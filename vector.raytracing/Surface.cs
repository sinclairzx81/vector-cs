using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector.Math;

namespace Vector.RayTracing
{
    public class Surface
    {
        public float roughness { get; set; }

        public virtual Color diffuse(Vector3 pos)
        {
            return Color.white;
        }
        public virtual Color specular(Vector3 pos)
        {
            return Color.grey;
        }
        public virtual float reflect(Vector3 pos)
        {
            return 0.7f;
        }

        public Surface()
        {
            this.roughness = 250;
        }
    }
}
