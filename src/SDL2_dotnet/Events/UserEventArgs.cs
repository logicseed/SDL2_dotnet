// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains an application-defined event type.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct UserEventArgs : IEquatable<UserEventArgs>
    {
        /// <summary>
        /// Should be a UserEvent
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
        /// User-defined event code.
        /// </summary>
        public int Code => _code;
        [FieldOffset(12)]
        private readonly int _code;

        /// <summary>
        /// User-defined data pointer.
        /// </summary>
        public IntPtr Data1 => _data1;
        [FieldOffset(16)]
        private readonly IntPtr _data1;

        /// <summary>
        /// User-defined data pointer.
        /// </summary>
        public IntPtr Data2 => _data2;
        [FieldOffset(20)]
        private readonly IntPtr _data2;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is UserEventArgs args && Equals(args);
        }

        public bool Equals(UserEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _windowID == other._windowID &&
                _code == other._code &&
                _data1.Equals(other._data1) &&
                _data2.Equals(other._data2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _windowID, _code, _data1, _data2);
        }

        public static bool operator ==(UserEventArgs left, UserEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(UserEventArgs left, UserEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
