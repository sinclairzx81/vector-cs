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

using Vector.Math;
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    public class ClipPlane     
    {
        public bool  Enabled { get; set; }
        public Plane Plane { get; set; }
        public ClipPlane()
        {
            this.Enabled = false;
            this.Plane = new Plane();
        }
    }

    public class PolygonMode   
    {
        public PolygonMode() : this(Face.FrontAndBack, RasterMode.Fill)  { }
        public PolygonMode(Face face, RasterMode rasterMode)
        {
            this.Face       = face;
            this.RasterMode = rasterMode;
        }
        public Face       Face       { get; set; }
        public RasterMode RasterMode { get; set; }
    }

    public class DepthFunction 
    {
        public LogicOp LogicOp { get; set; }
        public DepthFunction() : this(LogicOp.LessOrEqual) { }
        public DepthFunction(LogicOp logicOp)
        {
            this.LogicOp = logicOp;
        }
    }

    public class AlphaFunction 
    {
        public LogicOp LogicOp { get; set; }
        public float   Value   { get; set; }

        public AlphaFunction() : this(LogicOp.Never, 1.0f) { }
        public AlphaFunction(LogicOp logicOp, float value)
        {
            this.LogicOp = logicOp;
            this.Value   = value;
        }
    }

    public class BlendFunction 
    {
        public Factor Src { get; set; }
        public Factor Dst { get; set; }

        public BlendFunction() : this(Factor.One, Factor.One) { }
        public BlendFunction(Factor src, Factor dst)
        {
            this.Src = src;
            this.Dst = dst;
        }
    }

    public class Light
    {
        public bool     Enabled              { get; set; }
        public Vector4  Position             { get; set; }
        public Vector4  Diffuse              { get; set; }
        public Vector4  Ambient              { get; set; }
        public Vector4  Specular             { get; set; }
        public Vector3  SpotDirection        { get; set; }
        public float    SpotExponent         { get; set; }
        public float    SpotCutOff           { get; set; }
        public float    ContstantAttenuation { get; set; }
        public float    LinearAttenuation    { get; set; }
        public float    QuadraticAttenuation { get; set; }

        public Light()
        {
            this.Enabled              = false;
            this.Position             = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
            this.Diffuse              = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
            this.Ambient              = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
            this.Specular             = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
            this.SpotDirection        = new Vector3(0.0f, 0.0f, -1.0f);
            this.SpotExponent         = 0.0f;
            this.SpotCutOff           = 180.0f;
            this.ContstantAttenuation = 1;
            this.LinearAttenuation    = 0;
            this.QuadraticAttenuation = 0;
        }
    }
  
    public enum FogMode : int
    {
        Exp    = Gl.GL_EXP,
        Exp2   = Gl.GL_EXP2,
        Linear = Gl.GL_LINEAR,
    }

    public class Fog
    {
        public bool    Enabled { get; set; }
        public FogMode Mode    { get; set; }
        public Vector4 Color   { get; set; }
        public float   Density { get; set; }
        public Hint    Hint    { get; set; }
        public float   Start   { get; set; }
        public float   End     { get; set; }

        public Fog()
        {
            this.Enabled = false;
            this.Mode    = FogMode.Linear;
            this.Color   = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
            this.Density = 0.5f;
            this.Hint    = Gpu.Hint.DontCare;
            this.Start   = 0.0f;
            this.End     = 1.0f;
        }
    }

    public class State         
    {      
        /// <summary>
        /// World - is actually the MODEL matrix from a GL_MODELVIEW matrix. Multiplication of the Model and View is done in the Device as part of a enabling of this state. Seperated for conveniance.
        /// </summary>
        public Matrix        World                     { get; set; }
        /// <summary>
        /// View - is actually the VIEW matrix from a GL_MODELVIEW matrix. Multiplication of the Model and View is done in the Device as part of a enabling of this state. Seperated for conveniance.
        /// </summary>
        public Matrix        View                      { get; set; }
        /// <summary>
        /// Projection - Maps to a GL_PROJECTION matrix.
        /// </summary>
        public Matrix        Projection                { get; set; }
        public bool          AlphaTest                 { get; set; }
        public bool          DepthTest                 { get; set; }
        public bool          StencilTest               { get; set; }
        public bool          Culling                   { get; set; }
        public bool          Blending                  { get; set; }
        public bool          MultiSampling             { get; set; }
        public bool          Lighting                  { get; set; }
        public Light []      Lights                    { get; set; }
        public Fog           Fog                       { get; set; }
        public ClipPlane     ClipPlane0                { get; set; }
        public ClipPlane     ClipPlane1                { get; set; }
        public ClipPlane     ClipPlane2                { get; set; }
        public ClipPlane     ClipPlane3                { get; set; }
        public ClipPlane     ClipPlane4                { get; set; }
        public ClipPlane     ClipPlane5                { get; set; }
        public float         LineWidth                 { get; set; }
        public Hint          PointSmoothHint           { get; set; }
        public Hint          LineSmoothHint            { get; set; }
        public Hint          PolygonSmoothHint         { get; set; }
        public Face          CullFace                  { get; set; }
        public Hint          PerspectiveCorrectionHint { get; set; }
        public PolygonMode   PolygonMode               { get; set; }
        public DepthFunction DepthFunction             { get; set; }
        public AlphaFunction AlphaFunction             { get; set; }
        public BlendFunction BlendFunction             { get; set; }
        
        public State()
        {
            this.CullFace                  = Face.Back;
            this.Culling                   = true;
            this.MultiSampling             = false;
            this.Blending                  = false;
            this.DepthTest                 = true;
            this.AlphaTest                 = false;
            this.StencilTest               = false;
            this.Lighting                  = false;
            this.ClipPlane0                = new ClipPlane();
            this.ClipPlane1                = new ClipPlane();
            this.ClipPlane2                = new ClipPlane();
            this.ClipPlane3                = new ClipPlane();
            this.ClipPlane4                = new ClipPlane();
            this.ClipPlane5                = new ClipPlane();
            this.Lights                    = new Light[8];
            for (int i = 0; i < this.Lights.Length; i++) this.Lights[i] = new Light();
            this.Fog                       = new Fog();

            this.PerspectiveCorrectionHint = Hint.Nicest;
            this.PointSmoothHint           = Hint.Nicest;
            this.LineSmoothHint            = Hint.Nicest;
            this.PolygonSmoothHint         = Hint.Nicest;
            this.LineWidth                 = 1.0f;

            
            this.PolygonMode               = new PolygonMode();
            this.DepthFunction             = new DepthFunction();
            this.AlphaFunction             = new AlphaFunction();
            this.BlendFunction             = new BlendFunction();
        }

        #region Statics

        public static State Default
        {
            get
            {
                return new State();
            }
        }

        #endregion

    }
}
