// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains a video driver dependent system event.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_SysWMEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.SystemWindowManager"/>
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public EventType EventType;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp;

        /// <summary>
        /// Driver dependent data.
        /// </summary>
        public IntPtr Data; // SDL_SysWMmsg*
    }
}
