﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vector.Win32
{
    public static partial class Wgl
    {
        // Manually added, GlBindGen seems to skip this one
        public const int WGL_FONT_POLYGONS = ((int)1);

        public const int WGL_SWAP_METHOD_EXT = ((int)0x2007);
        public const int WGL_MIPMAP_TEXTURE_ARB = ((int)0x2074);
        public const int WGL_NO_ACCELERATION_ARB = ((int)0x2025);
        public const int WGL_SAMPLE_BUFFERS_EXT = ((int)0x2041);
        public const int WGL_BIND_TO_TEXTURE_RGB_ARB = ((int)0x2070);
        public const int WGL_AUX_BUFFERS_EXT = ((int)0x2024);
        public const int WGL_AUX0_ARB = ((int)0x2087);
        public const int WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D = ((int)0x204A);
        public const int WGL_ACCUM_ALPHA_BITS_EXT = ((int)0x2021);
        public const int WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV = ((int)0x20B1);
        public const int WGL_IMAGE_BUFFER_LOCK_I3D = ((int)0x00000002);
        public const int WGL_BLUE_SHIFT_EXT = ((int)0x201A);
        public const int WGL_NEED_SYSTEM_PALETTE_EXT = ((int)0x2005);
        public const int WGL_SHARE_ACCUM_EXT = ((int)0x200E);
        public const int WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = ((int)0x207E);
        public const int WGL_DRAW_TO_PBUFFER_ARB = ((int)0x202D);
        public const int WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = ((int)0x2053);
        public const int WGL_TEXTURE_CUBE_MAP_ARB = ((int)0x2078);
        public const int WGL_TYPE_RGBA_FLOAT_ARB = ((int)0x21A0);
        public const int WGL_FULL_ACCELERATION_EXT = ((int)0x2027);
        public const int WGL_ACCUM_GREEN_BITS_EXT = ((int)0x201F);
        public const int WGL_BACK_COLOR_BUFFER_BIT_ARB = ((int)0x00000002);
        public const int WGL_ACCUM_GREEN_BITS_ARB = ((int)0x201F);
        public const int WGL_MAX_PBUFFER_WIDTH_EXT = ((int)0x202F);
        public const int WGL_ACCUM_RED_BITS_EXT = ((int)0x201E);
        public const int WGL_AUX9_ARB = ((int)0x2090);
        public const int WGL_TRANSPARENT_EXT = ((int)0x200A);
        public const int WGL_ACCUM_ALPHA_BITS_ARB = ((int)0x2021);
        public const int WGL_GENERIC_ACCELERATION_EXT = ((int)0x2026);
        public const int WGL_AUX2_ARB = ((int)0x2089);
        public const int WGL_PIXEL_TYPE_EXT = ((int)0x2013);
        public const int WGL_NUMBER_PIXEL_FORMATS_EXT = ((int)0x2000);
        public const int WGL_ACCELERATION_ARB = ((int)0x2003);
        public const int WGL_IMAGE_BUFFER_MIN_ACCESS_I3D = ((int)0x00000001);
        public const int WGL_DOUBLE_BUFFER_EXT = ((int)0x2011);
        public const int WGL_NEED_PALETTE_EXT = ((int)0x2004);
        public const int WGL_TEXTURE_FLOAT_RG_NV = ((int)0x20B6);
        public const int WGL_DEPTH_FLOAT_EXT = ((int)0x2040);
        public const int WGL_BLUE_BITS_ARB = ((int)0x2019);
        public const int WGL_ACCUM_BITS_EXT = ((int)0x201D);
        public const int WGL_MAX_PBUFFER_WIDTH_ARB = ((int)0x202F);
        public const int WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = ((int)0x2080);
        public const int WGL_NUMBER_OVERLAYS_ARB = ((int)0x2008);
        public const int WGL_TEXTURE_RGB_ARB = ((int)0x2075);
        public const int WGL_SUPPORT_GDI_EXT = ((int)0x200F);
        public const int WGL_PBUFFER_HEIGHT_EXT = ((int)0x2035);
        public const int WGL_BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = ((int)0x20A4);
        public const int WGL_SAMPLE_BUFFERS_ARB = ((int)0x2041);
        public const int WGL_TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A);
        public const int WGL_GREEN_SHIFT_ARB = ((int)0x2018);
        public const int WGL_BIND_TO_TEXTURE_RECTANGLE_RGBA_NV = ((int)0x20A1);
        public const int WGL_TYPE_COLORINDEX_EXT = ((int)0x202C);
        public const int WGL_SHARE_STENCIL_ARB = ((int)0x200D);
        public const int WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D = ((int)0x2048);
        public const int WGL_SHARE_DEPTH_EXT = ((int)0x200C);
        public const int WGL_NO_ACCELERATION_EXT = ((int)0x2025);
        public const int WGL_BLUE_SHIFT_ARB = ((int)0x201A);
        public const int WGL_SUPPORT_GDI_ARB = ((int)0x200F);
        public const int WGL_NO_TEXTURE_ARB = ((int)0x2077);
        public const int WGL_TEXTURE_FLOAT_RGBA_NV = ((int)0x20B8);
        public const int WGL_DEPTH_TEXTURE_FORMAT_NV = ((int)0x20A5);
        public const int WGL_TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039);
        public const int WGL_DEPTH_BUFFER_BIT_ARB = ((int)0x00000004);
        public const int WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = ((int)0x2082);
        public const int WGL_SWAP_EXCHANGE_ARB = ((int)0x2028);
        public const int WGL_TRANSPARENT_RED_VALUE_ARB = ((int)0x2037);
        public const int WGL_SWAP_COPY_ARB = ((int)0x2029);
        public const int WGL_GREEN_SHIFT_EXT = ((int)0x2018);
        public const int WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = ((int)0x2081);
        public const int WGL_TYPE_RGBA_EXT = ((int)0x202B);
        public const int WGL_TYPE_RGBA_FLOAT_ATI = ((int)0x21A0);
        public const int WGL_NUMBER_PIXEL_FORMATS_ARB = ((int)0x2000);
        public const int WGL_TEXTURE_RGBA_ARB = ((int)0x2076);
        public const int WGL_SWAP_COPY_EXT = ((int)0x2029);
        public const int WGL_NEED_SYSTEM_PALETTE_ARB = ((int)0x2005);
        public const int WGL_TEXTURE_FLOAT_RGB_NV = ((int)0x20B7);
        public const int WGL_SWAP_UNDEFINED_ARB = ((int)0x202A);
        public const int WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D = ((int)0x2049);
        public const int WGL_GENLOCK_SOURCE_EDGE_RISING_I3D = ((int)0x204B);
        public const int WGL_SWAP_LAYER_BUFFERS_EXT = ((int)0x2006);
        public const int WGL_SWAP_UNDEFINED_EXT = ((int)0x202A);
        public const int WGL_FULL_ACCELERATION_ARB = ((int)0x2027);
        public const int WGL_NUMBER_UNDERLAYS_ARB = ((int)0x2009);
        public const int WGL_BIND_TO_TEXTURE_RGBA_ARB = ((int)0x2071);
        public const int WGL_TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038);
        public const int WGL_PIXEL_TYPE_ARB = ((int)0x2013);
        public const int WGL_NEED_PALETTE_ARB = ((int)0x2004);
        public const int WGL_NUMBER_OVERLAYS_EXT = ((int)0x2008);
        public const int WGL_DEPTH_BITS_EXT = ((int)0x2022);
        public const int WGL_AUX3_ARB = ((int)0x208A);
        public const int WGL_DEPTH_BITS_ARB = ((int)0x2022);
        public const int WGL_GENERIC_ACCELERATION_ARB = ((int)0x2026);
        public const int WGL_TYPE_RGBA_ARB = ((int)0x202B);
        public const int WGL_DRAW_TO_WINDOW_EXT = ((int)0x2001);
        public const int WGL_TEXTURE_2D_ARB = ((int)0x207A);
        public const int WGL_STENCIL_BUFFER_BIT_ARB = ((int)0x00000008);
        public const int WGL_SWAP_EXCHANGE_EXT = ((int)0x2028);
        public const int WGL_SHARE_STENCIL_EXT = ((int)0x200D);
        public const int WGL_STEREO_ARB = ((int)0x2012);
        public const int WGL_SHARE_ACCUM_ARB = ((int)0x200E);
        public const int WGL_TEXTURE_RECTANGLE_NV = ((int)0x20A2);
        public const int WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV = ((int)0x20B3);
        public const int WGL_STENCIL_BITS_EXT = ((int)0x2023);
        public const int WGL_MIPMAP_LEVEL_ARB = ((int)0x207B);
        public const int WGL_DRAW_TO_WINDOW_ARB = ((int)0x2001);
        public const int WGL_AUX5_ARB = ((int)0x208C);
        public const int WGL_DEPTH_COMPONENT_NV = ((int)0x20A7);
        public const int WGL_AUX1_ARB = ((int)0x2088);
        public const int WGL_TEXTURE_DEPTH_COMPONENT_NV = ((int)0x20A6);
        public const int WGL_FRONT_LEFT_ARB = ((int)0x2083);
        public const int WGL_MAX_PBUFFER_HEIGHT_EXT = ((int)0x2030);
        public const int WGL_RED_BITS_EXT = ((int)0x2015);
        public const int WGL_GENLOCK_SOURCE_EXTENAL_TTL_I3D = ((int)0x2047);
        public const int WGL_RED_SHIFT_ARB = ((int)0x2016);
        public const int WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = ((int)0x207F);
        public const int WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = ((int)0x2051);
        public const int WGL_TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B);
        public const int WGL_ALPHA_BITS_EXT = ((int)0x201B);
        public const int WGL_TRANSPARENT_VALUE_EXT = ((int)0x200B);
        public const int WGL_BIND_TO_TEXTURE_DEPTH_NV = ((int)0x20A3);
        public const int WGL_TEXTURE_1D_ARB = ((int)0x2079);
        public const int WGL_MAX_PBUFFER_PIXELS_ARB = ((int)0x202E);
        public const int WGL_SUPPORT_OPENGL_ARB = ((int)0x2010);
        public const int WGL_TEXTURE_TARGET_ARB = ((int)0x2073);
        public const int WGL_SAMPLE_BUFFERS_3DFX = ((int)0x2060);
        public const int WGL_TEXTURE_FLOAT_R_NV = ((int)0x20B5);
        public const int WGL_COLOR_BITS_EXT = ((int)0x2014);
        public const int WGL_BACK_RIGHT_ARB = ((int)0x2086);
        public const int WGL_PBUFFER_HEIGHT_ARB = ((int)0x2035);
        public const int WGL_ACCUM_BLUE_BITS_ARB = ((int)0x2020);
        public const int WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB = ((int)0x207D);
        public const int WGL_GENLOCK_SOURCE_EXTENAL_SYNC_I3D = ((int)0x2045);
        public const int WGL_SWAP_METHOD_ARB = ((int)0x2007);
        public const int WGL_AUX8_ARB = ((int)0x208F);
        public const int WGL_TYPE_COLORINDEX_ARB = ((int)0x202C);
        public const int WGL_DRAW_TO_PBUFFER_EXT = ((int)0x202D);
        public const int WGL_CUBE_MAP_FACE_ARB = ((int)0x207C);
        public const int WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D = ((int)0x204C);
        public const int WGL_SAMPLES_3DFX = ((int)0x2061);
        public const int WGL_MAX_PBUFFER_PIXELS_EXT = ((int)0x202E);
        public const int WGL_DOUBLE_BUFFER_ARB = ((int)0x2011);
        public const int WGL_STEREO_EXT = ((int)0x2012);
        public const int WGL_RED_SHIFT_EXT = ((int)0x2016);
        public const int WGL_ALPHA_BITS_ARB = ((int)0x201B);
        public const int WGL_COLOR_BITS_ARB = ((int)0x2014);
        public const int WGL_GAMMA_TABLE_SIZE_I3D = ((int)0x204E);
        public const int WGL_AUX_BUFFERS_ARB = ((int)0x2024);
        public const int WGL_ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = ((int)0x2054);
        public const int WGL_FRONT_COLOR_BUFFER_BIT_ARB = ((int)0x00000001);
        public const int WGL_SAMPLES_EXT = ((int)0x2042);
        public const int WGL_ALPHA_SHIFT_EXT = ((int)0x201C);
        public const int WGL_ACCELERATION_EXT = ((int)0x2003);
        public const int WGL_AUX6_ARB = ((int)0x208D);
        public const int WGL_FRONT_RIGHT_ARB = ((int)0x2084);
        public const int WGL_PBUFFER_WIDTH_ARB = ((int)0x2034);
        public const int WGL_PBUFFER_LARGEST_ARB = ((int)0x2033);
        public const int WGL_NUMBER_UNDERLAYS_EXT = ((int)0x2009);
        public const int WGL_ACCUM_BITS_ARB = ((int)0x201D);
        public const int WGL_STENCIL_BITS_ARB = ((int)0x2023);
        public const int WGL_ACCUM_BLUE_BITS_EXT = ((int)0x2020);
        public const int WGL_MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030);
        public const int WGL_AUX4_ARB = ((int)0x208B);
        public const int WGL_TEXTURE_FORMAT_ARB = ((int)0x2072);
        public const int WGL_ACCUM_RED_BITS_ARB = ((int)0x201E);
        public const int WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV = ((int)0x20B4);
        public const int WGL_FLOAT_COMPONENTS_NV = ((int)0x20B0);
        public const int WGL_TRANSPARENT_ARB = ((int)0x200A);
        public const int WGL_RED_BITS_ARB = ((int)0x2015);
        public const int WGL_GREEN_BITS_ARB = ((int)0x2017);
        public const int WGL_GENLOCK_SOURCE_MULTIVIEW_I3D = ((int)0x2044);
        public const int WGL_BLUE_BITS_EXT = ((int)0x2019);
        public const int WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV = ((int)0x20B2);
        public const int WGL_GREEN_BITS_EXT = ((int)0x2017);
        public const int WGL_SHARE_DEPTH_ARB = ((int)0x200C);
        public const int WGL_ALPHA_SHIFT_ARB = ((int)0x201C);
        public const int WGL_PBUFFER_WIDTH_EXT = ((int)0x2034);
        public const int WGL_BIND_TO_TEXTURE_RECTANGLE_RGB_NV = ((int)0x20A0);
        public const int WGL_SWAP_LAYER_BUFFERS_ARB = ((int)0x2006);
        public const int WGL_ERROR_INVALID_PIXEL_TYPE_ARB = ((int)0x2043);
        public const int WGL_AUX7_ARB = ((int)0x208E);
        public const int WGL_PBUFFER_LOST_ARB = ((int)0x2036);
        public const int WGL_ERROR_INVALID_PIXEL_TYPE_EXT = ((int)0x2043);
        public const int WGL_SAMPLES_ARB = ((int)0x2042);
        public const int WGL_GENLOCK_SOURCE_EXTENAL_FIELD_I3D = ((int)0x2046);
        public const int WGL_GAMMA_EXCLUDE_DESKTOP_I3D = ((int)0x204F);
        public const int WGL_FONT_LINES = ((int)0);
        public const int WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = ((int)0x2052);
        public const int WGL_OPTIMAL_PBUFFER_HEIGHT_EXT = ((int)0x2032);
        public const int WGL_PBUFFER_LARGEST_EXT = ((int)0x2033);
        public const int WGL_DRAW_TO_BITMAP_EXT = ((int)0x2002);
        public const int WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = ((int)0x2050);
        public const int WGL_OPTIMAL_PBUFFER_WIDTH_EXT = ((int)0x2031);
        public const int WGL_DRAW_TO_BITMAP_ARB = ((int)0x2002);
        public const int WGL_BACK_LEFT_ARB = ((int)0x2085);
        public const int WGL_SUPPORT_OPENGL_EXT = ((int)0x2010);
    }
}
