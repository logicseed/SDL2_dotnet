// SPDX-License-Identifier: MIT

namespace SDL
{
    /// <summary>
    /// The types of events that can be delivered. (uint)
    /// </summary>
    public enum EventType : uint
    {
        None = 0b_0000_0000_0000_0000_0000_0000_0000_0000,

        #region Application Events

        /// <summary>
        /// User-requested quit.
        /// </summary>
        Quit = 0b_0000_0000_0000_0000_0000_0001_0000_0000,

        #endregion Application Events

        #region Mobile Events

        /// <summary>
        /// The application is being terminated by the OS.
        /// </summary>
        ApplicationTerminating = 0b_0000_0000_0000_0000_0000_0001_0000_0001,

        /// <summary>
        /// The application is low on memory, free memory if possible.
        /// </summary>
        ApplicationLowMemory = 0b_0000_0000_0000_0000_0000_0001_0000_0010,

        /// <summary>
        /// The application is about to enter the background.
        /// </summary>
        ApplicationWillEnterBackground = 0b_0000_0000_0000_0000_0000_0001_0000_0011,

        /// <summary>
        /// The application did enter the background and may not get CPU for some time.
        /// </summary>
        ApplicationDidEnterBackground = 0b_0000_0000_0000_0000_0000_0001_0000_0100,

        /// <summary>
        /// The application is about to enter the foreground.
        /// </summary>
        ApplicationWillEnterForeground = 0b_0000_0000_0000_0000_0000_0001_0000_0101,

        /// <summary>
        /// The application is now interactive.
        /// </summary>
        ApplicationDidEnterForeground = 0b_0000_0000_0000_0000_0000_0001_0000_0110,

        #endregion Mobile Events

        #region Display Events

        /// <summary>
        /// Display state change.
        /// </summary>
        Display = 0b_0000_0000_0000_0000_0000_0001_0101_0000,

        #endregion Display Events

        #region Window Events

        /// <summary>
        /// Window state change.
        /// </summary>
        Window = 0b_0000_0000_0000_0000_0000_0010_0000_0000,

        /// <summary>
        /// System specific event.
        /// </summary>
        SystemWindowManager = 0b_0000_0000_0000_0000_0000_0010_0000_0001,

        #endregion Window Events

        #region Keyboard Events

        /// <summary>
        /// Key pressed.
        /// </summary>
        KeyDown = 0b_0000_0000_0000_0000_0000_0011_0000_0000,

        /// <summary>
        /// Key released.
        /// </summary>
        KeyUp = 0b_0000_0000_0000_0000_0000_0011_0000_0001,

        /// <summary>
        /// Keyboard text editing (composition).
        /// </summary>
        TextEditing = 0b_0000_0000_0000_0000_0000_0011_0000_0010,

        /// <summary>
        /// Keyboard text input.
        /// </summary>
        TextInput = 0b_0000_0000_0000_0000_0000_0011_0000_0011,

        /// <summary>
        /// Keymap changed due to a system event such as an input language or keyboard layout change.
        /// </summary>
        KeyMapChanged = 0b_0000_0000_0000_0000_0000_0011_0000_0100,

        #endregion Keyboard Events

        #region Mouse Events

        /// <summary>
        /// Mouse moved.
        /// </summary>
        MouseMotion = 0b_0000_0000_0000_0000_0000_0100_0000_0000,

        /// <summary>
        /// Mouse button pressed.
        /// </summary>
        MouseButtonDown = 0b_0000_0000_0000_0000_0000_0100_0000_0001,

        /// <summary>
        /// Mouse button released.
        /// </summary>
        MouseButtonUp = 0b_0000_0000_0000_0000_0000_0100_0000_0010,

        /// <summary>
        /// Mouse wheel motion.
        /// </summary>
        MouseWheel = 0b_0000_0000_0000_0000_0000_0100_0000_0011,

        #endregion Mouse Events

        #region Joystick Events

        /// <summary>
        /// Joystick axis motion.
        /// </summary>
        JoystickAxisMotion = 0b_0000_0000_0000_0000_0000_0110_0000_0000,

        /// <summary>
        /// Joystick trackball motion.
        /// </summary>
        JoystickBallMotion = 0b_0000_0000_0000_0000_0000_0110_0000_0001,

        /// <summary>
        /// Joystick hat position change.
        /// </summary>
        JoystickHatMotion = 0b_0000_0000_0000_0000_0000_0110_0000_0010,

        /// <summary>
        /// Joystick button pressed.
        /// </summary>
        JoystickButtonDown = 0b_0000_0000_0000_0000_0000_0110_0000_0011,

        /// <summary>
        /// Joystick button released.
        /// </summary>
        JoystickButtonUp = 0b_0000_0000_0000_0000_0000_0110_0000_0100,

