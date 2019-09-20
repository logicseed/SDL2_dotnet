// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains multiple finger gesture event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_MultiGestureEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.MultiGesture"/>
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public EventType EventType;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp;

        /// <summary>
        /// The touch device ID.
        /// </summary>
        public long TouchID; // SDL_TouchID

        /// <summary>
        /// The amount that the fingers rotated during this motion.
        /// </summary>
        public float Rotation;

        /// <summary>
        /// The amount that the fingers pinched during this motion
        /// </summary>
        public float Pinch;

        /// <summary>
        /// The normalized center of the gesture.
        /// </summary>
        public float CenterX;

        /// <summary>
        /// The normalized center of the gesture.
        /// </summary>
        public float CenterY;

        /// <summary>
        /// The number of fingers used in the gesture.
        /// </summary>
        public ushort FingerCount;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private ushort padding;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier
    }
}
