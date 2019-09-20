// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_DollarGestureEvent
    {
        public uint type;
        public uint timestamp;
        public long touchId; // SDL_TouchID
        public long gestureId; // SDL_GestureID
        public uint numFingers;
        public float error;
        public float x;
        public float y;
    }
}
