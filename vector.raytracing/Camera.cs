using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector.Math;
namespace Vector.RayTracing
{
    public class Camera
    {
        public Vector3 pos;
        public Vector3 forward;
        public Vector3 right;
        public Vector3 up;

        public Camera(Vector3 pos, Vector3 lookat)
        {
            this.pos     = pos;
            
            var down     = new Vector3(0.0f, -1.0f, 0.0f);

            this.forward = Vector3.Normalize(lookat - this.pos);
            
            this.right   = Vector3.Normalize(Vector3.Cross(this.forward, down)) * 1.5f;

            this.up      = Vector3.Normalize(Vector3.Cross(this.forward, this.right)) * 1.5f;
        }

    }
}
