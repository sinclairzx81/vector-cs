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
    public class Sphere : Object3D
    {
        public Vector3 center;

        public Surface surface { get; set; }

        public float radius;

        public float radius2;

        public Sphere(Vector3 center, float radius, Surface surface)
        {
            this.center = center;

            this.radius = radius;

            this.radius2 = radius * 2;

            this.surface = surface;
        }

        public Vector3 normal(Vector3 pos)
        {
            return Vector3.Normalize(pos - this.center);
        }

        public Intersection intersect(Ray ray)
        {
            var eo = this.center - ray.Position;

            float v = Vector3.Dot(eo, ray.Direction);

            float dist = 0.0f;

            if (v >= 0.0f)
            {
                float disc = this.radius2 - (Vector3.Dot(eo, eo) - v * v);

                if (disc >= 0.0f)
                {
                    dist = v - (float)System.Math.Sqrt(disc);
                }
            }
            if (dist == 0)
            {
                return null;
            }
            else
            {
                return new Intersection { thing = this, ray = ray, dist = dist };
            }
        }
    }
}
