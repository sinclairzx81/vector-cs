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
