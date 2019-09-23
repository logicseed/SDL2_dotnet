// SPDX-License-Identifier: MIT

namespace SDL.Events
{
    /// <summary>
    /// The pressed state of a button.
    /// </summary>
    public enum ButtonState : byte
    {
        /// <summary>
        /// The button is not being pressed.
        /// </summary>
        Released = 0b_0000_0000,

        /// <summary>
        /// The button is being pressed.
        /// </summary>
        Pressed = 0b_0000_0001
    }
}
