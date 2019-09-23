// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains mouse button event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct MouseButtonEventArgs : IEquatable<MouseButtonEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.MouseButtonDown"/> or <see cref="EventType.MouseButtonUp"/>.
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
        /// The button that changed.
        /// </summary>
        public MouseButton Button => _button;
        [FieldOffset(16)]
        private readonly MouseButton _button;

        /// <summary>
        /// The state of the button.
        /// </summary>
        public ButtonState State => _state;
        [FieldOffset(17)]
        private readonly ButtonState _state;

        /// <summary>
        /// 1 for single-click, 2 for double-click, etc.
        /// </summary>
        public byte ClickCount => _clickCount;
        [FieldOffset(18)]
        private readonly byte _clickCount;

        /// <summary>
        ///THe  X coordinate, relative to window.
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

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is MouseButtonEventArgs args && Equals(args);
        }

        public bool Equals(MouseButtonEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _windowID == other._windowID &&
                _mouseID == other._mouseID &&
                _button == other._button &&
                _state == other._state &&
                _clickCount == other._clickCount &&
                _x == other._x &&
                _y == other._y;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(_type);
            hash.Add(_timestamp);
            hash.Add(_windowID);
            hash.Add(_mouseID);
            hash.Add(_button);
            hash.Add(_state);
            hash.Add(_clickCount);
            hash.Add(_x);
            hash.Add(_y);
            return hash.ToHashCode();
        }

        public static bool operator ==(MouseButtonEventArgs left, MouseButtonEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(MouseButtonEventArgs left, MouseButtonEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