        /// <summary>
        /// A new joystick has been inserted into the system.
        /// </summary>
        JoystickDeviceAdded = 0b_0000_0000_0000_0000_0000_0110_0000_0101,

        /// <summary>
        /// An open joystick has been removed.
        /// </summary>
        JoystickDeviceRemoved = 0b_0000_0000_0000_0000_0000_0110_0000_0110,

        #endregion Joystick Events

        #region Game Controller Events

        /// <summary>
        /// Game controller axis motion.
        /// </summary>
        ControllerAxisMotion = 0b_0000_0000_0000_0000_0000_0110_0101_0000,

        /// <summary>
        /// Game controller button pressed.
        /// </summary>
        ControllerButtonDown = 0b_0000_0000_0000_0000_0000_0110_0101_0001,

        /// <summary>
        /// Game controller button released.
        /// </summary>
        ControllerButtonUp = 0b_0000_0000_0000_0000_0000_0110_0101_0010,

        /// <summary>
        /// A new game controller has been inserted into the system.
        /// </summary>
        ControllerDeviceAdded = 0b_0000_0000_0000_0000_0000_0110_0101_0011,

        /// <summary>
        /// An opened game controller has been removed.
        /// </summary>
        ControllerDeviceRemoved = 0b_0000_0000_0000_0000_0000_0110_0101_0100,

        /// <summary>
        /// The game controller mapping was updated.
        /// </summary>
        ControllerDeviceRemapped = 0b_0000_0000_0000_0000_0000_0110_0101_0101,

        #endregion Game Controller Events

        #region Touch Events

        /// <summary>
        /// Finger has touched the screen.
        /// </summary>
        FingerDown = 0b_0000_0000_0000_0000_0000_0111_0000_0000,

        /// <summary>
        /// Finger has stopped touching the screen.
        /// </summary>
        FingerUp = 0b_0000_0000_0000_0000_0000_0111_0000_0001,

        /// <summary>
        /// Finger has moved upon the screen.
        /// </summary>
        FingerMotion = 0b_0000_0000_0000_0000_0000_0111_0000_0010,

        #endregion Touch Events

        #region Gesture Events

        /// <summary>
        ///
        /// </summary>
        DollarGesture = 0b_0000_0000_0000_0000_0000_1000_0000_0000,

        /// <summary>
        ///
        /// </summary>
        DollarRecord = 0b_0000_0000_0000_0000_0000_1000_0000_0001,

        /// <summary>
        ///
        /// </summary>
        MultiGesture = 0b_0000_0000_0000_0000_0000_1000_0000_0010,

        #endregion Gesture Events

        #region Clipboard Events

        /// <summary>
        /// The clipboard changed.
        /// </summary>
        ClipboardUpdate = 0b_0000_0000_0000_0000_0000_1001_0000_0000,

        #endregion Clipboard Events

        #region Drag and Drop Events

        /// <summary>
        /// The system requests a file open.
        /// </summary>
        DropFile = 0b_0000_0000_0000_0000_0001_0000_0000_0000,

        /// <summary>
        /// Text/plain drop-and-drop event.
        /// </summary>
        DropText = 0b_0000_0000_0000_0000_0001_0000_0000_0001,

        /// <summary>
        /// A new set of drops is beginning.
        /// </summary>
        DropBegin = 0b_0000_0000_0000_0000_0001_0000_0000_0010,

        /// <summary>
        /// Current set of drops is now complete.
        /// </summary>
        DropComplete = 0b_0000_0000_0000_0000_0001_0000_0000_0011,

        #endregion Drag and Drop Events

        #region Audio Events

        /// <summary>
        /// A new audio device is available.
        /// </summary>
        AudioDeviceAdded = 0b_0000_0000_0000_0000_0001_0001_0000_0000,

        /// <summary>
        /// An audio device has been removed.
        /// </summary>
        AudioDeviceRemoved = 0b_0000_0000_0000_0000_0001_0001_0000_0001,

        #endregion Audio Events

        #region Sensor Events

        /// <summary>
        /// A sensor was updated.
        /// </summary>
        SensorUpdate = 0b_0000_0000_0000_0000_0001_0010_0000_0000,

        #endregion Sensor Events

        #region Render Events

        /// <summary>
        /// The render targets have been reset and their contents need to be updated.
        /// </summary>
        RenderTargetsReset = 0b_0000_0000_0000_0000_0010_0000_0000_0000,

        /// <summary>
        /// The device has been reset and all textures need to be recreated.
        /// </summary>
        RenderDeviceReset = 0b_0000_0000_0000_0000_0010_0000_0000_0001,

        #endregion Render Events
    }
}
