// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    public partial class Window
    {
        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_CreateWindow"
        )]
        private static extern IntPtr SDL_CreateWindow(
            string title,
            int x,
            int y,
            int width,
            int height,
            [MarshalAs(UnmanagedType.U4)]
            WindowOptions options
        );

        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_DestroyWindow"
        )]
        private static extern void SDL_DestroyWindow(IntPtr windowPointer);
    }
}
