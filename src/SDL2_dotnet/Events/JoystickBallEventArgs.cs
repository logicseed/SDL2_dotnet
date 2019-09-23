// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains joystick trackball motion event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct JoystickBallEventArgs : IEquatable<JoystickBallEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.JoystickBallMotion"/>.
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
        /// The index of the trackball that changed.
        /// </summary>
        public byte Index => _index;
        [FieldOffset(12)]
        private readonly byte _index;

        /// <summary>
        /// The relative motion in the X direction.
        /// </summary>
        public short RelativeX => _relativeX;
        [FieldOffset(16)]
        private readonly short _relativeX;

        /// <summary>
        /// The relative motion in the Y direction.
        /// </summary>
        public short RelativeY => _relativeY;
        [FieldOffset(18)]
        private readonly short _relativeY;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is JoystickBallEventArgs args && Equals(args);
        }

        public bool Equals(JoystickBallEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _joystickID == other._joystickID &&
                _index == other._index &&
                _relativeX == other._relativeX &&
                _relativeY == other._relativeY;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _joystickID, _index, _relativeX, _relativeY);
        }

        public static bool operator ==(JoystickBallEventArgs left, JoystickBallEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(JoystickBallEventArgs left, JoystickBallEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
