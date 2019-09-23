// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains joystick button event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct JoystickButtonEventArgs : IEquatable<JoystickButtonEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickButtonUp"/> or <see cref="EventType.JoystickButtonDown"/>.
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
        /// The index of the button that changed.
        /// </summary>
        public byte Index => _index;
        [FieldOffset(12)]
        private readonly byte _index;

        /// <summary>
        /// The state of the button.
        /// </summary>
        public ButtonState State => _state;
        [FieldOffset(13)]
        private readonly ButtonState _state;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is JoystickButtonEventArgs args && Equals(args);
        }

        public bool Equals(JoystickButtonEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _joystickID == other._joystickID &&
                _index == other._index &&
                _state == other._state;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _joystickID, _index, _state);
        }

        public static bool operator ==(JoystickButtonEventArgs left, JoystickButtonEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(JoystickButtonEventArgs left, JoystickButtonEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
