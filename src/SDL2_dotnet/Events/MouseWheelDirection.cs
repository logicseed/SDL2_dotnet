// SPDX-License-Identifier: MIT

namespace SDL
{
    /// <summary>
    /// Scroll direction types for the mouse wheel event.
    /// </summary>
    public enum MouseWheelDirection : byte
    {
        /// <summary>
        /// The scroll direction is normal.
        /// </summary>
        Normal = 0b_0000_0000,

        /// <summary>
        /// The scroll direction is flipped / natural.
        /// </summary>
        Flipped = 0b_0000_0001
    }
}
