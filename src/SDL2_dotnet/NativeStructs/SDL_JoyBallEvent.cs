// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains joystick trackball motion event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyBallEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickBallMotion"/>.
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
        /// The index of the trackball that changed.
        /// </summary>
        public byte BallIndex;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private byte padding1;
        private byte padding2;
        private byte padding3;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier

        /// <summary>
        /// The relative motion in the X direction.
        /// </summary>
        public short RelativeX;

        /// <summary>
        /// The relative motion in the Y direction.
        /// </summary>
        public short RelativeY;
    }
}
