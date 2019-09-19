// SPDX-License-Identifier: MIT

using System;

namespace SDL2_dotnet
{
    public partial class Window
    {
        private readonly IntPtr _windowPointer;

        public Surface Surface { get; }

        public Window(string title, int x, int y, int width, int height, WindowOptions options)
        {
            _windowPointer = SDL_CreateWindow(title, x, y, width, height, options);

            if (_windowPointer == null)
            {
                string message = $"Window could not be created! SDL_Error: {SDL2.GetError()}";
                throw new InitializationException(message);
            }

            IntPtr surfacePointer = SDL_GetWindowSurface(_windowPointer);
            Surface = new Surface(surfacePointer);
        }

        public Window(string title, WindowPosition x, WindowPosition y, int width, int height, WindowOptions options)
            : this(title, (int)x, (int)y, width, height, options) { }

        public Window(string title, WindowPosition x, int y, int width, int height, WindowOptions options)
            : this(title, (int)x, y, width, height, options) { }

        public Window(string title, int x, WindowPosition y, int width, int height, WindowOptions options)
            : this(title, x, (int)y, width, height, options) { }

        public Window(string title, WindowPosition position, int width, int height, WindowOptions options)
            : this(title, (int)position, (int)position, width, height, options) { }

        public Window(string title, int x, int y, ScreenResolution resolution, WindowOptions options)
            : this(title, x, y, resolution.Width(), resolution.Height(), options) { }

        public Window(string title, WindowPosition x, WindowPosition y, ScreenResolution resolution, WindowOptions options)
            : this(title, (int)x, (int)y, resolution.Width(), resolution.Height(), options) { }

        public Window(string title, WindowPosition x, int y, ScreenResolution resolution, WindowOptions options)
            : this(title, (int)x, y, resolution.Width(), resolution.Height(), options) { }

        public Window(string title, int x, WindowPosition y, ScreenResolution resolution, WindowOptions options)
            : this(title, x, (int)y, resolution.Width(), resolution.Height(), options) { }

        public Window(string title, WindowPosition position, ScreenResolution resolution, WindowOptions options)
            : this(title, (int)position, (int)position, resolution.Width(), resolution.Height(), options) { }

        public void Update()
        {
            SDL_UpdateWindowSurface(_windowPointer);
        }
    }
}
