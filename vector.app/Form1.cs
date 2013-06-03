using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vector.Gdi;
using Vector.Math;
using Vector.RayTracing;

namespace Vector.App
{
    public partial class Form1 : Form
    {
        private Device Device { get; set; }

        private Scene  Scene  { get; set; }

        private Renderer raytracer { get; set; }

        public void SetupControl()
        {
            this.Device = new Device(this);

            this.raytracer   = new Renderer();
            
            this.Scene = new Scene();

            this.Scene.things = new Object3D[]
            {
               new Vector.RayTracing.Plane(new Vector3(0.0f, 1.0f, 0.0f), 0.0f, new Surface()),

               new Sphere(new Vector3(0.0f, 1.0f, -0.25f), 1.0f, new Surface()),

               new Sphere(new Vector3(-1.0f, 0.5f, 1.5f), 0.5f, new Surface())
            };
            this.Scene.lights = new Light[]
            {
                new Light { pos= new Vector3(-2.0f, 2.5f, 0.0f), color = new Vector.RayTracing.Color(0.49f, 0.07f, 0.07f) },

                new Light { pos= new Vector3(1.5f, 2.5f, 1.5f),  color = new Vector.RayTracing.Color(0.07f, 0.07f, 0.49f) },

                new Light { pos= new Vector3(1.5f, 2.5f, -1.5f), color = new Vector.RayTracing.Color(0.07f, 0.49f, 0.071f) },

                new Light { pos= new Vector3(0.0f, 3.5f, 0.0f),  color = new Vector.RayTracing.Color(0.21f, 0.21f, 0.35f) }
            };

            this.Scene.camera = new Camera(new Vector3(10.0f, 20.0f, 10.0f), new Vector3(-1.0f, 0.5f, 0.0f));

        }

        public float n = 0.0f;

        public void UpdateControl()
        {
            var sphere = (Sphere)this.Scene.things[2];

            sphere.center.Y = n;

            this.Scene.camera = new Camera(new Vector3(10.0f, 1.0f, 10.0f), sphere.center);

            n += 0.1f;

            if (n > 5) n = 0;
        }

        public void RenderControl()
        {
            this.Device.Clear(System.Drawing.Color.Black);

            this.raytracer.render(this.Scene, this.Device, this.Width, this.Height);

            this.Device.Present();

              this.timer.Stop();
        }


        #region Events

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.SetupControl();

            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.UpdateControl();

            this.RenderControl();
        }

        #endregion
    }
}
