// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains joystick button event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyButtonEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickButtonUp"/> or <see cref="EventType.JoystickButtonDown"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public EventType EventType;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp;

        /// <summary>
        /// The instance ID of the joystick that reported the event.
        /// </summary>
        public int JoystickID; // SDL_JoystickID

        /// <summary>
        /// The index of the button that changed.
        /// </summary>
        public byte ButtonIndex;

        /// <summary>
        /// The state of the button.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public PressedState PressedState;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private byte padding1;
        private byte padding2;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier
    }
}
