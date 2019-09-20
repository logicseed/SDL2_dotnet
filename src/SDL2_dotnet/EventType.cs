// SPDX-License-Identifier: MIT

namespace SDL2_dotnet
{
    public enum EventType : uint
    {
        SDL_FIRSTEVENT = 0b_0000_0000_0000_0000_0000_0000_0000_0000,

        /* Application events */
        SDL_QUIT = 0b_0000_0000_0000_0000_0000_0001_0000_0000, //0x100,

        /* iOS/Android/WinRT app events */
        SDL_APP_TERMINATING = 0b_0000_0000_0000_0000_0000_0001_0000_0001, //,
        SDL_APP_LOWMEMORY = 0b_0000_0000_0000_0000_0000_0001_0000_0010,
        SDL_APP_WILLENTERBACKGROUND = 0b_0000_0000_0000_0000_0000_0001_0000_0011,
        SDL_APP_DIDENTERBACKGROUND = 0b_0000_0000_0000_0000_0000_0001_0000_0100,
        SDL_APP_WILLENTERFOREGROUND = 0b_0000_0000_0000_0000_0000_0001_0000_0101,
        SDL_APP_DIDENTERFOREGROUND = 0b_0000_0000_0000_0000_0000_0001_0000_0110,

        /* Display events */
        /* Only available in SDL 2.0.9 or higher */
        SDL_DISPLAYEVENT = 0b_0000_0000_0000_0000_0000_0001_0101_0000,

        /* Window events */
        SDL_WINDOWEVENT = 0b_0000_0000_0000_0000_0000_0010_0000_0000,
        SDL_SYSWMEVENT = 0b_0000_0000_0000_0000_0000_0010_0000_0001,

        /* Keyboard events */
        SDL_KEYDOWN = 0x300,
        SDL_KEYUP,
        SDL_TEXTEDITING,
        SDL_TEXTINPUT,
        SDL_KEYMAPCHANGED,

        /* Mouse events */
        SDL_MOUSEMOTION = 0x400,
        SDL_MOUSEBUTTONDOWN,
        SDL_MOUSEBUTTONUP,
        SDL_MOUSEWHEEL,

        /* Joystick events */
        SDL_JOYAXISMOTION = 0x600,
        SDL_JOYBALLMOTION,
        SDL_JOYHATMOTION,
        SDL_JOYBUTTONDOWN,
        SDL_JOYBUTTONUP,
        SDL_JOYDEVICEADDED,
        SDL_JOYDEVICEREMOVED,

        /* Game controller events */
        SDL_CONTROLLERAXISMOTION = 0x650,
        SDL_CONTROLLERBUTTONDOWN,
        SDL_CONTROLLERBUTTONUP,
        SDL_CONTROLLERDEVICEADDED,
        SDL_CONTROLLERDEVICEREMOVED,
        SDL_CONTROLLERDEVICEREMAPPED,

        /* Touch events */
        SDL_FINGERDOWN = 0x700,
        SDL_FINGERUP,
        SDL_FINGERMOTION,

        /* Gesture events */
        SDL_DOLLARGESTURE = 0x800,
        SDL_DOLLARRECORD,
        SDL_MULTIGESTURE,

        /* Clipboard events */
        SDL_CLIPBOARDUPDATE = 0x900,

        /* Drag and drop events */
        SDL_DROPFILE = 0x1000,
        /* Only available in 2.0.4 or higher */
        SDL_DROPTEXT,
        SDL_DROPBEGIN,
        SDL_DROPCOMPLETE,

        /* Audio hotplug events */
        /* Only available in SDL 2.0.4 or higher */
        SDL_AUDIODEVICEADDED = 0x1100,
        SDL_AUDIODEVICEREMOVED,

        /* Sensor events */
        /* Only available in SDL 2.0.9 or higher */
        SDL_SENSORUPDATE = 0x1200,

        /* Render events */
        /* Only available in SDL 2.0.2 or higher */
        SDL_RENDER_TARGETS_RESET = 0x2000,
        /* Only available in SDL 2.0.4 or higher */
        SDL_RENDER_DEVICE_RESET,

        /* Events SDL_USEREVENT through SDL_LASTEVENT are for
         * your use, and should be allocated with
         * SDL_RegisterEvents()
         */
        SDL_USEREVENT = 0x8000,

        /* The last event, used for bouding arrays. */
        SDL_LASTEVENT = 0xFFFF
    }
}
