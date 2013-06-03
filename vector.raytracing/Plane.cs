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

using Vector.Math;

namespace Vector.RayTracing
{
    public class Plane : Object3D
    {
        public Vector3 norm;
        public float offset;
        public Surface surface { get; set; }

        public Plane(Vector3 norm, float offset, Surface surface)
        {
            this.norm = norm;
            this.offset = offset;
            this.surface = surface;
        }

        public Intersection intersect(Ray ray)
        {
            var denom = Vector3.Dot(norm, ray.Direction);

            if (denom > 0)
            {
                return null;
            }
            else
            {
                var dist = (Vector3.Dot(norm, ray.Position) + offset) / (-denom);

                return new Intersection { thing = this, ray = ray, dist = dist };
            }
        }

        public Vector3 normal(Vector3 pos)
        {
            return this.norm;
        }
    }
}
