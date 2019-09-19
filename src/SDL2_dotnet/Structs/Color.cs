// SPDX-License-Identifier: MIT

using System;

namespace SDL2_dotnet
{
    public partial struct Color
    {
        public byte R;
        public byte G;
        public byte B;
        public byte A;

        public Color(byte red, byte green, byte blue)
        {
            R = red;
            G = green;
            B = blue;
            A = 0;
        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            R = red;
            G = green;
            B = blue;
            A = alpha;
        }

        internal uint MapRGB(IntPtr pixelFormat)
        {
            return SDL_MapRGB(pixelFormat, R, G, B);
        }

        internal uint MapRGBA(IntPtr pixelFormat)
        {
            return SDL_MapRGBA(pixelFormat, R, G, B, A);
        }

        public static Color Black => new Color(0, 0, 0);
        public static Color White => new Color(255, 255, 255);
        public static Color Red => new Color(244, 67, 54);
        public static Color Pink => new Color(233, 30, 99);
        public static Color Purple => new Color(156, 39, 176);
        public static Color DeepPurple => new Color(103, 58, 183);
        public static Color Indigo => new Color(63, 81, 181);
        public static Color Blue => new Color(33, 150, 243);
        public static Color LightBlue => new Color(3, 169, 244);
        public static Color Cyan => new Color(0, 188, 212);
        public static Color Teal => new Color(0, 150, 136);
        public static Color Green => new Color(76, 175, 80);
        public static Color LightGreen => new Color(139, 195, 74);
        public static Color Lime => new Color(205, 220, 57);
        public static Color Yellow => new Color(255, 235, 59);
        public static Color Amber => new Color(255, 193, 7);
        public static Color Orange => new Color(255, 152, 0);
        public static Color DeepOrange => new Color(255, 87, 34);
        public static Color Brown => new Color(121, 85, 72);
        public static Color Grey => new Color(158, 158, 158);
        public static Color BlueGrey => new Color(96, 125, 139);
        public static Color DarkRed => new Color(183, 28, 28);
        public static Color DarkPink => new Color(136, 14, 79);
        public static Color DarkPurple => new Color(74, 20, 140);
        public static Color DarkDeepPurple => new Color(49, 27, 146);
        public static Color DarkIndigo => new Color(26, 35, 126);
        public static Color DarkBlue => new Color(13, 71, 161);
        public static Color DarkLightBlue => new Color(1, 87, 155);
        public static Color DarkCyan => new Color(0, 96, 100);
        public static Color DarkTeal => new Color(0, 77, 64);
        public static Color DarkGreen => new Color(27, 94, 32);
        public static Color DarkLightGreen => new Color(51, 105, 30);
        public static Color DarkLime => new Color(130, 119, 23);
        public static Color DarkYellow => new Color(245, 127, 23);
        public static Color DarkAmber => new Color(255, 111, 0);
        public static Color DarkOrange => new Color(230, 81, 0);
        public static Color DarkDeepOrange => new Color(191, 54, 12);
        public static Color DarkBrown => new Color(62, 39, 35);
        public static Color DarkGrey => new Color(33, 33, 33);
        public static Color DarkBlueGrey => new Color(38, 50, 56);
    }
}
