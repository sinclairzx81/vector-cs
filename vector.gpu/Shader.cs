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

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Vector.Math;
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    /// <summary>
    /// A Shader Error.
    /// </summary>
    public class ShaderCompileResult
    {
        private bool   hasError;
        private string vertexShaderError;
        private string geometryShaderError;
        private string fragmentShaderError;
        private string linkerError;

        public ShaderCompileResult()
        {
            this.hasError            = false;
            this.vertexShaderError   = string.Empty;
            this.fragmentShaderError = string.Empty;
            this.geometryShaderError = string.Empty;
            this.linkerError         = string.Empty;
        }

        private string GroomErrorString(string error)
        {
            //=================
            //vertex shader
            //=================
            //0(47) : error C1103: too few parameters in function call
            //0(47) : warning C7011: implicit cast from "vec4" to "float"
            //0(58) : error C1115: unable to find compatible overloaded function "specular(vec3, vec3, vec3)"
            //0(60) : warning C7011: implicit cast from "float" to "vec4"
            //0(67) : error C1115: unable to find compatible overloaded function "normalize(error)"
            //0(136) : error C0000: syntax error, unexpected reserved word "float", expecting ',' or ';' at token "float"
            //0(136) : error C0501: type name expected at token "float"
            //0(141) : warning C7554: OpenGL requires samplers to be explicitly declared as uniform
            //0(142) : warning C7554: OpenGL requires samplers to be explicitly declared as uniform
            //0(143) : warning C7554: OpenGL requires samplers to be explicitly declared as uniform
            //0(144) : warning C7554: OpenGL requires samplers to be explicitly declared as uniform
            //0(145) : warning C7554: OpenGL requires samplers to be explicitly declared as uniform
            //0(146) : warning C7554: OpenGL requires samplers to be explicitly declared as uniform
            //0(147) : warning C7524: OpenGL requires uniform variables to be declared in global scope
            //0(159) : warning C7524: OpenGL requires uniform variables to be declared in global scope
            //0(161) : error C1038: declaration of "position" conflicts with previous declaration at 0(130)
            //0(162) : warning C7515: OpenGL requires varying variables to be declared in global scope
            //0(163) : warning C7515: OpenGL requires varying variables to be declared in global scope
            //0(164) : warning C7515: OpenGL requires varying variables to be declared in global scope
            //0(165) : warning C7515: OpenGL requires varying variables to be declared in global scope
            //0(167) : warning C7546: OpenGL does not allow abstract declarations in structs
            //0(172) : error C1115: unable to find compatible overloaded function "mul(vec3, error)"
            //0(173) : error C1115: unable to find compatible overloaded function "mul(error, error)"
            //0(174) : error C1115: unable to find compatible overloaded function "mul(error, error)"
            //(0) : error C0000: syntax error, unexpected $end at token "<EOF>"
            //(0) : error C0501: type name expected at token "<null atom>"


            return error.Replace("\n", "\r\n");
        }

        #region Properties
        public bool   HasError           
        {
            get { return this.hasError; }
            set { this.hasError = value; }
        }
        public string VertexShaderError  
        {
            get { return this.vertexShaderError; }
            set { this.vertexShaderError = value; }
        }
        public string FragmentShaderError
        {
            get { return this.fragmentShaderError; }
            set { this.fragmentShaderError = value; }
        }
        public string GeometryShaderError
        {
            get { return this.geometryShaderError; }
            set { this.geometryShaderError = value; }
        }
        public string LinkerError        
        {
            get { return this.linkerError; }
            set { this.linkerError = value; }
        }
        public string Summary            
        {
            get
            {
                return "=================\r\nvertex shader\r\n=================\r\n" + this.vertexShaderError +
                       "=================\r\nfragment shader\r\n=================\r\n" + this.fragmentShaderError +
                       "=================\r\ngeometry shader\r\n=================\r\n" + this.geometryShaderError +
                       "=================\r\nlinker\r\n=================\r\n" + this.linkerError;
            }
        }
        #endregion
    }

    /// <summary>
    /// <para>Shader</para>
    /// <para>GLSL Effect wrapper Object.</para>
    /// </summary>
    public class Shader  
    {
        private Device   device;

        private int      programHandle;
        private int      vertexHandle;
        private int      geometryHandle;
        private int      fragmentHandle;

        private string   vertexSource;
        private string   geometrySource;
        private string   fragmentSource;

        private Topology inputTopology;
        private Topology outputTopology;
        private int      outputVertexCount;

        private int      texturecount;
        
        public Shader(Device device)
        {
            this.device            = device;
            this.texturecount      = 0;
            this.programHandle     = Gl.glCreateProgram();
            this.vertexHandle      = 0;
            this.fragmentHandle    = 0;
            this.geometryHandle    = 0;
            
            this.vertexSource      = string.Empty;
            this.fragmentSource    = string.Empty;
            this.geometrySource    = string.Empty;

            this.inputTopology     = Topology.Triangles;
            this.outputTopology    = Topology.Triangles;
            this.outputVertexCount = 3;
        }

        #region Properties
        /// <summary>
        /// The handle for this Shader
        /// </summary>
        public int      Handle
        {
            get { return this.programHandle; }
        }
        /// <summary>
        /// The Device that this Shader is bound to. 
        /// </summary>
        public Device   Device
        {
            get { return this.device; }
        }
        /// <summary>
        /// The Vertex Shader source code.
        /// </summary>
        public string   VertexSource
        {
            get { return this.vertexSource; }
        }
        /// <summary>
        /// The Fragment Shader source code.
        /// </summary>
        public string   FragmentSource
        {
            get { return this.fragmentSource; }
        }
        /// <summary>
        /// The Geometry Shader source code.
        /// </summary>
        public string   GeometrySource
        {
            get { return this.geometrySource; }
        }
        /// <summary>
        /// The input topology of a user defined GeometryShader. 
        /// </summary>
        public Topology InputTopology
        {
            get { return this.inputTopology; }
            set { this.inputTopology = value; }
        }
        /// <summary>
        /// The output topology of a user defined GeometryShader
        /// </summary>
        public Topology OutputTopology
        {
            get { return this.outputTopology; }
            set { this.outputTopology = value; }
        }
        /// <summary>
        /// The amount of vertices outputted from a user defined GeometryShader.
        /// </summary>
        public int      OutputVertexCount
        {
            get { return this.outputVertexCount; }
            set { this.outputVertexCount = value; }
        }
        #endregion

        /// <summary>
        /// Appends the Vertex Shader Source
        /// </summary>
        /// <param name="sources"></param>
        public void AppendVertexSource       (params string[] sources)
        {
            foreach (string source in sources)
            {
                this.vertexSource += source;
            }
        }
        /// <summary>
        /// Appends the Fragment Shader Source
        /// </summary>
        /// <param name="sources"></param>
        public void AppendFragmentSource     (params string[] sources)
        {
            foreach (string source in sources)
            {
                this.fragmentSource += source;
            }
        }
        /// <summary>
        /// Appends the Fragment Shader Source
        /// </summary>
        /// <param name="sources"></param>
        public void AppendGeometrySource     (params string[] sources)
        {
            foreach (string source in sources)
            {
                this.geometrySource += source;
            }
        }
        /// <summary>
        /// Clears the Vertex Shader Source.
        /// </summary>
        public void ClearVertexSource        ()
        {
            this.vertexSource = string.Empty;
        }
        /// <summary>
        /// Clears the Fragment Shader Source
        /// </summary>
        public void ClearFragmentSource      ()
        {
            this.fragmentSource = string.Empty;
        }
        /// <summary>
        /// Clears the Geometry Shader Source
        /// </summary>
        public void ClearGeometrySource      ()
        {
            this.geometrySource = string.Empty;
        }

        /// <summary>
        /// Detaches and Deletes a Vertex Program.
        /// </summary>
        private void DestroyVertexShader    ()
        {
            if (this.vertexHandle != 0)
            {
                Gl.glDetachObjectARB(this.programHandle, this.vertexHandle);

                Gl.glDeleteShader(this.vertexHandle);
            }
        }
        /// <summary>
        /// Detaches and Deletes a Fragment Program.
        /// </summary>
        private void DestroyFragmentShader  ()
        {
            if (this.fragmentHandle != 0)
            {
                Gl.glDetachObjectARB(this.programHandle, this.fragmentHandle);

                Gl.glDeleteObjectARB(this.fragmentHandle);
            }
        }
        /// <summary>
        /// Detaches and Deletes a Geometry Program.
        /// </summary>
        private void DestroyGeometryShader  ()
        {
            if (this.geometryHandle != 0)
            {
                Gl.glDetachObjectARB(this.programHandle, this.geometryHandle);

                Gl.glDeleteObjectARB(this.geometryHandle);
            }
        }
        /// <summary>
        /// Compiles Vertex Source
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        private bool CompileVertexSource     (out string error)
        {
            error = string.Empty;

            this.vertexHandle = Gl.glCreateShaderObjectARB(Gl.GL_VERTEX_SHADER);

            Gl.glShaderSourceARB(this.vertexHandle, 1, new string[] { this.vertexSource }, IntPtr.Zero);

            Gl.glCompileShaderARB(this.vertexHandle);

            // Error Checking
            
            #region Error Handling
            
            int result;

            Gl.glGetObjectParameterivARB(this.vertexHandle, Gl.GL_OBJECT_COMPILE_STATUS_ARB, out result);

            if (result == 0)
            {
                int infologlength;

                int infolength;

                Gl.glGetShaderiv(this.vertexHandle, Gl.GL_INFO_LOG_LENGTH, out infologlength);

                Gl.glGetInfoLogARB(this.vertexHandle, infologlength, out infolength, out error);

                return false;
            }
            #endregion

            return true;
        }
        /// <summary>
        /// Compiles Fragment Source
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        private bool CompileFragmentSource   (out string error)
        {
            error = string.Empty;

            this.fragmentHandle = Gl.glCreateShaderObjectARB(Gl.GL_FRAGMENT_SHADER);

            Gl.glShaderSourceARB(this.fragmentHandle, 1, new string[] { this.fragmentSource }, IntPtr.Zero);

            Gl.glCompileShaderARB(this.fragmentHandle);

            #region Error Handling

            int result;

            Gl.glGetObjectParameterivARB(this.fragmentHandle, Gl.GL_OBJECT_COMPILE_STATUS_ARB, out result);

            if (result == 0)
            {
                int infologlength;

                int infolength;

                Gl.glGetShaderiv(this.fragmentHandle, Gl.GL_INFO_LOG_LENGTH, out infologlength);

                Gl.glGetInfoLogARB(this.fragmentHandle, 8096, out infolength, out error);

                return false;
            }

            #endregion

            return true;
        }
        /// <summary>
        /// Compiles Geometry Source
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        private bool CompileGeometrySource   (out string error)
        {
            error = string.Empty;

            Gl.glProgramParameteriEXT(this.programHandle, Gl.GL_GEOMETRY_INPUT_TYPE_EXT,   (int)this.inputTopology);
           
            Gl.glProgramParameteriEXT(this.programHandle, Gl.GL_GEOMETRY_OUTPUT_TYPE_EXT,  (int)this.outputTopology);
            
            Gl.glProgramParameteriEXT(this.programHandle, Gl.GL_GEOMETRY_VERTICES_OUT_EXT, this.outputVertexCount);

            this.geometryHandle = Gl.glCreateShaderObjectARB(Gl.GL_GEOMETRY_SHADER_EXT);

            Gl.glShaderSourceARB(this.geometryHandle, 1, new string[] { this.geometrySource }, IntPtr.Zero);

            Gl.glCompileShaderARB(this.geometryHandle);

            #region Error Handling

            int result;

            Gl.glGetObjectParameterivARB(this.geometryHandle, Gl.GL_OBJECT_COMPILE_STATUS_ARB, out result);

            if (result == 0)
            {
                int infologlength;

                int infolength;

                Gl.glGetShaderiv(this.geometryHandle, Gl.GL_INFO_LOG_LENGTH, out infologlength);

                Gl.glGetInfoLogARB(this.geometryHandle, infologlength, out infolength, out error);

                return false;
            }

            #endregion

            return true;
        }
        /// <summary>
        /// Compiles all Shader Source code into a workable program. Will only
        /// compile a Shader Type, Vertex, Fragment or Geometry if the Source for
        /// each program is greater than 0 in length. 
        /// </summary>
        /// <returns></returns>
        public ShaderCompileResult Compile()
        {
            ShaderCompileResult compileResult = new ShaderCompileResult();

            // Delete the Vertex Shader
            this.DestroyVertexShader   ();

            // Delete the Fragment Shader
            this.DestroyFragmentShader ();
            
            // Delete the Geometry Shader
            this.DestroyGeometryShader ();

            // Compile Vertex Source
            if(this.vertexSource.Length > 0) 
            {
                string error = string.Empty;

                if (!this.CompileVertexSource(out error))
                {
                    compileResult.HasError = true;

                    compileResult.VertexShaderError = error;
                }
            }
            // Compile Fragment Source
            if(this.fragmentSource.Length > 0) 
            {
                string error = string.Empty;

                if (!this.CompileFragmentSource(out error))
                {
                    compileResult.HasError = true;

                    compileResult.FragmentShaderError = error;
                }
            }
             
            // Compile Geometry Source
            if(this.geometrySource.Length > 0) 
            {
                string error = string.Empty;

                if (!this.CompileGeometrySource(out error))
                {
                    compileResult.HasError = true;

                    compileResult.GeometryShaderError = error;
                }
            }

            // Exit on failer to compile shaders
            if(compileResult.HasError)
            {
                return compileResult;
            }

            if (this.vertexHandle   != 0)
            {
                Gl.glAttachObjectARB(this.programHandle, this.vertexHandle);
            }
            if (this.geometryHandle != 0)
            {
                Gl.glAttachObjectARB(this.programHandle, this.geometryHandle);
            }
            if (this.fragmentHandle != 0)
            {
                Gl.glAttachObjectARB(this.programHandle, this.fragmentHandle);
            }

            Gl.glLinkProgramARB(this.programHandle);

            #region Error Handling

            int result;

            Gl.glGetObjectParameterivARB(this.programHandle, Gl.GL_OBJECT_LINK_STATUS_ARB, out result);

            if (result == 0)
            {
                int infologlength;

                int infolength;

                Gl.glGetShaderiv(this.programHandle, Gl.GL_INFO_LOG_LENGTH, out infologlength);

                string error = string.Empty;

                Gl.glGetInfoLogARB(this.programHandle, 8096, out infolength, out error);

                compileResult.HasError    = true;

                compileResult.LinkerError = error;

                return compileResult;
            }

            #endregion

            return compileResult;
             
        }

      

        #region Pipeline

        /// <summary>
        /// Starts this Program 
        /// </summary>
        public virtual void Begin()
        {
            Gl.glUseProgram(this.programHandle);  
        }
        /// <summary>
        /// Ends this Program
        /// </summary>
        public virtual void End()
        {
            this.Flush();

            Gl.glUseProgram(0);
        }
        /// <summary>
        /// Flushes out all previously bound data while leaving the Shader still bound.
        /// </summary>
        public virtual void Flush()
        {
            for (int i = 0; i < this.texturecount; i++)
            {
                this.device.Texture[i] = null;
            }

            this.texturecount = 0;
        }

        #endregion

        #region Parameters
        public void          Parameter                     (string name, object obj)
        {
            //if (obj is int)           this.Parameter(name, (int)      obj); return;
            //if (obj is float)         this.Parameter(name, (float)    obj); return;
            //if (obj is Vector2)       this.Parameter(name, (Vector2)  obj); return;
            //if (obj is Vector3)       this.Parameter(name, (Vector3)  obj); return;
            //if (obj is Vector4)       this.Parameter(name, (Vector4)  obj); return;
            //if (obj is Matrix)        this.Parameter(name, (Matrix)   obj); return;
            //if (obj is Plane)         this.Parameter(name, (Plane)    obj); return;
            //if (obj is TextureBase)   this.Parameter(name, (TextureBase)obj); return;
            //if (obj is int    [])     this.Parameter(name, (Vector2[])obj); return;
            //if (obj is float  [])     this.Parameter(name, (Vector2[])obj); return;
            //if (obj is Vector2[])     this.Parameter(name, (Vector2[])obj); return;
            //if (obj is Vector3[])     this.Parameter(name, (Vector3[])obj); return;
            //if (obj is Vector4[])     this.Parameter(name, (Vector4[])obj); return;
            //if (obj is Matrix [])     this.Parameter(name, (Matrix [])obj); return;
            //if (obj is Plane  [])     this.Parameter(name, (Plane  [])obj); return;
        }
        public void          Parameter                     (string name, bool  x)
        {
            int handle = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var = Gl.glGetUniformLocation(this.programHandle, name);
            if (x) Gl.glUniform1iARB(var, 1); else Gl.glUniform1iARB(var, 0);
        }
        public void          Parameter                     (string name, int   x)
        {
            int handle  = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var     = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform1iARB(var, x);   
        }
        public void          Parameter                     (string name, int   x, int   y)
        {
            int handle  = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var     = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform2iARB(var, x, y);
        }
        public void          Parameter                     (string name, int   x, int   y, int   z)
        {
            int handle  = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var     = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform3iARB(var, x, y, z);
        }
        public void          Parameter                     (string name, int   x, int   y, int   z, int   w)
        {
            int handle  = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var     = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform4iARB(var, x, y, z, w);
        }
        public void          Parameter                     (string name, float x)
        {
            int handle  = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var     = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform1fARB(var, x);
        }
        public void          Parameter                     (string name, float x, float y)
        {
            int handle  = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var     = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform2fARB(var, x, y);
        }
        public void          Parameter                     (string name, float x, float y, float z)
        {
            int handle  = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var     = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform3fARB(var, x, y, z);
        }
        public void          Parameter                     (string name, float x, float y, float z, float w)
        {
            int handle  = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var     = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform4fARB(var, x, y, z, w);
        }
        public void          Parameter                     (string name, TextureBase    texture)
        {
            
            this.device.Texture[this.texturecount] = texture;
            this.Parameter(name, this.texturecount);
            this.texturecount += 1;
        }
        public void          Parameter                     (string name, Matrix      matrix)
        {
            int handle = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var    = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniformMatrix4fv(var, 1, 1, matrix.ToArray());
        }
        public void          Parameter                     (string name, Vector2     v)
        {
            this.Parameter(name, v.X, v.Y);
        }
        public void          Parameter                     (string name, Vector3     v)
        {
            this.Parameter(name, v.X, v.Y, v.Z);
        }
        public void          Parameter                     (string name, Vector4     v)
        {
            this.Parameter(name, v.X, v.Y, v.Z, v.W);
        }
        public void          Parameter                     (string name, Plane       plane)
        {
            this.Parameter(name, plane.A, plane.B, plane.C, plane.D);
        }
        public void          Parameter                     (string name, int     []  v)
        {
            int handle = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var    = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform1iv(var, v.Length, v);
        }
        public void          Parameter                     (string name, float   []  v)
        {
            int handle = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var    = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform1fv(var, v.Length, v);
        }
        public void          Parameter                     (string name, Matrix  []  m)
        {
            // Replace with pointers
            List<float> data = new List<float>();
            for (int i = 0; i < m.Length; i++)
            {
                data.AddRange(m[i].ToArray());   
            }

            int handle = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniformMatrix4fv(var, m.Length, 1, data.ToArray());
        }
        public void          Parameter                     (string name, Vector2 []  v)
        {
            // Replace with pointers
            float[] data = new float[v.Length * 2];
            int count = 0;
            for (int i = 0; i < v.Length; i++)
            {
                data[count] = v[i].X; count++;
                data[count] = v[i].Y; count++;
            }
            int handle = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform2fv(var, v.Length, data);
        }
        public void          Parameter                     (string name, Vector3 []  v)
        {
            float[] data = new float[v.Length * 3];
            int count = 0;
            for (int i = 0; i < v.Length; i++)
            {
                data[count] = v[i].X; count++;
                data[count] = v[i].Y; count++;
                data[count] = v[i].Z; count++;
            }
            int handle = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform3fv(var, v.Length, data);
        }
        public void          Parameter                     (string name, Vector4 []  v)
        {
            float[] data = new float[v.Length * 4];
            int count = 0;
            for (int i = 0; i < v.Length; i++)
            {
                data[count] = v[i].X; count++;
                data[count] = v[i].Y; count++;
                data[count] = v[i].Z; count++;
                data[count] = v[i].W; count++;
            }
            int handle = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform4fv(var, v.Length, data);
        }
        public void          Parameter                     (string name, Plane   []  v)
        {
            float[] data = new float[v.Length * 4];
            int count = 0;
            for (int i = 0; i < v.Length; i++)
            {
                data[count] = v[i].A; count++;
                data[count] = v[i].B; count++;
                data[count] = v[i].C; count++;
                data[count] = v[i].D; count++;
            }
            int handle = Gl.glGetHandleARB(Gl.GL_PROGRAM_OBJECT_ARB);
            int var = Gl.glGetUniformLocation(this.programHandle, name);
            Gl.glUniform4fv(var, v.Length, data);
        }
        public void          Parameter                     (string name, TextureBase[]  textures)
        {
            List<int> v = new List<int>();
            for (int i = 0; i < textures.Length; i++)
            {
                v.Add(this.texturecount);
                this.device.Texture[this.texturecount] = textures[i];
                this.texturecount += 1;
            }
            this.Parameter(name, v.ToArray());
        }
        #endregion

        #region IDisposable Members

        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing) 
                {
                    Gl.glUseProgram(0);
                    if (this.vertexHandle   != 0) Gl.glDeleteProgram(this.vertexHandle);
                    if (this.fragmentHandle != 0) Gl.glDeleteProgram(this.fragmentHandle);
                    if (this.programHandle  != 0) Gl.glDeleteProgram(this.programHandle);
                }

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        ~Shader()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
