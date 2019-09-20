// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains sensor event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_SensorEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.SensorUpdate"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public EventType EventType;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp;

        /// <summary>
        /// The instance ID of the sensor.
        /// </summary>
        public int SensorID;

        /// <summary>
        /// Up to 6 values from the sensor - additional values can be queried using SDL_SensorGetData()
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.R4, SizeConst = 6)]
        public float[] Data;
    }
}
