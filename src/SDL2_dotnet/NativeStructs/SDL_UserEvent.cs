// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains an application-defined event type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_UserEvent
    {
        /// <summary>
        /// Should be a UserEvent
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public EventType EventType;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp;

        /// <summary>
        /// The associated window.
        /// </summary>
        public uint WindowID;

        /// <summary>
        /// User-defined event code.
        /// </summary>
        public int Code;

        /// <summary>
        /// User-defined data pointer.
        /// </summary>
        public IntPtr Data1;

        /// <summary>
        /// User-defined data pointer.
        /// </summary>
        public IntPtr Data2;
    }
}
