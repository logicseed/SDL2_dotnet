// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains key information used in key events.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct KeyInfo : IEquatable<KeyInfo>
    {
        /// <summary>
        /// Physical key code.
        /// </summary>
        public ScanCode Scancode => _scancode;
        [FieldOffset(0)]
        private readonly ScanCode _scancode;

        /// <summary>
        /// Virtual key code.
        /// </summary>
        public KeyCode Keycode => _keycode;
        [FieldOffset(4)]
        private readonly KeyCode _keycode;

        /// <summary>
        /// Current key modifiers.
        /// </summary>
        public KeyModifiers KeyModifiers => _keyModifiers;
        [FieldOffset(8)]
        private readonly KeyModifiers _keyModifiers;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is KeyInfo info && Equals(info);
        }

        public bool Equals(KeyInfo other)
        {
            return
                _scancode == other._scancode &&
                _keycode == other._keycode &&
                _keyModifiers == other._keyModifiers;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_scancode, _keycode, _keyModifiers);
        }

        public static bool operator ==(KeyInfo left, KeyInfo right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(KeyInfo left, KeyInfo right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
