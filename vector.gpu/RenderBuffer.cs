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
using System.Linq;
using System.Text;
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    /// <summary>
    /// Vector.Graphics.RenderBuffer. 
    /// </summary>
    public class RenderBuffer : IDisposable 
    {
        private Device device;
        private int    handle;
        private int    width;
        private int    height;
        private int    samples;
        public RenderBuffer(Device device, int width, int height) : this(device, width, height, 1) { }
        public RenderBuffer(Device device, int width, int height, int samples)
        {
            this.device  = device;
            this.width   = width;
            this.height  = height;
            this.samples = samples;

            Gl.glGenRenderbuffersEXT(1, out this.handle);
        }
        #region Properties
        /// <summary>
        /// The device for this render buffer.
        /// </summary>
        public Device Device
        {
            get { return this.device; }
            set { this.device = value; }
        }
        /// <summary>
        /// The handle to this render buffer.
        /// </summary>
        public int Handle
        {
            get { return this.handle; }
            set { this.handle = value; }
        }
        /// <summary>
        /// The width of this render buffer
        /// </summary>
        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        // The height of this render buffer
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        /// <summary>
        /// The Sampling on this Render Buffer.
        /// </summary>
        public int Samples
        {
            get { return this.samples; }
            set { this.samples = value; }
        }

        #endregion

        #region IDisposable Members

        private bool disposed = false;

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!disposed)
                {
                    Gl.glDeleteRenderbuffersEXT(1, ref this.handle);

                    this.disposed = true;
                }
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        ~RenderBuffer()
        {
            this.Dispose(false);
        }


        #endregion
    }
    /// <summary>
    /// Color Buffer Render Target
    /// </summary>
    public class ColorBuffer  : RenderBuffer
    {
        private TextureFormat format;
        
        public ColorBuffer(Device device, int width, int height, TextureFormat format) : this(device, width, height, format, 0) { }
        
        public ColorBuffer(Device device, int width, int height, TextureFormat format, int samples) : base(device, width, height, samples)
        {
            this.format = format;
            
            Gl.glBindRenderbufferEXT              (Gl.GL_RENDERBUFFER_EXT, this.Handle);

            if (samples == 0)
            {
                Gl.glRenderbufferStorageEXT(Gl.GL_RENDERBUFFER_EXT, (int)format, this.Width, this.Height);
            }
            else
            {
                Gl.glRenderbufferStorageMultisampleEXT(Gl.GL_RENDERBUFFER_EXT, this.Samples, (int)this.format, this.Width, this.Height);
            }
        }

        #region Properties

        public TextureFormat Format
        {
            get { return this.format; }
            set { this.format = value; }
        }

        #endregion
    }
    /// <summary>
    /// Depth Buffer Render Target
    /// </summary>
    public class DepthBuffer  : RenderBuffer
    {
        public Depth depth;

        public DepthBuffer(Device device, int width, int height, Depth depth) : this(device, width, height, depth, 0) { }
       
        public DepthBuffer(Device device, int width, int height, Depth depth, int samples) : base(device, width, height, samples)
        {
            this.depth = depth;

            Gl.glBindRenderbufferEXT              (Gl.GL_RENDERBUFFER_EXT, this.Handle);

            if (samples == 0)
            {
                Gl.glRenderbufferStorageEXT(Gl.GL_RENDERBUFFER_EXT, (int)this.depth, this.Width, this.Height);
            }
            else
            {
                Gl.glRenderbufferStorageMultisampleEXT(Gl.GL_RENDERBUFFER_EXT, this.Samples, (int)this.depth, this.Width, this.Height);
            }
        }

        #region Properties

        public Depth Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }

        #endregion
    }

    
}
