﻿// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_PixelFormat
    {
        public uint Format;
        public IntPtr Palette; // SDL_Pallette*
        public byte BitsPerPixel;
        public byte BytesPerPixel;
        public uint RMask;
        public uint GMask;
        public uint BMask;
        public uint AMask;

        public byte RLoss;
        public byte GLoss;
        public byte BLoss;
        public byte ALoss;
        public byte RShift;
        public byte GShift;
        public byte BShift;
        public byte AShift;
        public int RefCount;
        public IntPtr Next; // SDL_PixelFormat*
    }
}
