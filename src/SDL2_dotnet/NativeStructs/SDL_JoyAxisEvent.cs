// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains joystick axis motion event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyAxisEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickAxisMotion"/>.
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
        /// The index of the axis that changed
        /// </summary>
        public byte AxisIndex;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private byte padding1;
        private byte padding2;
        private byte padding3;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier

        /// <summary>
        /// The current position of the axis (range: -32768 to 32767)
        /// </summary>
        public short AxisPosition;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        public ushort padding4;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier
    }
}
