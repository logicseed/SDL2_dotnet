// SPDX-License-Identifier: MIT

using System;

namespace SDL
{
    public partial struct Rect : IEquatable<Rect>
    {
        public override bool Equals(object other)
        {
            return other is Rect rect && Equals(rect);
        }

        public bool Equals(Rect other)
        {
            return X == other.X &&
                   Y == other.Y &&
                   Width == other.Width &&
                   Height == other.Height;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Width, Height);
        }

        public static bool operator ==(Rect left, Rect right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Rect left, Rect right)
        {
            return !left.Equals(right);
        }
    }
}
