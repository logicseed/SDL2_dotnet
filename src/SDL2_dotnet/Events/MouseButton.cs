// SPDX-License-Identifier: MIT

using System;

namespace SDL.Events
{
    [Flags]
    public enum MouseButton : byte
    {
        Left = 0b_0000_0001,
        Middle = 0b_0000_0010,
        Right = 0b_0000_0100,
        X1 = 0b_0000_1000,
        X2 = 0b_0001_0000
    }
}
