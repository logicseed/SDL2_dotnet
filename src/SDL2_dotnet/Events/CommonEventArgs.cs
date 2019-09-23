// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// Fields shared by every event.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct CommonEventArgs : IEquatable<CommonEventArgs>
    {
        /// <summary>
        /// The type of event.
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

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is CommonEventArgs args && Equals(args);
        }

        public bool Equals(CommonEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp);
        }

        public static bool operator ==(CommonEventArgs left, CommonEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CommonEventArgs left, CommonEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
