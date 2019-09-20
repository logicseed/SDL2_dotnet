// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_DisplayEvent
    {
        public SDL_EventType type;
        public uint timestamp;
        public uint display;
        public SDL_DisplayEventID displayEvent; // event, lolC#
        private byte padding1;
        private byte padding2;
        private byte padding3;
        public int data1;
    }
}
