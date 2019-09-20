// SPDX-License-Identifier: MIT

namespace SDL2_dotnet
{
    public enum EventType : uint
    {
        // Application Events
        Quit = 0b_0000_0000_0000_0000_0000_0001_0000_0000,

        // Mobile Events
        ApplicationTerminating = 0b_0000_0000_0000_0000_0000_0001_0000_0001,
        ApplicationLowMemory = 0b_0000_0000_0000_0000_0000_0001_0000_0010,
        ApplicationWillEnterBackground = 0b_0000_0000_0000_0000_0000_0001_0000_0011,
        ApplicationDidEnterBackground = 0b_0000_0000_0000_0000_0000_0001_0000_0100,
        ApplicationWillEnterForeground = 0b_0000_0000_0000_0000_0000_0001_0000_0101,
        ApplicationDidEnterForeground = 0b_0000_0000_0000_0000_0000_0001_0000_0110,

        // Display Events
        Display = 0b_0000_0000_0000_0000_0000_0001_0101_0000,

        // Window Events
        Window = 0b_0000_0000_0000_0000_0000_0010_0000_0000,
        SystemWindowManager = 0b_0000_0000_0000_0000_0000_0010_0000_0001,

        // Keyboard Events
        KeyDown = 0b_0000_0000_0000_0000_0000_0011_0000_0000,
        KeyUp = 0b_0000_0000_0000_0000_0000_0011_0000_0001,
        TextEditing = 0b_0000_0000_0000_0000_0000_0011_0000_0010,
        TextInput = 0b_0000_0000_0000_0000_0000_0011_0000_0011,
        KeyMapChanged = 0b_0000_0000_0000_0000_0000_0011_0000_0100,

        // Mouse Events
        MouseMotion = 0b_0000_0000_0000_0000_0000_0100_0000_0000,
        MouseButtonDown = 0b_0000_0000_0000_0000_0000_0100_0000_0001,
        MouseButtonUp = 0b_0000_0000_0000_0000_0000_0100_0000_0010,
        MouseWheel = 0b_0000_0000_0000_0000_0000_0100_0000_0011,

        // Joystick Events
        JoystickAxisMotion = 0b_0000_0000_0000_0000_0000_0110_0000_0000,
        JoystickBallMotion = 0b_0000_0000_0000_0000_0000_0110_0000_0001,
        JoystickHatMotion = 0b_0000_0000_0000_0000_0000_0110_0000_0010,
        JoystickButtonDown = 0b_0000_0000_0000_0000_0000_0110_0000_0011,
        JoystickButtonUp = 0b_0000_0000_0000_0000_0000_0110_0000_0100,
        JoystickDeviceAdded = 0b_0000_0000_0000_0000_0000_0110_0000_0101,
        JoystickDeviceRemoved = 0b_0000_0000_0000_0000_0000_0110_0000_0110,

        // Game Controller Events
        ControllerAxisMotion = 0b_0000_0000_0000_0000_0000_0110_0101_0000,
        ControllerButtonDown = 0b_0000_0000_0000_0000_0000_0110_0101_0001,
        ControllerButtonUp = 0b_0000_0000_0000_0000_0000_0110_0101_0010,
        ControllerDeviceAdded = 0b_0000_0000_0000_0000_0000_0110_0101_0011,
        ControllerDeviceRemoved = 0b_0000_0000_0000_0000_0000_0110_0101_0100,
        ControllerDeviceRemapped = 0b_0000_0000_0000_0000_0000_0110_0101_0101,

        // Touch Events
        FingerDown = 0b_0000_0000_0000_0000_0000_0111_0000_0000,
        FingerUp = 0b_0000_0000_0000_0000_0000_0111_0000_0001,
        FingerMotion = 0b_0000_0000_0000_0000_0000_0111_0000_0010,

        // Gesture Events
        DollarGesture = 0b_0000_0000_0000_0000_0000_1000_0000_0000,
        DollarRecord = 0b_0000_0000_0000_0000_0000_1000_0000_0001,
        MultiGesture = 0b_0000_0000_0000_0000_0000_1000_0000_0010,

        // Clipboard Events
        ClipboardUpdate = 0b_0000_0000_0000_0000_0000_1001_0000_0000,

        // Drag and Drop Events
        DropFile = 0b_0000_0000_0000_0000_0001_0000_0000_0000,
        DropText = 0b_0000_0000_0000_0000_0001_0000_0000_0001,
        DropBegin = 0b_0000_0000_0000_0000_0001_0000_0000_0010,
        DropComplete = 0b_0000_0000_0000_0000_0001_0000_0000_0011,

        // Audio Events
        AudioDeviceAdded = 0b_0000_0000_0000_0000_0001_0001_0000_0000,
        AudioDeviceRemoved = 0b_0000_0000_0000_0000_0001_0001_0000_0001,

        // Sensor Events
        SensorUpdate = 0b_0000_0000_0000_0000_0001_0010_0000_0000,

        // Render Events
        RenderTargetsRest = 0b_0000_0000_0000_0000_0010_0000_0000_0000,
        RenderDeviceReset = 0b_0000_0000_0000_0000_0010_0000_0000_0001,

        // User Events
        // Events UserEvent through LastEvent are for users, allocate with SDL_RegisterEvents()
        UserEvent = 0b_0000_0000_0000_0000_1000_0000_0000_0000,
        LastEvent = 0b_0000_0000_0000_0000_1111_1111_1111_1111
    }
}
