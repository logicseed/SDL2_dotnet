// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains keyboard text editing event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_TextEditingEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.TextEditing"/>
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
        /// The null-terminated input text in UTF-8 encoding.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 32)]
        public byte[] Text;

        /// <summary>
        /// The location to begin editing from.
        /// </summary>
        public int Start;

        /// <summary>
        /// The number of characters to edit from the start point.
        /// </summary>
        public int Length;
    }
}
