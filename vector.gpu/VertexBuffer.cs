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
using System.Runtime.InteropServices;
using Vector.Gpu.OpenGL;

namespace Vector.Gpu
{
    unsafe public class VertexBuffer : IBuffer, IDisposable
    {
        private Device            device;
        private VertexDeclaration vertexDeclaration;
        private BufferUsage       usage;
        private int               handle;
        private int               sizeInBytes;

        public VertexBuffer(Device device, VertexDeclaration vertexDeclaration, BufferUsage usage)  
        {
            this.device            = device;
            this.usage             = usage;
            this.vertexDeclaration = vertexDeclaration;
            Gl.glGenBuffersARB(1, out this.handle);
        }

        public VertexBuffer(Device device, Type vertexType, BufferUsage usage) : this(device, VertexDeclaration.GetDeclarationFromType(vertexType), usage){ }

    
        public VertexBuffer(Device device, VertexElement element, BufferUsage usage) : this(device, new VertexDeclaration(new VertexElement[] { element }), usage) { }


        #region Properties

        /// <summary>
        /// The Device
        /// </summary>
        public Device            Device      
        {
            get { return this.device; }
        }
        /// <summary>
        /// The OpenGL Handle for this VertexBuffer
        /// </summary>
        public int               Handle      
        {
            get { return this.handle; }
        }
        /// <summary>
        /// The Buffer Usage
        /// </summary>
        public BufferUsage       Usage       
        {
            get { return this.usage;  }
        }
        /// <summary>
        /// Returns the size of the Graphics Buffer in Bytes.
        /// </summary>
        public int               SizeInBytes 
        {
            get
            {
                return this.sizeInBytes; 
            }
        }
        /// <summary>
        /// Gets or sets this Vertex Buffers Declaration. 
        /// </summary>
        public VertexDeclaration VertexDeclaration
        {
            get { return this.vertexDeclaration; }
            set { this.vertexDeclaration = value; }
        }

        #endregion



        /// <summary>
        /// Reads a graphics buffer in a array of the specified value type.  
        /// </summary>
        /// <typeparam name="T">Any value type</typeparam>
        /// <returns>A graphics buffer</returns>
        public T [] GetData<T>() where T         : struct 
        {
            Gl.glBindBuffer(Gl.GL_ARRAY_BUFFER, this.handle);
            IntPtr cachePointer = Gl.glMapBuffer(Gl.GL_ARRAY_BUFFER, (int)BufferAccess.Read);  
            byte [] buffer = new byte[this.sizeInBytes];
            Marshal.Copy(cachePointer, buffer, 0, buffer.Length);
            T    [] data = new T[this.sizeInBytes / Marshal.SizeOf(typeof(T))];
            GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
            IntPtr   p      = handle.AddrOfPinnedObject();
            Marshal.Copy(buffer, 0, p, buffer.Length);
            handle.Free();
            Gl.glUnmapBuffer(Gl.GL_ARRAY_BUFFER);
            return data;
        }
        /// <summary>
        /// Fills this graphics buffer with data.
        /// </summary>
        /// <typeparam name="T">(optional) Any value type.</typeparam>
        /// <param name="data">An array of any value type.</param>
        public void SetData<T>(T[] data) where T : struct 
        { 
            this.sizeInBytes = Marshal.SizeOf(typeof(T)) * data.Length;
            Gl.glBindBuffer(Gl.GL_ARRAY_BUFFER, this.handle);
            Gl.glBufferData(Gl.GL_ARRAY_BUFFER, (IntPtr)(Marshal.SizeOf(typeof(T)) * data.Length), data, (int)this.usage);
        }
        /// <summary>
        /// Fills a subset of this graphics buffer with data.
        /// </summary>
        /// <typeparam name="T">Any value type.</typeparam>
        /// <param name="data">any value array</param>
        /// <param name="start">The start offset to being writing. (Is computed relative to the size of the type passed.)</param>
        /// <param name="length">The number of items to write. (Is computed relative to the size of the type passed.)</param>
        public void SetData<T>(T [] data, int start, int length) where T : struct
        {
            int typesize = Marshal.SizeOf(typeof(T));
            int offset   = typesize * start;
            int size     = (length * typesize);
            Gl.glBindBuffer(Gl.GL_ARRAY_BUFFER, this.handle);
            Gl.glBufferSubData (Gl.GL_ARRAY_BUFFER, (IntPtr)offset, (IntPtr)size, data);
        }

        #region IDisposible Members

        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Gl.glDeleteBuffers(1, ref this.handle);
                }

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        ~VertexBuffer()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
