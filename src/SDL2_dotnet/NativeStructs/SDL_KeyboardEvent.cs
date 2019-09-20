// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains keyboard button event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_KeyboardEvent
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
        /// The associated window.
        /// </summary>
        public uint WindowID;

        /// <summary>
        /// The state of the key.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public PressedState PressedState;

        /// <summary>
        /// Non-zero if this is a key repeat.
        /// </summary>
        public byte Repeat;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private byte padding1;
        private byte padding2;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier

        /// <summary>
        /// The SDL_Keysym representing the key that was pressed or released.
        /// </summary>
        public SDL_Keysym keysym;
    }
}
