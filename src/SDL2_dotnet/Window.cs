// SPDX-License-Identifier: MIT

using System;

namespace SDL2_dotnet
{
    public partial class Window : ErrorAccess
    {
        private readonly IntPtr _windowPointer;

        public Surface Surface { get; }

        public Window(string title, int x, int y, int width, int height, WindowOptions options)
        {
            _windowPointer = SDL_CreateWindow(title, x, y, width, height, options);

            if (_windowPointer == null)
            {
                var message = $"Window could not be created! SDL_Error: {GetError()}";
                throw new InitializationException(message);
            }

            var surfacePointer = SDL_GetWindowSurface(_windowPointer);
            Surface = new Surface(surfacePointer);
        }

        public Window(string title, WindowPosition x, WindowPosition y, int width, int height, WindowOptions options)
            : this(title, (int)x, (int)y, width, height, options) { }

        public void UpdateWindowSurface()
        {
            SDL_UpdateWindowSurface(_windowPointer);
        }
    }
}
