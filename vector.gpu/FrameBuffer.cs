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
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    public enum FrameBufferReadTarget
    {
        Color   = Gl.GL_COLOR_BUFFER_BIT,
        Depth   = Gl.GL_DEPTH_BUFFER_BIT,
        Stencil = Gl.GL_STENCIL_BUFFER_BIT
    }

    public class FrameBuffer : IDisposable
    {
        private Device      device;
        private int         handle;
        private int         width;
        private int         height;
        
        public FrameBuffer(Device device)
        {
            this.device   = device;

            Gl.glGenFramebuffersEXT(1, out this.handle);
        }
        
        #region Properties
        /// <summary>
        /// The device for this framebuffer.
        /// </summary>
        public Device Device
        {
            get { return this.device; }
            set { this.device = value; }
        }
        /// <summary>
        /// The Handle to this framebuffer
        /// </summary>
        public int    Handle
        {
            get { return this.handle; }
            set { this.handle = value; }
        }
        #endregion

        
        /// <summary>
        /// Clears this FrameBuffer. Has the same effect as calling it on the device. Ensure you can called Begin on this framebuffer
        /// first.
        /// </summary>
        /// <param name="red"></param>
        /// <param name="blue"></param>
        /// <param name="green"></param>
        /// <param name="alpha"></param>
        public void Clear     (float red, float blue, float green, float alpha)
        {
            this.device.Clear(red, green, blue, alpha);
        }
        /// <summary>
        /// Begins a FrameBuffer Pass. Binds only a Color Buffer. 
        /// </summary>
        /// <param name="buffer"></param>
        public void Begin     (ColorBuffer colorBuffer, ViewPort viewPort)
        {
            Gl.glBindFramebufferEXT        (Gl.GL_FRAMEBUFFER_EXT, this.handle);

            Gl.glFramebufferRenderbufferEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_RENDERBUFFER_EXT, colorBuffer.Handle);

            this.CheckStatus(Gl.glCheckFramebufferStatusEXT(Gl.GL_FRAMEBUFFER_EXT));

            this.width  = colorBuffer.Width;

            this.height = colorBuffer.Height;
            
            Gl.glPushAttrib(Gl.GL_VIEWPORT_BIT);

            this.device.ViewPort = viewPort;
        }
        /// <summary>
        /// Begins a FrameBuffer Pass. Binds only a Color Buffer. The viewport is automatically ajusted to be
        /// width and height of the ColorBuffer.
        /// </summary>
        /// <param name="buffer"></param>
        public void Begin     (ColorBuffer colorBuffer)
        {
            this.Begin(colorBuffer, new ViewPort(0, 0, colorBuffer.Width, colorBuffer.Height));
        }
        /// <summary>
        /// Binds a ColorBuffer and Depth Buffer. A Frame Buffer "must" be bound with a depth buffer if you intend on
        /// rendering geometry with this FrameBuffer.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="depthBuffer"></param>
        public void Begin     (ColorBuffer colorBuffer,      DepthBuffer depthBuffer, ViewPort viewPort)
        {
            Gl.glBindFramebufferEXT        (Gl.GL_FRAMEBUFFER_EXT, this.handle);

            Gl.glFramebufferRenderbufferEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_RENDERBUFFER_EXT, colorBuffer.Handle);

            Gl.glFramebufferRenderbufferEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_DEPTH_ATTACHMENT_EXT, Gl.GL_RENDERBUFFER_EXT, depthBuffer.Handle);

            this.CheckStatus               (Gl.glCheckFramebufferStatusEXT(Gl.GL_FRAMEBUFFER_EXT));

            this.width = colorBuffer.Width;

            this.height = colorBuffer.Height;

            Gl.glPushAttrib(Gl.GL_VIEWPORT_BIT);

            this.device.ViewPort = viewPort;
        }
        /// <summary>
        /// Binds a ColorBuffer and Depth Buffer. A Frame Buffer "must" be bound with a depth buffer if you intend on
        /// rendering geometry with this FrameBuffer.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="depthBuffer"></param>
        public void Begin     (ColorBuffer colorBuffer,      DepthBuffer depthBuffer)
        {
            this.Begin(colorBuffer, depthBuffer, new ViewPort(0, 0, colorBuffer.Width, colorBuffer.Height));
        }
        /// <summary>
        /// Begins this Render Buffer with a Texture bound.  
        /// </summary>
        /// <param name="texture"></param>
        public void Begin     (Texture2D   colorTexture,     ViewPort viewPort)
        {
            Gl.glBindTexture            (Gl.GL_TEXTURE_2D, colorTexture.Handle);
            
            Gl.glBindFramebufferEXT     (Gl.GL_FRAMEBUFFER_EXT, this.handle);
            
            Gl.glFramebufferTexture2DEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_TEXTURE_2D, colorTexture.Handle, 0);

            this.CheckStatus(Gl.glCheckFramebufferStatusEXT(Gl.GL_FRAMEBUFFER_EXT));

            this.width  = colorTexture.Width;
            
            this.height = colorTexture.Height;

            Gl.glPushAttrib(Gl.GL_VIEWPORT_BIT);

            this.device.ViewPort = viewPort;
        }
        /// <summary>
        /// Begins a FrameBuffer Pass. Binds a Texture as a RenderTargets. Will automatically set the
        /// devices Viewport to match the dimensions of the Texture.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="depthBuffer"></param>
        public void Begin     (Texture2D   colorTexture)
        {
            this.Begin(colorTexture, new ViewPort(0, 0, colorTexture.Width, colorTexture.Height));
        }
        /// <summary>
        /// Begins this Render Buffer with a Texture bound. Depth Buffer is required if rendering Geometry.
        /// </summary>
        /// <param name="texture"></param>
        public void Begin     (Texture2D   colorTexture,     DepthBuffer depthBuffer, ViewPort viewPort)
        {
            Gl.glBindTexture               (Gl.GL_TEXTURE_2D, colorTexture.Handle);
            
            Gl.glBindFramebufferEXT        (Gl.GL_FRAMEBUFFER_EXT, this.handle);
            
            Gl.glFramebufferTexture2DEXT   (Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_TEXTURE_2D, colorTexture.Handle, 0);

            Gl.glFramebufferRenderbufferEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_DEPTH_ATTACHMENT_EXT, Gl.GL_RENDERBUFFER_EXT, depthBuffer.Handle);

            this.CheckStatus(Gl.glCheckFramebufferStatusEXT(Gl.GL_FRAMEBUFFER_EXT));

            this.width  = colorTexture.Width;
            
            this.height = colorTexture.Height;

            Gl.glPushAttrib(Gl.GL_VIEWPORT_BIT);

            this.device.ViewPort = viewPort;
        }
        /// <summary>
        /// Begins a FrameBuffer Pass. Binds a Texture and a DepthBuffer as the RenderTargets. Will automatically set the
        /// devices Viewport to match the dimensions of the Texture.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="depthBuffer"></param>
        public void Begin     (Texture2D   colorTexture,     DepthBuffer depthBuffer)
        {
            this.Begin(colorTexture, depthBuffer, new ViewPort(0, 0, colorTexture.Width, colorTexture.Height));
        }
        /// <summary>
        /// Begins a FrameBuffer Pass. Binds a CubeTexture as the RenderTargets. 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="depthBuffer"></param>
        public void Begin     (TextureCube colorTextureCube, TextureCubeFace face, ViewPort viewPort)
        {
            Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, this.handle);

            Gl.glFramebufferTexture2DEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, (int)face, colorTextureCube.Handle, 0);

            this.CheckStatus(Gl.glCheckFramebufferStatusEXT(Gl.GL_FRAMEBUFFER_EXT));

            Gl.glPushAttrib(Gl.GL_VIEWPORT_BIT);

            this.device.ViewPort = viewPort;
        }
        /// <summary>
        /// Begins a FrameBuffer Pass. Binds a CubeTexture as the RenderTarget. Will automatically set
        /// the Device's ViewPort to match the dimentions of the CubeTexture.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="face"></param>
        public void Begin     (TextureCube colorTextureCube, TextureCubeFace face)
        {
            this.Begin(colorTextureCube, face, new ViewPort(0, 0, colorTextureCube.Width, colorTextureCube.Width));
        }
        /// <summary>
        /// Begins a Texture Cube Rendering Pass.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="face"></param>
        public void Begin     (TextureCube colorTextureCube, DepthBuffer depthBuffer, TextureCubeFace face, ViewPort viewPort)
        {
            Gl.glBindFramebufferEXT        (Gl.GL_FRAMEBUFFER_EXT , this.handle);
 
            Gl.glFramebufferTexture2DEXT   (Gl.GL_FRAMEBUFFER_EXT , Gl.GL_COLOR_ATTACHMENT0_EXT, (int)face, colorTextureCube.Handle, 0);

            Gl.glFramebufferRenderbufferEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_DEPTH_ATTACHMENT_EXT, Gl.GL_RENDERBUFFER_EXT, depthBuffer.Handle);

            this.CheckStatus(Gl.glCheckFramebufferStatusEXT(Gl.GL_FRAMEBUFFER_EXT));
            
            Gl.glPushAttrib(Gl.GL_VIEWPORT_BIT);

            this.device.ViewPort = viewPort;
        }
        /// <summary>
        /// Begins a FrameBuffer Pass. Binds a CubeTexture and a DepthBuffer as the RenderTargets. Will automatically set the
        /// devices Viewport to match the dimensions of the Texture.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="depthBuffer"></param>
        public void Begin     (TextureCube colorTextureCube, DepthBuffer depthBuffer, TextureCubeFace face)
        {
            this.Begin(colorTextureCube, depthBuffer, face, new ViewPort(0, 0, colorTextureCube.Width, colorTextureCube.Width));
        }
        /// <summary>
        /// Begins Depth Render Pass. Depth Texture TextureFormat "should" be TextureFormat.Depth32
        /// </summary>
        /// <param name="buffer">Color Buffer Render Target</param>
        /// <param name="depthTexture">Depth Texture Render Target</param>
        /// <param name="depthTexture">The Viewport for this FrameBuffer.</param>
        public void BeginDepth(ColorBuffer colorBuffer,      Texture2D depthTexture, ViewPort viewPort)
        {
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, depthTexture.Handle);

            Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, this.handle);

            Gl.glFramebufferRenderbufferEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_RENDERBUFFER_EXT, colorBuffer.Handle);

            Gl.glFramebufferTexture2DEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_DEPTH_ATTACHMENT_EXT, Gl.GL_TEXTURE_2D, depthTexture.Handle, 0);

            this.CheckStatus(Gl.glCheckFramebufferStatusEXT(Gl.GL_FRAMEBUFFER_EXT));

            this.width = depthTexture.Width;

            this.height = depthTexture.Height;

            Gl.glPushAttrib(Gl.GL_VIEWPORT_BIT);

            this.device.ViewPort = viewPort;
        }
        /// <summary>
        /// Begins Depth Render Pass. Depth Texture TextureFormat "should" be TextureFormat.Depth32
        /// </summary>
        /// <param name="buffer">Color Buffer Render Target</param>
        /// <param name="depthTexture">Depth Texture Render Target</param>
        public void BeginDepth(ColorBuffer colorBuffer,      Texture2D depthTexture)
        {
            this.BeginDepth(colorBuffer, depthTexture, new ViewPort(0, 0, depthTexture.Width, depthTexture.Height));
        }
        /// <summary>
        /// Unbinds this FrameBuffer and returns rendering back to the main device.
        /// </summary>
        public void End       ()
        {
            Gl.glPopAttrib();

            Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, 0);
        }
        /// <summary>
        /// Reads from another Buffers output.
        /// </summary>
        /// <param name="frameBuffer"></param>
        public void Read      (FrameBuffer frameBuffer, FrameBufferReadTarget target)
        {
            Gl.glBindFramebufferEXT(Gl.GL_READ_FRAMEBUFFER_EXT, frameBuffer.Handle);
            
            Gl.glBindFramebufferEXT(Gl.GL_DRAW_FRAMEBUFFER_EXT, this.Handle);
             
            Gl.glBlitFramebufferEXT(0, 0, this.width, this.height, 0, 0, this.width, this.height, (int)target, Gl.GL_NEAREST);

            Gl.glBindFramebufferEXT(Gl.GL_READ_FRAMEBUFFER_EXT, 0);

            Gl.glBindFramebufferEXT(Gl.GL_DRAW_FRAMEBUFFER_EXT, 0);
        }
        
        #region Privates

        private void CheckStatus(int status)
        {
            switch (status)
            {
                case Gl.GL_FRAMEBUFFER_COMPLETE_EXT:

                    break;
                case Gl.GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT:
                    throw new Exception("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT\n");
                // break;
                case Gl.GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT:
                    throw new Exception("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT\n");
                // break;
                case Gl.GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT:
                    throw new Exception("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT\n");
                // break;
                case Gl.GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT:
                    throw new Exception("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT\n");
                //  break;
                case Gl.GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT:
                    throw new Exception("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT\n");
                //  break;
                case Gl.GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT:
                    throw new Exception("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT\n");
                // break;
                case Gl.GL_FRAMEBUFFER_UNSUPPORTED_EXT:

                    throw new Exception("GL_FRAMEBUFFER_UNSUPPORTED_EXT\n");
                //break;
                default:

                    throw new Exception("Unknown ERROR\n");

            }
        }

        #endregion

        #region IDisposable Members

        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!disposed)
                {
                    Gl.glDeleteFramebuffersEXT(1, ref this.handle);
                }
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        ~FrameBuffer()
        {
            this.Dispose(false);
        }

        #endregion
    }

  
}
