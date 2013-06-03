using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
