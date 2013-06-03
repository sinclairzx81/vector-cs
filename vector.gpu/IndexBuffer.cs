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
    /// <summary>
    /// <para>IndexBuffer</para>
    /// <para>An IndexBuffer connects vertices into primities</para>
    /// </summary>
    unsafe public class IndexBuffer : IDisposable
    {
        private Device        device;
        private BufferUsage   usage;
        private int           handle;
        private int           count;

        public IndexBuffer(Device device, BufferUsage usage)  
        {
            this.device = device;

            this.usage = usage;

            Gl.glGenBuffersARB(1, out this.handle);
        }

        #region IResource<uint> Members
        
        /// <summary>
        /// The Device
        /// </summary>
        public Device              Device
        {
            get { return this.device; }
        }
        /// <summary>
        /// The OpenGL Handle for this Index Buffer.
        /// </summary>
        public int                 Handle
        {
            get { return this.handle;  }
        }
        /// <summary>
        /// The Buffer Usage 
        /// </summary>
        public BufferUsage         Usage
        {
            get { return this.usage; }
        }
        /// <summary>
        /// The number of indices in this buffer.
        /// </summary>
        public int                 Count
        {
            get { return this.count; }
        }
        /// <summary>
        /// Gets the Index data in this buffer
        /// </summary>
        /// <returns>An array of indices.</returns>
        public uint             [] GetData()
        {
            Gl.glBindBuffer(Gl.GL_ELEMENT_ARRAY_BUFFER, this.handle);
            IntPtr cachePointer = Gl.glMapBuffer(Gl.GL_ELEMENT_ARRAY_BUFFER, (int)BufferAccess.Read);
            byte [] buffer = new byte[this.count * Marshal.SizeOf(typeof(uint))];
            Marshal.Copy(cachePointer, buffer, 0, buffer.Length);
            uint[] data = new uint[this.count];
            GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
            IntPtr p = handle.AddrOfPinnedObject();
            Marshal.Copy(buffer, 0, p, buffer.Length);
            handle.Free();
            Gl.glUnmapBuffer(Gl.GL_ELEMENT_ARRAY_BUFFER);
            return data;
        }
        /// <summary>
        /// Sets the indices for this buffer.
        /// </summary>
        /// <param name="data">An array of unsigned integers</param>
        public void SetData(uint[] data)
        {
            this.count = data.Length;
            Gl.glBindBuffer(Gl.GL_ELEMENT_ARRAY_BUFFER, this.handle);
            Gl.glBufferData(Gl.GL_ELEMENT_ARRAY_BUFFER, (IntPtr)(Marshal.SizeOf(typeof(uint)) * data.Length), data, (int)this.usage);
        }
        /// <summary>
        /// Sets the indices for this buffer.
        /// </summary>
        /// <param name="data">An array of unsigned integers</param>
        /// <param name="start">The index to start</param>
        /// <param name="length">The length of the buffer</param>
        public void SetData(uint[] data, int start, int length)
        {
            int typesize = Marshal.SizeOf(typeof(uint));
            int offset   = typesize * start;
            int size     = (length * typesize);
            Gl.glBindBuffer(Gl.GL_ELEMENT_ARRAY_BUFFER, this.handle);
            Gl.glBufferSubData(Gl.GL_ELEMENT_ARRAY_BUFFER, (IntPtr)offset, (IntPtr)size, data);
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
                    Gl.glDeleteBuffers(1, ref this.handle);
                }

                this.disposed = true;
            }
        }
        /// <summary>
        /// Disposes this IndexBuffer
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        ~IndexBuffer()
        {
            this.Dispose(false);
        }
        #endregion
    }
}
