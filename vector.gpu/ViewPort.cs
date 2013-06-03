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
using System.Runtime.InteropServices;
using System.Globalization;
using Vector.Gpu;
using Vector.Math;


namespace Vector.Gpu
{
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct ViewPort
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private float minZ;
        private float maxZ;
        public ViewPort(int x, int y, int width, int height) : this(x, y, width, height, 0, 1000)
        {
            
        }

        public ViewPort(int x, int y, int width, int height, int minZ, int maxZ)
        {
            this.x      = x;
            this.y      = y;
            this.width  = width;
            this.height = height;
            this.minZ   = minZ;
            this.maxZ   = maxZ;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public float MinDepth
        {
            get
            {
                return this.minZ;
            }
            set
            {
                this.minZ = value;
            }
        }
        public float MaxDepth
        {
            get
            {
                return this.maxZ;
            }
            set
            {
                this.maxZ = value;
            }
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{X:{0} Y:{1} Width:{2} Height:{3} MinDepth:{4} MaxDepth:{5}}}", new object[] { this.X, this.Y, this.Width, this.Height, this.MinDepth, this.MaxDepth });
        }

        private static bool WithinEpsilon(float a, float b)
        {
            float num = a - b;
            return ((-1.401298E-45f <= num) && (num <= float.Epsilon));
        }

        public Vector3 Project(Vector3 source, Matrix projection, Matrix view, Matrix world)
        {
            Matrix matrix = Matrix.Multiply(Matrix.Multiply(world, view), projection);
            Vector3 vector = Vector3.Transform(source, matrix);
            float a = (((source.X * matrix.M14) + (source.Y * matrix.M24)) + (source.Z * matrix.M34)) + matrix.M44;
            if (!WithinEpsilon(a, 1f))
            {
                vector = (Vector3)(vector / a);
            }
            vector.X = (((vector.X + 1f) * 0.5f) * this.Width) + this.X;
            vector.Y = (((-vector.Y + 1f) * 0.5f) * this.Height) + this.Y;
            vector.Z = (vector.Z * (this.MaxDepth - this.MinDepth)) + this.MinDepth;
            return vector;
        }

        public Vector3 Unproject(Vector3 source, Matrix projection, Matrix view, Matrix world)
        {
            Vector3 position = new Vector3();
            Matrix matrix = Matrix.Invert(Matrix.Multiply(Matrix.Multiply(world, view), projection));
            position.X = (((source.X - this.X) / ((float)this.Width)) * 2f) - 1f;
            position.Y = -((((source.Y - this.Y) / ((float)this.Height)) * 2f) - 1f);
            position.Z = (source.Z - this.MinDepth) / (this.MaxDepth - this.MinDepth);
            position = Vector3.Transform(position, matrix);
            float a = (((source.X * matrix.M14) + (source.Y * matrix.M24)) + (source.Z * matrix.M34)) + matrix.M44;
            if (!WithinEpsilon(a, 1f))
            {
                position = (Vector3)(position / a);
            }
            return position;
        }

        public float AspectRatio
        {
            get
            {
                if ((this.height != 0) && (this.width != 0))
                {
                    return (((float)this.width) / ((float)this.height));
                }
                return 0.0f;
            }
        }
    }
}
