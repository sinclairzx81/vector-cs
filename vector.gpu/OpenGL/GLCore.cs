namespace Vector.Gpu.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    internal static class Imports
    {
        static Imports() { }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNewList", ExactSpelling = true)]
        internal extern static void NewList(UInt32 list, int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndList", ExactSpelling = true)]
        internal extern static void EndList();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCallList", ExactSpelling = true)]
        internal extern static void CallList(UInt32 list);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCallLists", ExactSpelling = true)]
        internal extern static unsafe void CallLists(Int32 n, int type, void* lists);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteLists", ExactSpelling = true)]
        internal extern static void DeleteLists(UInt32 list, Int32 range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenLists", ExactSpelling = true)]
        internal extern static Int32 GenLists(Int32 range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glListBase", ExactSpelling = true)]
        internal extern static void ListBase(UInt32 @base);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBegin", ExactSpelling = true)]
        internal extern static void Begin(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBitmap", ExactSpelling = true)]
        internal extern static unsafe void Bitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, Byte* bitmap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3b", ExactSpelling = true)]
        internal extern static void Color3b(SByte red, SByte green, SByte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3bv", ExactSpelling = true)]
        internal extern static unsafe void Color3bv(SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3d", ExactSpelling = true)]
        internal extern static void Color3d(Double red, Double green, Double blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3dv", ExactSpelling = true)]
        internal extern static unsafe void Color3dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3f", ExactSpelling = true)]
        internal extern static void Color3f(Single red, Single green, Single blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3fv", ExactSpelling = true)]
        internal extern static unsafe void Color3fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3i", ExactSpelling = true)]
        internal extern static void Color3i(Int32 red, Int32 green, Int32 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3iv", ExactSpelling = true)]
        internal extern static unsafe void Color3iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3s", ExactSpelling = true)]
        internal extern static void Color3s(Int16 red, Int16 green, Int16 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3sv", ExactSpelling = true)]
        internal extern static unsafe void Color3sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3ub", ExactSpelling = true)]
        internal extern static void Color3ub(Byte red, Byte green, Byte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3ubv", ExactSpelling = true)]
        internal extern static unsafe void Color3ubv(Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3ui", ExactSpelling = true)]
        internal extern static void Color3ui(UInt32 red, UInt32 green, UInt32 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3uiv", ExactSpelling = true)]
        internal extern static unsafe void Color3uiv(UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3us", ExactSpelling = true)]
        internal extern static void Color3us(UInt16 red, UInt16 green, UInt16 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3usv", ExactSpelling = true)]
        internal extern static unsafe void Color3usv(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4b", ExactSpelling = true)]
        internal extern static void Color4b(SByte red, SByte green, SByte blue, SByte alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4bv", ExactSpelling = true)]
        internal extern static unsafe void Color4bv(SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4d", ExactSpelling = true)]
        internal extern static void Color4d(Double red, Double green, Double blue, Double alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4dv", ExactSpelling = true)]
        internal extern static unsafe void Color4dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4f", ExactSpelling = true)]
        internal extern static void Color4f(Single red, Single green, Single blue, Single alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4fv", ExactSpelling = true)]
        internal extern static unsafe void Color4fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4i", ExactSpelling = true)]
        internal extern static void Color4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4iv", ExactSpelling = true)]
        internal extern static unsafe void Color4iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4s", ExactSpelling = true)]
        internal extern static void Color4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4sv", ExactSpelling = true)]
        internal extern static unsafe void Color4sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ub", ExactSpelling = true)]
        internal extern static void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ubv", ExactSpelling = true)]
        internal extern static unsafe void Color4ubv(Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ui", ExactSpelling = true)]
        internal extern static void Color4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4uiv", ExactSpelling = true)]
        internal extern static unsafe void Color4uiv(UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4us", ExactSpelling = true)]
        internal extern static void Color4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4usv", ExactSpelling = true)]
        internal extern static unsafe void Color4usv(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEdgeFlag", ExactSpelling = true)]
        internal extern static void EdgeFlag(int flag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEdgeFlagv", ExactSpelling = true)]
        internal extern static unsafe void EdgeFlagv(int* flag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnd", ExactSpelling = true)]
        internal extern static void End();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexd", ExactSpelling = true)]
        internal extern static void Indexd(Double c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexdv", ExactSpelling = true)]
        internal extern static unsafe void Indexdv(Double* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexf", ExactSpelling = true)]
        internal extern static void Indexf(Single c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexfv", ExactSpelling = true)]
        internal extern static unsafe void Indexfv(Single* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexi", ExactSpelling = true)]
        internal extern static void Indexi(Int32 c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexiv", ExactSpelling = true)]
        internal extern static unsafe void Indexiv(Int32* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexs", ExactSpelling = true)]
        internal extern static void Indexs(Int16 c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexsv", ExactSpelling = true)]
        internal extern static unsafe void Indexsv(Int16* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3b", ExactSpelling = true)]
        internal extern static void Normal3b(SByte nx, SByte ny, SByte nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3bv", ExactSpelling = true)]
        internal extern static unsafe void Normal3bv(SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3d", ExactSpelling = true)]
        internal extern static void Normal3d(Double nx, Double ny, Double nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3dv", ExactSpelling = true)]
        internal extern static unsafe void Normal3dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
        internal extern static void Normal3f(Single nx, Single ny, Single nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3fv", ExactSpelling = true)]
        internal extern static unsafe void Normal3fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3i", ExactSpelling = true)]
        internal extern static void Normal3i(Int32 nx, Int32 ny, Int32 nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3iv", ExactSpelling = true)]
        internal extern static unsafe void Normal3iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3s", ExactSpelling = true)]
        internal extern static void Normal3s(Int16 nx, Int16 ny, Int16 nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3sv", ExactSpelling = true)]
        internal extern static unsafe void Normal3sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2d", ExactSpelling = true)]
        internal extern static void RasterPos2d(Double x, Double y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2dv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos2dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2f", ExactSpelling = true)]
        internal extern static void RasterPos2f(Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2fv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos2fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2i", ExactSpelling = true)]
        internal extern static void RasterPos2i(Int32 x, Int32 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2iv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos2iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2s", ExactSpelling = true)]
        internal extern static void RasterPos2s(Int16 x, Int16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2sv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos2sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3d", ExactSpelling = true)]
        internal extern static void RasterPos3d(Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3dv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos3dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3f", ExactSpelling = true)]
        internal extern static void RasterPos3f(Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3fv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos3fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3i", ExactSpelling = true)]
        internal extern static void RasterPos3i(Int32 x, Int32 y, Int32 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3iv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos3iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3s", ExactSpelling = true)]
        internal extern static void RasterPos3s(Int16 x, Int16 y, Int16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3sv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos3sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4d", ExactSpelling = true)]
        internal extern static void RasterPos4d(Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4dv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos4dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4f", ExactSpelling = true)]
        internal extern static void RasterPos4f(Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4fv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos4fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4i", ExactSpelling = true)]
        internal extern static void RasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4iv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos4iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4s", ExactSpelling = true)]
        internal extern static void RasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4sv", ExactSpelling = true)]
        internal extern static unsafe void RasterPos4sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectd", ExactSpelling = true)]
        internal extern static void Rectd(Double x1, Double y1, Double x2, Double y2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectdv", ExactSpelling = true)]
        internal extern static unsafe void Rectdv(Double* v1, Double* v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectf", ExactSpelling = true)]
        internal extern static void Rectf(Single x1, Single y1, Single x2, Single y2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectfv", ExactSpelling = true)]
        internal extern static unsafe void Rectfv(Single* v1, Single* v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRecti", ExactSpelling = true)]
        internal extern static void Recti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectiv", ExactSpelling = true)]
        internal extern static unsafe void Rectiv(Int32* v1, Int32* v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRects", ExactSpelling = true)]
        internal extern static void Rects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectsv", ExactSpelling = true)]
        internal extern static unsafe void Rectsv(Int16* v1, Int16* v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1d", ExactSpelling = true)]
        internal extern static void TexCoord1d(Double s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1dv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1f", ExactSpelling = true)]
        internal extern static void TexCoord1f(Single s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1fv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1i", ExactSpelling = true)]
        internal extern static void TexCoord1i(Int32 s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1iv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1s", ExactSpelling = true)]
        internal extern static void TexCoord1s(Int16 s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1sv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2d", ExactSpelling = true)]
        internal extern static void TexCoord2d(Double s, Double t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2dv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2f", ExactSpelling = true)]
        internal extern static void TexCoord2f(Single s, Single t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2i", ExactSpelling = true)]
        internal extern static void TexCoord2i(Int32 s, Int32 t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2iv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2s", ExactSpelling = true)]
        internal extern static void TexCoord2s(Int16 s, Int16 t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2sv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3d", ExactSpelling = true)]
        internal extern static void TexCoord3d(Double s, Double t, Double r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3dv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3f", ExactSpelling = true)]
        internal extern static void TexCoord3f(Single s, Single t, Single r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3fv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3i", ExactSpelling = true)]
        internal extern static void TexCoord3i(Int32 s, Int32 t, Int32 r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3iv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3s", ExactSpelling = true)]
        internal extern static void TexCoord3s(Int16 s, Int16 t, Int16 r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3sv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4d", ExactSpelling = true)]
        internal extern static void TexCoord4d(Double s, Double t, Double r, Double q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4dv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4f", ExactSpelling = true)]
        internal extern static void TexCoord4f(Single s, Single t, Single r, Single q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4fv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4i", ExactSpelling = true)]
        internal extern static void TexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4iv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4s", ExactSpelling = true)]
        internal extern static void TexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4sv", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2d", ExactSpelling = true)]
        internal extern static void Vertex2d(Double x, Double y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2dv", ExactSpelling = true)]
        internal extern static unsafe void Vertex2dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2f", ExactSpelling = true)]
        internal extern static void Vertex2f(Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2fv", ExactSpelling = true)]
        internal extern static unsafe void Vertex2fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2i", ExactSpelling = true)]
        internal extern static void Vertex2i(Int32 x, Int32 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2iv", ExactSpelling = true)]
        internal extern static unsafe void Vertex2iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2s", ExactSpelling = true)]
        internal extern static void Vertex2s(Int16 x, Int16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2sv", ExactSpelling = true)]
        internal extern static unsafe void Vertex2sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3d", ExactSpelling = true)]
        internal extern static void Vertex3d(Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3dv", ExactSpelling = true)]
        internal extern static unsafe void Vertex3dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3f", ExactSpelling = true)]
        internal extern static void Vertex3f(Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3fv", ExactSpelling = true)]
        internal extern static unsafe void Vertex3fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3i", ExactSpelling = true)]
        internal extern static void Vertex3i(Int32 x, Int32 y, Int32 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3iv", ExactSpelling = true)]
        internal extern static unsafe void Vertex3iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3s", ExactSpelling = true)]
        internal extern static void Vertex3s(Int16 x, Int16 y, Int16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3sv", ExactSpelling = true)]
        internal extern static unsafe void Vertex3sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4d", ExactSpelling = true)]
        internal extern static void Vertex4d(Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4dv", ExactSpelling = true)]
        internal extern static unsafe void Vertex4dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4f", ExactSpelling = true)]
        internal extern static void Vertex4f(Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4fv", ExactSpelling = true)]
        internal extern static unsafe void Vertex4fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4i", ExactSpelling = true)]
        internal extern static void Vertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4iv", ExactSpelling = true)]
        internal extern static unsafe void Vertex4iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4s", ExactSpelling = true)]
        internal extern static void Vertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4sv", ExactSpelling = true)]
        internal extern static unsafe void Vertex4sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClipPlane", ExactSpelling = true)]
        internal extern static unsafe void ClipPlane(int plane, Double* equation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorMaterial", ExactSpelling = true)]
        internal extern static void ColorMaterial(int face, int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
        internal extern static void CullFace(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogf", ExactSpelling = true)]
        internal extern static void Fogf(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogfv", ExactSpelling = true)]
        internal extern static unsafe void Fogfv(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogi", ExactSpelling = true)]
        internal extern static void Fogi(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogiv", ExactSpelling = true)]
        internal extern static unsafe void Fogiv(int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
        internal extern static void FrontFace(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glHint", ExactSpelling = true)]
        internal extern static void Hint(int target, int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightf", ExactSpelling = true)]
        internal extern static void Lightf(int light, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightfv", ExactSpelling = true)]
        internal extern static unsafe void Lightfv(int light, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLighti", ExactSpelling = true)]
        internal extern static void Lighti(int light, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightiv", ExactSpelling = true)]
        internal extern static unsafe void Lightiv(int light, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
        internal extern static void LightModelf(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
        internal extern static unsafe void LightModelfv(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightModeli", ExactSpelling = true)]
        internal extern static void LightModeli(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightModeliv", ExactSpelling = true)]
        internal extern static unsafe void LightModeliv(int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLineStipple", ExactSpelling = true)]
        internal extern static void LineStipple(Int32 factor, UInt16 pattern);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
        internal extern static void LineWidth(Single width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
        internal extern static void Materialf(int face, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
        internal extern static unsafe void Materialfv(int face, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMateriali", ExactSpelling = true)]
        internal extern static void Materiali(int face, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMaterialiv", ExactSpelling = true)]
        internal extern static unsafe void Materialiv(int face, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointSize", ExactSpelling = true)]
        internal extern static void PointSize(Single size);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
        internal extern static void PolygonMode(int face, int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPolygonStipple", ExactSpelling = true)]
        internal extern static unsafe void PolygonStipple(Byte* mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScissor", ExactSpelling = true)]
        internal extern static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
        internal extern static void ShadeModel(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
        internal extern static void TexParameterf(int target, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
        internal extern static unsafe void TexParameterfv(int target, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
        internal extern static void TexParameteri(int target, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
        internal extern static unsafe void TexParameteriv(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
        internal extern static unsafe void TexImage1D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 border, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
        internal extern static unsafe void TexImage2D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
        internal extern static void TexEnvf(int target, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
        internal extern static unsafe void TexEnvfv(int target, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexEnvi", ExactSpelling = true)]
        internal extern static void TexEnvi(int target, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexEnviv", ExactSpelling = true)]
        internal extern static unsafe void TexEnviv(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGend", ExactSpelling = true)]
        internal extern static void TexGend(int coord, int pname, Double param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGendv", ExactSpelling = true)]
        internal extern static unsafe void TexGendv(int coord, int pname, Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGenf", ExactSpelling = true)]
        internal extern static void TexGenf(int coord, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGenfv", ExactSpelling = true)]
        internal extern static unsafe void TexGenfv(int coord, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGeni", ExactSpelling = true)]
        internal extern static void TexGeni(int coord, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGeniv", ExactSpelling = true)]
        internal extern static unsafe void TexGeniv(int coord, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFeedbackBuffer", ExactSpelling = true)]
        internal extern static unsafe void FeedbackBuffer(Int32 size, int type, [Out] Single* buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSelectBuffer", ExactSpelling = true)]
        internal extern static unsafe void SelectBuffer(Int32 size, [Out] UInt32* buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRenderMode", ExactSpelling = true)]
        internal extern static Int32 RenderMode(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInitNames", ExactSpelling = true)]
        internal extern static void InitNames();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadName", ExactSpelling = true)]
        internal extern static void LoadName(UInt32 name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPassThrough", ExactSpelling = true)]
        internal extern static void PassThrough(Single token);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPopName", ExactSpelling = true)]
        internal extern static void PopName();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPushName", ExactSpelling = true)]
        internal extern static void PushName(UInt32 name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
        internal extern static void DrawBuffer(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClear", ExactSpelling = true)]
        internal extern static void Clear(int mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearAccum", ExactSpelling = true)]
        internal extern static void ClearAccum(Single red, Single green, Single blue, Single alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearIndex", ExactSpelling = true)]
        internal extern static void ClearIndex(Single c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
        internal extern static void ClearColor(Single red, Single green, Single blue, Single alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
        internal extern static void ClearStencil(Int32 s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
        internal extern static void ClearDepth(Double depth);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
        internal extern static void StencilMask(UInt32 mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
        internal extern static void ColorMask(int red, int green, int blue, int alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
        internal extern static void DepthMask(int flag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexMask", ExactSpelling = true)]
        internal extern static void IndexMask(UInt32 mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAccum", ExactSpelling = true)]
        internal extern static void Accum(int op, Single value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisable", ExactSpelling = true)]
        internal extern static void Disable(int cap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnable", ExactSpelling = true)]
        internal extern static void Enable(int cap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFinish", ExactSpelling = true)]
        internal extern static void Finish();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlush", ExactSpelling = true)]
        internal extern static void Flush();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPopAttrib", ExactSpelling = true)]
        internal extern static void PopAttrib();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPushAttrib", ExactSpelling = true)]
        internal extern static void PushAttrib(int mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMap1d", ExactSpelling = true)]
        internal extern static unsafe void Map1d(int target, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMap1f", ExactSpelling = true)]
        internal extern static unsafe void Map1f(int target, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMap2d", ExactSpelling = true)]
        internal extern static unsafe void Map2d(int target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMap2f", ExactSpelling = true)]
        internal extern static unsafe void Map2f(int target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapGrid1d", ExactSpelling = true)]
        internal extern static void MapGrid1d(Int32 un, Double u1, Double u2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapGrid1f", ExactSpelling = true)]
        internal extern static void MapGrid1f(Int32 un, Single u1, Single u2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapGrid2d", ExactSpelling = true)]
        internal extern static void MapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapGrid2f", ExactSpelling = true)]
        internal extern static void MapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord1d", ExactSpelling = true)]
        internal extern static void EvalCoord1d(Double u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord1dv", ExactSpelling = true)]
        internal extern static unsafe void EvalCoord1dv(Double* u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord1f", ExactSpelling = true)]
        internal extern static void EvalCoord1f(Single u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord1fv", ExactSpelling = true)]
        internal extern static unsafe void EvalCoord1fv(Single* u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord2d", ExactSpelling = true)]
        internal extern static void EvalCoord2d(Double u, Double v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord2dv", ExactSpelling = true)]
        internal extern static unsafe void EvalCoord2dv(Double* u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord2f", ExactSpelling = true)]
        internal extern static void EvalCoord2f(Single u, Single v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord2fv", ExactSpelling = true)]
        internal extern static unsafe void EvalCoord2fv(Single* u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalMesh1", ExactSpelling = true)]
        internal extern static void EvalMesh1(int mode, Int32 i1, Int32 i2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalPoint1", ExactSpelling = true)]
        internal extern static void EvalPoint1(Int32 i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalMesh2", ExactSpelling = true)]
        internal extern static void EvalMesh2(int mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalPoint2", ExactSpelling = true)]
        internal extern static void EvalPoint2(Int32 i, Int32 j);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
        internal extern static void AlphaFunc(int func, Single @ref);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
        internal extern static void BlendFunc(int sfactor, int dfactor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
        internal extern static void LogicOp(int opcode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
        internal extern static void StencilFunc(int func, Int32 @ref, UInt32 mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
        internal extern static void StencilOp(int fail, int zfail, int zpass);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
        internal extern static void DepthFunc(int func);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelZoom", ExactSpelling = true)]
        internal extern static void PixelZoom(Single xfactor, Single yfactor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTransferf", ExactSpelling = true)]
        internal extern static void PixelTransferf(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTransferi", ExactSpelling = true)]
        internal extern static void PixelTransferi(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
        internal extern static void PixelStoref(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
        internal extern static void PixelStorei(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelMapfv", ExactSpelling = true)]
        internal extern static unsafe void PixelMapfv(int map, Int32 mapsize, Single* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelMapuiv", ExactSpelling = true)]
        internal extern static unsafe void PixelMapuiv(int map, Int32 mapsize, UInt32* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelMapusv", ExactSpelling = true)]
        internal extern static unsafe void PixelMapusv(int map, Int32 mapsize, UInt16* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
        internal extern static void ReadBuffer(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyPixels", ExactSpelling = true)]
        internal extern static void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, int type);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
        internal extern static unsafe void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, [Out] void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawPixels", ExactSpelling = true)]
        internal extern static unsafe void DrawPixels(Int32 width, Int32 height, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
        internal extern static unsafe void GetBooleanv(int pname, [Out] int* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetClipPlane", ExactSpelling = true)]
        internal extern static unsafe void GetClipPlane(int plane, [Out] Double* equation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
        internal extern static unsafe void GetDoublev(int pname, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetError", ExactSpelling = true)]
        internal extern static int GetError();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
        internal extern static unsafe void GetFloatv(int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
        internal extern static unsafe void GetIntegerv(int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetLightfv", ExactSpelling = true)]
        internal extern static unsafe void GetLightfv(int light, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetLightiv", ExactSpelling = true)]
        internal extern static unsafe void GetLightiv(int light, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapdv", ExactSpelling = true)]
        internal extern static unsafe void GetMapdv(int target, int query, [Out] Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapfv", ExactSpelling = true)]
        internal extern static unsafe void GetMapfv(int target, int query, [Out] Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapiv", ExactSpelling = true)]
        internal extern static unsafe void GetMapiv(int target, int query, [Out] Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
        internal extern static unsafe void GetMaterialfv(int face, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMaterialiv", ExactSpelling = true)]
        internal extern static unsafe void GetMaterialiv(int face, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPixelMapfv", ExactSpelling = true)]
        internal extern static unsafe void GetPixelMapfv(int map, [Out] Single* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPixelMapuiv", ExactSpelling = true)]
        internal extern static unsafe void GetPixelMapuiv(int map, [Out] UInt32* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPixelMapusv", ExactSpelling = true)]
        internal extern static unsafe void GetPixelMapusv(int map, [Out] UInt16* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPolygonStipple", ExactSpelling = true)]
        internal extern static unsafe void GetPolygonStipple([Out] Byte* mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetString", ExactSpelling = true)]
        internal extern static IntPtr GetString(int name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
        internal extern static unsafe void GetTexEnvfv(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
        internal extern static unsafe void GetTexEnviv(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexGendv", ExactSpelling = true)]
        internal extern static unsafe void GetTexGendv(int coord, int pname, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexGenfv", ExactSpelling = true)]
        internal extern static unsafe void GetTexGenfv(int coord, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexGeniv", ExactSpelling = true)]
        internal extern static unsafe void GetTexGeniv(int coord, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
        internal extern static unsafe void GetTexImage(int target, Int32 level, int format, int type, [Out] void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
        internal extern static unsafe void GetTexParameterfv(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
        internal extern static unsafe void GetTexParameteriv(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
        internal extern static unsafe void GetTexLevelParameterfv(int target, Int32 level, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
        internal extern static unsafe void GetTexLevelParameteriv(int target, Int32 level, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
        internal extern static int IsEnabled(int cap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsList", ExactSpelling = true)]
        internal extern static int IsList(UInt32 list);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
        internal extern static void DepthRange(Double near, Double far);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFrustum", ExactSpelling = true)]
        internal extern static void Frustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
        internal extern static void LoadIdentity();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
        internal extern static unsafe void LoadMatrixf(Single* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadMatrixd", ExactSpelling = true)]
        internal extern static unsafe void LoadMatrixd(Double* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
        internal extern static void MatrixMode(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
        internal extern static unsafe void MultMatrixf(Single* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultMatrixd", ExactSpelling = true)]
        internal extern static unsafe void MultMatrixd(Double* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glOrtho", ExactSpelling = true)]
        internal extern static void Ortho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
        internal extern static void PopMatrix();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
        internal extern static void PushMatrix();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRotated", ExactSpelling = true)]
        internal extern static void Rotated(Double angle, Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRotatef", ExactSpelling = true)]
        internal extern static void Rotatef(Single angle, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScaled", ExactSpelling = true)]
        internal extern static void Scaled(Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScalef", ExactSpelling = true)]
        internal extern static void Scalef(Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTranslated", ExactSpelling = true)]
        internal extern static void Translated(Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
        internal extern static void Translatef(Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glViewport", ExactSpelling = true)]
        internal extern static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glArrayElement", ExactSpelling = true)]
        internal extern static void ArrayElement(Int32 i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorPointer", ExactSpelling = true)]
        internal extern static unsafe void ColorPointer(Int32 size, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisableClientState", ExactSpelling = true)]
        internal extern static void DisableClientState(int array);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
        internal extern static void DrawArrays(int mode, Int32 first, Int32 count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
        internal extern static unsafe void DrawElements(int mode, Int32 count, int type, void* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEdgeFlagPointer", ExactSpelling = true)]
        internal extern static unsafe void EdgeFlagPointer(Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnableClientState", ExactSpelling = true)]
        internal extern static void EnableClientState(int array);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
        internal extern static unsafe void GetPointerv(int pname, [Out] void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexPointer", ExactSpelling = true)]
        internal extern static unsafe void IndexPointer(int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInterleavedArrays", ExactSpelling = true)]
        internal extern static unsafe void InterleavedArrays(int format, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalPointer", ExactSpelling = true)]
        internal extern static unsafe void NormalPointer(int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
        internal extern static unsafe void TexCoordPointer(Int32 size, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexPointer", ExactSpelling = true)]
        internal extern static unsafe void VertexPointer(Int32 size, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
        internal extern static void PolygonOffset(Single factor, Single units);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
        internal extern static void CopyTexImage1D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
        internal extern static void CopyTexImage2D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
        internal extern static void CopyTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
        internal extern static void CopyTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAreTexturesResident", ExactSpelling = true)]
        internal extern static unsafe int AreTexturesResident(Int32 n, UInt32* textures, [Out] int* residences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
        internal extern static void BindTexture(int target, UInt32 texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
        internal extern static unsafe void DeleteTextures(Int32 n, UInt32* textures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
        internal extern static unsafe void GenTextures(Int32 n, [Out] UInt32* textures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
        internal extern static int IsTexture(UInt32 texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPrioritizeTextures", ExactSpelling = true)]
        internal extern static unsafe void PrioritizeTextures(Int32 n, UInt32* textures, Single* priorities);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexub", ExactSpelling = true)]
        internal extern static void Indexub(Byte c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexubv", ExactSpelling = true)]
        internal extern static unsafe void Indexubv(Byte* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPopClientAttrib", ExactSpelling = true)]
        internal extern static void PopClientAttrib();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPushClientAttrib", ExactSpelling = true)]
        internal extern static void PushClientAttrib(int mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
        internal extern static void BlendColor(Single red, Single green, Single blue, Single alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
        internal extern static void BlendEquation(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
        internal extern static unsafe void DrawRangeElements(int mode, UInt32 start, UInt32 end, Int32 count, int type, void* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTable", ExactSpelling = true)]
        internal extern static unsafe void ColorTable(int target, int internalformat, Int32 width, int format, int type, void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTableParameterfv", ExactSpelling = true)]
        internal extern static unsafe void ColorTableParameterfv(int target, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTableParameteriv", ExactSpelling = true)]
        internal extern static unsafe void ColorTableParameteriv(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyColorTable", ExactSpelling = true)]
        internal extern static void CopyColorTable(int target, int internalformat, Int32 x, Int32 y, Int32 width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTable", ExactSpelling = true)]
        internal extern static unsafe void GetColorTable(int target, int format, int type, [Out] void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableParameterfv", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterfv(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableParameteriv", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameteriv(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorSubTable", ExactSpelling = true)]
        internal extern static unsafe void ColorSubTable(int target, Int32 start, Int32 count, int format, int type, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyColorSubTable", ExactSpelling = true)]
        internal extern static void CopyColorSubTable(int target, Int32 start, Int32 x, Int32 y, Int32 width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionFilter1D", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionFilter1D(int target, int internalformat, Int32 width, int format, int type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionFilter2D", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameterf", ExactSpelling = true)]
        internal extern static void ConvolutionParameterf(int target, int pname, Single @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameterfv", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionParameterfv(int target, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameteri", ExactSpelling = true)]
        internal extern static void ConvolutionParameteri(int target, int pname, Int32 @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameteriv", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionParameteriv(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyConvolutionFilter1D", ExactSpelling = true)]
        internal extern static void CopyConvolutionFilter1D(int target, int internalformat, Int32 x, Int32 y, Int32 width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyConvolutionFilter2D", ExactSpelling = true)]
        internal extern static void CopyConvolutionFilter2D(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetConvolutionFilter", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionFilter(int target, int format, int type, [Out] void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetConvolutionParameterfv", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionParameterfv(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetConvolutionParameteriv", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionParameteriv(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSeparableFilter", ExactSpelling = true)]
        internal extern static unsafe void GetSeparableFilter(int target, int format, int type, [Out] void* row, [Out] void* column, [Out] void* span);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSeparableFilter2D", ExactSpelling = true)]
        internal extern static unsafe void SeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, void* row, void* column);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHistogram", ExactSpelling = true)]
        internal extern static unsafe void GetHistogram(int target, int reset, int format, int type, [Out] void* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHistogramParameterfv", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramParameterfv(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHistogramParameteriv", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramParameteriv(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMinmax", ExactSpelling = true)]
        internal extern static unsafe void GetMinmax(int target, int reset, int format, int type, [Out] void* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMinmaxParameterfv", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxParameterfv(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMinmaxParameteriv", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxParameteriv(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glHistogram", ExactSpelling = true)]
        internal extern static void Histogram(int target, Int32 width, int internalformat, int sink);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMinmax", ExactSpelling = true)]
        internal extern static void Minmax(int target, int internalformat, int sink);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glResetHistogram", ExactSpelling = true)]
        internal extern static void ResetHistogram(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glResetMinmax", ExactSpelling = true)]
        internal extern static void ResetMinmax(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage3D", ExactSpelling = true)]
        internal extern static unsafe void TexImage3D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
        internal extern static void CopyTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
        internal extern static void ActiveTexture(int texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
        internal extern static void ClientActiveTexture(int texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1d", ExactSpelling = true)]
        internal extern static void MultiTexCoord1d(int target, Double s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1dv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1dv(int target, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1f", ExactSpelling = true)]
        internal extern static void MultiTexCoord1f(int target, Single s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1fv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1fv(int target, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1i", ExactSpelling = true)]
        internal extern static void MultiTexCoord1i(int target, Int32 s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1iv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1iv(int target, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1s", ExactSpelling = true)]
        internal extern static void MultiTexCoord1s(int target, Int16 s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1sv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1sv(int target, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2d", ExactSpelling = true)]
        internal extern static void MultiTexCoord2d(int target, Double s, Double t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2dv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2dv(int target, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2f", ExactSpelling = true)]
        internal extern static void MultiTexCoord2f(int target, Single s, Single t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2fv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2fv(int target, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2i", ExactSpelling = true)]
        internal extern static void MultiTexCoord2i(int target, Int32 s, Int32 t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2iv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2iv(int target, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2s", ExactSpelling = true)]
        internal extern static void MultiTexCoord2s(int target, Int16 s, Int16 t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2sv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2sv(int target, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3d", ExactSpelling = true)]
        internal extern static void MultiTexCoord3d(int target, Double s, Double t, Double r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3dv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3dv(int target, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3f", ExactSpelling = true)]
        internal extern static void MultiTexCoord3f(int target, Single s, Single t, Single r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3fv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3fv(int target, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3i", ExactSpelling = true)]
        internal extern static void MultiTexCoord3i(int target, Int32 s, Int32 t, Int32 r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3iv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3iv(int target, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3s", ExactSpelling = true)]
        internal extern static void MultiTexCoord3s(int target, Int16 s, Int16 t, Int16 r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3sv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3sv(int target, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4d", ExactSpelling = true)]
        internal extern static void MultiTexCoord4d(int target, Double s, Double t, Double r, Double q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4dv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4dv(int target, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
        internal extern static void MultiTexCoord4f(int target, Single s, Single t, Single r, Single q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4fv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4fv(int target, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4i", ExactSpelling = true)]
        internal extern static void MultiTexCoord4i(int target, Int32 s, Int32 t, Int32 r, Int32 q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4iv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4iv(int target, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4s", ExactSpelling = true)]
        internal extern static void MultiTexCoord4s(int target, Int16 s, Int16 t, Int16 r, Int16 q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4sv", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4sv(int target, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadTransposeMatrixf", ExactSpelling = true)]
        internal extern static unsafe void LoadTransposeMatrixf(Single* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadTransposeMatrixd", ExactSpelling = true)]
        internal extern static unsafe void LoadTransposeMatrixd(Double* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultTransposeMatrixf", ExactSpelling = true)]
        internal extern static unsafe void MultTransposeMatrixf(Single* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultTransposeMatrixd", ExactSpelling = true)]
        internal extern static unsafe void MultTransposeMatrixd(Double* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
        internal extern static void SampleCoverage(Single value, int invert);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
        internal extern static unsafe void GetCompressedTexImage(int target, Int32 level, [Out] void* img);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
        internal extern static void BlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordf", ExactSpelling = true)]
        internal extern static void FogCoordf(Single coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordfv", ExactSpelling = true)]
        internal extern static unsafe void FogCoordfv(Single* coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordd", ExactSpelling = true)]
        internal extern static void FogCoordd(Double coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoorddv", ExactSpelling = true)]
        internal extern static unsafe void FogCoorddv(Double* coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordPointer", ExactSpelling = true)]
        internal extern static unsafe void FogCoordPointer(int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawArrays(int mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawElements(int mode, Int32* count, int type, void* indices, Int32 primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
        internal extern static void PointParameterf(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
        internal extern static unsafe void PointParameterfv(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
        internal extern static void PointParameteri(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
        internal extern static unsafe void PointParameteriv(int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3b", ExactSpelling = true)]
        internal extern static void SecondaryColor3b(SByte red, SByte green, SByte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3bv", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3bv(SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3d", ExactSpelling = true)]
        internal extern static void SecondaryColor3d(Double red, Double green, Double blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3dv", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3f", ExactSpelling = true)]
        internal extern static void SecondaryColor3f(Single red, Single green, Single blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3fv", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3i", ExactSpelling = true)]
        internal extern static void SecondaryColor3i(Int32 red, Int32 green, Int32 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3iv", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3s", ExactSpelling = true)]
        internal extern static void SecondaryColor3s(Int16 red, Int16 green, Int16 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3sv", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3ub", ExactSpelling = true)]
        internal extern static void SecondaryColor3ub(Byte red, Byte green, Byte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3ubv", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3ubv(Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3ui", ExactSpelling = true)]
        internal extern static void SecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3uiv", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3uiv(UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3us", ExactSpelling = true)]
        internal extern static void SecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3usv", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3usv(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColorPointer", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColorPointer(Int32 size, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2d", ExactSpelling = true)]
        internal extern static void WindowPos2d(Double x, Double y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2dv", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2f", ExactSpelling = true)]
        internal extern static void WindowPos2f(Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2fv", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2i", ExactSpelling = true)]
        internal extern static void WindowPos2i(Int32 x, Int32 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2iv", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2s", ExactSpelling = true)]
        internal extern static void WindowPos2s(Int16 x, Int16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2sv", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3d", ExactSpelling = true)]
        internal extern static void WindowPos3d(Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3dv", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3dv(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3f", ExactSpelling = true)]
        internal extern static void WindowPos3f(Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3fv", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3fv(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3i", ExactSpelling = true)]
        internal extern static void WindowPos3i(Int32 x, Int32 y, Int32 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3iv", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3iv(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3s", ExactSpelling = true)]
        internal extern static void WindowPos3s(Int16 x, Int16 y, Int16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3sv", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3sv(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenQueries", ExactSpelling = true)]
        internal extern static unsafe void GenQueries(Int32 n, [Out] UInt32* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteQueries", ExactSpelling = true)]
        internal extern static unsafe void DeleteQueries(Int32 n, UInt32* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsQuery", ExactSpelling = true)]
        internal extern static int IsQuery(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginQuery", ExactSpelling = true)]
        internal extern static void BeginQuery(int target, UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndQuery", ExactSpelling = true)]
        internal extern static void EndQuery(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryiv", ExactSpelling = true)]
        internal extern static unsafe void GetQueryiv(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectiv(UInt32 id, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectuiv(UInt32 id, int pname, [Out] UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
        internal extern static void BindBuffer(int target, UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
        internal extern static unsafe void DeleteBuffers(Int32 n, UInt32* buffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
        internal extern static unsafe void GenBuffers(Int32 n, [Out] UInt32* buffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
        internal extern static int IsBuffer(UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferData", ExactSpelling = true)]
        internal extern static unsafe void BufferData(int target, IntPtr size, void* data, int usage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
        internal extern static unsafe void BufferSubData(int target, IntPtr offset, IntPtr size, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
        internal extern static unsafe void GetBufferSubData(int target, IntPtr offset, IntPtr size, [Out] void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapBuffer", ExactSpelling = true)]
        internal extern static IntPtr MapBuffer(int target, int access);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
        internal extern static int UnmapBuffer(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
        internal extern static unsafe void GetBufferParameteriv(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
        internal extern static unsafe void GetBufferPointerv(int target, int pname, [Out] void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
        internal extern static void BlendEquationSeparate(int modeRGB, int modeAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
        internal extern static unsafe void DrawBuffers(Int32 n, int* bufs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
        internal extern static void StencilOpSeparate(int face, int sfail, int dpfail, int dppass);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
        internal extern static void StencilFuncSeparate(int frontfunc, int backfunc, Int32 @ref, UInt32 mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
        internal extern static void StencilMaskSeparate(int face, UInt32 mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
        internal extern static void AttachShader(UInt32 program, UInt32 shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
        internal extern static void BindAttribLocation(UInt32 program, UInt32 index, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
        internal extern static void CompileShader(UInt32 shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
        internal extern static Int32 CreateProgram();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
        internal extern static Int32 CreateShader(int type);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
        internal extern static void DeleteProgram(UInt32 program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
        internal extern static void DeleteShader(UInt32 shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
        internal extern static void DetachShader(UInt32 program, UInt32 shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
        internal extern static void DisableVertexAttribArray(UInt32 index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
        internal extern static void EnableVertexAttribArray(UInt32 index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
        internal extern static unsafe void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
        internal extern static unsafe void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
        internal extern static unsafe void GetAttachedShaders(UInt32 program, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
        internal extern static Int32 GetAttribLocation(UInt32 program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
        internal extern static unsafe void GetProgramiv(UInt32 program, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
        internal extern static unsafe void GetProgramInfoLog(UInt32 program, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
        internal extern static unsafe void GetShaderiv(UInt32 shader, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
        internal extern static unsafe void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
        internal extern static unsafe void GetShaderSource(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
        internal extern static Int32 GetUniformLocation(UInt32 program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
        internal extern static unsafe void GetUniformfv(UInt32 program, Int32 location, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
        internal extern static unsafe void GetUniformiv(UInt32 program, Int32 location, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribdv(UInt32 index, int pname, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribfv(UInt32 index, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribiv(UInt32 index, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribPointerv(UInt32 index, int pname, [Out] void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
        internal extern static int IsProgram(UInt32 program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsShader", ExactSpelling = true)]
        internal extern static int IsShader(UInt32 shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
        internal extern static void LinkProgram(UInt32 program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
        internal extern static unsafe void ShaderSource(UInt32 shader, Int32 count, System.String[] @string, Int32* length);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
        internal extern static void UseProgram(UInt32 program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
        internal extern static void Uniform1f(Int32 location, Single v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
        internal extern static void Uniform2f(Int32 location, Single v0, Single v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
        internal extern static void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
        internal extern static void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
        internal extern static void Uniform1i(Int32 location, Int32 v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
        internal extern static void Uniform2i(Int32 location, Int32 v0, Int32 v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
        internal extern static void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
        internal extern static void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
        internal extern static unsafe void Uniform1fv(Int32 location, Int32 count, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
        internal extern static unsafe void Uniform2fv(Int32 location, Int32 count, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
        internal extern static unsafe void Uniform3fv(Int32 location, Int32 count, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
        internal extern static unsafe void Uniform4fv(Int32 location, Int32 count, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
        internal extern static unsafe void Uniform1iv(Int32 location, Int32 count, Int32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
        internal extern static unsafe void Uniform2iv(Int32 location, Int32 count, Int32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
        internal extern static unsafe void Uniform3iv(Int32 location, Int32 count, Int32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
        internal extern static unsafe void Uniform4iv(Int32 location, Int32 count, Int32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix2fv(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix3fv(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix4fv(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
        internal extern static void ValidateProgram(UInt32 program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
        internal extern static void VertexAttrib1d(UInt32 index, Double x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1dv(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
        internal extern static void VertexAttrib1f(UInt32 index, Single x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1fv(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
        internal extern static void VertexAttrib1s(UInt32 index, Int16 x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1sv(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
        internal extern static void VertexAttrib2d(UInt32 index, Double x, Double y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2dv(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
        internal extern static void VertexAttrib2f(UInt32 index, Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2fv(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
        internal extern static void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2sv(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
        internal extern static void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3dv(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
        internal extern static void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3fv(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
        internal extern static void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3sv(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nbv(UInt32 index, SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Niv(UInt32 index, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nsv(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
        internal extern static void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nubv(UInt32 index, Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nusv(UInt32 index, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4bv(UInt32 index, SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
        internal extern static void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4dv(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
        internal extern static void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4fv(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4iv(UInt32 index, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
        internal extern static void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4sv(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4ubv(UInt32 index, Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4uiv(UInt32 index, UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4usv(UInt32 index, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribPointer(UInt32 index, Int32 size, int type, int normalized, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix2x3fv(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix3x2fv(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix2x4fv(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix4x2fv(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix3x4fv(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix4x3fv(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glActiveTextureARB", ExactSpelling = true)]
        internal extern static void ActiveTextureARB(int texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClientActiveTextureARB", ExactSpelling = true)]
        internal extern static void ClientActiveTextureARB(int texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1dARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord1dARB(int target, Double s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1dvARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1dvARB(int target, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1fARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord1fARB(int target, Single s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1fvARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1fvARB(int target, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1iARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord1iARB(int target, Int32 s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1ivARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1ivARB(int target, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1sARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord1sARB(int target, Int16 s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1svARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1svARB(int target, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2dARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord2dARB(int target, Double s, Double t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2dvARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2dvARB(int target, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2fARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord2fARB(int target, Single s, Single t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2fvARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2fvARB(int target, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2iARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord2iARB(int target, Int32 s, Int32 t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2ivARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2ivARB(int target, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2sARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord2sARB(int target, Int16 s, Int16 t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2svARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2svARB(int target, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3dARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord3dARB(int target, Double s, Double t, Double r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3dvARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3dvARB(int target, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3fARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord3fARB(int target, Single s, Single t, Single r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3fvARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3fvARB(int target, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3iARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord3iARB(int target, Int32 s, Int32 t, Int32 r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3ivARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3ivARB(int target, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3sARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord3sARB(int target, Int16 s, Int16 t, Int16 r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3svARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3svARB(int target, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4dARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord4dARB(int target, Double s, Double t, Double r, Double q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4dvARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4dvARB(int target, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4fARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord4fARB(int target, Single s, Single t, Single r, Single q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4fvARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4fvARB(int target, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4iARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord4iARB(int target, Int32 s, Int32 t, Int32 r, Int32 q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4ivARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4ivARB(int target, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4sARB", ExactSpelling = true)]
        internal extern static void MultiTexCoord4sARB(int target, Int16 s, Int16 t, Int16 r, Int16 q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4svARB", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4svARB(int target, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadTransposeMatrixfARB", ExactSpelling = true)]
        internal extern static unsafe void LoadTransposeMatrixfARB(Single* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadTransposeMatrixdARB", ExactSpelling = true)]
        internal extern static unsafe void LoadTransposeMatrixdARB(Double* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultTransposeMatrixfARB", ExactSpelling = true)]
        internal extern static unsafe void MultTransposeMatrixfARB(Single* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultTransposeMatrixdARB", ExactSpelling = true)]
        internal extern static unsafe void MultTransposeMatrixdARB(Double* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSampleCoverageARB", ExactSpelling = true)]
        internal extern static void SampleCoverageARB(Single value, int invert);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage3DARB", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage3DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage2DARB", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage2DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage1DARB", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage1DARB(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage3DARB", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage3DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage2DARB", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage2DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage1DARB", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage1DARB(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCompressedTexImageARB", ExactSpelling = true)]
        internal extern static unsafe void GetCompressedTexImageARB(int target, Int32 level, [Out] void* img);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterfARB", ExactSpelling = true)]
        internal extern static void PointParameterfARB(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterfvARB", ExactSpelling = true)]
        internal extern static unsafe void PointParameterfvARB(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWeightbvARB", ExactSpelling = true)]
        internal extern static unsafe void WeightbvARB(Int32 size, SByte* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWeightsvARB", ExactSpelling = true)]
        internal extern static unsafe void WeightsvARB(Int32 size, Int16* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWeightivARB", ExactSpelling = true)]
        internal extern static unsafe void WeightivARB(Int32 size, Int32* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWeightfvARB", ExactSpelling = true)]
        internal extern static unsafe void WeightfvARB(Int32 size, Single* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWeightdvARB", ExactSpelling = true)]
        internal extern static unsafe void WeightdvARB(Int32 size, Double* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWeightubvARB", ExactSpelling = true)]
        internal extern static unsafe void WeightubvARB(Int32 size, Byte* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWeightusvARB", ExactSpelling = true)]
        internal extern static unsafe void WeightusvARB(Int32 size, UInt16* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWeightuivARB", ExactSpelling = true)]
        internal extern static unsafe void WeightuivARB(Int32 size, UInt32* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWeightPointerARB", ExactSpelling = true)]
        internal extern static unsafe void WeightPointerARB(Int32 size, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexBlendARB", ExactSpelling = true)]
        internal extern static void VertexBlendARB(Int32 count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCurrentPaletteMatrixARB", ExactSpelling = true)]
        internal extern static void CurrentPaletteMatrixARB(Int32 index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMatrixIndexubvARB", ExactSpelling = true)]
        internal extern static unsafe void MatrixIndexubvARB(Int32 size, Byte* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMatrixIndexusvARB", ExactSpelling = true)]
        internal extern static unsafe void MatrixIndexusvARB(Int32 size, UInt16* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMatrixIndexuivARB", ExactSpelling = true)]
        internal extern static unsafe void MatrixIndexuivARB(Int32 size, UInt32* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMatrixIndexPointerARB", ExactSpelling = true)]
        internal extern static unsafe void MatrixIndexPointerARB(Int32 size, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2dARB", ExactSpelling = true)]
        internal extern static void WindowPos2dARB(Double x, Double y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2dvARB", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2dvARB(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2fARB", ExactSpelling = true)]
        internal extern static void WindowPos2fARB(Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2fvARB", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2fvARB(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2iARB", ExactSpelling = true)]
        internal extern static void WindowPos2iARB(Int32 x, Int32 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2ivARB", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2ivARB(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2sARB", ExactSpelling = true)]
        internal extern static void WindowPos2sARB(Int16 x, Int16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2svARB", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2svARB(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3dARB", ExactSpelling = true)]
        internal extern static void WindowPos3dARB(Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3dvARB", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3dvARB(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3fARB", ExactSpelling = true)]
        internal extern static void WindowPos3fARB(Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3fvARB", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3fvARB(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3iARB", ExactSpelling = true)]
        internal extern static void WindowPos3iARB(Int32 x, Int32 y, Int32 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3ivARB", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3ivARB(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3sARB", ExactSpelling = true)]
        internal extern static void WindowPos3sARB(Int16 x, Int16 y, Int16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3svARB", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3svARB(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1dARB", ExactSpelling = true)]
        internal extern static void VertexAttrib1dARB(UInt32 index, Double x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1dvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1dvARB(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1fARB", ExactSpelling = true)]
        internal extern static void VertexAttrib1fARB(UInt32 index, Single x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1fvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1fvARB(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1sARB", ExactSpelling = true)]
        internal extern static void VertexAttrib1sARB(UInt32 index, Int16 x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1svARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1svARB(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2dARB", ExactSpelling = true)]
        internal extern static void VertexAttrib2dARB(UInt32 index, Double x, Double y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2dvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2dvARB(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2fARB", ExactSpelling = true)]
        internal extern static void VertexAttrib2fARB(UInt32 index, Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2fvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2fvARB(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2sARB", ExactSpelling = true)]
        internal extern static void VertexAttrib2sARB(UInt32 index, Int16 x, Int16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2svARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2svARB(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3dARB", ExactSpelling = true)]
        internal extern static void VertexAttrib3dARB(UInt32 index, Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3dvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3dvARB(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3fARB", ExactSpelling = true)]
        internal extern static void VertexAttrib3fARB(UInt32 index, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3fvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3fvARB(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3sARB", ExactSpelling = true)]
        internal extern static void VertexAttrib3sARB(UInt32 index, Int16 x, Int16 y, Int16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3svARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3svARB(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4NbvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NbvARB(UInt32 index, SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4NivARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NivARB(UInt32 index, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4NsvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NsvARB(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4NubARB", ExactSpelling = true)]
        internal extern static void VertexAttrib4NubARB(UInt32 index, Byte x, Byte y, Byte z, Byte w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4NubvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NubvARB(UInt32 index, Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4NuivARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NuivARB(UInt32 index, UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4NusvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NusvARB(UInt32 index, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4bvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4bvARB(UInt32 index, SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4dARB", ExactSpelling = true)]
        internal extern static void VertexAttrib4dARB(UInt32 index, Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4dvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4dvARB(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4fARB", ExactSpelling = true)]
        internal extern static void VertexAttrib4fARB(UInt32 index, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4fvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4fvARB(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4ivARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4ivARB(UInt32 index, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4sARB", ExactSpelling = true)]
        internal extern static void VertexAttrib4sARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4svARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4svARB(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4ubvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4ubvARB(UInt32 index, Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4uivARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4uivARB(UInt32 index, UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4usvARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4usvARB(UInt32 index, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribPointerARB", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribPointerARB(UInt32 index, Int32 size, int type, int normalized, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnableVertexAttribArrayARB", ExactSpelling = true)]
        internal extern static void EnableVertexAttribArrayARB(UInt32 index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisableVertexAttribArrayARB", ExactSpelling = true)]
        internal extern static void DisableVertexAttribArrayARB(UInt32 index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramStringARB", ExactSpelling = true)]
        internal extern static unsafe void ProgramStringARB(int target, int format, Int32 len, void* @string);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindProgramARB", ExactSpelling = true)]
        internal extern static void BindProgramARB(int target, UInt32 program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteProgramsARB", ExactSpelling = true)]
        internal extern static unsafe void DeleteProgramsARB(Int32 n, UInt32* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenProgramsARB", ExactSpelling = true)]
        internal extern static unsafe void GenProgramsARB(Int32 n, [Out] UInt32* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParameter4dARB", ExactSpelling = true)]
        internal extern static void ProgramEnvParameter4dARB(int target, UInt32 index, Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParameter4dvARB", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameter4dvARB(int target, UInt32 index, Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParameter4fARB", ExactSpelling = true)]
        internal extern static void ProgramEnvParameter4fARB(int target, UInt32 index, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParameter4fvARB", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameter4fvARB(int target, UInt32 index, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParameter4dARB", ExactSpelling = true)]
        internal extern static void ProgramLocalParameter4dARB(int target, UInt32 index, Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParameter4dvARB", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameter4dvARB(int target, UInt32 index, Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParameter4fARB", ExactSpelling = true)]
        internal extern static void ProgramLocalParameter4fARB(int target, UInt32 index, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParameter4fvARB", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameter4fvARB(int target, UInt32 index, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramEnvParameterdvARB", ExactSpelling = true)]
        internal extern static unsafe void GetProgramEnvParameterdvARB(int target, UInt32 index, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramEnvParameterfvARB", ExactSpelling = true)]
        internal extern static unsafe void GetProgramEnvParameterfvARB(int target, UInt32 index, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramLocalParameterdvARB", ExactSpelling = true)]
        internal extern static unsafe void GetProgramLocalParameterdvARB(int target, UInt32 index, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramLocalParameterfvARB", ExactSpelling = true)]
        internal extern static unsafe void GetProgramLocalParameterfvARB(int target, UInt32 index, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramivARB", ExactSpelling = true)]
        internal extern static unsafe void GetProgramivARB(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramStringARB", ExactSpelling = true)]
        internal extern static unsafe void GetProgramStringARB(int target, int pname, [Out] void* @string);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribdvARB", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribdvARB(UInt32 index, int pname, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribfvARB", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribfvARB(UInt32 index, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribivARB", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribivARB(UInt32 index, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribPointervARB", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribPointervARB(UInt32 index, int pname, [Out] void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsProgramARB", ExactSpelling = true)]
        internal extern static int IsProgramARB(UInt32 program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBufferARB", ExactSpelling = true)]
        internal extern static void BindBufferARB(int target, UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteBuffersARB", ExactSpelling = true)]
        internal extern static unsafe void DeleteBuffersARB(Int32 n, UInt32* buffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenBuffersARB", ExactSpelling = true)]
        internal extern static unsafe void GenBuffersARB(Int32 n, [Out] UInt32* buffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsBufferARB", ExactSpelling = true)]
        internal extern static int IsBufferARB(UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferDataARB", ExactSpelling = true)]
        internal extern static unsafe void BufferDataARB(int target, IntPtr size, void* data, int usage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferSubDataARB", ExactSpelling = true)]
        internal extern static unsafe void BufferSubDataARB(int target, IntPtr offset, IntPtr size, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferSubDataARB", ExactSpelling = true)]
        internal extern static unsafe void GetBufferSubDataARB(int target, IntPtr offset, IntPtr size, [Out] void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapBufferARB", ExactSpelling = true)]
        internal extern static IntPtr MapBufferARB(int target, int access);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUnmapBufferARB", ExactSpelling = true)]
        internal extern static int UnmapBufferARB(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferParameterivARB", ExactSpelling = true)]
        internal extern static unsafe void GetBufferParameterivARB(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferPointervARB", ExactSpelling = true)]
        internal extern static unsafe void GetBufferPointervARB(int target, int pname, [Out] void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenQueriesARB", ExactSpelling = true)]
        internal extern static unsafe void GenQueriesARB(Int32 n, [Out] UInt32* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteQueriesARB", ExactSpelling = true)]
        internal extern static unsafe void DeleteQueriesARB(Int32 n, UInt32* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsQueryARB", ExactSpelling = true)]
        internal extern static int IsQueryARB(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginQueryARB", ExactSpelling = true)]
        internal extern static void BeginQueryARB(int target, UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndQueryARB", ExactSpelling = true)]
        internal extern static void EndQueryARB(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryivARB", ExactSpelling = true)]
        internal extern static unsafe void GetQueryivARB(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectivARB", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectivARB(UInt32 id, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectuivARB", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectuivARB(UInt32 id, int pname, [Out] UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteObjectARB", ExactSpelling = true)]
        internal extern static void DeleteObjectARB(UInt32 obj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHandleARB", ExactSpelling = true)]
        internal extern static Int32 GetHandleARB(int pname);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDetachObjectARB", ExactSpelling = true)]
        internal extern static void DetachObjectARB(UInt32 containerObj, UInt32 attachedObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateShaderObjectARB", ExactSpelling = true)]
        internal extern static Int32 CreateShaderObjectARB(int shaderType);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShaderSourceARB", ExactSpelling = true)]
        internal extern static unsafe void ShaderSourceARB(UInt32 shaderObj, Int32 count, System.String[] @string, Int32* length);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompileShaderARB", ExactSpelling = true)]
        internal extern static void CompileShaderARB(UInt32 shaderObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateProgramObjectARB", ExactSpelling = true)]
        internal extern static Int32 CreateProgramObjectARB();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAttachObjectARB", ExactSpelling = true)]
        internal extern static void AttachObjectARB(UInt32 containerObj, UInt32 obj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLinkProgramARB", ExactSpelling = true)]
        internal extern static void LinkProgramARB(UInt32 programObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUseProgramObjectARB", ExactSpelling = true)]
        internal extern static void UseProgramObjectARB(UInt32 programObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glValidateProgramARB", ExactSpelling = true)]
        internal extern static void ValidateProgramARB(UInt32 programObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1fARB", ExactSpelling = true)]
        internal extern static void Uniform1fARB(Int32 location, Single v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2fARB", ExactSpelling = true)]
        internal extern static void Uniform2fARB(Int32 location, Single v0, Single v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3fARB", ExactSpelling = true)]
        internal extern static void Uniform3fARB(Int32 location, Single v0, Single v1, Single v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4fARB", ExactSpelling = true)]
        internal extern static void Uniform4fARB(Int32 location, Single v0, Single v1, Single v2, Single v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1iARB", ExactSpelling = true)]
        internal extern static void Uniform1iARB(Int32 location, Int32 v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2iARB", ExactSpelling = true)]
        internal extern static void Uniform2iARB(Int32 location, Int32 v0, Int32 v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3iARB", ExactSpelling = true)]
        internal extern static void Uniform3iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4iARB", ExactSpelling = true)]
        internal extern static void Uniform4iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1fvARB", ExactSpelling = true)]
        internal extern static unsafe void Uniform1fvARB(Int32 location, Int32 count, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2fvARB", ExactSpelling = true)]
        internal extern static unsafe void Uniform2fvARB(Int32 location, Int32 count, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3fvARB", ExactSpelling = true)]
        internal extern static unsafe void Uniform3fvARB(Int32 location, Int32 count, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4fvARB", ExactSpelling = true)]
        internal extern static unsafe void Uniform4fvARB(Int32 location, Int32 count, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1ivARB", ExactSpelling = true)]
        internal extern static unsafe void Uniform1ivARB(Int32 location, Int32 count, Int32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2ivARB", ExactSpelling = true)]
        internal extern static unsafe void Uniform2ivARB(Int32 location, Int32 count, Int32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3ivARB", ExactSpelling = true)]
        internal extern static unsafe void Uniform3ivARB(Int32 location, Int32 count, Int32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4ivARB", ExactSpelling = true)]
        internal extern static unsafe void Uniform4ivARB(Int32 location, Int32 count, Int32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2fvARB", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix2fvARB(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3fvARB", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix3fvARB(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4fvARB", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix4fvARB(Int32 location, Int32 count, int transpose, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetObjectParameterfvARB", ExactSpelling = true)]
        internal extern static unsafe void GetObjectParameterfvARB(UInt32 obj, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetObjectParameterivARB", ExactSpelling = true)]
        internal extern static unsafe void GetObjectParameterivARB(UInt32 obj, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetInfoLogARB", ExactSpelling = true)]
        internal extern static unsafe void GetInfoLogARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetAttachedObjectsARB", ExactSpelling = true)]
        internal extern static unsafe void GetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformLocationARB", ExactSpelling = true)]
        internal extern static Int32 GetUniformLocationARB(UInt32 programObj, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveUniformARB", ExactSpelling = true)]
        internal extern static unsafe void GetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformfvARB", ExactSpelling = true)]
        internal extern static unsafe void GetUniformfvARB(UInt32 programObj, Int32 location, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformivARB", ExactSpelling = true)]
        internal extern static unsafe void GetUniformivARB(UInt32 programObj, Int32 location, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderSourceARB", ExactSpelling = true)]
        internal extern static unsafe void GetShaderSourceARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindAttribLocationARB", ExactSpelling = true)]
        internal extern static void BindAttribLocationARB(UInt32 programObj, UInt32 index, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveAttribARB", ExactSpelling = true)]
        internal extern static unsafe void GetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetAttribLocationARB", ExactSpelling = true)]
        internal extern static Int32 GetAttribLocationARB(UInt32 programObj, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawBuffersARB", ExactSpelling = true)]
        internal extern static unsafe void DrawBuffersARB(Int32 n, int* bufs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClampColorARB", ExactSpelling = true)]
        internal extern static void ClampColorARB(int target, int clamp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendColorEXT", ExactSpelling = true)]
        internal extern static void BlendColorEXT(Single red, Single green, Single blue, Single alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPolygonOffsetEXT", ExactSpelling = true)]
        internal extern static void PolygonOffsetEXT(Single factor, Single bias);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage3DEXT", ExactSpelling = true)]
        internal extern static unsafe void TexImage3DEXT(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage3DEXT", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage3DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexFilterFuncSGIS", ExactSpelling = true)]
        internal extern static unsafe void GetTexFilterFuncSGIS(int target, int filter, [Out] Single* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexFilterFuncSGIS", ExactSpelling = true)]
        internal extern static unsafe void TexFilterFuncSGIS(int target, int filter, Int32 n, Single* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage1DEXT", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage1DEXT(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage2DEXT", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage2DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexImage1DEXT", ExactSpelling = true)]
        internal extern static void CopyTexImage1DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexImage2DEXT", ExactSpelling = true)]
        internal extern static void CopyTexImage2DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage1DEXT", ExactSpelling = true)]
        internal extern static void CopyTexSubImage1DEXT(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage2DEXT", ExactSpelling = true)]
        internal extern static void CopyTexSubImage2DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage3DEXT", ExactSpelling = true)]
        internal extern static void CopyTexSubImage3DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHistogramEXT", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramEXT(int target, int reset, int format, int type, [Out] void* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHistogramParameterfvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramParameterfvEXT(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHistogramParameterivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramParameterivEXT(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMinmaxEXT", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxEXT(int target, int reset, int format, int type, [Out] void* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMinmaxParameterfvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxParameterfvEXT(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMinmaxParameterivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxParameterivEXT(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glHistogramEXT", ExactSpelling = true)]
        internal extern static void HistogramEXT(int target, Int32 width, int internalformat, int sink);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMinmaxEXT", ExactSpelling = true)]
        internal extern static void MinmaxEXT(int target, int internalformat, int sink);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glResetHistogramEXT", ExactSpelling = true)]
        internal extern static void ResetHistogramEXT(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glResetMinmaxEXT", ExactSpelling = true)]
        internal extern static void ResetMinmaxEXT(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionFilter1DEXT", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionFilter1DEXT(int target, int internalformat, Int32 width, int format, int type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionFilter2DEXT", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameterfEXT", ExactSpelling = true)]
        internal extern static void ConvolutionParameterfEXT(int target, int pname, Single @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameterfvEXT", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionParameterfvEXT(int target, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameteriEXT", ExactSpelling = true)]
        internal extern static void ConvolutionParameteriEXT(int target, int pname, Int32 @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameterivEXT", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionParameterivEXT(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyConvolutionFilter1DEXT", ExactSpelling = true)]
        internal extern static void CopyConvolutionFilter1DEXT(int target, int internalformat, Int32 x, Int32 y, Int32 width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyConvolutionFilter2DEXT", ExactSpelling = true)]
        internal extern static void CopyConvolutionFilter2DEXT(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetConvolutionFilterEXT", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionFilterEXT(int target, int format, int type, [Out] void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetConvolutionParameterfvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionParameterfvEXT(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetConvolutionParameterivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionParameterivEXT(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSeparableFilterEXT", ExactSpelling = true)]
        internal extern static unsafe void GetSeparableFilterEXT(int target, int format, int type, [Out] void* row, [Out] void* column, [Out] void* span);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSeparableFilter2DEXT", ExactSpelling = true)]
        internal extern static unsafe void SeparableFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, void* row, void* column);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTableSGI", ExactSpelling = true)]
        internal extern static unsafe void ColorTableSGI(int target, int internalformat, Int32 width, int format, int type, void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTableParameterfvSGI", ExactSpelling = true)]
        internal extern static unsafe void ColorTableParameterfvSGI(int target, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTableParameterivSGI", ExactSpelling = true)]
        internal extern static unsafe void ColorTableParameterivSGI(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyColorTableSGI", ExactSpelling = true)]
        internal extern static void CopyColorTableSGI(int target, int internalformat, Int32 x, Int32 y, Int32 width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableSGI", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableSGI(int target, int format, int type, [Out] void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableParameterfvSGI", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterfvSGI(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableParameterivSGI", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterivSGI(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTexGenSGIX", ExactSpelling = true)]
        internal extern static void PixelTexGenSGIX(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTexGenParameteriSGIS", ExactSpelling = true)]
        internal extern static void PixelTexGenParameteriSGIS(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTexGenParameterivSGIS", ExactSpelling = true)]
        internal extern static unsafe void PixelTexGenParameterivSGIS(int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTexGenParameterfSGIS", ExactSpelling = true)]
        internal extern static void PixelTexGenParameterfSGIS(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTexGenParameterfvSGIS", ExactSpelling = true)]
        internal extern static unsafe void PixelTexGenParameterfvSGIS(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPixelTexGenParameterivSGIS", ExactSpelling = true)]
        internal extern static unsafe void GetPixelTexGenParameterivSGIS(int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPixelTexGenParameterfvSGIS", ExactSpelling = true)]
        internal extern static unsafe void GetPixelTexGenParameterfvSGIS(int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage4DSGIS", ExactSpelling = true)]
        internal extern static unsafe void TexImage4DSGIS(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage4DSGIS", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage4DSGIS(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, int format, int type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAreTexturesResidentEXT", ExactSpelling = true)]
        internal extern static unsafe int AreTexturesResidentEXT(Int32 n, UInt32* textures, [Out] int* residences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindTextureEXT", ExactSpelling = true)]
        internal extern static void BindTextureEXT(int target, UInt32 texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteTexturesEXT", ExactSpelling = true)]
        internal extern static unsafe void DeleteTexturesEXT(Int32 n, UInt32* textures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenTexturesEXT", ExactSpelling = true)]
        internal extern static unsafe void GenTexturesEXT(Int32 n, [Out] UInt32* textures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsTextureEXT", ExactSpelling = true)]
        internal extern static int IsTextureEXT(UInt32 texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPrioritizeTexturesEXT", ExactSpelling = true)]
        internal extern static unsafe void PrioritizeTexturesEXT(Int32 n, UInt32* textures, Single* priorities);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDetailTexFuncSGIS", ExactSpelling = true)]
        internal extern static unsafe void DetailTexFuncSGIS(int target, Int32 n, Single* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetDetailTexFuncSGIS", ExactSpelling = true)]
        internal extern static unsafe void GetDetailTexFuncSGIS(int target, [Out] Single* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSharpenTexFuncSGIS", ExactSpelling = true)]
        internal extern static unsafe void SharpenTexFuncSGIS(int target, Int32 n, Single* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSharpenTexFuncSGIS", ExactSpelling = true)]
        internal extern static unsafe void GetSharpenTexFuncSGIS(int target, [Out] Single* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSampleMaskSGIS", ExactSpelling = true)]
        internal extern static void SampleMaskSGIS(Single value, int invert);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSamplePatternSGIS", ExactSpelling = true)]
        internal extern static void SamplePatternSGIS(int pattern);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glArrayElementEXT", ExactSpelling = true)]
        internal extern static void ArrayElementEXT(Int32 i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void ColorPointerEXT(Int32 size, int type, Int32 stride, Int32 count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawArraysEXT", ExactSpelling = true)]
        internal extern static void DrawArraysEXT(int mode, Int32 first, Int32 count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEdgeFlagPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void EdgeFlagPointerEXT(Int32 stride, Int32 count, int* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPointervEXT", ExactSpelling = true)]
        internal extern static unsafe void GetPointervEXT(int pname, [Out] void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void IndexPointerEXT(int type, Int32 stride, Int32 count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void NormalPointerEXT(int type, Int32 stride, Int32 count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoordPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void TexCoordPointerEXT(Int32 size, int type, Int32 stride, Int32 count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexPointerEXT(Int32 size, int type, Int32 stride, Int32 count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquationEXT", ExactSpelling = true)]
        internal extern static void BlendEquationEXT(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSpriteParameterfSGIX", ExactSpelling = true)]
        internal extern static void SpriteParameterfSGIX(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSpriteParameterfvSGIX", ExactSpelling = true)]
        internal extern static unsafe void SpriteParameterfvSGIX(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSpriteParameteriSGIX", ExactSpelling = true)]
        internal extern static void SpriteParameteriSGIX(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSpriteParameterivSGIX", ExactSpelling = true)]
        internal extern static unsafe void SpriteParameterivSGIX(int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterfEXT", ExactSpelling = true)]
        internal extern static void PointParameterfEXT(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterfvEXT", ExactSpelling = true)]
        internal extern static unsafe void PointParameterfvEXT(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterfSGIS", ExactSpelling = true)]
        internal extern static void PointParameterfSGIS(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterfvSGIS", ExactSpelling = true)]
        internal extern static unsafe void PointParameterfvSGIS(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetInstrumentsSGIX", ExactSpelling = true)]
        internal extern static Int32 GetInstrumentsSGIX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInstrumentsBufferSGIX", ExactSpelling = true)]
        internal extern static unsafe void InstrumentsBufferSGIX(Int32 size, [Out] Int32* buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPollInstrumentsSGIX", ExactSpelling = true)]
        internal extern static unsafe Int32 PollInstrumentsSGIX([Out] Int32* marker_p);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReadInstrumentsSGIX", ExactSpelling = true)]
        internal extern static void ReadInstrumentsSGIX(Int32 marker);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStartInstrumentsSGIX", ExactSpelling = true)]
        internal extern static void StartInstrumentsSGIX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStopInstrumentsSGIX", ExactSpelling = true)]
        internal extern static void StopInstrumentsSGIX(Int32 marker);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFrameZoomSGIX", ExactSpelling = true)]
        internal extern static void FrameZoomSGIX(Int32 factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTagSampleBufferSGIX", ExactSpelling = true)]
        internal extern static void TagSampleBufferSGIX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeformationMap3dSGIX", ExactSpelling = true)]
        internal extern static unsafe void DeformationMap3dSGIX(int target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double w1, Double w2, Int32 wstride, Int32 worder, Double* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeformationMap3fSGIX", ExactSpelling = true)]
        internal extern static unsafe void DeformationMap3fSGIX(int target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single w1, Single w2, Int32 wstride, Int32 worder, Single* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeformSGIX", ExactSpelling = true)]
        internal extern static void DeformSGIX(int mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadIdentityDeformationMapSGIX", ExactSpelling = true)]
        internal extern static void LoadIdentityDeformationMapSGIX(int mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReferencePlaneSGIX", ExactSpelling = true)]
        internal extern static unsafe void ReferencePlaneSGIX(Double* equation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlushRasterSGIX", ExactSpelling = true)]
        internal extern static void FlushRasterSGIX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogFuncSGIS", ExactSpelling = true)]
        internal extern static unsafe void FogFuncSGIS(Int32 n, Single* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFogFuncSGIS", ExactSpelling = true)]
        internal extern static unsafe void GetFogFuncSGIS([Out] Single* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glImageTransformParameteriHP", ExactSpelling = true)]
        internal extern static void ImageTransformParameteriHP(int target, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glImageTransformParameterfHP", ExactSpelling = true)]
        internal extern static void ImageTransformParameterfHP(int target, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glImageTransformParameterivHP", ExactSpelling = true)]
        internal extern static unsafe void ImageTransformParameterivHP(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glImageTransformParameterfvHP", ExactSpelling = true)]
        internal extern static unsafe void ImageTransformParameterfvHP(int target, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetImageTransformParameterivHP", ExactSpelling = true)]
        internal extern static unsafe void GetImageTransformParameterivHP(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetImageTransformParameterfvHP", ExactSpelling = true)]
        internal extern static unsafe void GetImageTransformParameterfvHP(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorSubTableEXT", ExactSpelling = true)]
        internal extern static unsafe void ColorSubTableEXT(int target, Int32 start, Int32 count, int format, int type, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyColorSubTableEXT", ExactSpelling = true)]
        internal extern static void CopyColorSubTableEXT(int target, Int32 start, Int32 x, Int32 y, Int32 width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glHintPGI", ExactSpelling = true)]
        internal extern static void HintPGI(int target, Int32 mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTableEXT", ExactSpelling = true)]
        internal extern static unsafe void ColorTableEXT(int target, int internalFormat, Int32 width, int format, int type, void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableEXT", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableEXT(int target, int format, int type, [Out] void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableParameterivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterivEXT(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableParameterfvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterfvEXT(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetListParameterfvSGIX", ExactSpelling = true)]
        internal extern static unsafe void GetListParameterfvSGIX(UInt32 list, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetListParameterivSGIX", ExactSpelling = true)]
        internal extern static unsafe void GetListParameterivSGIX(UInt32 list, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glListParameterfSGIX", ExactSpelling = true)]
        internal extern static void ListParameterfSGIX(UInt32 list, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glListParameterfvSGIX", ExactSpelling = true)]
        internal extern static unsafe void ListParameterfvSGIX(UInt32 list, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glListParameteriSGIX", ExactSpelling = true)]
        internal extern static void ListParameteriSGIX(UInt32 list, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glListParameterivSGIX", ExactSpelling = true)]
        internal extern static unsafe void ListParameterivSGIX(UInt32 list, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexMaterialEXT", ExactSpelling = true)]
        internal extern static void IndexMaterialEXT(int face, int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexFuncEXT", ExactSpelling = true)]
        internal extern static void IndexFuncEXT(int func, Single @ref);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLockArraysEXT", ExactSpelling = true)]
        internal extern static void LockArraysEXT(Int32 first, Int32 count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUnlockArraysEXT", ExactSpelling = true)]
        internal extern static void UnlockArraysEXT();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCullParameterdvEXT", ExactSpelling = true)]
        internal extern static unsafe void CullParameterdvEXT(int pname, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCullParameterfvEXT", ExactSpelling = true)]
        internal extern static unsafe void CullParameterfvEXT(int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentColorMaterialSGIX", ExactSpelling = true)]
        internal extern static void FragmentColorMaterialSGIX(int face, int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentLightfSGIX", ExactSpelling = true)]
        internal extern static void FragmentLightfSGIX(int light, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentLightfvSGIX", ExactSpelling = true)]
        internal extern static unsafe void FragmentLightfvSGIX(int light, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentLightiSGIX", ExactSpelling = true)]
        internal extern static void FragmentLightiSGIX(int light, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentLightivSGIX", ExactSpelling = true)]
        internal extern static unsafe void FragmentLightivSGIX(int light, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentLightModelfSGIX", ExactSpelling = true)]
        internal extern static void FragmentLightModelfSGIX(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentLightModelfvSGIX", ExactSpelling = true)]
        internal extern static unsafe void FragmentLightModelfvSGIX(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentLightModeliSGIX", ExactSpelling = true)]
        internal extern static void FragmentLightModeliSGIX(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentLightModelivSGIX", ExactSpelling = true)]
        internal extern static unsafe void FragmentLightModelivSGIX(int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentMaterialfSGIX", ExactSpelling = true)]
        internal extern static void FragmentMaterialfSGIX(int face, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentMaterialfvSGIX", ExactSpelling = true)]
        internal extern static unsafe void FragmentMaterialfvSGIX(int face, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentMaterialiSGIX", ExactSpelling = true)]
        internal extern static void FragmentMaterialiSGIX(int face, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFragmentMaterialivSGIX", ExactSpelling = true)]
        internal extern static unsafe void FragmentMaterialivSGIX(int face, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFragmentLightfvSGIX", ExactSpelling = true)]
        internal extern static unsafe void GetFragmentLightfvSGIX(int light, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFragmentLightivSGIX", ExactSpelling = true)]
        internal extern static unsafe void GetFragmentLightivSGIX(int light, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFragmentMaterialfvSGIX", ExactSpelling = true)]
        internal extern static unsafe void GetFragmentMaterialfvSGIX(int face, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFragmentMaterialivSGIX", ExactSpelling = true)]
        internal extern static unsafe void GetFragmentMaterialivSGIX(int face, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightEnviSGIX", ExactSpelling = true)]
        internal extern static void LightEnviSGIX(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawRangeElementsEXT", ExactSpelling = true)]
        internal extern static unsafe void DrawRangeElementsEXT(int mode, UInt32 start, UInt32 end, Int32 count, int type, void* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glApplyTextureEXT", ExactSpelling = true)]
        internal extern static void ApplyTextureEXT(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureLightEXT", ExactSpelling = true)]
        internal extern static void TextureLightEXT(int pname);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureMaterialEXT", ExactSpelling = true)]
        internal extern static void TextureMaterialEXT(int face, int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAsyncMarkerSGIX", ExactSpelling = true)]
        internal extern static void AsyncMarkerSGIX(UInt32 marker);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFinishAsyncSGIX", ExactSpelling = true)]
        internal extern static unsafe Int32 FinishAsyncSGIX([Out] UInt32* markerp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPollAsyncSGIX", ExactSpelling = true)]
        internal extern static unsafe Int32 PollAsyncSGIX([Out] UInt32* markerp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenAsyncMarkersSGIX", ExactSpelling = true)]
        internal extern static Int32 GenAsyncMarkersSGIX(Int32 range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteAsyncMarkersSGIX", ExactSpelling = true)]
        internal extern static void DeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsAsyncMarkerSGIX", ExactSpelling = true)]
        internal extern static int IsAsyncMarkerSGIX(UInt32 marker);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexPointervINTEL", ExactSpelling = true)]
        internal extern static unsafe void VertexPointervINTEL(Int32 size, int type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalPointervINTEL", ExactSpelling = true)]
        internal extern static unsafe void NormalPointervINTEL(int type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorPointervINTEL", ExactSpelling = true)]
        internal extern static unsafe void ColorPointervINTEL(Int32 size, int type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoordPointervINTEL", ExactSpelling = true)]
        internal extern static unsafe void TexCoordPointervINTEL(Int32 size, int type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTransformParameteriEXT", ExactSpelling = true)]
        internal extern static void PixelTransformParameteriEXT(int target, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTransformParameterfEXT", ExactSpelling = true)]
        internal extern static void PixelTransformParameterfEXT(int target, int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTransformParameterivEXT", ExactSpelling = true)]
        internal extern static unsafe void PixelTransformParameterivEXT(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTransformParameterfvEXT", ExactSpelling = true)]
        internal extern static unsafe void PixelTransformParameterfvEXT(int target, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3bEXT", ExactSpelling = true)]
        internal extern static void SecondaryColor3bEXT(SByte red, SByte green, SByte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3bvEXT", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3bvEXT(SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3dEXT", ExactSpelling = true)]
        internal extern static void SecondaryColor3dEXT(Double red, Double green, Double blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3dvEXT", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3dvEXT(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3fEXT", ExactSpelling = true)]
        internal extern static void SecondaryColor3fEXT(Single red, Single green, Single blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3fvEXT", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3fvEXT(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3iEXT", ExactSpelling = true)]
        internal extern static void SecondaryColor3iEXT(Int32 red, Int32 green, Int32 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3ivEXT", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3ivEXT(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3sEXT", ExactSpelling = true)]
        internal extern static void SecondaryColor3sEXT(Int16 red, Int16 green, Int16 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3svEXT", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3svEXT(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3ubEXT", ExactSpelling = true)]
        internal extern static void SecondaryColor3ubEXT(Byte red, Byte green, Byte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3ubvEXT", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3ubvEXT(Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3uiEXT", ExactSpelling = true)]
        internal extern static void SecondaryColor3uiEXT(UInt32 red, UInt32 green, UInt32 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3uivEXT", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3uivEXT(UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3usEXT", ExactSpelling = true)]
        internal extern static void SecondaryColor3usEXT(UInt16 red, UInt16 green, UInt16 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3usvEXT", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3usvEXT(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColorPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColorPointerEXT(Int32 size, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureNormalEXT", ExactSpelling = true)]
        internal extern static void TextureNormalEXT(int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawArraysEXT", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawArraysEXT(int mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawElementsEXT", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawElementsEXT(int mode, Int32* count, int type, void* indices, Int32 primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordfEXT", ExactSpelling = true)]
        internal extern static void FogCoordfEXT(Single coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordfvEXT", ExactSpelling = true)]
        internal extern static unsafe void FogCoordfvEXT(Single* coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoorddEXT", ExactSpelling = true)]
        internal extern static void FogCoorddEXT(Double coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoorddvEXT", ExactSpelling = true)]
        internal extern static unsafe void FogCoorddvEXT(Double* coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void FogCoordPointerEXT(int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3bEXT", ExactSpelling = true)]
        internal extern static void Tangent3bEXT(SByte tx, SByte ty, SByte tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3bvEXT", ExactSpelling = true)]
        internal extern static unsafe void Tangent3bvEXT(SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3dEXT", ExactSpelling = true)]
        internal extern static void Tangent3dEXT(Double tx, Double ty, Double tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3dvEXT", ExactSpelling = true)]
        internal extern static unsafe void Tangent3dvEXT(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3fEXT", ExactSpelling = true)]
        internal extern static void Tangent3fEXT(Single tx, Single ty, Single tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3fvEXT", ExactSpelling = true)]
        internal extern static unsafe void Tangent3fvEXT(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3iEXT", ExactSpelling = true)]
        internal extern static void Tangent3iEXT(Int32 tx, Int32 ty, Int32 tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3ivEXT", ExactSpelling = true)]
        internal extern static unsafe void Tangent3ivEXT(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3sEXT", ExactSpelling = true)]
        internal extern static void Tangent3sEXT(Int16 tx, Int16 ty, Int16 tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangent3svEXT", ExactSpelling = true)]
        internal extern static unsafe void Tangent3svEXT(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3bEXT", ExactSpelling = true)]
        internal extern static void Binormal3bEXT(SByte bx, SByte by, SByte bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3bvEXT", ExactSpelling = true)]
        internal extern static unsafe void Binormal3bvEXT(SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3dEXT", ExactSpelling = true)]
        internal extern static void Binormal3dEXT(Double bx, Double by, Double bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3dvEXT", ExactSpelling = true)]
        internal extern static unsafe void Binormal3dvEXT(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3fEXT", ExactSpelling = true)]
        internal extern static void Binormal3fEXT(Single bx, Single by, Single bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3fvEXT", ExactSpelling = true)]
        internal extern static unsafe void Binormal3fvEXT(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3iEXT", ExactSpelling = true)]
        internal extern static void Binormal3iEXT(Int32 bx, Int32 by, Int32 bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3ivEXT", ExactSpelling = true)]
        internal extern static unsafe void Binormal3ivEXT(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3sEXT", ExactSpelling = true)]
        internal extern static void Binormal3sEXT(Int16 bx, Int16 by, Int16 bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormal3svEXT", ExactSpelling = true)]
        internal extern static unsafe void Binormal3svEXT(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTangentPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void TangentPointerEXT(int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBinormalPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void BinormalPointerEXT(int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFinishTextureSUNX", ExactSpelling = true)]
        internal extern static void FinishTextureSUNX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGlobalAlphaFactorbSUN", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorbSUN(SByte factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGlobalAlphaFactorsSUN", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorsSUN(Int16 factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGlobalAlphaFactoriSUN", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactoriSUN(Int32 factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGlobalAlphaFactorfSUN", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorfSUN(Single factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGlobalAlphaFactordSUN", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactordSUN(Double factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGlobalAlphaFactorubSUN", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorubSUN(Byte factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGlobalAlphaFactorusSUN", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorusSUN(UInt16 factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGlobalAlphaFactoruiSUN", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactoruiSUN(UInt32 factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiSUN(UInt32 code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeusSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeusSUN(UInt16 code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeubSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeubSUN(Byte code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuivSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuivSUN(UInt32* code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeusvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeusvSUN(UInt16* code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeubvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeubvSUN(Byte* code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodePointerSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodePointerSUN(int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ubVertex2fSUN", ExactSpelling = true)]
        internal extern static void Color4ubVertex2fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ubVertex2fvSUN", ExactSpelling = true)]
        internal extern static unsafe void Color4ubVertex2fvSUN(Byte* c, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ubVertex3fSUN", ExactSpelling = true)]
        internal extern static void Color4ubVertex3fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ubVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void Color4ubVertex3fvSUN(Byte* c, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void Color3fVertex3fSUN(Single r, Single g, Single b, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void Color3fVertex3fvSUN(Single* c, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void Normal3fVertex3fSUN(Single nx, Single ny, Single nz, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void Normal3fVertex3fvSUN(Single* n, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void Color4fNormal3fVertex3fSUN(Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void Color4fNormal3fVertex3fvSUN(Single* c, Single* n, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fVertex3fSUN", ExactSpelling = true)]
        internal extern static void TexCoord2fVertex3fSUN(Single s, Single t, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fVertex3fvSUN(Single* tc, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4fVertex4fSUN", ExactSpelling = true)]
        internal extern static void TexCoord4fVertex4fSUN(Single s, Single t, Single p, Single q, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4fVertex4fvSUN", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4fVertex4fvSUN(Single* tc, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fColor4ubVertex3fSUN", ExactSpelling = true)]
        internal extern static void TexCoord2fColor4ubVertex3fSUN(Single s, Single t, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fColor4ubVertex3fvSUN(Single* tc, Byte* c, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fColor3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void TexCoord2fColor3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fColor3fVertex3fvSUN(Single* tc, Single* c, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void TexCoord2fNormal3fVertex3fSUN(Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fNormal3fVertex3fvSUN(Single* tc, Single* n, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void TexCoord2fColor4fNormal3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(Single* tc, Single* c, Single* n, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fSUN", ExactSpelling = true)]
        internal extern static void TexCoord4fColor4fNormal3fVertex4fSUN(Single s, Single t, Single p, Single q, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(Single* tc, Single* c, Single* n, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiVertex3fSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiVertex3fSUN(UInt32 rc, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiVertex3fvSUN(UInt32* rc, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, Byte* c, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, Single* c, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, Single* n, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* c, Single* n, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, Single s, Single t, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, Single* tc, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* n, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* c, Single* n, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFuncSeparateEXT", ExactSpelling = true)]
        internal extern static void BlendFuncSeparateEXT(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFuncSeparateINGR", ExactSpelling = true)]
        internal extern static void BlendFuncSeparateINGR(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexWeightfEXT", ExactSpelling = true)]
        internal extern static void VertexWeightfEXT(Single weight);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexWeightfvEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexWeightfvEXT(Single* weight);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexWeightPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexWeightPointerEXT(Int32 size, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlushVertexArrayRangeNV", ExactSpelling = true)]
        internal extern static void FlushVertexArrayRangeNV();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayRangeNV", ExactSpelling = true)]
        internal extern static unsafe void VertexArrayRangeNV(Int32 length, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCombinerParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void CombinerParameterfvNV(int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCombinerParameterfNV", ExactSpelling = true)]
        internal extern static void CombinerParameterfNV(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCombinerParameterivNV", ExactSpelling = true)]
        internal extern static unsafe void CombinerParameterivNV(int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCombinerParameteriNV", ExactSpelling = true)]
        internal extern static void CombinerParameteriNV(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCombinerInputNV", ExactSpelling = true)]
        internal extern static void CombinerInputNV(int stage, int portion, int variable, int input, int mapping, int componentUsage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCombinerOutputNV", ExactSpelling = true)]
        internal extern static void CombinerOutputNV(int stage, int portion, int abOutput, int cdOutput, int sumOutput, int scale, int bias, int abDotProduct, int cdDotProduct, int muxSum);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFinalCombinerInputNV", ExactSpelling = true)]
        internal extern static void FinalCombinerInputNV(int variable, int input, int mapping, int componentUsage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCombinerInputParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerInputParameterfvNV(int stage, int portion, int variable, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCombinerInputParameterivNV", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerInputParameterivNV(int stage, int portion, int variable, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCombinerOutputParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerOutputParameterfvNV(int stage, int portion, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCombinerOutputParameterivNV", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerOutputParameterivNV(int stage, int portion, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFinalCombinerInputParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void GetFinalCombinerInputParameterfvNV(int variable, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFinalCombinerInputParameterivNV", ExactSpelling = true)]
        internal extern static unsafe void GetFinalCombinerInputParameterivNV(int variable, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glResizeBuffersMESA", ExactSpelling = true)]
        internal extern static void ResizeBuffersMESA();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2dMESA", ExactSpelling = true)]
        internal extern static void WindowPos2dMESA(Double x, Double y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2dvMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2dvMESA(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2fMESA", ExactSpelling = true)]
        internal extern static void WindowPos2fMESA(Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2fvMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2fvMESA(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2iMESA", ExactSpelling = true)]
        internal extern static void WindowPos2iMESA(Int32 x, Int32 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2ivMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2ivMESA(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2sMESA", ExactSpelling = true)]
        internal extern static void WindowPos2sMESA(Int16 x, Int16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2svMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2svMESA(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3dMESA", ExactSpelling = true)]
        internal extern static void WindowPos3dMESA(Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3dvMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3dvMESA(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3fMESA", ExactSpelling = true)]
        internal extern static void WindowPos3fMESA(Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3fvMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3fvMESA(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3iMESA", ExactSpelling = true)]
        internal extern static void WindowPos3iMESA(Int32 x, Int32 y, Int32 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3ivMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3ivMESA(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3sMESA", ExactSpelling = true)]
        internal extern static void WindowPos3sMESA(Int16 x, Int16 y, Int16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3svMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3svMESA(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos4dMESA", ExactSpelling = true)]
        internal extern static void WindowPos4dMESA(Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos4dvMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos4dvMESA(Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos4fMESA", ExactSpelling = true)]
        internal extern static void WindowPos4fMESA(Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos4fvMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos4fvMESA(Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos4iMESA", ExactSpelling = true)]
        internal extern static void WindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos4ivMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos4ivMESA(Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos4sMESA", ExactSpelling = true)]
        internal extern static void WindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos4svMESA", ExactSpelling = true)]
        internal extern static unsafe void WindowPos4svMESA(Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiModeDrawArraysIBM", ExactSpelling = true)]
        internal extern static unsafe void MultiModeDrawArraysIBM(int* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiModeDrawElementsIBM", ExactSpelling = true)]
        internal extern static unsafe void MultiModeDrawElementsIBM(int* mode, Int32* count, int type, void* indices, Int32 primcount, Int32 modestride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorPointerListIBM", ExactSpelling = true)]
        internal extern static unsafe void ColorPointerListIBM(Int32 size, int type, Int32 stride, void* pointer, Int32 ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColorPointerListIBM", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColorPointerListIBM(Int32 size, int type, Int32 stride, void* pointer, Int32 ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEdgeFlagPointerListIBM", ExactSpelling = true)]
        internal extern static unsafe void EdgeFlagPointerListIBM(Int32 stride, Boolean* pointer, Int32 ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordPointerListIBM", ExactSpelling = true)]
        internal extern static unsafe void FogCoordPointerListIBM(int type, Int32 stride, void* pointer, Int32 ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexPointerListIBM", ExactSpelling = true)]
        internal extern static unsafe void IndexPointerListIBM(int type, Int32 stride, void* pointer, Int32 ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalPointerListIBM", ExactSpelling = true)]
        internal extern static unsafe void NormalPointerListIBM(int type, Int32 stride, void* pointer, Int32 ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoordPointerListIBM", ExactSpelling = true)]
        internal extern static unsafe void TexCoordPointerListIBM(Int32 size, int type, Int32 stride, void* pointer, Int32 ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexPointerListIBM", ExactSpelling = true)]
        internal extern static unsafe void VertexPointerListIBM(Int32 size, int type, Int32 stride, void* pointer, Int32 ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTbufferMask3DFX", ExactSpelling = true)]
        internal extern static void TbufferMask3DFX(UInt32 mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSampleMaskEXT", ExactSpelling = true)]
        internal extern static void SampleMaskEXT(Single value, int invert);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSamplePatternEXT", ExactSpelling = true)]
        internal extern static void SamplePatternEXT(int pattern);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureColorMaskSGIS", ExactSpelling = true)]
        internal extern static void TextureColorMaskSGIS(int red, int green, int blue, int alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIglooInterfaceSGIX", ExactSpelling = true)]
        internal extern static unsafe void IglooInterfaceSGIX(int pname, void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteFencesNV", ExactSpelling = true)]
        internal extern static unsafe void DeleteFencesNV(Int32 n, UInt32* fences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenFencesNV", ExactSpelling = true)]
        internal extern static unsafe void GenFencesNV(Int32 n, [Out] UInt32* fences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsFenceNV", ExactSpelling = true)]
        internal extern static int IsFenceNV(UInt32 fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTestFenceNV", ExactSpelling = true)]
        internal extern static int TestFenceNV(UInt32 fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFenceivNV", ExactSpelling = true)]
        internal extern static unsafe void GetFenceivNV(UInt32 fence, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFinishFenceNV", ExactSpelling = true)]
        internal extern static void FinishFenceNV(UInt32 fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSetFenceNV", ExactSpelling = true)]
        internal extern static void SetFenceNV(UInt32 fence, int condition);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapControlPointsNV", ExactSpelling = true)]
        internal extern static unsafe void MapControlPointsNV(int target, UInt32 index, int type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, int packed, void* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapParameterivNV", ExactSpelling = true)]
        internal extern static unsafe void MapParameterivNV(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void MapParameterfvNV(int target, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapControlPointsNV", ExactSpelling = true)]
        internal extern static unsafe void GetMapControlPointsNV(int target, UInt32 index, int type, Int32 ustride, Int32 vstride, int packed, [Out] void* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapParameterivNV", ExactSpelling = true)]
        internal extern static unsafe void GetMapParameterivNV(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void GetMapParameterfvNV(int target, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapAttribParameterivNV", ExactSpelling = true)]
        internal extern static unsafe void GetMapAttribParameterivNV(int target, UInt32 index, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapAttribParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void GetMapAttribParameterfvNV(int target, UInt32 index, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalMapsNV", ExactSpelling = true)]
        internal extern static void EvalMapsNV(int target, int mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCombinerStageParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void CombinerStageParameterfvNV(int stage, int pname, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCombinerStageParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerStageParameterfvNV(int stage, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAreProgramsResidentNV", ExactSpelling = true)]
        internal extern static unsafe int AreProgramsResidentNV(Int32 n, UInt32* programs, [Out] int* residences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindProgramNV", ExactSpelling = true)]
        internal extern static void BindProgramNV(int target, UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteProgramsNV", ExactSpelling = true)]
        internal extern static unsafe void DeleteProgramsNV(Int32 n, UInt32* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glExecuteProgramNV", ExactSpelling = true)]
        internal extern static unsafe void ExecuteProgramNV(int target, UInt32 id, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenProgramsNV", ExactSpelling = true)]
        internal extern static unsafe void GenProgramsNV(Int32 n, [Out] UInt32* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramParameterdvNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramParameterdvNV(int target, UInt32 index, int pname, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramParameterfvNV(int target, UInt32 index, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramivNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramivNV(UInt32 id, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramStringNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramStringNV(UInt32 id, int pname, [Out] Byte* program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTrackMatrixivNV", ExactSpelling = true)]
        internal extern static unsafe void GetTrackMatrixivNV(int target, UInt32 address, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribdvNV", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribdvNV(UInt32 index, int pname, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribfvNV", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribfvNV(UInt32 index, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribivNV", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribivNV(UInt32 index, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribPointervNV", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribPointervNV(UInt32 index, int pname, [Out] void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsProgramNV", ExactSpelling = true)]
        internal extern static int IsProgramNV(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadProgramNV", ExactSpelling = true)]
        internal extern static unsafe void LoadProgramNV(int target, UInt32 id, Int32 len, Byte* program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramParameter4dNV", ExactSpelling = true)]
        internal extern static void ProgramParameter4dNV(int target, UInt32 index, Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramParameter4dvNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramParameter4dvNV(int target, UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramParameter4fNV", ExactSpelling = true)]
        internal extern static void ProgramParameter4fNV(int target, UInt32 index, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramParameter4fvNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramParameter4fvNV(int target, UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramParameters4dvNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramParameters4dvNV(int target, UInt32 index, UInt32 count, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramParameters4fvNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramParameters4fvNV(int target, UInt32 index, UInt32 count, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRequestResidentProgramsNV", ExactSpelling = true)]
        internal extern static unsafe void RequestResidentProgramsNV(Int32 n, UInt32* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTrackMatrixNV", ExactSpelling = true)]
        internal extern static void TrackMatrixNV(int target, UInt32 address, int matrix, int transform);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribPointerNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribPointerNV(UInt32 index, Int32 fsize, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1dNV", ExactSpelling = true)]
        internal extern static void VertexAttrib1dNV(UInt32 index, Double x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1dvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1dvNV(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1fNV", ExactSpelling = true)]
        internal extern static void VertexAttrib1fNV(UInt32 index, Single x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1fvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1fvNV(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1sNV", ExactSpelling = true)]
        internal extern static void VertexAttrib1sNV(UInt32 index, Int16 x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1svNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1svNV(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2dNV", ExactSpelling = true)]
        internal extern static void VertexAttrib2dNV(UInt32 index, Double x, Double y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2dvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2dvNV(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2fNV", ExactSpelling = true)]
        internal extern static void VertexAttrib2fNV(UInt32 index, Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2fvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2fvNV(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2sNV", ExactSpelling = true)]
        internal extern static void VertexAttrib2sNV(UInt32 index, Int16 x, Int16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2svNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2svNV(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3dNV", ExactSpelling = true)]
        internal extern static void VertexAttrib3dNV(UInt32 index, Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3dvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3dvNV(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3fNV", ExactSpelling = true)]
        internal extern static void VertexAttrib3fNV(UInt32 index, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3fvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3fvNV(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3sNV", ExactSpelling = true)]
        internal extern static void VertexAttrib3sNV(UInt32 index, Int16 x, Int16 y, Int16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3svNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3svNV(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4dNV", ExactSpelling = true)]
        internal extern static void VertexAttrib4dNV(UInt32 index, Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4dvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4dvNV(UInt32 index, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4fNV", ExactSpelling = true)]
        internal extern static void VertexAttrib4fNV(UInt32 index, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4fvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4fvNV(UInt32 index, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4sNV", ExactSpelling = true)]
        internal extern static void VertexAttrib4sNV(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4svNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4svNV(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4ubNV", ExactSpelling = true)]
        internal extern static void VertexAttrib4ubNV(UInt32 index, Byte x, Byte y, Byte z, Byte w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4ubvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4ubvNV(UInt32 index, Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs1dvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs1dvNV(UInt32 index, Int32 count, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs1fvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs1fvNV(UInt32 index, Int32 count, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs1svNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs2dvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs2dvNV(UInt32 index, Int32 count, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs2fvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs2fvNV(UInt32 index, Int32 count, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs2svNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs3dvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs3dvNV(UInt32 index, Int32 count, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs3fvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs3fvNV(UInt32 index, Int32 count, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs3svNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs4dvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4dvNV(UInt32 index, Int32 count, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs4fvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4fvNV(UInt32 index, Int32 count, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs4svNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs4ubvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4ubvNV(UInt32 index, Int32 count, Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexBumpParameterivATI", ExactSpelling = true)]
        internal extern static unsafe void TexBumpParameterivATI(int pname, Int32* param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexBumpParameterfvATI", ExactSpelling = true)]
        internal extern static unsafe void TexBumpParameterfvATI(int pname, Single* param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexBumpParameterivATI", ExactSpelling = true)]
        internal extern static unsafe void GetTexBumpParameterivATI(int pname, [Out] Int32* param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexBumpParameterfvATI", ExactSpelling = true)]
        internal extern static unsafe void GetTexBumpParameterfvATI(int pname, [Out] Single* param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenFragmentShadersATI", ExactSpelling = true)]
        internal extern static Int32 GenFragmentShadersATI(UInt32 range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindFragmentShaderATI", ExactSpelling = true)]
        internal extern static void BindFragmentShaderATI(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteFragmentShaderATI", ExactSpelling = true)]
        internal extern static void DeleteFragmentShaderATI(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginFragmentShaderATI", ExactSpelling = true)]
        internal extern static void BeginFragmentShaderATI();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndFragmentShaderATI", ExactSpelling = true)]
        internal extern static void EndFragmentShaderATI();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPassTexCoordATI", ExactSpelling = true)]
        internal extern static void PassTexCoordATI(UInt32 dst, UInt32 coord, int swizzle);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSampleMapATI", ExactSpelling = true)]
        internal extern static void SampleMapATI(UInt32 dst, UInt32 interp, int swizzle);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorFragmentOp1ATI", ExactSpelling = true)]
        internal extern static void ColorFragmentOp1ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorFragmentOp2ATI", ExactSpelling = true)]
        internal extern static void ColorFragmentOp2ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorFragmentOp3ATI", ExactSpelling = true)]
        internal extern static void ColorFragmentOp3ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAlphaFragmentOp1ATI", ExactSpelling = true)]
        internal extern static void AlphaFragmentOp1ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAlphaFragmentOp2ATI", ExactSpelling = true)]
        internal extern static void AlphaFragmentOp2ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAlphaFragmentOp3ATI", ExactSpelling = true)]
        internal extern static void AlphaFragmentOp3ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSetFragmentShaderConstantATI", ExactSpelling = true)]
        internal extern static unsafe void SetFragmentShaderConstantATI(UInt32 dst, Single* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPNTrianglesiATI", ExactSpelling = true)]
        internal extern static void PNTrianglesiATI(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPNTrianglesfATI", ExactSpelling = true)]
        internal extern static void PNTrianglesfATI(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNewObjectBufferATI", ExactSpelling = true)]
        internal extern static unsafe Int32 NewObjectBufferATI(Int32 size, void* pointer, int usage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsObjectBufferATI", ExactSpelling = true)]
        internal extern static int IsObjectBufferATI(UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUpdateObjectBufferATI", ExactSpelling = true)]
        internal extern static unsafe void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, void* pointer, int preserve);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetObjectBufferfvATI", ExactSpelling = true)]
        internal extern static unsafe void GetObjectBufferfvATI(UInt32 buffer, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetObjectBufferivATI", ExactSpelling = true)]
        internal extern static unsafe void GetObjectBufferivATI(UInt32 buffer, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFreeObjectBufferATI", ExactSpelling = true)]
        internal extern static void FreeObjectBufferATI(UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glArrayObjectATI", ExactSpelling = true)]
        internal extern static void ArrayObjectATI(int array, Int32 size, int type, Int32 stride, UInt32 buffer, UInt32 offset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetArrayObjectfvATI", ExactSpelling = true)]
        internal extern static unsafe void GetArrayObjectfvATI(int array, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetArrayObjectivATI", ExactSpelling = true)]
        internal extern static unsafe void GetArrayObjectivATI(int array, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantArrayObjectATI", ExactSpelling = true)]
        internal extern static void VariantArrayObjectATI(UInt32 id, int type, Int32 stride, UInt32 buffer, UInt32 offset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVariantArrayObjectfvATI", ExactSpelling = true)]
        internal extern static unsafe void GetVariantArrayObjectfvATI(UInt32 id, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVariantArrayObjectivATI", ExactSpelling = true)]
        internal extern static unsafe void GetVariantArrayObjectivATI(UInt32 id, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginVertexShaderEXT", ExactSpelling = true)]
        internal extern static void BeginVertexShaderEXT();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndVertexShaderEXT", ExactSpelling = true)]
        internal extern static void EndVertexShaderEXT();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindVertexShaderEXT", ExactSpelling = true)]
        internal extern static void BindVertexShaderEXT(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenVertexShadersEXT", ExactSpelling = true)]
        internal extern static Int32 GenVertexShadersEXT(UInt32 range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteVertexShaderEXT", ExactSpelling = true)]
        internal extern static void DeleteVertexShaderEXT(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShaderOp1EXT", ExactSpelling = true)]
        internal extern static void ShaderOp1EXT(int op, UInt32 res, UInt32 arg1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShaderOp2EXT", ExactSpelling = true)]
        internal extern static void ShaderOp2EXT(int op, UInt32 res, UInt32 arg1, UInt32 arg2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShaderOp3EXT", ExactSpelling = true)]
        internal extern static void ShaderOp3EXT(int op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSwizzleEXT", ExactSpelling = true)]
        internal extern static void SwizzleEXT(UInt32 res, UInt32 @in, int outX, int outY, int outZ, int outW);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWriteMaskEXT", ExactSpelling = true)]
        internal extern static void WriteMaskEXT(UInt32 res, UInt32 @in, int outX, int outY, int outZ, int outW);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInsertComponentEXT", ExactSpelling = true)]
        internal extern static void InsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glExtractComponentEXT", ExactSpelling = true)]
        internal extern static void ExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenSymbolsEXT", ExactSpelling = true)]
        internal extern static Int32 GenSymbolsEXT(int datatype, int storagetype, int range, UInt32 components);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSetInvariantEXT", ExactSpelling = true)]
        internal extern static unsafe void SetInvariantEXT(UInt32 id, int type, void* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSetLocalConstantEXT", ExactSpelling = true)]
        internal extern static unsafe void SetLocalConstantEXT(UInt32 id, int type, void* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantbvEXT", ExactSpelling = true)]
        internal extern static unsafe void VariantbvEXT(UInt32 id, SByte* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantsvEXT", ExactSpelling = true)]
        internal extern static unsafe void VariantsvEXT(UInt32 id, Int16* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantivEXT", ExactSpelling = true)]
        internal extern static unsafe void VariantivEXT(UInt32 id, Int32* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantfvEXT", ExactSpelling = true)]
        internal extern static unsafe void VariantfvEXT(UInt32 id, Single* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantdvEXT", ExactSpelling = true)]
        internal extern static unsafe void VariantdvEXT(UInt32 id, Double* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantubvEXT", ExactSpelling = true)]
        internal extern static unsafe void VariantubvEXT(UInt32 id, Byte* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantusvEXT", ExactSpelling = true)]
        internal extern static unsafe void VariantusvEXT(UInt32 id, UInt16* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantuivEXT", ExactSpelling = true)]
        internal extern static unsafe void VariantuivEXT(UInt32 id, UInt32* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVariantPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void VariantPointerEXT(UInt32 id, int type, UInt32 stride, void* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnableVariantClientStateEXT", ExactSpelling = true)]
        internal extern static void EnableVariantClientStateEXT(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisableVariantClientStateEXT", ExactSpelling = true)]
        internal extern static void DisableVariantClientStateEXT(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindLightParameterEXT", ExactSpelling = true)]
        internal extern static Int32 BindLightParameterEXT(int light, int value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindMaterialParameterEXT", ExactSpelling = true)]
        internal extern static Int32 BindMaterialParameterEXT(int face, int value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindTexGenParameterEXT", ExactSpelling = true)]
        internal extern static Int32 BindTexGenParameterEXT(int unit, int coord, int value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindTextureUnitParameterEXT", ExactSpelling = true)]
        internal extern static Int32 BindTextureUnitParameterEXT(int unit, int value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindParameterEXT", ExactSpelling = true)]
        internal extern static Int32 BindParameterEXT(int value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsVariantEnabledEXT", ExactSpelling = true)]
        internal extern static int IsVariantEnabledEXT(UInt32 id, int cap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVariantBooleanvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetVariantBooleanvEXT(UInt32 id, int value, [Out] int* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVariantIntegervEXT", ExactSpelling = true)]
        internal extern static unsafe void GetVariantIntegervEXT(UInt32 id, int value, [Out] Int32* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVariantFloatvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetVariantFloatvEXT(UInt32 id, int value, [Out] Single* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVariantPointervEXT", ExactSpelling = true)]
        internal extern static unsafe void GetVariantPointervEXT(UInt32 id, int value, [Out] void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetInvariantBooleanvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetInvariantBooleanvEXT(UInt32 id, int value, [Out] int* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetInvariantIntegervEXT", ExactSpelling = true)]
        internal extern static unsafe void GetInvariantIntegervEXT(UInt32 id, int value, [Out] Int32* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetInvariantFloatvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetInvariantFloatvEXT(UInt32 id, int value, [Out] Single* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetLocalConstantBooleanvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetLocalConstantBooleanvEXT(UInt32 id, int value, [Out] int* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetLocalConstantIntegervEXT", ExactSpelling = true)]
        internal extern static unsafe void GetLocalConstantIntegervEXT(UInt32 id, int value, [Out] Int32* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetLocalConstantFloatvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetLocalConstantFloatvEXT(UInt32 id, int value, [Out] Single* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream1sATI", ExactSpelling = true)]
        internal extern static void VertexStream1sATI(int stream, Int16 x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream1svATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream1svATI(int stream, Int16* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream1iATI", ExactSpelling = true)]
        internal extern static void VertexStream1iATI(int stream, Int32 x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream1ivATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream1ivATI(int stream, Int32* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream1fATI", ExactSpelling = true)]
        internal extern static void VertexStream1fATI(int stream, Single x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream1fvATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream1fvATI(int stream, Single* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream1dATI", ExactSpelling = true)]
        internal extern static void VertexStream1dATI(int stream, Double x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream1dvATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream1dvATI(int stream, Double* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream2sATI", ExactSpelling = true)]
        internal extern static void VertexStream2sATI(int stream, Int16 x, Int16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream2svATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream2svATI(int stream, Int16* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream2iATI", ExactSpelling = true)]
        internal extern static void VertexStream2iATI(int stream, Int32 x, Int32 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream2ivATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream2ivATI(int stream, Int32* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream2fATI", ExactSpelling = true)]
        internal extern static void VertexStream2fATI(int stream, Single x, Single y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream2fvATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream2fvATI(int stream, Single* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream2dATI", ExactSpelling = true)]
        internal extern static void VertexStream2dATI(int stream, Double x, Double y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream2dvATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream2dvATI(int stream, Double* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream3sATI", ExactSpelling = true)]
        internal extern static void VertexStream3sATI(int stream, Int16 x, Int16 y, Int16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream3svATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream3svATI(int stream, Int16* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream3iATI", ExactSpelling = true)]
        internal extern static void VertexStream3iATI(int stream, Int32 x, Int32 y, Int32 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream3ivATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream3ivATI(int stream, Int32* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream3fATI", ExactSpelling = true)]
        internal extern static void VertexStream3fATI(int stream, Single x, Single y, Single z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream3fvATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream3fvATI(int stream, Single* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream3dATI", ExactSpelling = true)]
        internal extern static void VertexStream3dATI(int stream, Double x, Double y, Double z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream3dvATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream3dvATI(int stream, Double* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream4sATI", ExactSpelling = true)]
        internal extern static void VertexStream4sATI(int stream, Int16 x, Int16 y, Int16 z, Int16 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream4svATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream4svATI(int stream, Int16* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream4iATI", ExactSpelling = true)]
        internal extern static void VertexStream4iATI(int stream, Int32 x, Int32 y, Int32 z, Int32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream4ivATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream4ivATI(int stream, Int32* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream4fATI", ExactSpelling = true)]
        internal extern static void VertexStream4fATI(int stream, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream4fvATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream4fvATI(int stream, Single* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream4dATI", ExactSpelling = true)]
        internal extern static void VertexStream4dATI(int stream, Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexStream4dvATI", ExactSpelling = true)]
        internal extern static unsafe void VertexStream4dvATI(int stream, Double* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3bATI", ExactSpelling = true)]
        internal extern static void NormalStream3bATI(int stream, SByte nx, SByte ny, SByte nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3bvATI", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3bvATI(int stream, SByte* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3sATI", ExactSpelling = true)]
        internal extern static void NormalStream3sATI(int stream, Int16 nx, Int16 ny, Int16 nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3svATI", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3svATI(int stream, Int16* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3iATI", ExactSpelling = true)]
        internal extern static void NormalStream3iATI(int stream, Int32 nx, Int32 ny, Int32 nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3ivATI", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3ivATI(int stream, Int32* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3fATI", ExactSpelling = true)]
        internal extern static void NormalStream3fATI(int stream, Single nx, Single ny, Single nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3fvATI", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3fvATI(int stream, Single* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3dATI", ExactSpelling = true)]
        internal extern static void NormalStream3dATI(int stream, Double nx, Double ny, Double nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalStream3dvATI", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3dvATI(int stream, Double* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClientActiveVertexStreamATI", ExactSpelling = true)]
        internal extern static void ClientActiveVertexStreamATI(int stream);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexBlendEnviATI", ExactSpelling = true)]
        internal extern static void VertexBlendEnviATI(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexBlendEnvfATI", ExactSpelling = true)]
        internal extern static void VertexBlendEnvfATI(int pname, Single param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glElementPointerATI", ExactSpelling = true)]
        internal extern static unsafe void ElementPointerATI(int type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElementArrayATI", ExactSpelling = true)]
        internal extern static void DrawElementArrayATI(int mode, Int32 count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawRangeElementArrayATI", ExactSpelling = true)]
        internal extern static void DrawRangeElementArrayATI(int mode, UInt32 start, UInt32 end, Int32 count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawMeshArraysSUN", ExactSpelling = true)]
        internal extern static void DrawMeshArraysSUN(int mode, Int32 first, Int32 count, Int32 width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenOcclusionQueriesNV", ExactSpelling = true)]
        internal extern static unsafe void GenOcclusionQueriesNV(Int32 n, [Out] UInt32* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteOcclusionQueriesNV", ExactSpelling = true)]
        internal extern static unsafe void DeleteOcclusionQueriesNV(Int32 n, UInt32* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsOcclusionQueryNV", ExactSpelling = true)]
        internal extern static int IsOcclusionQueryNV(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginOcclusionQueryNV", ExactSpelling = true)]
        internal extern static void BeginOcclusionQueryNV(UInt32 id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndOcclusionQueryNV", ExactSpelling = true)]
        internal extern static void EndOcclusionQueryNV();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetOcclusionQueryivNV", ExactSpelling = true)]
        internal extern static unsafe void GetOcclusionQueryivNV(UInt32 id, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetOcclusionQueryuivNV", ExactSpelling = true)]
        internal extern static unsafe void GetOcclusionQueryuivNV(UInt32 id, int pname, [Out] UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameteriNV", ExactSpelling = true)]
        internal extern static void PointParameteriNV(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterivNV", ExactSpelling = true)]
        internal extern static unsafe void PointParameterivNV(int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glActiveStencilFaceEXT", ExactSpelling = true)]
        internal extern static void ActiveStencilFaceEXT(int face);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glElementPointerAPPLE", ExactSpelling = true)]
        internal extern static unsafe void ElementPointerAPPLE(int type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElementArrayAPPLE", ExactSpelling = true)]
        internal extern static void DrawElementArrayAPPLE(int mode, Int32 first, Int32 count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawRangeElementArrayAPPLE", ExactSpelling = true)]
        internal extern static void DrawRangeElementArrayAPPLE(int mode, UInt32 start, UInt32 end, Int32 first, Int32 count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawElementArrayAPPLE", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawElementArrayAPPLE(int mode, Int32* first, Int32* count, Int32 primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawRangeElementArrayAPPLE", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawRangeElementArrayAPPLE(int mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenFencesAPPLE", ExactSpelling = true)]
        internal extern static unsafe void GenFencesAPPLE(Int32 n, [Out] UInt32* fences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteFencesAPPLE", ExactSpelling = true)]
        internal extern static unsafe void DeleteFencesAPPLE(Int32 n, UInt32* fences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSetFenceAPPLE", ExactSpelling = true)]
        internal extern static void SetFenceAPPLE(UInt32 fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsFenceAPPLE", ExactSpelling = true)]
        internal extern static int IsFenceAPPLE(UInt32 fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTestFenceAPPLE", ExactSpelling = true)]
        internal extern static int TestFenceAPPLE(UInt32 fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFinishFenceAPPLE", ExactSpelling = true)]
        internal extern static void FinishFenceAPPLE(UInt32 fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTestObjectAPPLE", ExactSpelling = true)]
        internal extern static int TestObjectAPPLE(int @object, UInt32 name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFinishObjectAPPLE", ExactSpelling = true)]
        internal extern static void FinishObjectAPPLE(int @object, Int32 name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindVertexArrayAPPLE", ExactSpelling = true)]
        internal extern static void BindVertexArrayAPPLE(UInt32 array);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteVertexArraysAPPLE", ExactSpelling = true)]
        internal extern static unsafe void DeleteVertexArraysAPPLE(Int32 n, UInt32* arrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenVertexArraysAPPLE", ExactSpelling = true)]
        internal extern static unsafe void GenVertexArraysAPPLE(Int32 n, [Out] UInt32* arrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsVertexArrayAPPLE", ExactSpelling = true)]
        internal extern static int IsVertexArrayAPPLE(UInt32 array);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayRangeAPPLE", ExactSpelling = true)]
        internal extern static unsafe void VertexArrayRangeAPPLE(Int32 length, [Out] void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlushVertexArrayRangeAPPLE", ExactSpelling = true)]
        internal extern static unsafe void FlushVertexArrayRangeAPPLE(Int32 length, [Out] void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayParameteriAPPLE", ExactSpelling = true)]
        internal extern static void VertexArrayParameteriAPPLE(int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawBuffersATI", ExactSpelling = true)]
        internal extern static unsafe void DrawBuffersATI(Int32 n, int* bufs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramNamedParameter4fNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramNamedParameter4fNV(UInt32 id, Int32 len, Byte* name, Single x, Single y, Single z, Single w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramNamedParameter4dNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramNamedParameter4dNV(UInt32 id, Int32 len, Byte* name, Double x, Double y, Double z, Double w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramNamedParameter4fvNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramNamedParameter4fvNV(UInt32 id, Int32 len, Byte* name, Single* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramNamedParameter4dvNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramNamedParameter4dvNV(UInt32 id, Int32 len, Byte* name, Double* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramNamedParameterfvNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramNamedParameterfvNV(UInt32 id, Int32 len, Byte* name, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramNamedParameterdvNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramNamedParameterdvNV(UInt32 id, Int32 len, Byte* name, [Out] Double* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2hNV", ExactSpelling = true)]
        internal extern static void Vertex2hNV(UInt16 x, UInt16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2hvNV", ExactSpelling = true)]
        internal extern static unsafe void Vertex2hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3hNV", ExactSpelling = true)]
        internal extern static void Vertex3hNV(UInt16 x, UInt16 y, UInt16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3hvNV", ExactSpelling = true)]
        internal extern static unsafe void Vertex3hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4hNV", ExactSpelling = true)]
        internal extern static void Vertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4hvNV", ExactSpelling = true)]
        internal extern static unsafe void Vertex4hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3hNV", ExactSpelling = true)]
        internal extern static void Normal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3hvNV", ExactSpelling = true)]
        internal extern static unsafe void Normal3hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3hNV", ExactSpelling = true)]
        internal extern static void Color3hNV(UInt16 red, UInt16 green, UInt16 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3hvNV", ExactSpelling = true)]
        internal extern static unsafe void Color3hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4hNV", ExactSpelling = true)]
        internal extern static void Color4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4hvNV", ExactSpelling = true)]
        internal extern static unsafe void Color4hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1hNV", ExactSpelling = true)]
        internal extern static void TexCoord1hNV(UInt16 s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1hvNV", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2hNV", ExactSpelling = true)]
        internal extern static void TexCoord2hNV(UInt16 s, UInt16 t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2hvNV", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3hNV", ExactSpelling = true)]
        internal extern static void TexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3hvNV", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4hNV", ExactSpelling = true)]
        internal extern static void TexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4hvNV", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1hNV", ExactSpelling = true)]
        internal extern static void MultiTexCoord1hNV(int target, UInt16 s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1hvNV", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1hvNV(int target, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2hNV", ExactSpelling = true)]
        internal extern static void MultiTexCoord2hNV(int target, UInt16 s, UInt16 t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2hvNV", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2hvNV(int target, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3hNV", ExactSpelling = true)]
        internal extern static void MultiTexCoord3hNV(int target, UInt16 s, UInt16 t, UInt16 r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3hvNV", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3hvNV(int target, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4hNV", ExactSpelling = true)]
        internal extern static void MultiTexCoord4hNV(int target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4hvNV", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4hvNV(int target, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordhNV", ExactSpelling = true)]
        internal extern static void FogCoordhNV(UInt16 fog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordhvNV", ExactSpelling = true)]
        internal extern static unsafe void FogCoordhvNV(UInt16* fog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3hNV", ExactSpelling = true)]
        internal extern static void SecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3hvNV", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3hvNV(UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexWeighthNV", ExactSpelling = true)]
        internal extern static void VertexWeighthNV(UInt16 weight);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexWeighthvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexWeighthvNV(UInt16* weight);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1hNV", ExactSpelling = true)]
        internal extern static void VertexAttrib1hNV(UInt32 index, UInt16 x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1hvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1hvNV(UInt32 index, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2hNV", ExactSpelling = true)]
        internal extern static void VertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2hvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2hvNV(UInt32 index, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3hNV", ExactSpelling = true)]
        internal extern static void VertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3hvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3hvNV(UInt32 index, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4hNV", ExactSpelling = true)]
        internal extern static void VertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4hvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4hvNV(UInt32 index, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs1hvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs2hvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs3hvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribs4hvNV", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelDataRangeNV", ExactSpelling = true)]
        internal extern static unsafe void PixelDataRangeNV(int target, Int32 length, [Out] void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlushPixelDataRangeNV", ExactSpelling = true)]
        internal extern static void FlushPixelDataRangeNV(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPrimitiveRestartNV", ExactSpelling = true)]
        internal extern static void PrimitiveRestartNV();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPrimitiveRestartIndexNV", ExactSpelling = true)]
        internal extern static void PrimitiveRestartIndexNV(UInt32 index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapObjectBufferATI", ExactSpelling = true)]
        internal extern static IntPtr MapObjectBufferATI(UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUnmapObjectBufferATI", ExactSpelling = true)]
        internal extern static void UnmapObjectBufferATI(UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilOpSeparateATI", ExactSpelling = true)]
        internal extern static void StencilOpSeparateATI(int face, int sfail, int dpfail, int dppass);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilFuncSeparateATI", ExactSpelling = true)]
        internal extern static void StencilFuncSeparateATI(int frontfunc, int backfunc, Int32 @ref, UInt32 mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribArrayObjectATI", ExactSpelling = true)]
        internal extern static void VertexAttribArrayObjectATI(UInt32 index, Int32 size, int type, int normalized, Int32 stride, UInt32 buffer, UInt32 offset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribArrayObjectfvATI", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribArrayObjectfvATI(UInt32 index, int pname, [Out] Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribArrayObjectivATI", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribArrayObjectivATI(UInt32 index, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthBoundsEXT", ExactSpelling = true)]
        internal extern static void DepthBoundsEXT(Double zmin, Double zmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquationSeparateEXT", ExactSpelling = true)]
        internal extern static void BlendEquationSeparateEXT(int modeRGB, int modeAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsRenderbufferEXT", ExactSpelling = true)]
        internal extern static int IsRenderbufferEXT(UInt32 renderbuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindRenderbufferEXT", ExactSpelling = true)]
        internal extern static void BindRenderbufferEXT(int target, UInt32 renderbuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteRenderbuffersEXT", ExactSpelling = true)]
        internal extern static unsafe void DeleteRenderbuffersEXT(Int32 n, UInt32* renderbuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenRenderbuffersEXT", ExactSpelling = true)]
        internal extern static unsafe void GenRenderbuffersEXT(Int32 n, [Out] UInt32* renderbuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRenderbufferStorageEXT", ExactSpelling = true)]
        internal extern static void RenderbufferStorageEXT(int target, int internalformat, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetRenderbufferParameterivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetRenderbufferParameterivEXT(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsFramebufferEXT", ExactSpelling = true)]
        internal extern static int IsFramebufferEXT(UInt32 framebuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindFramebufferEXT", ExactSpelling = true)]
        internal extern static void BindFramebufferEXT(int target, UInt32 framebuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteFramebuffersEXT", ExactSpelling = true)]
        internal extern static unsafe void DeleteFramebuffersEXT(Int32 n, UInt32* framebuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenFramebuffersEXT", ExactSpelling = true)]
        internal extern static unsafe void GenFramebuffersEXT(Int32 n, [Out] UInt32* framebuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCheckFramebufferStatusEXT", ExactSpelling = true)]
        internal extern static int CheckFramebufferStatusEXT(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTexture1DEXT", ExactSpelling = true)]
        internal extern static void FramebufferTexture1DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTexture2DEXT", ExactSpelling = true)]
        internal extern static void FramebufferTexture2DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTexture3DEXT", ExactSpelling = true)]
        internal extern static void FramebufferTexture3DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferRenderbufferEXT", ExactSpelling = true)]
        internal extern static void FramebufferRenderbufferEXT(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFramebufferAttachmentParameterivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetFramebufferAttachmentParameterivEXT(int target, int attachment, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenerateMipmapEXT", ExactSpelling = true)]
        internal extern static void GenerateMipmapEXT(int target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStringMarkerGREMEDY", ExactSpelling = true)]
        internal extern static unsafe void StringMarkerGREMEDY(Int32 len, void* @string);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilClearTagEXT", ExactSpelling = true)]
        internal extern static void StencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlitFramebufferEXT", ExactSpelling = true)]
        internal extern static void BlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, int mask, int filter);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
        internal extern static void RenderbufferStorageMultisampleEXT(int target, Int32 samples, int internalformat, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjecti64vEXT", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjecti64vEXT(UInt32 id, int pname, [Out] Int64* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectui64vEXT", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectui64vEXT(UInt32 id, int pname, [Out] UInt64* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParameters4fvEXT", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameters4fvEXT(int target, UInt32 index, Int32 count, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParameters4fvEXT", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameters4fvEXT(int target, UInt32 index, Int32 count, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferParameteriAPPLE", ExactSpelling = true)]
        internal extern static void BufferParameteriAPPLE(int target, int pname, Int32 param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlushMappedBufferRangeAPPLE", ExactSpelling = true)]
        internal extern static void FlushMappedBufferRangeAPPLE(int target, IntPtr offset, IntPtr size);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParameterI4iNV", ExactSpelling = true)]
        internal extern static void ProgramLocalParameterI4iNV(int target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParameterI4ivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameterI4ivNV(int target, UInt32 index, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParametersI4ivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParametersI4ivNV(int target, UInt32 index, Int32 count, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParameterI4uiNV", ExactSpelling = true)]
        internal extern static void ProgramLocalParameterI4uiNV(int target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParameterI4uivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameterI4uivNV(int target, UInt32 index, UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramLocalParametersI4uivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParametersI4uivNV(int target, UInt32 index, Int32 count, UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParameterI4iNV", ExactSpelling = true)]
        internal extern static void ProgramEnvParameterI4iNV(int target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParameterI4ivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameterI4ivNV(int target, UInt32 index, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParametersI4ivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParametersI4ivNV(int target, UInt32 index, Int32 count, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParameterI4uiNV", ExactSpelling = true)]
        internal extern static void ProgramEnvParameterI4uiNV(int target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParameterI4uivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameterI4uivNV(int target, UInt32 index, UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramEnvParametersI4uivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParametersI4uivNV(int target, UInt32 index, Int32 count, UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramLocalParameterIivNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramLocalParameterIivNV(int target, UInt32 index, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramLocalParameterIuivNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramLocalParameterIuivNV(int target, UInt32 index, [Out] UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramEnvParameterIivNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramEnvParameterIivNV(int target, UInt32 index, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramEnvParameterIuivNV", ExactSpelling = true)]
        internal extern static unsafe void GetProgramEnvParameterIuivNV(int target, UInt32 index, [Out] UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramVertexLimitNV", ExactSpelling = true)]
        internal extern static void ProgramVertexLimitNV(int target, Int32 limit);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTextureEXT", ExactSpelling = true)]
        internal extern static void FramebufferTextureEXT(int target, int attachment, UInt32 texture, Int32 level);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTextureLayerEXT", ExactSpelling = true)]
        internal extern static void FramebufferTextureLayerEXT(int target, int attachment, UInt32 texture, Int32 level, Int32 layer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTextureFaceEXT", ExactSpelling = true)]
        internal extern static void FramebufferTextureFaceEXT(int target, int attachment, UInt32 texture, Int32 level, int face);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramParameteriEXT", ExactSpelling = true)]
        internal extern static void ProgramParameteriEXT(UInt32 program, int pname, Int32 value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI1iEXT", ExactSpelling = true)]
        internal extern static void VertexAttribI1iEXT(UInt32 index, Int32 x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI2iEXT", ExactSpelling = true)]
        internal extern static void VertexAttribI2iEXT(UInt32 index, Int32 x, Int32 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI3iEXT", ExactSpelling = true)]
        internal extern static void VertexAttribI3iEXT(UInt32 index, Int32 x, Int32 y, Int32 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4iEXT", ExactSpelling = true)]
        internal extern static void VertexAttribI4iEXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI1uiEXT", ExactSpelling = true)]
        internal extern static void VertexAttribI1uiEXT(UInt32 index, UInt32 x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI2uiEXT", ExactSpelling = true)]
        internal extern static void VertexAttribI2uiEXT(UInt32 index, UInt32 x, UInt32 y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI3uiEXT", ExactSpelling = true)]
        internal extern static void VertexAttribI3uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4uiEXT", ExactSpelling = true)]
        internal extern static void VertexAttribI4uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI1ivEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI1ivEXT(UInt32 index, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI2ivEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI2ivEXT(UInt32 index, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI3ivEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI3ivEXT(UInt32 index, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4ivEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4ivEXT(UInt32 index, Int32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI1uivEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI1uivEXT(UInt32 index, UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI2uivEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI2uivEXT(UInt32 index, UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI3uivEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI3uivEXT(UInt32 index, UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4uivEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4uivEXT(UInt32 index, UInt32* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4bvEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4bvEXT(UInt32 index, SByte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4svEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4svEXT(UInt32 index, Int16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4ubvEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4ubvEXT(UInt32 index, Byte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4usvEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4usvEXT(UInt32 index, UInt16* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribIPointerEXT", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribIPointerEXT(UInt32 index, Int32 size, int type, Int32 stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribIivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribIivEXT(UInt32 index, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribIuivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribIuivEXT(UInt32 index, int pname, [Out] UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformuivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetUniformuivEXT(UInt32 program, Int32 location, [Out] UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindFragDataLocationEXT", ExactSpelling = true)]
        internal extern static void BindFragDataLocationEXT(UInt32 program, UInt32 color, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFragDataLocationEXT", ExactSpelling = true)]
        internal extern static Int32 GetFragDataLocationEXT(UInt32 program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1uiEXT", ExactSpelling = true)]
        internal extern static void Uniform1uiEXT(Int32 location, UInt32 v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2uiEXT", ExactSpelling = true)]
        internal extern static void Uniform2uiEXT(Int32 location, UInt32 v0, UInt32 v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3uiEXT", ExactSpelling = true)]
        internal extern static void Uniform3uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4uiEXT", ExactSpelling = true)]
        internal extern static void Uniform4uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1uivEXT", ExactSpelling = true)]
        internal extern static unsafe void Uniform1uivEXT(Int32 location, Int32 count, UInt32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2uivEXT", ExactSpelling = true)]
        internal extern static unsafe void Uniform2uivEXT(Int32 location, Int32 count, UInt32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3uivEXT", ExactSpelling = true)]
        internal extern static unsafe void Uniform3uivEXT(Int32 location, Int32 count, UInt32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4uivEXT", ExactSpelling = true)]
        internal extern static unsafe void Uniform4uivEXT(Int32 location, Int32 count, UInt32* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawArraysInstancedEXT", ExactSpelling = true)]
        internal extern static void DrawArraysInstancedEXT(int mode, Int32 start, Int32 count, Int32 primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElementsInstancedEXT", ExactSpelling = true)]
        internal extern static unsafe void DrawElementsInstancedEXT(int mode, Int32 count, int type, void* indices, Int32 primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexBufferEXT", ExactSpelling = true)]
        internal extern static void TexBufferEXT(int target, int internalformat, UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthRangedNV", ExactSpelling = true)]
        internal extern static void DepthRangedNV(Double zNear, Double zFar);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearDepthdNV", ExactSpelling = true)]
        internal extern static void ClearDepthdNV(Double depth);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthBoundsdNV", ExactSpelling = true)]
        internal extern static void DepthBoundsdNV(Double zmin, Double zmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", ExactSpelling = true)]
        internal extern static void RenderbufferStorageMultisampleCoverageNV(int target, Int32 coverageSamples, Int32 colorSamples, int internalformat, Int32 width, Int32 height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramBufferParametersfvNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramBufferParametersfvNV(int target, UInt32 buffer, UInt32 index, Int32 count, Single* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramBufferParametersIivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramBufferParametersIivNV(int target, UInt32 buffer, UInt32 index, Int32 count, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramBufferParametersIuivNV", ExactSpelling = true)]
        internal extern static unsafe void ProgramBufferParametersIuivNV(int target, UInt32 buffer, UInt32 index, Int32 count, UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorMaskIndexedEXT", ExactSpelling = true)]
        internal extern static void ColorMaskIndexedEXT(UInt32 index, int r, int g, int b, int a);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBooleanIndexedvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetBooleanIndexedvEXT(int target, UInt32 index, [Out] int* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetIntegerIndexedvEXT", ExactSpelling = true)]
        internal extern static unsafe void GetIntegerIndexedvEXT(int target, UInt32 index, [Out] Int32* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnableIndexedEXT", ExactSpelling = true)]
        internal extern static void EnableIndexedEXT(int target, UInt32 index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisableIndexedEXT", ExactSpelling = true)]
        internal extern static void DisableIndexedEXT(int target, UInt32 index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsEnabledIndexedEXT", ExactSpelling = true)]
        internal extern static int IsEnabledIndexedEXT(int target, UInt32 index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginTransformFeedbackNV", ExactSpelling = true)]
        internal extern static void BeginTransformFeedbackNV(int primitiveMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndTransformFeedbackNV", ExactSpelling = true)]
        internal extern static void EndTransformFeedbackNV();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTransformFeedbackAttribsNV", ExactSpelling = true)]
        internal extern static unsafe void TransformFeedbackAttribsNV(UInt32 count, Int32* attribs, int bufferMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBufferRangeNV", ExactSpelling = true)]
        internal extern static void BindBufferRangeNV(int target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBufferOffsetNV", ExactSpelling = true)]
        internal extern static void BindBufferOffsetNV(int target, UInt32 index, UInt32 buffer, IntPtr offset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBufferBaseNV", ExactSpelling = true)]
        internal extern static void BindBufferBaseNV(int target, UInt32 index, UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTransformFeedbackVaryingsNV", ExactSpelling = true)]
        internal extern static unsafe void TransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, int bufferMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glActiveVaryingNV", ExactSpelling = true)]
        internal extern static void ActiveVaryingNV(UInt32 program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVaryingLocationNV", ExactSpelling = true)]
        internal extern static Int32 GetVaryingLocationNV(UInt32 program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveVaryingNV", ExactSpelling = true)]
        internal extern static unsafe void GetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTransformFeedbackVaryingNV", ExactSpelling = true)]
        internal extern static unsafe void GetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, [Out] Int32* location);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformBufferEXT", ExactSpelling = true)]
        internal extern static void UniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformBufferSizeEXT", ExactSpelling = true)]
        internal extern static Int32 GetUniformBufferSizeEXT(UInt32 program, Int32 location);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformOffsetEXT", ExactSpelling = true)]
        internal extern static IntPtr GetUniformOffsetEXT(UInt32 program, Int32 location);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterIivEXT", ExactSpelling = true)]
        internal extern static unsafe void TexParameterIivEXT(int target, int pname, Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterIuivEXT", ExactSpelling = true)]
        internal extern static unsafe void TexParameterIuivEXT(int target, int pname, UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameterIivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetTexParameterIivEXT(int target, int pname, [Out] Int32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameterIuivEXT", ExactSpelling = true)]
        internal extern static unsafe void GetTexParameterIuivEXT(int target, int pname, [Out] UInt32* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearColorIiEXT", ExactSpelling = true)]
        internal extern static void ClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearColorIuiEXT", ExactSpelling = true)]
        internal extern static void ClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
    }
}
