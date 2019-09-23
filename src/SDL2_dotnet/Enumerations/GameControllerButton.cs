// SPDX-License-Identifier: MIT

namespace SDL
{
    public enum GameControllerButton : byte
    {
        A = 0b_0000_0000,
        B = 0b_0000_0001,
        X = 0b_0000_0010,
        Y = 0b_0000_0011,
        Back = 0b_0000_0100,
        Guide = 0b_0000_0101,
        Start = 0b_0000_0110,
        LeftStick = 0b_0000_0111,
        RightStick = 0b_0000_1000,
        LeftShoulder = 0b_0000_1001,
        RightShoulder = 0b_0000_1010,
        Up = 0b_0000_1011,
        Down = 0b_0000_1100,
        Left = 0b_0000_1101,
        Right = 0b_0000_1110
    }
}
