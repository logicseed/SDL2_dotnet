// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_AudioDeviceEvent
    {
        public uint type;
        public uint timestamp;
        public uint which;
        public byte iscapture;
        private byte padding1;
        private byte padding2;
        private byte padding3;
    }
}
