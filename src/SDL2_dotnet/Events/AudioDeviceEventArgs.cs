// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains Audio device event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct AudioDeviceEventArgs : IEquatable<AudioDeviceEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.AudioDeviceAdded"/> or <see cref="EventType.AudioDeviceRemoved"/>.
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
        /// The audio device index for the <see cref="EventType.AudioDeviceAdded"/> event, or the audio device ID for
        /// the <see cref="EventType.AudioDeviceRemoved"/> event.
        /// </summary>
        public uint DeviceID => _deviceID;
        [FieldOffset(8)]
        private readonly uint _deviceID;

        /// <summary>
        /// True if an audio capture device; otherwise false if an audio output device.
        /// </summary>
        public bool IsCapture => _isCapture != 0;
        [FieldOffset(12)]
        private readonly byte _isCapture;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is AudioDeviceEventArgs args && Equals(args);
        }

        public bool Equals(AudioDeviceEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _deviceID == other._deviceID &&
                _isCapture == other._isCapture;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _timestamp, _deviceID, _isCapture);
        }

        public static bool operator ==(AudioDeviceEventArgs left, AudioDeviceEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(AudioDeviceEventArgs left, AudioDeviceEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
