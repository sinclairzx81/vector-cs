using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
