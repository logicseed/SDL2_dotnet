// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains joystick hat position change event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyHatEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickHatMotion"/>.
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
        /// THe index of the hat that changed.
        /// </summary>
        public byte HatIndex;

        /// <summary>
        /// The new position of the hat.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public JoystickHatPosition JoystickHatPosition;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private byte padding1;
        private byte padding2;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier
    }
}
