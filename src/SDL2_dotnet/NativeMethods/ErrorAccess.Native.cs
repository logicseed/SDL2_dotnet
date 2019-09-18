// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    public abstract partial class ErrorAccess
    {
        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_ClearError"
        )]
        private static extern void SDL_ClearError();

        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_GetError"
        )]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        private static extern string SDL_GetError();

        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_SetError"
        )]
        private static extern int SDL_SetError(string message);
    }
}
