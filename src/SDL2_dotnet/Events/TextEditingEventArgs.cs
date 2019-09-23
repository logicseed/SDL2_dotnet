// SPDX-License-Identifier: MIT

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL.Events
{
    /// <summary>
    /// A structure that contains keyboard text editing event information.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct TextEditingEventArgs : IEquatable<TextEditingEventArgs>
    {
        /// <summary>
        /// Should be <see cref="EventType.TextEditing"/>
        /// </summary>
        public EventType Type => _type;
        [FieldOffset(0)]
        private readonly EventType _type;

        /// <summary>
        /// Timestamp of the event in milliseconds.
        /// </summary>
        public uint Timestamp => _timestamp;
        [FieldOffset(4)]
        private readonly uint _timestamp;

        /// <summary>
        /// The associated window.
        /// </summary>
        public uint WindowID => _windowID;
        [FieldOffset(8)]
        private readonly uint _windowID;

        /// <summary>
        /// The null-terminated input text in UTF-8 encoding.
        /// </summary>
        public string Text => BuildText();
        [FieldOffset(12)]
        private readonly byte _char1;
        [FieldOffset(13)]
        private readonly byte _char2;
        [FieldOffset(14)]
        private readonly byte _char3;
        [FieldOffset(15)]
        private readonly byte _char4;
        [FieldOffset(16)]
        private readonly byte _char5;
        [FieldOffset(17)]
        private readonly byte _char6;
        [FieldOffset(18)]
        private readonly byte _char7;
        [FieldOffset(19)]
        private readonly byte _char8;
        [FieldOffset(20)]
        private readonly byte _char9;
        [FieldOffset(21)]
        private readonly byte _char10;
        [FieldOffset(22)]
        private readonly byte _char11;
        [FieldOffset(23)]
        private readonly byte _char12;
        [FieldOffset(24)]
        private readonly byte _char13;
        [FieldOffset(25)]
        private readonly byte _char14;
        [FieldOffset(26)]
        private readonly byte _char15;
        [FieldOffset(27)]
        private readonly byte _char16;
        [FieldOffset(28)]
        private readonly byte _char17;
        [FieldOffset(29)]
        private readonly byte _char18;
        [FieldOffset(30)]
        private readonly byte _char19;
        [FieldOffset(31)]
        private readonly byte _char20;
        [FieldOffset(32)]
        private readonly byte _char21;
        [FieldOffset(33)]
        private readonly byte _char22;
        [FieldOffset(34)]
        private readonly byte _char23;
        [FieldOffset(35)]
        private readonly byte _char24;
        [FieldOffset(36)]
        private readonly byte _char25;
        [FieldOffset(37)]
        private readonly byte _char26;
        [FieldOffset(38)]
        private readonly byte _char27;
        [FieldOffset(39)]
        private readonly byte _char28;
        [FieldOffset(40)]
        private readonly byte _char29;
        [FieldOffset(41)]
        private readonly byte _char30;
        [FieldOffset(42)]
        private readonly byte _char31;
        [FieldOffset(43)]
        private readonly byte _char32;

        /// <summary>
        /// The location to begin editing from.
        /// </summary>
        public int Start => _start;
        [FieldOffset(44)]
        private readonly int _start;

        /// <summary>
        /// The number of characters to edit from the start point.
        /// </summary>
        public int Length => _length;
        [FieldOffset(48)]
        private readonly int _length;

        private string BuildText()
        {
            List<byte> buffer = new List<byte>();

#pragma warning disable IDE0011 // Add braces
            if (Add(ref buffer, _char1)) return Convert(ref buffer);
            if (Add(ref buffer, _char2)) return Convert(ref buffer);
            if (Add(ref buffer, _char3)) return Convert(ref buffer);
            if (Add(ref buffer, _char4)) return Convert(ref buffer);
            if (Add(ref buffer, _char5)) return Convert(ref buffer);
            if (Add(ref buffer, _char6)) return Convert(ref buffer);
            if (Add(ref buffer, _char7)) return Convert(ref buffer);
            if (Add(ref buffer, _char8)) return Convert(ref buffer);
            if (Add(ref buffer, _char9)) return Convert(ref buffer);
            if (Add(ref buffer, _char10)) return Convert(ref buffer);
            if (Add(ref buffer, _char11)) return Convert(ref buffer);
            if (Add(ref buffer, _char12)) return Convert(ref buffer);
            if (Add(ref buffer, _char13)) return Convert(ref buffer);
            if (Add(ref buffer, _char14)) return Convert(ref buffer);
            if (Add(ref buffer, _char15)) return Convert(ref buffer);
            if (Add(ref buffer, _char16)) return Convert(ref buffer);
            if (Add(ref buffer, _char17)) return Convert(ref buffer);
            if (Add(ref buffer, _char18)) return Convert(ref buffer);
            if (Add(ref buffer, _char19)) return Convert(ref buffer);
            if (Add(ref buffer, _char20)) return Convert(ref buffer);
            if (Add(ref buffer, _char21)) return Convert(ref buffer);
            if (Add(ref buffer, _char22)) return Convert(ref buffer);
            if (Add(ref buffer, _char23)) return Convert(ref buffer);
            if (Add(ref buffer, _char24)) return Convert(ref buffer);
            if (Add(ref buffer, _char25)) return Convert(ref buffer);
            if (Add(ref buffer, _char26)) return Convert(ref buffer);
            if (Add(ref buffer, _char27)) return Convert(ref buffer);
            if (Add(ref buffer, _char28)) return Convert(ref buffer);
            if (Add(ref buffer, _char29)) return Convert(ref buffer);
            if (Add(ref buffer, _char30)) return Convert(ref buffer);
            if (Add(ref buffer, _char31)) return Convert(ref buffer);
            if (Add(ref buffer, _char32)) return Convert(ref buffer);
#pragma warning restore IDE0011 // Add braces

            return Convert(ref buffer);
        }

        private bool Add(ref List<byte> buffer, byte byteToAdd)
        {
            if (byteToAdd != '\0')
            {
                buffer.Add(byteToAdd);
                return true;
            }
            return false;
        }

        private string Convert(ref List<byte> buffer)
        {
            return Encoding.ASCII.GetString(buffer.ToArray(), 0, buffer.Count);
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is TextEditingEventArgs args && Equals(args);
        }

        public bool Equals(TextEditingEventArgs other)
        {
            return
                _type == other._type &&
                _timestamp == other._timestamp &&
                _windowID == other._windowID &&
                _char1 == other._char1 &&
                _char2 == other._char2 &&
                _char3 == other._char3 &&
                _char4 == other._char4 &&
                _char5 == other._char5 &&
                _char6 == other._char6 &&
                _char7 == other._char7 &&
                _char8 == other._char8 &&
                _char9 == other._char9 &&
                _char10 == other._char10 &&
                _char11 == other._char11 &&
                _char12 == other._char12 &&
                _char13 == other._char13 &&
                _char14 == other._char14 &&
                _char15 == other._char15 &&
                _char16 == other._char16 &&
                _char17 == other._char17 &&
                _char18 == other._char18 &&
                _char19 == other._char19 &&
                _char20 == other._char20 &&
                _char21 == other._char21 &&
                _char22 == other._char22 &&
                _char23 == other._char23 &&
                _char24 == other._char24 &&
                _char25 == other._char25 &&
                _char26 == other._char26 &&
                _char27 == other._char27 &&
                _char28 == other._char28 &&
                _char29 == other._char29 &&
                _char30 == other._char30 &&
                _char31 == other._char31 &&
                _char32 == other._char32 &&
                _start == other._start &&
                _length == other._length;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(_type);
            hash.Add(_timestamp);
            hash.Add(_windowID);
            hash.Add(_char1);
            hash.Add(_char2);
            hash.Add(_char3);
            hash.Add(_char4);
            hash.Add(_char5);
            hash.Add(_char6);
            hash.Add(_char7);
            hash.Add(_char8);
            hash.Add(_char9);
            hash.Add(_char10);
            hash.Add(_char11);
            hash.Add(_char12);
            hash.Add(_char13);
            hash.Add(_char14);
            hash.Add(_char15);
            hash.Add(_char16);
            hash.Add(_char17);
            hash.Add(_char18);
            hash.Add(_char19);
            hash.Add(_char20);
            hash.Add(_char21);
            hash.Add(_char22);
            hash.Add(_char23);
            hash.Add(_char24);
            hash.Add(_char25);
            hash.Add(_char26);
            hash.Add(_char27);
            hash.Add(_char28);
            hash.Add(_char29);
            hash.Add(_char30);
            hash.Add(_char31);
            hash.Add(_char32);
            hash.Add(_start);
            hash.Add(_length);
            return hash.ToHashCode();
        }

        public static bool operator ==(TextEditingEventArgs left, TextEditingEventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TextEditingEventArgs left, TextEditingEventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
