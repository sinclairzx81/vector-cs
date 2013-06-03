using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector.Math;

namespace Vector.RayTracing
{
    public interface Object3D
    {
        Surface       surface { get; set; }
        Intersection  intersect (Ray ray);
        Vector3       normal    (Vector3 pos);
    }
}
