// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// Window state change event data.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct WindowEventArgs : IEquatable<WindowEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.Window"/>.
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
        /// The type of window state change event.
        /// </summary>
        public WindowChange Change => _change;
        [FieldOffset(12)]
        private readonly WindowChange _change;

        /// <summary>
        /// Event dependent data.
        /// </summary>
        public int Data1 => _data1;
        [FieldOffset(16)]
        private readonly int _data1;

        /// <summary>
        /// Event dependent data.
        /// </summary>
        public int Data2 => _data2;
        [FieldOffset(20)]
        private readonly int _data2;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is WindowEventArgs args && Equals(args);
        }

        public bool Equals(WindowEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _windowID == other._windowID &&
                _change == other._change &&
                _data1 == other._data1 &&
                _data2 == other._data2;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _windowID, _change, _data1, _data2);
        }

        public static bool operator ==(WindowEventArgs left, WindowEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(WindowEventArgs left, WindowEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
