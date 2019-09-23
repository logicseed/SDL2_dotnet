// SPDX-License-Identifier: MIT

using System;

namespace SDL
{
    public partial class SDL2 : IDisposable
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

                SDL_Quit();
                disposed = true;
            }
        }

        ~SDL2()
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
