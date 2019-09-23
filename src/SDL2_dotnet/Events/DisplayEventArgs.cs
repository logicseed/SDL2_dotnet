// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains display event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct DisplayEventArgs : IEquatable<DisplayEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.Display"/>.
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
        /// The associated display index.
        /// </summary>
        public uint Index => _index;
        [FieldOffset(8)]
        private readonly uint _index;

        /// <summary>
        /// The display event type.
        /// </summary>
        public DisplayChange Change => _change;
        [FieldOffset(12)]
        private readonly DisplayChange _change;

        /// <summary>
        /// Event dependent data.
        /// </summary>
        public int Data => _data;
        [FieldOffset(16)]
        private readonly int _data;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is DisplayEventArgs args && Equals(args);
        }

        public bool Equals(DisplayEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _index == other._index &&
                _change == other._change &&
                _data == other._data;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _index, _change, _data);
        }

        public static bool operator ==(DisplayEventArgs left, DisplayEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DisplayEventArgs left, DisplayEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
