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
using System.Text;
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    /// <summary>
    /// Abstract base class for all textures.
    /// </summary>
    public abstract class TextureBase: IResource
    {
        protected Device        device;
        protected int           handle;
        protected TextureFormat internalFormat;
        protected ElementType   type;
        protected int           baseformat;
        protected TextureFilter minFilter;
        protected TextureFilter magFilter;

        public TextureBase()
        {
            this.minFilter = TextureFilter.Linear;
            this.magFilter = TextureFilter.Linear;
        }

        #region Properties

        public Device Device
        {
            get { return this.device; }
        }

        public TextureFormat Format
        {
            get { return this.internalFormat; }
        }

        public int Handle
        {
            get { return this.handle; }
            set { this.handle = value; }
        }

        #endregion

        #region Virtual

        public abstract TextureFilter MinFilter { get; set; }

        public abstract TextureFilter MagFilter { get; set; }

        #endregion

        #region Formats
        protected ElementType GetBaseType(TextureFormat format)
        {
            ElementType type = ElementType.UByte;
            switch (format)
            {
                case TextureFormat.ALPHA4:              type = ElementType.UByte; break;
                case TextureFormat.ALPHA8:              type = ElementType.UByte; break;
                case TextureFormat.ALPHA12:             type = ElementType.Float; break;
                case TextureFormat.ALPHA16:             type = ElementType.Float; break;
                case TextureFormat.ALPHA32:             type = ElementType.Float; break;
                case TextureFormat.INTENSITY4:          type = ElementType.UByte; break;
                case TextureFormat.INTENSITY8:          type = ElementType.UByte; break;
                case TextureFormat.INTENSITY12:         type = ElementType.Float; break;
                case TextureFormat.INTENSITY16:         type = ElementType.Float; break;
                case TextureFormat.INTENSITY32:         type = ElementType.Float; break;
                case TextureFormat.LUMINANCE4:          type = ElementType.UByte; break;
                case TextureFormat.LUMINANCE8:          type = ElementType.UByte; break;
                case TextureFormat.LUMINANCE12:         type = ElementType.Float; break;
                case TextureFormat.LUMINANCE16:         type = ElementType.Float; break;
                case TextureFormat.LUMINANCE32:         type = ElementType.Float; break;
                case TextureFormat.LUMINANCE4_ALPHA4:   type = ElementType.UByte; break;
                case TextureFormat.LUMINANCE6_ALPHA2:   type = ElementType.UByte; break;
                case TextureFormat.LUMINANCE8_ALPHA8:   type = ElementType.UByte; break;
                case TextureFormat.LUMINANCE12_ALPHA4:  type = ElementType.Float; break;
                case TextureFormat.LUMINANCE16_ALPHA16: type = ElementType.Float; break;
                case TextureFormat.LUMINANCE32_ALPHA32: type = ElementType.Float; break;
                case TextureFormat.R3_G3_B2:            type = ElementType.UByte; break;
                case TextureFormat.RGB5:                type = ElementType.UByte; break;
                case TextureFormat.RGB8:                type = ElementType.UByte; break;
                case TextureFormat.RGB10:               type = ElementType.Float; break;
                case TextureFormat.RGB12:               type = ElementType.Float; break;
                case TextureFormat.RGB16:               type = ElementType.Float; break;
                case TextureFormat.RGB32:               type = ElementType.Float; break;
                case TextureFormat.RGBA2:               type = ElementType.UByte; break;
                case TextureFormat.RGBA4:               type = ElementType.UByte; break;
                case TextureFormat.RGBA8:               type = ElementType.UByte; break;
                case TextureFormat.RGBA12:              type = ElementType.Float; break;
                case TextureFormat.RGBA16:              type = ElementType.Float; break;
                case TextureFormat.RGBA32:              type = ElementType.Float; break;
                case TextureFormat.RGB5_A1:             type = ElementType.UByte; break;
                case TextureFormat.RGB10_A2:            type = ElementType.Float; break;
                case TextureFormat.DEPTH16:             type = ElementType.UByte; break;
                case TextureFormat.DEPTH24:             type = ElementType.UByte; break;
                case TextureFormat.DEPTH32:             type = ElementType.UByte; break;
            }
            return type;
        }
        protected int GetBaseSize(TextureFormat format)
        {
            int size = 0;
            switch (format)
            {
                case TextureFormat.ALPHA4:              size = 1; break;
                case TextureFormat.ALPHA8:              size = 1; break;
                case TextureFormat.ALPHA12:             size = 1; break;
                case TextureFormat.ALPHA16:             size = 1; break;
                case TextureFormat.ALPHA32:             size = 1; break;
                case TextureFormat.INTENSITY4:          size = 1; break;
                case TextureFormat.INTENSITY8:          size = 1; break;
                case TextureFormat.INTENSITY12:         size = 1; break;
                case TextureFormat.INTENSITY16:         size = 1; break;
                case TextureFormat.INTENSITY32:         size = 1; break;
                case TextureFormat.LUMINANCE4:          size = 1; break;
                case TextureFormat.LUMINANCE8:          size = 1; break;
                case TextureFormat.LUMINANCE12:         size = 1; break;
                case TextureFormat.LUMINANCE16:         size = 1; break;
                case TextureFormat.LUMINANCE32:         size = 1; break;
                case TextureFormat.LUMINANCE4_ALPHA4:   size = 2; break;
                case TextureFormat.LUMINANCE6_ALPHA2:   size = 2; break;
                case TextureFormat.LUMINANCE8_ALPHA8:   size = 2; break;
                case TextureFormat.LUMINANCE12_ALPHA4:  size = 2; break;
                case TextureFormat.LUMINANCE16_ALPHA16: size = 2; break;
                case TextureFormat.LUMINANCE32_ALPHA32: size = 2; break;
                case TextureFormat.R3_G3_B2:            size = 3; break;
                case TextureFormat.RGB5:                size = 3; break;
                case TextureFormat.RGB8:                size = 3; break;
                case TextureFormat.RGB10:               size = 3; break;
                case TextureFormat.RGB12:               size = 3; break;
                case TextureFormat.RGB16:               size = 3; break;
                case TextureFormat.RGB32:               size = 3; break;
                case TextureFormat.RGBA2:               size = 4; break;
                case TextureFormat.RGBA4:               size = 4; break;
                case TextureFormat.RGBA8:               size = 4; break;
                case TextureFormat.RGBA12:              size = 4; break;
                case TextureFormat.RGBA16:              size = 4; break;
                case TextureFormat.RGBA32:              size = 4; break;
                case TextureFormat.RGB5_A1:             size = 4; break;
                case TextureFormat.RGB10_A2:            size = 4; break;
                case TextureFormat.DEPTH16:             size = Gl.GL_DEPTH_COMPONENT; break;
                case TextureFormat.DEPTH24:             size = Gl.GL_DEPTH_COMPONENT; break;
                case TextureFormat.DEPTH32:             size = Gl.GL_DEPTH_COMPONENT; break;
            }
            return size;
        }
        protected int GetBaseFormat(TextureFormat format)
        {
            int baseformat = 0;
            switch (format)
            {
                case TextureFormat.ALPHA4:              baseformat = Gl.GL_ALPHA; break;
                case TextureFormat.ALPHA8:              baseformat = Gl.GL_ALPHA; break;
                case TextureFormat.ALPHA12:             baseformat = Gl.GL_ALPHA; break;
                case TextureFormat.ALPHA16:             baseformat = Gl.GL_ALPHA; break;
                case TextureFormat.ALPHA32:             baseformat = Gl.GL_ALPHA; break;
                case TextureFormat.INTENSITY4:          baseformat = Gl.GL_INTENSITY; break;
                case TextureFormat.INTENSITY8:          baseformat = Gl.GL_INTENSITY; break;
                case TextureFormat.INTENSITY12:         baseformat = Gl.GL_INTENSITY; break;
                case TextureFormat.INTENSITY16:         baseformat = Gl.GL_INTENSITY; break;
                case TextureFormat.INTENSITY32:         baseformat = Gl.GL_INTENSITY; break;
                case TextureFormat.LUMINANCE4:          baseformat = Gl.GL_LUMINANCE; break;
                case TextureFormat.LUMINANCE8:          baseformat = Gl.GL_LUMINANCE; break;
                case TextureFormat.LUMINANCE12:         baseformat = Gl.GL_LUMINANCE; break;
                case TextureFormat.LUMINANCE16:         baseformat = Gl.GL_LUMINANCE; break;
                case TextureFormat.LUMINANCE32:         baseformat = Gl.GL_LUMINANCE; break;
                case TextureFormat.LUMINANCE4_ALPHA4:   baseformat = Gl.GL_LUMINANCE_ALPHA; break;
                case TextureFormat.LUMINANCE6_ALPHA2:   baseformat = Gl.GL_LUMINANCE_ALPHA; break;
                case TextureFormat.LUMINANCE8_ALPHA8:   baseformat = Gl.GL_LUMINANCE_ALPHA; break;
                case TextureFormat.LUMINANCE12_ALPHA4:  baseformat = Gl.GL_LUMINANCE_ALPHA; break;
                case TextureFormat.LUMINANCE16_ALPHA16: baseformat = Gl.GL_LUMINANCE_ALPHA; break;
                case TextureFormat.LUMINANCE32_ALPHA32: baseformat = Gl.GL_LUMINANCE_ALPHA; break;
                case TextureFormat.R3_G3_B2:            baseformat = Gl.GL_RGB; break;
                case TextureFormat.RGB5:                baseformat = Gl.GL_RGB; break;
                case TextureFormat.RGB8:                baseformat = Gl.GL_RGB; break;
                case TextureFormat.RGB10:               baseformat = Gl.GL_RGB; break;
                case TextureFormat.RGB12:               baseformat = Gl.GL_RGB; break;
                case TextureFormat.RGB16:               baseformat = Gl.GL_RGB; break;
                case TextureFormat.RGB32:               baseformat = Gl.GL_RGB; break;
                case TextureFormat.RGBA2:               baseformat = Gl.GL_RGBA; break;
                case TextureFormat.RGBA4:               baseformat = Gl.GL_RGBA; break;
                case TextureFormat.RGBA8:               baseformat = Gl.GL_RGBA; break;
                case TextureFormat.RGBA12:              baseformat = Gl.GL_RGBA; break;
                case TextureFormat.RGBA16:              baseformat = Gl.GL_RGBA; break;
                case TextureFormat.RGBA32:              baseformat = Gl.GL_RGBA; break;
                case TextureFormat.RGB5_A1:             baseformat = Gl.GL_RGBA; break;
                case TextureFormat.RGB10_A2:            baseformat = Gl.GL_RGBA; break;
                case TextureFormat.DEPTH16:             baseformat = Gl.GL_DEPTH_COMPONENT; break;
                case TextureFormat.DEPTH24:             baseformat = Gl.GL_DEPTH_COMPONENT; break;
                case TextureFormat.DEPTH32:             baseformat = Gl.GL_DEPTH_COMPONENT; break;
                    
            }
            return baseformat;
        }
        #endregion

        #region IDisposable Members

        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Gl.glDeleteTextures(1, ref this.handle);
                }

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        ~TextureBase()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
