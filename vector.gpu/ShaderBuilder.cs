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
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Vector.Gpu
{
    #region Format Structures
    public class Include       
    {
        private string source;

        public Include()
        {
            this.source = string.Empty;
        }

        #region Properties

        public string Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        #endregion
    }
    public class VertexShader  
    {
        private List<Include> includes;

        public VertexShader()
        {
            this.includes = new List<Include>();
        }

        #region Properties

        public List<Include> Includes
        {
            get { return this.includes; }
            set { this.includes = value; }
        }

        #endregion
    }
    public class FragmentShader
    {
        private List<Include> includes;

        public FragmentShader()
        {
            this.includes = new List<Include>();
        }

        #region Properties

        public List<Include> Includes
        {
            get { return this.includes; }
            set { this.includes = value; }
        }

        #endregion
    }
    public class GeometryShader
    {
        private List<Include> includes;
        private Topology inputTopology;
        private Topology outputTopology;
        private int outputVertexCount;

        public GeometryShader()
        {
            this.includes = new List<Include>();
            this.inputTopology = Topology.Triangles;
            this.outputTopology = Topology.Triangles;
            this.outputVertexCount = 0;
        }

        #region Properties
        public List<Include> Includes
        {
            get { return this.includes; }
            set { this.includes = value; }
        }
        public Topology InputTopology
        {
            get { return this.inputTopology; }
            set { this.inputTopology = value; }
        }
        public Topology OutputTopology
        {
            get { return this.outputTopology; }
            set { this.outputTopology = value; }
        }
        public int OutputVertexCount
        {
            get { return this.outputVertexCount; }
            set { this.outputVertexCount = value; }
        }
        #endregion
    }
    public class Program       
    {
        private string id;
        private VertexShader vertexShader;
        private GeometryShader geometryShader;
        private FragmentShader fragmentShader;

        public Program()
        {
            this.id = string.Empty;
            this.vertexShader = null;
            this.fragmentShader = null;
            this.geometryShader = null;
        }

        #region Properties
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public VertexShader VertexShader
        {
            get { return this.vertexShader; }
            set { this.vertexShader = value; }
        }
        public GeometryShader GeometryShader
        {
            get { return this.geometryShader; }
            set { this.geometryShader = value; }
        }
        public FragmentShader FragmentShader
        {
            get { return this.fragmentShader; }
            set { this.fragmentShader = value; }
        }
        #endregion
    }
    public class Pass          
    {
        private string program;
        private string id;

        public Pass()
        {
            this.program = string.Empty;
            this.id = string.Empty;
        }

        #region Properties
        public string Program
        {
            get { return this.program; }
            set { this.program = value; }
        }
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        #endregion
    }
    public class Source        
    {
        private string id;
        private string code;

        public Source()
        {
            this.id = string.Empty;
            this.code = string.Empty;
        }

        #region Properties

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        #endregion
    }
    
    /// <summary>
    /// Vector Shader Builder. A utility to load Shader source code from a fragmented XML document.
    /// Shader source code can be compiled into working programs. See Specification for Format.
    /// </summary>
    public class ShaderLibrary
    {
        private List<Source>  sources;
        private List<Program> programs;
        private List<Pass>    passes;

        public ShaderLibrary()
        {
            this.sources  = new List<Source> ();
            this.programs = new List<Program>();
            this.passes   = new List<Pass>   ();
        }

        public List<Source>  Sources  
        {
            get { return this.sources; }
            set { this.sources = value; }
        }
        public List<Program> Programs 
        {
            get { return this.programs; }
            set { this.programs = value;}
        }
        public List<Pass>    Passes   
        {
            get { return this.passes; }
            set { this.passes = value;}
        }
        
        


        #region Loader
        private static void  read_include         (Include             include,        XElement element)
        {
            foreach (XAttribute a in element.Attributes())
            {
                if (a.Name == "source") include.Source = a.Value;
            }
        }
        private static void  read_geometry_shader (GeometryShader      geometryShader, XElement element)
        {
            foreach (XAttribute a in element.Attributes())
            {
                if (a.Name == "inputTopology")
                {
                    switch (a.Value)
                    {
                        case "points":   geometryShader.InputTopology = Topology.Points;    break;
                        case "lines":    geometryShader.InputTopology = Topology.Lines;     break;
                        case "triangle": geometryShader.InputTopology = Topology.Triangles; break;
                        default: geometryShader.InputTopology = Topology.Triangles; break;
                    }
                }

                if (a.Name == "outputTopology")
                {
                    switch (a.Value)
                    {
                        case "points":   geometryShader.OutputTopology = Topology.Points; break;
                        case "lines":    geometryShader.OutputTopology = Topology.Lines; break;
                        case "triangle": geometryShader.OutputTopology = Topology.Triangles; break;
                        default: geometryShader.OutputTopology = Topology.Triangles; break;
                    }
                }

                if (a.Name == "outputVertexCount")
                {
                    int result = 0;

                    int.TryParse(a.Value, out result);

                    geometryShader.OutputVertexCount = result;
                }
            }

            foreach (XElement e in element.Elements())
            {
                if (e.Name == "include")
                {
                    Include include = new Include();

                    read_include(include, e);

                    geometryShader.Includes.Add(include);
                }
            }
        }
        private static void  read_fragment_shader (FragmentShader      fragmentShader, XElement element)
        {
            foreach (XElement e in element.Elements())
            {
                if (e.Name == "include")
                {
                    Include include = new Include();

                    read_include(include, e);

                    fragmentShader.Includes.Add(include);
                }
            }
        }
        private static void  read_vertex_shader   (VertexShader        vertexShader,   XElement element)
        {
            foreach (XElement e in element.Elements())
            {
                if (e.Name == "include")
                {
                    Include include = new Include();

                    read_include(include, e);

                    vertexShader.Includes.Add(include);
                }
            }
        }
        private static void  read_program         (Program             program,        XElement element)
        {
            foreach (XAttribute a in element.Attributes())
            {
                if (a.Name == "id") program.ID = a.Value;
            }

            foreach (XElement e in element.Elements())
            {
                if (e.Name.LocalName.ToLower() == "vertexshader")
                {
                    program.VertexShader = new VertexShader();

                    read_vertex_shader(program.VertexShader, e);
                }

                if (e.Name.LocalName.ToLower() == "fragmentshader")
                {
                    program.FragmentShader = new FragmentShader();

                    read_fragment_shader(program.FragmentShader, e);
                }
                
                if (e.Name.LocalName.ToLower() == "geometryshader")
                {
                    program.GeometryShader = new GeometryShader();

                    read_geometry_shader(program.GeometryShader, e);
                }
            }
        }
        private static void  read_source          (Source              source,         XElement element)
        {
            foreach (XAttribute a in element.Attributes())
            {
                if (a.Name == "id") source.ID = a.Value;
            }

            source.Code = element.Value;
        }
        private static void  read_library         (ShaderLibrary       effect,         XElement element)
        {
            foreach(XElement e in element.Elements())
            {
                if (e.Name.LocalName.ToLower() == "source")
                {
                    Source source = new Source();

                    read_source(source, e);

                    effect.sources.Add(source);

                }
                if (e.Name.LocalName.ToLower() == "program")
                {
                    Program program = new Program();

                    read_program(program, e);

                    effect.programs.Add(program);
                }

               
            }
        }
        public  static       ShaderLibrary Load   (string filename)
        {
            XDocument document = XDocument.Load(filename);

            ShaderLibrary library = new ShaderLibrary();

            read_library(library, document.Root);

            return library;
        }
        public  static       ShaderLibrary Parse  (string xml)
        {
            XDocument document = XDocument.Parse(xml);

            ShaderLibrary library = new ShaderLibrary();

            read_library(library, document.Root);

            return library;
        }
        #endregion
    }
    #endregion

    public static class ShaderBuilder
    {
        /// <summary>
        /// Compiles Shaders related to this effect.
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public static Shader Compile(Device device, ShaderLibrary library, string programId)
        {
            foreach (Program program in (from n in library.Programs where n.ID == programId select n))
            {
                Shader shader = new Shader(device);

                if (program.VertexShader != null)
                {
                    foreach (Source source in from   n in program.VertexShader.Includes
                                              from   m in library.Sources
                                              where  n.Source == m.ID
                                              select m)

                        shader.AppendVertexSource(source.Code);
                }

                if (program.GeometryShader != null)
                {
                    shader.InputTopology     = program.GeometryShader.InputTopology;
                    shader.OutputTopology    = program.GeometryShader.OutputTopology;
                    shader.OutputVertexCount = program.GeometryShader.OutputVertexCount;
                    foreach (Source source in from   n in program.GeometryShader.Includes
                                              from   m in library.Sources
                                              where  n.Source == m.ID
                                              select m)

                        shader.AppendGeometrySource(source.Code);

                }

                if (program.FragmentShader != null)
                {
                    foreach (Source source in from   n in program.FragmentShader.Includes
                                              from   m in library.Sources
                                              where  n.Source == m.ID
                                              select m)

                    shader.AppendFragmentSource(source.Code);
                }


                ShaderCompileResult compileResult = shader.Compile();

                if (!compileResult.HasError)
                {
                    return shader;
                }
                else
                {
                    throw new Exception(compileResult.Summary);
                }
            }

            return null;
        }

        /// <summary>
        /// Compiles Shaders related to this effect.
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public static List<Shader> CompileAll(Device device, ShaderLibrary library)
        {
            List<Shader> shaders = new List<Shader>();

            foreach (Program program in library.Programs)
            {
                Shader shader = new Shader(device);

                if (program.VertexShader != null)
                {
                    foreach (Source source in from   n in program.VertexShader.Includes
                                              from   m in library.Sources
                                              where  n.Source == m.ID
                                              select m)

                        shader.AppendVertexSource(source.Code);
                }

                if (program.GeometryShader != null)
                {
                    shader.InputTopology     = program.GeometryShader.InputTopology;
                    shader.OutputTopology    = program.GeometryShader.OutputTopology;
                    shader.OutputVertexCount = program.GeometryShader.OutputVertexCount;
                    foreach (Source source in from   n in program.GeometryShader.Includes
                                              from   m in library.Sources
                                              where  n.Source == m.ID
                                              select m)

                        shader.AppendGeometrySource(source.Code);

                }

                if (program.FragmentShader != null)
                {
                    foreach (Source source in from   n in program.FragmentShader.Includes
                                              from   m in library.Sources
                                              where  n.Source == m.ID
                                              select m)

                        shader.AppendFragmentSource(source.Code);
                }


                ShaderCompileResult compileResult = shader.Compile();

                if (!compileResult.HasError)
                {
                    shaders.Add(shader);
                }
                else
                {
                    throw new Exception(compileResult.Summary);
                }
            }

            return shaders;
        }


        public static string DefaultVertexShader 
        {
            get
            {
                return @"
                vec3 mulv3m4(vec3 v, mat4 m)
                {
                    return normalize(vec3( vec4(v, 0) * m ));
                }

                vec3 mulv3m4(mat4 m, vec3 v)
                {
                    return normalize(vec3( vec4(v, 0) * m ));
                }

                uniform mat4   world;
                uniform mat4   view;
                uniform mat4   projection;

                varying vec4   position;
                varying vec3   normal;
                varying vec3   tangent;
                varying vec3   binormal;
                varying vec4   texcoord;

                void main(void)
                {
                    gl_Position = gl_Vertex * (world * (view * projection));
                    position    = gl_Vertex * world;
                    texcoord    = gl_MultiTexCoord0;
                    normal      = mulv3m4(gl_Normal, world);
                    tangent     = mulv3m4(gl_MultiTexCoord1.xyz, world);
                    binormal    = mulv3m4(gl_MultiTexCoord2.xyz, world);
                }
            ";
            }
        }
    
    }
}
