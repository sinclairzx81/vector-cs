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

namespace Vector.Gpu
{
    /// <summary>
    /// All Resources implement this Interface. A Resource is any data 
    /// kept on the Graphics Card.
    /// </summary>
    public interface IResource : IDisposable
    {
        Device Device { get; }
        int    Handle { get; }
    }

    public interface IBuffer   : IResource
    { 
        int  SizeInBytes { get; }
        T[]  GetData<T>  () where T : struct;
        void SetData<T>  (    T[] data) where T : struct;
    }

    public interface IFrameBuffer
    {
        void Clear(float red, float blue, float green, float alpha);
        void Begin(Texture2D    texture,  Depth depth);
 
        void Dispose();
        void End();
    }

    public interface IShader
    {
        void AppendFragmentSource(params string[] sources);
        void AppendGeometrySource(params string[] sources);
        void AppendVertexSource(params string[] sources);
        void Begin();
        void ClearFragmentSource();
        void ClearGeometrySource();
        void ClearVertexSource();
        bool Compile(out string errors);
        Device Device { get; }
        void Dispose();
        void End();
        string FragmentSource { get; }
        string GeometrySource { get; }
        int Handle { get; }
        Topology InputTopology { get; set; }
        Topology OutputTopology { get; set; }
        int OutputVertexCount { get; set; }
        void Parameter(string name, int[] v);
        void Parameter(string name, float[] v);
        void Parameter(string name, Vector.Math.Matrix[] m);
        void Parameter(string name, Vector.Math.Vector3 v);
        void Parameter(string name, Vector.Math.Vector4 v);
        void Parameter(string name, Vector.Math.Plane plane);
        void Parameter(string name, Vector.Math.Plane[] v);
        void Parameter(string name, TextureBase[] textures);
        void Parameter(string name, int x, int y);
        void Parameter(string name, Vector.Math.Vector2[] v);
        void Parameter(string name, Vector.Math.Vector3[] v);
        void Parameter(string name, Vector.Math.Vector4[] v);
        void Parameter(string name, Vector.Math.Vector2 v);
        void Parameter(string name, int x, int y, int z);
        void Parameter(string name, int x, int y, int z, int w);
        void Parameter(string name, int x);
        void Parameter(string name, object obj);
        void Parameter(string name, bool x);
        void Parameter(string name, float x);
        void Parameter(string name, float x, float y, float z, float w);
        void Parameter(string name, TextureBase texture);
        void Parameter(string name, Vector.Math.Matrix matrix);
        void Parameter(string name, float x, float y);
        void Parameter(string name, float x, float y, float z);
        string VertexSource { get; }
    }
}
