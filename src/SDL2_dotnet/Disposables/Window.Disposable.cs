// SPDX-License-Identifier: MIT

using System;

namespace SDL2_dotnet
{
    public partial class Window : IDisposable
    {
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                SDL_DestroyWindow(_windowPointer);
                disposed = true;
            }
        }

        ~Window()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
