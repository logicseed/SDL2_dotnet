using SDL2_dotnet;

namespace _01_Hellow_SDL
{
    internal class Program
    {
        private const int WINDOW_WIDTH = 640;
        private const int WINDOW_HEIGHT = 480;

        private static void Main(string[] args)
        {
            // Initializing SDL2
            using SDL2 sdl2 = new SDL2(Subsystems.Video);

            // Creating a window
            using Window window = new Window(
                "SDL2_dotnet Test Window",
                WindowPosition.Undefined,
                WindowPosition.Undefined,
                WINDOW_WIDTH,
                WINDOW_HEIGHT,
                WindowOptions.Shown);

            // Filling window surface with white
            window.Surface.Fill(Color.White);
            window.Update();

            // Waiting 2 seconds
            Timer.Delay(2000);
        }
    }
}
