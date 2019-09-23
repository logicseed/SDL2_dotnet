// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains the "quit requested" event.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct QuitEventArgs : IEquatable<QuitEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.Quit"/>
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
            return obj is QuitEventArgs args && Equals(args);
        }

        public bool Equals(QuitEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp);
        }

        public static bool operator ==(QuitEventArgs left, QuitEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(QuitEventArgs left, QuitEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
