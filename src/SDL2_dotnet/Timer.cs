// SPDX-License-Identifier: MIT

namespace SDL2_dotnet
{
    public static partial class Timer
    {
        public static void Delay(uint milliseconds)
        {
            SDL_Delay(milliseconds);
        }
    }
}
