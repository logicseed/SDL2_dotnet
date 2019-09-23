// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct Color
    {
        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_MapRGB"
        )]
        private static extern uint SDL_MapRGB(
            IntPtr format, // SDL_PixelFormat*
            byte red,
            byte green,
            byte blue
        );

        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_MapRGBA"
        )]
        private static extern uint SDL_MapRGBA(
            IntPtr format, // SDL_PixelFormat*
            byte red,
            byte green,
            byte blue,
            byte alpha
        );
    }
}
