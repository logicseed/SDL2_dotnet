// SPDX-License-Identifier: MIT

namespace SDL2_dotnet
{
    public partial class SDL2 : ErrorAccess
    {
        private readonly Subsystems _subsystems;

        public SDL2(Subsystems subsystems)
        {
            _subsystems = subsystems;

            if (SDL_Init(_subsystems) < 0)
            {
                var message = $"SDL2 could not be initialized! SDL_Error: {GetError()}";
                throw new InitializationException(message);
            }
        }
    }
}
