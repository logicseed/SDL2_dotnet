// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains joystick device event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyDeviceEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickDeviceAdded"/> or <see cref="EventType.JoystickDeviceRemoved"/>.
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
    }
}
