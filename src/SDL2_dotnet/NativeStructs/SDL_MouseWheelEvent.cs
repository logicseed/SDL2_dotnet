// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains mouse wheel event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_MouseWheelEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.MouseWheel"/>
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
        /// The amount scrolled horizontally, positive to the right and negative to the left.
        /// </summary>
        public int X;

        /// <summary>
        /// The amount scrolled vertically, positive away from the user and negative towards the user.
        /// </summary>
        public int Y;

        /// <summary>
        /// Direction of the mouse wheel. When <see cref="MouseWheelDirection.Flipped"/> the values in <see cref="X"/>
        /// and <see cref="Y"/> will be opposite. Multiply by <c>-1</c> to change them back.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public MouseWheelDirection Direction;
    }
}
