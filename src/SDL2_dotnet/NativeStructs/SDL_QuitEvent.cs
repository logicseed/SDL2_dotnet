// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains the "quit requested" event.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_QuitEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.Quit"/>
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public EventType EventType;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp;
    }
}
