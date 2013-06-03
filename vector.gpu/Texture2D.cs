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
using System.Runtime.InteropServices;
using Vector.Gpu.OpenGL;


namespace Vector.Gpu
{
    /// <summary>
    /// A 2 Dimentional Texture. 
    /// </summary>
    public class Texture2D : TextureBase 
    {

        private int           width;
        private int           height;

        private Texture2D() : base() { }
        public Texture2D(Device device, int width, int height, TextureFormat format) : this(device, width, height, 0, format) { }
        public Texture2D(Device device, int width, int height, int border, TextureFormat format)
        {
            this.device         = device;
            this.internalFormat = format;
            this.baseformat     = this.GetBaseFormat (this.internalFormat);
            this.type           = this.GetBaseType   (this.internalFormat);
            this.width          = width;
            this.height         = height;

            Gl.glGenTextures(1, out this.handle);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.handle);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, (int)this.internalFormat,
                                                 (int)this.width,
                                                 (int)this.height, border,
                                                 (int)this.baseformat,
                                                 (int)this.type,
                                                 IntPtr.Zero);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);
            if (format == TextureFormat.DEPTH16  ||
                format == TextureFormat.DEPTH24  ||
                format == TextureFormat.DEPTH32)
            {
                //Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_COMPARE_MODE_ARB, Gl.GL_COMPARE_R_TO_TEXTURE_ARB);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_COMPARE_MODE_ARB, Gl.GL_NONE);
            }

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0);
        }

        #region Factory Methods
        

        /// <summary>
        /// Loads a Texture2D from a System.Drawing.Bitmap object.
        /// </summary>
        /// <param name="device"></param>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Texture2D FromBitmap(Device device, Bitmap bitmap)
        {
            Texture2D texture          = new Texture2D();
            texture.device             = device;
            texture.internalFormat     = TextureFormat.RGB8;
            texture.type               = texture.GetBaseType(texture.internalFormat);
            texture.baseformat         = Gl.GL_BGR;
            texture.width              = bitmap.Width;
            texture.height             = bitmap.Height;

            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0,
                                                                  0,
                                                                  bitmap.Width,
                                                                  bitmap.Height),
                                                                  ImageLockMode.ReadOnly,
                                                                  PixelFormat.Format24bppRgb);

            Gl.glGenTextures(1, out texture.handle);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture.handle);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, (int)texture.internalFormat,
                                                 (int)texture.Width,
                                                 (int)texture.Height, 0,
                                                 (int)texture.baseformat,
                                                 (int)texture.type,
                                                 bitmapData.Scan0);
           

            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0);

            bitmap.UnlockBits(bitmapData);
            
            return texture;
        }
        /// <summary>
        /// <para>Loads a Texture from File.</para>
        /// <para>This will load any image that a System.Drawing.Bitmap will load.</para>
        /// </summary>
        /// <param name="device"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static Texture2D FromFile(Device device, string filename)
        {
            if (System.IO.File.Exists(filename))
            {
                try
                {
                    Bitmap bitmap = new Bitmap(filename);

                    Texture2D texture2D = Texture2D.FromBitmap(device, bitmap);

                    return texture2D;
                }
                catch
                {

                }
            }
            return null;
        }
        /// <summary>
        /// Creates an empty texture. 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static Texture2D Empty(Device device, int width, int height, TextureFormat format)
        {
            return new Texture2D(device, width, height, format); 
        }
        /// <summary>
        /// Creates an empty texture. 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static Texture2D Empty     (Device device, int width, int height, int border, TextureFormat format)
        {
            return new Texture2D(device, width, height, border, format); 
        }

        #endregion

        #region Properties

        public int           Width
        {
            get { return this.width; }
        }

        public int           Height
        {
            get { return this.height; }
        }

        #endregion

        #region Overrides

        public override TextureFilter MinFilter
        {
            get
            {
                return this.minFilter;
            }
            set 
            {
                this.minFilter = value;
                Gl.glBindTexture  (Gl.GL_TEXTURE_2D, this.handle);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, (int)value);
                Gl.glBindTexture  (Gl.GL_TEXTURE_2D, 0);
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
                Gl.glBindTexture   (Gl.GL_TEXTURE_2D, this.handle);
                Gl.glTexParameteri (Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, (int)value);
                Gl.glBindTexture   (Gl.GL_TEXTURE_2D, 0);
            }
        }

        #endregion

        #region Exporting

        /// <summary>
        /// Saves this Texture2D to file.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="imageFormat"></param>
        public void Save(string filename, ImageFormat imageFormat)
        {
            Texture2D.Save(this, filename, imageFormat);
        }

        /// <summary>
        /// Saves this Texture to file.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="filename"></param>
        /// <param name="imageFormat"></param>
        public static void Save(Texture2D texture, string filename, ImageFormat imageFormat)
        {
            Bitmap bitmap; Texture2D.Save(texture, out bitmap, imageFormat);

            bitmap.Save(filename, imageFormat);

            bitmap.Dispose();
        }

        /// <summary>
        /// Saves this Texture to a Bitmap, Important, Caller "must" Dispose of the bitmap.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="bitmap"></param>
        /// <param name="imageFormat"></param>
        public void Save(out Bitmap bitmap, ImageFormat imageFormat)
        {
            Texture2D.Save(this, out bitmap, imageFormat);
        }

        /// <summary>
        /// Saves this Texture to a Bitmap, Important, Caller "must" Dispose of the bitmap.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="bitmap"></param>
        /// <param name="imageFormat"></param>
        public static void Save(Texture2D texture, out Bitmap bitmap, ImageFormat imageFormat)
        {
            // Get data
            byte[] data = texture.GetData<byte>();

            // Swap the Reds for Blues
            byte temp = 0;
            for (int i = 0; i < data.Length; i += 4)
            {
                temp = data[i + 0];
                data[i + 0] = data[i + 2];
                data[i + 2] = temp;
            }

            // Work out the pixel format
            PixelFormat pixelFormat;
            switch (texture.GetBaseSize(texture.Format))
            {
                case 3:  pixelFormat = PixelFormat.Format24bppRgb; break;
                case 4:  pixelFormat = PixelFormat.Format32bppArgb; break;
                default: pixelFormat = PixelFormat.Format32bppRgb; break;
            }

            // Serialize the Texture.
            bitmap = new Bitmap(texture.Width, texture.Height, pixelFormat);
            {
                BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, pixelFormat);

                Marshal.Copy(data, 0, bitmapData.Scan0, data.Length);

                bitmap.UnlockBits(bitmapData);

                bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
        }

        #endregion

        public void SetData<T>(    T [] data)
        {
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.handle);

            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0,
                            (int)this.internalFormat,
                            (int)this.width,
                            (int)this.height,
                            0,
                            (int)this.baseformat,
                            (int)this.type,
                            data);

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0);
        }
        public T [] GetData<T>()
        {
            T [] data = new T[(this.width * this.height) * GetBaseSize(this.internalFormat)];

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.handle);

            Gl.glGetTexImage(Gl.GL_TEXTURE_2D, 0, (int)this.baseformat, (int)this.type, data);

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0);

            return data;
        }
    }
}
