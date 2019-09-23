// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains complex gesture event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct DollarGestureEventArgs : IEquatable<DollarGestureEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.DollarGesture"/> or <see cref="EventType.DollarRecord"/>.
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
        /// The touch device ID.
        /// </summary>
        public long TouchID => _touchID; // SDL_TouchID
        [FieldOffset(8)]
        private readonly long _touchID;

        /// <summary>
        /// The unique ID of the closest gesture to the performed stroke.
        /// </summary>
        public long GestureID => _gestureID; // SDL_GestureID
        [FieldOffset(16)]
        private readonly long _gestureID;

        /// <summary>
        /// The number of fingers used to draw the stroke.
        /// </summary>
        public uint FingerCount => _fingerCount;
        [FieldOffset(24)]
        private readonly uint _fingerCount;

        /// <summary>
        /// The difference between the gesture template and the actual performed festure (lower error is a better match).
        /// </summary>
        public float Error => _error;
        [FieldOffset(28)]
        private readonly float _error;

        /// <summary>
        /// The normalized center of the gesture.
        /// </summary>
        public float CenterX => _centerX;
        [FieldOffset(32)]
        private readonly float _centerX;

        /// <summary>
        /// The normalized center of the gesture.
        /// </summary>
        public float CenterY => _centerY;
        [FieldOffset(36)]
        private readonly float _centerY;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is DollarGestureEventArgs args && Equals(args);
        }

        public bool Equals(DollarGestureEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _touchID == other._touchID &&
                _gestureID == other._gestureID &&
                _fingerCount == other._fingerCount &&
                _error == other._error &&
                _centerX == other._centerX &&
                _centerY == other._centerY;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _touchID, _gestureID, _fingerCount, _error, _centerX, _centerY);
        }

        public static bool operator ==(DollarGestureEventArgs left, DollarGestureEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DollarGestureEventArgs left, DollarGestureEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
