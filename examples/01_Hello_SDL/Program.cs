using SDL2_dotnet;
using System;
using System.Threading;

namespace _01_OpenWindow
{
    class Program
    {
        private const int WINDOW_WIDTH = 640;
        private const int WINDOW_HEIGHT = 480;

        static void Main(string[] args)
        {
            Console.WriteLine("Initializing SDL2...");

            using var sdl2 = new SDL2(Subsystems.Video);

            Console.WriteLine("Creating window...");

            using var window = new Window(
                "SDL2_dotnet Test Window",
                WindowPosition.Centered,
                WindowPosition.Centered,
                WINDOW_WIDTH,
                WINDOW_HEIGHT,
                WindowOptions.Shown);

            Console.WriteLine("Fill the surface orange...");
            var color = new Color(255, 152, 0);
            window.Surface.FillRect(color);
            window.UpdateWindowSurface();

            Console.WriteLine("Waiting for 5 seconds...");

            Thread.Sleep(5000);
        }
    }
}
