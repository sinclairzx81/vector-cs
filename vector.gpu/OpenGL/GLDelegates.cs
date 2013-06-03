namespace Vector.Gpu.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    public static class Delegates
    {
        static Delegates()
        {
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NewList(UInt32 list, int mode);
        internal static NewList glNewList = (NewList)Gl.GetDelegateForExtensionMethod("glNewList", typeof(NewList)) ?? new NewList(Imports.NewList);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndList();
        internal static EndList glEndList = (EndList)Gl.GetDelegateForExtensionMethod("glEndList", typeof(EndList)) ?? new EndList(Imports.EndList);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CallList(UInt32 list);
        internal static CallList glCallList = (CallList)Gl.GetDelegateForExtensionMethod("glCallList", typeof(CallList)) ?? new CallList(Imports.CallList);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CallLists(Int32 n, int type, void* lists);
        internal unsafe static CallLists glCallLists = (CallLists)Gl.GetDelegateForExtensionMethod("glCallLists", typeof(CallLists)) ?? new CallLists(Imports.CallLists);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteLists(UInt32 list, Int32 range);
        internal static DeleteLists glDeleteLists = (DeleteLists)Gl.GetDelegateForExtensionMethod("glDeleteLists", typeof(DeleteLists)) ?? new DeleteLists(Imports.DeleteLists);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenLists(Int32 range);
        internal static GenLists glGenLists = (GenLists)Gl.GetDelegateForExtensionMethod("glGenLists", typeof(GenLists)) ?? new GenLists(Imports.GenLists);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ListBase(UInt32 @base);
        internal static ListBase glListBase = (ListBase)Gl.GetDelegateForExtensionMethod("glListBase", typeof(ListBase)) ?? new ListBase(Imports.ListBase);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Begin(int mode);
        internal static Begin glBegin = (Begin)Gl.GetDelegateForExtensionMethod("glBegin", typeof(Begin)) ?? new Begin(Imports.Begin);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Bitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, Byte* bitmap);
        internal unsafe static Bitmap glBitmap = (Bitmap)Gl.GetDelegateForExtensionMethod("glBitmap", typeof(Bitmap)) ?? new Bitmap(Imports.Bitmap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3b(SByte red, SByte green, SByte blue);
        internal static Color3b glColor3b = (Color3b)Gl.GetDelegateForExtensionMethod("glColor3b", typeof(Color3b)) ?? new Color3b(Imports.Color3b);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3bv(SByte* v);
        internal unsafe static Color3bv glColor3bv = (Color3bv)Gl.GetDelegateForExtensionMethod("glColor3bv", typeof(Color3bv)) ?? new Color3bv(Imports.Color3bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3d(Double red, Double green, Double blue);
        internal static Color3d glColor3d = (Color3d)Gl.GetDelegateForExtensionMethod("glColor3d", typeof(Color3d)) ?? new Color3d(Imports.Color3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3dv(Double* v);
        internal unsafe static Color3dv glColor3dv = (Color3dv)Gl.GetDelegateForExtensionMethod("glColor3dv", typeof(Color3dv)) ?? new Color3dv(Imports.Color3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3f(Single red, Single green, Single blue);
        internal static Color3f glColor3f = (Color3f)Gl.GetDelegateForExtensionMethod("glColor3f", typeof(Color3f)) ?? new Color3f(Imports.Color3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3fv(Single* v);
        internal unsafe static Color3fv glColor3fv = (Color3fv)Gl.GetDelegateForExtensionMethod("glColor3fv", typeof(Color3fv)) ?? new Color3fv(Imports.Color3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3i(Int32 red, Int32 green, Int32 blue);
        internal static Color3i glColor3i = (Color3i)Gl.GetDelegateForExtensionMethod("glColor3i", typeof(Color3i)) ?? new Color3i(Imports.Color3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3iv(Int32* v);
        internal unsafe static Color3iv glColor3iv = (Color3iv)Gl.GetDelegateForExtensionMethod("glColor3iv", typeof(Color3iv)) ?? new Color3iv(Imports.Color3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3s(Int16 red, Int16 green, Int16 blue);
        internal static Color3s glColor3s = (Color3s)Gl.GetDelegateForExtensionMethod("glColor3s", typeof(Color3s)) ?? new Color3s(Imports.Color3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3sv(Int16* v);
        internal unsafe static Color3sv glColor3sv = (Color3sv)Gl.GetDelegateForExtensionMethod("glColor3sv", typeof(Color3sv)) ?? new Color3sv(Imports.Color3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3ub(Byte red, Byte green, Byte blue);
        internal static Color3ub glColor3ub = (Color3ub)Gl.GetDelegateForExtensionMethod("glColor3ub", typeof(Color3ub)) ?? new Color3ub(Imports.Color3ub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3ubv(Byte* v);
        internal unsafe static Color3ubv glColor3ubv = (Color3ubv)Gl.GetDelegateForExtensionMethod("glColor3ubv", typeof(Color3ubv)) ?? new Color3ubv(Imports.Color3ubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3ui(UInt32 red, UInt32 green, UInt32 blue);
        internal static Color3ui glColor3ui = (Color3ui)Gl.GetDelegateForExtensionMethod("glColor3ui", typeof(Color3ui)) ?? new Color3ui(Imports.Color3ui);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3uiv(UInt32* v);
        internal unsafe static Color3uiv glColor3uiv = (Color3uiv)Gl.GetDelegateForExtensionMethod("glColor3uiv", typeof(Color3uiv)) ?? new Color3uiv(Imports.Color3uiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3us(UInt16 red, UInt16 green, UInt16 blue);
        internal static Color3us glColor3us = (Color3us)Gl.GetDelegateForExtensionMethod("glColor3us", typeof(Color3us)) ?? new Color3us(Imports.Color3us);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3usv(UInt16* v);
        internal unsafe static Color3usv glColor3usv = (Color3usv)Gl.GetDelegateForExtensionMethod("glColor3usv", typeof(Color3usv)) ?? new Color3usv(Imports.Color3usv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4b(SByte red, SByte green, SByte blue, SByte alpha);
        internal static Color4b glColor4b = (Color4b)Gl.GetDelegateForExtensionMethod("glColor4b", typeof(Color4b)) ?? new Color4b(Imports.Color4b);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4bv(SByte* v);
        internal unsafe static Color4bv glColor4bv = (Color4bv)Gl.GetDelegateForExtensionMethod("glColor4bv", typeof(Color4bv)) ?? new Color4bv(Imports.Color4bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4d(Double red, Double green, Double blue, Double alpha);
        internal static Color4d glColor4d = (Color4d)Gl.GetDelegateForExtensionMethod("glColor4d", typeof(Color4d)) ?? new Color4d(Imports.Color4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4dv(Double* v);
        internal unsafe static Color4dv glColor4dv = (Color4dv)Gl.GetDelegateForExtensionMethod("glColor4dv", typeof(Color4dv)) ?? new Color4dv(Imports.Color4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4f(Single red, Single green, Single blue, Single alpha);
        internal static Color4f glColor4f = (Color4f)Gl.GetDelegateForExtensionMethod("glColor4f", typeof(Color4f)) ?? new Color4f(Imports.Color4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4fv(Single* v);
        internal unsafe static Color4fv glColor4fv = (Color4fv)Gl.GetDelegateForExtensionMethod("glColor4fv", typeof(Color4fv)) ?? new Color4fv(Imports.Color4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
        internal static Color4i glColor4i = (Color4i)Gl.GetDelegateForExtensionMethod("glColor4i", typeof(Color4i)) ?? new Color4i(Imports.Color4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4iv(Int32* v);
        internal unsafe static Color4iv glColor4iv = (Color4iv)Gl.GetDelegateForExtensionMethod("glColor4iv", typeof(Color4iv)) ?? new Color4iv(Imports.Color4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
        internal static Color4s glColor4s = (Color4s)Gl.GetDelegateForExtensionMethod("glColor4s", typeof(Color4s)) ?? new Color4s(Imports.Color4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4sv(Int16* v);
        internal unsafe static Color4sv glColor4sv = (Color4sv)Gl.GetDelegateForExtensionMethod("glColor4sv", typeof(Color4sv)) ?? new Color4sv(Imports.Color4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
        internal static Color4ub glColor4ub = (Color4ub)Gl.GetDelegateForExtensionMethod("glColor4ub", typeof(Color4ub)) ?? new Color4ub(Imports.Color4ub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4ubv(Byte* v);
        internal unsafe static Color4ubv glColor4ubv = (Color4ubv)Gl.GetDelegateForExtensionMethod("glColor4ubv", typeof(Color4ubv)) ?? new Color4ubv(Imports.Color4ubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
        internal static Color4ui glColor4ui = (Color4ui)Gl.GetDelegateForExtensionMethod("glColor4ui", typeof(Color4ui)) ?? new Color4ui(Imports.Color4ui);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4uiv(UInt32* v);
        internal unsafe static Color4uiv glColor4uiv = (Color4uiv)Gl.GetDelegateForExtensionMethod("glColor4uiv", typeof(Color4uiv)) ?? new Color4uiv(Imports.Color4uiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
        internal static Color4us glColor4us = (Color4us)Gl.GetDelegateForExtensionMethod("glColor4us", typeof(Color4us)) ?? new Color4us(Imports.Color4us);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4usv(UInt16* v);
        internal unsafe static Color4usv glColor4usv = (Color4usv)Gl.GetDelegateForExtensionMethod("glColor4usv", typeof(Color4usv)) ?? new Color4usv(Imports.Color4usv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EdgeFlag(int flag);
        internal static EdgeFlag glEdgeFlag = (EdgeFlag)Gl.GetDelegateForExtensionMethod("glEdgeFlag", typeof(EdgeFlag)) ?? new EdgeFlag(Imports.EdgeFlag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagv(int* flag);
        internal unsafe static EdgeFlagv glEdgeFlagv = (EdgeFlagv)Gl.GetDelegateForExtensionMethod("glEdgeFlagv", typeof(EdgeFlagv)) ?? new EdgeFlagv(Imports.EdgeFlagv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void End();
        internal static End glEnd = (End)Gl.GetDelegateForExtensionMethod("glEnd", typeof(End)) ?? new End(Imports.End);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexd(Double c);
        internal static Indexd glIndexd = (Indexd)Gl.GetDelegateForExtensionMethod("glIndexd", typeof(Indexd)) ?? new Indexd(Imports.Indexd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexdv(Double* c);
        internal unsafe static Indexdv glIndexdv = (Indexdv)Gl.GetDelegateForExtensionMethod("glIndexdv", typeof(Indexdv)) ?? new Indexdv(Imports.Indexdv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexf(Single c);
        internal static Indexf glIndexf = (Indexf)Gl.GetDelegateForExtensionMethod("glIndexf", typeof(Indexf)) ?? new Indexf(Imports.Indexf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexfv(Single* c);
        internal unsafe static Indexfv glIndexfv = (Indexfv)Gl.GetDelegateForExtensionMethod("glIndexfv", typeof(Indexfv)) ?? new Indexfv(Imports.Indexfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexi(Int32 c);
        internal static Indexi glIndexi = (Indexi)Gl.GetDelegateForExtensionMethod("glIndexi", typeof(Indexi)) ?? new Indexi(Imports.Indexi);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexiv(Int32* c);
        internal unsafe static Indexiv glIndexiv = (Indexiv)Gl.GetDelegateForExtensionMethod("glIndexiv", typeof(Indexiv)) ?? new Indexiv(Imports.Indexiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexs(Int16 c);
        internal static Indexs glIndexs = (Indexs)Gl.GetDelegateForExtensionMethod("glIndexs", typeof(Indexs)) ?? new Indexs(Imports.Indexs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexsv(Int16* c);
        internal unsafe static Indexsv glIndexsv = (Indexsv)Gl.GetDelegateForExtensionMethod("glIndexsv", typeof(Indexsv)) ?? new Indexsv(Imports.Indexsv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3b(SByte nx, SByte ny, SByte nz);
        internal static Normal3b glNormal3b = (Normal3b)Gl.GetDelegateForExtensionMethod("glNormal3b", typeof(Normal3b)) ?? new Normal3b(Imports.Normal3b);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3bv(SByte* v);
        internal unsafe static Normal3bv glNormal3bv = (Normal3bv)Gl.GetDelegateForExtensionMethod("glNormal3bv", typeof(Normal3bv)) ?? new Normal3bv(Imports.Normal3bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3d(Double nx, Double ny, Double nz);
        internal static Normal3d glNormal3d = (Normal3d)Gl.GetDelegateForExtensionMethod("glNormal3d", typeof(Normal3d)) ?? new Normal3d(Imports.Normal3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3dv(Double* v);
        internal unsafe static Normal3dv glNormal3dv = (Normal3dv)Gl.GetDelegateForExtensionMethod("glNormal3dv", typeof(Normal3dv)) ?? new Normal3dv(Imports.Normal3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3f(Single nx, Single ny, Single nz);
        internal static Normal3f glNormal3f = (Normal3f)Gl.GetDelegateForExtensionMethod("glNormal3f", typeof(Normal3f)) ?? new Normal3f(Imports.Normal3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3fv(Single* v);
        internal unsafe static Normal3fv glNormal3fv = (Normal3fv)Gl.GetDelegateForExtensionMethod("glNormal3fv", typeof(Normal3fv)) ?? new Normal3fv(Imports.Normal3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3i(Int32 nx, Int32 ny, Int32 nz);
        internal static Normal3i glNormal3i = (Normal3i)Gl.GetDelegateForExtensionMethod("glNormal3i", typeof(Normal3i)) ?? new Normal3i(Imports.Normal3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3iv(Int32* v);
        internal unsafe static Normal3iv glNormal3iv = (Normal3iv)Gl.GetDelegateForExtensionMethod("glNormal3iv", typeof(Normal3iv)) ?? new Normal3iv(Imports.Normal3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3s(Int16 nx, Int16 ny, Int16 nz);
        internal static Normal3s glNormal3s = (Normal3s)Gl.GetDelegateForExtensionMethod("glNormal3s", typeof(Normal3s)) ?? new Normal3s(Imports.Normal3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3sv(Int16* v);
        internal unsafe static Normal3sv glNormal3sv = (Normal3sv)Gl.GetDelegateForExtensionMethod("glNormal3sv", typeof(Normal3sv)) ?? new Normal3sv(Imports.Normal3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2d(Double x, Double y);
        internal static RasterPos2d glRasterPos2d = (RasterPos2d)Gl.GetDelegateForExtensionMethod("glRasterPos2d", typeof(RasterPos2d)) ?? new RasterPos2d(Imports.RasterPos2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2dv(Double* v);
        internal unsafe static RasterPos2dv glRasterPos2dv = (RasterPos2dv)Gl.GetDelegateForExtensionMethod("glRasterPos2dv", typeof(RasterPos2dv)) ?? new RasterPos2dv(Imports.RasterPos2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2f(Single x, Single y);
        internal static RasterPos2f glRasterPos2f = (RasterPos2f)Gl.GetDelegateForExtensionMethod("glRasterPos2f", typeof(RasterPos2f)) ?? new RasterPos2f(Imports.RasterPos2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2fv(Single* v);
        internal unsafe static RasterPos2fv glRasterPos2fv = (RasterPos2fv)Gl.GetDelegateForExtensionMethod("glRasterPos2fv", typeof(RasterPos2fv)) ?? new RasterPos2fv(Imports.RasterPos2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2i(Int32 x, Int32 y);
        internal static RasterPos2i glRasterPos2i = (RasterPos2i)Gl.GetDelegateForExtensionMethod("glRasterPos2i", typeof(RasterPos2i)) ?? new RasterPos2i(Imports.RasterPos2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2iv(Int32* v);
        internal unsafe static RasterPos2iv glRasterPos2iv = (RasterPos2iv)Gl.GetDelegateForExtensionMethod("glRasterPos2iv", typeof(RasterPos2iv)) ?? new RasterPos2iv(Imports.RasterPos2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2s(Int16 x, Int16 y);
        internal static RasterPos2s glRasterPos2s = (RasterPos2s)Gl.GetDelegateForExtensionMethod("glRasterPos2s", typeof(RasterPos2s)) ?? new RasterPos2s(Imports.RasterPos2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2sv(Int16* v);
        internal unsafe static RasterPos2sv glRasterPos2sv = (RasterPos2sv)Gl.GetDelegateForExtensionMethod("glRasterPos2sv", typeof(RasterPos2sv)) ?? new RasterPos2sv(Imports.RasterPos2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3d(Double x, Double y, Double z);
        internal static RasterPos3d glRasterPos3d = (RasterPos3d)Gl.GetDelegateForExtensionMethod("glRasterPos3d", typeof(RasterPos3d)) ?? new RasterPos3d(Imports.RasterPos3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3dv(Double* v);
        internal unsafe static RasterPos3dv glRasterPos3dv = (RasterPos3dv)Gl.GetDelegateForExtensionMethod("glRasterPos3dv", typeof(RasterPos3dv)) ?? new RasterPos3dv(Imports.RasterPos3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3f(Single x, Single y, Single z);
        internal static RasterPos3f glRasterPos3f = (RasterPos3f)Gl.GetDelegateForExtensionMethod("glRasterPos3f", typeof(RasterPos3f)) ?? new RasterPos3f(Imports.RasterPos3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3fv(Single* v);
        internal unsafe static RasterPos3fv glRasterPos3fv = (RasterPos3fv)Gl.GetDelegateForExtensionMethod("glRasterPos3fv", typeof(RasterPos3fv)) ?? new RasterPos3fv(Imports.RasterPos3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3i(Int32 x, Int32 y, Int32 z);
        internal static RasterPos3i glRasterPos3i = (RasterPos3i)Gl.GetDelegateForExtensionMethod("glRasterPos3i", typeof(RasterPos3i)) ?? new RasterPos3i(Imports.RasterPos3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3iv(Int32* v);
        internal unsafe static RasterPos3iv glRasterPos3iv = (RasterPos3iv)Gl.GetDelegateForExtensionMethod("glRasterPos3iv", typeof(RasterPos3iv)) ?? new RasterPos3iv(Imports.RasterPos3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3s(Int16 x, Int16 y, Int16 z);
        internal static RasterPos3s glRasterPos3s = (RasterPos3s)Gl.GetDelegateForExtensionMethod("glRasterPos3s", typeof(RasterPos3s)) ?? new RasterPos3s(Imports.RasterPos3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3sv(Int16* v);
        internal unsafe static RasterPos3sv glRasterPos3sv = (RasterPos3sv)Gl.GetDelegateForExtensionMethod("glRasterPos3sv", typeof(RasterPos3sv)) ?? new RasterPos3sv(Imports.RasterPos3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4d(Double x, Double y, Double z, Double w);
        internal static RasterPos4d glRasterPos4d = (RasterPos4d)Gl.GetDelegateForExtensionMethod("glRasterPos4d", typeof(RasterPos4d)) ?? new RasterPos4d(Imports.RasterPos4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4dv(Double* v);
        internal unsafe static RasterPos4dv glRasterPos4dv = (RasterPos4dv)Gl.GetDelegateForExtensionMethod("glRasterPos4dv", typeof(RasterPos4dv)) ?? new RasterPos4dv(Imports.RasterPos4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4f(Single x, Single y, Single z, Single w);
        internal static RasterPos4f glRasterPos4f = (RasterPos4f)Gl.GetDelegateForExtensionMethod("glRasterPos4f", typeof(RasterPos4f)) ?? new RasterPos4f(Imports.RasterPos4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4fv(Single* v);
        internal unsafe static RasterPos4fv glRasterPos4fv = (RasterPos4fv)Gl.GetDelegateForExtensionMethod("glRasterPos4fv", typeof(RasterPos4fv)) ?? new RasterPos4fv(Imports.RasterPos4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
        internal static RasterPos4i glRasterPos4i = (RasterPos4i)Gl.GetDelegateForExtensionMethod("glRasterPos4i", typeof(RasterPos4i)) ?? new RasterPos4i(Imports.RasterPos4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4iv(Int32* v);
        internal unsafe static RasterPos4iv glRasterPos4iv = (RasterPos4iv)Gl.GetDelegateForExtensionMethod("glRasterPos4iv", typeof(RasterPos4iv)) ?? new RasterPos4iv(Imports.RasterPos4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
        internal static RasterPos4s glRasterPos4s = (RasterPos4s)Gl.GetDelegateForExtensionMethod("glRasterPos4s", typeof(RasterPos4s)) ?? new RasterPos4s(Imports.RasterPos4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4sv(Int16* v);
        internal unsafe static RasterPos4sv glRasterPos4sv = (RasterPos4sv)Gl.GetDelegateForExtensionMethod("glRasterPos4sv", typeof(RasterPos4sv)) ?? new RasterPos4sv(Imports.RasterPos4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rectd(Double x1, Double y1, Double x2, Double y2);
        internal static Rectd glRectd = (Rectd)Gl.GetDelegateForExtensionMethod("glRectd", typeof(Rectd)) ?? new Rectd(Imports.Rectd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectdv(Double* v1, Double* v2);
        internal unsafe static Rectdv glRectdv = (Rectdv)Gl.GetDelegateForExtensionMethod("glRectdv", typeof(Rectdv)) ?? new Rectdv(Imports.Rectdv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rectf(Single x1, Single y1, Single x2, Single y2);
        internal static Rectf glRectf = (Rectf)Gl.GetDelegateForExtensionMethod("glRectf", typeof(Rectf)) ?? new Rectf(Imports.Rectf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectfv(Single* v1, Single* v2);
        internal unsafe static Rectfv glRectfv = (Rectfv)Gl.GetDelegateForExtensionMethod("glRectfv", typeof(Rectfv)) ?? new Rectfv(Imports.Rectfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Recti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
        internal static Recti glRecti = (Recti)Gl.GetDelegateForExtensionMethod("glRecti", typeof(Recti)) ?? new Recti(Imports.Recti);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectiv(Int32* v1, Int32* v2);
        internal unsafe static Rectiv glRectiv = (Rectiv)Gl.GetDelegateForExtensionMethod("glRectiv", typeof(Rectiv)) ?? new Rectiv(Imports.Rectiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
        internal static Rects glRects = (Rects)Gl.GetDelegateForExtensionMethod("glRects", typeof(Rects)) ?? new Rects(Imports.Rects);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectsv(Int16* v1, Int16* v2);
        internal unsafe static Rectsv glRectsv = (Rectsv)Gl.GetDelegateForExtensionMethod("glRectsv", typeof(Rectsv)) ?? new Rectsv(Imports.Rectsv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1d(Double s);
        internal static TexCoord1d glTexCoord1d = (TexCoord1d)Gl.GetDelegateForExtensionMethod("glTexCoord1d", typeof(TexCoord1d)) ?? new TexCoord1d(Imports.TexCoord1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1dv(Double* v);
        internal unsafe static TexCoord1dv glTexCoord1dv = (TexCoord1dv)Gl.GetDelegateForExtensionMethod("glTexCoord1dv", typeof(TexCoord1dv)) ?? new TexCoord1dv(Imports.TexCoord1dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1f(Single s);
        internal static TexCoord1f glTexCoord1f = (TexCoord1f)Gl.GetDelegateForExtensionMethod("glTexCoord1f", typeof(TexCoord1f)) ?? new TexCoord1f(Imports.TexCoord1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1fv(Single* v);
        internal unsafe static TexCoord1fv glTexCoord1fv = (TexCoord1fv)Gl.GetDelegateForExtensionMethod("glTexCoord1fv", typeof(TexCoord1fv)) ?? new TexCoord1fv(Imports.TexCoord1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1i(Int32 s);
        internal static TexCoord1i glTexCoord1i = (TexCoord1i)Gl.GetDelegateForExtensionMethod("glTexCoord1i", typeof(TexCoord1i)) ?? new TexCoord1i(Imports.TexCoord1i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1iv(Int32* v);
        internal unsafe static TexCoord1iv glTexCoord1iv = (TexCoord1iv)Gl.GetDelegateForExtensionMethod("glTexCoord1iv", typeof(TexCoord1iv)) ?? new TexCoord1iv(Imports.TexCoord1iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1s(Int16 s);
        internal static TexCoord1s glTexCoord1s = (TexCoord1s)Gl.GetDelegateForExtensionMethod("glTexCoord1s", typeof(TexCoord1s)) ?? new TexCoord1s(Imports.TexCoord1s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1sv(Int16* v);
        internal unsafe static TexCoord1sv glTexCoord1sv = (TexCoord1sv)Gl.GetDelegateForExtensionMethod("glTexCoord1sv", typeof(TexCoord1sv)) ?? new TexCoord1sv(Imports.TexCoord1sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2d(Double s, Double t);
        internal static TexCoord2d glTexCoord2d = (TexCoord2d)Gl.GetDelegateForExtensionMethod("glTexCoord2d", typeof(TexCoord2d)) ?? new TexCoord2d(Imports.TexCoord2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2dv(Double* v);
        internal unsafe static TexCoord2dv glTexCoord2dv = (TexCoord2dv)Gl.GetDelegateForExtensionMethod("glTexCoord2dv", typeof(TexCoord2dv)) ?? new TexCoord2dv(Imports.TexCoord2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2f(Single s, Single t);
        internal static TexCoord2f glTexCoord2f = (TexCoord2f)Gl.GetDelegateForExtensionMethod("glTexCoord2f", typeof(TexCoord2f)) ?? new TexCoord2f(Imports.TexCoord2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fv(Single* v);
        internal unsafe static TexCoord2fv glTexCoord2fv = (TexCoord2fv)Gl.GetDelegateForExtensionMethod("glTexCoord2fv", typeof(TexCoord2fv)) ?? new TexCoord2fv(Imports.TexCoord2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2i(Int32 s, Int32 t);
        internal static TexCoord2i glTexCoord2i = (TexCoord2i)Gl.GetDelegateForExtensionMethod("glTexCoord2i", typeof(TexCoord2i)) ?? new TexCoord2i(Imports.TexCoord2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2iv(Int32* v);
        internal unsafe static TexCoord2iv glTexCoord2iv = (TexCoord2iv)Gl.GetDelegateForExtensionMethod("glTexCoord2iv", typeof(TexCoord2iv)) ?? new TexCoord2iv(Imports.TexCoord2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2s(Int16 s, Int16 t);
        internal static TexCoord2s glTexCoord2s = (TexCoord2s)Gl.GetDelegateForExtensionMethod("glTexCoord2s", typeof(TexCoord2s)) ?? new TexCoord2s(Imports.TexCoord2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2sv(Int16* v);
        internal unsafe static TexCoord2sv glTexCoord2sv = (TexCoord2sv)Gl.GetDelegateForExtensionMethod("glTexCoord2sv", typeof(TexCoord2sv)) ?? new TexCoord2sv(Imports.TexCoord2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3d(Double s, Double t, Double r);
        internal static TexCoord3d glTexCoord3d = (TexCoord3d)Gl.GetDelegateForExtensionMethod("glTexCoord3d", typeof(TexCoord3d)) ?? new TexCoord3d(Imports.TexCoord3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3dv(Double* v);
        internal unsafe static TexCoord3dv glTexCoord3dv = (TexCoord3dv)Gl.GetDelegateForExtensionMethod("glTexCoord3dv", typeof(TexCoord3dv)) ?? new TexCoord3dv(Imports.TexCoord3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3f(Single s, Single t, Single r);
        internal static TexCoord3f glTexCoord3f = (TexCoord3f)Gl.GetDelegateForExtensionMethod("glTexCoord3f", typeof(TexCoord3f)) ?? new TexCoord3f(Imports.TexCoord3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3fv(Single* v);
        internal unsafe static TexCoord3fv glTexCoord3fv = (TexCoord3fv)Gl.GetDelegateForExtensionMethod("glTexCoord3fv", typeof(TexCoord3fv)) ?? new TexCoord3fv(Imports.TexCoord3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3i(Int32 s, Int32 t, Int32 r);
        internal static TexCoord3i glTexCoord3i = (TexCoord3i)Gl.GetDelegateForExtensionMethod("glTexCoord3i", typeof(TexCoord3i)) ?? new TexCoord3i(Imports.TexCoord3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3iv(Int32* v);
        internal unsafe static TexCoord3iv glTexCoord3iv = (TexCoord3iv)Gl.GetDelegateForExtensionMethod("glTexCoord3iv", typeof(TexCoord3iv)) ?? new TexCoord3iv(Imports.TexCoord3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3s(Int16 s, Int16 t, Int16 r);
        internal static TexCoord3s glTexCoord3s = (TexCoord3s)Gl.GetDelegateForExtensionMethod("glTexCoord3s", typeof(TexCoord3s)) ?? new TexCoord3s(Imports.TexCoord3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3sv(Int16* v);
        internal unsafe static TexCoord3sv glTexCoord3sv = (TexCoord3sv)Gl.GetDelegateForExtensionMethod("glTexCoord3sv", typeof(TexCoord3sv)) ?? new TexCoord3sv(Imports.TexCoord3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4d(Double s, Double t, Double r, Double q);
        internal static TexCoord4d glTexCoord4d = (TexCoord4d)Gl.GetDelegateForExtensionMethod("glTexCoord4d", typeof(TexCoord4d)) ?? new TexCoord4d(Imports.TexCoord4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4dv(Double* v);
        internal unsafe static TexCoord4dv glTexCoord4dv = (TexCoord4dv)Gl.GetDelegateForExtensionMethod("glTexCoord4dv", typeof(TexCoord4dv)) ?? new TexCoord4dv(Imports.TexCoord4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4f(Single s, Single t, Single r, Single q);
        internal static TexCoord4f glTexCoord4f = (TexCoord4f)Gl.GetDelegateForExtensionMethod("glTexCoord4f", typeof(TexCoord4f)) ?? new TexCoord4f(Imports.TexCoord4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4fv(Single* v);
        internal unsafe static TexCoord4fv glTexCoord4fv = (TexCoord4fv)Gl.GetDelegateForExtensionMethod("glTexCoord4fv", typeof(TexCoord4fv)) ?? new TexCoord4fv(Imports.TexCoord4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
        internal static TexCoord4i glTexCoord4i = (TexCoord4i)Gl.GetDelegateForExtensionMethod("glTexCoord4i", typeof(TexCoord4i)) ?? new TexCoord4i(Imports.TexCoord4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4iv(Int32* v);
        internal unsafe static TexCoord4iv glTexCoord4iv = (TexCoord4iv)Gl.GetDelegateForExtensionMethod("glTexCoord4iv", typeof(TexCoord4iv)) ?? new TexCoord4iv(Imports.TexCoord4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
        internal static TexCoord4s glTexCoord4s = (TexCoord4s)Gl.GetDelegateForExtensionMethod("glTexCoord4s", typeof(TexCoord4s)) ?? new TexCoord4s(Imports.TexCoord4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4sv(Int16* v);
        internal unsafe static TexCoord4sv glTexCoord4sv = (TexCoord4sv)Gl.GetDelegateForExtensionMethod("glTexCoord4sv", typeof(TexCoord4sv)) ?? new TexCoord4sv(Imports.TexCoord4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2d(Double x, Double y);
        internal static Vertex2d glVertex2d = (Vertex2d)Gl.GetDelegateForExtensionMethod("glVertex2d", typeof(Vertex2d)) ?? new Vertex2d(Imports.Vertex2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2dv(Double* v);
        internal unsafe static Vertex2dv glVertex2dv = (Vertex2dv)Gl.GetDelegateForExtensionMethod("glVertex2dv", typeof(Vertex2dv)) ?? new Vertex2dv(Imports.Vertex2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2f(Single x, Single y);
        internal static Vertex2f glVertex2f = (Vertex2f)Gl.GetDelegateForExtensionMethod("glVertex2f", typeof(Vertex2f)) ?? new Vertex2f(Imports.Vertex2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2fv(Single* v);
        internal unsafe static Vertex2fv glVertex2fv = (Vertex2fv)Gl.GetDelegateForExtensionMethod("glVertex2fv", typeof(Vertex2fv)) ?? new Vertex2fv(Imports.Vertex2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2i(Int32 x, Int32 y);
        internal static Vertex2i glVertex2i = (Vertex2i)Gl.GetDelegateForExtensionMethod("glVertex2i", typeof(Vertex2i)) ?? new Vertex2i(Imports.Vertex2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2iv(Int32* v);
        internal unsafe static Vertex2iv glVertex2iv = (Vertex2iv)Gl.GetDelegateForExtensionMethod("glVertex2iv", typeof(Vertex2iv)) ?? new Vertex2iv(Imports.Vertex2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2s(Int16 x, Int16 y);
        internal static Vertex2s glVertex2s = (Vertex2s)Gl.GetDelegateForExtensionMethod("glVertex2s", typeof(Vertex2s)) ?? new Vertex2s(Imports.Vertex2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2sv(Int16* v);
        internal unsafe static Vertex2sv glVertex2sv = (Vertex2sv)Gl.GetDelegateForExtensionMethod("glVertex2sv", typeof(Vertex2sv)) ?? new Vertex2sv(Imports.Vertex2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3d(Double x, Double y, Double z);
        internal static Vertex3d glVertex3d = (Vertex3d)Gl.GetDelegateForExtensionMethod("glVertex3d", typeof(Vertex3d)) ?? new Vertex3d(Imports.Vertex3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3dv(Double* v);
        internal unsafe static Vertex3dv glVertex3dv = (Vertex3dv)Gl.GetDelegateForExtensionMethod("glVertex3dv", typeof(Vertex3dv)) ?? new Vertex3dv(Imports.Vertex3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3f(Single x, Single y, Single z);
        internal static Vertex3f glVertex3f = (Vertex3f)Gl.GetDelegateForExtensionMethod("glVertex3f", typeof(Vertex3f)) ?? new Vertex3f(Imports.Vertex3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3fv(Single* v);
        internal unsafe static Vertex3fv glVertex3fv = (Vertex3fv)Gl.GetDelegateForExtensionMethod("glVertex3fv", typeof(Vertex3fv)) ?? new Vertex3fv(Imports.Vertex3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3i(Int32 x, Int32 y, Int32 z);
        internal static Vertex3i glVertex3i = (Vertex3i)Gl.GetDelegateForExtensionMethod("glVertex3i", typeof(Vertex3i)) ?? new Vertex3i(Imports.Vertex3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3iv(Int32* v);
        internal unsafe static Vertex3iv glVertex3iv = (Vertex3iv)Gl.GetDelegateForExtensionMethod("glVertex3iv", typeof(Vertex3iv)) ?? new Vertex3iv(Imports.Vertex3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3s(Int16 x, Int16 y, Int16 z);
        internal static Vertex3s glVertex3s = (Vertex3s)Gl.GetDelegateForExtensionMethod("glVertex3s", typeof(Vertex3s)) ?? new Vertex3s(Imports.Vertex3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3sv(Int16* v);
        internal unsafe static Vertex3sv glVertex3sv = (Vertex3sv)Gl.GetDelegateForExtensionMethod("glVertex3sv", typeof(Vertex3sv)) ?? new Vertex3sv(Imports.Vertex3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4d(Double x, Double y, Double z, Double w);
        internal static Vertex4d glVertex4d = (Vertex4d)Gl.GetDelegateForExtensionMethod("glVertex4d", typeof(Vertex4d)) ?? new Vertex4d(Imports.Vertex4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4dv(Double* v);
        internal unsafe static Vertex4dv glVertex4dv = (Vertex4dv)Gl.GetDelegateForExtensionMethod("glVertex4dv", typeof(Vertex4dv)) ?? new Vertex4dv(Imports.Vertex4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4f(Single x, Single y, Single z, Single w);
        internal static Vertex4f glVertex4f = (Vertex4f)Gl.GetDelegateForExtensionMethod("glVertex4f", typeof(Vertex4f)) ?? new Vertex4f(Imports.Vertex4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4fv(Single* v);
        internal unsafe static Vertex4fv glVertex4fv = (Vertex4fv)Gl.GetDelegateForExtensionMethod("glVertex4fv", typeof(Vertex4fv)) ?? new Vertex4fv(Imports.Vertex4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
        internal static Vertex4i glVertex4i = (Vertex4i)Gl.GetDelegateForExtensionMethod("glVertex4i", typeof(Vertex4i)) ?? new Vertex4i(Imports.Vertex4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4iv(Int32* v);
        internal unsafe static Vertex4iv glVertex4iv = (Vertex4iv)Gl.GetDelegateForExtensionMethod("glVertex4iv", typeof(Vertex4iv)) ?? new Vertex4iv(Imports.Vertex4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
        internal static Vertex4s glVertex4s = (Vertex4s)Gl.GetDelegateForExtensionMethod("glVertex4s", typeof(Vertex4s)) ?? new Vertex4s(Imports.Vertex4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4sv(Int16* v);
        internal unsafe static Vertex4sv glVertex4sv = (Vertex4sv)Gl.GetDelegateForExtensionMethod("glVertex4sv", typeof(Vertex4sv)) ?? new Vertex4sv(Imports.Vertex4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ClipPlane(int plane, Double* equation);
        internal unsafe static ClipPlane glClipPlane = (ClipPlane)Gl.GetDelegateForExtensionMethod("glClipPlane", typeof(ClipPlane)) ?? new ClipPlane(Imports.ClipPlane);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMaterial(int face, int mode);
        internal static ColorMaterial glColorMaterial = (ColorMaterial)Gl.GetDelegateForExtensionMethod("glColorMaterial", typeof(ColorMaterial)) ?? new ColorMaterial(Imports.ColorMaterial);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CullFace(int mode);
        internal static CullFace glCullFace = (CullFace)Gl.GetDelegateForExtensionMethod("glCullFace", typeof(CullFace)) ?? new CullFace(Imports.CullFace);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Fogf(int pname, Single param);
        internal static Fogf glFogf = (Fogf)Gl.GetDelegateForExtensionMethod("glFogf", typeof(Fogf)) ?? new Fogf(Imports.Fogf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Fogfv(int pname, Single* @params);
        internal unsafe static Fogfv glFogfv = (Fogfv)Gl.GetDelegateForExtensionMethod("glFogfv", typeof(Fogfv)) ?? new Fogfv(Imports.Fogfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Fogi(int pname, Int32 param);
        internal static Fogi glFogi = (Fogi)Gl.GetDelegateForExtensionMethod("glFogi", typeof(Fogi)) ?? new Fogi(Imports.Fogi);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Fogiv(int pname, Int32* @params);
        internal unsafe static Fogiv glFogiv = (Fogiv)Gl.GetDelegateForExtensionMethod("glFogiv", typeof(Fogiv)) ?? new Fogiv(Imports.Fogiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FrontFace(int mode);
        internal static FrontFace glFrontFace = (FrontFace)Gl.GetDelegateForExtensionMethod("glFrontFace", typeof(FrontFace)) ?? new FrontFace(Imports.FrontFace);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Hint(int target, int mode);
        internal static Hint glHint = (Hint)Gl.GetDelegateForExtensionMethod("glHint", typeof(Hint)) ?? new Hint(Imports.Hint);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Lightf(int light, int pname, Single param);
        internal static Lightf glLightf = (Lightf)Gl.GetDelegateForExtensionMethod("glLightf", typeof(Lightf)) ?? new Lightf(Imports.Lightf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Lightfv(int light, int pname, Single* @params);
        internal unsafe static Lightfv glLightfv = (Lightfv)Gl.GetDelegateForExtensionMethod("glLightfv", typeof(Lightfv)) ?? new Lightfv(Imports.Lightfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Lighti(int light, int pname, Int32 param);
        internal static Lighti glLighti = (Lighti)Gl.GetDelegateForExtensionMethod("glLighti", typeof(Lighti)) ?? new Lighti(Imports.Lighti);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Lightiv(int light, int pname, Int32* @params);
        internal unsafe static Lightiv glLightiv = (Lightiv)Gl.GetDelegateForExtensionMethod("glLightiv", typeof(Lightiv)) ?? new Lightiv(Imports.Lightiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LightModelf(int pname, Single param);
        internal static LightModelf glLightModelf = (LightModelf)Gl.GetDelegateForExtensionMethod("glLightModelf", typeof(LightModelf)) ?? new LightModelf(Imports.LightModelf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LightModelfv(int pname, Single* @params);
        internal unsafe static LightModelfv glLightModelfv = (LightModelfv)Gl.GetDelegateForExtensionMethod("glLightModelfv", typeof(LightModelfv)) ?? new LightModelfv(Imports.LightModelfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LightModeli(int pname, Int32 param);
        internal static LightModeli glLightModeli = (LightModeli)Gl.GetDelegateForExtensionMethod("glLightModeli", typeof(LightModeli)) ?? new LightModeli(Imports.LightModeli);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LightModeliv(int pname, Int32* @params);
        internal unsafe static LightModeliv glLightModeliv = (LightModeliv)Gl.GetDelegateForExtensionMethod("glLightModeliv", typeof(LightModeliv)) ?? new LightModeliv(Imports.LightModeliv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LineStipple(Int32 factor, UInt16 pattern);
        internal static LineStipple glLineStipple = (LineStipple)Gl.GetDelegateForExtensionMethod("glLineStipple", typeof(LineStipple)) ?? new LineStipple(Imports.LineStipple);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LineWidth(Single width);
        internal static LineWidth glLineWidth = (LineWidth)Gl.GetDelegateForExtensionMethod("glLineWidth", typeof(LineWidth)) ?? new LineWidth(Imports.LineWidth);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Materialf(int face, int pname, Single param);
        internal static Materialf glMaterialf = (Materialf)Gl.GetDelegateForExtensionMethod("glMaterialf", typeof(Materialf)) ?? new Materialf(Imports.Materialf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Materialfv(int face, int pname, Single* @params);
        internal unsafe static Materialfv glMaterialfv = (Materialfv)Gl.GetDelegateForExtensionMethod("glMaterialfv", typeof(Materialfv)) ?? new Materialfv(Imports.Materialfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Materiali(int face, int pname, Int32 param);
        internal static Materiali glMateriali = (Materiali)Gl.GetDelegateForExtensionMethod("glMateriali", typeof(Materiali)) ?? new Materiali(Imports.Materiali);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Materialiv(int face, int pname, Int32* @params);
        internal unsafe static Materialiv glMaterialiv = (Materialiv)Gl.GetDelegateForExtensionMethod("glMaterialiv", typeof(Materialiv)) ?? new Materialiv(Imports.Materialiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointSize(Single size);
        internal static PointSize glPointSize = (PointSize)Gl.GetDelegateForExtensionMethod("glPointSize", typeof(PointSize)) ?? new PointSize(Imports.PointSize);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonMode(int face, int mode);
        internal static PolygonMode glPolygonMode = (PolygonMode)Gl.GetDelegateForExtensionMethod("glPolygonMode", typeof(PolygonMode)) ?? new PolygonMode(Imports.PolygonMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PolygonStipple(Byte* mask);
        internal unsafe static PolygonStipple glPolygonStipple = (PolygonStipple)Gl.GetDelegateForExtensionMethod("glPolygonStipple", typeof(PolygonStipple)) ?? new PolygonStipple(Imports.PolygonStipple);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
        internal static Scissor glScissor = (Scissor)Gl.GetDelegateForExtensionMethod("glScissor", typeof(Scissor)) ?? new Scissor(Imports.Scissor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShadeModel(int mode);
        internal static ShadeModel glShadeModel = (ShadeModel)Gl.GetDelegateForExtensionMethod("glShadeModel", typeof(ShadeModel)) ?? new ShadeModel(Imports.ShadeModel);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexParameterf(int target, int pname, Single param);
        internal static TexParameterf glTexParameterf = (TexParameterf)Gl.GetDelegateForExtensionMethod("glTexParameterf", typeof(TexParameterf)) ?? new TexParameterf(Imports.TexParameterf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterfv(int target, int pname, Single* @params);
        internal unsafe static TexParameterfv glTexParameterfv = (TexParameterfv)Gl.GetDelegateForExtensionMethod("glTexParameterfv", typeof(TexParameterfv)) ?? new TexParameterfv(Imports.TexParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexParameteri(int target, int pname, Int32 param);
        internal static TexParameteri glTexParameteri = (TexParameteri)Gl.GetDelegateForExtensionMethod("glTexParameteri", typeof(TexParameteri)) ?? new TexParameteri(Imports.TexParameteri);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameteriv(int target, int pname, Int32* @params);
        internal unsafe static TexParameteriv glTexParameteriv = (TexParameteriv)Gl.GetDelegateForExtensionMethod("glTexParameteriv", typeof(TexParameteriv)) ?? new TexParameteriv(Imports.TexParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage1D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 border, int format, int type, void* pixels);
        internal unsafe static TexImage1D glTexImage1D = (TexImage1D)Gl.GetDelegateForExtensionMethod("glTexImage1D", typeof(TexImage1D)) ?? new TexImage1D(Imports.TexImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage2D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, int format, int type, void* pixels);
        internal unsafe static TexImage2D glTexImage2D = (TexImage2D)Gl.GetDelegateForExtensionMethod("glTexImage2D", typeof(TexImage2D)) ?? new TexImage2D(Imports.TexImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexEnvf(int target, int pname, Single param);
        internal static TexEnvf glTexEnvf = (TexEnvf)Gl.GetDelegateForExtensionMethod("glTexEnvf", typeof(TexEnvf)) ?? new TexEnvf(Imports.TexEnvf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexEnvfv(int target, int pname, Single* @params);
        internal unsafe static TexEnvfv glTexEnvfv = (TexEnvfv)Gl.GetDelegateForExtensionMethod("glTexEnvfv", typeof(TexEnvfv)) ?? new TexEnvfv(Imports.TexEnvfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexEnvi(int target, int pname, Int32 param);
        internal static TexEnvi glTexEnvi = (TexEnvi)Gl.GetDelegateForExtensionMethod("glTexEnvi", typeof(TexEnvi)) ?? new TexEnvi(Imports.TexEnvi);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexEnviv(int target, int pname, Int32* @params);
        internal unsafe static TexEnviv glTexEnviv = (TexEnviv)Gl.GetDelegateForExtensionMethod("glTexEnviv", typeof(TexEnviv)) ?? new TexEnviv(Imports.TexEnviv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexGend(int coord, int pname, Double param);
        internal static TexGend glTexGend = (TexGend)Gl.GetDelegateForExtensionMethod("glTexGend", typeof(TexGend)) ?? new TexGend(Imports.TexGend);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexGendv(int coord, int pname, Double* @params);
        internal unsafe static TexGendv glTexGendv = (TexGendv)Gl.GetDelegateForExtensionMethod("glTexGendv", typeof(TexGendv)) ?? new TexGendv(Imports.TexGendv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexGenf(int coord, int pname, Single param);
        internal static TexGenf glTexGenf = (TexGenf)Gl.GetDelegateForExtensionMethod("glTexGenf", typeof(TexGenf)) ?? new TexGenf(Imports.TexGenf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexGenfv(int coord, int pname, Single* @params);
        internal unsafe static TexGenfv glTexGenfv = (TexGenfv)Gl.GetDelegateForExtensionMethod("glTexGenfv", typeof(TexGenfv)) ?? new TexGenfv(Imports.TexGenfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexGeni(int coord, int pname, Int32 param);
        internal static TexGeni glTexGeni = (TexGeni)Gl.GetDelegateForExtensionMethod("glTexGeni", typeof(TexGeni)) ?? new TexGeni(Imports.TexGeni);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexGeniv(int coord, int pname, Int32* @params);
        internal unsafe static TexGeniv glTexGeniv = (TexGeniv)Gl.GetDelegateForExtensionMethod("glTexGeniv", typeof(TexGeniv)) ?? new TexGeniv(Imports.TexGeniv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FeedbackBuffer(Int32 size, int type, [Out] Single* buffer);
        internal unsafe static FeedbackBuffer glFeedbackBuffer = (FeedbackBuffer)Gl.GetDelegateForExtensionMethod("glFeedbackBuffer", typeof(FeedbackBuffer)) ?? new FeedbackBuffer(Imports.FeedbackBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SelectBuffer(Int32 size, [Out] UInt32* buffer);
        internal unsafe static SelectBuffer glSelectBuffer = (SelectBuffer)Gl.GetDelegateForExtensionMethod("glSelectBuffer", typeof(SelectBuffer)) ?? new SelectBuffer(Imports.SelectBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 RenderMode(int mode);
        internal static RenderMode glRenderMode = (RenderMode)Gl.GetDelegateForExtensionMethod("glRenderMode", typeof(RenderMode)) ?? new RenderMode(Imports.RenderMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InitNames();
        internal static InitNames glInitNames = (InitNames)Gl.GetDelegateForExtensionMethod("glInitNames", typeof(InitNames)) ?? new InitNames(Imports.InitNames);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LoadName(UInt32 name);
        internal static LoadName glLoadName = (LoadName)Gl.GetDelegateForExtensionMethod("glLoadName", typeof(LoadName)) ?? new LoadName(Imports.LoadName);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PassThrough(Single token);
        internal static PassThrough glPassThrough = (PassThrough)Gl.GetDelegateForExtensionMethod("glPassThrough", typeof(PassThrough)) ?? new PassThrough(Imports.PassThrough);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopName();
        internal static PopName glPopName = (PopName)Gl.GetDelegateForExtensionMethod("glPopName", typeof(PopName)) ?? new PopName(Imports.PopName);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushName(UInt32 name);
        internal static PushName glPushName = (PushName)Gl.GetDelegateForExtensionMethod("glPushName", typeof(PushName)) ?? new PushName(Imports.PushName);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawBuffer(int mode);
        internal static DrawBuffer glDrawBuffer = (DrawBuffer)Gl.GetDelegateForExtensionMethod("glDrawBuffer", typeof(DrawBuffer)) ?? new DrawBuffer(Imports.DrawBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Clear(int mask);
        internal static Clear glClear = (Clear)Gl.GetDelegateForExtensionMethod("glClear", typeof(Clear)) ?? new Clear(Imports.Clear);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearAccum(Single red, Single green, Single blue, Single alpha);
        internal static ClearAccum glClearAccum = (ClearAccum)Gl.GetDelegateForExtensionMethod("glClearAccum", typeof(ClearAccum)) ?? new ClearAccum(Imports.ClearAccum);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearIndex(Single c);
        internal static ClearIndex glClearIndex = (ClearIndex)Gl.GetDelegateForExtensionMethod("glClearIndex", typeof(ClearIndex)) ?? new ClearIndex(Imports.ClearIndex);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
        internal static ClearColor glClearColor = (ClearColor)Gl.GetDelegateForExtensionMethod("glClearColor", typeof(ClearColor)) ?? new ClearColor(Imports.ClearColor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearStencil(Int32 s);
        internal static ClearStencil glClearStencil = (ClearStencil)Gl.GetDelegateForExtensionMethod("glClearStencil", typeof(ClearStencil)) ?? new ClearStencil(Imports.ClearStencil);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearDepth(Double depth);
        internal static ClearDepth glClearDepth = (ClearDepth)Gl.GetDelegateForExtensionMethod("glClearDepth", typeof(ClearDepth)) ?? new ClearDepth(Imports.ClearDepth);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilMask(UInt32 mask);
        internal static StencilMask glStencilMask = (StencilMask)Gl.GetDelegateForExtensionMethod("glStencilMask", typeof(StencilMask)) ?? new StencilMask(Imports.StencilMask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMask(int red, int green, int blue, int alpha);
        internal static ColorMask glColorMask = (ColorMask)Gl.GetDelegateForExtensionMethod("glColorMask", typeof(ColorMask)) ?? new ColorMask(Imports.ColorMask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthMask(int flag);
        internal static DepthMask glDepthMask = (DepthMask)Gl.GetDelegateForExtensionMethod("glDepthMask", typeof(DepthMask)) ?? new DepthMask(Imports.DepthMask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void IndexMask(UInt32 mask);
        internal static IndexMask glIndexMask = (IndexMask)Gl.GetDelegateForExtensionMethod("glIndexMask", typeof(IndexMask)) ?? new IndexMask(Imports.IndexMask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Accum(int op, Single value);
        internal static Accum glAccum = (Accum)Gl.GetDelegateForExtensionMethod("glAccum", typeof(Accum)) ?? new Accum(Imports.Accum);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Disable(int cap);
        internal static Disable glDisable = (Disable)Gl.GetDelegateForExtensionMethod("glDisable", typeof(Disable)) ?? new Disable(Imports.Disable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Enable(int cap);
        internal static Enable glEnable = (Enable)Gl.GetDelegateForExtensionMethod("glEnable", typeof(Enable)) ?? new Enable(Imports.Enable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Finish();
        internal static Finish glFinish = (Finish)Gl.GetDelegateForExtensionMethod("glFinish", typeof(Finish)) ?? new Finish(Imports.Finish);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Flush();
        internal static Flush glFlush = (Flush)Gl.GetDelegateForExtensionMethod("glFlush", typeof(Flush)) ?? new Flush(Imports.Flush);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopAttrib();
        internal static PopAttrib glPopAttrib = (PopAttrib)Gl.GetDelegateForExtensionMethod("glPopAttrib", typeof(PopAttrib)) ?? new PopAttrib(Imports.PopAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushAttrib(int mask);
        internal static PushAttrib glPushAttrib = (PushAttrib)Gl.GetDelegateForExtensionMethod("glPushAttrib", typeof(PushAttrib)) ?? new PushAttrib(Imports.PushAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map1d(int target, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
        internal unsafe static Map1d glMap1d = (Map1d)Gl.GetDelegateForExtensionMethod("glMap1d", typeof(Map1d)) ?? new Map1d(Imports.Map1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map1f(int target, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
        internal unsafe static Map1f glMap1f = (Map1f)Gl.GetDelegateForExtensionMethod("glMap1f", typeof(Map1f)) ?? new Map1f(Imports.Map1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map2d(int target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
        internal unsafe static Map2d glMap2d = (Map2d)Gl.GetDelegateForExtensionMethod("glMap2d", typeof(Map2d)) ?? new Map2d(Imports.Map2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map2f(int target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
        internal unsafe static Map2f glMap2f = (Map2f)Gl.GetDelegateForExtensionMethod("glMap2f", typeof(Map2f)) ?? new Map2f(Imports.Map2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid1d(Int32 un, Double u1, Double u2);
        internal static MapGrid1d glMapGrid1d = (MapGrid1d)Gl.GetDelegateForExtensionMethod("glMapGrid1d", typeof(MapGrid1d)) ?? new MapGrid1d(Imports.MapGrid1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid1f(Int32 un, Single u1, Single u2);
        internal static MapGrid1f glMapGrid1f = (MapGrid1f)Gl.GetDelegateForExtensionMethod("glMapGrid1f", typeof(MapGrid1f)) ?? new MapGrid1f(Imports.MapGrid1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);
        internal static MapGrid2d glMapGrid2d = (MapGrid2d)Gl.GetDelegateForExtensionMethod("glMapGrid2d", typeof(MapGrid2d)) ?? new MapGrid2d(Imports.MapGrid2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);
        internal static MapGrid2f glMapGrid2f = (MapGrid2f)Gl.GetDelegateForExtensionMethod("glMapGrid2f", typeof(MapGrid2f)) ?? new MapGrid2f(Imports.MapGrid2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord1d(Double u);
        internal static EvalCoord1d glEvalCoord1d = (EvalCoord1d)Gl.GetDelegateForExtensionMethod("glEvalCoord1d", typeof(EvalCoord1d)) ?? new EvalCoord1d(Imports.EvalCoord1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord1dv(Double* u);
        internal unsafe static EvalCoord1dv glEvalCoord1dv = (EvalCoord1dv)Gl.GetDelegateForExtensionMethod("glEvalCoord1dv", typeof(EvalCoord1dv)) ?? new EvalCoord1dv(Imports.EvalCoord1dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord1f(Single u);
        internal static EvalCoord1f glEvalCoord1f = (EvalCoord1f)Gl.GetDelegateForExtensionMethod("glEvalCoord1f", typeof(EvalCoord1f)) ?? new EvalCoord1f(Imports.EvalCoord1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord1fv(Single* u);
        internal unsafe static EvalCoord1fv glEvalCoord1fv = (EvalCoord1fv)Gl.GetDelegateForExtensionMethod("glEvalCoord1fv", typeof(EvalCoord1fv)) ?? new EvalCoord1fv(Imports.EvalCoord1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord2d(Double u, Double v);
        internal static EvalCoord2d glEvalCoord2d = (EvalCoord2d)Gl.GetDelegateForExtensionMethod("glEvalCoord2d", typeof(EvalCoord2d)) ?? new EvalCoord2d(Imports.EvalCoord2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord2dv(Double* u);
        internal unsafe static EvalCoord2dv glEvalCoord2dv = (EvalCoord2dv)Gl.GetDelegateForExtensionMethod("glEvalCoord2dv", typeof(EvalCoord2dv)) ?? new EvalCoord2dv(Imports.EvalCoord2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord2f(Single u, Single v);
        internal static EvalCoord2f glEvalCoord2f = (EvalCoord2f)Gl.GetDelegateForExtensionMethod("glEvalCoord2f", typeof(EvalCoord2f)) ?? new EvalCoord2f(Imports.EvalCoord2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord2fv(Single* u);
        internal unsafe static EvalCoord2fv glEvalCoord2fv = (EvalCoord2fv)Gl.GetDelegateForExtensionMethod("glEvalCoord2fv", typeof(EvalCoord2fv)) ?? new EvalCoord2fv(Imports.EvalCoord2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalMesh1(int mode, Int32 i1, Int32 i2);
        internal static EvalMesh1 glEvalMesh1 = (EvalMesh1)Gl.GetDelegateForExtensionMethod("glEvalMesh1", typeof(EvalMesh1)) ?? new EvalMesh1(Imports.EvalMesh1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalPoint1(Int32 i);
        internal static EvalPoint1 glEvalPoint1 = (EvalPoint1)Gl.GetDelegateForExtensionMethod("glEvalPoint1", typeof(EvalPoint1)) ?? new EvalPoint1(Imports.EvalPoint1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalMesh2(int mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
        internal static EvalMesh2 glEvalMesh2 = (EvalMesh2)Gl.GetDelegateForExtensionMethod("glEvalMesh2", typeof(EvalMesh2)) ?? new EvalMesh2(Imports.EvalMesh2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalPoint2(Int32 i, Int32 j);
        internal static EvalPoint2 glEvalPoint2 = (EvalPoint2)Gl.GetDelegateForExtensionMethod("glEvalPoint2", typeof(EvalPoint2)) ?? new EvalPoint2(Imports.EvalPoint2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFunc(int func, Single @ref);
        internal static AlphaFunc glAlphaFunc = (AlphaFunc)Gl.GetDelegateForExtensionMethod("glAlphaFunc", typeof(AlphaFunc)) ?? new AlphaFunc(Imports.AlphaFunc);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFunc(int sfactor, int dfactor);
        internal static BlendFunc glBlendFunc = (BlendFunc)Gl.GetDelegateForExtensionMethod("glBlendFunc", typeof(BlendFunc)) ?? new BlendFunc(Imports.BlendFunc);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LogicOp(int opcode);
        internal static LogicOp glLogicOp = (LogicOp)Gl.GetDelegateForExtensionMethod("glLogicOp", typeof(LogicOp)) ?? new LogicOp(Imports.LogicOp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFunc(int func, Int32 @ref, UInt32 mask);
        internal static StencilFunc glStencilFunc = (StencilFunc)Gl.GetDelegateForExtensionMethod("glStencilFunc", typeof(StencilFunc)) ?? new StencilFunc(Imports.StencilFunc);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOp(int fail, int zfail, int zpass);
        internal static StencilOp glStencilOp = (StencilOp)Gl.GetDelegateForExtensionMethod("glStencilOp", typeof(StencilOp)) ?? new StencilOp(Imports.StencilOp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthFunc(int func);
        internal static DepthFunc glDepthFunc = (DepthFunc)Gl.GetDelegateForExtensionMethod("glDepthFunc", typeof(DepthFunc)) ?? new DepthFunc(Imports.DepthFunc);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelZoom(Single xfactor, Single yfactor);
        internal static PixelZoom glPixelZoom = (PixelZoom)Gl.GetDelegateForExtensionMethod("glPixelZoom", typeof(PixelZoom)) ?? new PixelZoom(Imports.PixelZoom);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransferf(int pname, Single param);
        internal static PixelTransferf glPixelTransferf = (PixelTransferf)Gl.GetDelegateForExtensionMethod("glPixelTransferf", typeof(PixelTransferf)) ?? new PixelTransferf(Imports.PixelTransferf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransferi(int pname, Int32 param);
        internal static PixelTransferi glPixelTransferi = (PixelTransferi)Gl.GetDelegateForExtensionMethod("glPixelTransferi", typeof(PixelTransferi)) ?? new PixelTransferi(Imports.PixelTransferi);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelStoref(int pname, Single param);
        internal static PixelStoref glPixelStoref = (PixelStoref)Gl.GetDelegateForExtensionMethod("glPixelStoref", typeof(PixelStoref)) ?? new PixelStoref(Imports.PixelStoref);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelStorei(int pname, Int32 param);
        internal static PixelStorei glPixelStorei = (PixelStorei)Gl.GetDelegateForExtensionMethod("glPixelStorei", typeof(PixelStorei)) ?? new PixelStorei(Imports.PixelStorei);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelMapfv(int map, Int32 mapsize, Single* values);
        internal unsafe static PixelMapfv glPixelMapfv = (PixelMapfv)Gl.GetDelegateForExtensionMethod("glPixelMapfv", typeof(PixelMapfv)) ?? new PixelMapfv(Imports.PixelMapfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelMapuiv(int map, Int32 mapsize, UInt32* values);
        internal unsafe static PixelMapuiv glPixelMapuiv = (PixelMapuiv)Gl.GetDelegateForExtensionMethod("glPixelMapuiv", typeof(PixelMapuiv)) ?? new PixelMapuiv(Imports.PixelMapuiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelMapusv(int map, Int32 mapsize, UInt16* values);
        internal unsafe static PixelMapusv glPixelMapusv = (PixelMapusv)Gl.GetDelegateForExtensionMethod("glPixelMapusv", typeof(PixelMapusv)) ?? new PixelMapusv(Imports.PixelMapusv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReadBuffer(int mode);
        internal static ReadBuffer glReadBuffer = (ReadBuffer)Gl.GetDelegateForExtensionMethod("glReadBuffer", typeof(ReadBuffer)) ?? new ReadBuffer(Imports.ReadBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, int type);
        internal static CopyPixels glCopyPixels = (CopyPixels)Gl.GetDelegateForExtensionMethod("glCopyPixels", typeof(CopyPixels)) ?? new CopyPixels(Imports.CopyPixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, [Out] void* pixels);
        internal unsafe static ReadPixels glReadPixels = (ReadPixels)Gl.GetDelegateForExtensionMethod("glReadPixels", typeof(ReadPixels)) ?? new ReadPixels(Imports.ReadPixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawPixels(Int32 width, Int32 height, int format, int type, void* pixels);
        internal unsafe static DrawPixels glDrawPixels = (DrawPixels)Gl.GetDelegateForExtensionMethod("glDrawPixels", typeof(DrawPixels)) ?? new DrawPixels(Imports.DrawPixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBooleanv(int pname, [Out] int* @params);
        internal unsafe static GetBooleanv glGetBooleanv = (GetBooleanv)Gl.GetDelegateForExtensionMethod("glGetBooleanv", typeof(GetBooleanv)) ?? new GetBooleanv(Imports.GetBooleanv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetClipPlane(int plane, [Out] Double* equation);
        internal unsafe static GetClipPlane glGetClipPlane = (GetClipPlane)Gl.GetDelegateForExtensionMethod("glGetClipPlane", typeof(GetClipPlane)) ?? new GetClipPlane(Imports.GetClipPlane);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetDoublev(int pname, [Out] Double* @params);
        internal unsafe static GetDoublev glGetDoublev = (GetDoublev)Gl.GetDelegateForExtensionMethod("glGetDoublev", typeof(GetDoublev)) ?? new GetDoublev(Imports.GetDoublev);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int GetError();
        internal static GetError glGetError = (GetError)Gl.GetDelegateForExtensionMethod("glGetError", typeof(GetError)) ?? new GetError(Imports.GetError);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFloatv(int pname, [Out] Single* @params);
        internal unsafe static GetFloatv glGetFloatv = (GetFloatv)Gl.GetDelegateForExtensionMethod("glGetFloatv", typeof(GetFloatv)) ?? new GetFloatv(Imports.GetFloatv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetIntegerv(int pname, [Out] Int32* @params);
        internal unsafe static GetIntegerv glGetIntegerv = (GetIntegerv)Gl.GetDelegateForExtensionMethod("glGetIntegerv", typeof(GetIntegerv)) ?? new GetIntegerv(Imports.GetIntegerv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLightfv(int light, int pname, [Out] Single* @params);
        internal unsafe static GetLightfv glGetLightfv = (GetLightfv)Gl.GetDelegateForExtensionMethod("glGetLightfv", typeof(GetLightfv)) ?? new GetLightfv(Imports.GetLightfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLightiv(int light, int pname, [Out] Int32* @params);
        internal unsafe static GetLightiv glGetLightiv = (GetLightiv)Gl.GetDelegateForExtensionMethod("glGetLightiv", typeof(GetLightiv)) ?? new GetLightiv(Imports.GetLightiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapdv(int target, int query, [Out] Double* v);
        internal unsafe static GetMapdv glGetMapdv = (GetMapdv)Gl.GetDelegateForExtensionMethod("glGetMapdv", typeof(GetMapdv)) ?? new GetMapdv(Imports.GetMapdv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapfv(int target, int query, [Out] Single* v);
        internal unsafe static GetMapfv glGetMapfv = (GetMapfv)Gl.GetDelegateForExtensionMethod("glGetMapfv", typeof(GetMapfv)) ?? new GetMapfv(Imports.GetMapfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapiv(int target, int query, [Out] Int32* v);
        internal unsafe static GetMapiv glGetMapiv = (GetMapiv)Gl.GetDelegateForExtensionMethod("glGetMapiv", typeof(GetMapiv)) ?? new GetMapiv(Imports.GetMapiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMaterialfv(int face, int pname, [Out] Single* @params);
        internal unsafe static GetMaterialfv glGetMaterialfv = (GetMaterialfv)Gl.GetDelegateForExtensionMethod("glGetMaterialfv", typeof(GetMaterialfv)) ?? new GetMaterialfv(Imports.GetMaterialfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMaterialiv(int face, int pname, [Out] Int32* @params);
        internal unsafe static GetMaterialiv glGetMaterialiv = (GetMaterialiv)Gl.GetDelegateForExtensionMethod("glGetMaterialiv", typeof(GetMaterialiv)) ?? new GetMaterialiv(Imports.GetMaterialiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelMapfv(int map, [Out] Single* values);
        internal unsafe static GetPixelMapfv glGetPixelMapfv = (GetPixelMapfv)Gl.GetDelegateForExtensionMethod("glGetPixelMapfv", typeof(GetPixelMapfv)) ?? new GetPixelMapfv(Imports.GetPixelMapfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelMapuiv(int map, [Out] UInt32* values);
        internal unsafe static GetPixelMapuiv glGetPixelMapuiv = (GetPixelMapuiv)Gl.GetDelegateForExtensionMethod("glGetPixelMapuiv", typeof(GetPixelMapuiv)) ?? new GetPixelMapuiv(Imports.GetPixelMapuiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelMapusv(int map, [Out] UInt16* values);
        internal unsafe static GetPixelMapusv glGetPixelMapusv = (GetPixelMapusv)Gl.GetDelegateForExtensionMethod("glGetPixelMapusv", typeof(GetPixelMapusv)) ?? new GetPixelMapusv(Imports.GetPixelMapusv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPolygonStipple([Out] Byte* mask);
        internal unsafe static GetPolygonStipple glGetPolygonStipple = (GetPolygonStipple)Gl.GetDelegateForExtensionMethod("glGetPolygonStipple", typeof(GetPolygonStipple)) ?? new GetPolygonStipple(Imports.GetPolygonStipple);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr GetString(int name);
        internal static GetString glGetString = (GetString)Gl.GetDelegateForExtensionMethod("glGetString", typeof(GetString)) ?? new GetString(Imports.GetString);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexEnvfv(int target, int pname, [Out] Single* @params);
        internal unsafe static GetTexEnvfv glGetTexEnvfv = (GetTexEnvfv)Gl.GetDelegateForExtensionMethod("glGetTexEnvfv", typeof(GetTexEnvfv)) ?? new GetTexEnvfv(Imports.GetTexEnvfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexEnviv(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetTexEnviv glGetTexEnviv = (GetTexEnviv)Gl.GetDelegateForExtensionMethod("glGetTexEnviv", typeof(GetTexEnviv)) ?? new GetTexEnviv(Imports.GetTexEnviv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexGendv(int coord, int pname, [Out] Double* @params);
        internal unsafe static GetTexGendv glGetTexGendv = (GetTexGendv)Gl.GetDelegateForExtensionMethod("glGetTexGendv", typeof(GetTexGendv)) ?? new GetTexGendv(Imports.GetTexGendv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexGenfv(int coord, int pname, [Out] Single* @params);
        internal unsafe static GetTexGenfv glGetTexGenfv = (GetTexGenfv)Gl.GetDelegateForExtensionMethod("glGetTexGenfv", typeof(GetTexGenfv)) ?? new GetTexGenfv(Imports.GetTexGenfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexGeniv(int coord, int pname, [Out] Int32* @params);
        internal unsafe static GetTexGeniv glGetTexGeniv = (GetTexGeniv)Gl.GetDelegateForExtensionMethod("glGetTexGeniv", typeof(GetTexGeniv)) ?? new GetTexGeniv(Imports.GetTexGeniv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexImage(int target, Int32 level, int format, int type, [Out] void* pixels);
        internal unsafe static GetTexImage glGetTexImage = (GetTexImage)Gl.GetDelegateForExtensionMethod("glGetTexImage", typeof(GetTexImage)) ?? new GetTexImage(Imports.GetTexImage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterfv(int target, int pname, [Out] Single* @params);
        internal unsafe static GetTexParameterfv glGetTexParameterfv = (GetTexParameterfv)Gl.GetDelegateForExtensionMethod("glGetTexParameterfv", typeof(GetTexParameterfv)) ?? new GetTexParameterfv(Imports.GetTexParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameteriv(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetTexParameteriv glGetTexParameteriv = (GetTexParameteriv)Gl.GetDelegateForExtensionMethod("glGetTexParameteriv", typeof(GetTexParameteriv)) ?? new GetTexParameteriv(Imports.GetTexParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexLevelParameterfv(int target, Int32 level, int pname, [Out] Single* @params);
        internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv = (GetTexLevelParameterfv)Gl.GetDelegateForExtensionMethod("glGetTexLevelParameterfv", typeof(GetTexLevelParameterfv)) ?? new GetTexLevelParameterfv(Imports.GetTexLevelParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexLevelParameteriv(int target, Int32 level, int pname, [Out] Int32* @params);
        internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv = (GetTexLevelParameteriv)Gl.GetDelegateForExtensionMethod("glGetTexLevelParameteriv", typeof(GetTexLevelParameteriv)) ?? new GetTexLevelParameteriv(Imports.GetTexLevelParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsEnabled(int cap);
        internal static IsEnabled glIsEnabled = (IsEnabled)Gl.GetDelegateForExtensionMethod("glIsEnabled", typeof(IsEnabled)) ?? new IsEnabled(Imports.IsEnabled);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsList(UInt32 list);
        internal static IsList glIsList = (IsList)Gl.GetDelegateForExtensionMethod("glIsList", typeof(IsList)) ?? new IsList(Imports.IsList);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthRange(Double near, Double far);
        internal static DepthRange glDepthRange = (DepthRange)Gl.GetDelegateForExtensionMethod("glDepthRange", typeof(DepthRange)) ?? new DepthRange(Imports.DepthRange);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Frustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
        internal static Frustum glFrustum = (Frustum)Gl.GetDelegateForExtensionMethod("glFrustum", typeof(Frustum)) ?? new Frustum(Imports.Frustum);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LoadIdentity();
        internal static LoadIdentity glLoadIdentity = (LoadIdentity)Gl.GetDelegateForExtensionMethod("glLoadIdentity", typeof(LoadIdentity)) ?? new LoadIdentity(Imports.LoadIdentity);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadMatrixf(Single* m);
        internal unsafe static LoadMatrixf glLoadMatrixf = (LoadMatrixf)Gl.GetDelegateForExtensionMethod("glLoadMatrixf", typeof(LoadMatrixf)) ?? new LoadMatrixf(Imports.LoadMatrixf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadMatrixd(Double* m);
        internal unsafe static LoadMatrixd glLoadMatrixd = (LoadMatrixd)Gl.GetDelegateForExtensionMethod("glLoadMatrixd", typeof(LoadMatrixd)) ?? new LoadMatrixd(Imports.LoadMatrixd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MatrixMode(int mode);
        internal static MatrixMode glMatrixMode = (MatrixMode)Gl.GetDelegateForExtensionMethod("glMatrixMode", typeof(MatrixMode)) ?? new MatrixMode(Imports.MatrixMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultMatrixf(Single* m);
        internal unsafe static MultMatrixf glMultMatrixf = (MultMatrixf)Gl.GetDelegateForExtensionMethod("glMultMatrixf", typeof(MultMatrixf)) ?? new MultMatrixf(Imports.MultMatrixf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultMatrixd(Double* m);
        internal unsafe static MultMatrixd glMultMatrixd = (MultMatrixd)Gl.GetDelegateForExtensionMethod("glMultMatrixd", typeof(MultMatrixd)) ?? new MultMatrixd(Imports.MultMatrixd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Ortho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
        internal static Ortho glOrtho = (Ortho)Gl.GetDelegateForExtensionMethod("glOrtho", typeof(Ortho)) ?? new Ortho(Imports.Ortho);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopMatrix();
        internal static PopMatrix glPopMatrix = (PopMatrix)Gl.GetDelegateForExtensionMethod("glPopMatrix", typeof(PopMatrix)) ?? new PopMatrix(Imports.PopMatrix);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushMatrix();
        internal static PushMatrix glPushMatrix = (PushMatrix)Gl.GetDelegateForExtensionMethod("glPushMatrix", typeof(PushMatrix)) ?? new PushMatrix(Imports.PushMatrix);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rotated(Double angle, Double x, Double y, Double z);
        internal static Rotated glRotated = (Rotated)Gl.GetDelegateForExtensionMethod("glRotated", typeof(Rotated)) ?? new Rotated(Imports.Rotated);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rotatef(Single angle, Single x, Single y, Single z);
        internal static Rotatef glRotatef = (Rotatef)Gl.GetDelegateForExtensionMethod("glRotatef", typeof(Rotatef)) ?? new Rotatef(Imports.Rotatef);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Scaled(Double x, Double y, Double z);
        internal static Scaled glScaled = (Scaled)Gl.GetDelegateForExtensionMethod("glScaled", typeof(Scaled)) ?? new Scaled(Imports.Scaled);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Scalef(Single x, Single y, Single z);
        internal static Scalef glScalef = (Scalef)Gl.GetDelegateForExtensionMethod("glScalef", typeof(Scalef)) ?? new Scalef(Imports.Scalef);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Translated(Double x, Double y, Double z);
        internal static Translated glTranslated = (Translated)Gl.GetDelegateForExtensionMethod("glTranslated", typeof(Translated)) ?? new Translated(Imports.Translated);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Translatef(Single x, Single y, Single z);
        internal static Translatef glTranslatef = (Translatef)Gl.GetDelegateForExtensionMethod("glTranslatef", typeof(Translatef)) ?? new Translatef(Imports.Translatef);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
        internal static Viewport glViewport = (Viewport)Gl.GetDelegateForExtensionMethod("glViewport", typeof(Viewport)) ?? new Viewport(Imports.Viewport);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ArrayElement(Int32 i);
        internal static ArrayElement glArrayElement = (ArrayElement)Gl.GetDelegateForExtensionMethod("glArrayElement", typeof(ArrayElement)) ?? new ArrayElement(Imports.ArrayElement);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointer(Int32 size, int type, Int32 stride, void* pointer);
        internal unsafe static ColorPointer glColorPointer = (ColorPointer)Gl.GetDelegateForExtensionMethod("glColorPointer", typeof(ColorPointer)) ?? new ColorPointer(Imports.ColorPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableClientState(int array);
        internal static DisableClientState glDisableClientState = (DisableClientState)Gl.GetDelegateForExtensionMethod("glDisableClientState", typeof(DisableClientState)) ?? new DisableClientState(Imports.DisableClientState);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArrays(int mode, Int32 first, Int32 count);
        internal static DrawArrays glDrawArrays = (DrawArrays)Gl.GetDelegateForExtensionMethod("glDrawArrays", typeof(DrawArrays)) ?? new DrawArrays(Imports.DrawArrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawElements(int mode, Int32 count, int type, void* indices);
        internal unsafe static DrawElements glDrawElements = (DrawElements)Gl.GetDelegateForExtensionMethod("glDrawElements", typeof(DrawElements)) ?? new DrawElements(Imports.DrawElements);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagPointer(Int32 stride, void* pointer);
        internal unsafe static EdgeFlagPointer glEdgeFlagPointer = (EdgeFlagPointer)Gl.GetDelegateForExtensionMethod("glEdgeFlagPointer", typeof(EdgeFlagPointer)) ?? new EdgeFlagPointer(Imports.EdgeFlagPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableClientState(int array);
        internal static EnableClientState glEnableClientState = (EnableClientState)Gl.GetDelegateForExtensionMethod("glEnableClientState", typeof(EnableClientState)) ?? new EnableClientState(Imports.EnableClientState);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPointerv(int pname, [Out] void* @params);
        internal unsafe static GetPointerv glGetPointerv = (GetPointerv)Gl.GetDelegateForExtensionMethod("glGetPointerv", typeof(GetPointerv)) ?? new GetPointerv(Imports.GetPointerv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IndexPointer(int type, Int32 stride, void* pointer);
        internal unsafe static IndexPointer glIndexPointer = (IndexPointer)Gl.GetDelegateForExtensionMethod("glIndexPointer", typeof(IndexPointer)) ?? new IndexPointer(Imports.IndexPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void InterleavedArrays(int format, Int32 stride, void* pointer);
        internal unsafe static InterleavedArrays glInterleavedArrays = (InterleavedArrays)Gl.GetDelegateForExtensionMethod("glInterleavedArrays", typeof(InterleavedArrays)) ?? new InterleavedArrays(Imports.InterleavedArrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointer(int type, Int32 stride, void* pointer);
        internal unsafe static NormalPointer glNormalPointer = (NormalPointer)Gl.GetDelegateForExtensionMethod("glNormalPointer", typeof(NormalPointer)) ?? new NormalPointer(Imports.NormalPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointer(Int32 size, int type, Int32 stride, void* pointer);
        internal unsafe static TexCoordPointer glTexCoordPointer = (TexCoordPointer)Gl.GetDelegateForExtensionMethod("glTexCoordPointer", typeof(TexCoordPointer)) ?? new TexCoordPointer(Imports.TexCoordPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointer(Int32 size, int type, Int32 stride, void* pointer);
        internal unsafe static VertexPointer glVertexPointer = (VertexPointer)Gl.GetDelegateForExtensionMethod("glVertexPointer", typeof(VertexPointer)) ?? new VertexPointer(Imports.VertexPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonOffset(Single factor, Single units);
        internal static PolygonOffset glPolygonOffset = (PolygonOffset)Gl.GetDelegateForExtensionMethod("glPolygonOffset", typeof(PolygonOffset)) ?? new PolygonOffset(Imports.PolygonOffset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage1D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
        internal static CopyTexImage1D glCopyTexImage1D = (CopyTexImage1D)Gl.GetDelegateForExtensionMethod("glCopyTexImage1D", typeof(CopyTexImage1D)) ?? new CopyTexImage1D(Imports.CopyTexImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage2D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        internal static CopyTexImage2D glCopyTexImage2D = (CopyTexImage2D)Gl.GetDelegateForExtensionMethod("glCopyTexImage2D", typeof(CopyTexImage2D)) ?? new CopyTexImage2D(Imports.CopyTexImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
        internal static CopyTexSubImage1D glCopyTexSubImage1D = (CopyTexSubImage1D)Gl.GetDelegateForExtensionMethod("glCopyTexSubImage1D", typeof(CopyTexSubImage1D)) ?? new CopyTexSubImage1D(Imports.CopyTexSubImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyTexSubImage2D glCopyTexSubImage2D = (CopyTexSubImage2D)Gl.GetDelegateForExtensionMethod("glCopyTexSubImage2D", typeof(CopyTexSubImage2D)) ?? new CopyTexSubImage2D(Imports.CopyTexSubImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, void* pixels);
        internal unsafe static TexSubImage1D glTexSubImage1D = (TexSubImage1D)Gl.GetDelegateForExtensionMethod("glTexSubImage1D", typeof(TexSubImage1D)) ?? new TexSubImage1D(Imports.TexSubImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, void* pixels);
        internal unsafe static TexSubImage2D glTexSubImage2D = (TexSubImage2D)Gl.GetDelegateForExtensionMethod("glTexSubImage2D", typeof(TexSubImage2D)) ?? new TexSubImage2D(Imports.TexSubImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate int AreTexturesResident(Int32 n, UInt32* textures, [Out] int* residences);
        internal unsafe static AreTexturesResident glAreTexturesResident = (AreTexturesResident)Gl.GetDelegateForExtensionMethod("glAreTexturesResident", typeof(AreTexturesResident)) ?? new AreTexturesResident(Imports.AreTexturesResident);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindTexture(int target, UInt32 texture);
        internal static BindTexture glBindTexture = (BindTexture)Gl.GetDelegateForExtensionMethod("glBindTexture", typeof(BindTexture)) ?? new BindTexture(Imports.BindTexture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
        internal unsafe static DeleteTextures glDeleteTextures = (DeleteTextures)Gl.GetDelegateForExtensionMethod("glDeleteTextures", typeof(DeleteTextures)) ?? new DeleteTextures(Imports.DeleteTextures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenTextures(Int32 n, [Out] UInt32* textures);
        internal unsafe static GenTextures glGenTextures = (GenTextures)Gl.GetDelegateForExtensionMethod("glGenTextures", typeof(GenTextures)) ?? new GenTextures(Imports.GenTextures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsTexture(UInt32 texture);
        internal static IsTexture glIsTexture = (IsTexture)Gl.GetDelegateForExtensionMethod("glIsTexture", typeof(IsTexture)) ?? new IsTexture(Imports.IsTexture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PrioritizeTextures(Int32 n, UInt32* textures, Single* priorities);
        internal unsafe static PrioritizeTextures glPrioritizeTextures = (PrioritizeTextures)Gl.GetDelegateForExtensionMethod("glPrioritizeTextures", typeof(PrioritizeTextures)) ?? new PrioritizeTextures(Imports.PrioritizeTextures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexub(Byte c);
        internal static Indexub glIndexub = (Indexub)Gl.GetDelegateForExtensionMethod("glIndexub", typeof(Indexub)) ?? new Indexub(Imports.Indexub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexubv(Byte* c);
        internal unsafe static Indexubv glIndexubv = (Indexubv)Gl.GetDelegateForExtensionMethod("glIndexubv", typeof(Indexubv)) ?? new Indexubv(Imports.Indexubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopClientAttrib();
        internal static PopClientAttrib glPopClientAttrib = (PopClientAttrib)Gl.GetDelegateForExtensionMethod("glPopClientAttrib", typeof(PopClientAttrib)) ?? new PopClientAttrib(Imports.PopClientAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushClientAttrib(int mask);
        internal static PushClientAttrib glPushClientAttrib = (PushClientAttrib)Gl.GetDelegateForExtensionMethod("glPushClientAttrib", typeof(PushClientAttrib)) ?? new PushClientAttrib(Imports.PushClientAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
        internal static BlendColor glBlendColor = (BlendColor)Gl.GetDelegateForExtensionMethod("glBlendColor", typeof(BlendColor)) ?? new BlendColor(Imports.BlendColor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquation(int mode);
        internal static BlendEquation glBlendEquation = (BlendEquation)Gl.GetDelegateForExtensionMethod("glBlendEquation", typeof(BlendEquation)) ?? new BlendEquation(Imports.BlendEquation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawRangeElements(int mode, UInt32 start, UInt32 end, Int32 count, int type, void* indices);
        internal unsafe static DrawRangeElements glDrawRangeElements = (DrawRangeElements)Gl.GetDelegateForExtensionMethod("glDrawRangeElements", typeof(DrawRangeElements)) ?? new DrawRangeElements(Imports.DrawRangeElements);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTable(int target, int internalformat, Int32 width, int format, int type, void* table);
        internal unsafe static ColorTable glColorTable = (ColorTable)Gl.GetDelegateForExtensionMethod("glColorTable", typeof(ColorTable)) ?? new ColorTable(Imports.ColorTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameterfv(int target, int pname, Single* @params);
        internal unsafe static ColorTableParameterfv glColorTableParameterfv = (ColorTableParameterfv)Gl.GetDelegateForExtensionMethod("glColorTableParameterfv", typeof(ColorTableParameterfv)) ?? new ColorTableParameterfv(Imports.ColorTableParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameteriv(int target, int pname, Int32* @params);
        internal unsafe static ColorTableParameteriv glColorTableParameteriv = (ColorTableParameteriv)Gl.GetDelegateForExtensionMethod("glColorTableParameteriv", typeof(ColorTableParameteriv)) ?? new ColorTableParameteriv(Imports.ColorTableParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorTable(int target, int internalformat, Int32 x, Int32 y, Int32 width);
        internal static CopyColorTable glCopyColorTable = (CopyColorTable)Gl.GetDelegateForExtensionMethod("glCopyColorTable", typeof(CopyColorTable)) ?? new CopyColorTable(Imports.CopyColorTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTable(int target, int format, int type, [Out] void* table);
        internal unsafe static GetColorTable glGetColorTable = (GetColorTable)Gl.GetDelegateForExtensionMethod("glGetColorTable", typeof(GetColorTable)) ?? new GetColorTable(Imports.GetColorTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterfv(int target, int pname, [Out] Single* @params);
        internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv = (GetColorTableParameterfv)Gl.GetDelegateForExtensionMethod("glGetColorTableParameterfv", typeof(GetColorTableParameterfv)) ?? new GetColorTableParameterfv(Imports.GetColorTableParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameteriv(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv = (GetColorTableParameteriv)Gl.GetDelegateForExtensionMethod("glGetColorTableParameteriv", typeof(GetColorTableParameteriv)) ?? new GetColorTableParameteriv(Imports.GetColorTableParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorSubTable(int target, Int32 start, Int32 count, int format, int type, void* data);
        internal unsafe static ColorSubTable glColorSubTable = (ColorSubTable)Gl.GetDelegateForExtensionMethod("glColorSubTable", typeof(ColorSubTable)) ?? new ColorSubTable(Imports.ColorSubTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorSubTable(int target, Int32 start, Int32 x, Int32 y, Int32 width);
        internal static CopyColorSubTable glCopyColorSubTable = (CopyColorSubTable)Gl.GetDelegateForExtensionMethod("glCopyColorSubTable", typeof(CopyColorSubTable)) ?? new CopyColorSubTable(Imports.CopyColorSubTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter1D(int target, int internalformat, Int32 width, int format, int type, void* image);
        internal unsafe static ConvolutionFilter1D glConvolutionFilter1D = (ConvolutionFilter1D)Gl.GetDelegateForExtensionMethod("glConvolutionFilter1D", typeof(ConvolutionFilter1D)) ?? new ConvolutionFilter1D(Imports.ConvolutionFilter1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, void* image);
        internal unsafe static ConvolutionFilter2D glConvolutionFilter2D = (ConvolutionFilter2D)Gl.GetDelegateForExtensionMethod("glConvolutionFilter2D", typeof(ConvolutionFilter2D)) ?? new ConvolutionFilter2D(Imports.ConvolutionFilter2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameterf(int target, int pname, Single @params);
        internal static ConvolutionParameterf glConvolutionParameterf = (ConvolutionParameterf)Gl.GetDelegateForExtensionMethod("glConvolutionParameterf", typeof(ConvolutionParameterf)) ?? new ConvolutionParameterf(Imports.ConvolutionParameterf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameterfv(int target, int pname, Single* @params);
        internal unsafe static ConvolutionParameterfv glConvolutionParameterfv = (ConvolutionParameterfv)Gl.GetDelegateForExtensionMethod("glConvolutionParameterfv", typeof(ConvolutionParameterfv)) ?? new ConvolutionParameterfv(Imports.ConvolutionParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameteri(int target, int pname, Int32 @params);
        internal static ConvolutionParameteri glConvolutionParameteri = (ConvolutionParameteri)Gl.GetDelegateForExtensionMethod("glConvolutionParameteri", typeof(ConvolutionParameteri)) ?? new ConvolutionParameteri(Imports.ConvolutionParameteri);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameteriv(int target, int pname, Int32* @params);
        internal unsafe static ConvolutionParameteriv glConvolutionParameteriv = (ConvolutionParameteriv)Gl.GetDelegateForExtensionMethod("glConvolutionParameteriv", typeof(ConvolutionParameteriv)) ?? new ConvolutionParameteriv(Imports.ConvolutionParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter1D(int target, int internalformat, Int32 x, Int32 y, Int32 width);
        internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D = (CopyConvolutionFilter1D)Gl.GetDelegateForExtensionMethod("glCopyConvolutionFilter1D", typeof(CopyConvolutionFilter1D)) ?? new CopyConvolutionFilter1D(Imports.CopyConvolutionFilter1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter2D(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D = (CopyConvolutionFilter2D)Gl.GetDelegateForExtensionMethod("glCopyConvolutionFilter2D", typeof(CopyConvolutionFilter2D)) ?? new CopyConvolutionFilter2D(Imports.CopyConvolutionFilter2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionFilter(int target, int format, int type, [Out] void* image);
        internal unsafe static GetConvolutionFilter glGetConvolutionFilter = (GetConvolutionFilter)Gl.GetDelegateForExtensionMethod("glGetConvolutionFilter", typeof(GetConvolutionFilter)) ?? new GetConvolutionFilter(Imports.GetConvolutionFilter);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameterfv(int target, int pname, [Out] Single* @params);
        internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv = (GetConvolutionParameterfv)Gl.GetDelegateForExtensionMethod("glGetConvolutionParameterfv", typeof(GetConvolutionParameterfv)) ?? new GetConvolutionParameterfv(Imports.GetConvolutionParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameteriv(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv = (GetConvolutionParameteriv)Gl.GetDelegateForExtensionMethod("glGetConvolutionParameteriv", typeof(GetConvolutionParameteriv)) ?? new GetConvolutionParameteriv(Imports.GetConvolutionParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSeparableFilter(int target, int format, int type, [Out] void* row, [Out] void* column, [Out] void* span);
        internal unsafe static GetSeparableFilter glGetSeparableFilter = (GetSeparableFilter)Gl.GetDelegateForExtensionMethod("glGetSeparableFilter", typeof(GetSeparableFilter)) ?? new GetSeparableFilter(Imports.GetSeparableFilter);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, void* row, void* column);
        internal unsafe static SeparableFilter2D glSeparableFilter2D = (SeparableFilter2D)Gl.GetDelegateForExtensionMethod("glSeparableFilter2D", typeof(SeparableFilter2D)) ?? new SeparableFilter2D(Imports.SeparableFilter2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogram(int target, int reset, int format, int type, [Out] void* values);
        internal unsafe static GetHistogram glGetHistogram = (GetHistogram)Gl.GetDelegateForExtensionMethod("glGetHistogram", typeof(GetHistogram)) ?? new GetHistogram(Imports.GetHistogram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameterfv(int target, int pname, [Out] Single* @params);
        internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv = (GetHistogramParameterfv)Gl.GetDelegateForExtensionMethod("glGetHistogramParameterfv", typeof(GetHistogramParameterfv)) ?? new GetHistogramParameterfv(Imports.GetHistogramParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameteriv(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv = (GetHistogramParameteriv)Gl.GetDelegateForExtensionMethod("glGetHistogramParameteriv", typeof(GetHistogramParameteriv)) ?? new GetHistogramParameteriv(Imports.GetHistogramParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmax(int target, int reset, int format, int type, [Out] void* values);
        internal unsafe static GetMinmax glGetMinmax = (GetMinmax)Gl.GetDelegateForExtensionMethod("glGetMinmax", typeof(GetMinmax)) ?? new GetMinmax(Imports.GetMinmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameterfv(int target, int pname, [Out] Single* @params);
        internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv = (GetMinmaxParameterfv)Gl.GetDelegateForExtensionMethod("glGetMinmaxParameterfv", typeof(GetMinmaxParameterfv)) ?? new GetMinmaxParameterfv(Imports.GetMinmaxParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameteriv(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv = (GetMinmaxParameteriv)Gl.GetDelegateForExtensionMethod("glGetMinmaxParameteriv", typeof(GetMinmaxParameteriv)) ?? new GetMinmaxParameteriv(Imports.GetMinmaxParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Histogram(int target, Int32 width, int internalformat, int sink);
        internal static Histogram glHistogram = (Histogram)Gl.GetDelegateForExtensionMethod("glHistogram", typeof(Histogram)) ?? new Histogram(Imports.Histogram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Minmax(int target, int internalformat, int sink);
        internal static Minmax glMinmax = (Minmax)Gl.GetDelegateForExtensionMethod("glMinmax", typeof(Minmax)) ?? new Minmax(Imports.Minmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetHistogram(int target);
        internal static ResetHistogram glResetHistogram = (ResetHistogram)Gl.GetDelegateForExtensionMethod("glResetHistogram", typeof(ResetHistogram)) ?? new ResetHistogram(Imports.ResetHistogram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetMinmax(int target);
        internal static ResetMinmax glResetMinmax = (ResetMinmax)Gl.GetDelegateForExtensionMethod("glResetMinmax", typeof(ResetMinmax)) ?? new ResetMinmax(Imports.ResetMinmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage3D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, void* pixels);
        internal unsafe static TexImage3D glTexImage3D = (TexImage3D)Gl.GetDelegateForExtensionMethod("glTexImage3D", typeof(TexImage3D)) ?? new TexImage3D(Imports.TexImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, void* pixels);
        internal unsafe static TexSubImage3D glTexSubImage3D = (TexSubImage3D)Gl.GetDelegateForExtensionMethod("glTexSubImage3D", typeof(TexSubImage3D)) ?? new TexSubImage3D(Imports.TexSubImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyTexSubImage3D glCopyTexSubImage3D = (CopyTexSubImage3D)Gl.GetDelegateForExtensionMethod("glCopyTexSubImage3D", typeof(CopyTexSubImage3D)) ?? new CopyTexSubImage3D(Imports.CopyTexSubImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveTexture(int texture);
        internal static ActiveTexture glActiveTexture = (ActiveTexture)Gl.GetDelegateForExtensionMethod("glActiveTexture", typeof(ActiveTexture)) ?? new ActiveTexture(Imports.ActiveTexture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClientActiveTexture(int texture);
        internal static ClientActiveTexture glClientActiveTexture = (ClientActiveTexture)Gl.GetDelegateForExtensionMethod("glClientActiveTexture", typeof(ClientActiveTexture)) ?? new ClientActiveTexture(Imports.ClientActiveTexture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1d(int target, Double s);
        internal static MultiTexCoord1d glMultiTexCoord1d = (MultiTexCoord1d)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1d", typeof(MultiTexCoord1d)) ?? new MultiTexCoord1d(Imports.MultiTexCoord1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1dv(int target, Double* v);
        internal unsafe static MultiTexCoord1dv glMultiTexCoord1dv = (MultiTexCoord1dv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1dv", typeof(MultiTexCoord1dv)) ?? new MultiTexCoord1dv(Imports.MultiTexCoord1dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1f(int target, Single s);
        internal static MultiTexCoord1f glMultiTexCoord1f = (MultiTexCoord1f)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1f", typeof(MultiTexCoord1f)) ?? new MultiTexCoord1f(Imports.MultiTexCoord1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1fv(int target, Single* v);
        internal unsafe static MultiTexCoord1fv glMultiTexCoord1fv = (MultiTexCoord1fv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1fv", typeof(MultiTexCoord1fv)) ?? new MultiTexCoord1fv(Imports.MultiTexCoord1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1i(int target, Int32 s);
        internal static MultiTexCoord1i glMultiTexCoord1i = (MultiTexCoord1i)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1i", typeof(MultiTexCoord1i)) ?? new MultiTexCoord1i(Imports.MultiTexCoord1i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1iv(int target, Int32* v);
        internal unsafe static MultiTexCoord1iv glMultiTexCoord1iv = (MultiTexCoord1iv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1iv", typeof(MultiTexCoord1iv)) ?? new MultiTexCoord1iv(Imports.MultiTexCoord1iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1s(int target, Int16 s);
        internal static MultiTexCoord1s glMultiTexCoord1s = (MultiTexCoord1s)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1s", typeof(MultiTexCoord1s)) ?? new MultiTexCoord1s(Imports.MultiTexCoord1s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1sv(int target, Int16* v);
        internal unsafe static MultiTexCoord1sv glMultiTexCoord1sv = (MultiTexCoord1sv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1sv", typeof(MultiTexCoord1sv)) ?? new MultiTexCoord1sv(Imports.MultiTexCoord1sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2d(int target, Double s, Double t);
        internal static MultiTexCoord2d glMultiTexCoord2d = (MultiTexCoord2d)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2d", typeof(MultiTexCoord2d)) ?? new MultiTexCoord2d(Imports.MultiTexCoord2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2dv(int target, Double* v);
        internal unsafe static MultiTexCoord2dv glMultiTexCoord2dv = (MultiTexCoord2dv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2dv", typeof(MultiTexCoord2dv)) ?? new MultiTexCoord2dv(Imports.MultiTexCoord2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2f(int target, Single s, Single t);
        internal static MultiTexCoord2f glMultiTexCoord2f = (MultiTexCoord2f)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2f", typeof(MultiTexCoord2f)) ?? new MultiTexCoord2f(Imports.MultiTexCoord2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2fv(int target, Single* v);
        internal unsafe static MultiTexCoord2fv glMultiTexCoord2fv = (MultiTexCoord2fv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2fv", typeof(MultiTexCoord2fv)) ?? new MultiTexCoord2fv(Imports.MultiTexCoord2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2i(int target, Int32 s, Int32 t);
        internal static MultiTexCoord2i glMultiTexCoord2i = (MultiTexCoord2i)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2i", typeof(MultiTexCoord2i)) ?? new MultiTexCoord2i(Imports.MultiTexCoord2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2iv(int target, Int32* v);
        internal unsafe static MultiTexCoord2iv glMultiTexCoord2iv = (MultiTexCoord2iv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2iv", typeof(MultiTexCoord2iv)) ?? new MultiTexCoord2iv(Imports.MultiTexCoord2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2s(int target, Int16 s, Int16 t);
        internal static MultiTexCoord2s glMultiTexCoord2s = (MultiTexCoord2s)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2s", typeof(MultiTexCoord2s)) ?? new MultiTexCoord2s(Imports.MultiTexCoord2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2sv(int target, Int16* v);
        internal unsafe static MultiTexCoord2sv glMultiTexCoord2sv = (MultiTexCoord2sv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2sv", typeof(MultiTexCoord2sv)) ?? new MultiTexCoord2sv(Imports.MultiTexCoord2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3d(int target, Double s, Double t, Double r);
        internal static MultiTexCoord3d glMultiTexCoord3d = (MultiTexCoord3d)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3d", typeof(MultiTexCoord3d)) ?? new MultiTexCoord3d(Imports.MultiTexCoord3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3dv(int target, Double* v);
        internal unsafe static MultiTexCoord3dv glMultiTexCoord3dv = (MultiTexCoord3dv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3dv", typeof(MultiTexCoord3dv)) ?? new MultiTexCoord3dv(Imports.MultiTexCoord3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3f(int target, Single s, Single t, Single r);
        internal static MultiTexCoord3f glMultiTexCoord3f = (MultiTexCoord3f)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3f", typeof(MultiTexCoord3f)) ?? new MultiTexCoord3f(Imports.MultiTexCoord3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3fv(int target, Single* v);
        internal unsafe static MultiTexCoord3fv glMultiTexCoord3fv = (MultiTexCoord3fv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3fv", typeof(MultiTexCoord3fv)) ?? new MultiTexCoord3fv(Imports.MultiTexCoord3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3i(int target, Int32 s, Int32 t, Int32 r);
        internal static MultiTexCoord3i glMultiTexCoord3i = (MultiTexCoord3i)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3i", typeof(MultiTexCoord3i)) ?? new MultiTexCoord3i(Imports.MultiTexCoord3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3iv(int target, Int32* v);
        internal unsafe static MultiTexCoord3iv glMultiTexCoord3iv = (MultiTexCoord3iv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3iv", typeof(MultiTexCoord3iv)) ?? new MultiTexCoord3iv(Imports.MultiTexCoord3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3s(int target, Int16 s, Int16 t, Int16 r);
        internal static MultiTexCoord3s glMultiTexCoord3s = (MultiTexCoord3s)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3s", typeof(MultiTexCoord3s)) ?? new MultiTexCoord3s(Imports.MultiTexCoord3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3sv(int target, Int16* v);
        internal unsafe static MultiTexCoord3sv glMultiTexCoord3sv = (MultiTexCoord3sv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3sv", typeof(MultiTexCoord3sv)) ?? new MultiTexCoord3sv(Imports.MultiTexCoord3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4d(int target, Double s, Double t, Double r, Double q);
        internal static MultiTexCoord4d glMultiTexCoord4d = (MultiTexCoord4d)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4d", typeof(MultiTexCoord4d)) ?? new MultiTexCoord4d(Imports.MultiTexCoord4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4dv(int target, Double* v);
        internal unsafe static MultiTexCoord4dv glMultiTexCoord4dv = (MultiTexCoord4dv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4dv", typeof(MultiTexCoord4dv)) ?? new MultiTexCoord4dv(Imports.MultiTexCoord4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4f(int target, Single s, Single t, Single r, Single q);
        internal static MultiTexCoord4f glMultiTexCoord4f = (MultiTexCoord4f)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4f", typeof(MultiTexCoord4f)) ?? new MultiTexCoord4f(Imports.MultiTexCoord4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4fv(int target, Single* v);
        internal unsafe static MultiTexCoord4fv glMultiTexCoord4fv = (MultiTexCoord4fv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4fv", typeof(MultiTexCoord4fv)) ?? new MultiTexCoord4fv(Imports.MultiTexCoord4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4i(int target, Int32 s, Int32 t, Int32 r, Int32 q);
        internal static MultiTexCoord4i glMultiTexCoord4i = (MultiTexCoord4i)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4i", typeof(MultiTexCoord4i)) ?? new MultiTexCoord4i(Imports.MultiTexCoord4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4iv(int target, Int32* v);
        internal unsafe static MultiTexCoord4iv glMultiTexCoord4iv = (MultiTexCoord4iv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4iv", typeof(MultiTexCoord4iv)) ?? new MultiTexCoord4iv(Imports.MultiTexCoord4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4s(int target, Int16 s, Int16 t, Int16 r, Int16 q);
        internal static MultiTexCoord4s glMultiTexCoord4s = (MultiTexCoord4s)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4s", typeof(MultiTexCoord4s)) ?? new MultiTexCoord4s(Imports.MultiTexCoord4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4sv(int target, Int16* v);
        internal unsafe static MultiTexCoord4sv glMultiTexCoord4sv = (MultiTexCoord4sv)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4sv", typeof(MultiTexCoord4sv)) ?? new MultiTexCoord4sv(Imports.MultiTexCoord4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixf(Single* m);
        internal unsafe static LoadTransposeMatrixf glLoadTransposeMatrixf = (LoadTransposeMatrixf)Gl.GetDelegateForExtensionMethod("glLoadTransposeMatrixf", typeof(LoadTransposeMatrixf)) ?? new LoadTransposeMatrixf(Imports.LoadTransposeMatrixf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixd(Double* m);
        internal unsafe static LoadTransposeMatrixd glLoadTransposeMatrixd = (LoadTransposeMatrixd)Gl.GetDelegateForExtensionMethod("glLoadTransposeMatrixd", typeof(LoadTransposeMatrixd)) ?? new LoadTransposeMatrixd(Imports.LoadTransposeMatrixd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixf(Single* m);
        internal unsafe static MultTransposeMatrixf glMultTransposeMatrixf = (MultTransposeMatrixf)Gl.GetDelegateForExtensionMethod("glMultTransposeMatrixf", typeof(MultTransposeMatrixf)) ?? new MultTransposeMatrixf(Imports.MultTransposeMatrixf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixd(Double* m);
        internal unsafe static MultTransposeMatrixd glMultTransposeMatrixd = (MultTransposeMatrixd)Gl.GetDelegateForExtensionMethod("glMultTransposeMatrixd", typeof(MultTransposeMatrixd)) ?? new MultTransposeMatrixd(Imports.MultTransposeMatrixd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleCoverage(Single value, int invert);
        internal static SampleCoverage glSampleCoverage = (SampleCoverage)Gl.GetDelegateForExtensionMethod("glSampleCoverage", typeof(SampleCoverage)) ?? new SampleCoverage(Imports.SampleCoverage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage3D glCompressedTexImage3D = (CompressedTexImage3D)Gl.GetDelegateForExtensionMethod("glCompressedTexImage3D", typeof(CompressedTexImage3D)) ?? new CompressedTexImage3D(Imports.CompressedTexImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage2D glCompressedTexImage2D = (CompressedTexImage2D)Gl.GetDelegateForExtensionMethod("glCompressedTexImage2D", typeof(CompressedTexImage2D)) ?? new CompressedTexImage2D(Imports.CompressedTexImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage1D glCompressedTexImage1D = (CompressedTexImage1D)Gl.GetDelegateForExtensionMethod("glCompressedTexImage1D", typeof(CompressedTexImage1D)) ?? new CompressedTexImage1D(Imports.CompressedTexImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage3D glCompressedTexSubImage3D = (CompressedTexSubImage3D)Gl.GetDelegateForExtensionMethod("glCompressedTexSubImage3D", typeof(CompressedTexSubImage3D)) ?? new CompressedTexSubImage3D(Imports.CompressedTexSubImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage2D glCompressedTexSubImage2D = (CompressedTexSubImage2D)Gl.GetDelegateForExtensionMethod("glCompressedTexSubImage2D", typeof(CompressedTexSubImage2D)) ?? new CompressedTexSubImage2D(Imports.CompressedTexSubImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage1D glCompressedTexSubImage1D = (CompressedTexSubImage1D)Gl.GetDelegateForExtensionMethod("glCompressedTexSubImage1D", typeof(CompressedTexSubImage1D)) ?? new CompressedTexSubImage1D(Imports.CompressedTexSubImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCompressedTexImage(int target, Int32 level, [Out] void* img);
        internal unsafe static GetCompressedTexImage glGetCompressedTexImage = (GetCompressedTexImage)Gl.GetDelegateForExtensionMethod("glGetCompressedTexImage", typeof(GetCompressedTexImage)) ?? new GetCompressedTexImage(Imports.GetCompressedTexImage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
        internal static BlendFuncSeparate glBlendFuncSeparate = (BlendFuncSeparate)Gl.GetDelegateForExtensionMethod("glBlendFuncSeparate", typeof(BlendFuncSeparate)) ?? new BlendFuncSeparate(Imports.BlendFuncSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordf(Single coord);
        internal static FogCoordf glFogCoordf = (FogCoordf)Gl.GetDelegateForExtensionMethod("glFogCoordf", typeof(FogCoordf)) ?? new FogCoordf(Imports.FogCoordf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordfv(Single* coord);
        internal unsafe static FogCoordfv glFogCoordfv = (FogCoordfv)Gl.GetDelegateForExtensionMethod("glFogCoordfv", typeof(FogCoordfv)) ?? new FogCoordfv(Imports.FogCoordfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordd(Double coord);
        internal static FogCoordd glFogCoordd = (FogCoordd)Gl.GetDelegateForExtensionMethod("glFogCoordd", typeof(FogCoordd)) ?? new FogCoordd(Imports.FogCoordd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoorddv(Double* coord);
        internal unsafe static FogCoorddv glFogCoorddv = (FogCoorddv)Gl.GetDelegateForExtensionMethod("glFogCoorddv", typeof(FogCoorddv)) ?? new FogCoorddv(Imports.FogCoorddv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordPointer(int type, Int32 stride, void* pointer);
        internal unsafe static FogCoordPointer glFogCoordPointer = (FogCoordPointer)Gl.GetDelegateForExtensionMethod("glFogCoordPointer", typeof(FogCoordPointer)) ?? new FogCoordPointer(Imports.FogCoordPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawArrays(int mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
        internal unsafe static MultiDrawArrays glMultiDrawArrays = (MultiDrawArrays)Gl.GetDelegateForExtensionMethod("glMultiDrawArrays", typeof(MultiDrawArrays)) ?? new MultiDrawArrays(Imports.MultiDrawArrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElements(int mode, Int32* count, int type, void* indices, Int32 primcount);
        internal unsafe static MultiDrawElements glMultiDrawElements = (MultiDrawElements)Gl.GetDelegateForExtensionMethod("glMultiDrawElements", typeof(MultiDrawElements)) ?? new MultiDrawElements(Imports.MultiDrawElements);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterf(int pname, Single param);
        internal static PointParameterf glPointParameterf = (PointParameterf)Gl.GetDelegateForExtensionMethod("glPointParameterf", typeof(PointParameterf)) ?? new PointParameterf(Imports.PointParameterf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfv(int pname, Single* @params);
        internal unsafe static PointParameterfv glPointParameterfv = (PointParameterfv)Gl.GetDelegateForExtensionMethod("glPointParameterfv", typeof(PointParameterfv)) ?? new PointParameterfv(Imports.PointParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameteri(int pname, Int32 param);
        internal static PointParameteri glPointParameteri = (PointParameteri)Gl.GetDelegateForExtensionMethod("glPointParameteri", typeof(PointParameteri)) ?? new PointParameteri(Imports.PointParameteri);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameteriv(int pname, Int32* @params);
        internal unsafe static PointParameteriv glPointParameteriv = (PointParameteriv)Gl.GetDelegateForExtensionMethod("glPointParameteriv", typeof(PointParameteriv)) ?? new PointParameteriv(Imports.PointParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3b(SByte red, SByte green, SByte blue);
        internal static SecondaryColor3b glSecondaryColor3b = (SecondaryColor3b)Gl.GetDelegateForExtensionMethod("glSecondaryColor3b", typeof(SecondaryColor3b)) ?? new SecondaryColor3b(Imports.SecondaryColor3b);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3bv(SByte* v);
        internal unsafe static SecondaryColor3bv glSecondaryColor3bv = (SecondaryColor3bv)Gl.GetDelegateForExtensionMethod("glSecondaryColor3bv", typeof(SecondaryColor3bv)) ?? new SecondaryColor3bv(Imports.SecondaryColor3bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3d(Double red, Double green, Double blue);
        internal static SecondaryColor3d glSecondaryColor3d = (SecondaryColor3d)Gl.GetDelegateForExtensionMethod("glSecondaryColor3d", typeof(SecondaryColor3d)) ?? new SecondaryColor3d(Imports.SecondaryColor3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3dv(Double* v);
        internal unsafe static SecondaryColor3dv glSecondaryColor3dv = (SecondaryColor3dv)Gl.GetDelegateForExtensionMethod("glSecondaryColor3dv", typeof(SecondaryColor3dv)) ?? new SecondaryColor3dv(Imports.SecondaryColor3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3f(Single red, Single green, Single blue);
        internal static SecondaryColor3f glSecondaryColor3f = (SecondaryColor3f)Gl.GetDelegateForExtensionMethod("glSecondaryColor3f", typeof(SecondaryColor3f)) ?? new SecondaryColor3f(Imports.SecondaryColor3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3fv(Single* v);
        internal unsafe static SecondaryColor3fv glSecondaryColor3fv = (SecondaryColor3fv)Gl.GetDelegateForExtensionMethod("glSecondaryColor3fv", typeof(SecondaryColor3fv)) ?? new SecondaryColor3fv(Imports.SecondaryColor3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3i(Int32 red, Int32 green, Int32 blue);
        internal static SecondaryColor3i glSecondaryColor3i = (SecondaryColor3i)Gl.GetDelegateForExtensionMethod("glSecondaryColor3i", typeof(SecondaryColor3i)) ?? new SecondaryColor3i(Imports.SecondaryColor3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3iv(Int32* v);
        internal unsafe static SecondaryColor3iv glSecondaryColor3iv = (SecondaryColor3iv)Gl.GetDelegateForExtensionMethod("glSecondaryColor3iv", typeof(SecondaryColor3iv)) ?? new SecondaryColor3iv(Imports.SecondaryColor3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3s(Int16 red, Int16 green, Int16 blue);
        internal static SecondaryColor3s glSecondaryColor3s = (SecondaryColor3s)Gl.GetDelegateForExtensionMethod("glSecondaryColor3s", typeof(SecondaryColor3s)) ?? new SecondaryColor3s(Imports.SecondaryColor3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3sv(Int16* v);
        internal unsafe static SecondaryColor3sv glSecondaryColor3sv = (SecondaryColor3sv)Gl.GetDelegateForExtensionMethod("glSecondaryColor3sv", typeof(SecondaryColor3sv)) ?? new SecondaryColor3sv(Imports.SecondaryColor3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3ub(Byte red, Byte green, Byte blue);
        internal static SecondaryColor3ub glSecondaryColor3ub = (SecondaryColor3ub)Gl.GetDelegateForExtensionMethod("glSecondaryColor3ub", typeof(SecondaryColor3ub)) ?? new SecondaryColor3ub(Imports.SecondaryColor3ub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3ubv(Byte* v);
        internal unsafe static SecondaryColor3ubv glSecondaryColor3ubv = (SecondaryColor3ubv)Gl.GetDelegateForExtensionMethod("glSecondaryColor3ubv", typeof(SecondaryColor3ubv)) ?? new SecondaryColor3ubv(Imports.SecondaryColor3ubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
        internal static SecondaryColor3ui glSecondaryColor3ui = (SecondaryColor3ui)Gl.GetDelegateForExtensionMethod("glSecondaryColor3ui", typeof(SecondaryColor3ui)) ?? new SecondaryColor3ui(Imports.SecondaryColor3ui);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3uiv(UInt32* v);
        internal unsafe static SecondaryColor3uiv glSecondaryColor3uiv = (SecondaryColor3uiv)Gl.GetDelegateForExtensionMethod("glSecondaryColor3uiv", typeof(SecondaryColor3uiv)) ?? new SecondaryColor3uiv(Imports.SecondaryColor3uiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
        internal static SecondaryColor3us glSecondaryColor3us = (SecondaryColor3us)Gl.GetDelegateForExtensionMethod("glSecondaryColor3us", typeof(SecondaryColor3us)) ?? new SecondaryColor3us(Imports.SecondaryColor3us);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3usv(UInt16* v);
        internal unsafe static SecondaryColor3usv glSecondaryColor3usv = (SecondaryColor3usv)Gl.GetDelegateForExtensionMethod("glSecondaryColor3usv", typeof(SecondaryColor3usv)) ?? new SecondaryColor3usv(Imports.SecondaryColor3usv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColorPointer(Int32 size, int type, Int32 stride, void* pointer);
        internal unsafe static SecondaryColorPointer glSecondaryColorPointer = (SecondaryColorPointer)Gl.GetDelegateForExtensionMethod("glSecondaryColorPointer", typeof(SecondaryColorPointer)) ?? new SecondaryColorPointer(Imports.SecondaryColorPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2d(Double x, Double y);
        internal static WindowPos2d glWindowPos2d = (WindowPos2d)Gl.GetDelegateForExtensionMethod("glWindowPos2d", typeof(WindowPos2d)) ?? new WindowPos2d(Imports.WindowPos2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2dv(Double* v);
        internal unsafe static WindowPos2dv glWindowPos2dv = (WindowPos2dv)Gl.GetDelegateForExtensionMethod("glWindowPos2dv", typeof(WindowPos2dv)) ?? new WindowPos2dv(Imports.WindowPos2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2f(Single x, Single y);
        internal static WindowPos2f glWindowPos2f = (WindowPos2f)Gl.GetDelegateForExtensionMethod("glWindowPos2f", typeof(WindowPos2f)) ?? new WindowPos2f(Imports.WindowPos2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2fv(Single* v);
        internal unsafe static WindowPos2fv glWindowPos2fv = (WindowPos2fv)Gl.GetDelegateForExtensionMethod("glWindowPos2fv", typeof(WindowPos2fv)) ?? new WindowPos2fv(Imports.WindowPos2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2i(Int32 x, Int32 y);
        internal static WindowPos2i glWindowPos2i = (WindowPos2i)Gl.GetDelegateForExtensionMethod("glWindowPos2i", typeof(WindowPos2i)) ?? new WindowPos2i(Imports.WindowPos2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2iv(Int32* v);
        internal unsafe static WindowPos2iv glWindowPos2iv = (WindowPos2iv)Gl.GetDelegateForExtensionMethod("glWindowPos2iv", typeof(WindowPos2iv)) ?? new WindowPos2iv(Imports.WindowPos2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2s(Int16 x, Int16 y);
        internal static WindowPos2s glWindowPos2s = (WindowPos2s)Gl.GetDelegateForExtensionMethod("glWindowPos2s", typeof(WindowPos2s)) ?? new WindowPos2s(Imports.WindowPos2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2sv(Int16* v);
        internal unsafe static WindowPos2sv glWindowPos2sv = (WindowPos2sv)Gl.GetDelegateForExtensionMethod("glWindowPos2sv", typeof(WindowPos2sv)) ?? new WindowPos2sv(Imports.WindowPos2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3d(Double x, Double y, Double z);
        internal static WindowPos3d glWindowPos3d = (WindowPos3d)Gl.GetDelegateForExtensionMethod("glWindowPos3d", typeof(WindowPos3d)) ?? new WindowPos3d(Imports.WindowPos3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3dv(Double* v);
        internal unsafe static WindowPos3dv glWindowPos3dv = (WindowPos3dv)Gl.GetDelegateForExtensionMethod("glWindowPos3dv", typeof(WindowPos3dv)) ?? new WindowPos3dv(Imports.WindowPos3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3f(Single x, Single y, Single z);
        internal static WindowPos3f glWindowPos3f = (WindowPos3f)Gl.GetDelegateForExtensionMethod("glWindowPos3f", typeof(WindowPos3f)) ?? new WindowPos3f(Imports.WindowPos3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3fv(Single* v);
        internal unsafe static WindowPos3fv glWindowPos3fv = (WindowPos3fv)Gl.GetDelegateForExtensionMethod("glWindowPos3fv", typeof(WindowPos3fv)) ?? new WindowPos3fv(Imports.WindowPos3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3i(Int32 x, Int32 y, Int32 z);
        internal static WindowPos3i glWindowPos3i = (WindowPos3i)Gl.GetDelegateForExtensionMethod("glWindowPos3i", typeof(WindowPos3i)) ?? new WindowPos3i(Imports.WindowPos3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3iv(Int32* v);
        internal unsafe static WindowPos3iv glWindowPos3iv = (WindowPos3iv)Gl.GetDelegateForExtensionMethod("glWindowPos3iv", typeof(WindowPos3iv)) ?? new WindowPos3iv(Imports.WindowPos3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3s(Int16 x, Int16 y, Int16 z);
        internal static WindowPos3s glWindowPos3s = (WindowPos3s)Gl.GetDelegateForExtensionMethod("glWindowPos3s", typeof(WindowPos3s)) ?? new WindowPos3s(Imports.WindowPos3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3sv(Int16* v);
        internal unsafe static WindowPos3sv glWindowPos3sv = (WindowPos3sv)Gl.GetDelegateForExtensionMethod("glWindowPos3sv", typeof(WindowPos3sv)) ?? new WindowPos3sv(Imports.WindowPos3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenQueries(Int32 n, [Out] UInt32* ids);
        internal unsafe static GenQueries glGenQueries = (GenQueries)Gl.GetDelegateForExtensionMethod("glGenQueries", typeof(GenQueries)) ?? new GenQueries(Imports.GenQueries);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
        internal unsafe static DeleteQueries glDeleteQueries = (DeleteQueries)Gl.GetDelegateForExtensionMethod("glDeleteQueries", typeof(DeleteQueries)) ?? new DeleteQueries(Imports.DeleteQueries);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsQuery(UInt32 id);
        internal static IsQuery glIsQuery = (IsQuery)Gl.GetDelegateForExtensionMethod("glIsQuery", typeof(IsQuery)) ?? new IsQuery(Imports.IsQuery);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginQuery(int target, UInt32 id);
        internal static BeginQuery glBeginQuery = (BeginQuery)Gl.GetDelegateForExtensionMethod("glBeginQuery", typeof(BeginQuery)) ?? new BeginQuery(Imports.BeginQuery);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndQuery(int target);
        internal static EndQuery glEndQuery = (EndQuery)Gl.GetDelegateForExtensionMethod("glEndQuery", typeof(EndQuery)) ?? new EndQuery(Imports.EndQuery);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryiv(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetQueryiv glGetQueryiv = (GetQueryiv)Gl.GetDelegateForExtensionMethod("glGetQueryiv", typeof(GetQueryiv)) ?? new GetQueryiv(Imports.GetQueryiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectiv(UInt32 id, int pname, [Out] Int32* @params);
        internal unsafe static GetQueryObjectiv glGetQueryObjectiv = (GetQueryObjectiv)Gl.GetDelegateForExtensionMethod("glGetQueryObjectiv", typeof(GetQueryObjectiv)) ?? new GetQueryObjectiv(Imports.GetQueryObjectiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectuiv(UInt32 id, int pname, [Out] UInt32* @params);
        internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv = (GetQueryObjectuiv)Gl.GetDelegateForExtensionMethod("glGetQueryObjectuiv", typeof(GetQueryObjectuiv)) ?? new GetQueryObjectuiv(Imports.GetQueryObjectuiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBuffer(int target, UInt32 buffer);
        internal static BindBuffer glBindBuffer = (BindBuffer)Gl.GetDelegateForExtensionMethod("glBindBuffer", typeof(BindBuffer)) ?? new BindBuffer(Imports.BindBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
        internal unsafe static DeleteBuffers glDeleteBuffers = (DeleteBuffers)Gl.GetDelegateForExtensionMethod("glDeleteBuffers", typeof(DeleteBuffers)) ?? new DeleteBuffers(Imports.DeleteBuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenBuffers(Int32 n, [Out] UInt32* buffers);
        internal unsafe static GenBuffers glGenBuffers = (GenBuffers)Gl.GetDelegateForExtensionMethod("glGenBuffers", typeof(GenBuffers)) ?? new GenBuffers(Imports.GenBuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsBuffer(UInt32 buffer);
        internal static IsBuffer glIsBuffer = (IsBuffer)Gl.GetDelegateForExtensionMethod("glIsBuffer", typeof(IsBuffer)) ?? new IsBuffer(Imports.IsBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferData(int target, IntPtr size, void* data, int usage);
        internal unsafe static BufferData glBufferData = (BufferData)Gl.GetDelegateForExtensionMethod("glBufferData", typeof(BufferData)) ?? new BufferData(Imports.BufferData);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferSubData(int target, IntPtr offset, IntPtr size, void* data);
        internal unsafe static BufferSubData glBufferSubData = (BufferSubData)Gl.GetDelegateForExtensionMethod("glBufferSubData", typeof(BufferSubData)) ?? new BufferSubData(Imports.BufferSubData);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferSubData(int target, IntPtr offset, IntPtr size, [Out] void* data);
        internal unsafe static GetBufferSubData glGetBufferSubData = (GetBufferSubData)Gl.GetDelegateForExtensionMethod("glGetBufferSubData", typeof(GetBufferSubData)) ?? new GetBufferSubData(Imports.GetBufferSubData);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr MapBuffer(int target, int access);
        internal static MapBuffer glMapBuffer = (MapBuffer)Gl.GetDelegateForExtensionMethod("glMapBuffer", typeof(MapBuffer)) ?? new MapBuffer(Imports.MapBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int UnmapBuffer(int target);
        internal static UnmapBuffer glUnmapBuffer = (UnmapBuffer)Gl.GetDelegateForExtensionMethod("glUnmapBuffer", typeof(UnmapBuffer)) ?? new UnmapBuffer(Imports.UnmapBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferParameteriv(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetBufferParameteriv glGetBufferParameteriv = (GetBufferParameteriv)Gl.GetDelegateForExtensionMethod("glGetBufferParameteriv", typeof(GetBufferParameteriv)) ?? new GetBufferParameteriv(Imports.GetBufferParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferPointerv(int target, int pname, [Out] void* @params);
        internal unsafe static GetBufferPointerv glGetBufferPointerv = (GetBufferPointerv)Gl.GetDelegateForExtensionMethod("glGetBufferPointerv", typeof(GetBufferPointerv)) ?? new GetBufferPointerv(Imports.GetBufferPointerv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationSeparate(int modeRGB, int modeAlpha);
        internal static BlendEquationSeparate glBlendEquationSeparate = (BlendEquationSeparate)Gl.GetDelegateForExtensionMethod("glBlendEquationSeparate", typeof(BlendEquationSeparate)) ?? new BlendEquationSeparate(Imports.BlendEquationSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffers(Int32 n, int* bufs);
        internal unsafe static DrawBuffers glDrawBuffers = (DrawBuffers)Gl.GetDelegateForExtensionMethod("glDrawBuffers", typeof(DrawBuffers)) ?? new DrawBuffers(Imports.DrawBuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOpSeparate(int face, int sfail, int dpfail, int dppass);
        internal static StencilOpSeparate glStencilOpSeparate = (StencilOpSeparate)Gl.GetDelegateForExtensionMethod("glStencilOpSeparate", typeof(StencilOpSeparate)) ?? new StencilOpSeparate(Imports.StencilOpSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFuncSeparate(int frontfunc, int backfunc, Int32 @ref, UInt32 mask);
        internal static StencilFuncSeparate glStencilFuncSeparate = (StencilFuncSeparate)Gl.GetDelegateForExtensionMethod("glStencilFuncSeparate", typeof(StencilFuncSeparate)) ?? new StencilFuncSeparate(Imports.StencilFuncSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilMaskSeparate(int face, UInt32 mask);
        internal static StencilMaskSeparate glStencilMaskSeparate = (StencilMaskSeparate)Gl.GetDelegateForExtensionMethod("glStencilMaskSeparate", typeof(StencilMaskSeparate)) ?? new StencilMaskSeparate(Imports.StencilMaskSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AttachShader(UInt32 program, UInt32 shader);
        internal static AttachShader glAttachShader = (AttachShader)Gl.GetDelegateForExtensionMethod("glAttachShader", typeof(AttachShader)) ?? new AttachShader(Imports.AttachShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindAttribLocation(UInt32 program, UInt32 index, System.String name);
        internal static BindAttribLocation glBindAttribLocation = (BindAttribLocation)Gl.GetDelegateForExtensionMethod("glBindAttribLocation", typeof(BindAttribLocation)) ?? new BindAttribLocation(Imports.BindAttribLocation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompileShader(UInt32 shader);
        internal static CompileShader glCompileShader = (CompileShader)Gl.GetDelegateForExtensionMethod("glCompileShader", typeof(CompileShader)) ?? new CompileShader(Imports.CompileShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 CreateProgram();
        internal static CreateProgram glCreateProgram = (CreateProgram)Gl.GetDelegateForExtensionMethod("glCreateProgram", typeof(CreateProgram)) ?? new CreateProgram(Imports.CreateProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 CreateShader(int type);
        internal static CreateShader glCreateShader = (CreateShader)Gl.GetDelegateForExtensionMethod("glCreateShader", typeof(CreateShader)) ?? new CreateShader(Imports.CreateShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteProgram(UInt32 program);
        internal static DeleteProgram glDeleteProgram = (DeleteProgram)Gl.GetDelegateForExtensionMethod("glDeleteProgram", typeof(DeleteProgram)) ?? new DeleteProgram(Imports.DeleteProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteShader(UInt32 shader);
        internal static DeleteShader glDeleteShader = (DeleteShader)Gl.GetDelegateForExtensionMethod("glDeleteShader", typeof(DeleteShader)) ?? new DeleteShader(Imports.DeleteShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DetachShader(UInt32 program, UInt32 shader);
        internal static DetachShader glDetachShader = (DetachShader)Gl.GetDelegateForExtensionMethod("glDetachShader", typeof(DetachShader)) ?? new DetachShader(Imports.DetachShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVertexAttribArray(UInt32 index);
        internal static DisableVertexAttribArray glDisableVertexAttribArray = (DisableVertexAttribArray)Gl.GetDelegateForExtensionMethod("glDisableVertexAttribArray", typeof(DisableVertexAttribArray)) ?? new DisableVertexAttribArray(Imports.DisableVertexAttribArray);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVertexAttribArray(UInt32 index);
        internal static EnableVertexAttribArray glEnableVertexAttribArray = (EnableVertexAttribArray)Gl.GetDelegateForExtensionMethod("glEnableVertexAttribArray", typeof(EnableVertexAttribArray)) ?? new EnableVertexAttribArray(Imports.EnableVertexAttribArray);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveAttrib glGetActiveAttrib = (GetActiveAttrib)Gl.GetDelegateForExtensionMethod("glGetActiveAttrib", typeof(GetActiveAttrib)) ?? new GetActiveAttrib(Imports.GetActiveAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveUniform glGetActiveUniform = (GetActiveUniform)Gl.GetDelegateForExtensionMethod("glGetActiveUniform", typeof(GetActiveUniform)) ?? new GetActiveUniform(Imports.GetActiveUniform);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
        internal unsafe static GetAttachedShaders glGetAttachedShaders = (GetAttachedShaders)Gl.GetDelegateForExtensionMethod("glGetAttachedShaders", typeof(GetAttachedShaders)) ?? new GetAttachedShaders(Imports.GetAttachedShaders);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetAttribLocation(UInt32 program, System.String name);
        internal static GetAttribLocation glGetAttribLocation = (GetAttribLocation)Gl.GetDelegateForExtensionMethod("glGetAttribLocation", typeof(GetAttribLocation)) ?? new GetAttribLocation(Imports.GetAttribLocation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramiv(UInt32 program, int pname, [Out] Int32* @params);
        internal unsafe static GetProgramiv glGetProgramiv = (GetProgramiv)Gl.GetDelegateForExtensionMethod("glGetProgramiv", typeof(GetProgramiv)) ?? new GetProgramiv(Imports.GetProgramiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
        internal unsafe static GetProgramInfoLog glGetProgramInfoLog = (GetProgramInfoLog)Gl.GetDelegateForExtensionMethod("glGetProgramInfoLog", typeof(GetProgramInfoLog)) ?? new GetProgramInfoLog(Imports.GetProgramInfoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderiv(UInt32 shader, int pname, [Out] Int32* @params);
        internal unsafe static GetShaderiv glGetShaderiv = (GetShaderiv)Gl.GetDelegateForExtensionMethod("glGetShaderiv", typeof(GetShaderiv)) ?? new GetShaderiv(Imports.GetShaderiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
        internal unsafe static GetShaderInfoLog glGetShaderInfoLog = (GetShaderInfoLog)Gl.GetDelegateForExtensionMethod("glGetShaderInfoLog", typeof(GetShaderInfoLog)) ?? new GetShaderInfoLog(Imports.GetShaderInfoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
        internal unsafe static GetShaderSource glGetShaderSource = (GetShaderSource)Gl.GetDelegateForExtensionMethod("glGetShaderSource", typeof(GetShaderSource)) ?? new GetShaderSource(Imports.GetShaderSource);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetUniformLocation(UInt32 program, System.String name);
        internal static GetUniformLocation glGetUniformLocation = (GetUniformLocation)Gl.GetDelegateForExtensionMethod("glGetUniformLocation", typeof(GetUniformLocation)) ?? new GetUniformLocation(Imports.GetUniformLocation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [Out] Single* @params);
        internal unsafe static GetUniformfv glGetUniformfv = (GetUniformfv)Gl.GetDelegateForExtensionMethod("glGetUniformfv", typeof(GetUniformfv)) ?? new GetUniformfv(Imports.GetUniformfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [Out] Int32* @params);
        internal unsafe static GetUniformiv glGetUniformiv = (GetUniformiv)Gl.GetDelegateForExtensionMethod("glGetUniformiv", typeof(GetUniformiv)) ?? new GetUniformiv(Imports.GetUniformiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdv(UInt32 index, int pname, [Out] Double* @params);
        internal unsafe static GetVertexAttribdv glGetVertexAttribdv = (GetVertexAttribdv)Gl.GetDelegateForExtensionMethod("glGetVertexAttribdv", typeof(GetVertexAttribdv)) ?? new GetVertexAttribdv(Imports.GetVertexAttribdv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfv(UInt32 index, int pname, [Out] Single* @params);
        internal unsafe static GetVertexAttribfv glGetVertexAttribfv = (GetVertexAttribfv)Gl.GetDelegateForExtensionMethod("glGetVertexAttribfv", typeof(GetVertexAttribfv)) ?? new GetVertexAttribfv(Imports.GetVertexAttribfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribiv(UInt32 index, int pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribiv glGetVertexAttribiv = (GetVertexAttribiv)Gl.GetDelegateForExtensionMethod("glGetVertexAttribiv", typeof(GetVertexAttribiv)) ?? new GetVertexAttribiv(Imports.GetVertexAttribiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribPointerv(UInt32 index, int pname, [Out] void* pointer);
        internal unsafe static GetVertexAttribPointerv glGetVertexAttribPointerv = (GetVertexAttribPointerv)Gl.GetDelegateForExtensionMethod("glGetVertexAttribPointerv", typeof(GetVertexAttribPointerv)) ?? new GetVertexAttribPointerv(Imports.GetVertexAttribPointerv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsProgram(UInt32 program);
        internal static IsProgram glIsProgram = (IsProgram)Gl.GetDelegateForExtensionMethod("glIsProgram", typeof(IsProgram)) ?? new IsProgram(Imports.IsProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsShader(UInt32 shader);
        internal static IsShader glIsShader = (IsShader)Gl.GetDelegateForExtensionMethod("glIsShader", typeof(IsShader)) ?? new IsShader(Imports.IsShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LinkProgram(UInt32 program);
        internal static LinkProgram glLinkProgram = (LinkProgram)Gl.GetDelegateForExtensionMethod("glLinkProgram", typeof(LinkProgram)) ?? new LinkProgram(Imports.LinkProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, System.String[] @string, Int32* length);
        internal unsafe static ShaderSource glShaderSource = (ShaderSource)Gl.GetDelegateForExtensionMethod("glShaderSource", typeof(ShaderSource)) ?? new ShaderSource(Imports.ShaderSource);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UseProgram(UInt32 program);
        internal static UseProgram glUseProgram = (UseProgram)Gl.GetDelegateForExtensionMethod("glUseProgram", typeof(UseProgram)) ?? new UseProgram(Imports.UseProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1f(Int32 location, Single v0);
        internal static Uniform1f glUniform1f = (Uniform1f)Gl.GetDelegateForExtensionMethod("glUniform1f", typeof(Uniform1f)) ?? new Uniform1f(Imports.Uniform1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2f(Int32 location, Single v0, Single v1);
        internal static Uniform2f glUniform2f = (Uniform2f)Gl.GetDelegateForExtensionMethod("glUniform2f", typeof(Uniform2f)) ?? new Uniform2f(Imports.Uniform2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
        internal static Uniform3f glUniform3f = (Uniform3f)Gl.GetDelegateForExtensionMethod("glUniform3f", typeof(Uniform3f)) ?? new Uniform3f(Imports.Uniform3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
        internal static Uniform4f glUniform4f = (Uniform4f)Gl.GetDelegateForExtensionMethod("glUniform4f", typeof(Uniform4f)) ?? new Uniform4f(Imports.Uniform4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1i(Int32 location, Int32 v0);
        internal static Uniform1i glUniform1i = (Uniform1i)Gl.GetDelegateForExtensionMethod("glUniform1i", typeof(Uniform1i)) ?? new Uniform1i(Imports.Uniform1i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);
        internal static Uniform2i glUniform2i = (Uniform2i)Gl.GetDelegateForExtensionMethod("glUniform2i", typeof(Uniform2i)) ?? new Uniform2i(Imports.Uniform2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
        internal static Uniform3i glUniform3i = (Uniform3i)Gl.GetDelegateForExtensionMethod("glUniform3i", typeof(Uniform3i)) ?? new Uniform3i(Imports.Uniform3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
        internal static Uniform4i glUniform4i = (Uniform4i)Gl.GetDelegateForExtensionMethod("glUniform4i", typeof(Uniform4i)) ?? new Uniform4i(Imports.Uniform4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform1fv glUniform1fv = (Uniform1fv)Gl.GetDelegateForExtensionMethod("glUniform1fv", typeof(Uniform1fv)) ?? new Uniform1fv(Imports.Uniform1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform2fv glUniform2fv = (Uniform2fv)Gl.GetDelegateForExtensionMethod("glUniform2fv", typeof(Uniform2fv)) ?? new Uniform2fv(Imports.Uniform2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform3fv glUniform3fv = (Uniform3fv)Gl.GetDelegateForExtensionMethod("glUniform3fv", typeof(Uniform3fv)) ?? new Uniform3fv(Imports.Uniform3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform4fv glUniform4fv = (Uniform4fv)Gl.GetDelegateForExtensionMethod("glUniform4fv", typeof(Uniform4fv)) ?? new Uniform4fv(Imports.Uniform4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform1iv glUniform1iv = (Uniform1iv)Gl.GetDelegateForExtensionMethod("glUniform1iv", typeof(Uniform1iv)) ?? new Uniform1iv(Imports.Uniform1iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform2iv glUniform2iv = (Uniform2iv)Gl.GetDelegateForExtensionMethod("glUniform2iv", typeof(Uniform2iv)) ?? new Uniform2iv(Imports.Uniform2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform3iv glUniform3iv = (Uniform3iv)Gl.GetDelegateForExtensionMethod("glUniform3iv", typeof(Uniform3iv)) ?? new Uniform3iv(Imports.Uniform3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform4iv glUniform4iv = (Uniform4iv)Gl.GetDelegateForExtensionMethod("glUniform4iv", typeof(Uniform4iv)) ?? new Uniform4iv(Imports.Uniform4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix2fv glUniformMatrix2fv = (UniformMatrix2fv)Gl.GetDelegateForExtensionMethod("glUniformMatrix2fv", typeof(UniformMatrix2fv)) ?? new UniformMatrix2fv(Imports.UniformMatrix2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix3fv glUniformMatrix3fv = (UniformMatrix3fv)Gl.GetDelegateForExtensionMethod("glUniformMatrix3fv", typeof(UniformMatrix3fv)) ?? new UniformMatrix3fv(Imports.UniformMatrix3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix4fv glUniformMatrix4fv = (UniformMatrix4fv)Gl.GetDelegateForExtensionMethod("glUniformMatrix4fv", typeof(UniformMatrix4fv)) ?? new UniformMatrix4fv(Imports.UniformMatrix4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ValidateProgram(UInt32 program);
        internal static ValidateProgram glValidateProgram = (ValidateProgram)Gl.GetDelegateForExtensionMethod("glValidateProgram", typeof(ValidateProgram)) ?? new ValidateProgram(Imports.ValidateProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1d(UInt32 index, Double x);
        internal static VertexAttrib1d glVertexAttrib1d = (VertexAttrib1d)Gl.GetDelegateForExtensionMethod("glVertexAttrib1d", typeof(VertexAttrib1d)) ?? new VertexAttrib1d(Imports.VertexAttrib1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dv(UInt32 index, Double* v);
        internal unsafe static VertexAttrib1dv glVertexAttrib1dv = (VertexAttrib1dv)Gl.GetDelegateForExtensionMethod("glVertexAttrib1dv", typeof(VertexAttrib1dv)) ?? new VertexAttrib1dv(Imports.VertexAttrib1dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1f(UInt32 index, Single x);
        internal static VertexAttrib1f glVertexAttrib1f = (VertexAttrib1f)Gl.GetDelegateForExtensionMethod("glVertexAttrib1f", typeof(VertexAttrib1f)) ?? new VertexAttrib1f(Imports.VertexAttrib1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
        internal unsafe static VertexAttrib1fv glVertexAttrib1fv = (VertexAttrib1fv)Gl.GetDelegateForExtensionMethod("glVertexAttrib1fv", typeof(VertexAttrib1fv)) ?? new VertexAttrib1fv(Imports.VertexAttrib1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1s(UInt32 index, Int16 x);
        internal static VertexAttrib1s glVertexAttrib1s = (VertexAttrib1s)Gl.GetDelegateForExtensionMethod("glVertexAttrib1s", typeof(VertexAttrib1s)) ?? new VertexAttrib1s(Imports.VertexAttrib1s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1sv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib1sv glVertexAttrib1sv = (VertexAttrib1sv)Gl.GetDelegateForExtensionMethod("glVertexAttrib1sv", typeof(VertexAttrib1sv)) ?? new VertexAttrib1sv(Imports.VertexAttrib1sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2d(UInt32 index, Double x, Double y);
        internal static VertexAttrib2d glVertexAttrib2d = (VertexAttrib2d)Gl.GetDelegateForExtensionMethod("glVertexAttrib2d", typeof(VertexAttrib2d)) ?? new VertexAttrib2d(Imports.VertexAttrib2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dv(UInt32 index, Double* v);
        internal unsafe static VertexAttrib2dv glVertexAttrib2dv = (VertexAttrib2dv)Gl.GetDelegateForExtensionMethod("glVertexAttrib2dv", typeof(VertexAttrib2dv)) ?? new VertexAttrib2dv(Imports.VertexAttrib2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
        internal static VertexAttrib2f glVertexAttrib2f = (VertexAttrib2f)Gl.GetDelegateForExtensionMethod("glVertexAttrib2f", typeof(VertexAttrib2f)) ?? new VertexAttrib2f(Imports.VertexAttrib2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
        internal unsafe static VertexAttrib2fv glVertexAttrib2fv = (VertexAttrib2fv)Gl.GetDelegateForExtensionMethod("glVertexAttrib2fv", typeof(VertexAttrib2fv)) ?? new VertexAttrib2fv(Imports.VertexAttrib2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
        internal static VertexAttrib2s glVertexAttrib2s = (VertexAttrib2s)Gl.GetDelegateForExtensionMethod("glVertexAttrib2s", typeof(VertexAttrib2s)) ?? new VertexAttrib2s(Imports.VertexAttrib2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2sv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib2sv glVertexAttrib2sv = (VertexAttrib2sv)Gl.GetDelegateForExtensionMethod("glVertexAttrib2sv", typeof(VertexAttrib2sv)) ?? new VertexAttrib2sv(Imports.VertexAttrib2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
        internal static VertexAttrib3d glVertexAttrib3d = (VertexAttrib3d)Gl.GetDelegateForExtensionMethod("glVertexAttrib3d", typeof(VertexAttrib3d)) ?? new VertexAttrib3d(Imports.VertexAttrib3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dv(UInt32 index, Double* v);
        internal unsafe static VertexAttrib3dv glVertexAttrib3dv = (VertexAttrib3dv)Gl.GetDelegateForExtensionMethod("glVertexAttrib3dv", typeof(VertexAttrib3dv)) ?? new VertexAttrib3dv(Imports.VertexAttrib3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
        internal static VertexAttrib3f glVertexAttrib3f = (VertexAttrib3f)Gl.GetDelegateForExtensionMethod("glVertexAttrib3f", typeof(VertexAttrib3f)) ?? new VertexAttrib3f(Imports.VertexAttrib3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
        internal unsafe static VertexAttrib3fv glVertexAttrib3fv = (VertexAttrib3fv)Gl.GetDelegateForExtensionMethod("glVertexAttrib3fv", typeof(VertexAttrib3fv)) ?? new VertexAttrib3fv(Imports.VertexAttrib3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
        internal static VertexAttrib3s glVertexAttrib3s = (VertexAttrib3s)Gl.GetDelegateForExtensionMethod("glVertexAttrib3s", typeof(VertexAttrib3s)) ?? new VertexAttrib3s(Imports.VertexAttrib3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3sv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib3sv glVertexAttrib3sv = (VertexAttrib3sv)Gl.GetDelegateForExtensionMethod("glVertexAttrib3sv", typeof(VertexAttrib3sv)) ?? new VertexAttrib3sv(Imports.VertexAttrib3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nbv(UInt32 index, SByte* v);
        internal unsafe static VertexAttrib4Nbv glVertexAttrib4Nbv = (VertexAttrib4Nbv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4Nbv", typeof(VertexAttrib4Nbv)) ?? new VertexAttrib4Nbv(Imports.VertexAttrib4Nbv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Niv(UInt32 index, Int32* v);
        internal unsafe static VertexAttrib4Niv glVertexAttrib4Niv = (VertexAttrib4Niv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4Niv", typeof(VertexAttrib4Niv)) ?? new VertexAttrib4Niv(Imports.VertexAttrib4Niv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nsv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4Nsv glVertexAttrib4Nsv = (VertexAttrib4Nsv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4Nsv", typeof(VertexAttrib4Nsv)) ?? new VertexAttrib4Nsv(Imports.VertexAttrib4Nsv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
        internal static VertexAttrib4Nub glVertexAttrib4Nub = (VertexAttrib4Nub)Gl.GetDelegateForExtensionMethod("glVertexAttrib4Nub", typeof(VertexAttrib4Nub)) ?? new VertexAttrib4Nub(Imports.VertexAttrib4Nub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nubv(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4Nubv glVertexAttrib4Nubv = (VertexAttrib4Nubv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4Nubv", typeof(VertexAttrib4Nubv)) ?? new VertexAttrib4Nubv(Imports.VertexAttrib4Nubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
        internal unsafe static VertexAttrib4Nuiv glVertexAttrib4Nuiv = (VertexAttrib4Nuiv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4Nuiv", typeof(VertexAttrib4Nuiv)) ?? new VertexAttrib4Nuiv(Imports.VertexAttrib4Nuiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nusv(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4Nusv glVertexAttrib4Nusv = (VertexAttrib4Nusv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4Nusv", typeof(VertexAttrib4Nusv)) ?? new VertexAttrib4Nusv(Imports.VertexAttrib4Nusv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4bv(UInt32 index, SByte* v);
        internal unsafe static VertexAttrib4bv glVertexAttrib4bv = (VertexAttrib4bv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4bv", typeof(VertexAttrib4bv)) ?? new VertexAttrib4bv(Imports.VertexAttrib4bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
        internal static VertexAttrib4d glVertexAttrib4d = (VertexAttrib4d)Gl.GetDelegateForExtensionMethod("glVertexAttrib4d", typeof(VertexAttrib4d)) ?? new VertexAttrib4d(Imports.VertexAttrib4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dv(UInt32 index, Double* v);
        internal unsafe static VertexAttrib4dv glVertexAttrib4dv = (VertexAttrib4dv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4dv", typeof(VertexAttrib4dv)) ?? new VertexAttrib4dv(Imports.VertexAttrib4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
        internal static VertexAttrib4f glVertexAttrib4f = (VertexAttrib4f)Gl.GetDelegateForExtensionMethod("glVertexAttrib4f", typeof(VertexAttrib4f)) ?? new VertexAttrib4f(Imports.VertexAttrib4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
        internal unsafe static VertexAttrib4fv glVertexAttrib4fv = (VertexAttrib4fv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4fv", typeof(VertexAttrib4fv)) ?? new VertexAttrib4fv(Imports.VertexAttrib4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4iv(UInt32 index, Int32* v);
        internal unsafe static VertexAttrib4iv glVertexAttrib4iv = (VertexAttrib4iv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4iv", typeof(VertexAttrib4iv)) ?? new VertexAttrib4iv(Imports.VertexAttrib4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
        internal static VertexAttrib4s glVertexAttrib4s = (VertexAttrib4s)Gl.GetDelegateForExtensionMethod("glVertexAttrib4s", typeof(VertexAttrib4s)) ?? new VertexAttrib4s(Imports.VertexAttrib4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4sv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4sv glVertexAttrib4sv = (VertexAttrib4sv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4sv", typeof(VertexAttrib4sv)) ?? new VertexAttrib4sv(Imports.VertexAttrib4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubv(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4ubv glVertexAttrib4ubv = (VertexAttrib4ubv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4ubv", typeof(VertexAttrib4ubv)) ?? new VertexAttrib4ubv(Imports.VertexAttrib4ubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4uiv(UInt32 index, UInt32* v);
        internal unsafe static VertexAttrib4uiv glVertexAttrib4uiv = (VertexAttrib4uiv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4uiv", typeof(VertexAttrib4uiv)) ?? new VertexAttrib4uiv(Imports.VertexAttrib4uiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4usv(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4usv glVertexAttrib4usv = (VertexAttrib4usv)Gl.GetDelegateForExtensionMethod("glVertexAttrib4usv", typeof(VertexAttrib4usv)) ?? new VertexAttrib4usv(Imports.VertexAttrib4usv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribPointer(UInt32 index, Int32 size, int type, int normalized, Int32 stride, void* pointer);
        internal unsafe static VertexAttribPointer glVertexAttribPointer = (VertexAttribPointer)Gl.GetDelegateForExtensionMethod("glVertexAttribPointer", typeof(VertexAttribPointer)) ?? new VertexAttribPointer(Imports.VertexAttribPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv = (UniformMatrix2x3fv)Gl.GetDelegateForExtensionMethod("glUniformMatrix2x3fv", typeof(UniformMatrix2x3fv)) ?? new UniformMatrix2x3fv(Imports.UniformMatrix2x3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv = (UniformMatrix3x2fv)Gl.GetDelegateForExtensionMethod("glUniformMatrix3x2fv", typeof(UniformMatrix3x2fv)) ?? new UniformMatrix3x2fv(Imports.UniformMatrix3x2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv = (UniformMatrix2x4fv)Gl.GetDelegateForExtensionMethod("glUniformMatrix2x4fv", typeof(UniformMatrix2x4fv)) ?? new UniformMatrix2x4fv(Imports.UniformMatrix2x4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv = (UniformMatrix4x2fv)Gl.GetDelegateForExtensionMethod("glUniformMatrix4x2fv", typeof(UniformMatrix4x2fv)) ?? new UniformMatrix4x2fv(Imports.UniformMatrix4x2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv = (UniformMatrix3x4fv)Gl.GetDelegateForExtensionMethod("glUniformMatrix3x4fv", typeof(UniformMatrix3x4fv)) ?? new UniformMatrix3x4fv(Imports.UniformMatrix3x4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv = (UniformMatrix4x3fv)Gl.GetDelegateForExtensionMethod("glUniformMatrix4x3fv", typeof(UniformMatrix4x3fv)) ?? new UniformMatrix4x3fv(Imports.UniformMatrix4x3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveTextureARB(int texture);
        internal static ActiveTextureARB glActiveTextureARB = (ActiveTextureARB)Gl.GetDelegateForExtensionMethod("glActiveTextureARB", typeof(ActiveTextureARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClientActiveTextureARB(int texture);
        internal static ClientActiveTextureARB glClientActiveTextureARB = (ClientActiveTextureARB)Gl.GetDelegateForExtensionMethod("glClientActiveTextureARB", typeof(ClientActiveTextureARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1dARB(int target, Double s);
        internal static MultiTexCoord1dARB glMultiTexCoord1dARB = (MultiTexCoord1dARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1dARB", typeof(MultiTexCoord1dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1dvARB(int target, Double* v);
        internal unsafe static MultiTexCoord1dvARB glMultiTexCoord1dvARB = (MultiTexCoord1dvARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1dvARB", typeof(MultiTexCoord1dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1fARB(int target, Single s);
        internal static MultiTexCoord1fARB glMultiTexCoord1fARB = (MultiTexCoord1fARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1fARB", typeof(MultiTexCoord1fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1fvARB(int target, Single* v);
        internal unsafe static MultiTexCoord1fvARB glMultiTexCoord1fvARB = (MultiTexCoord1fvARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1fvARB", typeof(MultiTexCoord1fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1iARB(int target, Int32 s);
        internal static MultiTexCoord1iARB glMultiTexCoord1iARB = (MultiTexCoord1iARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1iARB", typeof(MultiTexCoord1iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1ivARB(int target, Int32* v);
        internal unsafe static MultiTexCoord1ivARB glMultiTexCoord1ivARB = (MultiTexCoord1ivARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1ivARB", typeof(MultiTexCoord1ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1sARB(int target, Int16 s);
        internal static MultiTexCoord1sARB glMultiTexCoord1sARB = (MultiTexCoord1sARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1sARB", typeof(MultiTexCoord1sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1svARB(int target, Int16* v);
        internal unsafe static MultiTexCoord1svARB glMultiTexCoord1svARB = (MultiTexCoord1svARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1svARB", typeof(MultiTexCoord1svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2dARB(int target, Double s, Double t);
        internal static MultiTexCoord2dARB glMultiTexCoord2dARB = (MultiTexCoord2dARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2dARB", typeof(MultiTexCoord2dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2dvARB(int target, Double* v);
        internal unsafe static MultiTexCoord2dvARB glMultiTexCoord2dvARB = (MultiTexCoord2dvARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2dvARB", typeof(MultiTexCoord2dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2fARB(int target, Single s, Single t);
        internal static MultiTexCoord2fARB glMultiTexCoord2fARB = (MultiTexCoord2fARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2fARB", typeof(MultiTexCoord2fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2fvARB(int target, Single* v);
        internal unsafe static MultiTexCoord2fvARB glMultiTexCoord2fvARB = (MultiTexCoord2fvARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2fvARB", typeof(MultiTexCoord2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2iARB(int target, Int32 s, Int32 t);
        internal static MultiTexCoord2iARB glMultiTexCoord2iARB = (MultiTexCoord2iARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2iARB", typeof(MultiTexCoord2iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2ivARB(int target, Int32* v);
        internal unsafe static MultiTexCoord2ivARB glMultiTexCoord2ivARB = (MultiTexCoord2ivARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2ivARB", typeof(MultiTexCoord2ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2sARB(int target, Int16 s, Int16 t);
        internal static MultiTexCoord2sARB glMultiTexCoord2sARB = (MultiTexCoord2sARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2sARB", typeof(MultiTexCoord2sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2svARB(int target, Int16* v);
        internal unsafe static MultiTexCoord2svARB glMultiTexCoord2svARB = (MultiTexCoord2svARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2svARB", typeof(MultiTexCoord2svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3dARB(int target, Double s, Double t, Double r);
        internal static MultiTexCoord3dARB glMultiTexCoord3dARB = (MultiTexCoord3dARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3dARB", typeof(MultiTexCoord3dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3dvARB(int target, Double* v);
        internal unsafe static MultiTexCoord3dvARB glMultiTexCoord3dvARB = (MultiTexCoord3dvARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3dvARB", typeof(MultiTexCoord3dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3fARB(int target, Single s, Single t, Single r);
        internal static MultiTexCoord3fARB glMultiTexCoord3fARB = (MultiTexCoord3fARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3fARB", typeof(MultiTexCoord3fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3fvARB(int target, Single* v);
        internal unsafe static MultiTexCoord3fvARB glMultiTexCoord3fvARB = (MultiTexCoord3fvARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3fvARB", typeof(MultiTexCoord3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3iARB(int target, Int32 s, Int32 t, Int32 r);
        internal static MultiTexCoord3iARB glMultiTexCoord3iARB = (MultiTexCoord3iARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3iARB", typeof(MultiTexCoord3iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3ivARB(int target, Int32* v);
        internal unsafe static MultiTexCoord3ivARB glMultiTexCoord3ivARB = (MultiTexCoord3ivARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3ivARB", typeof(MultiTexCoord3ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3sARB(int target, Int16 s, Int16 t, Int16 r);
        internal static MultiTexCoord3sARB glMultiTexCoord3sARB = (MultiTexCoord3sARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3sARB", typeof(MultiTexCoord3sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3svARB(int target, Int16* v);
        internal unsafe static MultiTexCoord3svARB glMultiTexCoord3svARB = (MultiTexCoord3svARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3svARB", typeof(MultiTexCoord3svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4dARB(int target, Double s, Double t, Double r, Double q);
        internal static MultiTexCoord4dARB glMultiTexCoord4dARB = (MultiTexCoord4dARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4dARB", typeof(MultiTexCoord4dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4dvARB(int target, Double* v);
        internal unsafe static MultiTexCoord4dvARB glMultiTexCoord4dvARB = (MultiTexCoord4dvARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4dvARB", typeof(MultiTexCoord4dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4fARB(int target, Single s, Single t, Single r, Single q);
        internal static MultiTexCoord4fARB glMultiTexCoord4fARB = (MultiTexCoord4fARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4fARB", typeof(MultiTexCoord4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4fvARB(int target, Single* v);
        internal unsafe static MultiTexCoord4fvARB glMultiTexCoord4fvARB = (MultiTexCoord4fvARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4fvARB", typeof(MultiTexCoord4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4iARB(int target, Int32 s, Int32 t, Int32 r, Int32 q);
        internal static MultiTexCoord4iARB glMultiTexCoord4iARB = (MultiTexCoord4iARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4iARB", typeof(MultiTexCoord4iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4ivARB(int target, Int32* v);
        internal unsafe static MultiTexCoord4ivARB glMultiTexCoord4ivARB = (MultiTexCoord4ivARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4ivARB", typeof(MultiTexCoord4ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4sARB(int target, Int16 s, Int16 t, Int16 r, Int16 q);
        internal static MultiTexCoord4sARB glMultiTexCoord4sARB = (MultiTexCoord4sARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4sARB", typeof(MultiTexCoord4sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4svARB(int target, Int16* v);
        internal unsafe static MultiTexCoord4svARB glMultiTexCoord4svARB = (MultiTexCoord4svARB)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4svARB", typeof(MultiTexCoord4svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixfARB(Single* m);
        internal unsafe static LoadTransposeMatrixfARB glLoadTransposeMatrixfARB = (LoadTransposeMatrixfARB)Gl.GetDelegateForExtensionMethod("glLoadTransposeMatrixfARB", typeof(LoadTransposeMatrixfARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixdARB(Double* m);
        internal unsafe static LoadTransposeMatrixdARB glLoadTransposeMatrixdARB = (LoadTransposeMatrixdARB)Gl.GetDelegateForExtensionMethod("glLoadTransposeMatrixdARB", typeof(LoadTransposeMatrixdARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixfARB(Single* m);
        internal unsafe static MultTransposeMatrixfARB glMultTransposeMatrixfARB = (MultTransposeMatrixfARB)Gl.GetDelegateForExtensionMethod("glMultTransposeMatrixfARB", typeof(MultTransposeMatrixfARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixdARB(Double* m);
        internal unsafe static MultTransposeMatrixdARB glMultTransposeMatrixdARB = (MultTransposeMatrixdARB)Gl.GetDelegateForExtensionMethod("glMultTransposeMatrixdARB", typeof(MultTransposeMatrixdARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleCoverageARB(Single value, int invert);
        internal static SampleCoverageARB glSampleCoverageARB = (SampleCoverageARB)Gl.GetDelegateForExtensionMethod("glSampleCoverageARB", typeof(SampleCoverageARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage3DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage3DARB glCompressedTexImage3DARB = (CompressedTexImage3DARB)Gl.GetDelegateForExtensionMethod("glCompressedTexImage3DARB", typeof(CompressedTexImage3DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage2DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage2DARB glCompressedTexImage2DARB = (CompressedTexImage2DARB)Gl.GetDelegateForExtensionMethod("glCompressedTexImage2DARB", typeof(CompressedTexImage2DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage1DARB(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage1DARB glCompressedTexImage1DARB = (CompressedTexImage1DARB)Gl.GetDelegateForExtensionMethod("glCompressedTexImage1DARB", typeof(CompressedTexImage1DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage3DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage3DARB glCompressedTexSubImage3DARB = (CompressedTexSubImage3DARB)Gl.GetDelegateForExtensionMethod("glCompressedTexSubImage3DARB", typeof(CompressedTexSubImage3DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage2DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage2DARB glCompressedTexSubImage2DARB = (CompressedTexSubImage2DARB)Gl.GetDelegateForExtensionMethod("glCompressedTexSubImage2DARB", typeof(CompressedTexSubImage2DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage1DARB(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage1DARB glCompressedTexSubImage1DARB = (CompressedTexSubImage1DARB)Gl.GetDelegateForExtensionMethod("glCompressedTexSubImage1DARB", typeof(CompressedTexSubImage1DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCompressedTexImageARB(int target, Int32 level, [Out] void* img);
        internal unsafe static GetCompressedTexImageARB glGetCompressedTexImageARB = (GetCompressedTexImageARB)Gl.GetDelegateForExtensionMethod("glGetCompressedTexImageARB", typeof(GetCompressedTexImageARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterfARB(int pname, Single param);
        internal static PointParameterfARB glPointParameterfARB = (PointParameterfARB)Gl.GetDelegateForExtensionMethod("glPointParameterfARB", typeof(PointParameterfARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvARB(int pname, Single* @params);
        internal unsafe static PointParameterfvARB glPointParameterfvARB = (PointParameterfvARB)Gl.GetDelegateForExtensionMethod("glPointParameterfvARB", typeof(PointParameterfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightbvARB(Int32 size, SByte* weights);
        internal unsafe static WeightbvARB glWeightbvARB = (WeightbvARB)Gl.GetDelegateForExtensionMethod("glWeightbvARB", typeof(WeightbvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightsvARB(Int32 size, Int16* weights);
        internal unsafe static WeightsvARB glWeightsvARB = (WeightsvARB)Gl.GetDelegateForExtensionMethod("glWeightsvARB", typeof(WeightsvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightivARB(Int32 size, Int32* weights);
        internal unsafe static WeightivARB glWeightivARB = (WeightivARB)Gl.GetDelegateForExtensionMethod("glWeightivARB", typeof(WeightivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightfvARB(Int32 size, Single* weights);
        internal unsafe static WeightfvARB glWeightfvARB = (WeightfvARB)Gl.GetDelegateForExtensionMethod("glWeightfvARB", typeof(WeightfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightdvARB(Int32 size, Double* weights);
        internal unsafe static WeightdvARB glWeightdvARB = (WeightdvARB)Gl.GetDelegateForExtensionMethod("glWeightdvARB", typeof(WeightdvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightubvARB(Int32 size, Byte* weights);
        internal unsafe static WeightubvARB glWeightubvARB = (WeightubvARB)Gl.GetDelegateForExtensionMethod("glWeightubvARB", typeof(WeightubvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightusvARB(Int32 size, UInt16* weights);
        internal unsafe static WeightusvARB glWeightusvARB = (WeightusvARB)Gl.GetDelegateForExtensionMethod("glWeightusvARB", typeof(WeightusvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightuivARB(Int32 size, UInt32* weights);
        internal unsafe static WeightuivARB glWeightuivARB = (WeightuivARB)Gl.GetDelegateForExtensionMethod("glWeightuivARB", typeof(WeightuivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightPointerARB(Int32 size, int type, Int32 stride, void* pointer);
        internal unsafe static WeightPointerARB glWeightPointerARB = (WeightPointerARB)Gl.GetDelegateForExtensionMethod("glWeightPointerARB", typeof(WeightPointerARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBlendARB(Int32 count);
        internal static VertexBlendARB glVertexBlendARB = (VertexBlendARB)Gl.GetDelegateForExtensionMethod("glVertexBlendARB", typeof(VertexBlendARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CurrentPaletteMatrixARB(Int32 index);
        internal static CurrentPaletteMatrixARB glCurrentPaletteMatrixARB = (CurrentPaletteMatrixARB)Gl.GetDelegateForExtensionMethod("glCurrentPaletteMatrixARB", typeof(CurrentPaletteMatrixARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexubvARB(Int32 size, Byte* indices);
        internal unsafe static MatrixIndexubvARB glMatrixIndexubvARB = (MatrixIndexubvARB)Gl.GetDelegateForExtensionMethod("glMatrixIndexubvARB", typeof(MatrixIndexubvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexusvARB(Int32 size, UInt16* indices);
        internal unsafe static MatrixIndexusvARB glMatrixIndexusvARB = (MatrixIndexusvARB)Gl.GetDelegateForExtensionMethod("glMatrixIndexusvARB", typeof(MatrixIndexusvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexuivARB(Int32 size, UInt32* indices);
        internal unsafe static MatrixIndexuivARB glMatrixIndexuivARB = (MatrixIndexuivARB)Gl.GetDelegateForExtensionMethod("glMatrixIndexuivARB", typeof(MatrixIndexuivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexPointerARB(Int32 size, int type, Int32 stride, void* pointer);
        internal unsafe static MatrixIndexPointerARB glMatrixIndexPointerARB = (MatrixIndexPointerARB)Gl.GetDelegateForExtensionMethod("glMatrixIndexPointerARB", typeof(MatrixIndexPointerARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2dARB(Double x, Double y);
        internal static WindowPos2dARB glWindowPos2dARB = (WindowPos2dARB)Gl.GetDelegateForExtensionMethod("glWindowPos2dARB", typeof(WindowPos2dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2dvARB(Double* v);
        internal unsafe static WindowPos2dvARB glWindowPos2dvARB = (WindowPos2dvARB)Gl.GetDelegateForExtensionMethod("glWindowPos2dvARB", typeof(WindowPos2dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2fARB(Single x, Single y);
        internal static WindowPos2fARB glWindowPos2fARB = (WindowPos2fARB)Gl.GetDelegateForExtensionMethod("glWindowPos2fARB", typeof(WindowPos2fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2fvARB(Single* v);
        internal unsafe static WindowPos2fvARB glWindowPos2fvARB = (WindowPos2fvARB)Gl.GetDelegateForExtensionMethod("glWindowPos2fvARB", typeof(WindowPos2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2iARB(Int32 x, Int32 y);
        internal static WindowPos2iARB glWindowPos2iARB = (WindowPos2iARB)Gl.GetDelegateForExtensionMethod("glWindowPos2iARB", typeof(WindowPos2iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2ivARB(Int32* v);
        internal unsafe static WindowPos2ivARB glWindowPos2ivARB = (WindowPos2ivARB)Gl.GetDelegateForExtensionMethod("glWindowPos2ivARB", typeof(WindowPos2ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2sARB(Int16 x, Int16 y);
        internal static WindowPos2sARB glWindowPos2sARB = (WindowPos2sARB)Gl.GetDelegateForExtensionMethod("glWindowPos2sARB", typeof(WindowPos2sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2svARB(Int16* v);
        internal unsafe static WindowPos2svARB glWindowPos2svARB = (WindowPos2svARB)Gl.GetDelegateForExtensionMethod("glWindowPos2svARB", typeof(WindowPos2svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3dARB(Double x, Double y, Double z);
        internal static WindowPos3dARB glWindowPos3dARB = (WindowPos3dARB)Gl.GetDelegateForExtensionMethod("glWindowPos3dARB", typeof(WindowPos3dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3dvARB(Double* v);
        internal unsafe static WindowPos3dvARB glWindowPos3dvARB = (WindowPos3dvARB)Gl.GetDelegateForExtensionMethod("glWindowPos3dvARB", typeof(WindowPos3dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3fARB(Single x, Single y, Single z);
        internal static WindowPos3fARB glWindowPos3fARB = (WindowPos3fARB)Gl.GetDelegateForExtensionMethod("glWindowPos3fARB", typeof(WindowPos3fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3fvARB(Single* v);
        internal unsafe static WindowPos3fvARB glWindowPos3fvARB = (WindowPos3fvARB)Gl.GetDelegateForExtensionMethod("glWindowPos3fvARB", typeof(WindowPos3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3iARB(Int32 x, Int32 y, Int32 z);
        internal static WindowPos3iARB glWindowPos3iARB = (WindowPos3iARB)Gl.GetDelegateForExtensionMethod("glWindowPos3iARB", typeof(WindowPos3iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3ivARB(Int32* v);
        internal unsafe static WindowPos3ivARB glWindowPos3ivARB = (WindowPos3ivARB)Gl.GetDelegateForExtensionMethod("glWindowPos3ivARB", typeof(WindowPos3ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3sARB(Int16 x, Int16 y, Int16 z);
        internal static WindowPos3sARB glWindowPos3sARB = (WindowPos3sARB)Gl.GetDelegateForExtensionMethod("glWindowPos3sARB", typeof(WindowPos3sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3svARB(Int16* v);
        internal unsafe static WindowPos3svARB glWindowPos3svARB = (WindowPos3svARB)Gl.GetDelegateForExtensionMethod("glWindowPos3svARB", typeof(WindowPos3svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1dARB(UInt32 index, Double x);
        internal static VertexAttrib1dARB glVertexAttrib1dARB = (VertexAttrib1dARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib1dARB", typeof(VertexAttrib1dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dvARB(UInt32 index, Double* v);
        internal unsafe static VertexAttrib1dvARB glVertexAttrib1dvARB = (VertexAttrib1dvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib1dvARB", typeof(VertexAttrib1dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1fARB(UInt32 index, Single x);
        internal static VertexAttrib1fARB glVertexAttrib1fARB = (VertexAttrib1fARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib1fARB", typeof(VertexAttrib1fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fvARB(UInt32 index, Single* v);
        internal unsafe static VertexAttrib1fvARB glVertexAttrib1fvARB = (VertexAttrib1fvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib1fvARB", typeof(VertexAttrib1fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1sARB(UInt32 index, Int16 x);
        internal static VertexAttrib1sARB glVertexAttrib1sARB = (VertexAttrib1sARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib1sARB", typeof(VertexAttrib1sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1svARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib1svARB glVertexAttrib1svARB = (VertexAttrib1svARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib1svARB", typeof(VertexAttrib1svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2dARB(UInt32 index, Double x, Double y);
        internal static VertexAttrib2dARB glVertexAttrib2dARB = (VertexAttrib2dARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib2dARB", typeof(VertexAttrib2dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dvARB(UInt32 index, Double* v);
        internal unsafe static VertexAttrib2dvARB glVertexAttrib2dvARB = (VertexAttrib2dvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib2dvARB", typeof(VertexAttrib2dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2fARB(UInt32 index, Single x, Single y);
        internal static VertexAttrib2fARB glVertexAttrib2fARB = (VertexAttrib2fARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib2fARB", typeof(VertexAttrib2fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fvARB(UInt32 index, Single* v);
        internal unsafe static VertexAttrib2fvARB glVertexAttrib2fvARB = (VertexAttrib2fvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib2fvARB", typeof(VertexAttrib2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2sARB(UInt32 index, Int16 x, Int16 y);
        internal static VertexAttrib2sARB glVertexAttrib2sARB = (VertexAttrib2sARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib2sARB", typeof(VertexAttrib2sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2svARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib2svARB glVertexAttrib2svARB = (VertexAttrib2svARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib2svARB", typeof(VertexAttrib2svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3dARB(UInt32 index, Double x, Double y, Double z);
        internal static VertexAttrib3dARB glVertexAttrib3dARB = (VertexAttrib3dARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib3dARB", typeof(VertexAttrib3dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dvARB(UInt32 index, Double* v);
        internal unsafe static VertexAttrib3dvARB glVertexAttrib3dvARB = (VertexAttrib3dvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib3dvARB", typeof(VertexAttrib3dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3fARB(UInt32 index, Single x, Single y, Single z);
        internal static VertexAttrib3fARB glVertexAttrib3fARB = (VertexAttrib3fARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib3fARB", typeof(VertexAttrib3fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fvARB(UInt32 index, Single* v);
        internal unsafe static VertexAttrib3fvARB glVertexAttrib3fvARB = (VertexAttrib3fvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib3fvARB", typeof(VertexAttrib3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3sARB(UInt32 index, Int16 x, Int16 y, Int16 z);
        internal static VertexAttrib3sARB glVertexAttrib3sARB = (VertexAttrib3sARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib3sARB", typeof(VertexAttrib3sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3svARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib3svARB glVertexAttrib3svARB = (VertexAttrib3svARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib3svARB", typeof(VertexAttrib3svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NbvARB(UInt32 index, SByte* v);
        internal unsafe static VertexAttrib4NbvARB glVertexAttrib4NbvARB = (VertexAttrib4NbvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4NbvARB", typeof(VertexAttrib4NbvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NivARB(UInt32 index, Int32* v);
        internal unsafe static VertexAttrib4NivARB glVertexAttrib4NivARB = (VertexAttrib4NivARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4NivARB", typeof(VertexAttrib4NivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NsvARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4NsvARB glVertexAttrib4NsvARB = (VertexAttrib4NsvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4NsvARB", typeof(VertexAttrib4NsvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4NubARB(UInt32 index, Byte x, Byte y, Byte z, Byte w);
        internal static VertexAttrib4NubARB glVertexAttrib4NubARB = (VertexAttrib4NubARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4NubARB", typeof(VertexAttrib4NubARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NubvARB(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4NubvARB glVertexAttrib4NubvARB = (VertexAttrib4NubvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4NubvARB", typeof(VertexAttrib4NubvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NuivARB(UInt32 index, UInt32* v);
        internal unsafe static VertexAttrib4NuivARB glVertexAttrib4NuivARB = (VertexAttrib4NuivARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4NuivARB", typeof(VertexAttrib4NuivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NusvARB(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4NusvARB glVertexAttrib4NusvARB = (VertexAttrib4NusvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4NusvARB", typeof(VertexAttrib4NusvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4bvARB(UInt32 index, SByte* v);
        internal unsafe static VertexAttrib4bvARB glVertexAttrib4bvARB = (VertexAttrib4bvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4bvARB", typeof(VertexAttrib4bvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4dARB(UInt32 index, Double x, Double y, Double z, Double w);
        internal static VertexAttrib4dARB glVertexAttrib4dARB = (VertexAttrib4dARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4dARB", typeof(VertexAttrib4dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dvARB(UInt32 index, Double* v);
        internal unsafe static VertexAttrib4dvARB glVertexAttrib4dvARB = (VertexAttrib4dvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4dvARB", typeof(VertexAttrib4dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4fARB(UInt32 index, Single x, Single y, Single z, Single w);
        internal static VertexAttrib4fARB glVertexAttrib4fARB = (VertexAttrib4fARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4fARB", typeof(VertexAttrib4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fvARB(UInt32 index, Single* v);
        internal unsafe static VertexAttrib4fvARB glVertexAttrib4fvARB = (VertexAttrib4fvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4fvARB", typeof(VertexAttrib4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ivARB(UInt32 index, Int32* v);
        internal unsafe static VertexAttrib4ivARB glVertexAttrib4ivARB = (VertexAttrib4ivARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4ivARB", typeof(VertexAttrib4ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4sARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
        internal static VertexAttrib4sARB glVertexAttrib4sARB = (VertexAttrib4sARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4sARB", typeof(VertexAttrib4sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4svARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4svARB glVertexAttrib4svARB = (VertexAttrib4svARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4svARB", typeof(VertexAttrib4svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubvARB(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4ubvARB glVertexAttrib4ubvARB = (VertexAttrib4ubvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4ubvARB", typeof(VertexAttrib4ubvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4uivARB(UInt32 index, UInt32* v);
        internal unsafe static VertexAttrib4uivARB glVertexAttrib4uivARB = (VertexAttrib4uivARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4uivARB", typeof(VertexAttrib4uivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4usvARB(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4usvARB glVertexAttrib4usvARB = (VertexAttrib4usvARB)Gl.GetDelegateForExtensionMethod("glVertexAttrib4usvARB", typeof(VertexAttrib4usvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribPointerARB(UInt32 index, Int32 size, int type, int normalized, Int32 stride, void* pointer);
        internal unsafe static VertexAttribPointerARB glVertexAttribPointerARB = (VertexAttribPointerARB)Gl.GetDelegateForExtensionMethod("glVertexAttribPointerARB", typeof(VertexAttribPointerARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVertexAttribArrayARB(UInt32 index);
        internal static EnableVertexAttribArrayARB glEnableVertexAttribArrayARB = (EnableVertexAttribArrayARB)Gl.GetDelegateForExtensionMethod("glEnableVertexAttribArrayARB", typeof(EnableVertexAttribArrayARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVertexAttribArrayARB(UInt32 index);
        internal static DisableVertexAttribArrayARB glDisableVertexAttribArrayARB = (DisableVertexAttribArrayARB)Gl.GetDelegateForExtensionMethod("glDisableVertexAttribArrayARB", typeof(DisableVertexAttribArrayARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramStringARB(int target, int format, Int32 len, void* @string);
        internal unsafe static ProgramStringARB glProgramStringARB = (ProgramStringARB)Gl.GetDelegateForExtensionMethod("glProgramStringARB", typeof(ProgramStringARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindProgramARB(int target, UInt32 program);
        internal static BindProgramARB glBindProgramARB = (BindProgramARB)Gl.GetDelegateForExtensionMethod("glBindProgramARB", typeof(BindProgramARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteProgramsARB(Int32 n, UInt32* programs);
        internal unsafe static DeleteProgramsARB glDeleteProgramsARB = (DeleteProgramsARB)Gl.GetDelegateForExtensionMethod("glDeleteProgramsARB", typeof(DeleteProgramsARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenProgramsARB(Int32 n, [Out] UInt32* programs);
        internal unsafe static GenProgramsARB glGenProgramsARB = (GenProgramsARB)Gl.GetDelegateForExtensionMethod("glGenProgramsARB", typeof(GenProgramsARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameter4dARB(int target, UInt32 index, Double x, Double y, Double z, Double w);
        internal static ProgramEnvParameter4dARB glProgramEnvParameter4dARB = (ProgramEnvParameter4dARB)Gl.GetDelegateForExtensionMethod("glProgramEnvParameter4dARB", typeof(ProgramEnvParameter4dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameter4dvARB(int target, UInt32 index, Double* @params);
        internal unsafe static ProgramEnvParameter4dvARB glProgramEnvParameter4dvARB = (ProgramEnvParameter4dvARB)Gl.GetDelegateForExtensionMethod("glProgramEnvParameter4dvARB", typeof(ProgramEnvParameter4dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameter4fARB(int target, UInt32 index, Single x, Single y, Single z, Single w);
        internal static ProgramEnvParameter4fARB glProgramEnvParameter4fARB = (ProgramEnvParameter4fARB)Gl.GetDelegateForExtensionMethod("glProgramEnvParameter4fARB", typeof(ProgramEnvParameter4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameter4fvARB(int target, UInt32 index, Single* @params);
        internal unsafe static ProgramEnvParameter4fvARB glProgramEnvParameter4fvARB = (ProgramEnvParameter4fvARB)Gl.GetDelegateForExtensionMethod("glProgramEnvParameter4fvARB", typeof(ProgramEnvParameter4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameter4dARB(int target, UInt32 index, Double x, Double y, Double z, Double w);
        internal static ProgramLocalParameter4dARB glProgramLocalParameter4dARB = (ProgramLocalParameter4dARB)Gl.GetDelegateForExtensionMethod("glProgramLocalParameter4dARB", typeof(ProgramLocalParameter4dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameter4dvARB(int target, UInt32 index, Double* @params);
        internal unsafe static ProgramLocalParameter4dvARB glProgramLocalParameter4dvARB = (ProgramLocalParameter4dvARB)Gl.GetDelegateForExtensionMethod("glProgramLocalParameter4dvARB", typeof(ProgramLocalParameter4dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameter4fARB(int target, UInt32 index, Single x, Single y, Single z, Single w);
        internal static ProgramLocalParameter4fARB glProgramLocalParameter4fARB = (ProgramLocalParameter4fARB)Gl.GetDelegateForExtensionMethod("glProgramLocalParameter4fARB", typeof(ProgramLocalParameter4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameter4fvARB(int target, UInt32 index, Single* @params);
        internal unsafe static ProgramLocalParameter4fvARB glProgramLocalParameter4fvARB = (ProgramLocalParameter4fvARB)Gl.GetDelegateForExtensionMethod("glProgramLocalParameter4fvARB", typeof(ProgramLocalParameter4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterdvARB(int target, UInt32 index, [Out] Double* @params);
        internal unsafe static GetProgramEnvParameterdvARB glGetProgramEnvParameterdvARB = (GetProgramEnvParameterdvARB)Gl.GetDelegateForExtensionMethod("glGetProgramEnvParameterdvARB", typeof(GetProgramEnvParameterdvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterfvARB(int target, UInt32 index, [Out] Single* @params);
        internal unsafe static GetProgramEnvParameterfvARB glGetProgramEnvParameterfvARB = (GetProgramEnvParameterfvARB)Gl.GetDelegateForExtensionMethod("glGetProgramEnvParameterfvARB", typeof(GetProgramEnvParameterfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterdvARB(int target, UInt32 index, [Out] Double* @params);
        internal unsafe static GetProgramLocalParameterdvARB glGetProgramLocalParameterdvARB = (GetProgramLocalParameterdvARB)Gl.GetDelegateForExtensionMethod("glGetProgramLocalParameterdvARB", typeof(GetProgramLocalParameterdvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterfvARB(int target, UInt32 index, [Out] Single* @params);
        internal unsafe static GetProgramLocalParameterfvARB glGetProgramLocalParameterfvARB = (GetProgramLocalParameterfvARB)Gl.GetDelegateForExtensionMethod("glGetProgramLocalParameterfvARB", typeof(GetProgramLocalParameterfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramivARB(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetProgramivARB glGetProgramivARB = (GetProgramivARB)Gl.GetDelegateForExtensionMethod("glGetProgramivARB", typeof(GetProgramivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramStringARB(int target, int pname, [Out] void* @string);
        internal unsafe static GetProgramStringARB glGetProgramStringARB = (GetProgramStringARB)Gl.GetDelegateForExtensionMethod("glGetProgramStringARB", typeof(GetProgramStringARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdvARB(UInt32 index, int pname, [Out] Double* @params);
        internal unsafe static GetVertexAttribdvARB glGetVertexAttribdvARB = (GetVertexAttribdvARB)Gl.GetDelegateForExtensionMethod("glGetVertexAttribdvARB", typeof(GetVertexAttribdvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfvARB(UInt32 index, int pname, [Out] Single* @params);
        internal unsafe static GetVertexAttribfvARB glGetVertexAttribfvARB = (GetVertexAttribfvARB)Gl.GetDelegateForExtensionMethod("glGetVertexAttribfvARB", typeof(GetVertexAttribfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribivARB(UInt32 index, int pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribivARB glGetVertexAttribivARB = (GetVertexAttribivARB)Gl.GetDelegateForExtensionMethod("glGetVertexAttribivARB", typeof(GetVertexAttribivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribPointervARB(UInt32 index, int pname, [Out] void* pointer);
        internal unsafe static GetVertexAttribPointervARB glGetVertexAttribPointervARB = (GetVertexAttribPointervARB)Gl.GetDelegateForExtensionMethod("glGetVertexAttribPointervARB", typeof(GetVertexAttribPointervARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsProgramARB(UInt32 program);
        internal static IsProgramARB glIsProgramARB = (IsProgramARB)Gl.GetDelegateForExtensionMethod("glIsProgramARB", typeof(IsProgramARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferARB(int target, UInt32 buffer);
        internal static BindBufferARB glBindBufferARB = (BindBufferARB)Gl.GetDelegateForExtensionMethod("glBindBufferARB", typeof(BindBufferARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteBuffersARB(Int32 n, UInt32* buffers);
        internal unsafe static DeleteBuffersARB glDeleteBuffersARB = (DeleteBuffersARB)Gl.GetDelegateForExtensionMethod("glDeleteBuffersARB", typeof(DeleteBuffersARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenBuffersARB(Int32 n, [Out] UInt32* buffers);
        internal unsafe static GenBuffersARB glGenBuffersARB = (GenBuffersARB)Gl.GetDelegateForExtensionMethod("glGenBuffersARB", typeof(GenBuffersARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsBufferARB(UInt32 buffer);
        internal static IsBufferARB glIsBufferARB = (IsBufferARB)Gl.GetDelegateForExtensionMethod("glIsBufferARB", typeof(IsBufferARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferDataARB(int target, IntPtr size, void* data, int usage);
        internal unsafe static BufferDataARB glBufferDataARB = (BufferDataARB)Gl.GetDelegateForExtensionMethod("glBufferDataARB", typeof(BufferDataARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferSubDataARB(int target, IntPtr offset, IntPtr size, void* data);
        internal unsafe static BufferSubDataARB glBufferSubDataARB = (BufferSubDataARB)Gl.GetDelegateForExtensionMethod("glBufferSubDataARB", typeof(BufferSubDataARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferSubDataARB(int target, IntPtr offset, IntPtr size, [Out] void* data);
        internal unsafe static GetBufferSubDataARB glGetBufferSubDataARB = (GetBufferSubDataARB)Gl.GetDelegateForExtensionMethod("glGetBufferSubDataARB", typeof(GetBufferSubDataARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr MapBufferARB(int target, int access);
        internal static MapBufferARB glMapBufferARB = (MapBufferARB)Gl.GetDelegateForExtensionMethod("glMapBufferARB", typeof(MapBufferARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int UnmapBufferARB(int target);
        internal static UnmapBufferARB glUnmapBufferARB = (UnmapBufferARB)Gl.GetDelegateForExtensionMethod("glUnmapBufferARB", typeof(UnmapBufferARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferParameterivARB(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetBufferParameterivARB glGetBufferParameterivARB = (GetBufferParameterivARB)Gl.GetDelegateForExtensionMethod("glGetBufferParameterivARB", typeof(GetBufferParameterivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferPointervARB(int target, int pname, [Out] void* @params);
        internal unsafe static GetBufferPointervARB glGetBufferPointervARB = (GetBufferPointervARB)Gl.GetDelegateForExtensionMethod("glGetBufferPointervARB", typeof(GetBufferPointervARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenQueriesARB(Int32 n, [Out] UInt32* ids);
        internal unsafe static GenQueriesARB glGenQueriesARB = (GenQueriesARB)Gl.GetDelegateForExtensionMethod("glGenQueriesARB", typeof(GenQueriesARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteQueriesARB(Int32 n, UInt32* ids);
        internal unsafe static DeleteQueriesARB glDeleteQueriesARB = (DeleteQueriesARB)Gl.GetDelegateForExtensionMethod("glDeleteQueriesARB", typeof(DeleteQueriesARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsQueryARB(UInt32 id);
        internal static IsQueryARB glIsQueryARB = (IsQueryARB)Gl.GetDelegateForExtensionMethod("glIsQueryARB", typeof(IsQueryARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginQueryARB(int target, UInt32 id);
        internal static BeginQueryARB glBeginQueryARB = (BeginQueryARB)Gl.GetDelegateForExtensionMethod("glBeginQueryARB", typeof(BeginQueryARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndQueryARB(int target);
        internal static EndQueryARB glEndQueryARB = (EndQueryARB)Gl.GetDelegateForExtensionMethod("glEndQueryARB", typeof(EndQueryARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryivARB(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetQueryivARB glGetQueryivARB = (GetQueryivARB)Gl.GetDelegateForExtensionMethod("glGetQueryivARB", typeof(GetQueryivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectivARB(UInt32 id, int pname, [Out] Int32* @params);
        internal unsafe static GetQueryObjectivARB glGetQueryObjectivARB = (GetQueryObjectivARB)Gl.GetDelegateForExtensionMethod("glGetQueryObjectivARB", typeof(GetQueryObjectivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectuivARB(UInt32 id, int pname, [Out] UInt32* @params);
        internal unsafe static GetQueryObjectuivARB glGetQueryObjectuivARB = (GetQueryObjectuivARB)Gl.GetDelegateForExtensionMethod("glGetQueryObjectuivARB", typeof(GetQueryObjectuivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteObjectARB(UInt32 obj);
        internal static DeleteObjectARB glDeleteObjectARB = (DeleteObjectARB)Gl.GetDelegateForExtensionMethod("glDeleteObjectARB", typeof(DeleteObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetHandleARB(int pname);
        internal static GetHandleARB glGetHandleARB = (GetHandleARB)Gl.GetDelegateForExtensionMethod("glGetHandleARB", typeof(GetHandleARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DetachObjectARB(UInt32 containerObj, UInt32 attachedObj);
        internal static DetachObjectARB glDetachObjectARB = (DetachObjectARB)Gl.GetDelegateForExtensionMethod("glDetachObjectARB", typeof(DetachObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 CreateShaderObjectARB(int shaderType);
        internal static CreateShaderObjectARB glCreateShaderObjectARB = (CreateShaderObjectARB)Gl.GetDelegateForExtensionMethod("glCreateShaderObjectARB", typeof(CreateShaderObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ShaderSourceARB(UInt32 shaderObj, Int32 count, System.String[] @string, Int32* length);
        internal unsafe static ShaderSourceARB glShaderSourceARB = (ShaderSourceARB)Gl.GetDelegateForExtensionMethod("glShaderSourceARB", typeof(ShaderSourceARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompileShaderARB(UInt32 shaderObj);
        internal static CompileShaderARB glCompileShaderARB = (CompileShaderARB)Gl.GetDelegateForExtensionMethod("glCompileShaderARB", typeof(CompileShaderARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 CreateProgramObjectARB();
        internal static CreateProgramObjectARB glCreateProgramObjectARB = (CreateProgramObjectARB)Gl.GetDelegateForExtensionMethod("glCreateProgramObjectARB", typeof(CreateProgramObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AttachObjectARB(UInt32 containerObj, UInt32 obj);
        internal static AttachObjectARB glAttachObjectARB = (AttachObjectARB)Gl.GetDelegateForExtensionMethod("glAttachObjectARB", typeof(AttachObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LinkProgramARB(UInt32 programObj);
        internal static LinkProgramARB glLinkProgramARB = (LinkProgramARB)Gl.GetDelegateForExtensionMethod("glLinkProgramARB", typeof(LinkProgramARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UseProgramObjectARB(UInt32 programObj);
        internal static UseProgramObjectARB glUseProgramObjectARB = (UseProgramObjectARB)Gl.GetDelegateForExtensionMethod("glUseProgramObjectARB", typeof(UseProgramObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ValidateProgramARB(UInt32 programObj);
        internal static ValidateProgramARB glValidateProgramARB = (ValidateProgramARB)Gl.GetDelegateForExtensionMethod("glValidateProgramARB", typeof(ValidateProgramARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1fARB(Int32 location, Single v0);
        internal static Uniform1fARB glUniform1fARB = (Uniform1fARB)Gl.GetDelegateForExtensionMethod("glUniform1fARB", typeof(Uniform1fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2fARB(Int32 location, Single v0, Single v1);
        internal static Uniform2fARB glUniform2fARB = (Uniform2fARB)Gl.GetDelegateForExtensionMethod("glUniform2fARB", typeof(Uniform2fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3fARB(Int32 location, Single v0, Single v1, Single v2);
        internal static Uniform3fARB glUniform3fARB = (Uniform3fARB)Gl.GetDelegateForExtensionMethod("glUniform3fARB", typeof(Uniform3fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4fARB(Int32 location, Single v0, Single v1, Single v2, Single v3);
        internal static Uniform4fARB glUniform4fARB = (Uniform4fARB)Gl.GetDelegateForExtensionMethod("glUniform4fARB", typeof(Uniform4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1iARB(Int32 location, Int32 v0);
        internal static Uniform1iARB glUniform1iARB = (Uniform1iARB)Gl.GetDelegateForExtensionMethod("glUniform1iARB", typeof(Uniform1iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2iARB(Int32 location, Int32 v0, Int32 v1);
        internal static Uniform2iARB glUniform2iARB = (Uniform2iARB)Gl.GetDelegateForExtensionMethod("glUniform2iARB", typeof(Uniform2iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2);
        internal static Uniform3iARB glUniform3iARB = (Uniform3iARB)Gl.GetDelegateForExtensionMethod("glUniform3iARB", typeof(Uniform3iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
        internal static Uniform4iARB glUniform4iARB = (Uniform4iARB)Gl.GetDelegateForExtensionMethod("glUniform4iARB", typeof(Uniform4iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1fvARB(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform1fvARB glUniform1fvARB = (Uniform1fvARB)Gl.GetDelegateForExtensionMethod("glUniform1fvARB", typeof(Uniform1fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2fvARB(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform2fvARB glUniform2fvARB = (Uniform2fvARB)Gl.GetDelegateForExtensionMethod("glUniform2fvARB", typeof(Uniform2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3fvARB(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform3fvARB glUniform3fvARB = (Uniform3fvARB)Gl.GetDelegateForExtensionMethod("glUniform3fvARB", typeof(Uniform3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4fvARB(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform4fvARB glUniform4fvARB = (Uniform4fvARB)Gl.GetDelegateForExtensionMethod("glUniform4fvARB", typeof(Uniform4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1ivARB(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform1ivARB glUniform1ivARB = (Uniform1ivARB)Gl.GetDelegateForExtensionMethod("glUniform1ivARB", typeof(Uniform1ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2ivARB(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform2ivARB glUniform2ivARB = (Uniform2ivARB)Gl.GetDelegateForExtensionMethod("glUniform2ivARB", typeof(Uniform2ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3ivARB(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform3ivARB glUniform3ivARB = (Uniform3ivARB)Gl.GetDelegateForExtensionMethod("glUniform3ivARB", typeof(Uniform3ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4ivARB(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform4ivARB glUniform4ivARB = (Uniform4ivARB)Gl.GetDelegateForExtensionMethod("glUniform4ivARB", typeof(Uniform4ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2fvARB(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix2fvARB glUniformMatrix2fvARB = (UniformMatrix2fvARB)Gl.GetDelegateForExtensionMethod("glUniformMatrix2fvARB", typeof(UniformMatrix2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3fvARB(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix3fvARB glUniformMatrix3fvARB = (UniformMatrix3fvARB)Gl.GetDelegateForExtensionMethod("glUniformMatrix3fvARB", typeof(UniformMatrix3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4fvARB(Int32 location, Int32 count, int transpose, Single* value);
        internal unsafe static UniformMatrix4fvARB glUniformMatrix4fvARB = (UniformMatrix4fvARB)Gl.GetDelegateForExtensionMethod("glUniformMatrix4fvARB", typeof(UniformMatrix4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectParameterfvARB(UInt32 obj, int pname, [Out] Single* @params);
        internal unsafe static GetObjectParameterfvARB glGetObjectParameterfvARB = (GetObjectParameterfvARB)Gl.GetDelegateForExtensionMethod("glGetObjectParameterfvARB", typeof(GetObjectParameterfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectParameterivARB(UInt32 obj, int pname, [Out] Int32* @params);
        internal unsafe static GetObjectParameterivARB glGetObjectParameterivARB = (GetObjectParameterivARB)Gl.GetDelegateForExtensionMethod("glGetObjectParameterivARB", typeof(GetObjectParameterivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInfoLogARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, byte * infoLog);
        internal unsafe static GetInfoLogARB glGetInfoLogARB = (GetInfoLogARB)Gl.GetDelegateForExtensionMethod("glGetInfoLogARB", typeof(GetInfoLogARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
        internal unsafe static GetAttachedObjectsARB glGetAttachedObjectsARB = (GetAttachedObjectsARB)Gl.GetDelegateForExtensionMethod("glGetAttachedObjectsARB", typeof(GetAttachedObjectsARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetUniformLocationARB(UInt32 programObj, System.String name);
        internal static GetUniformLocationARB glGetUniformLocationARB = (GetUniformLocationARB)Gl.GetDelegateForExtensionMethod("glGetUniformLocationARB", typeof(GetUniformLocationARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveUniformARB glGetActiveUniformARB = (GetActiveUniformARB)Gl.GetDelegateForExtensionMethod("glGetActiveUniformARB", typeof(GetActiveUniformARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformfvARB(UInt32 programObj, Int32 location, [Out] Single* @params);
        internal unsafe static GetUniformfvARB glGetUniformfvARB = (GetUniformfvARB)Gl.GetDelegateForExtensionMethod("glGetUniformfvARB", typeof(GetUniformfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformivARB(UInt32 programObj, Int32 location, [Out] Int32* @params);
        internal unsafe static GetUniformivARB glGetUniformivARB = (GetUniformivARB)Gl.GetDelegateForExtensionMethod("glGetUniformivARB", typeof(GetUniformivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderSourceARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
        internal unsafe static GetShaderSourceARB glGetShaderSourceARB = (GetShaderSourceARB)Gl.GetDelegateForExtensionMethod("glGetShaderSourceARB", typeof(GetShaderSourceARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindAttribLocationARB(UInt32 programObj, UInt32 index, System.String name);
        internal static BindAttribLocationARB glBindAttribLocationARB = (BindAttribLocationARB)Gl.GetDelegateForExtensionMethod("glBindAttribLocationARB", typeof(BindAttribLocationARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveAttribARB glGetActiveAttribARB = (GetActiveAttribARB)Gl.GetDelegateForExtensionMethod("glGetActiveAttribARB", typeof(GetActiveAttribARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetAttribLocationARB(UInt32 programObj, System.String name);
        internal static GetAttribLocationARB glGetAttribLocationARB = (GetAttribLocationARB)Gl.GetDelegateForExtensionMethod("glGetAttribLocationARB", typeof(GetAttribLocationARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffersARB(Int32 n, int* bufs);
        internal unsafe static DrawBuffersARB glDrawBuffersARB = (DrawBuffersARB)Gl.GetDelegateForExtensionMethod("glDrawBuffersARB", typeof(DrawBuffersARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClampColorARB(int target, int clamp);
        internal static ClampColorARB glClampColorARB = (ClampColorARB)Gl.GetDelegateForExtensionMethod("glClampColorARB", typeof(ClampColorARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendColorEXT(Single red, Single green, Single blue, Single alpha);
        internal static BlendColorEXT glBlendColorEXT = (BlendColorEXT)Gl.GetDelegateForExtensionMethod("glBlendColorEXT", typeof(BlendColorEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonOffsetEXT(Single factor, Single bias);
        internal static PolygonOffsetEXT glPolygonOffsetEXT = (PolygonOffsetEXT)Gl.GetDelegateForExtensionMethod("glPolygonOffsetEXT", typeof(PolygonOffsetEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage3DEXT(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, void* pixels);
        internal unsafe static TexImage3DEXT glTexImage3DEXT = (TexImage3DEXT)Gl.GetDelegateForExtensionMethod("glTexImage3DEXT", typeof(TexImage3DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage3DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, void* pixels);
        internal unsafe static TexSubImage3DEXT glTexSubImage3DEXT = (TexSubImage3DEXT)Gl.GetDelegateForExtensionMethod("glTexSubImage3DEXT", typeof(TexSubImage3DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexFilterFuncSGIS(int target, int filter, [Out] Single* weights);
        internal unsafe static GetTexFilterFuncSGIS glGetTexFilterFuncSGIS = (GetTexFilterFuncSGIS)Gl.GetDelegateForExtensionMethod("glGetTexFilterFuncSGIS", typeof(GetTexFilterFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexFilterFuncSGIS(int target, int filter, Int32 n, Single* weights);
        internal unsafe static TexFilterFuncSGIS glTexFilterFuncSGIS = (TexFilterFuncSGIS)Gl.GetDelegateForExtensionMethod("glTexFilterFuncSGIS", typeof(TexFilterFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage1DEXT(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, void* pixels);
        internal unsafe static TexSubImage1DEXT glTexSubImage1DEXT = (TexSubImage1DEXT)Gl.GetDelegateForExtensionMethod("glTexSubImage1DEXT", typeof(TexSubImage1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage2DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, void* pixels);
        internal unsafe static TexSubImage2DEXT glTexSubImage2DEXT = (TexSubImage2DEXT)Gl.GetDelegateForExtensionMethod("glTexSubImage2DEXT", typeof(TexSubImage2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage1DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
        internal static CopyTexImage1DEXT glCopyTexImage1DEXT = (CopyTexImage1DEXT)Gl.GetDelegateForExtensionMethod("glCopyTexImage1DEXT", typeof(CopyTexImage1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage2DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        internal static CopyTexImage2DEXT glCopyTexImage2DEXT = (CopyTexImage2DEXT)Gl.GetDelegateForExtensionMethod("glCopyTexImage2DEXT", typeof(CopyTexImage2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage1DEXT(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
        internal static CopyTexSubImage1DEXT glCopyTexSubImage1DEXT = (CopyTexSubImage1DEXT)Gl.GetDelegateForExtensionMethod("glCopyTexSubImage1DEXT", typeof(CopyTexSubImage1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage2DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyTexSubImage2DEXT glCopyTexSubImage2DEXT = (CopyTexSubImage2DEXT)Gl.GetDelegateForExtensionMethod("glCopyTexSubImage2DEXT", typeof(CopyTexSubImage2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage3DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyTexSubImage3DEXT glCopyTexSubImage3DEXT = (CopyTexSubImage3DEXT)Gl.GetDelegateForExtensionMethod("glCopyTexSubImage3DEXT", typeof(CopyTexSubImage3DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramEXT(int target, int reset, int format, int type, [Out] void* values);
        internal unsafe static GetHistogramEXT glGetHistogramEXT = (GetHistogramEXT)Gl.GetDelegateForExtensionMethod("glGetHistogramEXT", typeof(GetHistogramEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameterfvEXT(int target, int pname, [Out] Single* @params);
        internal unsafe static GetHistogramParameterfvEXT glGetHistogramParameterfvEXT = (GetHistogramParameterfvEXT)Gl.GetDelegateForExtensionMethod("glGetHistogramParameterfvEXT", typeof(GetHistogramParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameterivEXT(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetHistogramParameterivEXT glGetHistogramParameterivEXT = (GetHistogramParameterivEXT)Gl.GetDelegateForExtensionMethod("glGetHistogramParameterivEXT", typeof(GetHistogramParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxEXT(int target, int reset, int format, int type, [Out] void* values);
        internal unsafe static GetMinmaxEXT glGetMinmaxEXT = (GetMinmaxEXT)Gl.GetDelegateForExtensionMethod("glGetMinmaxEXT", typeof(GetMinmaxEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameterfvEXT(int target, int pname, [Out] Single* @params);
        internal unsafe static GetMinmaxParameterfvEXT glGetMinmaxParameterfvEXT = (GetMinmaxParameterfvEXT)Gl.GetDelegateForExtensionMethod("glGetMinmaxParameterfvEXT", typeof(GetMinmaxParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameterivEXT(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetMinmaxParameterivEXT glGetMinmaxParameterivEXT = (GetMinmaxParameterivEXT)Gl.GetDelegateForExtensionMethod("glGetMinmaxParameterivEXT", typeof(GetMinmaxParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void HistogramEXT(int target, Int32 width, int internalformat, int sink);
        internal static HistogramEXT glHistogramEXT = (HistogramEXT)Gl.GetDelegateForExtensionMethod("glHistogramEXT", typeof(HistogramEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MinmaxEXT(int target, int internalformat, int sink);
        internal static MinmaxEXT glMinmaxEXT = (MinmaxEXT)Gl.GetDelegateForExtensionMethod("glMinmaxEXT", typeof(MinmaxEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetHistogramEXT(int target);
        internal static ResetHistogramEXT glResetHistogramEXT = (ResetHistogramEXT)Gl.GetDelegateForExtensionMethod("glResetHistogramEXT", typeof(ResetHistogramEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetMinmaxEXT(int target);
        internal static ResetMinmaxEXT glResetMinmaxEXT = (ResetMinmaxEXT)Gl.GetDelegateForExtensionMethod("glResetMinmaxEXT", typeof(ResetMinmaxEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter1DEXT(int target, int internalformat, Int32 width, int format, int type, void* image);
        internal unsafe static ConvolutionFilter1DEXT glConvolutionFilter1DEXT = (ConvolutionFilter1DEXT)Gl.GetDelegateForExtensionMethod("glConvolutionFilter1DEXT", typeof(ConvolutionFilter1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, void* image);
        internal unsafe static ConvolutionFilter2DEXT glConvolutionFilter2DEXT = (ConvolutionFilter2DEXT)Gl.GetDelegateForExtensionMethod("glConvolutionFilter2DEXT", typeof(ConvolutionFilter2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameterfEXT(int target, int pname, Single @params);
        internal static ConvolutionParameterfEXT glConvolutionParameterfEXT = (ConvolutionParameterfEXT)Gl.GetDelegateForExtensionMethod("glConvolutionParameterfEXT", typeof(ConvolutionParameterfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameterfvEXT(int target, int pname, Single* @params);
        internal unsafe static ConvolutionParameterfvEXT glConvolutionParameterfvEXT = (ConvolutionParameterfvEXT)Gl.GetDelegateForExtensionMethod("glConvolutionParameterfvEXT", typeof(ConvolutionParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameteriEXT(int target, int pname, Int32 @params);
        internal static ConvolutionParameteriEXT glConvolutionParameteriEXT = (ConvolutionParameteriEXT)Gl.GetDelegateForExtensionMethod("glConvolutionParameteriEXT", typeof(ConvolutionParameteriEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameterivEXT(int target, int pname, Int32* @params);
        internal unsafe static ConvolutionParameterivEXT glConvolutionParameterivEXT = (ConvolutionParameterivEXT)Gl.GetDelegateForExtensionMethod("glConvolutionParameterivEXT", typeof(ConvolutionParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter1DEXT(int target, int internalformat, Int32 x, Int32 y, Int32 width);
        internal static CopyConvolutionFilter1DEXT glCopyConvolutionFilter1DEXT = (CopyConvolutionFilter1DEXT)Gl.GetDelegateForExtensionMethod("glCopyConvolutionFilter1DEXT", typeof(CopyConvolutionFilter1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter2DEXT(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyConvolutionFilter2DEXT glCopyConvolutionFilter2DEXT = (CopyConvolutionFilter2DEXT)Gl.GetDelegateForExtensionMethod("glCopyConvolutionFilter2DEXT", typeof(CopyConvolutionFilter2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionFilterEXT(int target, int format, int type, [Out] void* image);
        internal unsafe static GetConvolutionFilterEXT glGetConvolutionFilterEXT = (GetConvolutionFilterEXT)Gl.GetDelegateForExtensionMethod("glGetConvolutionFilterEXT", typeof(GetConvolutionFilterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameterfvEXT(int target, int pname, [Out] Single* @params);
        internal unsafe static GetConvolutionParameterfvEXT glGetConvolutionParameterfvEXT = (GetConvolutionParameterfvEXT)Gl.GetDelegateForExtensionMethod("glGetConvolutionParameterfvEXT", typeof(GetConvolutionParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameterivEXT(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetConvolutionParameterivEXT glGetConvolutionParameterivEXT = (GetConvolutionParameterivEXT)Gl.GetDelegateForExtensionMethod("glGetConvolutionParameterivEXT", typeof(GetConvolutionParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSeparableFilterEXT(int target, int format, int type, [Out] void* row, [Out] void* column, [Out] void* span);
        internal unsafe static GetSeparableFilterEXT glGetSeparableFilterEXT = (GetSeparableFilterEXT)Gl.GetDelegateForExtensionMethod("glGetSeparableFilterEXT", typeof(GetSeparableFilterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SeparableFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, void* row, void* column);
        internal unsafe static SeparableFilter2DEXT glSeparableFilter2DEXT = (SeparableFilter2DEXT)Gl.GetDelegateForExtensionMethod("glSeparableFilter2DEXT", typeof(SeparableFilter2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableSGI(int target, int internalformat, Int32 width, int format, int type, void* table);
        internal unsafe static ColorTableSGI glColorTableSGI = (ColorTableSGI)Gl.GetDelegateForExtensionMethod("glColorTableSGI", typeof(ColorTableSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameterfvSGI(int target, int pname, Single* @params);
        internal unsafe static ColorTableParameterfvSGI glColorTableParameterfvSGI = (ColorTableParameterfvSGI)Gl.GetDelegateForExtensionMethod("glColorTableParameterfvSGI", typeof(ColorTableParameterfvSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameterivSGI(int target, int pname, Int32* @params);
        internal unsafe static ColorTableParameterivSGI glColorTableParameterivSGI = (ColorTableParameterivSGI)Gl.GetDelegateForExtensionMethod("glColorTableParameterivSGI", typeof(ColorTableParameterivSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorTableSGI(int target, int internalformat, Int32 x, Int32 y, Int32 width);
        internal static CopyColorTableSGI glCopyColorTableSGI = (CopyColorTableSGI)Gl.GetDelegateForExtensionMethod("glCopyColorTableSGI", typeof(CopyColorTableSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableSGI(int target, int format, int type, [Out] void* table);
        internal unsafe static GetColorTableSGI glGetColorTableSGI = (GetColorTableSGI)Gl.GetDelegateForExtensionMethod("glGetColorTableSGI", typeof(GetColorTableSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterfvSGI(int target, int pname, [Out] Single* @params);
        internal unsafe static GetColorTableParameterfvSGI glGetColorTableParameterfvSGI = (GetColorTableParameterfvSGI)Gl.GetDelegateForExtensionMethod("glGetColorTableParameterfvSGI", typeof(GetColorTableParameterfvSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterivSGI(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetColorTableParameterivSGI glGetColorTableParameterivSGI = (GetColorTableParameterivSGI)Gl.GetDelegateForExtensionMethod("glGetColorTableParameterivSGI", typeof(GetColorTableParameterivSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTexGenSGIX(int mode);
        internal static PixelTexGenSGIX glPixelTexGenSGIX = (PixelTexGenSGIX)Gl.GetDelegateForExtensionMethod("glPixelTexGenSGIX", typeof(PixelTexGenSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTexGenParameteriSGIS(int pname, Int32 param);
        internal static PixelTexGenParameteriSGIS glPixelTexGenParameteriSGIS = (PixelTexGenParameteriSGIS)Gl.GetDelegateForExtensionMethod("glPixelTexGenParameteriSGIS", typeof(PixelTexGenParameteriSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTexGenParameterivSGIS(int pname, Int32* @params);
        internal unsafe static PixelTexGenParameterivSGIS glPixelTexGenParameterivSGIS = (PixelTexGenParameterivSGIS)Gl.GetDelegateForExtensionMethod("glPixelTexGenParameterivSGIS", typeof(PixelTexGenParameterivSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTexGenParameterfSGIS(int pname, Single param);
        internal static PixelTexGenParameterfSGIS glPixelTexGenParameterfSGIS = (PixelTexGenParameterfSGIS)Gl.GetDelegateForExtensionMethod("glPixelTexGenParameterfSGIS", typeof(PixelTexGenParameterfSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTexGenParameterfvSGIS(int pname, Single* @params);
        internal unsafe static PixelTexGenParameterfvSGIS glPixelTexGenParameterfvSGIS = (PixelTexGenParameterfvSGIS)Gl.GetDelegateForExtensionMethod("glPixelTexGenParameterfvSGIS", typeof(PixelTexGenParameterfvSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelTexGenParameterivSGIS(int pname, [Out] Int32* @params);
        internal unsafe static GetPixelTexGenParameterivSGIS glGetPixelTexGenParameterivSGIS = (GetPixelTexGenParameterivSGIS)Gl.GetDelegateForExtensionMethod("glGetPixelTexGenParameterivSGIS", typeof(GetPixelTexGenParameterivSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelTexGenParameterfvSGIS(int pname, [Out] Single* @params);
        internal unsafe static GetPixelTexGenParameterfvSGIS glGetPixelTexGenParameterfvSGIS = (GetPixelTexGenParameterfvSGIS)Gl.GetDelegateForExtensionMethod("glGetPixelTexGenParameterfvSGIS", typeof(GetPixelTexGenParameterfvSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage4DSGIS(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, int format, int type, void* pixels);
        internal unsafe static TexImage4DSGIS glTexImage4DSGIS = (TexImage4DSGIS)Gl.GetDelegateForExtensionMethod("glTexImage4DSGIS", typeof(TexImage4DSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage4DSGIS(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, int format, int type, void* pixels);
        internal unsafe static TexSubImage4DSGIS glTexSubImage4DSGIS = (TexSubImage4DSGIS)Gl.GetDelegateForExtensionMethod("glTexSubImage4DSGIS", typeof(TexSubImage4DSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate int AreTexturesResidentEXT(Int32 n, UInt32* textures, [Out] int* residences);
        internal unsafe static AreTexturesResidentEXT glAreTexturesResidentEXT = (AreTexturesResidentEXT)Gl.GetDelegateForExtensionMethod("glAreTexturesResidentEXT", typeof(AreTexturesResidentEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindTextureEXT(int target, UInt32 texture);
        internal static BindTextureEXT glBindTextureEXT = (BindTextureEXT)Gl.GetDelegateForExtensionMethod("glBindTextureEXT", typeof(BindTextureEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteTexturesEXT(Int32 n, UInt32* textures);
        internal unsafe static DeleteTexturesEXT glDeleteTexturesEXT = (DeleteTexturesEXT)Gl.GetDelegateForExtensionMethod("glDeleteTexturesEXT", typeof(DeleteTexturesEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenTexturesEXT(Int32 n, [Out] UInt32* textures);
        internal unsafe static GenTexturesEXT glGenTexturesEXT = (GenTexturesEXT)Gl.GetDelegateForExtensionMethod("glGenTexturesEXT", typeof(GenTexturesEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsTextureEXT(UInt32 texture);
        internal static IsTextureEXT glIsTextureEXT = (IsTextureEXT)Gl.GetDelegateForExtensionMethod("glIsTextureEXT", typeof(IsTextureEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PrioritizeTexturesEXT(Int32 n, UInt32* textures, Single* priorities);
        internal unsafe static PrioritizeTexturesEXT glPrioritizeTexturesEXT = (PrioritizeTexturesEXT)Gl.GetDelegateForExtensionMethod("glPrioritizeTexturesEXT", typeof(PrioritizeTexturesEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DetailTexFuncSGIS(int target, Int32 n, Single* points);
        internal unsafe static DetailTexFuncSGIS glDetailTexFuncSGIS = (DetailTexFuncSGIS)Gl.GetDelegateForExtensionMethod("glDetailTexFuncSGIS", typeof(DetailTexFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetDetailTexFuncSGIS(int target, [Out] Single* points);
        internal unsafe static GetDetailTexFuncSGIS glGetDetailTexFuncSGIS = (GetDetailTexFuncSGIS)Gl.GetDelegateForExtensionMethod("glGetDetailTexFuncSGIS", typeof(GetDetailTexFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SharpenTexFuncSGIS(int target, Int32 n, Single* points);
        internal unsafe static SharpenTexFuncSGIS glSharpenTexFuncSGIS = (SharpenTexFuncSGIS)Gl.GetDelegateForExtensionMethod("glSharpenTexFuncSGIS", typeof(SharpenTexFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSharpenTexFuncSGIS(int target, [Out] Single* points);
        internal unsafe static GetSharpenTexFuncSGIS glGetSharpenTexFuncSGIS = (GetSharpenTexFuncSGIS)Gl.GetDelegateForExtensionMethod("glGetSharpenTexFuncSGIS", typeof(GetSharpenTexFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMaskSGIS(Single value, int invert);
        internal static SampleMaskSGIS glSampleMaskSGIS = (SampleMaskSGIS)Gl.GetDelegateForExtensionMethod("glSampleMaskSGIS", typeof(SampleMaskSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SamplePatternSGIS(int pattern);
        internal static SamplePatternSGIS glSamplePatternSGIS = (SamplePatternSGIS)Gl.GetDelegateForExtensionMethod("glSamplePatternSGIS", typeof(SamplePatternSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ArrayElementEXT(Int32 i);
        internal static ArrayElementEXT glArrayElementEXT = (ArrayElementEXT)Gl.GetDelegateForExtensionMethod("glArrayElementEXT", typeof(ArrayElementEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointerEXT(Int32 size, int type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static ColorPointerEXT glColorPointerEXT = (ColorPointerEXT)Gl.GetDelegateForExtensionMethod("glColorPointerEXT", typeof(ColorPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysEXT(int mode, Int32 first, Int32 count);
        internal static DrawArraysEXT glDrawArraysEXT = (DrawArraysEXT)Gl.GetDelegateForExtensionMethod("glDrawArraysEXT", typeof(DrawArraysEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagPointerEXT(Int32 stride, Int32 count, int* pointer);
        internal unsafe static EdgeFlagPointerEXT glEdgeFlagPointerEXT = (EdgeFlagPointerEXT)Gl.GetDelegateForExtensionMethod("glEdgeFlagPointerEXT", typeof(EdgeFlagPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPointervEXT(int pname, [Out] void* @params);
        internal unsafe static GetPointervEXT glGetPointervEXT = (GetPointervEXT)Gl.GetDelegateForExtensionMethod("glGetPointervEXT", typeof(GetPointervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IndexPointerEXT(int type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static IndexPointerEXT glIndexPointerEXT = (IndexPointerEXT)Gl.GetDelegateForExtensionMethod("glIndexPointerEXT", typeof(IndexPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointerEXT(int type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static NormalPointerEXT glNormalPointerEXT = (NormalPointerEXT)Gl.GetDelegateForExtensionMethod("glNormalPointerEXT", typeof(NormalPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointerEXT(Int32 size, int type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static TexCoordPointerEXT glTexCoordPointerEXT = (TexCoordPointerEXT)Gl.GetDelegateForExtensionMethod("glTexCoordPointerEXT", typeof(TexCoordPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointerEXT(Int32 size, int type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static VertexPointerEXT glVertexPointerEXT = (VertexPointerEXT)Gl.GetDelegateForExtensionMethod("glVertexPointerEXT", typeof(VertexPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationEXT(int mode);
        internal static BlendEquationEXT glBlendEquationEXT = (BlendEquationEXT)Gl.GetDelegateForExtensionMethod("glBlendEquationEXT", typeof(BlendEquationEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SpriteParameterfSGIX(int pname, Single param);
        internal static SpriteParameterfSGIX glSpriteParameterfSGIX = (SpriteParameterfSGIX)Gl.GetDelegateForExtensionMethod("glSpriteParameterfSGIX", typeof(SpriteParameterfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SpriteParameterfvSGIX(int pname, Single* @params);
        internal unsafe static SpriteParameterfvSGIX glSpriteParameterfvSGIX = (SpriteParameterfvSGIX)Gl.GetDelegateForExtensionMethod("glSpriteParameterfvSGIX", typeof(SpriteParameterfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SpriteParameteriSGIX(int pname, Int32 param);
        internal static SpriteParameteriSGIX glSpriteParameteriSGIX = (SpriteParameteriSGIX)Gl.GetDelegateForExtensionMethod("glSpriteParameteriSGIX", typeof(SpriteParameteriSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SpriteParameterivSGIX(int pname, Int32* @params);
        internal unsafe static SpriteParameterivSGIX glSpriteParameterivSGIX = (SpriteParameterivSGIX)Gl.GetDelegateForExtensionMethod("glSpriteParameterivSGIX", typeof(SpriteParameterivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterfEXT(int pname, Single param);
        internal static PointParameterfEXT glPointParameterfEXT = (PointParameterfEXT)Gl.GetDelegateForExtensionMethod("glPointParameterfEXT", typeof(PointParameterfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvEXT(int pname, Single* @params);
        internal unsafe static PointParameterfvEXT glPointParameterfvEXT = (PointParameterfvEXT)Gl.GetDelegateForExtensionMethod("glPointParameterfvEXT", typeof(PointParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterfSGIS(int pname, Single param);
        internal static PointParameterfSGIS glPointParameterfSGIS = (PointParameterfSGIS)Gl.GetDelegateForExtensionMethod("glPointParameterfSGIS", typeof(PointParameterfSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvSGIS(int pname, Single* @params);
        internal unsafe static PointParameterfvSGIS glPointParameterfvSGIS = (PointParameterfvSGIS)Gl.GetDelegateForExtensionMethod("glPointParameterfvSGIS", typeof(PointParameterfvSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetInstrumentsSGIX();
        internal static GetInstrumentsSGIX glGetInstrumentsSGIX = (GetInstrumentsSGIX)Gl.GetDelegateForExtensionMethod("glGetInstrumentsSGIX", typeof(GetInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void InstrumentsBufferSGIX(Int32 size, [Out] Int32* buffer);
        internal unsafe static InstrumentsBufferSGIX glInstrumentsBufferSGIX = (InstrumentsBufferSGIX)Gl.GetDelegateForExtensionMethod("glInstrumentsBufferSGIX", typeof(InstrumentsBufferSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Int32 PollInstrumentsSGIX([Out] Int32* marker_p);
        internal unsafe static PollInstrumentsSGIX glPollInstrumentsSGIX = (PollInstrumentsSGIX)Gl.GetDelegateForExtensionMethod("glPollInstrumentsSGIX", typeof(PollInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReadInstrumentsSGIX(Int32 marker);
        internal static ReadInstrumentsSGIX glReadInstrumentsSGIX = (ReadInstrumentsSGIX)Gl.GetDelegateForExtensionMethod("glReadInstrumentsSGIX", typeof(ReadInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StartInstrumentsSGIX();
        internal static StartInstrumentsSGIX glStartInstrumentsSGIX = (StartInstrumentsSGIX)Gl.GetDelegateForExtensionMethod("glStartInstrumentsSGIX", typeof(StartInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StopInstrumentsSGIX(Int32 marker);
        internal static StopInstrumentsSGIX glStopInstrumentsSGIX = (StopInstrumentsSGIX)Gl.GetDelegateForExtensionMethod("glStopInstrumentsSGIX", typeof(StopInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FrameZoomSGIX(Int32 factor);
        internal static FrameZoomSGIX glFrameZoomSGIX = (FrameZoomSGIX)Gl.GetDelegateForExtensionMethod("glFrameZoomSGIX", typeof(FrameZoomSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TagSampleBufferSGIX();
        internal static TagSampleBufferSGIX glTagSampleBufferSGIX = (TagSampleBufferSGIX)Gl.GetDelegateForExtensionMethod("glTagSampleBufferSGIX", typeof(TagSampleBufferSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeformationMap3dSGIX(int target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double w1, Double w2, Int32 wstride, Int32 worder, Double* points);
        internal unsafe static DeformationMap3dSGIX glDeformationMap3dSGIX = (DeformationMap3dSGIX)Gl.GetDelegateForExtensionMethod("glDeformationMap3dSGIX", typeof(DeformationMap3dSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeformationMap3fSGIX(int target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single w1, Single w2, Int32 wstride, Int32 worder, Single* points);
        internal unsafe static DeformationMap3fSGIX glDeformationMap3fSGIX = (DeformationMap3fSGIX)Gl.GetDelegateForExtensionMethod("glDeformationMap3fSGIX", typeof(DeformationMap3fSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeformSGIX(int mask);
        internal static DeformSGIX glDeformSGIX = (DeformSGIX)Gl.GetDelegateForExtensionMethod("glDeformSGIX", typeof(DeformSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LoadIdentityDeformationMapSGIX(int mask);
        internal static LoadIdentityDeformationMapSGIX glLoadIdentityDeformationMapSGIX = (LoadIdentityDeformationMapSGIX)Gl.GetDelegateForExtensionMethod("glLoadIdentityDeformationMapSGIX", typeof(LoadIdentityDeformationMapSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReferencePlaneSGIX(Double* equation);
        internal unsafe static ReferencePlaneSGIX glReferencePlaneSGIX = (ReferencePlaneSGIX)Gl.GetDelegateForExtensionMethod("glReferencePlaneSGIX", typeof(ReferencePlaneSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushRasterSGIX();
        internal static FlushRasterSGIX glFlushRasterSGIX = (FlushRasterSGIX)Gl.GetDelegateForExtensionMethod("glFlushRasterSGIX", typeof(FlushRasterSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogFuncSGIS(Int32 n, Single* points);
        internal unsafe static FogFuncSGIS glFogFuncSGIS = (FogFuncSGIS)Gl.GetDelegateForExtensionMethod("glFogFuncSGIS", typeof(FogFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFogFuncSGIS([Out] Single* points);
        internal unsafe static GetFogFuncSGIS glGetFogFuncSGIS = (GetFogFuncSGIS)Gl.GetDelegateForExtensionMethod("glGetFogFuncSGIS", typeof(GetFogFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ImageTransformParameteriHP(int target, int pname, Int32 param);
        internal static ImageTransformParameteriHP glImageTransformParameteriHP = (ImageTransformParameteriHP)Gl.GetDelegateForExtensionMethod("glImageTransformParameteriHP", typeof(ImageTransformParameteriHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ImageTransformParameterfHP(int target, int pname, Single param);
        internal static ImageTransformParameterfHP glImageTransformParameterfHP = (ImageTransformParameterfHP)Gl.GetDelegateForExtensionMethod("glImageTransformParameterfHP", typeof(ImageTransformParameterfHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ImageTransformParameterivHP(int target, int pname, Int32* @params);
        internal unsafe static ImageTransformParameterivHP glImageTransformParameterivHP = (ImageTransformParameterivHP)Gl.GetDelegateForExtensionMethod("glImageTransformParameterivHP", typeof(ImageTransformParameterivHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ImageTransformParameterfvHP(int target, int pname, Single* @params);
        internal unsafe static ImageTransformParameterfvHP glImageTransformParameterfvHP = (ImageTransformParameterfvHP)Gl.GetDelegateForExtensionMethod("glImageTransformParameterfvHP", typeof(ImageTransformParameterfvHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetImageTransformParameterivHP(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetImageTransformParameterivHP glGetImageTransformParameterivHP = (GetImageTransformParameterivHP)Gl.GetDelegateForExtensionMethod("glGetImageTransformParameterivHP", typeof(GetImageTransformParameterivHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetImageTransformParameterfvHP(int target, int pname, [Out] Single* @params);
        internal unsafe static GetImageTransformParameterfvHP glGetImageTransformParameterfvHP = (GetImageTransformParameterfvHP)Gl.GetDelegateForExtensionMethod("glGetImageTransformParameterfvHP", typeof(GetImageTransformParameterfvHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorSubTableEXT(int target, Int32 start, Int32 count, int format, int type, void* data);
        internal unsafe static ColorSubTableEXT glColorSubTableEXT = (ColorSubTableEXT)Gl.GetDelegateForExtensionMethod("glColorSubTableEXT", typeof(ColorSubTableEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorSubTableEXT(int target, Int32 start, Int32 x, Int32 y, Int32 width);
        internal static CopyColorSubTableEXT glCopyColorSubTableEXT = (CopyColorSubTableEXT)Gl.GetDelegateForExtensionMethod("glCopyColorSubTableEXT", typeof(CopyColorSubTableEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void HintPGI(int target, Int32 mode);
        internal static HintPGI glHintPGI = (HintPGI)Gl.GetDelegateForExtensionMethod("glHintPGI", typeof(HintPGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableEXT(int target, int internalFormat, Int32 width, int format, int type, void* table);
        internal unsafe static ColorTableEXT glColorTableEXT = (ColorTableEXT)Gl.GetDelegateForExtensionMethod("glColorTableEXT", typeof(ColorTableEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableEXT(int target, int format, int type, [Out] void* data);
        internal unsafe static GetColorTableEXT glGetColorTableEXT = (GetColorTableEXT)Gl.GetDelegateForExtensionMethod("glGetColorTableEXT", typeof(GetColorTableEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterivEXT(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetColorTableParameterivEXT glGetColorTableParameterivEXT = (GetColorTableParameterivEXT)Gl.GetDelegateForExtensionMethod("glGetColorTableParameterivEXT", typeof(GetColorTableParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterfvEXT(int target, int pname, [Out] Single* @params);
        internal unsafe static GetColorTableParameterfvEXT glGetColorTableParameterfvEXT = (GetColorTableParameterfvEXT)Gl.GetDelegateForExtensionMethod("glGetColorTableParameterfvEXT", typeof(GetColorTableParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetListParameterfvSGIX(UInt32 list, int pname, [Out] Single* @params);
        internal unsafe static GetListParameterfvSGIX glGetListParameterfvSGIX = (GetListParameterfvSGIX)Gl.GetDelegateForExtensionMethod("glGetListParameterfvSGIX", typeof(GetListParameterfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetListParameterivSGIX(UInt32 list, int pname, [Out] Int32* @params);
        internal unsafe static GetListParameterivSGIX glGetListParameterivSGIX = (GetListParameterivSGIX)Gl.GetDelegateForExtensionMethod("glGetListParameterivSGIX", typeof(GetListParameterivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ListParameterfSGIX(UInt32 list, int pname, Single param);
        internal static ListParameterfSGIX glListParameterfSGIX = (ListParameterfSGIX)Gl.GetDelegateForExtensionMethod("glListParameterfSGIX", typeof(ListParameterfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ListParameterfvSGIX(UInt32 list, int pname, Single* @params);
        internal unsafe static ListParameterfvSGIX glListParameterfvSGIX = (ListParameterfvSGIX)Gl.GetDelegateForExtensionMethod("glListParameterfvSGIX", typeof(ListParameterfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ListParameteriSGIX(UInt32 list, int pname, Int32 param);
        internal static ListParameteriSGIX glListParameteriSGIX = (ListParameteriSGIX)Gl.GetDelegateForExtensionMethod("glListParameteriSGIX", typeof(ListParameteriSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ListParameterivSGIX(UInt32 list, int pname, Int32* @params);
        internal unsafe static ListParameterivSGIX glListParameterivSGIX = (ListParameterivSGIX)Gl.GetDelegateForExtensionMethod("glListParameterivSGIX", typeof(ListParameterivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void IndexMaterialEXT(int face, int mode);
        internal static IndexMaterialEXT glIndexMaterialEXT = (IndexMaterialEXT)Gl.GetDelegateForExtensionMethod("glIndexMaterialEXT", typeof(IndexMaterialEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void IndexFuncEXT(int func, Single @ref);
        internal static IndexFuncEXT glIndexFuncEXT = (IndexFuncEXT)Gl.GetDelegateForExtensionMethod("glIndexFuncEXT", typeof(IndexFuncEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LockArraysEXT(Int32 first, Int32 count);
        internal static LockArraysEXT glLockArraysEXT = (LockArraysEXT)Gl.GetDelegateForExtensionMethod("glLockArraysEXT", typeof(LockArraysEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UnlockArraysEXT();
        internal static UnlockArraysEXT glUnlockArraysEXT = (UnlockArraysEXT)Gl.GetDelegateForExtensionMethod("glUnlockArraysEXT", typeof(UnlockArraysEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CullParameterdvEXT(int pname, [Out] Double* @params);
        internal unsafe static CullParameterdvEXT glCullParameterdvEXT = (CullParameterdvEXT)Gl.GetDelegateForExtensionMethod("glCullParameterdvEXT", typeof(CullParameterdvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CullParameterfvEXT(int pname, [Out] Single* @params);
        internal unsafe static CullParameterfvEXT glCullParameterfvEXT = (CullParameterfvEXT)Gl.GetDelegateForExtensionMethod("glCullParameterfvEXT", typeof(CullParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentColorMaterialSGIX(int face, int mode);
        internal static FragmentColorMaterialSGIX glFragmentColorMaterialSGIX = (FragmentColorMaterialSGIX)Gl.GetDelegateForExtensionMethod("glFragmentColorMaterialSGIX", typeof(FragmentColorMaterialSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightfSGIX(int light, int pname, Single param);
        internal static FragmentLightfSGIX glFragmentLightfSGIX = (FragmentLightfSGIX)Gl.GetDelegateForExtensionMethod("glFragmentLightfSGIX", typeof(FragmentLightfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightfvSGIX(int light, int pname, Single* @params);
        internal unsafe static FragmentLightfvSGIX glFragmentLightfvSGIX = (FragmentLightfvSGIX)Gl.GetDelegateForExtensionMethod("glFragmentLightfvSGIX", typeof(FragmentLightfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightiSGIX(int light, int pname, Int32 param);
        internal static FragmentLightiSGIX glFragmentLightiSGIX = (FragmentLightiSGIX)Gl.GetDelegateForExtensionMethod("glFragmentLightiSGIX", typeof(FragmentLightiSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightivSGIX(int light, int pname, Int32* @params);
        internal unsafe static FragmentLightivSGIX glFragmentLightivSGIX = (FragmentLightivSGIX)Gl.GetDelegateForExtensionMethod("glFragmentLightivSGIX", typeof(FragmentLightivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightModelfSGIX(int pname, Single param);
        internal static FragmentLightModelfSGIX glFragmentLightModelfSGIX = (FragmentLightModelfSGIX)Gl.GetDelegateForExtensionMethod("glFragmentLightModelfSGIX", typeof(FragmentLightModelfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightModelfvSGIX(int pname, Single* @params);
        internal unsafe static FragmentLightModelfvSGIX glFragmentLightModelfvSGIX = (FragmentLightModelfvSGIX)Gl.GetDelegateForExtensionMethod("glFragmentLightModelfvSGIX", typeof(FragmentLightModelfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightModeliSGIX(int pname, Int32 param);
        internal static FragmentLightModeliSGIX glFragmentLightModeliSGIX = (FragmentLightModeliSGIX)Gl.GetDelegateForExtensionMethod("glFragmentLightModeliSGIX", typeof(FragmentLightModeliSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightModelivSGIX(int pname, Int32* @params);
        internal unsafe static FragmentLightModelivSGIX glFragmentLightModelivSGIX = (FragmentLightModelivSGIX)Gl.GetDelegateForExtensionMethod("glFragmentLightModelivSGIX", typeof(FragmentLightModelivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentMaterialfSGIX(int face, int pname, Single param);
        internal static FragmentMaterialfSGIX glFragmentMaterialfSGIX = (FragmentMaterialfSGIX)Gl.GetDelegateForExtensionMethod("glFragmentMaterialfSGIX", typeof(FragmentMaterialfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentMaterialfvSGIX(int face, int pname, Single* @params);
        internal unsafe static FragmentMaterialfvSGIX glFragmentMaterialfvSGIX = (FragmentMaterialfvSGIX)Gl.GetDelegateForExtensionMethod("glFragmentMaterialfvSGIX", typeof(FragmentMaterialfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentMaterialiSGIX(int face, int pname, Int32 param);
        internal static FragmentMaterialiSGIX glFragmentMaterialiSGIX = (FragmentMaterialiSGIX)Gl.GetDelegateForExtensionMethod("glFragmentMaterialiSGIX", typeof(FragmentMaterialiSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentMaterialivSGIX(int face, int pname, Int32* @params);
        internal unsafe static FragmentMaterialivSGIX glFragmentMaterialivSGIX = (FragmentMaterialivSGIX)Gl.GetDelegateForExtensionMethod("glFragmentMaterialivSGIX", typeof(FragmentMaterialivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentLightfvSGIX(int light, int pname, [Out] Single* @params);
        internal unsafe static GetFragmentLightfvSGIX glGetFragmentLightfvSGIX = (GetFragmentLightfvSGIX)Gl.GetDelegateForExtensionMethod("glGetFragmentLightfvSGIX", typeof(GetFragmentLightfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentLightivSGIX(int light, int pname, [Out] Int32* @params);
        internal unsafe static GetFragmentLightivSGIX glGetFragmentLightivSGIX = (GetFragmentLightivSGIX)Gl.GetDelegateForExtensionMethod("glGetFragmentLightivSGIX", typeof(GetFragmentLightivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentMaterialfvSGIX(int face, int pname, [Out] Single* @params);
        internal unsafe static GetFragmentMaterialfvSGIX glGetFragmentMaterialfvSGIX = (GetFragmentMaterialfvSGIX)Gl.GetDelegateForExtensionMethod("glGetFragmentMaterialfvSGIX", typeof(GetFragmentMaterialfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentMaterialivSGIX(int face, int pname, [Out] Int32* @params);
        internal unsafe static GetFragmentMaterialivSGIX glGetFragmentMaterialivSGIX = (GetFragmentMaterialivSGIX)Gl.GetDelegateForExtensionMethod("glGetFragmentMaterialivSGIX", typeof(GetFragmentMaterialivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LightEnviSGIX(int pname, Int32 param);
        internal static LightEnviSGIX glLightEnviSGIX = (LightEnviSGIX)Gl.GetDelegateForExtensionMethod("glLightEnviSGIX", typeof(LightEnviSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawRangeElementsEXT(int mode, UInt32 start, UInt32 end, Int32 count, int type, void* indices);
        internal unsafe static DrawRangeElementsEXT glDrawRangeElementsEXT = (DrawRangeElementsEXT)Gl.GetDelegateForExtensionMethod("glDrawRangeElementsEXT", typeof(DrawRangeElementsEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ApplyTextureEXT(int mode);
        internal static ApplyTextureEXT glApplyTextureEXT = (ApplyTextureEXT)Gl.GetDelegateForExtensionMethod("glApplyTextureEXT", typeof(ApplyTextureEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureLightEXT(int pname);
        internal static TextureLightEXT glTextureLightEXT = (TextureLightEXT)Gl.GetDelegateForExtensionMethod("glTextureLightEXT", typeof(TextureLightEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureMaterialEXT(int face, int mode);
        internal static TextureMaterialEXT glTextureMaterialEXT = (TextureMaterialEXT)Gl.GetDelegateForExtensionMethod("glTextureMaterialEXT", typeof(TextureMaterialEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AsyncMarkerSGIX(UInt32 marker);
        internal static AsyncMarkerSGIX glAsyncMarkerSGIX = (AsyncMarkerSGIX)Gl.GetDelegateForExtensionMethod("glAsyncMarkerSGIX", typeof(AsyncMarkerSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Int32 FinishAsyncSGIX([Out] UInt32* markerp);
        internal unsafe static FinishAsyncSGIX glFinishAsyncSGIX = (FinishAsyncSGIX)Gl.GetDelegateForExtensionMethod("glFinishAsyncSGIX", typeof(FinishAsyncSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Int32 PollAsyncSGIX([Out] UInt32* markerp);
        internal unsafe static PollAsyncSGIX glPollAsyncSGIX = (PollAsyncSGIX)Gl.GetDelegateForExtensionMethod("glPollAsyncSGIX", typeof(PollAsyncSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenAsyncMarkersSGIX(Int32 range);
        internal static GenAsyncMarkersSGIX glGenAsyncMarkersSGIX = (GenAsyncMarkersSGIX)Gl.GetDelegateForExtensionMethod("glGenAsyncMarkersSGIX", typeof(GenAsyncMarkersSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);
        internal static DeleteAsyncMarkersSGIX glDeleteAsyncMarkersSGIX = (DeleteAsyncMarkersSGIX)Gl.GetDelegateForExtensionMethod("glDeleteAsyncMarkersSGIX", typeof(DeleteAsyncMarkersSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsAsyncMarkerSGIX(UInt32 marker);
        internal static IsAsyncMarkerSGIX glIsAsyncMarkerSGIX = (IsAsyncMarkerSGIX)Gl.GetDelegateForExtensionMethod("glIsAsyncMarkerSGIX", typeof(IsAsyncMarkerSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointervINTEL(Int32 size, int type, void* pointer);
        internal unsafe static VertexPointervINTEL glVertexPointervINTEL = (VertexPointervINTEL)Gl.GetDelegateForExtensionMethod("glVertexPointervINTEL", typeof(VertexPointervINTEL)) ?? new VertexPointervINTEL(Imports.VertexPointervINTEL);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointervINTEL(int type, void* pointer);
        internal unsafe static NormalPointervINTEL glNormalPointervINTEL = (NormalPointervINTEL)Gl.GetDelegateForExtensionMethod("glNormalPointervINTEL", typeof(NormalPointervINTEL)) ?? new NormalPointervINTEL(Imports.NormalPointervINTEL);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointervINTEL(Int32 size, int type, void* pointer);
        internal unsafe static ColorPointervINTEL glColorPointervINTEL = (ColorPointervINTEL)Gl.GetDelegateForExtensionMethod("glColorPointervINTEL", typeof(ColorPointervINTEL)) ?? new ColorPointervINTEL(Imports.ColorPointervINTEL);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointervINTEL(Int32 size, int type, void* pointer);
        internal unsafe static TexCoordPointervINTEL glTexCoordPointervINTEL = (TexCoordPointervINTEL)Gl.GetDelegateForExtensionMethod("glTexCoordPointervINTEL", typeof(TexCoordPointervINTEL)) ?? new TexCoordPointervINTEL(Imports.TexCoordPointervINTEL);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransformParameteriEXT(int target, int pname, Int32 param);
        internal static PixelTransformParameteriEXT glPixelTransformParameteriEXT = (PixelTransformParameteriEXT)Gl.GetDelegateForExtensionMethod("glPixelTransformParameteriEXT", typeof(PixelTransformParameteriEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransformParameterfEXT(int target, int pname, Single param);
        internal static PixelTransformParameterfEXT glPixelTransformParameterfEXT = (PixelTransformParameterfEXT)Gl.GetDelegateForExtensionMethod("glPixelTransformParameterfEXT", typeof(PixelTransformParameterfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTransformParameterivEXT(int target, int pname, Int32* @params);
        internal unsafe static PixelTransformParameterivEXT glPixelTransformParameterivEXT = (PixelTransformParameterivEXT)Gl.GetDelegateForExtensionMethod("glPixelTransformParameterivEXT", typeof(PixelTransformParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTransformParameterfvEXT(int target, int pname, Single* @params);
        internal unsafe static PixelTransformParameterfvEXT glPixelTransformParameterfvEXT = (PixelTransformParameterfvEXT)Gl.GetDelegateForExtensionMethod("glPixelTransformParameterfvEXT", typeof(PixelTransformParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3bEXT(SByte red, SByte green, SByte blue);
        internal static SecondaryColor3bEXT glSecondaryColor3bEXT = (SecondaryColor3bEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3bEXT", typeof(SecondaryColor3bEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3bvEXT(SByte* v);
        internal unsafe static SecondaryColor3bvEXT glSecondaryColor3bvEXT = (SecondaryColor3bvEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3bvEXT", typeof(SecondaryColor3bvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3dEXT(Double red, Double green, Double blue);
        internal static SecondaryColor3dEXT glSecondaryColor3dEXT = (SecondaryColor3dEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3dEXT", typeof(SecondaryColor3dEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3dvEXT(Double* v);
        internal unsafe static SecondaryColor3dvEXT glSecondaryColor3dvEXT = (SecondaryColor3dvEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3dvEXT", typeof(SecondaryColor3dvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3fEXT(Single red, Single green, Single blue);
        internal static SecondaryColor3fEXT glSecondaryColor3fEXT = (SecondaryColor3fEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3fEXT", typeof(SecondaryColor3fEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3fvEXT(Single* v);
        internal unsafe static SecondaryColor3fvEXT glSecondaryColor3fvEXT = (SecondaryColor3fvEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3fvEXT", typeof(SecondaryColor3fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3iEXT(Int32 red, Int32 green, Int32 blue);
        internal static SecondaryColor3iEXT glSecondaryColor3iEXT = (SecondaryColor3iEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3iEXT", typeof(SecondaryColor3iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3ivEXT(Int32* v);
        internal unsafe static SecondaryColor3ivEXT glSecondaryColor3ivEXT = (SecondaryColor3ivEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3ivEXT", typeof(SecondaryColor3ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3sEXT(Int16 red, Int16 green, Int16 blue);
        internal static SecondaryColor3sEXT glSecondaryColor3sEXT = (SecondaryColor3sEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3sEXT", typeof(SecondaryColor3sEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3svEXT(Int16* v);
        internal unsafe static SecondaryColor3svEXT glSecondaryColor3svEXT = (SecondaryColor3svEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3svEXT", typeof(SecondaryColor3svEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3ubEXT(Byte red, Byte green, Byte blue);
        internal static SecondaryColor3ubEXT glSecondaryColor3ubEXT = (SecondaryColor3ubEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3ubEXT", typeof(SecondaryColor3ubEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3ubvEXT(Byte* v);
        internal unsafe static SecondaryColor3ubvEXT glSecondaryColor3ubvEXT = (SecondaryColor3ubvEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3ubvEXT", typeof(SecondaryColor3ubvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3uiEXT(UInt32 red, UInt32 green, UInt32 blue);
        internal static SecondaryColor3uiEXT glSecondaryColor3uiEXT = (SecondaryColor3uiEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3uiEXT", typeof(SecondaryColor3uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3uivEXT(UInt32* v);
        internal unsafe static SecondaryColor3uivEXT glSecondaryColor3uivEXT = (SecondaryColor3uivEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3uivEXT", typeof(SecondaryColor3uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3usEXT(UInt16 red, UInt16 green, UInt16 blue);
        internal static SecondaryColor3usEXT glSecondaryColor3usEXT = (SecondaryColor3usEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3usEXT", typeof(SecondaryColor3usEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3usvEXT(UInt16* v);
        internal unsafe static SecondaryColor3usvEXT glSecondaryColor3usvEXT = (SecondaryColor3usvEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColor3usvEXT", typeof(SecondaryColor3usvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColorPointerEXT(Int32 size, int type, Int32 stride, void* pointer);
        internal unsafe static SecondaryColorPointerEXT glSecondaryColorPointerEXT = (SecondaryColorPointerEXT)Gl.GetDelegateForExtensionMethod("glSecondaryColorPointerEXT", typeof(SecondaryColorPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureNormalEXT(int mode);
        internal static TextureNormalEXT glTextureNormalEXT = (TextureNormalEXT)Gl.GetDelegateForExtensionMethod("glTextureNormalEXT", typeof(TextureNormalEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawArraysEXT(int mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
        internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT = (MultiDrawArraysEXT)Gl.GetDelegateForExtensionMethod("glMultiDrawArraysEXT", typeof(MultiDrawArraysEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElementsEXT(int mode, Int32* count, int type, void* indices, Int32 primcount);
        internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT = (MultiDrawElementsEXT)Gl.GetDelegateForExtensionMethod("glMultiDrawElementsEXT", typeof(MultiDrawElementsEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordfEXT(Single coord);
        internal static FogCoordfEXT glFogCoordfEXT = (FogCoordfEXT)Gl.GetDelegateForExtensionMethod("glFogCoordfEXT", typeof(FogCoordfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordfvEXT(Single* coord);
        internal unsafe static FogCoordfvEXT glFogCoordfvEXT = (FogCoordfvEXT)Gl.GetDelegateForExtensionMethod("glFogCoordfvEXT", typeof(FogCoordfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoorddEXT(Double coord);
        internal static FogCoorddEXT glFogCoorddEXT = (FogCoorddEXT)Gl.GetDelegateForExtensionMethod("glFogCoorddEXT", typeof(FogCoorddEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoorddvEXT(Double* coord);
        internal unsafe static FogCoorddvEXT glFogCoorddvEXT = (FogCoorddvEXT)Gl.GetDelegateForExtensionMethod("glFogCoorddvEXT", typeof(FogCoorddvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordPointerEXT(int type, Int32 stride, void* pointer);
        internal unsafe static FogCoordPointerEXT glFogCoordPointerEXT = (FogCoordPointerEXT)Gl.GetDelegateForExtensionMethod("glFogCoordPointerEXT", typeof(FogCoordPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3bEXT(SByte tx, SByte ty, SByte tz);
        internal static Tangent3bEXT glTangent3bEXT = (Tangent3bEXT)Gl.GetDelegateForExtensionMethod("glTangent3bEXT", typeof(Tangent3bEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3bvEXT(SByte* v);
        internal unsafe static Tangent3bvEXT glTangent3bvEXT = (Tangent3bvEXT)Gl.GetDelegateForExtensionMethod("glTangent3bvEXT", typeof(Tangent3bvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3dEXT(Double tx, Double ty, Double tz);
        internal static Tangent3dEXT glTangent3dEXT = (Tangent3dEXT)Gl.GetDelegateForExtensionMethod("glTangent3dEXT", typeof(Tangent3dEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3dvEXT(Double* v);
        internal unsafe static Tangent3dvEXT glTangent3dvEXT = (Tangent3dvEXT)Gl.GetDelegateForExtensionMethod("glTangent3dvEXT", typeof(Tangent3dvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3fEXT(Single tx, Single ty, Single tz);
        internal static Tangent3fEXT glTangent3fEXT = (Tangent3fEXT)Gl.GetDelegateForExtensionMethod("glTangent3fEXT", typeof(Tangent3fEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3fvEXT(Single* v);
        internal unsafe static Tangent3fvEXT glTangent3fvEXT = (Tangent3fvEXT)Gl.GetDelegateForExtensionMethod("glTangent3fvEXT", typeof(Tangent3fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3iEXT(Int32 tx, Int32 ty, Int32 tz);
        internal static Tangent3iEXT glTangent3iEXT = (Tangent3iEXT)Gl.GetDelegateForExtensionMethod("glTangent3iEXT", typeof(Tangent3iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3ivEXT(Int32* v);
        internal unsafe static Tangent3ivEXT glTangent3ivEXT = (Tangent3ivEXT)Gl.GetDelegateForExtensionMethod("glTangent3ivEXT", typeof(Tangent3ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3sEXT(Int16 tx, Int16 ty, Int16 tz);
        internal static Tangent3sEXT glTangent3sEXT = (Tangent3sEXT)Gl.GetDelegateForExtensionMethod("glTangent3sEXT", typeof(Tangent3sEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3svEXT(Int16* v);
        internal unsafe static Tangent3svEXT glTangent3svEXT = (Tangent3svEXT)Gl.GetDelegateForExtensionMethod("glTangent3svEXT", typeof(Tangent3svEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3bEXT(SByte bx, SByte by, SByte bz);
        internal static Binormal3bEXT glBinormal3bEXT = (Binormal3bEXT)Gl.GetDelegateForExtensionMethod("glBinormal3bEXT", typeof(Binormal3bEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3bvEXT(SByte* v);
        internal unsafe static Binormal3bvEXT glBinormal3bvEXT = (Binormal3bvEXT)Gl.GetDelegateForExtensionMethod("glBinormal3bvEXT", typeof(Binormal3bvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3dEXT(Double bx, Double by, Double bz);
        internal static Binormal3dEXT glBinormal3dEXT = (Binormal3dEXT)Gl.GetDelegateForExtensionMethod("glBinormal3dEXT", typeof(Binormal3dEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3dvEXT(Double* v);
        internal unsafe static Binormal3dvEXT glBinormal3dvEXT = (Binormal3dvEXT)Gl.GetDelegateForExtensionMethod("glBinormal3dvEXT", typeof(Binormal3dvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3fEXT(Single bx, Single by, Single bz);
        internal static Binormal3fEXT glBinormal3fEXT = (Binormal3fEXT)Gl.GetDelegateForExtensionMethod("glBinormal3fEXT", typeof(Binormal3fEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3fvEXT(Single* v);
        internal unsafe static Binormal3fvEXT glBinormal3fvEXT = (Binormal3fvEXT)Gl.GetDelegateForExtensionMethod("glBinormal3fvEXT", typeof(Binormal3fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3iEXT(Int32 bx, Int32 by, Int32 bz);
        internal static Binormal3iEXT glBinormal3iEXT = (Binormal3iEXT)Gl.GetDelegateForExtensionMethod("glBinormal3iEXT", typeof(Binormal3iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3ivEXT(Int32* v);
        internal unsafe static Binormal3ivEXT glBinormal3ivEXT = (Binormal3ivEXT)Gl.GetDelegateForExtensionMethod("glBinormal3ivEXT", typeof(Binormal3ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3sEXT(Int16 bx, Int16 by, Int16 bz);
        internal static Binormal3sEXT glBinormal3sEXT = (Binormal3sEXT)Gl.GetDelegateForExtensionMethod("glBinormal3sEXT", typeof(Binormal3sEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3svEXT(Int16* v);
        internal unsafe static Binormal3svEXT glBinormal3svEXT = (Binormal3svEXT)Gl.GetDelegateForExtensionMethod("glBinormal3svEXT", typeof(Binormal3svEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TangentPointerEXT(int type, Int32 stride, void* pointer);
        internal unsafe static TangentPointerEXT glTangentPointerEXT = (TangentPointerEXT)Gl.GetDelegateForExtensionMethod("glTangentPointerEXT", typeof(TangentPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BinormalPointerEXT(int type, Int32 stride, void* pointer);
        internal unsafe static BinormalPointerEXT glBinormalPointerEXT = (BinormalPointerEXT)Gl.GetDelegateForExtensionMethod("glBinormalPointerEXT", typeof(BinormalPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishTextureSUNX();
        internal static FinishTextureSUNX glFinishTextureSUNX = (FinishTextureSUNX)Gl.GetDelegateForExtensionMethod("glFinishTextureSUNX", typeof(FinishTextureSUNX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorbSUN(SByte factor);
        internal static GlobalAlphaFactorbSUN glGlobalAlphaFactorbSUN = (GlobalAlphaFactorbSUN)Gl.GetDelegateForExtensionMethod("glGlobalAlphaFactorbSUN", typeof(GlobalAlphaFactorbSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorsSUN(Int16 factor);
        internal static GlobalAlphaFactorsSUN glGlobalAlphaFactorsSUN = (GlobalAlphaFactorsSUN)Gl.GetDelegateForExtensionMethod("glGlobalAlphaFactorsSUN", typeof(GlobalAlphaFactorsSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactoriSUN(Int32 factor);
        internal static GlobalAlphaFactoriSUN glGlobalAlphaFactoriSUN = (GlobalAlphaFactoriSUN)Gl.GetDelegateForExtensionMethod("glGlobalAlphaFactoriSUN", typeof(GlobalAlphaFactoriSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorfSUN(Single factor);
        internal static GlobalAlphaFactorfSUN glGlobalAlphaFactorfSUN = (GlobalAlphaFactorfSUN)Gl.GetDelegateForExtensionMethod("glGlobalAlphaFactorfSUN", typeof(GlobalAlphaFactorfSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactordSUN(Double factor);
        internal static GlobalAlphaFactordSUN glGlobalAlphaFactordSUN = (GlobalAlphaFactordSUN)Gl.GetDelegateForExtensionMethod("glGlobalAlphaFactordSUN", typeof(GlobalAlphaFactordSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorubSUN(Byte factor);
        internal static GlobalAlphaFactorubSUN glGlobalAlphaFactorubSUN = (GlobalAlphaFactorubSUN)Gl.GetDelegateForExtensionMethod("glGlobalAlphaFactorubSUN", typeof(GlobalAlphaFactorubSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorusSUN(UInt16 factor);
        internal static GlobalAlphaFactorusSUN glGlobalAlphaFactorusSUN = (GlobalAlphaFactorusSUN)Gl.GetDelegateForExtensionMethod("glGlobalAlphaFactorusSUN", typeof(GlobalAlphaFactorusSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactoruiSUN(UInt32 factor);
        internal static GlobalAlphaFactoruiSUN glGlobalAlphaFactoruiSUN = (GlobalAlphaFactoruiSUN)Gl.GetDelegateForExtensionMethod("glGlobalAlphaFactoruiSUN", typeof(GlobalAlphaFactoruiSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiSUN(UInt32 code);
        internal static ReplacementCodeuiSUN glReplacementCodeuiSUN = (ReplacementCodeuiSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiSUN", typeof(ReplacementCodeuiSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeusSUN(UInt16 code);
        internal static ReplacementCodeusSUN glReplacementCodeusSUN = (ReplacementCodeusSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeusSUN", typeof(ReplacementCodeusSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeubSUN(Byte code);
        internal static ReplacementCodeubSUN glReplacementCodeubSUN = (ReplacementCodeubSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeubSUN", typeof(ReplacementCodeubSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuivSUN(UInt32* code);
        internal unsafe static ReplacementCodeuivSUN glReplacementCodeuivSUN = (ReplacementCodeuivSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuivSUN", typeof(ReplacementCodeuivSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeusvSUN(UInt16* code);
        internal unsafe static ReplacementCodeusvSUN glReplacementCodeusvSUN = (ReplacementCodeusvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeusvSUN", typeof(ReplacementCodeusvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeubvSUN(Byte* code);
        internal unsafe static ReplacementCodeubvSUN glReplacementCodeubvSUN = (ReplacementCodeubvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeubvSUN", typeof(ReplacementCodeubvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodePointerSUN(int type, Int32 stride, void* pointer);
        internal unsafe static ReplacementCodePointerSUN glReplacementCodePointerSUN = (ReplacementCodePointerSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodePointerSUN", typeof(ReplacementCodePointerSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ubVertex2fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y);
        internal static Color4ubVertex2fSUN glColor4ubVertex2fSUN = (Color4ubVertex2fSUN)Gl.GetDelegateForExtensionMethod("glColor4ubVertex2fSUN", typeof(Color4ubVertex2fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4ubVertex2fvSUN(Byte* c, Single* v);
        internal unsafe static Color4ubVertex2fvSUN glColor4ubVertex2fvSUN = (Color4ubVertex2fvSUN)Gl.GetDelegateForExtensionMethod("glColor4ubVertex2fvSUN", typeof(Color4ubVertex2fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ubVertex3fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
        internal static Color4ubVertex3fSUN glColor4ubVertex3fSUN = (Color4ubVertex3fSUN)Gl.GetDelegateForExtensionMethod("glColor4ubVertex3fSUN", typeof(Color4ubVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4ubVertex3fvSUN(Byte* c, Single* v);
        internal unsafe static Color4ubVertex3fvSUN glColor4ubVertex3fvSUN = (Color4ubVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glColor4ubVertex3fvSUN", typeof(Color4ubVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3fVertex3fSUN(Single r, Single g, Single b, Single x, Single y, Single z);
        internal static Color3fVertex3fSUN glColor3fVertex3fSUN = (Color3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glColor3fVertex3fSUN", typeof(Color3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3fVertex3fvSUN(Single* c, Single* v);
        internal unsafe static Color3fVertex3fvSUN glColor3fVertex3fvSUN = (Color3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glColor3fVertex3fvSUN", typeof(Color3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3fVertex3fSUN(Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static Normal3fVertex3fSUN glNormal3fVertex3fSUN = (Normal3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glNormal3fVertex3fSUN", typeof(Normal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3fVertex3fvSUN(Single* n, Single* v);
        internal unsafe static Normal3fVertex3fvSUN glNormal3fVertex3fvSUN = (Normal3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glNormal3fVertex3fvSUN", typeof(Normal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4fNormal3fVertex3fSUN(Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static Color4fNormal3fVertex3fSUN glColor4fNormal3fVertex3fSUN = (Color4fNormal3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glColor4fNormal3fVertex3fSUN", typeof(Color4fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4fNormal3fVertex3fvSUN(Single* c, Single* n, Single* v);
        internal unsafe static Color4fNormal3fVertex3fvSUN glColor4fNormal3fVertex3fvSUN = (Color4fNormal3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glColor4fNormal3fVertex3fvSUN", typeof(Color4fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fVertex3fSUN(Single s, Single t, Single x, Single y, Single z);
        internal static TexCoord2fVertex3fSUN glTexCoord2fVertex3fSUN = (TexCoord2fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fVertex3fSUN", typeof(TexCoord2fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fVertex3fvSUN(Single* tc, Single* v);
        internal unsafe static TexCoord2fVertex3fvSUN glTexCoord2fVertex3fvSUN = (TexCoord2fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fVertex3fvSUN", typeof(TexCoord2fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4fVertex4fSUN(Single s, Single t, Single p, Single q, Single x, Single y, Single z, Single w);
        internal static TexCoord4fVertex4fSUN glTexCoord4fVertex4fSUN = (TexCoord4fVertex4fSUN)Gl.GetDelegateForExtensionMethod("glTexCoord4fVertex4fSUN", typeof(TexCoord4fVertex4fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4fVertex4fvSUN(Single* tc, Single* v);
        internal unsafe static TexCoord4fVertex4fvSUN glTexCoord4fVertex4fvSUN = (TexCoord4fVertex4fvSUN)Gl.GetDelegateForExtensionMethod("glTexCoord4fVertex4fvSUN", typeof(TexCoord4fVertex4fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fColor4ubVertex3fSUN(Single s, Single t, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
        internal static TexCoord2fColor4ubVertex3fSUN glTexCoord2fColor4ubVertex3fSUN = (TexCoord2fColor4ubVertex3fSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fColor4ubVertex3fSUN", typeof(TexCoord2fColor4ubVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fColor4ubVertex3fvSUN(Single* tc, Byte* c, Single* v);
        internal unsafe static TexCoord2fColor4ubVertex3fvSUN glTexCoord2fColor4ubVertex3fvSUN = (TexCoord2fColor4ubVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fColor4ubVertex3fvSUN", typeof(TexCoord2fColor4ubVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fColor3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single x, Single y, Single z);
        internal static TexCoord2fColor3fVertex3fSUN glTexCoord2fColor3fVertex3fSUN = (TexCoord2fColor3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fColor3fVertex3fSUN", typeof(TexCoord2fColor3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fColor3fVertex3fvSUN(Single* tc, Single* c, Single* v);
        internal unsafe static TexCoord2fColor3fVertex3fvSUN glTexCoord2fColor3fVertex3fvSUN = (TexCoord2fColor3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fColor3fVertex3fvSUN", typeof(TexCoord2fColor3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fNormal3fVertex3fSUN(Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static TexCoord2fNormal3fVertex3fSUN glTexCoord2fNormal3fVertex3fSUN = (TexCoord2fNormal3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fNormal3fVertex3fSUN", typeof(TexCoord2fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fNormal3fVertex3fvSUN(Single* tc, Single* n, Single* v);
        internal unsafe static TexCoord2fNormal3fVertex3fvSUN glTexCoord2fNormal3fVertex3fvSUN = (TexCoord2fNormal3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fNormal3fVertex3fvSUN", typeof(TexCoord2fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fColor4fNormal3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static TexCoord2fColor4fNormal3fVertex3fSUN glTexCoord2fColor4fNormal3fVertex3fSUN = (TexCoord2fColor4fNormal3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fColor4fNormal3fVertex3fSUN", typeof(TexCoord2fColor4fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fColor4fNormal3fVertex3fvSUN(Single* tc, Single* c, Single* n, Single* v);
        internal unsafe static TexCoord2fColor4fNormal3fVertex3fvSUN glTexCoord2fColor4fNormal3fVertex3fvSUN = (TexCoord2fColor4fNormal3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(TexCoord2fColor4fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4fColor4fNormal3fVertex4fSUN(Single s, Single t, Single p, Single q, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z, Single w);
        internal static TexCoord4fColor4fNormal3fVertex4fSUN glTexCoord4fColor4fNormal3fVertex4fSUN = (TexCoord4fColor4fNormal3fVertex4fSUN)Gl.GetDelegateForExtensionMethod("glTexCoord4fColor4fNormal3fVertex4fSUN", typeof(TexCoord4fColor4fNormal3fVertex4fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4fColor4fNormal3fVertex4fvSUN(Single* tc, Single* c, Single* n, Single* v);
        internal unsafe static TexCoord4fColor4fNormal3fVertex4fvSUN glTexCoord4fColor4fNormal3fVertex4fvSUN = (TexCoord4fColor4fNormal3fVertex4fvSUN)Gl.GetDelegateForExtensionMethod("glTexCoord4fColor4fNormal3fVertex4fvSUN", typeof(TexCoord4fColor4fNormal3fVertex4fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiVertex3fSUN(UInt32 rc, Single x, Single y, Single z);
        internal static ReplacementCodeuiVertex3fSUN glReplacementCodeuiVertex3fSUN = (ReplacementCodeuiVertex3fSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiVertex3fSUN", typeof(ReplacementCodeuiVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiVertex3fvSUN(UInt32* rc, Single* v);
        internal unsafe static ReplacementCodeuiVertex3fvSUN glReplacementCodeuiVertex3fvSUN = (ReplacementCodeuiVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiVertex3fvSUN", typeof(ReplacementCodeuiVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
        internal static ReplacementCodeuiColor4ubVertex3fSUN glReplacementCodeuiColor4ubVertex3fSUN = (ReplacementCodeuiColor4ubVertex3fSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiColor4ubVertex3fSUN", typeof(ReplacementCodeuiColor4ubVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, Byte* c, Single* v);
        internal unsafe static ReplacementCodeuiColor4ubVertex3fvSUN glReplacementCodeuiColor4ubVertex3fvSUN = (ReplacementCodeuiColor4ubVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiColor4ubVertex3fvSUN", typeof(ReplacementCodeuiColor4ubVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single x, Single y, Single z);
        internal static ReplacementCodeuiColor3fVertex3fSUN glReplacementCodeuiColor3fVertex3fSUN = (ReplacementCodeuiColor3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiColor3fVertex3fSUN", typeof(ReplacementCodeuiColor3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, Single* c, Single* v);
        internal unsafe static ReplacementCodeuiColor3fVertex3fvSUN glReplacementCodeuiColor3fVertex3fvSUN = (ReplacementCodeuiColor3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiColor3fVertex3fvSUN", typeof(ReplacementCodeuiColor3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static ReplacementCodeuiNormal3fVertex3fSUN glReplacementCodeuiNormal3fVertex3fSUN = (ReplacementCodeuiNormal3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiNormal3fVertex3fSUN", typeof(ReplacementCodeuiNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, Single* n, Single* v);
        internal unsafe static ReplacementCodeuiNormal3fVertex3fvSUN glReplacementCodeuiNormal3fVertex3fvSUN = (ReplacementCodeuiNormal3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiNormal3fVertex3fvSUN", typeof(ReplacementCodeuiNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static ReplacementCodeuiColor4fNormal3fVertex3fSUN glReplacementCodeuiColor4fNormal3fVertex3fSUN = (ReplacementCodeuiColor4fNormal3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiColor4fNormal3fVertex3fSUN", typeof(ReplacementCodeuiColor4fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* c, Single* n, Single* v);
        internal unsafe static ReplacementCodeuiColor4fNormal3fVertex3fvSUN glReplacementCodeuiColor4fNormal3fVertex3fvSUN = (ReplacementCodeuiColor4fNormal3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiColor4fNormal3fVertex3fvSUN", typeof(ReplacementCodeuiColor4fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, Single s, Single t, Single x, Single y, Single z);
        internal static ReplacementCodeuiTexCoord2fVertex3fSUN glReplacementCodeuiTexCoord2fVertex3fSUN = (ReplacementCodeuiTexCoord2fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fVertex3fSUN", typeof(ReplacementCodeuiTexCoord2fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, Single* tc, Single* v);
        internal unsafe static ReplacementCodeuiTexCoord2fVertex3fvSUN glReplacementCodeuiTexCoord2fVertex3fvSUN = (ReplacementCodeuiTexCoord2fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fVertex3fvSUN", typeof(ReplacementCodeuiTexCoord2fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN = (ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", typeof(ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* n, Single* v);
        internal unsafe static ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN = (ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", typeof(ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN = (ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", typeof(ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* c, Single* n, Single* v);
        internal unsafe static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN = (ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN)Gl.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparateEXT(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
        internal static BlendFuncSeparateEXT glBlendFuncSeparateEXT = (BlendFuncSeparateEXT)Gl.GetDelegateForExtensionMethod("glBlendFuncSeparateEXT", typeof(BlendFuncSeparateEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparateINGR(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
        internal static BlendFuncSeparateINGR glBlendFuncSeparateINGR = (BlendFuncSeparateINGR)Gl.GetDelegateForExtensionMethod("glBlendFuncSeparateINGR", typeof(BlendFuncSeparateINGR));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexWeightfEXT(Single weight);
        internal static VertexWeightfEXT glVertexWeightfEXT = (VertexWeightfEXT)Gl.GetDelegateForExtensionMethod("glVertexWeightfEXT", typeof(VertexWeightfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexWeightfvEXT(Single* weight);
        internal unsafe static VertexWeightfvEXT glVertexWeightfvEXT = (VertexWeightfvEXT)Gl.GetDelegateForExtensionMethod("glVertexWeightfvEXT", typeof(VertexWeightfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexWeightPointerEXT(Int32 size, int type, Int32 stride, void* pointer);
        internal unsafe static VertexWeightPointerEXT glVertexWeightPointerEXT = (VertexWeightPointerEXT)Gl.GetDelegateForExtensionMethod("glVertexWeightPointerEXT", typeof(VertexWeightPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushVertexArrayRangeNV();
        internal static FlushVertexArrayRangeNV glFlushVertexArrayRangeNV = (FlushVertexArrayRangeNV)Gl.GetDelegateForExtensionMethod("glFlushVertexArrayRangeNV", typeof(FlushVertexArrayRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexArrayRangeNV(Int32 length, void* pointer);
        internal unsafe static VertexArrayRangeNV glVertexArrayRangeNV = (VertexArrayRangeNV)Gl.GetDelegateForExtensionMethod("glVertexArrayRangeNV", typeof(VertexArrayRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CombinerParameterfvNV(int pname, Single* @params);
        internal unsafe static CombinerParameterfvNV glCombinerParameterfvNV = (CombinerParameterfvNV)Gl.GetDelegateForExtensionMethod("glCombinerParameterfvNV", typeof(CombinerParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerParameterfNV(int pname, Single param);
        internal static CombinerParameterfNV glCombinerParameterfNV = (CombinerParameterfNV)Gl.GetDelegateForExtensionMethod("glCombinerParameterfNV", typeof(CombinerParameterfNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CombinerParameterivNV(int pname, Int32* @params);
        internal unsafe static CombinerParameterivNV glCombinerParameterivNV = (CombinerParameterivNV)Gl.GetDelegateForExtensionMethod("glCombinerParameterivNV", typeof(CombinerParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerParameteriNV(int pname, Int32 param);
        internal static CombinerParameteriNV glCombinerParameteriNV = (CombinerParameteriNV)Gl.GetDelegateForExtensionMethod("glCombinerParameteriNV", typeof(CombinerParameteriNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerInputNV(int stage, int portion, int variable, int input, int mapping, int componentUsage);
        internal static CombinerInputNV glCombinerInputNV = (CombinerInputNV)Gl.GetDelegateForExtensionMethod("glCombinerInputNV", typeof(CombinerInputNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerOutputNV(int stage, int portion, int abOutput, int cdOutput, int sumOutput, int scale, int bias, int abDotProduct, int cdDotProduct, int muxSum);
        internal static CombinerOutputNV glCombinerOutputNV = (CombinerOutputNV)Gl.GetDelegateForExtensionMethod("glCombinerOutputNV", typeof(CombinerOutputNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinalCombinerInputNV(int variable, int input, int mapping, int componentUsage);
        internal static FinalCombinerInputNV glFinalCombinerInputNV = (FinalCombinerInputNV)Gl.GetDelegateForExtensionMethod("glFinalCombinerInputNV", typeof(FinalCombinerInputNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerInputParameterfvNV(int stage, int portion, int variable, int pname, [Out] Single* @params);
        internal unsafe static GetCombinerInputParameterfvNV glGetCombinerInputParameterfvNV = (GetCombinerInputParameterfvNV)Gl.GetDelegateForExtensionMethod("glGetCombinerInputParameterfvNV", typeof(GetCombinerInputParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerInputParameterivNV(int stage, int portion, int variable, int pname, [Out] Int32* @params);
        internal unsafe static GetCombinerInputParameterivNV glGetCombinerInputParameterivNV = (GetCombinerInputParameterivNV)Gl.GetDelegateForExtensionMethod("glGetCombinerInputParameterivNV", typeof(GetCombinerInputParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerOutputParameterfvNV(int stage, int portion, int pname, [Out] Single* @params);
        internal unsafe static GetCombinerOutputParameterfvNV glGetCombinerOutputParameterfvNV = (GetCombinerOutputParameterfvNV)Gl.GetDelegateForExtensionMethod("glGetCombinerOutputParameterfvNV", typeof(GetCombinerOutputParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerOutputParameterivNV(int stage, int portion, int pname, [Out] Int32* @params);
        internal unsafe static GetCombinerOutputParameterivNV glGetCombinerOutputParameterivNV = (GetCombinerOutputParameterivNV)Gl.GetDelegateForExtensionMethod("glGetCombinerOutputParameterivNV", typeof(GetCombinerOutputParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFinalCombinerInputParameterfvNV(int variable, int pname, [Out] Single* @params);
        internal unsafe static GetFinalCombinerInputParameterfvNV glGetFinalCombinerInputParameterfvNV = (GetFinalCombinerInputParameterfvNV)Gl.GetDelegateForExtensionMethod("glGetFinalCombinerInputParameterfvNV", typeof(GetFinalCombinerInputParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFinalCombinerInputParameterivNV(int variable, int pname, [Out] Int32* @params);
        internal unsafe static GetFinalCombinerInputParameterivNV glGetFinalCombinerInputParameterivNV = (GetFinalCombinerInputParameterivNV)Gl.GetDelegateForExtensionMethod("glGetFinalCombinerInputParameterivNV", typeof(GetFinalCombinerInputParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResizeBuffersMESA();
        internal static ResizeBuffersMESA glResizeBuffersMESA = (ResizeBuffersMESA)Gl.GetDelegateForExtensionMethod("glResizeBuffersMESA", typeof(ResizeBuffersMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2dMESA(Double x, Double y);
        internal static WindowPos2dMESA glWindowPos2dMESA = (WindowPos2dMESA)Gl.GetDelegateForExtensionMethod("glWindowPos2dMESA", typeof(WindowPos2dMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2dvMESA(Double* v);
        internal unsafe static WindowPos2dvMESA glWindowPos2dvMESA = (WindowPos2dvMESA)Gl.GetDelegateForExtensionMethod("glWindowPos2dvMESA", typeof(WindowPos2dvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2fMESA(Single x, Single y);
        internal static WindowPos2fMESA glWindowPos2fMESA = (WindowPos2fMESA)Gl.GetDelegateForExtensionMethod("glWindowPos2fMESA", typeof(WindowPos2fMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2fvMESA(Single* v);
        internal unsafe static WindowPos2fvMESA glWindowPos2fvMESA = (WindowPos2fvMESA)Gl.GetDelegateForExtensionMethod("glWindowPos2fvMESA", typeof(WindowPos2fvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2iMESA(Int32 x, Int32 y);
        internal static WindowPos2iMESA glWindowPos2iMESA = (WindowPos2iMESA)Gl.GetDelegateForExtensionMethod("glWindowPos2iMESA", typeof(WindowPos2iMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2ivMESA(Int32* v);
        internal unsafe static WindowPos2ivMESA glWindowPos2ivMESA = (WindowPos2ivMESA)Gl.GetDelegateForExtensionMethod("glWindowPos2ivMESA", typeof(WindowPos2ivMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2sMESA(Int16 x, Int16 y);
        internal static WindowPos2sMESA glWindowPos2sMESA = (WindowPos2sMESA)Gl.GetDelegateForExtensionMethod("glWindowPos2sMESA", typeof(WindowPos2sMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2svMESA(Int16* v);
        internal unsafe static WindowPos2svMESA glWindowPos2svMESA = (WindowPos2svMESA)Gl.GetDelegateForExtensionMethod("glWindowPos2svMESA", typeof(WindowPos2svMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3dMESA(Double x, Double y, Double z);
        internal static WindowPos3dMESA glWindowPos3dMESA = (WindowPos3dMESA)Gl.GetDelegateForExtensionMethod("glWindowPos3dMESA", typeof(WindowPos3dMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3dvMESA(Double* v);
        internal unsafe static WindowPos3dvMESA glWindowPos3dvMESA = (WindowPos3dvMESA)Gl.GetDelegateForExtensionMethod("glWindowPos3dvMESA", typeof(WindowPos3dvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3fMESA(Single x, Single y, Single z);
        internal static WindowPos3fMESA glWindowPos3fMESA = (WindowPos3fMESA)Gl.GetDelegateForExtensionMethod("glWindowPos3fMESA", typeof(WindowPos3fMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3fvMESA(Single* v);
        internal unsafe static WindowPos3fvMESA glWindowPos3fvMESA = (WindowPos3fvMESA)Gl.GetDelegateForExtensionMethod("glWindowPos3fvMESA", typeof(WindowPos3fvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3iMESA(Int32 x, Int32 y, Int32 z);
        internal static WindowPos3iMESA glWindowPos3iMESA = (WindowPos3iMESA)Gl.GetDelegateForExtensionMethod("glWindowPos3iMESA", typeof(WindowPos3iMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3ivMESA(Int32* v);
        internal unsafe static WindowPos3ivMESA glWindowPos3ivMESA = (WindowPos3ivMESA)Gl.GetDelegateForExtensionMethod("glWindowPos3ivMESA", typeof(WindowPos3ivMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3sMESA(Int16 x, Int16 y, Int16 z);
        internal static WindowPos3sMESA glWindowPos3sMESA = (WindowPos3sMESA)Gl.GetDelegateForExtensionMethod("glWindowPos3sMESA", typeof(WindowPos3sMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3svMESA(Int16* v);
        internal unsafe static WindowPos3svMESA glWindowPos3svMESA = (WindowPos3svMESA)Gl.GetDelegateForExtensionMethod("glWindowPos3svMESA", typeof(WindowPos3svMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4dMESA(Double x, Double y, Double z, Double w);
        internal static WindowPos4dMESA glWindowPos4dMESA = (WindowPos4dMESA)Gl.GetDelegateForExtensionMethod("glWindowPos4dMESA", typeof(WindowPos4dMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4dvMESA(Double* v);
        internal unsafe static WindowPos4dvMESA glWindowPos4dvMESA = (WindowPos4dvMESA)Gl.GetDelegateForExtensionMethod("glWindowPos4dvMESA", typeof(WindowPos4dvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4fMESA(Single x, Single y, Single z, Single w);
        internal static WindowPos4fMESA glWindowPos4fMESA = (WindowPos4fMESA)Gl.GetDelegateForExtensionMethod("glWindowPos4fMESA", typeof(WindowPos4fMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4fvMESA(Single* v);
        internal unsafe static WindowPos4fvMESA glWindowPos4fvMESA = (WindowPos4fvMESA)Gl.GetDelegateForExtensionMethod("glWindowPos4fvMESA", typeof(WindowPos4fvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);
        internal static WindowPos4iMESA glWindowPos4iMESA = (WindowPos4iMESA)Gl.GetDelegateForExtensionMethod("glWindowPos4iMESA", typeof(WindowPos4iMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4ivMESA(Int32* v);
        internal unsafe static WindowPos4ivMESA glWindowPos4ivMESA = (WindowPos4ivMESA)Gl.GetDelegateForExtensionMethod("glWindowPos4ivMESA", typeof(WindowPos4ivMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);
        internal static WindowPos4sMESA glWindowPos4sMESA = (WindowPos4sMESA)Gl.GetDelegateForExtensionMethod("glWindowPos4sMESA", typeof(WindowPos4sMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4svMESA(Int16* v);
        internal unsafe static WindowPos4svMESA glWindowPos4svMESA = (WindowPos4svMESA)Gl.GetDelegateForExtensionMethod("glWindowPos4svMESA", typeof(WindowPos4svMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiModeDrawArraysIBM(int* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);
        internal unsafe static MultiModeDrawArraysIBM glMultiModeDrawArraysIBM = (MultiModeDrawArraysIBM)Gl.GetDelegateForExtensionMethod("glMultiModeDrawArraysIBM", typeof(MultiModeDrawArraysIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiModeDrawElementsIBM(int* mode, Int32* count, int type, void* indices, Int32 primcount, Int32 modestride);
        internal unsafe static MultiModeDrawElementsIBM glMultiModeDrawElementsIBM = (MultiModeDrawElementsIBM)Gl.GetDelegateForExtensionMethod("glMultiModeDrawElementsIBM", typeof(MultiModeDrawElementsIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointerListIBM(Int32 size, int type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static ColorPointerListIBM glColorPointerListIBM = (ColorPointerListIBM)Gl.GetDelegateForExtensionMethod("glColorPointerListIBM", typeof(ColorPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColorPointerListIBM(Int32 size, int type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static SecondaryColorPointerListIBM glSecondaryColorPointerListIBM = (SecondaryColorPointerListIBM)Gl.GetDelegateForExtensionMethod("glSecondaryColorPointerListIBM", typeof(SecondaryColorPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagPointerListIBM(Int32 stride, Boolean* pointer, Int32 ptrstride);
        internal unsafe static EdgeFlagPointerListIBM glEdgeFlagPointerListIBM = (EdgeFlagPointerListIBM)Gl.GetDelegateForExtensionMethod("glEdgeFlagPointerListIBM", typeof(EdgeFlagPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordPointerListIBM(int type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static FogCoordPointerListIBM glFogCoordPointerListIBM = (FogCoordPointerListIBM)Gl.GetDelegateForExtensionMethod("glFogCoordPointerListIBM", typeof(FogCoordPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IndexPointerListIBM(int type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static IndexPointerListIBM glIndexPointerListIBM = (IndexPointerListIBM)Gl.GetDelegateForExtensionMethod("glIndexPointerListIBM", typeof(IndexPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointerListIBM(int type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static NormalPointerListIBM glNormalPointerListIBM = (NormalPointerListIBM)Gl.GetDelegateForExtensionMethod("glNormalPointerListIBM", typeof(NormalPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointerListIBM(Int32 size, int type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static TexCoordPointerListIBM glTexCoordPointerListIBM = (TexCoordPointerListIBM)Gl.GetDelegateForExtensionMethod("glTexCoordPointerListIBM", typeof(TexCoordPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointerListIBM(Int32 size, int type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static VertexPointerListIBM glVertexPointerListIBM = (VertexPointerListIBM)Gl.GetDelegateForExtensionMethod("glVertexPointerListIBM", typeof(VertexPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TbufferMask3DFX(UInt32 mask);
        internal static TbufferMask3DFX glTbufferMask3DFX = (TbufferMask3DFX)Gl.GetDelegateForExtensionMethod("glTbufferMask3DFX", typeof(TbufferMask3DFX)) ?? new TbufferMask3DFX(Imports.TbufferMask3DFX);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMaskEXT(Single value, int invert);
        internal static SampleMaskEXT glSampleMaskEXT = (SampleMaskEXT)Gl.GetDelegateForExtensionMethod("glSampleMaskEXT", typeof(SampleMaskEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SamplePatternEXT(int pattern);
        internal static SamplePatternEXT glSamplePatternEXT = (SamplePatternEXT)Gl.GetDelegateForExtensionMethod("glSamplePatternEXT", typeof(SamplePatternEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureColorMaskSGIS(int red, int green, int blue, int alpha);
        internal static TextureColorMaskSGIS glTextureColorMaskSGIS = (TextureColorMaskSGIS)Gl.GetDelegateForExtensionMethod("glTextureColorMaskSGIS", typeof(TextureColorMaskSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IglooInterfaceSGIX(int pname, void* @params);
        internal unsafe static IglooInterfaceSGIX glIglooInterfaceSGIX = (IglooInterfaceSGIX)Gl.GetDelegateForExtensionMethod("glIglooInterfaceSGIX", typeof(IglooInterfaceSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
        internal unsafe static DeleteFencesNV glDeleteFencesNV = (DeleteFencesNV)Gl.GetDelegateForExtensionMethod("glDeleteFencesNV", typeof(DeleteFencesNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFencesNV(Int32 n, [Out] UInt32* fences);
        internal unsafe static GenFencesNV glGenFencesNV = (GenFencesNV)Gl.GetDelegateForExtensionMethod("glGenFencesNV", typeof(GenFencesNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsFenceNV(UInt32 fence);
        internal static IsFenceNV glIsFenceNV = (IsFenceNV)Gl.GetDelegateForExtensionMethod("glIsFenceNV", typeof(IsFenceNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int TestFenceNV(UInt32 fence);
        internal static TestFenceNV glTestFenceNV = (TestFenceNV)Gl.GetDelegateForExtensionMethod("glTestFenceNV", typeof(TestFenceNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFenceivNV(UInt32 fence, int pname, [Out] Int32* @params);
        internal unsafe static GetFenceivNV glGetFenceivNV = (GetFenceivNV)Gl.GetDelegateForExtensionMethod("glGetFenceivNV", typeof(GetFenceivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishFenceNV(UInt32 fence);
        internal static FinishFenceNV glFinishFenceNV = (FinishFenceNV)Gl.GetDelegateForExtensionMethod("glFinishFenceNV", typeof(FinishFenceNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SetFenceNV(UInt32 fence, int condition);
        internal static SetFenceNV glSetFenceNV = (SetFenceNV)Gl.GetDelegateForExtensionMethod("glSetFenceNV", typeof(SetFenceNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MapControlPointsNV(int target, UInt32 index, int type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, int packed, void* points);
        internal unsafe static MapControlPointsNV glMapControlPointsNV = (MapControlPointsNV)Gl.GetDelegateForExtensionMethod("glMapControlPointsNV", typeof(MapControlPointsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MapParameterivNV(int target, int pname, Int32* @params);
        internal unsafe static MapParameterivNV glMapParameterivNV = (MapParameterivNV)Gl.GetDelegateForExtensionMethod("glMapParameterivNV", typeof(MapParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MapParameterfvNV(int target, int pname, Single* @params);
        internal unsafe static MapParameterfvNV glMapParameterfvNV = (MapParameterfvNV)Gl.GetDelegateForExtensionMethod("glMapParameterfvNV", typeof(MapParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapControlPointsNV(int target, UInt32 index, int type, Int32 ustride, Int32 vstride, int packed, [Out] void* points);
        internal unsafe static GetMapControlPointsNV glGetMapControlPointsNV = (GetMapControlPointsNV)Gl.GetDelegateForExtensionMethod("glGetMapControlPointsNV", typeof(GetMapControlPointsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapParameterivNV(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetMapParameterivNV glGetMapParameterivNV = (GetMapParameterivNV)Gl.GetDelegateForExtensionMethod("glGetMapParameterivNV", typeof(GetMapParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapParameterfvNV(int target, int pname, [Out] Single* @params);
        internal unsafe static GetMapParameterfvNV glGetMapParameterfvNV = (GetMapParameterfvNV)Gl.GetDelegateForExtensionMethod("glGetMapParameterfvNV", typeof(GetMapParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapAttribParameterivNV(int target, UInt32 index, int pname, [Out] Int32* @params);
        internal unsafe static GetMapAttribParameterivNV glGetMapAttribParameterivNV = (GetMapAttribParameterivNV)Gl.GetDelegateForExtensionMethod("glGetMapAttribParameterivNV", typeof(GetMapAttribParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapAttribParameterfvNV(int target, UInt32 index, int pname, [Out] Single* @params);
        internal unsafe static GetMapAttribParameterfvNV glGetMapAttribParameterfvNV = (GetMapAttribParameterfvNV)Gl.GetDelegateForExtensionMethod("glGetMapAttribParameterfvNV", typeof(GetMapAttribParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalMapsNV(int target, int mode);
        internal static EvalMapsNV glEvalMapsNV = (EvalMapsNV)Gl.GetDelegateForExtensionMethod("glEvalMapsNV", typeof(EvalMapsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CombinerStageParameterfvNV(int stage, int pname, Single* @params);
        internal unsafe static CombinerStageParameterfvNV glCombinerStageParameterfvNV = (CombinerStageParameterfvNV)Gl.GetDelegateForExtensionMethod("glCombinerStageParameterfvNV", typeof(CombinerStageParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerStageParameterfvNV(int stage, int pname, [Out] Single* @params);
        internal unsafe static GetCombinerStageParameterfvNV glGetCombinerStageParameterfvNV = (GetCombinerStageParameterfvNV)Gl.GetDelegateForExtensionMethod("glGetCombinerStageParameterfvNV", typeof(GetCombinerStageParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate int AreProgramsResidentNV(Int32 n, UInt32* programs, [Out] int* residences);
        internal unsafe static AreProgramsResidentNV glAreProgramsResidentNV = (AreProgramsResidentNV)Gl.GetDelegateForExtensionMethod("glAreProgramsResidentNV", typeof(AreProgramsResidentNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindProgramNV(int target, UInt32 id);
        internal static BindProgramNV glBindProgramNV = (BindProgramNV)Gl.GetDelegateForExtensionMethod("glBindProgramNV", typeof(BindProgramNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteProgramsNV(Int32 n, UInt32* programs);
        internal unsafe static DeleteProgramsNV glDeleteProgramsNV = (DeleteProgramsNV)Gl.GetDelegateForExtensionMethod("glDeleteProgramsNV", typeof(DeleteProgramsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ExecuteProgramNV(int target, UInt32 id, Single* @params);
        internal unsafe static ExecuteProgramNV glExecuteProgramNV = (ExecuteProgramNV)Gl.GetDelegateForExtensionMethod("glExecuteProgramNV", typeof(ExecuteProgramNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenProgramsNV(Int32 n, [Out] UInt32* programs);
        internal unsafe static GenProgramsNV glGenProgramsNV = (GenProgramsNV)Gl.GetDelegateForExtensionMethod("glGenProgramsNV", typeof(GenProgramsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramParameterdvNV(int target, UInt32 index, int pname, [Out] Double* @params);
        internal unsafe static GetProgramParameterdvNV glGetProgramParameterdvNV = (GetProgramParameterdvNV)Gl.GetDelegateForExtensionMethod("glGetProgramParameterdvNV", typeof(GetProgramParameterdvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramParameterfvNV(int target, UInt32 index, int pname, [Out] Single* @params);
        internal unsafe static GetProgramParameterfvNV glGetProgramParameterfvNV = (GetProgramParameterfvNV)Gl.GetDelegateForExtensionMethod("glGetProgramParameterfvNV", typeof(GetProgramParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramivNV(UInt32 id, int pname, [Out] Int32* @params);
        internal unsafe static GetProgramivNV glGetProgramivNV = (GetProgramivNV)Gl.GetDelegateForExtensionMethod("glGetProgramivNV", typeof(GetProgramivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramStringNV(UInt32 id, int pname, [Out] Byte* program);
        internal unsafe static GetProgramStringNV glGetProgramStringNV = (GetProgramStringNV)Gl.GetDelegateForExtensionMethod("glGetProgramStringNV", typeof(GetProgramStringNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTrackMatrixivNV(int target, UInt32 address, int pname, [Out] Int32* @params);
        internal unsafe static GetTrackMatrixivNV glGetTrackMatrixivNV = (GetTrackMatrixivNV)Gl.GetDelegateForExtensionMethod("glGetTrackMatrixivNV", typeof(GetTrackMatrixivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdvNV(UInt32 index, int pname, [Out] Double* @params);
        internal unsafe static GetVertexAttribdvNV glGetVertexAttribdvNV = (GetVertexAttribdvNV)Gl.GetDelegateForExtensionMethod("glGetVertexAttribdvNV", typeof(GetVertexAttribdvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfvNV(UInt32 index, int pname, [Out] Single* @params);
        internal unsafe static GetVertexAttribfvNV glGetVertexAttribfvNV = (GetVertexAttribfvNV)Gl.GetDelegateForExtensionMethod("glGetVertexAttribfvNV", typeof(GetVertexAttribfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribivNV(UInt32 index, int pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribivNV glGetVertexAttribivNV = (GetVertexAttribivNV)Gl.GetDelegateForExtensionMethod("glGetVertexAttribivNV", typeof(GetVertexAttribivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribPointervNV(UInt32 index, int pname, [Out] void* pointer);
        internal unsafe static GetVertexAttribPointervNV glGetVertexAttribPointervNV = (GetVertexAttribPointervNV)Gl.GetDelegateForExtensionMethod("glGetVertexAttribPointervNV", typeof(GetVertexAttribPointervNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsProgramNV(UInt32 id);
        internal static IsProgramNV glIsProgramNV = (IsProgramNV)Gl.GetDelegateForExtensionMethod("glIsProgramNV", typeof(IsProgramNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadProgramNV(int target, UInt32 id, Int32 len, Byte* program);
        internal unsafe static LoadProgramNV glLoadProgramNV = (LoadProgramNV)Gl.GetDelegateForExtensionMethod("glLoadProgramNV", typeof(LoadProgramNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameter4dNV(int target, UInt32 index, Double x, Double y, Double z, Double w);
        internal static ProgramParameter4dNV glProgramParameter4dNV = (ProgramParameter4dNV)Gl.GetDelegateForExtensionMethod("glProgramParameter4dNV", typeof(ProgramParameter4dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameter4dvNV(int target, UInt32 index, Double* v);
        internal unsafe static ProgramParameter4dvNV glProgramParameter4dvNV = (ProgramParameter4dvNV)Gl.GetDelegateForExtensionMethod("glProgramParameter4dvNV", typeof(ProgramParameter4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameter4fNV(int target, UInt32 index, Single x, Single y, Single z, Single w);
        internal static ProgramParameter4fNV glProgramParameter4fNV = (ProgramParameter4fNV)Gl.GetDelegateForExtensionMethod("glProgramParameter4fNV", typeof(ProgramParameter4fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameter4fvNV(int target, UInt32 index, Single* v);
        internal unsafe static ProgramParameter4fvNV glProgramParameter4fvNV = (ProgramParameter4fvNV)Gl.GetDelegateForExtensionMethod("glProgramParameter4fvNV", typeof(ProgramParameter4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameters4dvNV(int target, UInt32 index, UInt32 count, Double* v);
        internal unsafe static ProgramParameters4dvNV glProgramParameters4dvNV = (ProgramParameters4dvNV)Gl.GetDelegateForExtensionMethod("glProgramParameters4dvNV", typeof(ProgramParameters4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameters4fvNV(int target, UInt32 index, UInt32 count, Single* v);
        internal unsafe static ProgramParameters4fvNV glProgramParameters4fvNV = (ProgramParameters4fvNV)Gl.GetDelegateForExtensionMethod("glProgramParameters4fvNV", typeof(ProgramParameters4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RequestResidentProgramsNV(Int32 n, UInt32* programs);
        internal unsafe static RequestResidentProgramsNV glRequestResidentProgramsNV = (RequestResidentProgramsNV)Gl.GetDelegateForExtensionMethod("glRequestResidentProgramsNV", typeof(RequestResidentProgramsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TrackMatrixNV(int target, UInt32 address, int matrix, int transform);
        internal static TrackMatrixNV glTrackMatrixNV = (TrackMatrixNV)Gl.GetDelegateForExtensionMethod("glTrackMatrixNV", typeof(TrackMatrixNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribPointerNV(UInt32 index, Int32 fsize, int type, Int32 stride, void* pointer);
        internal unsafe static VertexAttribPointerNV glVertexAttribPointerNV = (VertexAttribPointerNV)Gl.GetDelegateForExtensionMethod("glVertexAttribPointerNV", typeof(VertexAttribPointerNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1dNV(UInt32 index, Double x);
        internal static VertexAttrib1dNV glVertexAttrib1dNV = (VertexAttrib1dNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib1dNV", typeof(VertexAttrib1dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dvNV(UInt32 index, Double* v);
        internal unsafe static VertexAttrib1dvNV glVertexAttrib1dvNV = (VertexAttrib1dvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib1dvNV", typeof(VertexAttrib1dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1fNV(UInt32 index, Single x);
        internal static VertexAttrib1fNV glVertexAttrib1fNV = (VertexAttrib1fNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib1fNV", typeof(VertexAttrib1fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fvNV(UInt32 index, Single* v);
        internal unsafe static VertexAttrib1fvNV glVertexAttrib1fvNV = (VertexAttrib1fvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib1fvNV", typeof(VertexAttrib1fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1sNV(UInt32 index, Int16 x);
        internal static VertexAttrib1sNV glVertexAttrib1sNV = (VertexAttrib1sNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib1sNV", typeof(VertexAttrib1sNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1svNV(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib1svNV glVertexAttrib1svNV = (VertexAttrib1svNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib1svNV", typeof(VertexAttrib1svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2dNV(UInt32 index, Double x, Double y);
        internal static VertexAttrib2dNV glVertexAttrib2dNV = (VertexAttrib2dNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib2dNV", typeof(VertexAttrib2dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dvNV(UInt32 index, Double* v);
        internal unsafe static VertexAttrib2dvNV glVertexAttrib2dvNV = (VertexAttrib2dvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib2dvNV", typeof(VertexAttrib2dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2fNV(UInt32 index, Single x, Single y);
        internal static VertexAttrib2fNV glVertexAttrib2fNV = (VertexAttrib2fNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib2fNV", typeof(VertexAttrib2fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fvNV(UInt32 index, Single* v);
        internal unsafe static VertexAttrib2fvNV glVertexAttrib2fvNV = (VertexAttrib2fvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib2fvNV", typeof(VertexAttrib2fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2sNV(UInt32 index, Int16 x, Int16 y);
        internal static VertexAttrib2sNV glVertexAttrib2sNV = (VertexAttrib2sNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib2sNV", typeof(VertexAttrib2sNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2svNV(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib2svNV glVertexAttrib2svNV = (VertexAttrib2svNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib2svNV", typeof(VertexAttrib2svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3dNV(UInt32 index, Double x, Double y, Double z);
        internal static VertexAttrib3dNV glVertexAttrib3dNV = (VertexAttrib3dNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib3dNV", typeof(VertexAttrib3dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dvNV(UInt32 index, Double* v);
        internal unsafe static VertexAttrib3dvNV glVertexAttrib3dvNV = (VertexAttrib3dvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib3dvNV", typeof(VertexAttrib3dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3fNV(UInt32 index, Single x, Single y, Single z);
        internal static VertexAttrib3fNV glVertexAttrib3fNV = (VertexAttrib3fNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib3fNV", typeof(VertexAttrib3fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fvNV(UInt32 index, Single* v);
        internal unsafe static VertexAttrib3fvNV glVertexAttrib3fvNV = (VertexAttrib3fvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib3fvNV", typeof(VertexAttrib3fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3sNV(UInt32 index, Int16 x, Int16 y, Int16 z);
        internal static VertexAttrib3sNV glVertexAttrib3sNV = (VertexAttrib3sNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib3sNV", typeof(VertexAttrib3sNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3svNV(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib3svNV glVertexAttrib3svNV = (VertexAttrib3svNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib3svNV", typeof(VertexAttrib3svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4dNV(UInt32 index, Double x, Double y, Double z, Double w);
        internal static VertexAttrib4dNV glVertexAttrib4dNV = (VertexAttrib4dNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4dNV", typeof(VertexAttrib4dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dvNV(UInt32 index, Double* v);
        internal unsafe static VertexAttrib4dvNV glVertexAttrib4dvNV = (VertexAttrib4dvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4dvNV", typeof(VertexAttrib4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4fNV(UInt32 index, Single x, Single y, Single z, Single w);
        internal static VertexAttrib4fNV glVertexAttrib4fNV = (VertexAttrib4fNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4fNV", typeof(VertexAttrib4fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fvNV(UInt32 index, Single* v);
        internal unsafe static VertexAttrib4fvNV glVertexAttrib4fvNV = (VertexAttrib4fvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4fvNV", typeof(VertexAttrib4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4sNV(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
        internal static VertexAttrib4sNV glVertexAttrib4sNV = (VertexAttrib4sNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4sNV", typeof(VertexAttrib4sNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4svNV(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4svNV glVertexAttrib4svNV = (VertexAttrib4svNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4svNV", typeof(VertexAttrib4svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4ubNV(UInt32 index, Byte x, Byte y, Byte z, Byte w);
        internal static VertexAttrib4ubNV glVertexAttrib4ubNV = (VertexAttrib4ubNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4ubNV", typeof(VertexAttrib4ubNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubvNV(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4ubvNV glVertexAttrib4ubvNV = (VertexAttrib4ubvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4ubvNV", typeof(VertexAttrib4ubvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1dvNV(UInt32 index, Int32 count, Double* v);
        internal unsafe static VertexAttribs1dvNV glVertexAttribs1dvNV = (VertexAttribs1dvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs1dvNV", typeof(VertexAttribs1dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1fvNV(UInt32 index, Int32 count, Single* v);
        internal unsafe static VertexAttribs1fvNV glVertexAttribs1fvNV = (VertexAttribs1fvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs1fvNV", typeof(VertexAttribs1fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);
        internal unsafe static VertexAttribs1svNV glVertexAttribs1svNV = (VertexAttribs1svNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs1svNV", typeof(VertexAttribs1svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2dvNV(UInt32 index, Int32 count, Double* v);
        internal unsafe static VertexAttribs2dvNV glVertexAttribs2dvNV = (VertexAttribs2dvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs2dvNV", typeof(VertexAttribs2dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2fvNV(UInt32 index, Int32 count, Single* v);
        internal unsafe static VertexAttribs2fvNV glVertexAttribs2fvNV = (VertexAttribs2fvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs2fvNV", typeof(VertexAttribs2fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);
        internal unsafe static VertexAttribs2svNV glVertexAttribs2svNV = (VertexAttribs2svNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs2svNV", typeof(VertexAttribs2svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3dvNV(UInt32 index, Int32 count, Double* v);
        internal unsafe static VertexAttribs3dvNV glVertexAttribs3dvNV = (VertexAttribs3dvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs3dvNV", typeof(VertexAttribs3dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3fvNV(UInt32 index, Int32 count, Single* v);
        internal unsafe static VertexAttribs3fvNV glVertexAttribs3fvNV = (VertexAttribs3fvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs3fvNV", typeof(VertexAttribs3fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);
        internal unsafe static VertexAttribs3svNV glVertexAttribs3svNV = (VertexAttribs3svNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs3svNV", typeof(VertexAttribs3svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4dvNV(UInt32 index, Int32 count, Double* v);
        internal unsafe static VertexAttribs4dvNV glVertexAttribs4dvNV = (VertexAttribs4dvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs4dvNV", typeof(VertexAttribs4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4fvNV(UInt32 index, Int32 count, Single* v);
        internal unsafe static VertexAttribs4fvNV glVertexAttribs4fvNV = (VertexAttribs4fvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs4fvNV", typeof(VertexAttribs4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);
        internal unsafe static VertexAttribs4svNV glVertexAttribs4svNV = (VertexAttribs4svNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs4svNV", typeof(VertexAttribs4svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4ubvNV(UInt32 index, Int32 count, Byte* v);
        internal unsafe static VertexAttribs4ubvNV glVertexAttribs4ubvNV = (VertexAttribs4ubvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs4ubvNV", typeof(VertexAttribs4ubvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexBumpParameterivATI(int pname, Int32* param);
        internal unsafe static TexBumpParameterivATI glTexBumpParameterivATI = (TexBumpParameterivATI)Gl.GetDelegateForExtensionMethod("glTexBumpParameterivATI", typeof(TexBumpParameterivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexBumpParameterfvATI(int pname, Single* param);
        internal unsafe static TexBumpParameterfvATI glTexBumpParameterfvATI = (TexBumpParameterfvATI)Gl.GetDelegateForExtensionMethod("glTexBumpParameterfvATI", typeof(TexBumpParameterfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexBumpParameterivATI(int pname, [Out] Int32* param);
        internal unsafe static GetTexBumpParameterivATI glGetTexBumpParameterivATI = (GetTexBumpParameterivATI)Gl.GetDelegateForExtensionMethod("glGetTexBumpParameterivATI", typeof(GetTexBumpParameterivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexBumpParameterfvATI(int pname, [Out] Single* param);
        internal unsafe static GetTexBumpParameterfvATI glGetTexBumpParameterfvATI = (GetTexBumpParameterfvATI)Gl.GetDelegateForExtensionMethod("glGetTexBumpParameterfvATI", typeof(GetTexBumpParameterfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenFragmentShadersATI(UInt32 range);
        internal static GenFragmentShadersATI glGenFragmentShadersATI = (GenFragmentShadersATI)Gl.GetDelegateForExtensionMethod("glGenFragmentShadersATI", typeof(GenFragmentShadersATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFragmentShaderATI(UInt32 id);
        internal static BindFragmentShaderATI glBindFragmentShaderATI = (BindFragmentShaderATI)Gl.GetDelegateForExtensionMethod("glBindFragmentShaderATI", typeof(BindFragmentShaderATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteFragmentShaderATI(UInt32 id);
        internal static DeleteFragmentShaderATI glDeleteFragmentShaderATI = (DeleteFragmentShaderATI)Gl.GetDelegateForExtensionMethod("glDeleteFragmentShaderATI", typeof(DeleteFragmentShaderATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginFragmentShaderATI();
        internal static BeginFragmentShaderATI glBeginFragmentShaderATI = (BeginFragmentShaderATI)Gl.GetDelegateForExtensionMethod("glBeginFragmentShaderATI", typeof(BeginFragmentShaderATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndFragmentShaderATI();
        internal static EndFragmentShaderATI glEndFragmentShaderATI = (EndFragmentShaderATI)Gl.GetDelegateForExtensionMethod("glEndFragmentShaderATI", typeof(EndFragmentShaderATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PassTexCoordATI(UInt32 dst, UInt32 coord, int swizzle);
        internal static PassTexCoordATI glPassTexCoordATI = (PassTexCoordATI)Gl.GetDelegateForExtensionMethod("glPassTexCoordATI", typeof(PassTexCoordATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMapATI(UInt32 dst, UInt32 interp, int swizzle);
        internal static SampleMapATI glSampleMapATI = (SampleMapATI)Gl.GetDelegateForExtensionMethod("glSampleMapATI", typeof(SampleMapATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorFragmentOp1ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
        internal static ColorFragmentOp1ATI glColorFragmentOp1ATI = (ColorFragmentOp1ATI)Gl.GetDelegateForExtensionMethod("glColorFragmentOp1ATI", typeof(ColorFragmentOp1ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorFragmentOp2ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
        internal static ColorFragmentOp2ATI glColorFragmentOp2ATI = (ColorFragmentOp2ATI)Gl.GetDelegateForExtensionMethod("glColorFragmentOp2ATI", typeof(ColorFragmentOp2ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorFragmentOp3ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
        internal static ColorFragmentOp3ATI glColorFragmentOp3ATI = (ColorFragmentOp3ATI)Gl.GetDelegateForExtensionMethod("glColorFragmentOp3ATI", typeof(ColorFragmentOp3ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFragmentOp1ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
        internal static AlphaFragmentOp1ATI glAlphaFragmentOp1ATI = (AlphaFragmentOp1ATI)Gl.GetDelegateForExtensionMethod("glAlphaFragmentOp1ATI", typeof(AlphaFragmentOp1ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFragmentOp2ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
        internal static AlphaFragmentOp2ATI glAlphaFragmentOp2ATI = (AlphaFragmentOp2ATI)Gl.GetDelegateForExtensionMethod("glAlphaFragmentOp2ATI", typeof(AlphaFragmentOp2ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFragmentOp3ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
        internal static AlphaFragmentOp3ATI glAlphaFragmentOp3ATI = (AlphaFragmentOp3ATI)Gl.GetDelegateForExtensionMethod("glAlphaFragmentOp3ATI", typeof(AlphaFragmentOp3ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SetFragmentShaderConstantATI(UInt32 dst, Single* value);
        internal unsafe static SetFragmentShaderConstantATI glSetFragmentShaderConstantATI = (SetFragmentShaderConstantATI)Gl.GetDelegateForExtensionMethod("glSetFragmentShaderConstantATI", typeof(SetFragmentShaderConstantATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PNTrianglesiATI(int pname, Int32 param);
        internal static PNTrianglesiATI glPNTrianglesiATI = (PNTrianglesiATI)Gl.GetDelegateForExtensionMethod("glPNTrianglesiATI", typeof(PNTrianglesiATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PNTrianglesfATI(int pname, Single param);
        internal static PNTrianglesfATI glPNTrianglesfATI = (PNTrianglesfATI)Gl.GetDelegateForExtensionMethod("glPNTrianglesfATI", typeof(PNTrianglesfATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Int32 NewObjectBufferATI(Int32 size, void* pointer, int usage);
        internal unsafe static NewObjectBufferATI glNewObjectBufferATI = (NewObjectBufferATI)Gl.GetDelegateForExtensionMethod("glNewObjectBufferATI", typeof(NewObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsObjectBufferATI(UInt32 buffer);
        internal static IsObjectBufferATI glIsObjectBufferATI = (IsObjectBufferATI)Gl.GetDelegateForExtensionMethod("glIsObjectBufferATI", typeof(IsObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, void* pointer, int preserve);
        internal unsafe static UpdateObjectBufferATI glUpdateObjectBufferATI = (UpdateObjectBufferATI)Gl.GetDelegateForExtensionMethod("glUpdateObjectBufferATI", typeof(UpdateObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectBufferfvATI(UInt32 buffer, int pname, [Out] Single* @params);
        internal unsafe static GetObjectBufferfvATI glGetObjectBufferfvATI = (GetObjectBufferfvATI)Gl.GetDelegateForExtensionMethod("glGetObjectBufferfvATI", typeof(GetObjectBufferfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectBufferivATI(UInt32 buffer, int pname, [Out] Int32* @params);
        internal unsafe static GetObjectBufferivATI glGetObjectBufferivATI = (GetObjectBufferivATI)Gl.GetDelegateForExtensionMethod("glGetObjectBufferivATI", typeof(GetObjectBufferivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FreeObjectBufferATI(UInt32 buffer);
        internal static FreeObjectBufferATI glFreeObjectBufferATI = (FreeObjectBufferATI)Gl.GetDelegateForExtensionMethod("glFreeObjectBufferATI", typeof(FreeObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ArrayObjectATI(int array, Int32 size, int type, Int32 stride, UInt32 buffer, UInt32 offset);
        internal static ArrayObjectATI glArrayObjectATI = (ArrayObjectATI)Gl.GetDelegateForExtensionMethod("glArrayObjectATI", typeof(ArrayObjectATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetArrayObjectfvATI(int array, int pname, [Out] Single* @params);
        internal unsafe static GetArrayObjectfvATI glGetArrayObjectfvATI = (GetArrayObjectfvATI)Gl.GetDelegateForExtensionMethod("glGetArrayObjectfvATI", typeof(GetArrayObjectfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetArrayObjectivATI(int array, int pname, [Out] Int32* @params);
        internal unsafe static GetArrayObjectivATI glGetArrayObjectivATI = (GetArrayObjectivATI)Gl.GetDelegateForExtensionMethod("glGetArrayObjectivATI", typeof(GetArrayObjectivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VariantArrayObjectATI(UInt32 id, int type, Int32 stride, UInt32 buffer, UInt32 offset);
        internal static VariantArrayObjectATI glVariantArrayObjectATI = (VariantArrayObjectATI)Gl.GetDelegateForExtensionMethod("glVariantArrayObjectATI", typeof(VariantArrayObjectATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantArrayObjectfvATI(UInt32 id, int pname, [Out] Single* @params);
        internal unsafe static GetVariantArrayObjectfvATI glGetVariantArrayObjectfvATI = (GetVariantArrayObjectfvATI)Gl.GetDelegateForExtensionMethod("glGetVariantArrayObjectfvATI", typeof(GetVariantArrayObjectfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantArrayObjectivATI(UInt32 id, int pname, [Out] Int32* @params);
        internal unsafe static GetVariantArrayObjectivATI glGetVariantArrayObjectivATI = (GetVariantArrayObjectivATI)Gl.GetDelegateForExtensionMethod("glGetVariantArrayObjectivATI", typeof(GetVariantArrayObjectivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginVertexShaderEXT();
        internal static BeginVertexShaderEXT glBeginVertexShaderEXT = (BeginVertexShaderEXT)Gl.GetDelegateForExtensionMethod("glBeginVertexShaderEXT", typeof(BeginVertexShaderEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndVertexShaderEXT();
        internal static EndVertexShaderEXT glEndVertexShaderEXT = (EndVertexShaderEXT)Gl.GetDelegateForExtensionMethod("glEndVertexShaderEXT", typeof(EndVertexShaderEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindVertexShaderEXT(UInt32 id);
        internal static BindVertexShaderEXT glBindVertexShaderEXT = (BindVertexShaderEXT)Gl.GetDelegateForExtensionMethod("glBindVertexShaderEXT", typeof(BindVertexShaderEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenVertexShadersEXT(UInt32 range);
        internal static GenVertexShadersEXT glGenVertexShadersEXT = (GenVertexShadersEXT)Gl.GetDelegateForExtensionMethod("glGenVertexShadersEXT", typeof(GenVertexShadersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteVertexShaderEXT(UInt32 id);
        internal static DeleteVertexShaderEXT glDeleteVertexShaderEXT = (DeleteVertexShaderEXT)Gl.GetDelegateForExtensionMethod("glDeleteVertexShaderEXT", typeof(DeleteVertexShaderEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderOp1EXT(int op, UInt32 res, UInt32 arg1);
        internal static ShaderOp1EXT glShaderOp1EXT = (ShaderOp1EXT)Gl.GetDelegateForExtensionMethod("glShaderOp1EXT", typeof(ShaderOp1EXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderOp2EXT(int op, UInt32 res, UInt32 arg1, UInt32 arg2);
        internal static ShaderOp2EXT glShaderOp2EXT = (ShaderOp2EXT)Gl.GetDelegateForExtensionMethod("glShaderOp2EXT", typeof(ShaderOp2EXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderOp3EXT(int op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);
        internal static ShaderOp3EXT glShaderOp3EXT = (ShaderOp3EXT)Gl.GetDelegateForExtensionMethod("glShaderOp3EXT", typeof(ShaderOp3EXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SwizzleEXT(UInt32 res, UInt32 @in, int outX, int outY, int outZ, int outW);
        internal static SwizzleEXT glSwizzleEXT = (SwizzleEXT)Gl.GetDelegateForExtensionMethod("glSwizzleEXT", typeof(SwizzleEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WriteMaskEXT(UInt32 res, UInt32 @in, int outX, int outY, int outZ, int outW);
        internal static WriteMaskEXT glWriteMaskEXT = (WriteMaskEXT)Gl.GetDelegateForExtensionMethod("glWriteMaskEXT", typeof(WriteMaskEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);
        internal static InsertComponentEXT glInsertComponentEXT = (InsertComponentEXT)Gl.GetDelegateForExtensionMethod("glInsertComponentEXT", typeof(InsertComponentEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);
        internal static ExtractComponentEXT glExtractComponentEXT = (ExtractComponentEXT)Gl.GetDelegateForExtensionMethod("glExtractComponentEXT", typeof(ExtractComponentEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenSymbolsEXT(int datatype, int storagetype, int range, UInt32 components);
        internal static GenSymbolsEXT glGenSymbolsEXT = (GenSymbolsEXT)Gl.GetDelegateForExtensionMethod("glGenSymbolsEXT", typeof(GenSymbolsEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SetInvariantEXT(UInt32 id, int type, void* addr);
        internal unsafe static SetInvariantEXT glSetInvariantEXT = (SetInvariantEXT)Gl.GetDelegateForExtensionMethod("glSetInvariantEXT", typeof(SetInvariantEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SetLocalConstantEXT(UInt32 id, int type, void* addr);
        internal unsafe static SetLocalConstantEXT glSetLocalConstantEXT = (SetLocalConstantEXT)Gl.GetDelegateForExtensionMethod("glSetLocalConstantEXT", typeof(SetLocalConstantEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantbvEXT(UInt32 id, SByte* addr);
        internal unsafe static VariantbvEXT glVariantbvEXT = (VariantbvEXT)Gl.GetDelegateForExtensionMethod("glVariantbvEXT", typeof(VariantbvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantsvEXT(UInt32 id, Int16* addr);
        internal unsafe static VariantsvEXT glVariantsvEXT = (VariantsvEXT)Gl.GetDelegateForExtensionMethod("glVariantsvEXT", typeof(VariantsvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantivEXT(UInt32 id, Int32* addr);
        internal unsafe static VariantivEXT glVariantivEXT = (VariantivEXT)Gl.GetDelegateForExtensionMethod("glVariantivEXT", typeof(VariantivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantfvEXT(UInt32 id, Single* addr);
        internal unsafe static VariantfvEXT glVariantfvEXT = (VariantfvEXT)Gl.GetDelegateForExtensionMethod("glVariantfvEXT", typeof(VariantfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantdvEXT(UInt32 id, Double* addr);
        internal unsafe static VariantdvEXT glVariantdvEXT = (VariantdvEXT)Gl.GetDelegateForExtensionMethod("glVariantdvEXT", typeof(VariantdvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantubvEXT(UInt32 id, Byte* addr);
        internal unsafe static VariantubvEXT glVariantubvEXT = (VariantubvEXT)Gl.GetDelegateForExtensionMethod("glVariantubvEXT", typeof(VariantubvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantusvEXT(UInt32 id, UInt16* addr);
        internal unsafe static VariantusvEXT glVariantusvEXT = (VariantusvEXT)Gl.GetDelegateForExtensionMethod("glVariantusvEXT", typeof(VariantusvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantuivEXT(UInt32 id, UInt32* addr);
        internal unsafe static VariantuivEXT glVariantuivEXT = (VariantuivEXT)Gl.GetDelegateForExtensionMethod("glVariantuivEXT", typeof(VariantuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantPointerEXT(UInt32 id, int type, UInt32 stride, void* addr);
        internal unsafe static VariantPointerEXT glVariantPointerEXT = (VariantPointerEXT)Gl.GetDelegateForExtensionMethod("glVariantPointerEXT", typeof(VariantPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVariantClientStateEXT(UInt32 id);
        internal static EnableVariantClientStateEXT glEnableVariantClientStateEXT = (EnableVariantClientStateEXT)Gl.GetDelegateForExtensionMethod("glEnableVariantClientStateEXT", typeof(EnableVariantClientStateEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVariantClientStateEXT(UInt32 id);
        internal static DisableVariantClientStateEXT glDisableVariantClientStateEXT = (DisableVariantClientStateEXT)Gl.GetDelegateForExtensionMethod("glDisableVariantClientStateEXT", typeof(DisableVariantClientStateEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindLightParameterEXT(int light, int value);
        internal static BindLightParameterEXT glBindLightParameterEXT = (BindLightParameterEXT)Gl.GetDelegateForExtensionMethod("glBindLightParameterEXT", typeof(BindLightParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindMaterialParameterEXT(int face, int value);
        internal static BindMaterialParameterEXT glBindMaterialParameterEXT = (BindMaterialParameterEXT)Gl.GetDelegateForExtensionMethod("glBindMaterialParameterEXT", typeof(BindMaterialParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindTexGenParameterEXT(int unit, int coord, int value);
        internal static BindTexGenParameterEXT glBindTexGenParameterEXT = (BindTexGenParameterEXT)Gl.GetDelegateForExtensionMethod("glBindTexGenParameterEXT", typeof(BindTexGenParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindTextureUnitParameterEXT(int unit, int value);
        internal static BindTextureUnitParameterEXT glBindTextureUnitParameterEXT = (BindTextureUnitParameterEXT)Gl.GetDelegateForExtensionMethod("glBindTextureUnitParameterEXT", typeof(BindTextureUnitParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindParameterEXT(int value);
        internal static BindParameterEXT glBindParameterEXT = (BindParameterEXT)Gl.GetDelegateForExtensionMethod("glBindParameterEXT", typeof(BindParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsVariantEnabledEXT(UInt32 id, int cap);
        internal static IsVariantEnabledEXT glIsVariantEnabledEXT = (IsVariantEnabledEXT)Gl.GetDelegateForExtensionMethod("glIsVariantEnabledEXT", typeof(IsVariantEnabledEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantBooleanvEXT(UInt32 id, int value, [Out] int* data);
        internal unsafe static GetVariantBooleanvEXT glGetVariantBooleanvEXT = (GetVariantBooleanvEXT)Gl.GetDelegateForExtensionMethod("glGetVariantBooleanvEXT", typeof(GetVariantBooleanvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantIntegervEXT(UInt32 id, int value, [Out] Int32* data);
        internal unsafe static GetVariantIntegervEXT glGetVariantIntegervEXT = (GetVariantIntegervEXT)Gl.GetDelegateForExtensionMethod("glGetVariantIntegervEXT", typeof(GetVariantIntegervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantFloatvEXT(UInt32 id, int value, [Out] Single* data);
        internal unsafe static GetVariantFloatvEXT glGetVariantFloatvEXT = (GetVariantFloatvEXT)Gl.GetDelegateForExtensionMethod("glGetVariantFloatvEXT", typeof(GetVariantFloatvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantPointervEXT(UInt32 id, int value, [Out] void* data);
        internal unsafe static GetVariantPointervEXT glGetVariantPointervEXT = (GetVariantPointervEXT)Gl.GetDelegateForExtensionMethod("glGetVariantPointervEXT", typeof(GetVariantPointervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInvariantBooleanvEXT(UInt32 id, int value, [Out] int* data);
        internal unsafe static GetInvariantBooleanvEXT glGetInvariantBooleanvEXT = (GetInvariantBooleanvEXT)Gl.GetDelegateForExtensionMethod("glGetInvariantBooleanvEXT", typeof(GetInvariantBooleanvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInvariantIntegervEXT(UInt32 id, int value, [Out] Int32* data);
        internal unsafe static GetInvariantIntegervEXT glGetInvariantIntegervEXT = (GetInvariantIntegervEXT)Gl.GetDelegateForExtensionMethod("glGetInvariantIntegervEXT", typeof(GetInvariantIntegervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInvariantFloatvEXT(UInt32 id, int value, [Out] Single* data);
        internal unsafe static GetInvariantFloatvEXT glGetInvariantFloatvEXT = (GetInvariantFloatvEXT)Gl.GetDelegateForExtensionMethod("glGetInvariantFloatvEXT", typeof(GetInvariantFloatvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLocalConstantBooleanvEXT(UInt32 id, int value, [Out] int* data);
        internal unsafe static GetLocalConstantBooleanvEXT glGetLocalConstantBooleanvEXT = (GetLocalConstantBooleanvEXT)Gl.GetDelegateForExtensionMethod("glGetLocalConstantBooleanvEXT", typeof(GetLocalConstantBooleanvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLocalConstantIntegervEXT(UInt32 id, int value, [Out] Int32* data);
        internal unsafe static GetLocalConstantIntegervEXT glGetLocalConstantIntegervEXT = (GetLocalConstantIntegervEXT)Gl.GetDelegateForExtensionMethod("glGetLocalConstantIntegervEXT", typeof(GetLocalConstantIntegervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLocalConstantFloatvEXT(UInt32 id, int value, [Out] Single* data);
        internal unsafe static GetLocalConstantFloatvEXT glGetLocalConstantFloatvEXT = (GetLocalConstantFloatvEXT)Gl.GetDelegateForExtensionMethod("glGetLocalConstantFloatvEXT", typeof(GetLocalConstantFloatvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1sATI(int stream, Int16 x);
        internal static VertexStream1sATI glVertexStream1sATI = (VertexStream1sATI)Gl.GetDelegateForExtensionMethod("glVertexStream1sATI", typeof(VertexStream1sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1svATI(int stream, Int16* coords);
        internal unsafe static VertexStream1svATI glVertexStream1svATI = (VertexStream1svATI)Gl.GetDelegateForExtensionMethod("glVertexStream1svATI", typeof(VertexStream1svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1iATI(int stream, Int32 x);
        internal static VertexStream1iATI glVertexStream1iATI = (VertexStream1iATI)Gl.GetDelegateForExtensionMethod("glVertexStream1iATI", typeof(VertexStream1iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1ivATI(int stream, Int32* coords);
        internal unsafe static VertexStream1ivATI glVertexStream1ivATI = (VertexStream1ivATI)Gl.GetDelegateForExtensionMethod("glVertexStream1ivATI", typeof(VertexStream1ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1fATI(int stream, Single x);
        internal static VertexStream1fATI glVertexStream1fATI = (VertexStream1fATI)Gl.GetDelegateForExtensionMethod("glVertexStream1fATI", typeof(VertexStream1fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1fvATI(int stream, Single* coords);
        internal unsafe static VertexStream1fvATI glVertexStream1fvATI = (VertexStream1fvATI)Gl.GetDelegateForExtensionMethod("glVertexStream1fvATI", typeof(VertexStream1fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1dATI(int stream, Double x);
        internal static VertexStream1dATI glVertexStream1dATI = (VertexStream1dATI)Gl.GetDelegateForExtensionMethod("glVertexStream1dATI", typeof(VertexStream1dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1dvATI(int stream, Double* coords);
        internal unsafe static VertexStream1dvATI glVertexStream1dvATI = (VertexStream1dvATI)Gl.GetDelegateForExtensionMethod("glVertexStream1dvATI", typeof(VertexStream1dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2sATI(int stream, Int16 x, Int16 y);
        internal static VertexStream2sATI glVertexStream2sATI = (VertexStream2sATI)Gl.GetDelegateForExtensionMethod("glVertexStream2sATI", typeof(VertexStream2sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2svATI(int stream, Int16* coords);
        internal unsafe static VertexStream2svATI glVertexStream2svATI = (VertexStream2svATI)Gl.GetDelegateForExtensionMethod("glVertexStream2svATI", typeof(VertexStream2svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2iATI(int stream, Int32 x, Int32 y);
        internal static VertexStream2iATI glVertexStream2iATI = (VertexStream2iATI)Gl.GetDelegateForExtensionMethod("glVertexStream2iATI", typeof(VertexStream2iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2ivATI(int stream, Int32* coords);
        internal unsafe static VertexStream2ivATI glVertexStream2ivATI = (VertexStream2ivATI)Gl.GetDelegateForExtensionMethod("glVertexStream2ivATI", typeof(VertexStream2ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2fATI(int stream, Single x, Single y);
        internal static VertexStream2fATI glVertexStream2fATI = (VertexStream2fATI)Gl.GetDelegateForExtensionMethod("glVertexStream2fATI", typeof(VertexStream2fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2fvATI(int stream, Single* coords);
        internal unsafe static VertexStream2fvATI glVertexStream2fvATI = (VertexStream2fvATI)Gl.GetDelegateForExtensionMethod("glVertexStream2fvATI", typeof(VertexStream2fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2dATI(int stream, Double x, Double y);
        internal static VertexStream2dATI glVertexStream2dATI = (VertexStream2dATI)Gl.GetDelegateForExtensionMethod("glVertexStream2dATI", typeof(VertexStream2dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2dvATI(int stream, Double* coords);
        internal unsafe static VertexStream2dvATI glVertexStream2dvATI = (VertexStream2dvATI)Gl.GetDelegateForExtensionMethod("glVertexStream2dvATI", typeof(VertexStream2dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3sATI(int stream, Int16 x, Int16 y, Int16 z);
        internal static VertexStream3sATI glVertexStream3sATI = (VertexStream3sATI)Gl.GetDelegateForExtensionMethod("glVertexStream3sATI", typeof(VertexStream3sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3svATI(int stream, Int16* coords);
        internal unsafe static VertexStream3svATI glVertexStream3svATI = (VertexStream3svATI)Gl.GetDelegateForExtensionMethod("glVertexStream3svATI", typeof(VertexStream3svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3iATI(int stream, Int32 x, Int32 y, Int32 z);
        internal static VertexStream3iATI glVertexStream3iATI = (VertexStream3iATI)Gl.GetDelegateForExtensionMethod("glVertexStream3iATI", typeof(VertexStream3iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3ivATI(int stream, Int32* coords);
        internal unsafe static VertexStream3ivATI glVertexStream3ivATI = (VertexStream3ivATI)Gl.GetDelegateForExtensionMethod("glVertexStream3ivATI", typeof(VertexStream3ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3fATI(int stream, Single x, Single y, Single z);
        internal static VertexStream3fATI glVertexStream3fATI = (VertexStream3fATI)Gl.GetDelegateForExtensionMethod("glVertexStream3fATI", typeof(VertexStream3fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3fvATI(int stream, Single* coords);
        internal unsafe static VertexStream3fvATI glVertexStream3fvATI = (VertexStream3fvATI)Gl.GetDelegateForExtensionMethod("glVertexStream3fvATI", typeof(VertexStream3fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3dATI(int stream, Double x, Double y, Double z);
        internal static VertexStream3dATI glVertexStream3dATI = (VertexStream3dATI)Gl.GetDelegateForExtensionMethod("glVertexStream3dATI", typeof(VertexStream3dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3dvATI(int stream, Double* coords);
        internal unsafe static VertexStream3dvATI glVertexStream3dvATI = (VertexStream3dvATI)Gl.GetDelegateForExtensionMethod("glVertexStream3dvATI", typeof(VertexStream3dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4sATI(int stream, Int16 x, Int16 y, Int16 z, Int16 w);
        internal static VertexStream4sATI glVertexStream4sATI = (VertexStream4sATI)Gl.GetDelegateForExtensionMethod("glVertexStream4sATI", typeof(VertexStream4sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4svATI(int stream, Int16* coords);
        internal unsafe static VertexStream4svATI glVertexStream4svATI = (VertexStream4svATI)Gl.GetDelegateForExtensionMethod("glVertexStream4svATI", typeof(VertexStream4svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4iATI(int stream, Int32 x, Int32 y, Int32 z, Int32 w);
        internal static VertexStream4iATI glVertexStream4iATI = (VertexStream4iATI)Gl.GetDelegateForExtensionMethod("glVertexStream4iATI", typeof(VertexStream4iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4ivATI(int stream, Int32* coords);
        internal unsafe static VertexStream4ivATI glVertexStream4ivATI = (VertexStream4ivATI)Gl.GetDelegateForExtensionMethod("glVertexStream4ivATI", typeof(VertexStream4ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4fATI(int stream, Single x, Single y, Single z, Single w);
        internal static VertexStream4fATI glVertexStream4fATI = (VertexStream4fATI)Gl.GetDelegateForExtensionMethod("glVertexStream4fATI", typeof(VertexStream4fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4fvATI(int stream, Single* coords);
        internal unsafe static VertexStream4fvATI glVertexStream4fvATI = (VertexStream4fvATI)Gl.GetDelegateForExtensionMethod("glVertexStream4fvATI", typeof(VertexStream4fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4dATI(int stream, Double x, Double y, Double z, Double w);
        internal static VertexStream4dATI glVertexStream4dATI = (VertexStream4dATI)Gl.GetDelegateForExtensionMethod("glVertexStream4dATI", typeof(VertexStream4dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4dvATI(int stream, Double* coords);
        internal unsafe static VertexStream4dvATI glVertexStream4dvATI = (VertexStream4dvATI)Gl.GetDelegateForExtensionMethod("glVertexStream4dvATI", typeof(VertexStream4dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3bATI(int stream, SByte nx, SByte ny, SByte nz);
        internal static NormalStream3bATI glNormalStream3bATI = (NormalStream3bATI)Gl.GetDelegateForExtensionMethod("glNormalStream3bATI", typeof(NormalStream3bATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3bvATI(int stream, SByte* coords);
        internal unsafe static NormalStream3bvATI glNormalStream3bvATI = (NormalStream3bvATI)Gl.GetDelegateForExtensionMethod("glNormalStream3bvATI", typeof(NormalStream3bvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3sATI(int stream, Int16 nx, Int16 ny, Int16 nz);
        internal static NormalStream3sATI glNormalStream3sATI = (NormalStream3sATI)Gl.GetDelegateForExtensionMethod("glNormalStream3sATI", typeof(NormalStream3sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3svATI(int stream, Int16* coords);
        internal unsafe static NormalStream3svATI glNormalStream3svATI = (NormalStream3svATI)Gl.GetDelegateForExtensionMethod("glNormalStream3svATI", typeof(NormalStream3svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3iATI(int stream, Int32 nx, Int32 ny, Int32 nz);
        internal static NormalStream3iATI glNormalStream3iATI = (NormalStream3iATI)Gl.GetDelegateForExtensionMethod("glNormalStream3iATI", typeof(NormalStream3iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3ivATI(int stream, Int32* coords);
        internal unsafe static NormalStream3ivATI glNormalStream3ivATI = (NormalStream3ivATI)Gl.GetDelegateForExtensionMethod("glNormalStream3ivATI", typeof(NormalStream3ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3fATI(int stream, Single nx, Single ny, Single nz);
        internal static NormalStream3fATI glNormalStream3fATI = (NormalStream3fATI)Gl.GetDelegateForExtensionMethod("glNormalStream3fATI", typeof(NormalStream3fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3fvATI(int stream, Single* coords);
        internal unsafe static NormalStream3fvATI glNormalStream3fvATI = (NormalStream3fvATI)Gl.GetDelegateForExtensionMethod("glNormalStream3fvATI", typeof(NormalStream3fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3dATI(int stream, Double nx, Double ny, Double nz);
        internal static NormalStream3dATI glNormalStream3dATI = (NormalStream3dATI)Gl.GetDelegateForExtensionMethod("glNormalStream3dATI", typeof(NormalStream3dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3dvATI(int stream, Double* coords);
        internal unsafe static NormalStream3dvATI glNormalStream3dvATI = (NormalStream3dvATI)Gl.GetDelegateForExtensionMethod("glNormalStream3dvATI", typeof(NormalStream3dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClientActiveVertexStreamATI(int stream);
        internal static ClientActiveVertexStreamATI glClientActiveVertexStreamATI = (ClientActiveVertexStreamATI)Gl.GetDelegateForExtensionMethod("glClientActiveVertexStreamATI", typeof(ClientActiveVertexStreamATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBlendEnviATI(int pname, Int32 param);
        internal static VertexBlendEnviATI glVertexBlendEnviATI = (VertexBlendEnviATI)Gl.GetDelegateForExtensionMethod("glVertexBlendEnviATI", typeof(VertexBlendEnviATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBlendEnvfATI(int pname, Single param);
        internal static VertexBlendEnvfATI glVertexBlendEnvfATI = (VertexBlendEnvfATI)Gl.GetDelegateForExtensionMethod("glVertexBlendEnvfATI", typeof(VertexBlendEnvfATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ElementPointerATI(int type, void* pointer);
        internal unsafe static ElementPointerATI glElementPointerATI = (ElementPointerATI)Gl.GetDelegateForExtensionMethod("glElementPointerATI", typeof(ElementPointerATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementArrayATI(int mode, Int32 count);
        internal static DrawElementArrayATI glDrawElementArrayATI = (DrawElementArrayATI)Gl.GetDelegateForExtensionMethod("glDrawElementArrayATI", typeof(DrawElementArrayATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawRangeElementArrayATI(int mode, UInt32 start, UInt32 end, Int32 count);
        internal static DrawRangeElementArrayATI glDrawRangeElementArrayATI = (DrawRangeElementArrayATI)Gl.GetDelegateForExtensionMethod("glDrawRangeElementArrayATI", typeof(DrawRangeElementArrayATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawMeshArraysSUN(int mode, Int32 first, Int32 count, Int32 width);
        internal static DrawMeshArraysSUN glDrawMeshArraysSUN = (DrawMeshArraysSUN)Gl.GetDelegateForExtensionMethod("glDrawMeshArraysSUN", typeof(DrawMeshArraysSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenOcclusionQueriesNV(Int32 n, [Out] UInt32* ids);
        internal unsafe static GenOcclusionQueriesNV glGenOcclusionQueriesNV = (GenOcclusionQueriesNV)Gl.GetDelegateForExtensionMethod("glGenOcclusionQueriesNV", typeof(GenOcclusionQueriesNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteOcclusionQueriesNV(Int32 n, UInt32* ids);
        internal unsafe static DeleteOcclusionQueriesNV glDeleteOcclusionQueriesNV = (DeleteOcclusionQueriesNV)Gl.GetDelegateForExtensionMethod("glDeleteOcclusionQueriesNV", typeof(DeleteOcclusionQueriesNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsOcclusionQueryNV(UInt32 id);
        internal static IsOcclusionQueryNV glIsOcclusionQueryNV = (IsOcclusionQueryNV)Gl.GetDelegateForExtensionMethod("glIsOcclusionQueryNV", typeof(IsOcclusionQueryNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginOcclusionQueryNV(UInt32 id);
        internal static BeginOcclusionQueryNV glBeginOcclusionQueryNV = (BeginOcclusionQueryNV)Gl.GetDelegateForExtensionMethod("glBeginOcclusionQueryNV", typeof(BeginOcclusionQueryNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndOcclusionQueryNV();
        internal static EndOcclusionQueryNV glEndOcclusionQueryNV = (EndOcclusionQueryNV)Gl.GetDelegateForExtensionMethod("glEndOcclusionQueryNV", typeof(EndOcclusionQueryNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetOcclusionQueryivNV(UInt32 id, int pname, [Out] Int32* @params);
        internal unsafe static GetOcclusionQueryivNV glGetOcclusionQueryivNV = (GetOcclusionQueryivNV)Gl.GetDelegateForExtensionMethod("glGetOcclusionQueryivNV", typeof(GetOcclusionQueryivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetOcclusionQueryuivNV(UInt32 id, int pname, [Out] UInt32* @params);
        internal unsafe static GetOcclusionQueryuivNV glGetOcclusionQueryuivNV = (GetOcclusionQueryuivNV)Gl.GetDelegateForExtensionMethod("glGetOcclusionQueryuivNV", typeof(GetOcclusionQueryuivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameteriNV(int pname, Int32 param);
        internal static PointParameteriNV glPointParameteriNV = (PointParameteriNV)Gl.GetDelegateForExtensionMethod("glPointParameteriNV", typeof(PointParameteriNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterivNV(int pname, Int32* @params);
        internal unsafe static PointParameterivNV glPointParameterivNV = (PointParameterivNV)Gl.GetDelegateForExtensionMethod("glPointParameterivNV", typeof(PointParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveStencilFaceEXT(int face);
        internal static ActiveStencilFaceEXT glActiveStencilFaceEXT = (ActiveStencilFaceEXT)Gl.GetDelegateForExtensionMethod("glActiveStencilFaceEXT", typeof(ActiveStencilFaceEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ElementPointerAPPLE(int type, void* pointer);
        internal unsafe static ElementPointerAPPLE glElementPointerAPPLE = (ElementPointerAPPLE)Gl.GetDelegateForExtensionMethod("glElementPointerAPPLE", typeof(ElementPointerAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementArrayAPPLE(int mode, Int32 first, Int32 count);
        internal static DrawElementArrayAPPLE glDrawElementArrayAPPLE = (DrawElementArrayAPPLE)Gl.GetDelegateForExtensionMethod("glDrawElementArrayAPPLE", typeof(DrawElementArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawRangeElementArrayAPPLE(int mode, UInt32 start, UInt32 end, Int32 first, Int32 count);
        internal static DrawRangeElementArrayAPPLE glDrawRangeElementArrayAPPLE = (DrawRangeElementArrayAPPLE)Gl.GetDelegateForExtensionMethod("glDrawRangeElementArrayAPPLE", typeof(DrawRangeElementArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElementArrayAPPLE(int mode, Int32* first, Int32* count, Int32 primcount);
        internal unsafe static MultiDrawElementArrayAPPLE glMultiDrawElementArrayAPPLE = (MultiDrawElementArrayAPPLE)Gl.GetDelegateForExtensionMethod("glMultiDrawElementArrayAPPLE", typeof(MultiDrawElementArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawRangeElementArrayAPPLE(int mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);
        internal unsafe static MultiDrawRangeElementArrayAPPLE glMultiDrawRangeElementArrayAPPLE = (MultiDrawRangeElementArrayAPPLE)Gl.GetDelegateForExtensionMethod("glMultiDrawRangeElementArrayAPPLE", typeof(MultiDrawRangeElementArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFencesAPPLE(Int32 n, [Out] UInt32* fences);
        internal unsafe static GenFencesAPPLE glGenFencesAPPLE = (GenFencesAPPLE)Gl.GetDelegateForExtensionMethod("glGenFencesAPPLE", typeof(GenFencesAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFencesAPPLE(Int32 n, UInt32* fences);
        internal unsafe static DeleteFencesAPPLE glDeleteFencesAPPLE = (DeleteFencesAPPLE)Gl.GetDelegateForExtensionMethod("glDeleteFencesAPPLE", typeof(DeleteFencesAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SetFenceAPPLE(UInt32 fence);
        internal static SetFenceAPPLE glSetFenceAPPLE = (SetFenceAPPLE)Gl.GetDelegateForExtensionMethod("glSetFenceAPPLE", typeof(SetFenceAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsFenceAPPLE(UInt32 fence);
        internal static IsFenceAPPLE glIsFenceAPPLE = (IsFenceAPPLE)Gl.GetDelegateForExtensionMethod("glIsFenceAPPLE", typeof(IsFenceAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int TestFenceAPPLE(UInt32 fence);
        internal static TestFenceAPPLE glTestFenceAPPLE = (TestFenceAPPLE)Gl.GetDelegateForExtensionMethod("glTestFenceAPPLE", typeof(TestFenceAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishFenceAPPLE(UInt32 fence);
        internal static FinishFenceAPPLE glFinishFenceAPPLE = (FinishFenceAPPLE)Gl.GetDelegateForExtensionMethod("glFinishFenceAPPLE", typeof(FinishFenceAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int TestObjectAPPLE(int @object, UInt32 name);
        internal static TestObjectAPPLE glTestObjectAPPLE = (TestObjectAPPLE)Gl.GetDelegateForExtensionMethod("glTestObjectAPPLE", typeof(TestObjectAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishObjectAPPLE(int @object, Int32 name);
        internal static FinishObjectAPPLE glFinishObjectAPPLE = (FinishObjectAPPLE)Gl.GetDelegateForExtensionMethod("glFinishObjectAPPLE", typeof(FinishObjectAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindVertexArrayAPPLE(UInt32 array);
        internal static BindVertexArrayAPPLE glBindVertexArrayAPPLE = (BindVertexArrayAPPLE)Gl.GetDelegateForExtensionMethod("glBindVertexArrayAPPLE", typeof(BindVertexArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteVertexArraysAPPLE(Int32 n, UInt32* arrays);
        internal unsafe static DeleteVertexArraysAPPLE glDeleteVertexArraysAPPLE = (DeleteVertexArraysAPPLE)Gl.GetDelegateForExtensionMethod("glDeleteVertexArraysAPPLE", typeof(DeleteVertexArraysAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenVertexArraysAPPLE(Int32 n, [Out] UInt32* arrays);
        internal unsafe static GenVertexArraysAPPLE glGenVertexArraysAPPLE = (GenVertexArraysAPPLE)Gl.GetDelegateForExtensionMethod("glGenVertexArraysAPPLE", typeof(GenVertexArraysAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsVertexArrayAPPLE(UInt32 array);
        internal static IsVertexArrayAPPLE glIsVertexArrayAPPLE = (IsVertexArrayAPPLE)Gl.GetDelegateForExtensionMethod("glIsVertexArrayAPPLE", typeof(IsVertexArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexArrayRangeAPPLE(Int32 length, [Out] void* pointer);
        internal unsafe static VertexArrayRangeAPPLE glVertexArrayRangeAPPLE = (VertexArrayRangeAPPLE)Gl.GetDelegateForExtensionMethod("glVertexArrayRangeAPPLE", typeof(VertexArrayRangeAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FlushVertexArrayRangeAPPLE(Int32 length, [Out] void* pointer);
        internal unsafe static FlushVertexArrayRangeAPPLE glFlushVertexArrayRangeAPPLE = (FlushVertexArrayRangeAPPLE)Gl.GetDelegateForExtensionMethod("glFlushVertexArrayRangeAPPLE", typeof(FlushVertexArrayRangeAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexArrayParameteriAPPLE(int pname, Int32 param);
        internal static VertexArrayParameteriAPPLE glVertexArrayParameteriAPPLE = (VertexArrayParameteriAPPLE)Gl.GetDelegateForExtensionMethod("glVertexArrayParameteriAPPLE", typeof(VertexArrayParameteriAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffersATI(Int32 n, int* bufs);
        internal unsafe static DrawBuffersATI glDrawBuffersATI = (DrawBuffersATI)Gl.GetDelegateForExtensionMethod("glDrawBuffersATI", typeof(DrawBuffersATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4fNV(UInt32 id, Int32 len, Byte* name, Single x, Single y, Single z, Single w);
        internal unsafe static ProgramNamedParameter4fNV glProgramNamedParameter4fNV = (ProgramNamedParameter4fNV)Gl.GetDelegateForExtensionMethod("glProgramNamedParameter4fNV", typeof(ProgramNamedParameter4fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4dNV(UInt32 id, Int32 len, Byte* name, Double x, Double y, Double z, Double w);
        internal unsafe static ProgramNamedParameter4dNV glProgramNamedParameter4dNV = (ProgramNamedParameter4dNV)Gl.GetDelegateForExtensionMethod("glProgramNamedParameter4dNV", typeof(ProgramNamedParameter4dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4fvNV(UInt32 id, Int32 len, Byte* name, Single* v);
        internal unsafe static ProgramNamedParameter4fvNV glProgramNamedParameter4fvNV = (ProgramNamedParameter4fvNV)Gl.GetDelegateForExtensionMethod("glProgramNamedParameter4fvNV", typeof(ProgramNamedParameter4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4dvNV(UInt32 id, Int32 len, Byte* name, Double* v);
        internal unsafe static ProgramNamedParameter4dvNV glProgramNamedParameter4dvNV = (ProgramNamedParameter4dvNV)Gl.GetDelegateForExtensionMethod("glProgramNamedParameter4dvNV", typeof(ProgramNamedParameter4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramNamedParameterfvNV(UInt32 id, Int32 len, Byte* name, [Out] Single* @params);
        internal unsafe static GetProgramNamedParameterfvNV glGetProgramNamedParameterfvNV = (GetProgramNamedParameterfvNV)Gl.GetDelegateForExtensionMethod("glGetProgramNamedParameterfvNV", typeof(GetProgramNamedParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramNamedParameterdvNV(UInt32 id, Int32 len, Byte* name, [Out] Double* @params);
        internal unsafe static GetProgramNamedParameterdvNV glGetProgramNamedParameterdvNV = (GetProgramNamedParameterdvNV)Gl.GetDelegateForExtensionMethod("glGetProgramNamedParameterdvNV", typeof(GetProgramNamedParameterdvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2hNV(UInt16 x, UInt16 y);
        internal static Vertex2hNV glVertex2hNV = (Vertex2hNV)Gl.GetDelegateForExtensionMethod("glVertex2hNV", typeof(Vertex2hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2hvNV(UInt16* v);
        internal unsafe static Vertex2hvNV glVertex2hvNV = (Vertex2hvNV)Gl.GetDelegateForExtensionMethod("glVertex2hvNV", typeof(Vertex2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3hNV(UInt16 x, UInt16 y, UInt16 z);
        internal static Vertex3hNV glVertex3hNV = (Vertex3hNV)Gl.GetDelegateForExtensionMethod("glVertex3hNV", typeof(Vertex3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3hvNV(UInt16* v);
        internal unsafe static Vertex3hvNV glVertex3hvNV = (Vertex3hvNV)Gl.GetDelegateForExtensionMethod("glVertex3hvNV", typeof(Vertex3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);
        internal static Vertex4hNV glVertex4hNV = (Vertex4hNV)Gl.GetDelegateForExtensionMethod("glVertex4hNV", typeof(Vertex4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4hvNV(UInt16* v);
        internal unsafe static Vertex4hvNV glVertex4hvNV = (Vertex4hvNV)Gl.GetDelegateForExtensionMethod("glVertex4hvNV", typeof(Vertex4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);
        internal static Normal3hNV glNormal3hNV = (Normal3hNV)Gl.GetDelegateForExtensionMethod("glNormal3hNV", typeof(Normal3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3hvNV(UInt16* v);
        internal unsafe static Normal3hvNV glNormal3hvNV = (Normal3hvNV)Gl.GetDelegateForExtensionMethod("glNormal3hvNV", typeof(Normal3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3hNV(UInt16 red, UInt16 green, UInt16 blue);
        internal static Color3hNV glColor3hNV = (Color3hNV)Gl.GetDelegateForExtensionMethod("glColor3hNV", typeof(Color3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3hvNV(UInt16* v);
        internal unsafe static Color3hvNV glColor3hvNV = (Color3hvNV)Gl.GetDelegateForExtensionMethod("glColor3hvNV", typeof(Color3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
        internal static Color4hNV glColor4hNV = (Color4hNV)Gl.GetDelegateForExtensionMethod("glColor4hNV", typeof(Color4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4hvNV(UInt16* v);
        internal unsafe static Color4hvNV glColor4hvNV = (Color4hvNV)Gl.GetDelegateForExtensionMethod("glColor4hvNV", typeof(Color4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1hNV(UInt16 s);
        internal static TexCoord1hNV glTexCoord1hNV = (TexCoord1hNV)Gl.GetDelegateForExtensionMethod("glTexCoord1hNV", typeof(TexCoord1hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1hvNV(UInt16* v);
        internal unsafe static TexCoord1hvNV glTexCoord1hvNV = (TexCoord1hvNV)Gl.GetDelegateForExtensionMethod("glTexCoord1hvNV", typeof(TexCoord1hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2hNV(UInt16 s, UInt16 t);
        internal static TexCoord2hNV glTexCoord2hNV = (TexCoord2hNV)Gl.GetDelegateForExtensionMethod("glTexCoord2hNV", typeof(TexCoord2hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2hvNV(UInt16* v);
        internal unsafe static TexCoord2hvNV glTexCoord2hvNV = (TexCoord2hvNV)Gl.GetDelegateForExtensionMethod("glTexCoord2hvNV", typeof(TexCoord2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);
        internal static TexCoord3hNV glTexCoord3hNV = (TexCoord3hNV)Gl.GetDelegateForExtensionMethod("glTexCoord3hNV", typeof(TexCoord3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3hvNV(UInt16* v);
        internal unsafe static TexCoord3hvNV glTexCoord3hvNV = (TexCoord3hvNV)Gl.GetDelegateForExtensionMethod("glTexCoord3hvNV", typeof(TexCoord3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);
        internal static TexCoord4hNV glTexCoord4hNV = (TexCoord4hNV)Gl.GetDelegateForExtensionMethod("glTexCoord4hNV", typeof(TexCoord4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4hvNV(UInt16* v);
        internal unsafe static TexCoord4hvNV glTexCoord4hvNV = (TexCoord4hvNV)Gl.GetDelegateForExtensionMethod("glTexCoord4hvNV", typeof(TexCoord4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1hNV(int target, UInt16 s);
        internal static MultiTexCoord1hNV glMultiTexCoord1hNV = (MultiTexCoord1hNV)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1hNV", typeof(MultiTexCoord1hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1hvNV(int target, UInt16* v);
        internal unsafe static MultiTexCoord1hvNV glMultiTexCoord1hvNV = (MultiTexCoord1hvNV)Gl.GetDelegateForExtensionMethod("glMultiTexCoord1hvNV", typeof(MultiTexCoord1hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2hNV(int target, UInt16 s, UInt16 t);
        internal static MultiTexCoord2hNV glMultiTexCoord2hNV = (MultiTexCoord2hNV)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2hNV", typeof(MultiTexCoord2hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2hvNV(int target, UInt16* v);
        internal unsafe static MultiTexCoord2hvNV glMultiTexCoord2hvNV = (MultiTexCoord2hvNV)Gl.GetDelegateForExtensionMethod("glMultiTexCoord2hvNV", typeof(MultiTexCoord2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3hNV(int target, UInt16 s, UInt16 t, UInt16 r);
        internal static MultiTexCoord3hNV glMultiTexCoord3hNV = (MultiTexCoord3hNV)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3hNV", typeof(MultiTexCoord3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3hvNV(int target, UInt16* v);
        internal unsafe static MultiTexCoord3hvNV glMultiTexCoord3hvNV = (MultiTexCoord3hvNV)Gl.GetDelegateForExtensionMethod("glMultiTexCoord3hvNV", typeof(MultiTexCoord3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4hNV(int target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);
        internal static MultiTexCoord4hNV glMultiTexCoord4hNV = (MultiTexCoord4hNV)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4hNV", typeof(MultiTexCoord4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4hvNV(int target, UInt16* v);
        internal unsafe static MultiTexCoord4hvNV glMultiTexCoord4hvNV = (MultiTexCoord4hvNV)Gl.GetDelegateForExtensionMethod("glMultiTexCoord4hvNV", typeof(MultiTexCoord4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordhNV(UInt16 fog);
        internal static FogCoordhNV glFogCoordhNV = (FogCoordhNV)Gl.GetDelegateForExtensionMethod("glFogCoordhNV", typeof(FogCoordhNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordhvNV(UInt16* fog);
        internal unsafe static FogCoordhvNV glFogCoordhvNV = (FogCoordhvNV)Gl.GetDelegateForExtensionMethod("glFogCoordhvNV", typeof(FogCoordhvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);
        internal static SecondaryColor3hNV glSecondaryColor3hNV = (SecondaryColor3hNV)Gl.GetDelegateForExtensionMethod("glSecondaryColor3hNV", typeof(SecondaryColor3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3hvNV(UInt16* v);
        internal unsafe static SecondaryColor3hvNV glSecondaryColor3hvNV = (SecondaryColor3hvNV)Gl.GetDelegateForExtensionMethod("glSecondaryColor3hvNV", typeof(SecondaryColor3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexWeighthNV(UInt16 weight);
        internal static VertexWeighthNV glVertexWeighthNV = (VertexWeighthNV)Gl.GetDelegateForExtensionMethod("glVertexWeighthNV", typeof(VertexWeighthNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexWeighthvNV(UInt16* weight);
        internal unsafe static VertexWeighthvNV glVertexWeighthvNV = (VertexWeighthvNV)Gl.GetDelegateForExtensionMethod("glVertexWeighthvNV", typeof(VertexWeighthvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1hNV(UInt32 index, UInt16 x);
        internal static VertexAttrib1hNV glVertexAttrib1hNV = (VertexAttrib1hNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib1hNV", typeof(VertexAttrib1hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1hvNV(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib1hvNV glVertexAttrib1hvNV = (VertexAttrib1hvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib1hvNV", typeof(VertexAttrib1hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);
        internal static VertexAttrib2hNV glVertexAttrib2hNV = (VertexAttrib2hNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib2hNV", typeof(VertexAttrib2hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2hvNV(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib2hvNV glVertexAttrib2hvNV = (VertexAttrib2hvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib2hvNV", typeof(VertexAttrib2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);
        internal static VertexAttrib3hNV glVertexAttrib3hNV = (VertexAttrib3hNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib3hNV", typeof(VertexAttrib3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3hvNV(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib3hvNV glVertexAttrib3hvNV = (VertexAttrib3hvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib3hvNV", typeof(VertexAttrib3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);
        internal static VertexAttrib4hNV glVertexAttrib4hNV = (VertexAttrib4hNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4hNV", typeof(VertexAttrib4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4hvNV(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4hvNV glVertexAttrib4hvNV = (VertexAttrib4hvNV)Gl.GetDelegateForExtensionMethod("glVertexAttrib4hvNV", typeof(VertexAttrib4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);
        internal unsafe static VertexAttribs1hvNV glVertexAttribs1hvNV = (VertexAttribs1hvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs1hvNV", typeof(VertexAttribs1hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);
        internal unsafe static VertexAttribs2hvNV glVertexAttribs2hvNV = (VertexAttribs2hvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs2hvNV", typeof(VertexAttribs2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);
        internal unsafe static VertexAttribs3hvNV glVertexAttribs3hvNV = (VertexAttribs3hvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs3hvNV", typeof(VertexAttribs3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);
        internal unsafe static VertexAttribs4hvNV glVertexAttribs4hvNV = (VertexAttribs4hvNV)Gl.GetDelegateForExtensionMethod("glVertexAttribs4hvNV", typeof(VertexAttribs4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelDataRangeNV(int target, Int32 length, [Out] void* pointer);
        internal unsafe static PixelDataRangeNV glPixelDataRangeNV = (PixelDataRangeNV)Gl.GetDelegateForExtensionMethod("glPixelDataRangeNV", typeof(PixelDataRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushPixelDataRangeNV(int target);
        internal static FlushPixelDataRangeNV glFlushPixelDataRangeNV = (FlushPixelDataRangeNV)Gl.GetDelegateForExtensionMethod("glFlushPixelDataRangeNV", typeof(FlushPixelDataRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PrimitiveRestartNV();
        internal static PrimitiveRestartNV glPrimitiveRestartNV = (PrimitiveRestartNV)Gl.GetDelegateForExtensionMethod("glPrimitiveRestartNV", typeof(PrimitiveRestartNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PrimitiveRestartIndexNV(UInt32 index);
        internal static PrimitiveRestartIndexNV glPrimitiveRestartIndexNV = (PrimitiveRestartIndexNV)Gl.GetDelegateForExtensionMethod("glPrimitiveRestartIndexNV", typeof(PrimitiveRestartIndexNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr MapObjectBufferATI(UInt32 buffer);
        internal static MapObjectBufferATI glMapObjectBufferATI = (MapObjectBufferATI)Gl.GetDelegateForExtensionMethod("glMapObjectBufferATI", typeof(MapObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UnmapObjectBufferATI(UInt32 buffer);
        internal static UnmapObjectBufferATI glUnmapObjectBufferATI = (UnmapObjectBufferATI)Gl.GetDelegateForExtensionMethod("glUnmapObjectBufferATI", typeof(UnmapObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOpSeparateATI(int face, int sfail, int dpfail, int dppass);
        internal static StencilOpSeparateATI glStencilOpSeparateATI = (StencilOpSeparateATI)Gl.GetDelegateForExtensionMethod("glStencilOpSeparateATI", typeof(StencilOpSeparateATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFuncSeparateATI(int frontfunc, int backfunc, Int32 @ref, UInt32 mask);
        internal static StencilFuncSeparateATI glStencilFuncSeparateATI = (StencilFuncSeparateATI)Gl.GetDelegateForExtensionMethod("glStencilFuncSeparateATI", typeof(StencilFuncSeparateATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribArrayObjectATI(UInt32 index, Int32 size, int type, int normalized, Int32 stride, UInt32 buffer, UInt32 offset);
        internal static VertexAttribArrayObjectATI glVertexAttribArrayObjectATI = (VertexAttribArrayObjectATI)Gl.GetDelegateForExtensionMethod("glVertexAttribArrayObjectATI", typeof(VertexAttribArrayObjectATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribArrayObjectfvATI(UInt32 index, int pname, [Out] Single* @params);
        internal unsafe static GetVertexAttribArrayObjectfvATI glGetVertexAttribArrayObjectfvATI = (GetVertexAttribArrayObjectfvATI)Gl.GetDelegateForExtensionMethod("glGetVertexAttribArrayObjectfvATI", typeof(GetVertexAttribArrayObjectfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribArrayObjectivATI(UInt32 index, int pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribArrayObjectivATI glGetVertexAttribArrayObjectivATI = (GetVertexAttribArrayObjectivATI)Gl.GetDelegateForExtensionMethod("glGetVertexAttribArrayObjectivATI", typeof(GetVertexAttribArrayObjectivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthBoundsEXT(Double zmin, Double zmax);
        internal static DepthBoundsEXT glDepthBoundsEXT = (DepthBoundsEXT)Gl.GetDelegateForExtensionMethod("glDepthBoundsEXT", typeof(DepthBoundsEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationSeparateEXT(int modeRGB, int modeAlpha);
        internal static BlendEquationSeparateEXT glBlendEquationSeparateEXT = (BlendEquationSeparateEXT)Gl.GetDelegateForExtensionMethod("glBlendEquationSeparateEXT", typeof(BlendEquationSeparateEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsRenderbufferEXT(UInt32 renderbuffer);
        internal static IsRenderbufferEXT glIsRenderbufferEXT = (IsRenderbufferEXT)Gl.GetDelegateForExtensionMethod("glIsRenderbufferEXT", typeof(IsRenderbufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindRenderbufferEXT(int target, UInt32 renderbuffer);
        internal static BindRenderbufferEXT glBindRenderbufferEXT = (BindRenderbufferEXT)Gl.GetDelegateForExtensionMethod("glBindRenderbufferEXT", typeof(BindRenderbufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteRenderbuffersEXT(Int32 n, UInt32* renderbuffers);
        internal unsafe static DeleteRenderbuffersEXT glDeleteRenderbuffersEXT = (DeleteRenderbuffersEXT)Gl.GetDelegateForExtensionMethod("glDeleteRenderbuffersEXT", typeof(DeleteRenderbuffersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenRenderbuffersEXT(Int32 n, [Out] UInt32* renderbuffers);
        internal unsafe static GenRenderbuffersEXT glGenRenderbuffersEXT = (GenRenderbuffersEXT)Gl.GetDelegateForExtensionMethod("glGenRenderbuffersEXT", typeof(GenRenderbuffersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageEXT(int target, int internalformat, Int32 width, Int32 height);
        internal static RenderbufferStorageEXT glRenderbufferStorageEXT = (RenderbufferStorageEXT)Gl.GetDelegateForExtensionMethod("glRenderbufferStorageEXT", typeof(RenderbufferStorageEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetRenderbufferParameterivEXT(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetRenderbufferParameterivEXT glGetRenderbufferParameterivEXT = (GetRenderbufferParameterivEXT)Gl.GetDelegateForExtensionMethod("glGetRenderbufferParameterivEXT", typeof(GetRenderbufferParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsFramebufferEXT(UInt32 framebuffer);
        internal static IsFramebufferEXT glIsFramebufferEXT = (IsFramebufferEXT)Gl.GetDelegateForExtensionMethod("glIsFramebufferEXT", typeof(IsFramebufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFramebufferEXT(int target, UInt32 framebuffer);
        internal static BindFramebufferEXT glBindFramebufferEXT = (BindFramebufferEXT)Gl.GetDelegateForExtensionMethod("glBindFramebufferEXT", typeof(BindFramebufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFramebuffersEXT(Int32 n, UInt32* framebuffers);
        internal unsafe static DeleteFramebuffersEXT glDeleteFramebuffersEXT = (DeleteFramebuffersEXT)Gl.GetDelegateForExtensionMethod("glDeleteFramebuffersEXT", typeof(DeleteFramebuffersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFramebuffersEXT(Int32 n, [Out] UInt32* framebuffers);
        internal unsafe static GenFramebuffersEXT glGenFramebuffersEXT = (GenFramebuffersEXT)Gl.GetDelegateForExtensionMethod("glGenFramebuffersEXT", typeof(GenFramebuffersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int CheckFramebufferStatusEXT(int target);
        internal static CheckFramebufferStatusEXT glCheckFramebufferStatusEXT = (CheckFramebufferStatusEXT)Gl.GetDelegateForExtensionMethod("glCheckFramebufferStatusEXT", typeof(CheckFramebufferStatusEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture1DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level);
        internal static FramebufferTexture1DEXT glFramebufferTexture1DEXT = (FramebufferTexture1DEXT)Gl.GetDelegateForExtensionMethod("glFramebufferTexture1DEXT", typeof(FramebufferTexture1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture2DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level);
        internal static FramebufferTexture2DEXT glFramebufferTexture2DEXT = (FramebufferTexture2DEXT)Gl.GetDelegateForExtensionMethod("glFramebufferTexture2DEXT", typeof(FramebufferTexture2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture3DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset);
        internal static FramebufferTexture3DEXT glFramebufferTexture3DEXT = (FramebufferTexture3DEXT)Gl.GetDelegateForExtensionMethod("glFramebufferTexture3DEXT", typeof(FramebufferTexture3DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferRenderbufferEXT(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer);
        internal static FramebufferRenderbufferEXT glFramebufferRenderbufferEXT = (FramebufferRenderbufferEXT)Gl.GetDelegateForExtensionMethod("glFramebufferRenderbufferEXT", typeof(FramebufferRenderbufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFramebufferAttachmentParameterivEXT(int target, int attachment, int pname, [Out] Int32* @params);
        internal unsafe static GetFramebufferAttachmentParameterivEXT glGetFramebufferAttachmentParameterivEXT = (GetFramebufferAttachmentParameterivEXT)Gl.GetDelegateForExtensionMethod("glGetFramebufferAttachmentParameterivEXT", typeof(GetFramebufferAttachmentParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GenerateMipmapEXT(int target);
        internal static GenerateMipmapEXT glGenerateMipmapEXT = (GenerateMipmapEXT)Gl.GetDelegateForExtensionMethod("glGenerateMipmapEXT", typeof(GenerateMipmapEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void StringMarkerGREMEDY(Int32 len, void* @string);
        internal unsafe static StringMarkerGREMEDY glStringMarkerGREMEDY = (StringMarkerGREMEDY)Gl.GetDelegateForExtensionMethod("glStringMarkerGREMEDY", typeof(StringMarkerGREMEDY));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);
        internal static StencilClearTagEXT glStencilClearTagEXT = (StencilClearTagEXT)Gl.GetDelegateForExtensionMethod("glStencilClearTagEXT", typeof(StencilClearTagEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, int mask, int filter);
        internal static BlitFramebufferEXT glBlitFramebufferEXT = (BlitFramebufferEXT)Gl.GetDelegateForExtensionMethod("glBlitFramebufferEXT", typeof(BlitFramebufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageMultisampleEXT(int target, Int32 samples, int internalformat, Int32 width, Int32 height);
        internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT = (RenderbufferStorageMultisampleEXT)Gl.GetDelegateForExtensionMethod("glRenderbufferStorageMultisampleEXT", typeof(RenderbufferStorageMultisampleEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjecti64vEXT(UInt32 id, int pname, [Out] Int64* @params);
        internal unsafe static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT = (GetQueryObjecti64vEXT)Gl.GetDelegateForExtensionMethod("glGetQueryObjecti64vEXT", typeof(GetQueryObjecti64vEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectui64vEXT(UInt32 id, int pname, [Out] UInt64* @params);
        internal unsafe static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT = (GetQueryObjectui64vEXT)Gl.GetDelegateForExtensionMethod("glGetQueryObjectui64vEXT", typeof(GetQueryObjectui64vEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameters4fvEXT(int target, UInt32 index, Int32 count, Single* @params);
        internal unsafe static ProgramEnvParameters4fvEXT glProgramEnvParameters4fvEXT = (ProgramEnvParameters4fvEXT)Gl.GetDelegateForExtensionMethod("glProgramEnvParameters4fvEXT", typeof(ProgramEnvParameters4fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameters4fvEXT(int target, UInt32 index, Int32 count, Single* @params);
        internal unsafe static ProgramLocalParameters4fvEXT glProgramLocalParameters4fvEXT = (ProgramLocalParameters4fvEXT)Gl.GetDelegateForExtensionMethod("glProgramLocalParameters4fvEXT", typeof(ProgramLocalParameters4fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BufferParameteriAPPLE(int target, int pname, Int32 param);
        internal static BufferParameteriAPPLE glBufferParameteriAPPLE = (BufferParameteriAPPLE)Gl.GetDelegateForExtensionMethod("glBufferParameteriAPPLE", typeof(BufferParameteriAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushMappedBufferRangeAPPLE(int target, IntPtr offset, IntPtr size);
        internal static FlushMappedBufferRangeAPPLE glFlushMappedBufferRangeAPPLE = (FlushMappedBufferRangeAPPLE)Gl.GetDelegateForExtensionMethod("glFlushMappedBufferRangeAPPLE", typeof(FlushMappedBufferRangeAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameterI4iNV(int target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
        internal static ProgramLocalParameterI4iNV glProgramLocalParameterI4iNV = (ProgramLocalParameterI4iNV)Gl.GetDelegateForExtensionMethod("glProgramLocalParameterI4iNV", typeof(ProgramLocalParameterI4iNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameterI4ivNV(int target, UInt32 index, Int32* @params);
        internal unsafe static ProgramLocalParameterI4ivNV glProgramLocalParameterI4ivNV = (ProgramLocalParameterI4ivNV)Gl.GetDelegateForExtensionMethod("glProgramLocalParameterI4ivNV", typeof(ProgramLocalParameterI4ivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParametersI4ivNV(int target, UInt32 index, Int32 count, Int32* @params);
        internal unsafe static ProgramLocalParametersI4ivNV glProgramLocalParametersI4ivNV = (ProgramLocalParametersI4ivNV)Gl.GetDelegateForExtensionMethod("glProgramLocalParametersI4ivNV", typeof(ProgramLocalParametersI4ivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameterI4uiNV(int target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
        internal static ProgramLocalParameterI4uiNV glProgramLocalParameterI4uiNV = (ProgramLocalParameterI4uiNV)Gl.GetDelegateForExtensionMethod("glProgramLocalParameterI4uiNV", typeof(ProgramLocalParameterI4uiNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameterI4uivNV(int target, UInt32 index, UInt32* @params);
        internal unsafe static ProgramLocalParameterI4uivNV glProgramLocalParameterI4uivNV = (ProgramLocalParameterI4uivNV)Gl.GetDelegateForExtensionMethod("glProgramLocalParameterI4uivNV", typeof(ProgramLocalParameterI4uivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParametersI4uivNV(int target, UInt32 index, Int32 count, UInt32* @params);
        internal unsafe static ProgramLocalParametersI4uivNV glProgramLocalParametersI4uivNV = (ProgramLocalParametersI4uivNV)Gl.GetDelegateForExtensionMethod("glProgramLocalParametersI4uivNV", typeof(ProgramLocalParametersI4uivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameterI4iNV(int target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
        internal static ProgramEnvParameterI4iNV glProgramEnvParameterI4iNV = (ProgramEnvParameterI4iNV)Gl.GetDelegateForExtensionMethod("glProgramEnvParameterI4iNV", typeof(ProgramEnvParameterI4iNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameterI4ivNV(int target, UInt32 index, Int32* @params);
        internal unsafe static ProgramEnvParameterI4ivNV glProgramEnvParameterI4ivNV = (ProgramEnvParameterI4ivNV)Gl.GetDelegateForExtensionMethod("glProgramEnvParameterI4ivNV", typeof(ProgramEnvParameterI4ivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParametersI4ivNV(int target, UInt32 index, Int32 count, Int32* @params);
        internal unsafe static ProgramEnvParametersI4ivNV glProgramEnvParametersI4ivNV = (ProgramEnvParametersI4ivNV)Gl.GetDelegateForExtensionMethod("glProgramEnvParametersI4ivNV", typeof(ProgramEnvParametersI4ivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameterI4uiNV(int target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
        internal static ProgramEnvParameterI4uiNV glProgramEnvParameterI4uiNV = (ProgramEnvParameterI4uiNV)Gl.GetDelegateForExtensionMethod("glProgramEnvParameterI4uiNV", typeof(ProgramEnvParameterI4uiNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameterI4uivNV(int target, UInt32 index, UInt32* @params);
        internal unsafe static ProgramEnvParameterI4uivNV glProgramEnvParameterI4uivNV = (ProgramEnvParameterI4uivNV)Gl.GetDelegateForExtensionMethod("glProgramEnvParameterI4uivNV", typeof(ProgramEnvParameterI4uivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParametersI4uivNV(int target, UInt32 index, Int32 count, UInt32* @params);
        internal unsafe static ProgramEnvParametersI4uivNV glProgramEnvParametersI4uivNV = (ProgramEnvParametersI4uivNV)Gl.GetDelegateForExtensionMethod("glProgramEnvParametersI4uivNV", typeof(ProgramEnvParametersI4uivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterIivNV(int target, UInt32 index, [Out] Int32* @params);
        internal unsafe static GetProgramLocalParameterIivNV glGetProgramLocalParameterIivNV = (GetProgramLocalParameterIivNV)Gl.GetDelegateForExtensionMethod("glGetProgramLocalParameterIivNV", typeof(GetProgramLocalParameterIivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterIuivNV(int target, UInt32 index, [Out] UInt32* @params);
        internal unsafe static GetProgramLocalParameterIuivNV glGetProgramLocalParameterIuivNV = (GetProgramLocalParameterIuivNV)Gl.GetDelegateForExtensionMethod("glGetProgramLocalParameterIuivNV", typeof(GetProgramLocalParameterIuivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterIivNV(int target, UInt32 index, [Out] Int32* @params);
        internal unsafe static GetProgramEnvParameterIivNV glGetProgramEnvParameterIivNV = (GetProgramEnvParameterIivNV)Gl.GetDelegateForExtensionMethod("glGetProgramEnvParameterIivNV", typeof(GetProgramEnvParameterIivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterIuivNV(int target, UInt32 index, [Out] UInt32* @params);
        internal unsafe static GetProgramEnvParameterIuivNV glGetProgramEnvParameterIuivNV = (GetProgramEnvParameterIuivNV)Gl.GetDelegateForExtensionMethod("glGetProgramEnvParameterIuivNV", typeof(GetProgramEnvParameterIuivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramVertexLimitNV(int target, Int32 limit);
        internal static ProgramVertexLimitNV glProgramVertexLimitNV = (ProgramVertexLimitNV)Gl.GetDelegateForExtensionMethod("glProgramVertexLimitNV", typeof(ProgramVertexLimitNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureEXT(int target, int attachment, UInt32 texture, Int32 level);
        internal static FramebufferTextureEXT glFramebufferTextureEXT = (FramebufferTextureEXT)Gl.GetDelegateForExtensionMethod("glFramebufferTextureEXT", typeof(FramebufferTextureEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureLayerEXT(int target, int attachment, UInt32 texture, Int32 level, Int32 layer);
        internal static FramebufferTextureLayerEXT glFramebufferTextureLayerEXT = (FramebufferTextureLayerEXT)Gl.GetDelegateForExtensionMethod("glFramebufferTextureLayerEXT", typeof(FramebufferTextureLayerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureFaceEXT(int target, int attachment, UInt32 texture, Int32 level, int face);
        internal static FramebufferTextureFaceEXT glFramebufferTextureFaceEXT = (FramebufferTextureFaceEXT)Gl.GetDelegateForExtensionMethod("glFramebufferTextureFaceEXT", typeof(FramebufferTextureFaceEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameteriEXT(UInt32 program, int pname, Int32 value);
        internal static ProgramParameteriEXT glProgramParameteriEXT = (ProgramParameteriEXT)Gl.GetDelegateForExtensionMethod("glProgramParameteriEXT", typeof(ProgramParameteriEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI1iEXT(UInt32 index, Int32 x);
        internal static VertexAttribI1iEXT glVertexAttribI1iEXT = (VertexAttribI1iEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI1iEXT", typeof(VertexAttribI1iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI2iEXT(UInt32 index, Int32 x, Int32 y);
        internal static VertexAttribI2iEXT glVertexAttribI2iEXT = (VertexAttribI2iEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI2iEXT", typeof(VertexAttribI2iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI3iEXT(UInt32 index, Int32 x, Int32 y, Int32 z);
        internal static VertexAttribI3iEXT glVertexAttribI3iEXT = (VertexAttribI3iEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI3iEXT", typeof(VertexAttribI3iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI4iEXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
        internal static VertexAttribI4iEXT glVertexAttribI4iEXT = (VertexAttribI4iEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI4iEXT", typeof(VertexAttribI4iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI1uiEXT(UInt32 index, UInt32 x);
        internal static VertexAttribI1uiEXT glVertexAttribI1uiEXT = (VertexAttribI1uiEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI1uiEXT", typeof(VertexAttribI1uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI2uiEXT(UInt32 index, UInt32 x, UInt32 y);
        internal static VertexAttribI2uiEXT glVertexAttribI2uiEXT = (VertexAttribI2uiEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI2uiEXT", typeof(VertexAttribI2uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI3uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
        internal static VertexAttribI3uiEXT glVertexAttribI3uiEXT = (VertexAttribI3uiEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI3uiEXT", typeof(VertexAttribI3uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI4uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
        internal static VertexAttribI4uiEXT glVertexAttribI4uiEXT = (VertexAttribI4uiEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI4uiEXT", typeof(VertexAttribI4uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI1ivEXT(UInt32 index, Int32* v);
        internal unsafe static VertexAttribI1ivEXT glVertexAttribI1ivEXT = (VertexAttribI1ivEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI1ivEXT", typeof(VertexAttribI1ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI2ivEXT(UInt32 index, Int32* v);
        internal unsafe static VertexAttribI2ivEXT glVertexAttribI2ivEXT = (VertexAttribI2ivEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI2ivEXT", typeof(VertexAttribI2ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI3ivEXT(UInt32 index, Int32* v);
        internal unsafe static VertexAttribI3ivEXT glVertexAttribI3ivEXT = (VertexAttribI3ivEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI3ivEXT", typeof(VertexAttribI3ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4ivEXT(UInt32 index, Int32* v);
        internal unsafe static VertexAttribI4ivEXT glVertexAttribI4ivEXT = (VertexAttribI4ivEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI4ivEXT", typeof(VertexAttribI4ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI1uivEXT(UInt32 index, UInt32* v);
        internal unsafe static VertexAttribI1uivEXT glVertexAttribI1uivEXT = (VertexAttribI1uivEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI1uivEXT", typeof(VertexAttribI1uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI2uivEXT(UInt32 index, UInt32* v);
        internal unsafe static VertexAttribI2uivEXT glVertexAttribI2uivEXT = (VertexAttribI2uivEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI2uivEXT", typeof(VertexAttribI2uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI3uivEXT(UInt32 index, UInt32* v);
        internal unsafe static VertexAttribI3uivEXT glVertexAttribI3uivEXT = (VertexAttribI3uivEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI3uivEXT", typeof(VertexAttribI3uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4uivEXT(UInt32 index, UInt32* v);
        internal unsafe static VertexAttribI4uivEXT glVertexAttribI4uivEXT = (VertexAttribI4uivEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI4uivEXT", typeof(VertexAttribI4uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4bvEXT(UInt32 index, SByte* v);
        internal unsafe static VertexAttribI4bvEXT glVertexAttribI4bvEXT = (VertexAttribI4bvEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI4bvEXT", typeof(VertexAttribI4bvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4svEXT(UInt32 index, Int16* v);
        internal unsafe static VertexAttribI4svEXT glVertexAttribI4svEXT = (VertexAttribI4svEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI4svEXT", typeof(VertexAttribI4svEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4ubvEXT(UInt32 index, Byte* v);
        internal unsafe static VertexAttribI4ubvEXT glVertexAttribI4ubvEXT = (VertexAttribI4ubvEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI4ubvEXT", typeof(VertexAttribI4ubvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4usvEXT(UInt32 index, UInt16* v);
        internal unsafe static VertexAttribI4usvEXT glVertexAttribI4usvEXT = (VertexAttribI4usvEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribI4usvEXT", typeof(VertexAttribI4usvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribIPointerEXT(UInt32 index, Int32 size, int type, Int32 stride, void* pointer);
        internal unsafe static VertexAttribIPointerEXT glVertexAttribIPointerEXT = (VertexAttribIPointerEXT)Gl.GetDelegateForExtensionMethod("glVertexAttribIPointerEXT", typeof(VertexAttribIPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribIivEXT(UInt32 index, int pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribIivEXT glGetVertexAttribIivEXT = (GetVertexAttribIivEXT)Gl.GetDelegateForExtensionMethod("glGetVertexAttribIivEXT", typeof(GetVertexAttribIivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribIuivEXT(UInt32 index, int pname, [Out] UInt32* @params);
        internal unsafe static GetVertexAttribIuivEXT glGetVertexAttribIuivEXT = (GetVertexAttribIuivEXT)Gl.GetDelegateForExtensionMethod("glGetVertexAttribIuivEXT", typeof(GetVertexAttribIuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformuivEXT(UInt32 program, Int32 location, [Out] UInt32* @params);
        internal unsafe static GetUniformuivEXT glGetUniformuivEXT = (GetUniformuivEXT)Gl.GetDelegateForExtensionMethod("glGetUniformuivEXT", typeof(GetUniformuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFragDataLocationEXT(UInt32 program, UInt32 color, System.String name);
        internal static BindFragDataLocationEXT glBindFragDataLocationEXT = (BindFragDataLocationEXT)Gl.GetDelegateForExtensionMethod("glBindFragDataLocationEXT", typeof(BindFragDataLocationEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetFragDataLocationEXT(UInt32 program, System.String name);
        internal static GetFragDataLocationEXT glGetFragDataLocationEXT = (GetFragDataLocationEXT)Gl.GetDelegateForExtensionMethod("glGetFragDataLocationEXT", typeof(GetFragDataLocationEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1uiEXT(Int32 location, UInt32 v0);
        internal static Uniform1uiEXT glUniform1uiEXT = (Uniform1uiEXT)Gl.GetDelegateForExtensionMethod("glUniform1uiEXT", typeof(Uniform1uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2uiEXT(Int32 location, UInt32 v0, UInt32 v1);
        internal static Uniform2uiEXT glUniform2uiEXT = (Uniform2uiEXT)Gl.GetDelegateForExtensionMethod("glUniform2uiEXT", typeof(Uniform2uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
        internal static Uniform3uiEXT glUniform3uiEXT = (Uniform3uiEXT)Gl.GetDelegateForExtensionMethod("glUniform3uiEXT", typeof(Uniform3uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
        internal static Uniform4uiEXT glUniform4uiEXT = (Uniform4uiEXT)Gl.GetDelegateForExtensionMethod("glUniform4uiEXT", typeof(Uniform4uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1uivEXT(Int32 location, Int32 count, UInt32* value);
        internal unsafe static Uniform1uivEXT glUniform1uivEXT = (Uniform1uivEXT)Gl.GetDelegateForExtensionMethod("glUniform1uivEXT", typeof(Uniform1uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2uivEXT(Int32 location, Int32 count, UInt32* value);
        internal unsafe static Uniform2uivEXT glUniform2uivEXT = (Uniform2uivEXT)Gl.GetDelegateForExtensionMethod("glUniform2uivEXT", typeof(Uniform2uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3uivEXT(Int32 location, Int32 count, UInt32* value);
        internal unsafe static Uniform3uivEXT glUniform3uivEXT = (Uniform3uivEXT)Gl.GetDelegateForExtensionMethod("glUniform3uivEXT", typeof(Uniform3uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4uivEXT(Int32 location, Int32 count, UInt32* value);
        internal unsafe static Uniform4uivEXT glUniform4uivEXT = (Uniform4uivEXT)Gl.GetDelegateForExtensionMethod("glUniform4uivEXT", typeof(Uniform4uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysInstancedEXT(int mode, Int32 start, Int32 count, Int32 primcount);
        internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT = (DrawArraysInstancedEXT)Gl.GetDelegateForExtensionMethod("glDrawArraysInstancedEXT", typeof(DrawArraysInstancedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawElementsInstancedEXT(int mode, Int32 count, int type, void* indices, Int32 primcount);
        internal unsafe static DrawElementsInstancedEXT glDrawElementsInstancedEXT = (DrawElementsInstancedEXT)Gl.GetDelegateForExtensionMethod("glDrawElementsInstancedEXT", typeof(DrawElementsInstancedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexBufferEXT(int target, int internalformat, UInt32 buffer);
        internal static TexBufferEXT glTexBufferEXT = (TexBufferEXT)Gl.GetDelegateForExtensionMethod("glTexBufferEXT", typeof(TexBufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthRangedNV(Double zNear, Double zFar);
        internal static DepthRangedNV glDepthRangedNV = (DepthRangedNV)Gl.GetDelegateForExtensionMethod("glDepthRangedNV", typeof(DepthRangedNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearDepthdNV(Double depth);
        internal static ClearDepthdNV glClearDepthdNV = (ClearDepthdNV)Gl.GetDelegateForExtensionMethod("glClearDepthdNV", typeof(ClearDepthdNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthBoundsdNV(Double zmin, Double zmax);
        internal static DepthBoundsdNV glDepthBoundsdNV = (DepthBoundsdNV)Gl.GetDelegateForExtensionMethod("glDepthBoundsdNV", typeof(DepthBoundsdNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageMultisampleCoverageNV(int target, Int32 coverageSamples, Int32 colorSamples, int internalformat, Int32 width, Int32 height);
        internal static RenderbufferStorageMultisampleCoverageNV glRenderbufferStorageMultisampleCoverageNV = (RenderbufferStorageMultisampleCoverageNV)Gl.GetDelegateForExtensionMethod("glRenderbufferStorageMultisampleCoverageNV", typeof(RenderbufferStorageMultisampleCoverageNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramBufferParametersfvNV(int target, UInt32 buffer, UInt32 index, Int32 count, Single* @params);
        internal unsafe static ProgramBufferParametersfvNV glProgramBufferParametersfvNV = (ProgramBufferParametersfvNV)Gl.GetDelegateForExtensionMethod("glProgramBufferParametersfvNV", typeof(ProgramBufferParametersfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramBufferParametersIivNV(int target, UInt32 buffer, UInt32 index, Int32 count, Int32* @params);
        internal unsafe static ProgramBufferParametersIivNV glProgramBufferParametersIivNV = (ProgramBufferParametersIivNV)Gl.GetDelegateForExtensionMethod("glProgramBufferParametersIivNV", typeof(ProgramBufferParametersIivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramBufferParametersIuivNV(int target, UInt32 buffer, UInt32 index, Int32 count, UInt32* @params);
        internal unsafe static ProgramBufferParametersIuivNV glProgramBufferParametersIuivNV = (ProgramBufferParametersIuivNV)Gl.GetDelegateForExtensionMethod("glProgramBufferParametersIuivNV", typeof(ProgramBufferParametersIuivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMaskIndexedEXT(UInt32 index, int r, int g, int b, int a);
        internal static ColorMaskIndexedEXT glColorMaskIndexedEXT = (ColorMaskIndexedEXT)Gl.GetDelegateForExtensionMethod("glColorMaskIndexedEXT", typeof(ColorMaskIndexedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBooleanIndexedvEXT(int target, UInt32 index, [Out] int* data);
        internal unsafe static GetBooleanIndexedvEXT glGetBooleanIndexedvEXT = (GetBooleanIndexedvEXT)Gl.GetDelegateForExtensionMethod("glGetBooleanIndexedvEXT", typeof(GetBooleanIndexedvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetIntegerIndexedvEXT(int target, UInt32 index, [Out] Int32* data);
        internal unsafe static GetIntegerIndexedvEXT glGetIntegerIndexedvEXT = (GetIntegerIndexedvEXT)Gl.GetDelegateForExtensionMethod("glGetIntegerIndexedvEXT", typeof(GetIntegerIndexedvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableIndexedEXT(int target, UInt32 index);
        internal static EnableIndexedEXT glEnableIndexedEXT = (EnableIndexedEXT)Gl.GetDelegateForExtensionMethod("glEnableIndexedEXT", typeof(EnableIndexedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableIndexedEXT(int target, UInt32 index);
        internal static DisableIndexedEXT glDisableIndexedEXT = (DisableIndexedEXT)Gl.GetDelegateForExtensionMethod("glDisableIndexedEXT", typeof(DisableIndexedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int IsEnabledIndexedEXT(int target, UInt32 index);
        internal static IsEnabledIndexedEXT glIsEnabledIndexedEXT = (IsEnabledIndexedEXT)Gl.GetDelegateForExtensionMethod("glIsEnabledIndexedEXT", typeof(IsEnabledIndexedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginTransformFeedbackNV(int primitiveMode);
        internal static BeginTransformFeedbackNV glBeginTransformFeedbackNV = (BeginTransformFeedbackNV)Gl.GetDelegateForExtensionMethod("glBeginTransformFeedbackNV", typeof(BeginTransformFeedbackNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndTransformFeedbackNV();
        internal static EndTransformFeedbackNV glEndTransformFeedbackNV = (EndTransformFeedbackNV)Gl.GetDelegateForExtensionMethod("glEndTransformFeedbackNV", typeof(EndTransformFeedbackNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TransformFeedbackAttribsNV(UInt32 count, Int32* attribs, int bufferMode);
        internal unsafe static TransformFeedbackAttribsNV glTransformFeedbackAttribsNV = (TransformFeedbackAttribsNV)Gl.GetDelegateForExtensionMethod("glTransformFeedbackAttribsNV", typeof(TransformFeedbackAttribsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferRangeNV(int target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
        internal static BindBufferRangeNV glBindBufferRangeNV = (BindBufferRangeNV)Gl.GetDelegateForExtensionMethod("glBindBufferRangeNV", typeof(BindBufferRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferOffsetNV(int target, UInt32 index, UInt32 buffer, IntPtr offset);
        internal static BindBufferOffsetNV glBindBufferOffsetNV = (BindBufferOffsetNV)Gl.GetDelegateForExtensionMethod("glBindBufferOffsetNV", typeof(BindBufferOffsetNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferBaseNV(int target, UInt32 index, UInt32 buffer);
        internal static BindBufferBaseNV glBindBufferBaseNV = (BindBufferBaseNV)Gl.GetDelegateForExtensionMethod("glBindBufferBaseNV", typeof(BindBufferBaseNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, int bufferMode);
        internal unsafe static TransformFeedbackVaryingsNV glTransformFeedbackVaryingsNV = (TransformFeedbackVaryingsNV)Gl.GetDelegateForExtensionMethod("glTransformFeedbackVaryingsNV", typeof(TransformFeedbackVaryingsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveVaryingNV(UInt32 program, System.String name);
        internal static ActiveVaryingNV glActiveVaryingNV = (ActiveVaryingNV)Gl.GetDelegateForExtensionMethod("glActiveVaryingNV", typeof(ActiveVaryingNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetVaryingLocationNV(UInt32 program, System.String name);
        internal static GetVaryingLocationNV glGetVaryingLocationNV = (GetVaryingLocationNV)Gl.GetDelegateForExtensionMethod("glGetVaryingLocationNV", typeof(GetVaryingLocationNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveVaryingNV glGetActiveVaryingNV = (GetActiveVaryingNV)Gl.GetDelegateForExtensionMethod("glGetActiveVaryingNV", typeof(GetActiveVaryingNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, [Out] Int32* location);
        internal unsafe static GetTransformFeedbackVaryingNV glGetTransformFeedbackVaryingNV = (GetTransformFeedbackVaryingNV)Gl.GetDelegateForExtensionMethod("glGetTransformFeedbackVaryingNV", typeof(GetTransformFeedbackVaryingNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);
        internal static UniformBufferEXT glUniformBufferEXT = (UniformBufferEXT)Gl.GetDelegateForExtensionMethod("glUniformBufferEXT", typeof(UniformBufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetUniformBufferSizeEXT(UInt32 program, Int32 location);
        internal static GetUniformBufferSizeEXT glGetUniformBufferSizeEXT = (GetUniformBufferSizeEXT)Gl.GetDelegateForExtensionMethod("glGetUniformBufferSizeEXT", typeof(GetUniformBufferSizeEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr GetUniformOffsetEXT(UInt32 program, Int32 location);
        internal static GetUniformOffsetEXT glGetUniformOffsetEXT = (GetUniformOffsetEXT)Gl.GetDelegateForExtensionMethod("glGetUniformOffsetEXT", typeof(GetUniformOffsetEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterIivEXT(int target, int pname, Int32* @params);
        internal unsafe static TexParameterIivEXT glTexParameterIivEXT = (TexParameterIivEXT)Gl.GetDelegateForExtensionMethod("glTexParameterIivEXT", typeof(TexParameterIivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterIuivEXT(int target, int pname, UInt32* @params);
        internal unsafe static TexParameterIuivEXT glTexParameterIuivEXT = (TexParameterIuivEXT)Gl.GetDelegateForExtensionMethod("glTexParameterIuivEXT", typeof(TexParameterIuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterIivEXT(int target, int pname, [Out] Int32* @params);
        internal unsafe static GetTexParameterIivEXT glGetTexParameterIivEXT = (GetTexParameterIivEXT)Gl.GetDelegateForExtensionMethod("glGetTexParameterIivEXT", typeof(GetTexParameterIivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterIuivEXT(int target, int pname, [Out] UInt32* @params);
        internal unsafe static GetTexParameterIuivEXT glGetTexParameterIuivEXT = (GetTexParameterIuivEXT)Gl.GetDelegateForExtensionMethod("glGetTexParameterIuivEXT", typeof(GetTexParameterIuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);
        internal static ClearColorIiEXT glClearColorIiEXT = (ClearColorIiEXT)Gl.GetDelegateForExtensionMethod("glClearColorIiEXT", typeof(ClearColorIiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
        internal static ClearColorIuiEXT glClearColorIuiEXT = (ClearColorIuiEXT)Gl.GetDelegateForExtensionMethod("glClearColorIuiEXT", typeof(ClearColorIuiEXT));
    }
}
