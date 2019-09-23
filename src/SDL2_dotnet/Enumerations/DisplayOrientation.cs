// SPDX-License-Identifier: MIT

namespace SDL
{
    public enum DisplayOrientation
    {
        /// <summary>
        /// The display orientation can't be determined.
        /// </summary>
        Unknown = 0b_0000_0000_0000_0000_0000_0000_0000_0000,

        /// <summary>
        /// The display is in landscape mode, with the right side up, relative to portrait mode.
        /// </summary>
        Landscape = 0b_0000_0000_0000_0000_0000_0000_0000_0001,

        /// <summary>
        /// The display is in landscape mode, with the left side up, relative to portrait mode.
        /// </summary>
        LandscapeFlipped = 0b_0000_0000_0000_0000_0000_0000_0000_0010,

        /// <summary>
        /// The display is in portrait mode.
        /// </summary>
        Portrait = 0b_0000_0000_0000_0000_0000_0000_0000_0011,

        /// <summary>
        /// The display is in portrait mode, upside down.
        /// </summary>
        PortraitFlipped = 0b_0000_0000_0000_0000_0000_0000_0000_0100
    }
}
