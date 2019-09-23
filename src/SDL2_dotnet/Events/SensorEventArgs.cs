// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains sensor event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct SensorEventArgs : IEquatable<SensorEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.SensorUpdate"/>.
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
        /// The instance ID of the sensor.
        /// </summary>
        public int SensorID => _sensorID;
        [FieldOffset(8)]
        private readonly int _sensorID;

        /// <summary>
        /// Up to 6 values from the sensor - additional values can be queried using SDL_SensorGetData()
        /// </summary>
        public float[] Data
        {
            get
            {
                float[] data = new float[6];
                data[0] = data1;
                data[1] = data2;
                data[2] = data3;
                data[3] = data4;
                data[4] = data5;
                data[5] = data6;
                return data;
            }
        }

        [FieldOffset(12)]
        private readonly float data1;
        [FieldOffset(16)]
        private readonly float data2;
        [FieldOffset(20)]
        private readonly float data3;
        [FieldOffset(24)]
        private readonly float data4;
        [FieldOffset(28)]
        private readonly float data5;
        [FieldOffset(32)]
        private readonly float data6;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is SensorEventArgs args && Equals(args);
        }

        public bool Equals(SensorEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _sensorID == other._sensorID &&
                data1 == other.data1 &&
                data2 == other.data2 &&
                data3 == other.data3 &&
                data4 == other.data4 &&
                data5 == other.data5 &&
                data6 == other.data6;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(_type);
            hash.Add(_timestamp);
            hash.Add(_sensorID);
            hash.Add(data1);
            hash.Add(data2);
            hash.Add(data3);
            hash.Add(data4);
            hash.Add(data5);
            hash.Add(data6);
            return hash.ToHashCode();
        }

        public static bool operator ==(SensorEventArgs left, SensorEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(SensorEventArgs left, SensorEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
