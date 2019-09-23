// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains game controller button event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct ControllerButtonEventArgs : IEquatable<ControllerButtonEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.ControllerButtonDown"/> or <see cref="EventType.ControllerButtonUp"/>.
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
        /// The controller button.
        /// </summary>
        public GameControllerButton Button => _button;
        [FieldOffset(12)]
        private readonly GameControllerButton _button;

        /// <summary>
        /// The button state.
        /// </summary>
        public ButtonState State => _state;
        [FieldOffset(13)]
        private readonly ButtonState _state;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is ControllerButtonEventArgs args && Equals(args);
        }

        public bool Equals(ControllerButtonEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _controllerID == other._controllerID &&
                _button == other._button &&
                _state == other._state;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _controllerID, _button, _state);
        }

        public static bool operator ==(ControllerButtonEventArgs left, ControllerButtonEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ControllerButtonEventArgs left, ControllerButtonEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
