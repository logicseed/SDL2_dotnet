// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    public partial class SDL2
    {
        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_Init"
        )]
        private static extern int SDL_Init(
            [MarshalAs(UnmanagedType.U4)]
            Subsystems subsystems
        );

        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_Quit"
        )]
        private static extern void SDL_Quit();
    }
}
