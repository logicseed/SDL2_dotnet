// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    public partial class Surface
    {
        private readonly IntPtr _surfacePointer;
        private readonly SDL_Surface _surface;

        internal Surface(IntPtr surfacePointer)
        {
            _surfacePointer = surfacePointer;
            _surface = Marshal.PtrToStructure<SDL_Surface>(_surfacePointer);
        }

        public void Fill(Color color)
        {
            SDL_FillRect(_surfacePointer, IntPtr.Zero, color.MapRGB(_surface.PixelFormat));
        }

        public void Fill(Rect rect, Color color)
        {
            SDL_FillRect(_surfacePointer, ref rect, color.MapRGB(_surface.PixelFormat));
        }
    }
}
