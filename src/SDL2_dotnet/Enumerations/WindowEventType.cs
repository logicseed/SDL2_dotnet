// SPDX-License-Identifier: MIT

namespace SDL2_dotnet
{
    /// <summary>
    /// An enumeration of window events.
    /// </summary>
    public enum WindowEventType : byte
    {
        None = 0b_0000_0000,

        /// <summary>
        /// Window has been shown.
        /// </summary>
        Shown = 0b_0000_0001,

        /// <summary>
        /// Window has been hidden.
        /// </summary>
        Hidden = 0b_0000_0010,

        /// <summary>
        /// Window has been exposed and should be redrawn.
        /// </summary>
        Exposed = 0b_0000_0011,

        /// <summary>
        /// Window has been moved to data1, data2.
        /// </summary>
        Moved = 0b_0000_0100,

        /// <summary>
        /// Window has been resized to data1xdata2; this event is always preceded by SDL_WINDOWEVENT_SIZE_CHANGED.
        /// </summary>
        Resized = 0b_0000_0101,

        /// <summary>
        /// Window size has changed, either as a result of an API call or through the system or user changing the
        /// window size; this event is followed by SDL_WINDOWEVENT_RESIZED if the size was changed by an external
        /// event, i.e. the user or the window manager.
        /// </summary>
        SizeChanged = 0b_0000_0110,

        /// <summary>
        /// Window has been minimized.
        /// </summary>
        Minimized = 0b_0000_0111,

        /// <summary>
        /// Window has been maximized.
        /// </summary>
        Maximized = 0b_0000_1000,

        /// <summary>
        /// Window has been restored to normal size and position.
        /// </summary>
        Restored = 0b_0000_1001,

        /// <summary>
        /// Window has gained mouse focus.
        /// </summary>
        Enter = 0b_0000_1010,

        /// <summary>
        /// Window has lost mouse focus.
        /// </summary>
        Leave = 0b_0000_1011,

        /// <summary>
        /// Window has gained keyboard focus.
        /// </summary>
        FocusGained = 0b_0000_1100,

        /// <summary>
        /// Window has lost keyboard focus.
        /// </summary>
        FocusLost = 0b_0000_1101,

        /// <summary>
        /// The window manager requests that the window be closed.
        /// </summary>
        Close = 0b_0000_1110,

        /// <summary>
        /// Window is being offered a focus (should SDL_SetWindowInputFocus() on itself or a subwindow, or ignore).
        /// </summary>
        TakeFocus = 0b_0000_1111,

        /// <summary>
        /// Window had a hit test that wasn't SDL_HITTEST_NORMAL.
        /// </summary>
        HitTest = 0b_0001_0000
    }
}
