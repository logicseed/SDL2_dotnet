// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains joystick axis motion event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct JoystickAxisEventArgs : IEquatable<JoystickAxisEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickAxisMotion"/>.
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

        /// <summary>
        /// The index of the axis that changed
        /// </summary>
        public byte Index => _index;
        [FieldOffset(12)]
        private readonly byte _index;

        /// <summary>
        /// The current position of the axis (range: -32768 to 32767)
        /// </summary>
        public short Position => _position;
        [FieldOffset(16)]
        private readonly short _position;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is JoystickAxisEventArgs args && Equals(args);
        }

        public bool Equals(JoystickAxisEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _joystickID == other._joystickID &&
                _index == other._index &&
                _position == other._position;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _joystickID, _index, _position);
        }

        public static bool operator ==(JoystickAxisEventArgs left, JoystickAxisEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(JoystickAxisEventArgs left, JoystickAxisEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
