// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    public partial class Surface
    {
        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_FillRect"
        )]
        private static extern uint SDL_FillRect(
            IntPtr surfacePointer,
            IntPtr rect,
            uint colorMap
        );

        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_FillRect"
        )]
        private static extern uint SDL_FillRect(
            IntPtr surfacePointer,
            ref Rect rect,
            uint colorMap
        );
    }
}
