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

using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Vector.Math
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Triangle
    {
        public Vector3 vert0;
        public Vector3 vert1;
        public Vector3 vert2;

        public Triangle(Vector3 vert0, Vector3 vert1, Vector3 vert2)
        {
            this.vert0 = vert0;
            this.vert1 = vert1;
            this.vert2 = vert2;
        }

        #region Properties

        /// <summary>
        /// Returns the plane for this triangle.
        /// </summary>
        public Plane Plane
        {
            get
            {
                return new Plane(this.vert0, this.vert1, this.vert2);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Tests for a intersection bewteen this Ray and this Triangle.
        /// </summary>
        /// <param name="ray"></param>
        /// <returns></returns>
        public bool Intersect(Ray ray)
        {
            float t; return Triangle.Intersect(ray, this.vert0, this.vert1, this.vert2, out t);
        }

        /// <summary>
        /// Test for the intersection of this plane with this Triangle.
        /// </summary>
        /// <param name="plane"></param>
        /// <returns></returns>
        public bool Intersect(Plane plane)
        {
            return Triangle.Intersect(plane, this.vert0, this.vert1, this.vert2);
        }

        #endregion

        #region Statics

        /// <summary>
        /// Tests for a intersection between this Ray and this Triangle.
        /// </summary>
        /// <param name="ray"></param>
        /// <param name="vert0"></param>
        /// <param name="vert1"></param>
        /// <param name="vert2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool Intersect(Ray ray, Vector3 vert0, Vector3 vert1, Vector3 vert2, out float t)
        {
            t = 0;

            Vector3 edge1 = vert1 - vert0;
            
            Vector3 edge2 = vert2 - vert0;
            
            Vector3 tvec, pvec, qvec;
            
            float det, inv_det;

            pvec = Vector3.Cross(ray.Direction, edge2);

            det  = Vector3.Dot(edge1, pvec);

            if (det > -0.00001f)
            {
                return false;
            }

            inv_det = 1.0f / det;

            tvec = ray.Position - vert0;

            float u = Vector3.Dot(tvec, pvec) * inv_det;
            if (u < -0.001f || u > 1.001f)
                return false;

            qvec = Vector3.Cross(tvec, edge1);

            float v = Vector3.Dot(ray.Direction, qvec) * inv_det;
            
            if (v < -0.001f || u + v > 1.001f)
            {
                return false;
            }
            
            t = Vector3.Dot(edge2, qvec) * inv_det;

            if (t <= 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Test for the intersection of this plane with this Triangle.
        /// </summary>
        /// <param name="plane"></param>
        /// <returns></returns>
        public static bool Intersect(Plane plane, Vector3 vert0, Vector3 vert1, Vector3 vert2)
        {
            Ray ray0 = new Ray(vert0, vert1 - vert0);
            
            Ray ray1 = new Ray(vert1, vert2 - vert1);
            
            Ray ray2 = new Ray(vert2, vert0 - vert2);

            if (ray0.Intersects(plane) != null) return true;

            if (ray1.Intersects(plane) != null) return true;

            if (ray2.Intersects(plane) != null) return true;

            return false;
        }

        /// <summary>
        /// Splits a triangle by a plane. If no split is possible, then return original triangle.
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="vert0"></param>
        /// <param name="vert1"></param>
        /// <param name="vert2"></param>
        /// <returns></returns>
        public static Triangle [] Split(Plane plane, Vector3 vert0, Vector3 vert1, Vector3 vert2)
        {
            Vector3 []    verts  = new Vector3[] { vert0, vert1, vert2, Vector3.Zero, Vector3.Zero };

            int           count  = 0;

            int     []    edges  = new int[2];

            float   []    ratios = new float[2];

            // Check and store intersections along the edges of this triangle.
            for (int i = 0; i < 3; i++)
            {
                Ray ray = new Ray(verts[i], verts[(i + 1) % 3] - verts[i]);

                float ? ratio = ray.Intersects(plane); // Compute the Intesection along this Ray.

                if (ratio.HasValue)
                {
                    if (ratio > 0.0f && ratio < 1.0f)
                    {
                        ratios[count] = ratio.Value;
                        
                        edges [count] =  i;

                        count++;
                    }                  
                }
            }

            // If two edges are found, then we need to create two extra vertices for the split.

            if (count == 2)
            {
                verts[3] = ((verts[(edges[0] + 1) % 3] - verts[edges[0]]) * ratios[0]) + verts[edges[0]];

                verts[4] = ((verts[(edges[1] + 1) % 3] - verts[edges[1]]) * ratios[1]) + verts[edges[1]];
            }

            // TODO : Need to add condition whare only a single plane is intersected.
            
            // Intersection A - (v0-v1) (v1-v2) [(0, 3, 4) (1, 4, 3) (2, 0, 4)]
            
            // Intersection B - (v0-v1) (v2-v0) [(0, 3, 4) (1, 2, 3) (2, 4, 3)]
            
            // Intersection C - (v1-2v) (v2-v0) [(0, 1, 4) (1, 3, 4) (2, 4, 3)]

            if (edges[0] == 0 && edges[1] == 1) {
                return new Triangle[] { new Triangle(verts[0], verts[3], verts[4]),
                                        new Triangle(verts[1], verts[4], verts[3]),
                                        new Triangle(verts[2], verts[0], verts[4]) };
            }

            if (edges[0] == 1 && edges[1] == 2) {
                return new Triangle[] { new Triangle(verts[0], verts[1], verts[3]),
                                        new Triangle(verts[3], verts[4], verts[0]),
                                        new Triangle(verts[4], verts[3], verts[2]) 
                };
            }

            if (edges[0] == 0 && edges[1] == 2) {
                return new Triangle[] { new Triangle(verts[0], verts[3], verts[4]),
                                        new Triangle(verts[1], verts[2], verts[3]),
                                        new Triangle(verts[2], verts[4], verts[3]) 
                };
            }
             
            return new Triangle[] { new Triangle(verts[0], verts[1], verts[2]) };
        }

        #endregion
    }
}
