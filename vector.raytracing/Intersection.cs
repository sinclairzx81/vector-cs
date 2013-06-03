using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector.Math;

namespace Vector.RayTracing
{
    public class Intersection 
    {
        public Object3D    thing   { get; set; }
        public Ray      ray     { get; set; }
        public float    dist    { get; set; }
    }
}
