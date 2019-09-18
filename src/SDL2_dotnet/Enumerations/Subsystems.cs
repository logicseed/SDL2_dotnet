// SPDX-License-Identifier: MIT

using System;

namespace SDL2_dotnet
{
    /// <summary>
    /// An enumeration of subsystems.
    /// </summary>
    /// <remarks>
    /// Keys and values match SDL_INIT_* constants in SDL.h
    /// </remarks>
    [Flags]
    public enum Subsystems : uint
    {
        /// <summary>
        /// No subsystems.
        /// </summary>
        None = 0b_0000_0000_0000_0000_0000_0000_0000_0000,

        /// <summary>
        /// Timer subsystem.
        /// </summary>
        Timer = 0b_0000_0000_0000_0000_0000_0000_0000_0001,

        /// <summary>
        /// Audio subsystem.
        /// </summary>
        Audio = 0b_0000_0000_0000_0000_0000_0000_0001_0000,

        /// <summary>
        /// Video subsystem. Automatically initializes the <see cref="Events"/> subsystem.
        /// </summary>
        Video = 0b_0000_0000_0000_0000_0000_0000_0010_0000,

        /// <summary>
        /// Joystick subsystem. Automatically initializes the <see cref="Events"/> subsystem.
        /// </summary>
        Joystick = 0b_0000_0000_0000_0000_0000_0010_0000_0000,

        /// <summary>
        /// Haptic (force feedback) subsystem.
        /// </summary>
        Haptic = 0b_0000_0000_0000_0000_0001_0000_0000_0000,

        /// <summary>
        /// Controller subsystem. Automatically initializes the <see cref="Joystick"/> subsystem.
        /// </summary>
        GameController = 0b_0000_0000_0000_0000_0010_0000_0000_0000,

        /// <summary>
        /// Events subsystem.
        /// </summary>
        Events = 0b_0000_0000_0000_0000_0100_0000_0000_0000,

        /// <summary>
        /// Sensor subsystem.
        /// </summary>
        Sensor = 0b_0000_0000_0000_0000_1000_0000_0000_0000,

        /// <summary>
        /// All subsystems.
        /// </summary>
        Everything =
            Timer |
            Audio |
            Video |
            Joystick |
            Haptic |
            GameController |
            Events |
            Sensor
    }
}
