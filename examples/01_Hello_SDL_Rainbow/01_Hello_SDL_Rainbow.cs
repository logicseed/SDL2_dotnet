using SDL2_dotnet;
using System.Collections.Generic;

namespace _01_Hellow_SDL_Rainbow
{
    internal class Program
    {
        private static readonly List<Color> colors = InitColors();

        private static void Main(string[] args)
        {
            // Initializing SDL2
            using SDL2 sdl2 = new SDL2(Subsystems.Video);

            // Creating a window
            using Window window = new Window(
                "SDL2_dotnet Rainbow Test Window",
                WindowPosition.Centered,
                ScreenResolution.HD,
                WindowOptions.Shown);

            // Cycle through colors ten times
            DisplayColors(window, 10);
        }

        private static void DisplayColors(Window window, int count)
        {
            for (int i = 0; i < count; i++)
            {
                foreach (Color color in colors)
                {
                    window.Surface.Fill(color);
                    window.Update();
                    Timer.Delay(16); // ~60 FPS
                }
            }
        }

        private static List<Color> InitColors()
        {
            return new List<Color>
            {
                Color.Red,
                Color.Pink,
                Color.Purple,
                Color.DeepPurple,
                Color.Indigo,
                Color.Blue,
                Color.LightBlue,
                Color.Cyan,
                Color.Teal,
                Color.Green,
                Color.LightGreen,
                Color.Lime,
                Color.Yellow,
                Color.Amber,
                Color.Orange,
                Color.DeepOrange,
                Color.DarkRed,
                Color.DarkPink,
                Color.DarkPurple,
                Color.DarkDeepPurple,
                Color.DarkIndigo,
                Color.DarkBlue,
                Color.DarkLightBlue,
                Color.DarkCyan,
                Color.DarkTeal,
                Color.DarkGreen,
                Color.DarkLightGreen,
                Color.DarkLime,
                Color.DarkYellow,
                Color.DarkAmber,
                Color.DarkOrange,
                Color.DarkDeepOrange
            };
        }
    }
}
