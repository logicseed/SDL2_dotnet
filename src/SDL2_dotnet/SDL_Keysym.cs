// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace SDL2_dotnet
{
    /// <summary>
    /// A structure that contains key information used in key events.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_Keysym
    {
        /// <summary>
        /// Physical key code.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public Scancode Scancode;

        /// <summary>
        /// Virtual key code.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public Keycode Keycode;

        /// <summary>
        /// Current key modifiers.
        /// </summary>
        [MarshalAs(UnmanagedType.U2)]
        public Keymod Keymod;

#pragma warning disable IDE0044 // Add readonly modifier
        // IGNORE
        private uint unused;
        // IGNORE
#pragma warning restore IDE0044 // Add readonly modifier
    }
}
