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
using System.Windows.Forms;

namespace Vector.Gdi
{

    /// <summary>
    /// Very simple Gdi Device with double buffering.
    /// </summary>
    public class Device : IDisposable
    {
        public Control    Control   { get; set; }

        public Bitmap     Bitmap    { get; set; }
        
        public Graphics   Graphics0 { get; set; }
        
        public Graphics   Graphics1 { get; set; }

        public Device(Control Control)
        {
            this.Control   = Control;

            this.Bitmap    = new Bitmap(this.Control.Width, this.Control.Height);

            this.Graphics0 = Graphics.FromImage(this.Bitmap);

            this.Graphics1 = this.Control.CreateGraphics();
        }

        public void Clear(System.Drawing.Color color)
        {
            this.Graphics0.Clear(color);
        }

        public void DrawPixel(int x, int y, Color color)
        {
            this.Bitmap.SetPixel(x, y, color);
        }

        // todo, add more methods.

        public void Present()
        {
            this.Bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

            this.Graphics1.DrawImage(this.Bitmap, 0, 0);
        }

        #region IDisposable

        private bool disposed = false;

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!disposed)
                {
                    this.Graphics0.Dispose();

                    this.Graphics1.Dispose();

                    this.Bitmap.Dispose();

                    this.disposed = true;
                }
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        ~Device()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
