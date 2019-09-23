// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains controller device event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct ControllerDeviceEventArgs : IEquatable<ControllerDeviceEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.ControllerDeviceAdded"/>, <see cref="EventType.ControllerDeviceRemoved"/>,
        /// or <see cref="EventType.ControllerDeviceRemapped"/>.
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
        /// The controller device index for the <see cref="EventType.ControllerDeviceAdded"/> event, or the instance ID
        /// for the <see cref="EventType.ControllerDeviceRemoved"/> or <see cref="EventType.ControllerDeviceRemapped"/>
        /// event.
        /// </summary>
        public int ControllerID => _controllerID;
        [FieldOffset(8)]
        private readonly int _controllerID;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is ControllerDeviceEventArgs args && Equals(args);
        }

        public bool Equals(ControllerDeviceEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _controllerID == other._controllerID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _controllerID);
        }

        public static bool operator ==(ControllerDeviceEventArgs left, ControllerDeviceEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ControllerDeviceEventArgs left, ControllerDeviceEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
