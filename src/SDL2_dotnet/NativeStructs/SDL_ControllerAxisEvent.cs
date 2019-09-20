// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_ControllerAxisEvent
    {
        public SDL_EventType type;
        public uint timestamp;
        public int which; /* SDL_JoystickID */
        public byte axis;
        private byte padding1;
        private byte padding2;
        private byte padding3;
        public short axisValue; /* value, lolC# */
        private ushort padding4;
    }
}
