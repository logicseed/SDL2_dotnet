// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// Fields shared by every event.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_CommonEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.KeyDown"/> or <see cref="EventType.KeyUp"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public EventType EventType;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp;
    }
}
