// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_Surface
    {
        public uint Flags;
        public IntPtr PixelFormat; // SDL_PixelFormat
        public int Width;
        public int Height;
        public int Pitch;
        public IntPtr Pixels; // void*
        public IntPtr UserData; // void*
        public int Locked;
        public IntPtr LockData; // void*
        public Rect ClipRect;
        public IntPtr BlitMap; // SDL_BlitMap*
        public int RefCount;
    }
}
