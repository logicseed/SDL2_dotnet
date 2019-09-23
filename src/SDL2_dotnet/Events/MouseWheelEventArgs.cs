// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains mouse wheel event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct MouseWheelEventArgs : IEquatable<MouseWheelEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.MouseWheel"/>
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
        /// The associated window.
        /// </summary>
        public uint WindowID => _windowID;
        [FieldOffset(8)]
        private readonly uint _windowID;

        /// <summary>
        /// The mouse instance ID.
        /// </summary>
        public uint MouseID => _mouseID;
        [FieldOffset(12)]
        private readonly uint _mouseID;

        /// <summary>
        /// The amount scrolled horizontally, positive to the right and negative to the left.
        /// </summary>
        public int X => _x;
        [FieldOffset(16)]
        private readonly int _x;

        /// <summary>
        /// The amount scrolled vertically, positive away from the user and negative towards the user.
        /// </summary>
        public int Y => _y;
        [FieldOffset(20)]
        private readonly int _y;

        /// <summary>
        /// Direction of the mouse wheel. When <see cref="MouseWheelDirection.Flipped"/> the values in <see cref="X"/>
        /// and <see cref="Y"/> will be opposite. Multiply by <c>-1</c> to change them back.
        /// </summary>
        public MouseWheelDirection Direction => _direction;
        [FieldOffset(24)]
        private readonly MouseWheelDirection _direction;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is MouseWheelEventArgs args && Equals(args);
        }

        public bool Equals(MouseWheelEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _windowID == other._windowID &&
                _mouseID == other._mouseID &&
                _x == other._x &&
                _y == other._y &&
                _direction == other._direction;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _windowID, _mouseID, _x, _y, _direction);
        }

        public static bool operator ==(MouseWheelEventArgs left, MouseWheelEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(MouseWheelEventArgs left, MouseWheelEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
