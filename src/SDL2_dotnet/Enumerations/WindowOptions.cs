// SPDX-License-Identifier: MIT

using System;

namespace SDL
{
    /// <summary>
    /// An enumeration of window options.
    /// </summary>
    [Flags]
#pragma warning disable CA2217 // Do not mark enums with FlagsAttribute
    public enum WindowOptions
    {
        /// <summary>
        /// No window flags set.
        /// </summary>
        None = 0b_0000_0000_0000_0000_0000_0000_0000_0000,

        /// <summary>
        /// Fullscreen window.
        /// </summary>
        Fullscreen = 0b_0000_0000_0000_0000_0000_0000_0000_0001,

        /// <summary>
        /// Window usable with OpenGL context.
        /// </summary>
        OpenGL = 0b_0000_0000_0000_0000_0000_0000_0000_0010,

        /// <summary>
        /// Window is visible.
        /// </summary>
        Shown = 0b_0000_0000_0000_0000_0000_0000_0000_0100,

        /// <summary>
        /// Window is not visible.
        /// </summary>
        Hidden = 0b_0000_0000_0000_0000_0000_0000_0000_1000,

        /// <summary>
        /// No window decoration.
        /// </summary>
        Borderless = 0b_0000_0000_0000_0000_0000_0000_0001_0000,

        /// <summary>
        /// Window can be resized.
        /// </summary>
        Resizable = 0b_0000_0000_0000_0000_0000_0000_0010_0000,

        /// <summary>
        /// Window is minimized.
        /// </summary>
        Minimized = 0b_0000_0000_0000_0000_0000_0000_0100_0000,

        /// <summary>
        /// Window is maximized.
        /// </summary>
        Maximized = 0b_0000_0000_0000_0000_0000_0000_1000_0000,

        /// <summary>
        /// Window has grabbed input focus.
        /// </summary>
        InputGrabbed = 0b_0000_0000_0000_0000_0000_0001_0000_0000,

        /// <summary>
        /// Window has input focus.
        /// </summary>
        InputFocus = 0b_0000_0000_0000_0000_0000_0010_0000_0000,

        /// <summary>
        /// Window has mouse focus.
        /// </summary>
        MouseFocus = 0b_0000_0000_0000_0000_0000_0100_0000_0000,

        /// <summary>
        /// Window not created by SDL.
        /// </summary>
        Foreign = 0b_0000_0000_0000_0000_0000_1000_0000_0000,

        /// <summary>
        /// Fullscreen window at the current desktop resolution.
        /// </summary>
        FullscreenDesktop = 0b_0000_0000_0000_0000_0001_0000_0000_0000 | Fullscreen,

        /// <summary>
        /// Window should be created in high-DPI mode if supported.
        /// </summary>
        AllowHighDPI = 0b_0000_0000_0000_0000_0010_0000_0000_0000,

        /// <summary>
        /// Window has mouse captured. (unrelated to <see cref="InputGrabbed"/>)
        /// </summary>
        MouseCapture = 0b_0000_0000_0000_0000_0100_0000_0000_0000,

        /// <summary>
        /// Window should always be above others. (X11 only)
        /// </summary>
        AlwaysOnTop = 0b_0000_0000_0000_0000_1000_0000_0000_0000,

        /// <summary>
        /// Window should not be added to the taskbar. (X11 only)
        /// </summary>
        SkipTaskbar = 0b_0000_0000_0000_0001_0000_0000_0000_0000,

        /// <summary>
        /// Window should be treated as a utility window. (X11 only)
        /// </summary>
        Utility = 0b_0000_0000_0000_0010_0000_0000_0000_0000,

        /// <summary>
        /// Window should be treated as a tooltip. (X11 only)
        /// </summary>
        Tooltip = 0b_0000_0000_0000_0100_0000_0000_0000_0000,

        /// <summary>
        /// Window should be treated as a popup menu. (X11 only)
        /// </summary>
        PopupMenu = 0b_0000_0000_0000_1000_0000_0000_0000_0000
    }
#pragma warning restore CA2217 // Do not mark enums with FlagsAttribute
}
