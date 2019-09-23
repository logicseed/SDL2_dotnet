// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains mouse motion event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct MouseMotionEventArgs : IEquatable<MouseMotionEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.MouseMotion"/>.
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
        /// The state of the button.
        /// </summary>
        public MouseButton Button => _button;
        [FieldOffset(16)]
        private readonly MouseButton _button;

        /// <summary>
        ///The X coordinate, relative to window.
        /// </summary>
        public int X => _x;
        [FieldOffset(20)]
        private readonly int _x;

        /// <summary>
        /// The Y coordinate, relative to window.
        /// </summary>
        public int Y => _y;
        [FieldOffset(24)]
        private readonly int _y;

        /// <summary>
        /// The relative motion in the X direction.
        /// </summary>
        public int RelativeX => _relativeX;
        [FieldOffset(28)]
        private readonly int _relativeX;

        /// <summary>
        /// The relative motion in the Y direction.
        /// </summary>
        public int RelativeY => _relativeY;
        [FieldOffset(32)]
        private readonly int _relativeY;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is MouseMotionEventArgs args && Equals(args);
        }

        public bool Equals(MouseMotionEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _windowID == other._windowID &&
                _mouseID == other._mouseID &&
                _button == other._button &&
                _x == other._x &&
                _y == other._y &&
                _relativeX == other._relativeX &&
                _relativeY == other._relativeY;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(_type);
            hash.Add(_timestamp);
            hash.Add(_windowID);
            hash.Add(_mouseID);
            hash.Add(_button);
            hash.Add(_x);
            hash.Add(_y);
            hash.Add(_relativeX);
            hash.Add(_relativeY);
            return hash.ToHashCode();
        }

        public static bool operator ==(MouseMotionEventArgs left, MouseMotionEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(MouseMotionEventArgs left, MouseMotionEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
