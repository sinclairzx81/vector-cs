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

namespace Vector.RayTracing
{
    public class Color
    {
        public static Color white        = new Color(1.0f, 1.0f, 1.0f);
        public static Color grey         = new Color(0.5f, 0.5f, 0.5f);
        public static Color black        = new Color(0.0f, 0.0f, 0.0f);
        public static Color background   = Color.black;
        public static Color defaultColor = Color.black;

        public float r;
        public float b;
        public float g;

        public Color() : this(0.0f, 0.0f, 0.0f) 
        { 

        }
        public Color(float r, float b, float g)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static Color scale(float k, Color v)
        {
            return new Color(k * v.r, k * v.g, k * v.b);
        }

        public static Color plus(Color v1, Color v2)
        {
            return new Color(v1.r + v2.r, v1.g + v2.g, v1.b + v2.b);
        }

        public static Color times(Color v1, Color v2)
        {
            return new Color(v1.r * v2.r, v1.g * v2.g, v1.b * v2.b);
        }
        
        public static System.Drawing.Color toDrawingColor(Color color)
        {
            // legalize.
            var r = color.r > 1.0f ? 1.0f : color.r;
            
            var b = color.b > 1.0f ? 1.0f : color.b;
            
            var g = color.g > 1.0f ? 1.0f : color.g;

            return System.Drawing.Color.FromArgb((int)System.Math.Floor(r * 255),
                                                 (int)System.Math.Floor(g * 255),
                                                 (int)System.Math.Floor(b * 255));  
        }

    }
}
