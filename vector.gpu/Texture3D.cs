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
    /// A 3 Dimentional Texture.
    /// </summary>
    public class Texture3D : TextureBase 
    {
        private int           width;
        private int           height;
        private int           depth;

        private Texture3D() : base() { }
        
        public Texture3D (Device device, int width, int height, int depth, TextureFormat format) : this(device, width, height, depth, 0, format) { }
       
        public Texture3D (Device device, int width, int height, int depth, int border, TextureFormat format)
        {
            this.device         = device;
            this.internalFormat = format;
            this.baseformat     = this.GetBaseFormat(this.internalFormat);
            this.type           = this.GetBaseType(this.internalFormat);
            this.width          = width;
            this.height         = height;
            this.depth          = depth;

            Gl.glGenTextures(1, out this.handle);
            Gl.glBindTexture(Gl.GL_TEXTURE_3D, this.handle);
            Gl.glTexImage3D(Gl.GL_TEXTURE_3D, 0, (int)this.internalFormat,
                                                 (int)this.width,
                                                 (int)this.height,
                                                 (int)this.depth, 0,
                                                 (int)this.baseformat,
                                                 (int)this.type,
                                                 IntPtr.Zero);
            Gl.glTexParameteri(Gl.GL_TEXTURE_3D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);
            Gl.glTexParameteri(Gl.GL_TEXTURE_3D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);
            Gl.glBindTexture(Gl.GL_TEXTURE_3D, 0);
        }

        #region Factory Methods

        public static Texture3D Empty(Device device, int width, int height, int depth, TextureFormat format)
        {
            return new Texture3D(device, width, height, depth, 0, format);
        }

        public static Texture3D Empty(Device device, int width, int height, int depth, int border, TextureFormat format)
        {
            return new Texture3D(device, width, height, depth, border, format);
        }

        #endregion

        #region Properties

        public int Width
        {
            get { return this.width; }
        }
        public int Height
        {
            get { return this.height; }
        }
        public int Depth
        {
            get { return this.depth; }
        }

        #endregion

        #region ITexture Members

        public override TextureFilter MinFilter
        {
            get
            {
                return base.minFilter;
            }
            set
            {
                this.minFilter = value;
                Gl.glBindTexture  (Gl.GL_TEXTURE_3D, this.handle);
                Gl.glTexParameteri(Gl.GL_TEXTURE_3D, Gl.GL_TEXTURE_MIN_FILTER, (int)value);
                Gl.glBindTexture  (Gl.GL_TEXTURE_3D, 0);
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
                this.magFilter = value;
                Gl.glBindTexture  (Gl.GL_TEXTURE_3D, this.handle);
                Gl.glTexParameteri(Gl.GL_TEXTURE_3D, Gl.GL_TEXTURE_MAG_FILTER, (int)value);
                Gl.glBindTexture  (Gl.GL_TEXTURE_3D, 0);
            }
        }

        public void SetData<T>(T[] data)
        {
            Gl.glBindTexture(Gl.GL_TEXTURE_3D, this.handle);

            Gl.glTexImage3D(Gl.GL_TEXTURE_3D, 0,
                            (int)this.internalFormat,
                            (int)this.width,
                            (int)this.height,
                            (int)this.depth,
                            0,
                            (int)this.baseformat,
                            (int)this.type,
                            data);

            Gl.glBindTexture(Gl.GL_TEXTURE_3D, 0);
        }
        
        public T [] GetData<T>()
        {
            T [] data = new T[((this.width * this.height) * this.depth) * GetBaseSize(this.internalFormat)];

            Gl.glBindTexture(Gl.GL_TEXTURE_3D, this.handle);

            Gl.glGetTexImage(Gl.GL_TEXTURE_3D, 0, (int)this.baseformat, (int)this.type, data);

            Gl.glBindTexture(Gl.GL_TEXTURE_3D, 0);

            return data;
        }

        #endregion

        
       
    }
}
