// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains mouse motion event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_MouseMotionEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.MouseMotion"/>.
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
        /// The state of the button.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public MouseButton MouseButton;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private byte padding1;
        private byte padding2;
        private byte padding3;
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

        /// <summary>
        /// The relative motion in the X direction.
        /// </summary>
        public int RelativeX;

        /// <summary>
        /// The relative motion in the Y direction.
        /// </summary>
        public int RelativeY;
    }
}
