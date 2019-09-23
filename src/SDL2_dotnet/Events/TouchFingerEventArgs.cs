// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains finger touch event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct TouchFingerEventArgs : IEquatable<TouchFingerEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.FingerDown"/>, <see cref="EventType.FingerUp"/>, or
        /// <see cref="EventType.FingerMotion"/>
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
        /// The touch device id.
        /// </summary>
        public long TouchID => _touchID; // SDL_TouchID
        [FieldOffset(8)]
        private readonly long _touchID;

        /// <summary>
        /// The finger id.
        /// </summary>
        public long FingerID => _fingerID; // SDL_GestureID
        [FieldOffset(16)]
        private readonly long _fingerID;

        /// <summary>
        /// Normalized in the range 0...1
        /// </summary>
        public float X => _x;
        [FieldOffset(24)]
        private readonly float _x;

        /// <summary>
        /// Normalized in the range 0...1
        /// </summary>
        public float Y => _y;
        [FieldOffset(28)]
        private readonly float _y;

        /// <summary>
        /// Normalized in the range -1...1
        /// </summary>
        public float DeltaX => _deltaX;
        [FieldOffset(32)]
        private readonly float _deltaX;

        /// <summary>
        /// Normalized in the range -1...1
        /// </summary>
        public float DeltaY => _deltaY;
        [FieldOffset(36)]
        private readonly float _deltaY;

        /// <summary>
        /// Normalized in the range 0...1
        /// </summary>
        public float Pressure => _pressure;
        [FieldOffset(40)]
        private readonly float _pressure;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is TouchFingerEventArgs args && Equals(args);
        }

        public bool Equals(TouchFingerEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _touchID == other._touchID &&
                _fingerID == other._fingerID &&
                _x == other._x &&
                _y == other._y &&
                _deltaX == other._deltaX &&
                _deltaY == other._deltaY &&
                _pressure == other._pressure;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(_type);
            hash.Add(_timestamp);
            hash.Add(_touchID);
            hash.Add(_fingerID);
            hash.Add(_x);
            hash.Add(_y);
            hash.Add(_deltaX);
            hash.Add(_deltaY);
            hash.Add(_pressure);
            return hash.ToHashCode();
        }

        public static bool operator ==(TouchFingerEventArgs left, TouchFingerEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TouchFingerEventArgs left, TouchFingerEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
