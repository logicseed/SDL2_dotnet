// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains an event used to request a file open by the system.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct DropEventArgs : IEquatable<DropEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.DropFile"/>, <see cref="EventType.DropText"/>,
        /// <see cref="EventType.DropBegin"/>, or <see cref="EventType.DropComplete"/>.
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
        /// The file name, which should be freed with SDL_free(), is NULL on begin/complete.
        /// </summary>
        public string File => Marshal.PtrToStringAnsi(_file);
        [FieldOffset(8)]
        private readonly IntPtr _file;

        /// <summary>
        /// The associated window.
        /// </summary>
        public uint WindowID => _windowID;
        [FieldOffset(12)]
        private readonly uint _windowID;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is DropEventArgs args && Equals(args);
        }

        public bool Equals(DropEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _file.Equals(other._file) &&
                _windowID == other._windowID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _file, _windowID);
        }

        public static bool operator ==(DropEventArgs left, DropEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DropEventArgs left, DropEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
