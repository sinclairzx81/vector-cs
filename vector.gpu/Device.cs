/* ===============================================================================  
 * Copyright (c) 2013 Vector by sinclair
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 * 
 * =============================================================================== */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using Vector.Math;
using Vector.Win32;
using System.Collections;
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    /// <summary>
    /// <para>
    /// A Windows Device
    /// </para>
    /// <para>
    /// A concrete class used specifically for windows. 
    /// </para>
    /// </summary>
    public class WindowsDevice : Device
    {
        protected Presentation           present;
        protected IntPtr                 hwnd;
        protected IntPtr                 hdc;
        protected IntPtr                 hrc;
 
        public WindowsDevice(IntPtr hwnd, Presentation present) : base()
        {
            this.present         = present;
            this.hwnd            = hwnd;
            this.hdc             = User.GetDC(this.hwnd);
            this.Create();
        }
        
        protected override void Create()
        {
           int pixelFormat = Gdi.ChoosePixelFormat(this.hdc, ref this.present.pfd);
           
            if (pixelFormat == 0)
            {
                this.Dispose();

                throw new Exception("Can't Find A Suitable PixelFormat.");
            }

            if (!Gdi.SetPixelFormat(this.hdc, pixelFormat, ref this.present.pfd))
            {
                this.Dispose();

                throw new Exception("Can't Set The PixelFormat.");
            }

            this.hrc = Wgl.wglCreateContext(this.hdc);

            if (this.hrc == IntPtr.Zero)
            {
                this.Dispose();

                throw new Exception("Can't Create A GL Rendering Context.");
            }

            if (!Wgl.wglMakeCurrent(this.hdc, this.hrc))
            {
                this.Dispose();

                throw new Exception("Can't Activate The GL Rendering Context.");
            }

            this.state = new State();

            
        }


     


        /// <summary>
        /// Presents the Current OpenGL framebuffer to the drawing surface
        /// </summary>
        public  override void Present()
        {
            Gdi.SwapBuffers(this.hdc);
        }
        

        private bool disposed = false;
        
        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (this.hrc != IntPtr.Zero)
                    {
                        if (!Wgl.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero))
                        {
                            throw new Exception("Release Of DC And RC Failed.");
                        }

                        if (!Wgl.wglDeleteContext(this.hrc))
                        {
                            throw new Exception("Release Rendering Context Failed.");
                        }

                        this.hrc = IntPtr.Zero;
                    }

                    if (this.hdc != IntPtr.Zero)
                    {
                        if (!User.ReleaseDC(this.hwnd, this.hdc))
                        {
                            throw new Exception("Release Device Context Failed.");
                        }

                        this.hdc = IntPtr.Zero;
                    }
                }

                this.disposed = true;
            }
        }
     
        public override void Dispose()
        {
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        ~WindowsDevice()
        {
            Dispose(false);
        }

        #region Utilities

        public void SaveBuffer(string filename, int x, int y, int width, int height, ImageFormat format)
        {
            Bitmap bitmap = new Bitmap(width, height);

            System.Drawing.Imaging.BitmapData data = bitmap.LockBits(new Rectangle(0, 0, width, height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            Gl.glCopyPixels(x, y, width, height, Gl.GL_COLOR);

            Gl.glReadPixels(x, y, width, height, Gl.GL_BGR, Gl.GL_UNSIGNED_BYTE, data.Scan0);

            bitmap.UnlockBits(data);

            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

            bitmap.Save(filename, format);

            bitmap.Dispose();
        }

        #endregion
    }

    /// <summary>
    /// Intended to aid in the management of multiple vertex
    /// streams passed to the device.
    /// </summary>
    internal class  VertexStream 
    {
        private VertexBuffer vertexBuffer;
        private bool         active;

        public VertexStream()
        {
            this.vertexBuffer = null;
            this.active       = false;
        }

        #region Properties

        public VertexBuffer VertexBuffer
        {
            get { return this.vertexBuffer; }
            set { this.vertexBuffer = value; }
        }

        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }

        #endregion
    }

    /// <summary>
    /// <para>
    /// Abstract class Device. 
    /// </para>
    /// <para>
    /// Contains Standard Rendering Methods and State Management. 
    /// </para>
    /// </summary>
    public abstract class Device : IDisposable
    {
        protected State              state;
        protected VertexDeclaration  vertexDeclaration;
        protected IndexBuffer        indexBuffer;
        protected TextureBase     [] textures;
        private   VertexStream    [] vertexStreams;
        

        public Device()
        {
            this.vertexStreams = new VertexStream[] {
                new VertexStream(),
                new VertexStream(),
                new VertexStream(),
                new VertexStream(),
                new VertexStream(),
                new VertexStream(),
                new VertexStream(),
            };

            this.textures      = new TextureBase[32]; // 32 Bindable textures 
        }

        #region Properties

        /// <summary>
        /// Gets and sets the ViewPort for this Device.
        /// </summary>
        public ViewPort      ViewPort
        {
            get
            {
                int[] data = new int[4];

                Gl.glGetIntegerv(Gl.GL_VIEWPORT, data);

                return new ViewPort(data[0], data[1], data[2], data[3]);

            }
            set
            {
                Gl.glViewport(value.X, value.Y, value.Width, value.Height);
            }
        }

        /// <summary>
        /// <para>Gets or Sets the IndexBuffer assoiciated with this Device.</para>
        /// </summary>
        public IndexBuffer   IndexBuffer
        {
            get { return this.indexBuffer; }
            set { this.indexBuffer = value; }
        }

        /// <summary>
        /// <para>Gets or Sets the Textures assoiciated with this Device.</para>
        /// <para>These Textures get bound when the Device.Draw method is called. 
        /// They are unbound at the end of that call</para>
        /// </summary>
        public TextureBase[] Texture
        {
            get { return this.textures; }
        }

        /// <summary>
        /// The State for this device. 
        /// </summary>
        public State State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        #endregion

        #region Pass Preperation

        private void EnableStates()
        {
            // Alpha Test
            if (this.state.AlphaTest) Gl.glEnable(Gl.GL_ALPHA_TEST);
            else  Gl.glDisable(Gl.GL_ALPHA_TEST); 

            // Depth Test
            if (this.state.DepthTest) Gl.glEnable(Gl.GL_DEPTH_TEST);
            else  Gl.glDisable(Gl.GL_DEPTH_TEST); 

            // Stencil Test
            if (this.state.StencilTest) Gl.glEnable(Gl.GL_STENCIL_TEST);
            else Gl.glDisable(Gl.GL_STENCIL_TEST); 

            // Culling On|Off
            if (this.state.Culling) Gl.glEnable(Gl.GL_CULL_FACE);
            else  Gl.glDisable(Gl.GL_CULL_FACE); 

            // Blending On|Off
            if (this.state.Blending) Gl.glEnable(Gl.GL_BLEND);
            else  Gl.glDisable(Gl.GL_BLEND); 

            // MultiSampling On|Off
            if (this.state.MultiSampling) Gl.glEnable(Gl.GL_MULTISAMPLE);
            else  Gl.glDisable(Gl.GL_MULTISAMPLE); 

            // Clip Plane 0
            if (this.state.ClipPlane0.Enabled)
            {
                Gl.glEnable(Gl.GL_CLIP_PLANE0);
                
                Gl.glClipPlane(Gl.GL_CLIP_PLANE0, new double[] { this.state.ClipPlane0.Plane.A, 
                                                                 this.state.ClipPlane0.Plane.B, 
                                                                 this.state.ClipPlane0.Plane.C, 
                                                                 this.state.ClipPlane0.Plane.D});
            }
            else  Gl.glDisable(Gl.GL_CLIP_PLANE0); 

            // Clip Plane 1
            if (this.state.ClipPlane1.Enabled) 
            {
                Gl.glEnable(Gl.GL_CLIP_PLANE1);
                
                Gl.glClipPlane(Gl.GL_CLIP_PLANE1, new double[] { this.state.ClipPlane1.Plane.A, 
                                                                 this.state.ClipPlane1.Plane.B, 
                                                                 this.state.ClipPlane1.Plane.C, 
                                                                 this.state.ClipPlane1.Plane.D});
            }
            else  Gl.glDisable(Gl.GL_CLIP_PLANE1); 

            // Clip Plane 2
            if (this.state.ClipPlane2.Enabled)
            {
                Gl.glEnable(Gl.GL_CLIP_PLANE2);
                
                Gl.glClipPlane(Gl.GL_CLIP_PLANE2, new double[] { this.state.ClipPlane2.Plane.A, 
                                                                 this.state.ClipPlane2.Plane.B, 
                                                                 this.state.ClipPlane2.Plane.C, 
                                                                 this.state.ClipPlane2.Plane.D});
            }
            else  Gl.glDisable(Gl.GL_CLIP_PLANE2); 

            // Clip Plane 3
            if (this.state.ClipPlane3.Enabled)
            {
                Gl.glEnable(Gl.GL_CLIP_PLANE3);
                
                Gl.glClipPlane(Gl.GL_CLIP_PLANE3, new double[] { this.state.ClipPlane3.Plane.A, 
                                                                 this.state.ClipPlane3.Plane.B, 
                                                                 this.state.ClipPlane3.Plane.C, 
                                                                 this.state.ClipPlane3.Plane.D});
            }
            else  Gl.glDisable(Gl.GL_CLIP_PLANE3); 

            // Clip Plane 4
            if (this.state.ClipPlane4.Enabled)
            {
                Gl.glEnable(Gl.GL_CLIP_PLANE4);
               
                Gl.glClipPlane(Gl.GL_CLIP_PLANE4, new double[] { this.state.ClipPlane4.Plane.A, 
                                                                 this.state.ClipPlane4.Plane.B, 
                                                                 this.state.ClipPlane4.Plane.C, 
                                                                 this.state.ClipPlane4.Plane.D});
            } 
            else  Gl.glDisable(Gl.GL_CLIP_PLANE4); 

            // Clip Plane 5
            if (this.state.ClipPlane5.Enabled)
            {
                Gl.glEnable(Gl.GL_CLIP_PLANE5);
               
                Gl.glClipPlane(Gl.GL_CLIP_PLANE5, new double[] { this.state.ClipPlane5.Plane.A, 
                                                                 this.state.ClipPlane5.Plane.B, 
                                                                 this.state.ClipPlane5.Plane.C, 
                                                                 this.state.ClipPlane5.Plane.D});
            }
            else Gl.glDisable(Gl.GL_CLIP_PLANE5);

            // Lighting
            if (this.state.Lighting) Gl.glEnable(Gl.GL_LIGHTING);
            else Gl.glDisable(Gl.GL_LIGHTING);
            
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            for (int i = 0; i < this.state.Lights.Length; i++)
            {
                if (this.state.Lights[i].Enabled)
                {
                    Gl.glEnable(Gl.GL_LIGHT0 + i);
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_POSITION,              new float[] { this.state.Lights[i].Position.X, this.state.Lights[i].Position.Y, this.state.Lights[i].Position.Z, this.state.Lights[i].Position.W});
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_AMBIENT,               new float[] { this.state.Lights[i].Ambient.X,  this.state.Lights[i].Ambient.Y, this.state.Lights[i].Ambient.Z,  this.state.Lights[i].Ambient.W});
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_DIFFUSE,               new float[] { this.state.Lights[i].Diffuse.X,  this.state.Lights[i].Diffuse.Y,  this.state.Lights[i].Diffuse.Z,  this.state.Lights[i].Diffuse.W});
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_SPECULAR,              new float[] { this.state.Lights[i].Specular.X,  this.state.Lights[i].Specular.Y,  this.state.Lights[i].Specular.Z, this.state.Lights[i].Specular.W});
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_SPOT_DIRECTION,        new float[] { this.state.Lights[i].SpotDirection.X, this.state.Lights[i].SpotDirection.Y, this.state.Lights[i].SpotDirection.Z});
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_SPOT_EXPONENT,         new float[] { this.state.Lights[i].SpotExponent});
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_SPOT_CUTOFF,           new float[] { this.state.Lights[i].SpotCutOff });
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_CONSTANT_ATTENUATION,  new float[] { this.state.Lights[i].ContstantAttenuation });
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_LINEAR_ATTENUATION,    new float[] { this.state.Lights[i].LinearAttenuation });
                    Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_QUADRATIC_ATTENUATION, new float[] { this.state.Lights[i].QuadraticAttenuation });
                }
                else Gl.glDisable(Gl.GL_LIGHT0 + i);
                
            }

            // Fog
        
            if (this.state.Fog.Enabled)
            {
                Gl.glEnable(Gl.GL_FOG);
                Gl.glFogi  (Gl.GL_FOG_MODE,    (int)this.state.Fog.Mode);		 
                Gl.glFogfv (Gl.GL_FOG_COLOR,   new float[] {this.state.Fog.Color.X, this.state.Fog.Color.Y, this.state.Fog.Color.Z, this.state.Fog.Color.W});			// Set Fog Color
                Gl.glFogf  (Gl.GL_FOG_DENSITY, this.state.Fog.Density);				 
                Gl.glFogf  (Gl.GL_FOG_START,   this.state.Fog.Start);				 
                Gl.glFogf  (Gl.GL_FOG_END,     this.state.Fog.End);				 
            }
            else Gl.glDisable(Gl.GL_FOG);

            // Device Hinting
            Gl.glHint(Gl.GL_POINT_SMOOTH_HINT,           (int)this.state.PointSmoothHint);
            
            Gl.glHint(Gl.GL_LINE_SMOOTH_HINT,            (int)this.state.LineSmoothHint);
            
            Gl.glHint(Gl.GL_POINT_SMOOTH_HINT,           (int)this.state.PolygonSmoothHint);
            
            Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, (int)this.state.PerspectiveCorrectionHint);

            // Additional
            Gl.glCullFace    ((int)this.state.CullFace);
            
            Gl.glPolygonMode ((int)this.state.PolygonMode.Face, (int)this.state.PolygonMode.RasterMode);
            
            Gl.glDepthFunc   ((int)this.state.DepthFunction.LogicOp);
            
            Gl.glAlphaFunc   ((int)this.state.AlphaFunction.LogicOp, this.state.AlphaFunction.Value);
            
            Gl.glBlendFunc   ((int)this.state.BlendFunction.Src,    (int)this.state.BlendFunction.Dst);
            
            Gl.glLineWidth   (this.state.LineWidth);


            // ModelView

            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            Gl.glLoadIdentity();

            Gl.glMultMatrixf((this.state.World * this.state.View).ToArray());

            // Projection
            Gl.glMatrixMode(Gl.GL_PROJECTION);

            Gl.glLoadIdentity();

            Gl.glMultMatrixf(this.state.Projection.ToArray());
        }

        private void EnableTextures()
        {
            for (int i = 0; i < this.textures.Length; i++)
            {
                TextureBase itexture = this.textures[i];

                if (itexture != null)
                {
                    if (itexture.GetType() == typeof(Texture2D))
                    {
                        Texture2D texture = (Texture2D)itexture;
                        Gl.glActiveTexture(Gl.GL_TEXTURE0 + i);
                        Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture.Handle);
                        Gl.glEnable(Gl.GL_TEXTURE_2D);
                    }
                    if (itexture.GetType() == typeof(TextureCube))
                    {
                        TextureCube cubetexture = (TextureCube)itexture;
                        Gl.glActiveTexture(Gl.GL_TEXTURE0 + i);
                        Gl.glBindTexture(Gl.GL_TEXTURE_CUBE_MAP, cubetexture.Handle);
                        Gl.glEnable(Gl.GL_TEXTURE_CUBE_MAP);
                    }
                }
            }
        }
        
        private void EnableVertexDeclaration()
        {
            #region Enable Array State

            foreach (VertexStream vertexStream in this.vertexStreams)
            {
                if(vertexStream.Active)
                {
                    foreach (VertexElement element in vertexStream.VertexBuffer.VertexDeclaration.Elements)
                    {
                        switch (element.ElementBinding)
                        {
                            case ElementBinding.Vertex:
                                Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY);
                                break;
                            case ElementBinding.Normal:
                                Gl.glEnableClientState(Gl.GL_NORMAL_ARRAY);
                                break;
                            case ElementBinding.Color:
                                Gl.glEnableClientState(Gl.GL_COLOR_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord0:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE0);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord1:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE1);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord2:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE2);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord3:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE3);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord4:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE4);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord5:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE5);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord6:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE6);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord7:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE7);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord8:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE8);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord9:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE9);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord10:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE10);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord11:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE11);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord12:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE12);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord13:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE13);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord14:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE14);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord15:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE15);
                                Gl.glEnableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                        }
                    }
                }
            }
            
            #endregion

            #region Enable Vertex Buffers


            foreach (VertexStream vertexStream in this.vertexStreams)
            {
                if (vertexStream.Active)
                {
                    Gl.glBindBuffer(Gl.GL_ARRAY_BUFFER, vertexStream.VertexBuffer.Handle);

                    foreach (VertexElement element in vertexStream.VertexBuffer.VertexDeclaration.Elements)
                    {
                        switch (element.ElementBinding)
                        {
                            case ElementBinding.Vertex:
                                Gl.glVertexPointer((int)element.TypeCount,
                                                   (int)element.ElementType,
                                                   (int)element.Stride,
                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.Normal:
                                Gl.glNormalPointer((int)element.ElementType,
                                                   (int)element.Stride,
                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.Color:
                                Gl.glColorPointer((int)element.TypeCount,
                                                  (int)element.ElementType,
                                                  (int)element.Stride,
                                                  (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord0:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE0);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                 (int)element.ElementType,
                                                                 (int)element.Stride,
                                                                 (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord1:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE1);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                 (int)element.ElementType,
                                                                 (int)element.Stride,
                                                                 (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord2:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE2);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord3:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE3);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord4:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE4);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord5:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE5);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord6:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE6);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                  (int)element.ElementType,
                                                                  (int)element.Stride,
                                                                  (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord7:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE7);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord8:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE8);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord9:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE9);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord10:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE10);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord11:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE11);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord12:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE12);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord13:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE13);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord14:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE14);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                            case ElementBinding.MultiTexCoord15:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE15);
                                Gl.glTexCoordPointer((int)element.TypeCount,
                                                                   (int)element.ElementType,
                                                                   (int)element.Stride,
                                                                   (IntPtr)element.Ordinal);
                                break;
                        }
                    }
                }
            }



            #endregion
        }
        
        private void DisableTextures()
        {
            for (int i = 0; i < this.textures.Length; i++)
            {
                TextureBase itexture = this.textures[i];

                if (itexture != null)
                {
                    if (itexture.GetType() == typeof(Texture2D))
                    {
                        Gl.glActiveTexture(Gl.GL_TEXTURE0 + i);
                        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0);
                        Gl.glDisable(Gl.GL_TEXTURE_2D);

                    }
                    if (itexture.GetType() == typeof(TextureCube))
                    {
                        Gl.glActiveTexture(Gl.GL_TEXTURE0 + i);
                        Gl.glBindTexture(Gl.GL_TEXTURE_CUBE_MAP, 0);
                        Gl.glDisable(Gl.GL_TEXTURE_CUBE_MAP);
                    }
                    itexture = null;
                }
            }
        }
        
        private void DisableVertexDeclaration()
        {
            foreach (VertexStream vertexStream in this.vertexStreams)
            {
                if (vertexStream.Active)
                {
                    vertexStream.Active = false;

                    foreach (VertexElement element in vertexStream.VertexBuffer.VertexDeclaration.Elements)
                    {
                        switch (element.ElementBinding)
                        {
                            case ElementBinding.Vertex:
                                Gl.glDisableClientState(Gl.GL_VERTEX_ARRAY);
                                break;
                            case ElementBinding.Normal:
                                Gl.glDisableClientState(Gl.GL_NORMAL_ARRAY);
                                break;
                            case ElementBinding.Color:
                                Gl.glDisableClientState(Gl.GL_COLOR_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord0:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE0);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord1:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE1);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord2:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE2);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord3:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE3);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord4:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE4);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord5:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE5);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord6:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE6);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord7:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE7);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord8:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE8);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord9:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE9);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord10:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE10);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord11:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE11);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord12:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE12);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord13:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE13);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord14:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE14);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                            case ElementBinding.MultiTexCoord15:
                                Gl.glClientActiveTexture(Gl.GL_TEXTURE15);
                                Gl.glDisableClientState(Gl.GL_TEXTURE_COORD_ARRAY);
                                break;
                        }
                    }
                }
            }
        }
        
        #endregion

        #region Renderables
        
        /// <summary>
        /// Clears the FrameBuffer. 
        /// </summary>
        /// <param name="flags"></param>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="alpha"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        public void Clear    (ClearFlags flags, float red, float green, float blue, float alpha, float depth, int stencil)
        {
            Gl.glClearColor(red, green, blue, alpha);

            Gl.glClearDepth(depth);

            Gl.glClearStencil(stencil);

            Gl.glClear((int)flags);
        }    
        /// <summary>
        /// <para>Clears the FrameBuffer.</para>
        /// <para>(Automatically Clears the Depth Buffer Bit, Stencil Color Bit and the Color Bit)</para>
        /// </summary>
        /// <param name="flags"></param>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="alpha"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        public void Clear    (float red, float green, float blue, float alpha)
        {
            Gl.glClearColor(red, green, blue, alpha);

            Gl.glClearDepth  (1.0f);

            Gl.glClearStencil(1);

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT | Gl.GL_STENCIL_BUFFER_BIT);
        }
        /// <summary>
        /// Clears the FrameBuffer
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="alpha"></param>
        public void Clear    (Color color)
        {
            Gl.glClearColor((float)color.R / 255, 
                            (float)color.G / 255, 
                            (float)color.B / 255, 
                            (float)color.A / 255);

            Gl.glClearDepth(1.0f);

            Gl.glClearStencil(1);

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT | Gl.GL_STENCIL_BUFFER_BIT);
        }
      
        /// <summary>
        /// <para>Draws the currently bound source objects associated with this device.</para>
        /// <para>A valid VertexDeclaration, VertexBuffer, IndexBuffer and Optional Texture 
        /// must be bound before calling this method.</para>
        /// </summary>
        /// <param name="topology"></param>
        public void Draw     (Topology topology)
        {
            this.EnableStates();

            this.EnableTextures();
            
            this.EnableVertexDeclaration();

            if (this.indexBuffer != null)
            {
                Gl.glBindBuffer(Gl.GL_ELEMENT_ARRAY_BUFFER, this.indexBuffer.Handle);

                Gl.glDrawElements((int)topology, this.indexBuffer.Count, Gl.GL_UNSIGNED_INT, (IntPtr)0);
            }

            this.DisableVertexDeclaration();
            
            this.DisableTextures();
        }

        /// <summary>
        /// <para>Only Availible on NVidia 8800's (Time of writing).</para> 
        /// <para>Draws buffers as instanced. Primitive
        /// Count refers to the amount of times the object is drawn. inside a shader. 
        /// The instance can be looked up via the gl_InstanceId sematic.</para>
        /// </summary>
        /// <param name="topology"></param>
        /// <param name="primitiveCount"></param>
        public void DrawInstanced(Topology topology, int primitiveCount)
        {
            this.EnableTextures();

            this.EnableVertexDeclaration();

            Gl.glBindBuffer(Gl.GL_ELEMENT_ARRAY_BUFFER, this.indexBuffer.Handle);

            

            Gl.glDrawElementsInstancedEXT((int)topology, this.indexBuffer.Count, Gl.GL_UNSIGNED_INT, (IntPtr)0, primitiveCount);

            this.DisableVertexDeclaration();

            this.DisableTextures();
        }
        
        #endregion

        #region Methods
        /// <summary>
        /// Sets the Vertex Buffer for a given rendering pass.
        /// </summary>
        /// <param name="streamIndex"></param>
        /// <param name="vertexBuffer"></param>
        public void SetVertexBuffer(int streamIndex, VertexBuffer vertexBuffer)
        {
            this.vertexStreams[streamIndex].VertexBuffer = vertexBuffer;

            this.vertexStreams[streamIndex].Active = true;
        }

        #endregion


        #region Query Methods

        public string [] GetExtensions()
        {
            return Gl.glGetString(Gl.GL_EXTENSIONS).Split(new char[] {' '});
        }

        #endregion

        protected abstract void Create();
       
        /// <summary>
        /// Presents the Current OpenGL framebuffer to the drawing surface
        /// </summary>
        public    abstract void Present();
        
        /// <summary>
        /// Disposes this Object
        /// </summary>
        public    abstract void Dispose();
    }
}
