// SPDX-License-Identifier: MIT

namespace SDL2_dotnet
{
    public partial class SDL2
    {
        private readonly Subsystems _subsystems;

        public SDL2(Subsystems subsystems)
        {
            _subsystems = subsystems;

            if (SDL_Init(_subsystems) < 0)
            {
                string message = $"SDL2 could not be initialized! SDL_Error: {SDL2.GetError()}";
                throw new InitializationException(message);
            }
        }

        /// <summary>
        /// Clears any previous error message.
        /// </summary>
        internal static void ClearError()
        {
            SDL_ClearError();
        }

        /// <summary>
        /// Retrieves a message about the last error that occurred.
        /// </summary>
        /// <returns>
        /// The last error that occurred.
        /// </returns>
        /// <remarks>
        /// It's possible for multiple errors to occur before calling <see cref="Get"/>(). Only the last error
        /// is returned.
        /// </remarks>
        internal static string GetError()
        {
            return SDL_GetError();
        }

        /// <summary>
        /// Sets the error message.
        /// </summary>
        /// <param name="message">
        /// The error message to set.
        /// </param>
        /// <remarks>
        /// Calling <see cref="Set"/>() will replace any previous error message that was set.
        /// </remarks>
        internal static void SetError(string message)
        {
            SDL_SetError(message);
        }
    }
}
