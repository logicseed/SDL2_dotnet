// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains keyboard button event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct KeyboardEventArgs : IEquatable<KeyboardEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.KeyDown"/> or <see cref="EventType.KeyUp"/>.
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
        /// The state of the key.
        /// </summary>
        public ButtonState State => _state;
        [FieldOffset(12)]
        private readonly ButtonState _state;

        /// <summary>
        /// Non-zero if this is a key repeat.
        /// </summary>
        public byte Repeat => _repeat;
        [FieldOffset(13)]
        private readonly byte _repeat;

        /// <summary>
        /// The SDL_Keysym representing the key that was pressed or released.
        /// </summary>
        public KeyInfo KeyInfo => _keyInfo;
        [FieldOffset(16)]
        private readonly KeyInfo _keyInfo;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is KeyboardEventArgs args && Equals(args);
        }

        public bool Equals(KeyboardEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _windowID == other._windowID &&
                _state == other._state &&
                _repeat == other._repeat &&
                _keyInfo.Equals(other._keyInfo);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _windowID, _state, _repeat, _keyInfo);
        }

        public static bool operator ==(KeyboardEventArgs left, KeyboardEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(KeyboardEventArgs left, KeyboardEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
