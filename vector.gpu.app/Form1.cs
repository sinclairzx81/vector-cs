using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vector.Gpu;
using Vector.Math;

namespace vector.gpu.app
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vertex
    {
        [VertexAttribute(ElementBinding.Vertex, ElementType.Float, 4)]
        public Vector4 Position;

        [VertexAttribute(ElementBinding.Normal, ElementType.Float, 3)]
        public Vector3 Normal;

        [VertexAttribute(ElementBinding.MultiTexCoord0, ElementType.Float, 2)]
        public Vector2 Texcoord;
    }

    public partial class Form1 : Form
    {
        private WindowsDevice Device        { get; set; }

        private VertexBuffer  VertexBuffer  { get; set; }

        private IndexBuffer   IndexBuffer   { get; set; }

        private Shader        Shader        { get; set; }

        public void SetupControl()
        {
            this.Device = new WindowsDevice(this.Handle, Presentation.Default);

            this.VertexBuffer = new VertexBuffer(this.Device, typeof(Vertex), BufferUsage.Dynamic);

            this.VertexBuffer.SetData<Vertex>(new Vertex[] {

                new Vertex { Position = new Vector4(0.0f, 0.0f, 0.0f, 1.0f) , Normal = Vector3.Forward, Texcoord = Vector2.Zero },

                new Vertex { Position = new Vector4(0.0f, 10.0f, 0.0f, 1.0f), Normal = Vector3.Forward, Texcoord = Vector2.Zero },

                new Vertex { Position = new Vector4(10.0f, 10.0f, 0.0f, 1.0f), Normal = Vector3.Forward, Texcoord = Vector2.Zero },
            });


            this.IndexBuffer = new IndexBuffer(this.Device, BufferUsage.Dynamic);

            this.IndexBuffer.SetData(new uint[] {0, 1, 2 });

            

            this.Shader = new Shader(this.Device);

            this.Shader.VertexSource = @"

                uniform mat4 world;

                uniform mat4 view;

                uniform mat4 projection;

                attribute vec4 gl_Vertex;

                attribute vec3 gl_Normal;

                attribute vec2 gl_MultiTexCoord0;
                
                void main()
                {
                    gl_Position = mul(world, mul(view, projection)) * gl_Vertex;
                }            
    
            ";

            this.Shader.FragmentSource = @"
                
                void main()
                {
                    gl_FragColor = vec4(1, 1, 1, 1);
                }            
    
            ";

            var result = this.Shader.Compile(); 

            if (result.HasError)
            {
                MessageBox.Show(result.Summary);
            }
        }

        public float n = 0.0f;

        public void UpdateControl()
        {
            n += 1.1f;
        }

        public void RenderControl()
        {
            this.Device.ViewPort = new ViewPort(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
            
            this.Device.State.Culling = false;
            
            
            this.Device.Clear(Color.Gold);

            this.Shader.Parameter("world", Matrix.RotationY(n));

            this.Shader.Parameter("view",  Matrix.CreateLookAt(new Vector3(0, 0, -10), new Vector3(0, 0, 0), new Vector3(0, 1, 0)));

            this.Shader.Parameter("projection", Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(90.0f), (float)this.ClientRectangle.Width / (float)this.ClientRectangle.Height, 0.1f, 1000.0f));

            this.Shader.Begin();

            this.Device.IndexBuffer = this.IndexBuffer;

            this.Device.SetVertexBuffer(0, this.VertexBuffer);

            this.Device.Draw(Topology.Triangles);

            this.Shader.End();


            // flush graphics to output.
            this.Device.Present();
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
