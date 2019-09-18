// SPDX-License-Identifier: MIT

using System;

namespace SDL2_dotnet
{
    public partial struct Color
    {
        public byte Red;
        public byte Green;
        public byte Blue;
        public byte Alpha;

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 0;
        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        internal uint MapRGB(IntPtr pixelFormat)
        {
            return SDL_MapRGB(pixelFormat, Red, Green, Blue);
        }

        internal uint MapRGBA(IntPtr pixelFormat)
        {
            return SDL_MapRGBA(pixelFormat, Red, Green, Blue, Alpha);
        }
    }
}
