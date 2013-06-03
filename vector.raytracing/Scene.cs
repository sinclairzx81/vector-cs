using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.RayTracing
{
    public class Scene
    {
        public Camera  camera;
        public Object3D[] things;
        public Light[] lights;
    }
}
