// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains a video driver dependent system event.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct SystemWindowManagerEventArgs : IEquatable<SystemWindowManagerEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.SystemWindowManager"/>
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
        /// Driver dependent data.
        /// </summary>
        public IntPtr Data => _data; // SDL_SysWMmsg*
        [FieldOffset(8)]
        private readonly IntPtr _data;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is SystemWindowManagerEventArgs args && Equals(args);
        }

        public bool Equals(SystemWindowManagerEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _data.Equals(other._data);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _data);
        }

        public static bool operator ==(SystemWindowManagerEventArgs left, SystemWindowManagerEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(SystemWindowManagerEventArgs left, SystemWindowManagerEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
