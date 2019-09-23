// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains joystick hat position change event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct JoystickHatEventArgs : IEquatable<JoystickHatEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickHatMotion"/>.
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
        /// THe index of the hat that changed.
        /// </summary>
        public byte Index => _index;
        [FieldOffset(12)]
        private readonly byte _index;

        /// <summary>
        /// The new position of the hat.
        /// </summary>
        public JoystickHatPosition Position => _position;
        [FieldOffset(13)]
        private readonly JoystickHatPosition _position;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is JoystickHatEventArgs args && Equals(args);
        }

        public bool Equals(JoystickHatEventArgs other)
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

        public static bool operator ==(JoystickHatEventArgs left, JoystickHatEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(JoystickHatEventArgs left, JoystickHatEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
