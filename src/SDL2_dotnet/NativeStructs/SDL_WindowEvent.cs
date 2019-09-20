// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// Window state change event data.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_WindowEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.Window"/>
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
        /// The type of window state change event.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public WindowEventType WindowEventType;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private byte padding1;
        private byte padding2;
        private byte padding3;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier

        /// <summary>
        /// Event dependent data.
        /// </summary>
        public int Data1;

        /// <summary>
        /// Event dependent data.
        /// </summary>
        public int Data2;
    }
}
