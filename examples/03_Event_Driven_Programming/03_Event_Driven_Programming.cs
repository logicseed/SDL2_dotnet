using SDL;
using SDL.Events;
using System.Collections.Generic;

namespace _03_Event_Driven_Programming
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using SDL.SDL2 sdl2 = new SDL.SDL2(Subsystems.Video);

            using Window window = new Window(
                "SDL2_dotnet Example",
                WindowPosition.Undefined,
                ScreenResolution.VGA,
                WindowOptions.Shown);

            bool quit = false;

            // While application is running
            while (!quit)
            {
                while (Event.Next)
                {
                    if (Event.Type == EventType.Quit)
                    {
                        quit = true;
                    }
                }

                window.Surface.Fill(NextColor());
                window.Update();

            }

            Timer.Delay(2000);
        }

        private static Color NextColor()
        {
            int curIndex = colorIndex;

            colorIndex++;
            if (colorIndex >= colors.Count)
            {
                colorIndex = 0;
            }

            return colors[curIndex];
        }

        private static int colorIndex = 0;
        private static readonly List<Color> colors = new List<Color>
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
                Color.DeepOrange
            };
    }
}
