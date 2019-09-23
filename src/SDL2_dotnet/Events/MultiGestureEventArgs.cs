// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains multiple finger gesture event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct MultiGestureEventArgs : IEquatable<MultiGestureEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.MultiGesture"/>
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
        /// The amount that the fingers rotated during this motion.
        /// </summary>
        public float Rotation => _rotation;
        [FieldOffset(16)]
        private readonly float _rotation;

        /// <summary>
        /// The amount that the fingers pinched during this motion
        /// </summary>
        public float Pinch => _pinch;
        [FieldOffset(20)]
        private readonly float _pinch;

        /// <summary>
        /// The normalized center of the gesture.
        /// </summary>
        public float CenterX => _centerX;
        [FieldOffset(24)]
        private readonly float _centerX;

        /// <summary>
        /// The normalized center of the gesture.
        /// </summary>
        public float CenterY => _centerY;
        [FieldOffset(28)]
        private readonly float _centerY;

        /// <summary>
        /// The number of fingers used in the gesture.
        /// </summary>
        public ushort FingerCount => _fingerCount;
        [FieldOffset(32)]
        private readonly ushort _fingerCount;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is MultiGestureEventArgs args && Equals(args);
        }

        public bool Equals(MultiGestureEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _touchID == other._touchID &&
                _rotation == other._rotation &&
                _pinch == other._pinch &&
                _centerX == other._centerX &&
                _centerY == other._centerY &&
                _fingerCount == other._fingerCount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _touchID, _rotation, _pinch, _centerX, _centerY, _fingerCount);
        }

        public static bool operator ==(MultiGestureEventArgs left, MultiGestureEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(MultiGestureEventArgs left, MultiGestureEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
