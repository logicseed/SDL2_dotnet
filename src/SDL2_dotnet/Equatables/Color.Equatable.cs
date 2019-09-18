// SPDX-License-Identifier: MIT

using System;

namespace SDL2_dotnet
{
    public partial struct Color : IEquatable<Color>
    {
        public override bool Equals(object other)
        {
            return other is Color color && Equals(color);
        }

        public bool Equals(Color other)
        {
            return Red == other.Red &&
                   Green == other.Green &&
                   Blue == other.Blue &&
                   Alpha == other.Alpha;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Red, Green, Blue, Alpha);
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
