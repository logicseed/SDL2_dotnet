// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains mouse button event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_MouseButtonEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.MouseButtonDown"/> or <see cref="EventType.MouseButtonUp"/>.
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
        /// The mouse instance ID.
        /// </summary>
        public uint MouseID;

        /// <summary>
        /// The button that changed.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public MouseButton MouseButton;

        /// <summary>
        /// The state of the button.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public PressedState PressedState;

        /// <summary>
        /// 1 for single-click, 2 for double-click, etc.
        /// </summary>
        public byte ClickCount;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private byte padding1;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier

        /// <summary>
        ///THe  X coordinate, relative to window.
        /// </summary>
        public int X;

        /// <summary>
        /// The Y coordinate, relative to window.
        /// </summary>
        public int Y;
    }
}
