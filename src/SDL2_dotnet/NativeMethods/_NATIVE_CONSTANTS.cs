// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL
{
    internal static class NATIVE_CONSTANTS
    {
#if Windows

        public const string LIBRARY_PATH_SDL2 = "SDL2";
        public const string LIBRARY_PATH_SDL2_IMAGE = "SDL2_image";
        public const string LIBRARY_PATH_SDL2_MIXER = "SDL2_mixer";
        public const string LIBRARY_PATH_SDL2_TTF = "SDL2_ttf";

        public const CallingConvention CALLING_CONVENTION = CallingConvention.Cdecl;
        public const CharSet CHAR_SET = CharSet.Ansi;
        public const bool SET_LAST_ERROR = false;

#elif OSX

#elif Linux

#endif

    }
}
