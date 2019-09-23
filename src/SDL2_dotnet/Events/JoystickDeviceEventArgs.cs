// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains joystick device event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct JoystickDeviceEventArgs : IEquatable<JoystickDeviceEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickDeviceAdded"/> or <see cref="EventType.JoystickDeviceRemoved"/>.
        /// </summary>
        public EventType Type => _type;
        [FieldOffset(0)]
        private readonly EventType _type;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp => _timestamp;
        [FieldOffset(4)]
        private readonly uint _timestamp;

        /// <summary>
        /// The instance ID of the joystick that reported the event.
        /// </summary>
        public int JoystickID => _joystickID; // SDL_JoystickID
        [FieldOffset(8)]
        private readonly int _joystickID;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is JoystickDeviceEventArgs args && Equals(args);
        }

        public bool Equals(JoystickDeviceEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _joystickID == other._joystickID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _joystickID);
        }

        public static bool operator ==(JoystickDeviceEventArgs left, JoystickDeviceEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(JoystickDeviceEventArgs left, JoystickDeviceEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
