// SPDX-License-Identifier: MIT

namespace SDL
{
    public enum GameControllerAxis : byte
    {
        LeftStickX = 0b_0000_0000,
        LeftStickY = 0b_0000_0001,
        RightStickX = 0b_0000_0010,
        RightStickY = 0b_0000_0011,
        LeftTrigger = 0b_0000_0100,
        RightTrigger = 0b_0000_0101
    }
}
