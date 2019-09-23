// SPDX-License-Identifier: MIT

using System;

namespace SDL
{
    public partial struct Color : IEquatable<Color>
    {
        public override bool Equals(object other)
        {
            return other is Color color && Equals(color);
        }

        public bool Equals(Color other)
        {
            return R == other.R &&
                   G == other.G &&
                   B == other.B &&
                   A == other.A;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(R, G, B, A);
        }

        public static bool operator ==(Color left, Color right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Color left, Color right)
        {
            return !left.Equals(right);
        }
    }
}
