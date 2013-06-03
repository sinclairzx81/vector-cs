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

using System.Runtime.InteropServices;

using Vector.Win32;

namespace Vector.Gpu
{
    public class Presentation 
    {
        public Gdi.PIXELFORMATDESCRIPTOR pfd;

        public Presentation()
        {
            this.pfd = new Gdi.PIXELFORMATDESCRIPTOR();     
        }
        /// <summary>
        /// Default Presentation Mode. (DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER, 16 BIT DEPTH, RGBA PIXEL TYPE)
        /// </summary>
        public static Presentation Default
        {
            get
            {
                Presentation p = new Presentation();

                p.pfd = new Gdi.PIXELFORMATDESCRIPTOR();    // pfd Tells Windows How We Want Things To Be
                p.pfd.nSize = (short)Marshal.SizeOf(p.pfd);                            // Size Of This Pixel Format Descriptor
                p.pfd.nVersion = 1;                                                   // Version Number
                p.pfd.dwFlags = Gdi.PFD_DRAW_TO_WINDOW |                              // Format Must Support Window
                              Gdi.PFD_SUPPORT_OPENGL |                                        // Format Must Support OpenGL
                              Gdi.PFD_DOUBLEBUFFER;                                           // Format Must Support Double Buffering
                p.pfd.iPixelType = (byte)Gdi.PFD_TYPE_RGBA;                          // Request An RGBA Format
                p.pfd.cColorBits = (byte)32;                                       // Select Our Color Depth
                p.pfd.cRedBits = 0;                                                   // Color Bits Ignored
                p.pfd.cRedShift = 0;
                p.pfd.cGreenBits = 0;
                p.pfd.cGreenShift = 0;
                p.pfd.cBlueBits = 0;
                p.pfd.cBlueShift = 0;
                p.pfd.cAlphaBits = 0;                                                 // No Alpha Buffer
                p.pfd.cAlphaShift = 0;                                                // Shift Bit Ignored
                p.pfd.cAccumBits = 0;                                                 // No Accumulation Buffer
                p.pfd.cAccumRedBits = 0;                                              // Accumulation Bits Ignored
                p.pfd.cAccumGreenBits = 0;
                p.pfd.cAccumBlueBits = 0;
                p.pfd.cAccumAlphaBits = 0;
                p.pfd.cDepthBits = 16;                                                // 16Bit Z-Buffer (Depth Buffer)
                p.pfd.cStencilBits = 0;                                               // No Stencil Buffer
                p.pfd.cAuxBuffers = 0;                                                // No Auxiliary Buffer
                p.pfd.iLayerType = (byte)Gdi.PFD_MAIN_PLANE;                         // Main Drawing Layer
                p.pfd.bReserved = 0;                                                  // Reserved
                p.pfd.dwLayerMask = 0;                                                // Layer Masks Ignored
                p.pfd.dwVisibleMask = 0;
                p.pfd.dwDamageMask = 0;
                return p;
            }
        }

       
 
    }
}
