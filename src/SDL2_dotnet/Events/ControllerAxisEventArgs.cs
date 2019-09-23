// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains game controller axis motion event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct ControllerAxisEventArgs : IEquatable<ControllerAxisEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.ControllerAxisMotion"/>.
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
        /// The controller instance ID.
        /// </summary>
        public int ControllerID => _controllerID; // SDL_JoystickID
        [FieldOffset(8)]
        private readonly int _controllerID;

        /// <summary>
        /// The controller axis.
        /// </summary>
        public GameControllerAxis Axis => _axis;
        [FieldOffset(12)]
        private readonly GameControllerAxis _axis;

        /// <summary>
        /// The axis value (range: -32768 to 32767).
        /// </summary>
        public short Value => _value;
        [FieldOffset(16)]
        private readonly short _value;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is ControllerAxisEventArgs args && Equals(args);
        }

        public bool Equals(ControllerAxisEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _controllerID == other._controllerID &&
                _axis == other._axis &&
                _value == other._value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _controllerID, _axis, _value);
        }

        public static bool operator ==(ControllerAxisEventArgs left, ControllerAxisEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ControllerAxisEventArgs left, ControllerAxisEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
