// SPDX-License-Identifier: MIT

namespace SDL
{
    /// <summary>
    /// A structure that contains the definition of a rectangle, with the origin at the upper left.
    /// </summary>
    public partial struct Rect
    {
        /// <summary>
        /// The x location of the rectangle's upper left corner.
        /// </summary>
        public int X;

        /// <summary>
        /// The y location of the rectangle's upper left corner.
        /// </summary>
        public int Y;

        /// <summary>
        /// The width of the rectangle.
        /// </summary>
        public int Width;

        /// <summary>
        /// The height of the rectangle.
        /// </summary>
        public int Height;
    }
}
