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
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    #region Device

    /// <summary>
    /// Clear Flags for the Device
    /// </summary>
    public enum ClearFlags : int
    {
        Color             = Gl.GL_COLOR_BUFFER_BIT,
        Depth             = Gl.GL_DEPTH_BUFFER_BIT,
        Stencil           = Gl.GL_STENCIL_BUFFER_BIT
    }

    /// <summary>
    /// The Topology for the Input Vertices.
    /// </summary>
    public enum Topology : int
    {
        Points            = Gl.GL_POINTS,
        Lines             = Gl.GL_LINES,
        LinesAdjacency    = Gl.GL_LINES_ADJACENCY_EXT,
        Triangles         = Gl.GL_TRIANGLES,
        TriangleAdjacency = Gl.GL_TRIANGLES_ADJACENCY_EXT
    }

    #endregion

    #region FrameBuffer

    /// <summary>
    /// FrameBuffer Depth
    /// </summary>
    public enum Depth
    {
        /// <summary>
        /// Automatically choses the Default Depth Format
        /// </summary>
        Default = Gl.GL_DEPTH_COMPONENT,
        /// <summary>
        /// Uses a 16Bit Depth Buffer
        /// </summary>
        Depth16 = Gl.GL_DEPTH_COMPONENT16,
        /// <summary>
        /// Uses a 24bit Depth Buffer
        /// </summary>
        Depth24 = Gl.GL_DEPTH_COMPONENT24,
        /// <summary>
        /// Uses a 32bit Depth Buffer
        /// </summary>
        Depth32 = Gl.GL_DEPTH_COMPONENT32
    }

    #endregion

    #region VertexBuffer

    /// <summary>
    /// The FrameBuffer Access (Not exposed)
    /// </summary>
    public enum BufferAccess : int
    {
        Read      = Gl.GL_READ_ONLY,
        ReadWrite = Gl.GL_READ_WRITE,
        Write     = Gl.GL_WRITE_ONLY
    }

    /// <summary>
    /// The Buffer Usage for the Device
    /// </summary>
    public enum BufferUsage : int
    {
        Dynamic = Gl.GL_DYNAMIC_DRAW,
        Static  = Gl.GL_STATIC_DRAW,
        Stream  = Gl.GL_STREAM_DRAW
    }

    #endregion

    #region Textures

    /// <summary>
    /// The type of Texture Filtering to be used.
    /// </summary>
    public enum TextureFilter : int
    {
        /// <summary>
        /// Faster Rendering, Lower Quality (Good for GPGPU)
        /// </summary>
        Nearest = Gl.GL_NEAREST,
        /// <summary>
        /// Slower Rendering, Higher Quality. (Used mostly except in cases of GPGPU)
        /// </summary>
        Linear  = Gl.GL_LINEAR
    }

    /// <summary>
    /// Specifies a Cubemap Face
    /// </summary>
    public enum TextureCubeFace : int
    {
        PositiveX = Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_X,
        NegativeX = Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_X,
        PositiveY = Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_Y,
        NegativeY = Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,
        PositiveZ = Gl.GL_TEXTURE_CUBE_MAP_POSITIVE_Z,
        NegativeZ = Gl.GL_TEXTURE_CUBE_MAP_NEGATIVE_Z,
    }
    
    /// <summary>
    /// The Internal Format used for a OpenGL Texture.
    /// </summary>
    public enum TextureFormat : int
    {
        /// <summary>
        /// 4 Bits, 1 channel
        /// </summary>
        ALPHA4 	            = Gl.GL_ALPHA4,
        /// <summary>
        /// 8 bits, 1 channel
        /// </summary>
        ALPHA8 	   	        = Gl.GL_ALPHA8,
        /// <summary>
        /// 12 bits, 1 channel
        /// </summary>
        ALPHA12 	        = Gl.GL_ALPHA12,
        /// <summary>
        /// 16 bit float, 1 channel
        /// </summary>
        ALPHA16             = Gl.GL_ALPHA16,
        /// <summary>
        /// 32 bit float, 1 channel
        /// </summary>
        ALPHA32             = Gl.GL_ALPHA32F_ARB,
        /// <summary>
        /// 4 bits, 1 channel
        /// </summary>
        LUMINANCE4          = Gl.GL_LUMINANCE4,
        /// <summary>
        /// 8 bits, 1 channel
        /// </summary>
        LUMINANCE8          = Gl.GL_LUMINANCE8,
        /// <summary>
        /// 12 bits, 1 channel
        /// </summary>
        LUMINANCE12         = Gl.GL_LUMINANCE12,
        /// <summary>
        /// 16 bit float, 1 channel
        /// </summary>
        LUMINANCE16         = Gl.GL_LUMINANCE16,
        /// <summary>
        /// 32 bit float, 1 channel
        /// </summary>
        LUMINANCE32         = Gl.GL_LUMINANCE32F_ARB,
        /// <summary>
        /// 4 bits, 2 channels
        /// </summary>
        LUMINANCE4_ALPHA4   = Gl.GL_LUMINANCE4_ALPHA4,
        /// <summary>
        /// 6 bit Luminance, 2 bit Alpha, 2 Channels
        /// </summary>
        LUMINANCE6_ALPHA2   = Gl.GL_LUMINANCE6_ALPHA2,
        /// <summary>
        /// 8 bit Luminance, 8 bit Alpha, 2 channels
        /// </summary>
        LUMINANCE8_ALPHA8   = Gl.GL_LUMINANCE8_ALPHA8,
        /// <summary>
        /// 12 bit Luminance, 4 bit Alpha, 2 channels
        /// </summary>
        LUMINANCE12_ALPHA4  = Gl.GL_LUMINANCE12_ALPHA4,
        /// <summary>
        /// 12 bit float Luminance, 12 bit float Alpha, 2 channels
        /// </summary>
        LUMINANCE16_ALPHA16 = Gl.GL_LUMINANCE16_ALPHA16,
        /// <summary>
        /// 32 bit float Luminance, 32 bit float Alpha, 2 channels
        /// </summary>
        LUMINANCE32_ALPHA32 = Gl.GL_LUMINANCE_ALPHA32F_ARB,
        /// <summary>
        /// 4 bits, 1 channel
        /// </summary>
        INTENSITY4          = Gl.GL_INTENSITY4,
        /// <summary>
        /// 8 bits, 1 channel
        /// </summary>
        INTENSITY8          = Gl.GL_INTENSITY8,
        /// <summary>
        /// 12 bits, 1 channel
        /// </summary>
        INTENSITY12         = Gl.GL_INTENSITY12,
        /// <summary>
        /// 16 bit float, 1 channel
        /// </summary>
        INTENSITY16         = Gl.GL_INTENSITY16,
        /// <summary>
        /// 16 bit float, 1 channel
        /// </summary>
        INTENSITY32         = Gl.GL_INTENSITY32F_ARB,
        /// <summary>
        /// 3 bit red, 3 bit green, 2 bit blue, 3 channels
        /// </summary>
        R3_G3_B2            = Gl.GL_R3_G3_B2,
        /// <summary>
        /// 4 bit red, 4 bit green, 4 bit blue, 3 channels
        /// </summary>
        RGB4                = Gl.GL_RGB4,
        /// <summary>
        /// 5 bit red, 5 bit green, 5 bit blue, 3 channels
        /// </summary>
        RGB5                = Gl.GL_RGB5,
        /// <summary>
        /// 8 bit red, 8 bit green, 8 bit blue, 3 channels
        /// </summary>
        RGB8                = Gl.GL_RGB8,
        /// <summary>
        /// 10 bit red, 10 bit green, 10 bit blue, 3 channels
        /// </summary>
        RGB10               = Gl.GL_RGB10,
        /// <summary>
        /// 12 bit red, 12 bit green, 12 bit blue, 3 channels
        /// </summary>
        RGB12               = Gl.GL_RGB12,
        /// <summary>
        /// 16 bit float red, 16 bit float green, 16 bit float blue, 3 channels
        /// </summary>
        RGB16               = Gl.GL_RGB16,
        /// <summary>
        /// 32 bit float red, 32 bit float green, 32 bit float blue, 3 channels
        /// </summary>
        RGB32               = Gl.GL_RGB32F_ARB,
        /// <summary>
        /// 2 bit red, 2 bit green, 2 bit blue, 2 bit alpha 4 channels
        /// </summary>
        RGBA2               = Gl.GL_RGBA2,
        /// <summary>
        /// 4 bit red, 4 bit green, 4 bit blue, 4 bit alpha 4 channels
        /// </summary>
        RGBA4               = Gl.GL_RGBA4,
        /// <summary>
        /// 5 bit red, 5 bit green, 5 bit blue, 1 bit alpha 4 channels
        /// </summary>
        RGB5_A1             = Gl.GL_RGB5_A1,
        /// <summary>
        /// 8 bit red, 8 bit green, 8 bit blue, 8 bit alpha 4 channels
        /// </summary>
        RGBA8               = Gl.GL_RGBA8,
        /// <summary>
        /// 10 bit red, 10 bit green, 10 bit blue, 2 bit alpha 4 channels
        /// </summary>
        RGB10_A2            = Gl.GL_RGB10_A2,
        /// <summary>
        /// 12 bit red, 12 bit green, 12 bit blue, 12 bit alpha 4 channels
        /// </summary>
        RGBA12              = Gl.GL_RGBA12,
        /// <summary>
        /// 16 bit float red, 16 bit float green, 16 bit float blue, 16 bit float alpha 4 channels
        /// </summary>
        RGBA16              = Gl.GL_RGBA16,
        /// <summary>
        /// 32 bit float red, 32 bit float green, 32 bit float blue, 32 bit float alpha 4 channels
        /// </summary>
        RGBA32              = Gl.GL_RGBA32F_ARB,
        /// <summary>
        /// 16 bit Depth component texture format
        /// </summary> 
        DEPTH16             = Gl.GL_DEPTH_COMPONENT16,
        /// <summary>
        /// 24 bit Depth component texture format
        /// </summary> 
        DEPTH24             = Gl.GL_DEPTH_COMPONENT24,
        /// <summary>
        /// 32 bit Depth component texture format
        /// </summary> 
        DEPTH32             = Gl.GL_DEPTH_COMPONENT32,

    }
       
 
    #endregion

    #region Vertex Declarations

    /// <summary>
    /// <para>GLSL Bindings</para>
    /// <para>Part of the Vertex Declaration. When passing streams of Vertex 
    /// data to the GPU, there needs to be a mapping between the GLSL sematics 
    /// and the element. This specifies what element corrosponds
    /// to what GLSL binding.</para>
    /// </summary>
    public enum ElementBinding
    {
        /// <summary>
        /// gl_Vertex
        /// </summary>
        Vertex,
        /// <summary>
        /// gl_Normal
        /// </summary>
        Normal,
        /// <summary>
        /// gl_Color
        /// </summary>
        Color,
        /// <summary>
        /// gl_MultiTexCoord2
        /// </summary>
        MultiTexCoord0,
        /// <summary>
        /// gl_MultiTexCoord1
        /// </summary>
        MultiTexCoord1,
        /// <summary>
        /// gl_MultiTexCoord2
        /// </summary>
        MultiTexCoord2,
        /// <summary>
        /// gl_MultiTexCoord3
        /// </summary>
        MultiTexCoord3,
        /// <summary>
        /// gl_MultiTexCoord4
        /// </summary>
        MultiTexCoord4,
        /// <summary>
        /// gl_MultiTexCoord5
        /// </summary>
        MultiTexCoord5,
        /// <summary>
        /// gl_MultiTexCoord6
        /// </summary>
        MultiTexCoord6,
        /// <summary>
        /// gl_MultiTexCoord7
        /// </summary>
        MultiTexCoord7,
        /// <summary>
        /// gl_MultiTexCoord8
        /// </summary>
        MultiTexCoord8,
        /// <summary>
        /// gl_MultiTexCoord9
        /// </summary>
        MultiTexCoord9,
        /// <summary>
        /// gl_MultiTexCoord10
        /// </summary>
        MultiTexCoord10,
        /// <summary>
        /// gl_MultiTexCoord11
        /// </summary>
        MultiTexCoord11,
        /// <summary>
        /// gl_MultiTexCoord12
        /// </summary>
        MultiTexCoord12,
        /// <summary>
        /// gl_MultiTexCoord13
        /// </summary>
        MultiTexCoord13,
        /// <summary>
        /// gl_MultiTexCoord14
        /// </summary>
        MultiTexCoord14,
        /// <summary>
        /// gl_MultiTexCoord15
        /// </summary>
        MultiTexCoord15

    }

    /// <summary>
    /// <para>Element Type</para>
    /// <para>Specifies the Type of the Vertex Element being passed to the GPU. In most cases the ElementType
    /// will be of type Float. However, there are instances where other types will be useful as part of a vertex stream</para>
    /// <para>Note: According to the OpenGL 3.0 prelimanary spec, there is talk about double precision being removed.
    /// The use of double precision should be discouraged.</para>
    /// </summary>
    public enum ElementType
    {
        Byte         = Gl.GL_BYTE,
        UByte        = Gl.GL_UNSIGNED_BYTE,
        Short        = Gl.GL_SHORT,
        Int          = Gl.GL_INT,
        UInt         = Gl.GL_UNSIGNED_INT,
        Float        = Gl.GL_FLOAT,
        Double       = Gl.GL_DOUBLE
    }

    #endregion

    #region State

    /// <summary>
    /// Defines a Hint 
    /// </summary>
    public enum Hint
    {
        Fastest  = Gl.GL_FASTEST,
        Nicest   = Gl.GL_NICEST,
        DontCare = Gl.GL_DONT_CARE
    }

    /// <summary>
    /// Defines a Face
    /// </summary>
    public enum Face
    {
        Front        = Gl.GL_FRONT,
        Back         = Gl.GL_BACK,
        FrontAndBack = Gl.GL_FRONT_AND_BACK
    }

    /// <summary>
    /// Defines a Raster Mode
    /// </summary>
    public enum RasterMode
    {
        Point = Gl.GL_POINT,
        Line  = Gl.GL_LINE,
        Fill  = Gl.GL_FILL
    }

    /// <summary>
    /// Defines a Logic Op
    /// </summary>
    public enum LogicOp
    {
        Never          = Gl.GL_NEVER,
        Always         = Gl.GL_ALWAYS,
        LessThan       = Gl.GL_LESS,
        EqualTo        = Gl.GL_EQUAL,
        LessOrEqual    = Gl.GL_LEQUAL,
		GreaterThan    = Gl.GL_GREATER,
        NotEqual       = Gl.GL_NOTEQUAL,
        GreaterOrEqual = Gl.GL_GEQUAL 	
    }

     
    /// <summary>
    /// Defines a Src and Dst Factor
    /// </summary>
    public enum Factor
    {
        Zero                    = Gl.GL_ZERO,
        One                     = Gl.GL_ONE,
        DstColor                = Gl.GL_DST_COLOR,
        OneMinusDstColor        = Gl.GL_ONE_MINUS_DST_COLOR,
        SrcAlpha                = Gl.GL_SRC_ALPHA,
        OneMinusSrcAlpha        = Gl.GL_ONE_MINUS_SRC_ALPHA,
        DstAlpha                = Gl.GL_DST_ALPHA,
        SrcAlphaSaturate        = Gl.GL_SRC_ALPHA_SATURATE,
        ConstantColor           = Gl.GL_CONSTANT_COLOR,
        OneMinusConstantColor   = Gl.GL_ONE_MINUS_CONSTANT_COLOR,
        ConstantAlpha           = Gl.GL_CONSTANT_ALPHA,
        OneMinusConstantAlpha   = Gl.GL_ONE_MINUS_CONSTANT_ALPHA 
    }

    #endregion

}
