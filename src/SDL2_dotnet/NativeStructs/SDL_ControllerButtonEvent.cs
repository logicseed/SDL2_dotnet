// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_ControllerButtonEvent
    {
        public SDL_EventType type;
        public uint timestamp;
        public int which; /* SDL_JoystickID */
        public byte button;
        public byte state;
        private byte padding1;
        private byte padding2;
    }
}
