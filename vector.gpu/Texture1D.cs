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
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    /// <summary>
    /// A 1 Dimentional Texture
    /// </summary>
    public class Texture1D : TextureBase 
    {
        private int           width;

        private Texture1D() : base() { }

        public  Texture1D (Device device, int width, TextureFormat format)
        {
            this.device         = device;
            
            this.internalFormat = format;
            
            this.type           = this.GetBaseType(format);
            
            this.baseformat     = this.GetBaseFormat(format);
            
            this.width          = width;

            Gl.glGenTextures(1, out this.handle);
            
            Gl.glBindTexture(Gl.GL_TEXTURE_1D, this.handle);
            
            Gl.glTexImage1D(Gl.GL_TEXTURE_1D, 0, (int)this.internalFormat,
                                                 (int)this.width,
                                                 0,
                                                 (int)this.baseformat,
                                                 (int)this.type,
                                                 IntPtr.Zero);

            Gl.glTexParameteri(Gl.GL_TEXTURE_1D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);

            Gl.glTexParameteri(Gl.GL_TEXTURE_1D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);

            Gl.glBindTexture(Gl.GL_TEXTURE_1D, 0);

         
        }

        #region Factory Methods
        /// <summary>
        /// Creates a Texture1D with this width and format. 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="width"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static Texture1D Empty(Device device, int width, TextureFormat format)
        {
            return new Texture1D(device, width, format);
        }
        #endregion

        #region Properties

        public int           Width
        {
            get { return this.width; }
        }

        #endregion

        #region ITexture Members
        public override TextureFilter MinFilter
        {
            get
            {
                return this.minFilter;
            }
            set
            {
                base.minFilter = value;
                Gl.glBindTexture(Gl.GL_TEXTURE_1D, this.handle);
                Gl.glTexParameteri(Gl.GL_TEXTURE_1D, Gl.GL_TEXTURE_MIN_FILTER, (int)value);
                Gl.glBindTexture(Gl.GL_TEXTURE_1D, 0);
            }
        }
        public override TextureFilter MagFilter
        {
            get
            {
                return this.magFilter;
            }
            set
            {
                base.magFilter = value;
                Gl.glBindTexture(Gl.GL_TEXTURE_1D, this.handle);
                Gl.glTexParameteri(Gl.GL_TEXTURE_1D, Gl.GL_TEXTURE_MAG_FILTER, (int)value);
                Gl.glBindTexture(Gl.GL_TEXTURE_1D, 0);
            }
        }
        public void SetData <T> (T [] data)
        {
            Gl.glBindTexture(Gl.GL_TEXTURE_1D, this.handle);
            
            Gl.glTexImage1D(Gl.GL_TEXTURE_1D, 0,
                           (int)this.internalFormat,
                           (int)this.width,
                           0,
                           (int)this.baseformat,
                           (int)this.type,
                           data);

            Gl.glBindTexture(Gl.GL_TEXTURE_1D, 0);
        }
        public T [] GetData <T> ()
        {
            T [] data = new T[(this.width) * GetBaseSize(this.internalFormat)];

            Gl.glBindTexture(Gl.GL_TEXTURE_1D, this.handle);

            Gl.glGetTexImage(Gl.GL_TEXTURE_1D, 0, (int)this.baseformat, (int)this.type, data);

            Gl.glBindTexture(Gl.GL_TEXTURE_1D, 0);

            return data;
        }
        #endregion
    }
}
