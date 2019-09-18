// SPDX-License-Identifier: MIT

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace SDL2_dotnet
{
    /// <summary>
    /// Provides access to native error messages.
    /// </summary>
    public abstract partial class ErrorAccess
    {
#pragma warning disable CA1822 // Mark members as static

        /// <summary>
        /// Clears any previous error message.
        /// </summary>
        internal void ClearError()
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
        /// It's possible for multiple errors to occur before calling <see cref="GetError"/>(). Only the last error
        /// is returned.
        /// </remarks>
        internal string GetError()
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
        /// Calling <see cref="SetError"/>() will replace any previous error message that was set.
        /// </remarks>
        internal void SetError(string message)
        {
            SDL_SetError(message);
        }

#pragma warning restore CA1822 // Mark members as static
    }
}
