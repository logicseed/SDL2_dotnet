// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains an event used to request a file open by the system.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_DropEvent
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

        /// <summary>
        /// The file name, which should be freed with SDL_free(), is NULL on begin/complete.
        /// </summary>
        public IntPtr file; // char* filename

        /// <summary>
        /// The associated window.
        /// </summary>
        public uint WindowID;
    }
}
