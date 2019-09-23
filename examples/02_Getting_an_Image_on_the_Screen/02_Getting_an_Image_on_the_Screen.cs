using SDL;

namespace _02_Getting_an_Image_on_the_Screen
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

            using Surface imageSurface = Surface.LoadBMP("Hello_World.bmp");

            window.Surface.Fill(Color.White);
            window.Surface.BlitSurface(imageSurface);
            window.Update();

            Timer.Delay(2000);
        }
    }
}
