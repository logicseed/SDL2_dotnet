// SPDX-License-Identifier: MIT

namespace SDL.Events
{
    public enum DisplayChange : byte
    {
        None = 0b_0000_0000,

        /// <summary>
        /// Display orientation has changed.
        /// </summary>
        Orientation = 0b_0000_0001
    }
}
