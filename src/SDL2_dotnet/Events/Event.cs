// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL.Events
{
    public static class Event
    {
        private static EventArgs _currentEventArgs;

        public static EventType Type => _currentEventArgs.Type;

        /// <summary>
        /// Whether there is an event sitting in the event queue.
        /// </summary>
        public static bool Next => SDL_PollEvent(out _currentEventArgs) != 0;

        #region Native Methods

        [DllImport(
            NATIVE_CONSTANTS.LIBRARY_PATH_SDL2,
            CallingConvention = NATIVE_CONSTANTS.CALLING_CONVENTION,
            CharSet = NATIVE_CONSTANTS.CHAR_SET,
            SetLastError = NATIVE_CONSTANTS.SET_LAST_ERROR,
            EntryPoint = "SDL_PollEvent"
        )]
        private static extern int SDL_PollEvent(out EventArgs @event);

        #endregion Native Methods
    }
}
