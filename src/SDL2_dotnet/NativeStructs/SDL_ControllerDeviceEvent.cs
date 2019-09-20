// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_ControllerDeviceEvent
    {
        public SDL_EventType type;
        public uint timestamp;
        public int which; /* joystick id for ADDED,
						 * else instance id
						 */
    }
}
