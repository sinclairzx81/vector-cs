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
using System.Drawing;
using System.Drawing.Imaging;
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    public class TextureCube : TextureBase
    {
        private int           width;

        private TextureCube() : base() { }

        public TextureCube(Device device, int width, int border, TextureFormat format)
        {
            this.device              = device;
            this.internalFormat      = format;
            this.type                = this.GetBaseType   (this.internalFormat);
            this.baseformat          = this.GetBaseFormat (this.internalFormat);
            this.width               = width;

            Gl.glGenTextures(1, out this.handle);
            Gl.glBindTexture  (Gl.GL_TEXTURE_CUBE_MAP, this.handle);
            Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);
            Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);
            Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_WRAP_T, Gl.GL_CLAMP_TO_EDGE);
            Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_WRAP_S, Gl.GL_CLAMP_TO_EDGE);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_X, 0, (int)this.internalFormat, this.width, this.width, border, (int)this.baseformat, (int)this.type, IntPtr.Zero);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 0, (int)this.internalFormat, this.width, this.width, border, (int)this.baseformat, (int)this.type, IntPtr.Zero);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 0, (int)this.internalFormat, this.width, this.width, border, (int)this.baseformat, (int)this.type, IntPtr.Zero);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, 0, (int)this.internalFormat, this.width, this.width, border, (int)this.baseformat, (int)this.type, IntPtr.Zero);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 0, (int)this.internalFormat, this.width, this.width, border, (int)this.baseformat, (int)this.type, IntPtr.Zero);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, 0, (int)this.internalFormat, this.width, this.width, border, (int)this.baseformat, (int)this.type, IntPtr.Zero);
            Gl.glBindTexture(Gl.GL_TEXTURE_CUBE_MAP, 0);
        }

        #region Factory

        public static TextureCube FromBitmap(Device device, Bitmap px, Bitmap py, Bitmap pz, Bitmap nx, Bitmap ny, Bitmap nz)
        {
            TextureCube texture = new TextureCube();
            texture.device     = device;
            texture.internalFormat     = TextureFormat.RGB8;
            texture.type       = ElementType.UByte;
            texture.baseformat = Gl.GL_BGR;
            texture.width  = px.Width;

            px.RotateFlip(RotateFlipType.RotateNoneFlipY);
            nx.RotateFlip(RotateFlipType.RotateNoneFlipY);
            py.RotateFlip(RotateFlipType.RotateNoneFlipY);
            ny.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pz.RotateFlip(RotateFlipType.RotateNoneFlipY);
            nz.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Gl.glGenTextures(1, out texture.handle);
            Gl.glBindTexture(Gl.GL_TEXTURE_CUBE_MAP, texture.handle);
            Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);
            Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);
            Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_WRAP_T, Gl.GL_CLAMP_TO_EDGE);
            Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_WRAP_S, Gl.GL_CLAMP_TO_EDGE);
            
 
            BitmapData pxd = px.LockBits(new Rectangle(0, 0, texture.width, texture.width), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_X, 0, (int)texture.internalFormat, (int)texture.width, (int)texture.width, 0, (int)texture.baseformat, (int)texture.type, pxd.Scan0);
            px.UnlockBits(pxd);
            
            BitmapData nxd = nx.LockBits(new Rectangle(0, 0, texture.width, texture.width), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 0, (int)texture.internalFormat, (int)texture.width, (int)texture.width, 0, (int)texture.baseformat, (int)texture.type, nxd.Scan0);
            nx.UnlockBits(nxd);
            
            BitmapData pyd = py.LockBits(new Rectangle(0, 0, texture.width, texture.width), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, 0, (int)texture.internalFormat, (int)texture.width, (int)texture.width, 0, (int)texture.baseformat, (int)texture.type, pyd.Scan0);
            py.UnlockBits(pyd);
            
            BitmapData nyd = ny.LockBits(new Rectangle(0, 0, texture.width, texture.width), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 0, (int)texture.internalFormat, (int)texture.width, (int)texture.width, 0, (int)texture.baseformat, (int)texture.type, nyd.Scan0);
            ny.UnlockBits(nyd);
            
            BitmapData pzd = pz.LockBits(new Rectangle(0, 0, texture.width, texture.width), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 0, (int)texture.internalFormat, (int)texture.width, (int)texture.width, 0, (int)texture.baseformat, (int)texture.type, pzd.Scan0);
            pz.UnlockBits(pzd);
            
            BitmapData nzd = nz.LockBits(new Rectangle(0, 0, texture.width, texture.width), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, 0, (int)texture.internalFormat, (int)texture.width, (int)texture.width, 0, (int)texture.baseformat, (int)texture.type, nzd.Scan0);
            nz.UnlockBits(nzd);
            
            Gl.glBindTexture(Gl.GL_TEXTURE_CUBE_MAP, 0);
            return texture;
        }

        public static TextureCube FromFile(Device device, string px, string py, string pz, string nx, string ny, string nz)
        {
            Bitmap bpx = new Bitmap(px);
            Bitmap bnx = new Bitmap(nx);
            Bitmap bpy = new Bitmap(py);
            Bitmap bny = new Bitmap(ny);
            Bitmap bpz = new Bitmap(pz);
            Bitmap bnz = new Bitmap(nz);
            TextureCube textureCube = TextureCube.FromBitmap(device, bpx, bpy, bpz, bnx, bny, bnz);
            bpx.Dispose();
            bnx.Dispose();
            bpy.Dispose();
            bny.Dispose();
            bpz.Dispose();
            bnz.Dispose();
            return textureCube;
        }

        public static TextureCube Empty(Device device, int width, TextureFormat format)
        {
            return new TextureCube(device, width, 0, format);
        }
        public static TextureCube Empty(Device device, int width, int border, TextureFormat format)
        {
            return new TextureCube(device, width, border, format);
        }

        #endregion

        #region Properties

        public int           Width
        {
            get { return this.width; }
        }

        #endregion

        #region TextureBase Members

        public override TextureFilter MinFilter
        {
            get
            {
                return base.minFilter;
            }
            set
            {
                base.minFilter = value;
                Gl.glBindTexture  (Gl.GL_TEXTURE_CUBE_MAP, this.handle);
                Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_MIN_FILTER, (int)value);
                Gl.glBindTexture  (Gl.GL_TEXTURE_CUBE_MAP, 0);
            }
        }

        public override TextureFilter MagFilter
        {
            get
            {
                return base.magFilter;
            }
            set
            {
                base.magFilter = value;
                Gl.glBindTexture  (Gl.GL_TEXTURE_CUBE_MAP, this.handle);
                Gl.glTexParameteri(Gl.GL_TEXTURE_CUBE_MAP, Gl.GL_TEXTURE_MAG_FILTER, (int)value);
                Gl.glBindTexture  (Gl.GL_TEXTURE_CUBE_MAP, 0);
            }
        }

        public void SetData<T>(T[] data)
        {
            Gl.glBindTexture(Gl.GL_TEXTURE_CUBE_MAP, this.handle);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_X, 0, this.baseformat, this.width, this.width, 0, (int)this.internalFormat, (int)this.type, data[(this.width * this.width) * 0]);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 0, this.baseformat, this.width, this.width, 0, (int)this.internalFormat, (int)this.type, data[(this.width * this.width) * 1]);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 0, this.baseformat, this.width, this.width, 0, (int)this.internalFormat, (int)this.type, data[(this.width * this.width) * 2]);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, 0, this.baseformat, this.width, this.width, 0, (int)this.internalFormat, (int)this.type, data[(this.width * this.width) * 3]);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 0, this.baseformat, this.width, this.width, 0, (int)this.internalFormat, (int)this.type, data[(this.width * this.width) * 4]);
            Gl.glTexImage2D(Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, 0, this.baseformat, this.width, this.width, 0, (int)this.internalFormat, (int)this.type, data[(this.width * this.width) * 5]);
            Gl.glBindTexture(Gl.GL_TEXTURE_CUBE_MAP, 0);
        }

        public T [] GetData<T>()
        {
            T [] data = new T[((this.width * this.width) * GetBaseSize(this.internalFormat)) * 6];

            Gl.glBindTexture(Gl.GL_TEXTURE_CUBE_MAP, this.handle);

            Gl.glGetTexImage(Gl.GL_TEXTURE_CUBE_MAP, 0, (int)this.baseformat, (int)this.type, data);

            Gl.glBindTexture(Gl.GL_TEXTURE_CUBE_MAP, 0);

            return data;
        }

        #endregion
    }
}
