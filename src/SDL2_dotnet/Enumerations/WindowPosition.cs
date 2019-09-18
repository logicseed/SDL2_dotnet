// SPDX-License-Identifier: MIT

namespace SDL2_dotnet
{
    /// <summary>
    /// System-based window positions.
    /// </summary>
    public enum WindowPosition
    {
        /// <summary>
        /// Window position is handled by operating system.
        /// </summary>
        Undefined = 0b_0001_1111_1111_1111_0000_0000_0000_0000,

        /// <summary>
        /// Window is centered on the screen.
        /// </summary>
        Centered = 0b_0010_1111_1111_1111_0000_0000_0000_0000
    }
}
