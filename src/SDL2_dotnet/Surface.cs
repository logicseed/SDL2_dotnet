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

        public static Surface LoadBMP(string imagePath)
        {
            IntPtr filePointer = SDL2.SDL_RWFromFile(imagePath, "rb");
            IntPtr surfacePointer = SDL_LoadBMP_RW(filePointer, 1);

            if (surfacePointer == null)
            {
                string message = $"Unable to load bitmap {imagePath}! SDL_Error: {SDL2.GetError()}";
                throw new InitializationException(message);
            }

            return new Surface(surfacePointer);
        }

        public void BlitSurface(Surface source, Rect? sourceRect = null, Rect? destinationRect = null)
        {
            if (sourceRect == null)
            {
                if (destinationRect == null)
                {
                    SDL_BlitSurface(source._surfacePointer, IntPtr.Zero, _surfacePointer, IntPtr.Zero);
                }
                else
                {
                    Rect dstRect = destinationRect.Value;
                    SDL_BlitSurface(source._surfacePointer, IntPtr.Zero, _surfacePointer, ref dstRect);
                }
            }
            else
            {
                Rect srcRect = sourceRect.Value;

                if (destinationRect == null)
                {
                    SDL_BlitSurface(source._surfacePointer, ref srcRect, _surfacePointer, IntPtr.Zero);
                }
                else
                {
                    Rect dstRect = destinationRect.Value;
                    SDL_BlitSurface(source._surfacePointer, ref srcRect, _surfacePointer, ref dstRect);
                }
            }
        }
    }
}
