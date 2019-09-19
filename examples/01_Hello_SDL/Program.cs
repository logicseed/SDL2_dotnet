using SDL2_dotnet;

namespace _01_OpenWindow
{
    class Program
    {
        private const int WINDOW_WIDTH = 640;
        private const int WINDOW_HEIGHT = 480;

        static void Main(string[] args)
        {
            // Initializing SDL2
            using var sdl2 = new SDL2(Subsystems.Video);

            // Creating a window
            using var window = new Window(
                "SDL2_dotnet Test Window",
                WindowPosition.Centered,
                WindowPosition.Centered,
                WINDOW_WIDTH,
                WINDOW_HEIGHT,
                WindowOptions.Shown);

            // Filling window surface with orange
            var color = new Color(255, 152, 0);
            window.Surface.FillRect(color);
            window.UpdateWindowSurface();

            // Waiting 2 seconds
            Timer.Delay(2000);
        }
    }
}
