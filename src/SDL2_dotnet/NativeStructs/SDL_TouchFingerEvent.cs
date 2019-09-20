// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains finger touch event information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_TouchFingerEvent
    {
        /// <summary>
        /// Should be <see cref="EventType.FingerDown"/>, <see cref="EventType.FingerUp"/>, or
        /// <see cref="EventType.FingerMotion"/>
        /// </summary>
        public EventType EventType;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp;

        /// <summary>
        /// The touch device id.
        /// </summary>
        public long TouchID; // SDL_TouchID

        /// <summary>
        /// The finger id.
        /// </summary>
        public long FingerID; // SDL_GestureID

        /// <summary>
        /// Normalized in the range 0...1
        /// </summary>
        public float X;

        /// <summary>
        /// Normalized in the range 0...1
        /// </summary>
        public float Y;

        /// <summary>
        /// Normalized in the range -1...1
        /// </summary>
        public float DeltaX;

        /// <summary>
        /// Normalized in the range -1...1
        /// </summary>
        public float DeltaY;

        /// <summary>
        /// Normalized in the range 0...1
        /// </summary>
        public float Pressure;
    }
}
