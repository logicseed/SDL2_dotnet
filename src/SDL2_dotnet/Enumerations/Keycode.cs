﻿// SPDX-License-Identifier: MIT

namespace SDL2_dotnet
{
    public enum Keycode
    {
        SDLK_UNKNOWN = 0,

        SDLK_RETURN = '\r',
        SDLK_ESCAPE = 27, // '\033'
        SDLK_BACKSPACE = '\b',
        SDLK_TAB = '\t',
        SDLK_SPACE = ' ',
        SDLK_EXCLAIM = '!',
        SDLK_QUOTEDBL = '"',
        SDLK_HASH = '#',
        SDLK_PERCENT = '%',
        SDLK_DOLLAR = '$',
        SDLK_AMPERSAND = '&',
        SDLK_QUOTE = '\'',
        SDLK_LEFTPAREN = '(',
        SDLK_RIGHTPAREN = ')',
        SDLK_ASTERISK = '*',
        SDLK_PLUS = '+',
        SDLK_COMMA = ',',
        SDLK_MINUS = '-',
        SDLK_PERIOD = '.',
        SDLK_SLASH = '/',
        SDLK_0 = '0',
        SDLK_1 = '1',
        SDLK_2 = '2',
        SDLK_3 = '3',
        SDLK_4 = '4',
        SDLK_5 = '5',
        SDLK_6 = '6',
        SDLK_7 = '7',
        SDLK_8 = '8',
        SDLK_9 = '9',
        SDLK_COLON = ':',
        SDLK_SEMICOLON = ';',
        SDLK_LESS = '<',
        SDLK_EQUALS = '=',
        SDLK_GREATER = '>',
        SDLK_QUESTION = '?',
        SDLK_AT = '@',
        /*
        Skip uppercase letters
        */
        SDLK_LEFTBRACKET = '[',
        SDLK_BACKSLASH = '\\',
        SDLK_RIGHTBRACKET = ']',
        SDLK_CARET = '^',
        SDLK_UNDERSCORE = '_',
        SDLK_BACKQUOTE = '`',
        SDLK_a = 'a',
        SDLK_b = 'b',
        SDLK_c = 'c',
        SDLK_d = 'd',
        SDLK_e = 'e',
        SDLK_f = 'f',
        SDLK_g = 'g',
        SDLK_h = 'h',
        SDLK_i = 'i',
        SDLK_j = 'j',
        SDLK_k = 'k',
        SDLK_l = 'l',
        SDLK_m = 'm',
        SDLK_n = 'n',
        SDLK_o = 'o',
        SDLK_p = 'p',
        SDLK_q = 'q',
        SDLK_r = 'r',
        SDLK_s = 's',
        SDLK_t = 't',
        SDLK_u = 'u',
        SDLK_v = 'v',
        SDLK_w = 'w',
        SDLK_x = 'x',
        SDLK_y = 'y',
        SDLK_z = 'z',

        SDLK_CAPSLOCK = (int)Scancode.SDL_SCANCODE_CAPSLOCK | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_F1 = (int)Scancode.SDL_SCANCODE_F1 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F2 = (int)Scancode.SDL_SCANCODE_F2 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F3 = (int)Scancode.SDL_SCANCODE_F3 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F4 = (int)Scancode.SDL_SCANCODE_F4 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F5 = (int)Scancode.SDL_SCANCODE_F5 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F6 = (int)Scancode.SDL_SCANCODE_F6 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F7 = (int)Scancode.SDL_SCANCODE_F7 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F8 = (int)Scancode.SDL_SCANCODE_F8 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F9 = (int)Scancode.SDL_SCANCODE_F9 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F10 = (int)Scancode.SDL_SCANCODE_F10 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F11 = (int)Scancode.SDL_SCANCODE_F11 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F12 = (int)Scancode.SDL_SCANCODE_F12 | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_PRINTSCREEN = (int)Scancode.SDL_SCANCODE_PRINTSCREEN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_SCROLLLOCK = (int)Scancode.SDL_SCANCODE_SCROLLLOCK | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_PAUSE = (int)Scancode.SDL_SCANCODE_PAUSE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_INSERT = (int)Scancode.SDL_SCANCODE_INSERT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_HOME = (int)Scancode.SDL_SCANCODE_HOME | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_PAGEUP = (int)Scancode.SDL_SCANCODE_PAGEUP | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_DELETE = 127,
        SDLK_END = (int)Scancode.SDL_SCANCODE_END | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_PAGEDOWN = (int)Scancode.SDL_SCANCODE_PAGEDOWN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_RIGHT = (int)Scancode.SDL_SCANCODE_RIGHT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_LEFT = (int)Scancode.SDL_SCANCODE_LEFT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_DOWN = (int)Scancode.SDL_SCANCODE_DOWN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_UP = (int)Scancode.SDL_SCANCODE_UP | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_NUMLOCKCLEAR = (int)Scancode.SDL_SCANCODE_NUMLOCKCLEAR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_DIVIDE = (int)Scancode.SDL_SCANCODE_KP_DIVIDE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_MULTIPLY = (int)Scancode.SDL_SCANCODE_KP_MULTIPLY | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_MINUS = (int)Scancode.SDL_SCANCODE_KP_MINUS | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_PLUS = (int)Scancode.SDL_SCANCODE_KP_PLUS | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_ENTER = (int)Scancode.SDL_SCANCODE_KP_ENTER | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_1 = (int)Scancode.SDL_SCANCODE_KP_1 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_2 = (int)Scancode.SDL_SCANCODE_KP_2 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_3 = (int)Scancode.SDL_SCANCODE_KP_3 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_4 = (int)Scancode.SDL_SCANCODE_KP_4 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_5 = (int)Scancode.SDL_SCANCODE_KP_5 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_6 = (int)Scancode.SDL_SCANCODE_KP_6 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_7 = (int)Scancode.SDL_SCANCODE_KP_7 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_8 = (int)Scancode.SDL_SCANCODE_KP_8 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_9 = (int)Scancode.SDL_SCANCODE_KP_9 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_0 = (int)Scancode.SDL_SCANCODE_KP_0 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_PERIOD = (int)Scancode.SDL_SCANCODE_KP_PERIOD | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_APPLICATION = (int)Scancode.SDL_SCANCODE_APPLICATION | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_POWER = (int)Scancode.SDL_SCANCODE_POWER | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_EQUALS = (int)Scancode.SDL_SCANCODE_KP_EQUALS | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F13 = (int)Scancode.SDL_SCANCODE_F13 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F14 = (int)Scancode.SDL_SCANCODE_F14 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F15 = (int)Scancode.SDL_SCANCODE_F15 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F16 = (int)Scancode.SDL_SCANCODE_F16 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F17 = (int)Scancode.SDL_SCANCODE_F17 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F18 = (int)Scancode.SDL_SCANCODE_F18 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F19 = (int)Scancode.SDL_SCANCODE_F19 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F20 = (int)Scancode.SDL_SCANCODE_F20 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F21 = (int)Scancode.SDL_SCANCODE_F21 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F22 = (int)Scancode.SDL_SCANCODE_F22 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F23 = (int)Scancode.SDL_SCANCODE_F23 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_F24 = (int)Scancode.SDL_SCANCODE_F24 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_EXECUTE = (int)Scancode.SDL_SCANCODE_EXECUTE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_HELP = (int)Scancode.SDL_SCANCODE_HELP | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_MENU = (int)Scancode.SDL_SCANCODE_MENU | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_SELECT = (int)Scancode.SDL_SCANCODE_SELECT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_STOP = (int)Scancode.SDL_SCANCODE_STOP | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AGAIN = (int)Scancode.SDL_SCANCODE_AGAIN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_UNDO = (int)Scancode.SDL_SCANCODE_UNDO | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_CUT = (int)Scancode.SDL_SCANCODE_CUT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_COPY = (int)Scancode.SDL_SCANCODE_COPY | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_PASTE = (int)Scancode.SDL_SCANCODE_PASTE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_FIND = (int)Scancode.SDL_SCANCODE_FIND | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_MUTE = (int)Scancode.SDL_SCANCODE_MUTE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_VOLUMEUP = (int)Scancode.SDL_SCANCODE_VOLUMEUP | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_VOLUMEDOWN = (int)Scancode.SDL_SCANCODE_VOLUMEDOWN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_COMMA = (int)Scancode.SDL_SCANCODE_KP_COMMA | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_EQUALSAS400 =
        (int)Scancode.SDL_SCANCODE_KP_EQUALSAS400 | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_ALTERASE = (int)Scancode.SDL_SCANCODE_ALTERASE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_SYSREQ = (int)Scancode.SDL_SCANCODE_SYSREQ | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_CANCEL = (int)Scancode.SDL_SCANCODE_CANCEL | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_CLEAR = (int)Scancode.SDL_SCANCODE_CLEAR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_PRIOR = (int)Scancode.SDL_SCANCODE_PRIOR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_RETURN2 = (int)Scancode.SDL_SCANCODE_RETURN2 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_SEPARATOR = (int)Scancode.SDL_SCANCODE_SEPARATOR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_OUT = (int)Scancode.SDL_SCANCODE_OUT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_OPER = (int)Scancode.SDL_SCANCODE_OPER | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_CLEARAGAIN = (int)Scancode.SDL_SCANCODE_CLEARAGAIN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_CRSEL = (int)Scancode.SDL_SCANCODE_CRSEL | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_EXSEL = (int)Scancode.SDL_SCANCODE_EXSEL | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_KP_00 = (int)Scancode.SDL_SCANCODE_KP_00 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_000 = (int)Scancode.SDL_SCANCODE_KP_000 | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_THOUSANDSSEPARATOR =
        (int)Scancode.SDL_SCANCODE_THOUSANDSSEPARATOR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_DECIMALSEPARATOR =
        (int)Scancode.SDL_SCANCODE_DECIMALSEPARATOR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_CURRENCYUNIT = (int)Scancode.SDL_SCANCODE_CURRENCYUNIT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_CURRENCYSUBUNIT =
        (int)Scancode.SDL_SCANCODE_CURRENCYSUBUNIT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_LEFTPAREN = (int)Scancode.SDL_SCANCODE_KP_LEFTPAREN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_RIGHTPAREN = (int)Scancode.SDL_SCANCODE_KP_RIGHTPAREN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_LEFTBRACE = (int)Scancode.SDL_SCANCODE_KP_LEFTBRACE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_RIGHTBRACE = (int)Scancode.SDL_SCANCODE_KP_RIGHTBRACE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_TAB = (int)Scancode.SDL_SCANCODE_KP_TAB | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_BACKSPACE = (int)Scancode.SDL_SCANCODE_KP_BACKSPACE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_A = (int)Scancode.SDL_SCANCODE_KP_A | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_B = (int)Scancode.SDL_SCANCODE_KP_B | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_C = (int)Scancode.SDL_SCANCODE_KP_C | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_D = (int)Scancode.SDL_SCANCODE_KP_D | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_E = (int)Scancode.SDL_SCANCODE_KP_E | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_F = (int)Scancode.SDL_SCANCODE_KP_F | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_XOR = (int)Scancode.SDL_SCANCODE_KP_XOR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_POWER = (int)Scancode.SDL_SCANCODE_KP_POWER | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_PERCENT = (int)Scancode.SDL_SCANCODE_KP_PERCENT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_LESS = (int)Scancode.SDL_SCANCODE_KP_LESS | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_GREATER = (int)Scancode.SDL_SCANCODE_KP_GREATER | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_AMPERSAND = (int)Scancode.SDL_SCANCODE_KP_AMPERSAND | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_DBLAMPERSAND =
        (int)Scancode.SDL_SCANCODE_KP_DBLAMPERSAND | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_VERTICALBAR =
        (int)Scancode.SDL_SCANCODE_KP_VERTICALBAR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_DBLVERTICALBAR =
        (int)Scancode.SDL_SCANCODE_KP_DBLVERTICALBAR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_COLON = (int)Scancode.SDL_SCANCODE_KP_COLON | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_HASH = (int)Scancode.SDL_SCANCODE_KP_HASH | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_SPACE = (int)Scancode.SDL_SCANCODE_KP_SPACE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_AT = (int)Scancode.SDL_SCANCODE_KP_AT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_EXCLAM = (int)Scancode.SDL_SCANCODE_KP_EXCLAM | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMSTORE = (int)Scancode.SDL_SCANCODE_KP_MEMSTORE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMRECALL = (int)Scancode.SDL_SCANCODE_KP_MEMRECALL | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMCLEAR = (int)Scancode.SDL_SCANCODE_KP_MEMCLEAR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMADD = (int)Scancode.SDL_SCANCODE_KP_MEMADD | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMSUBTRACT =
        (int)Scancode.SDL_SCANCODE_KP_MEMSUBTRACT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMMULTIPLY =
        (int)Scancode.SDL_SCANCODE_KP_MEMMULTIPLY | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMDIVIDE = (int)Scancode.SDL_SCANCODE_KP_MEMDIVIDE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_PLUSMINUS = (int)Scancode.SDL_SCANCODE_KP_PLUSMINUS | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_CLEAR = (int)Scancode.SDL_SCANCODE_KP_CLEAR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_CLEARENTRY = (int)Scancode.SDL_SCANCODE_KP_CLEARENTRY | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_BINARY = (int)Scancode.SDL_SCANCODE_KP_BINARY | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_OCTAL = (int)Scancode.SDL_SCANCODE_KP_OCTAL | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_DECIMAL = (int)Scancode.SDL_SCANCODE_KP_DECIMAL | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KP_HEXADECIMAL =
        (int)Scancode.SDL_SCANCODE_KP_HEXADECIMAL | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_LCTRL = (int)Scancode.SDL_SCANCODE_LCTRL | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_LSHIFT = (int)Scancode.SDL_SCANCODE_LSHIFT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_LALT = (int)Scancode.SDL_SCANCODE_LALT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_LGUI = (int)Scancode.SDL_SCANCODE_LGUI | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_RCTRL = (int)Scancode.SDL_SCANCODE_RCTRL | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_RSHIFT = (int)Scancode.SDL_SCANCODE_RSHIFT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_RALT = (int)Scancode.SDL_SCANCODE_RALT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_RGUI = (int)Scancode.SDL_SCANCODE_RGUI | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_MODE = (int)Scancode.SDL_SCANCODE_MODE | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_AUDIONEXT = (int)Scancode.SDL_SCANCODE_AUDIONEXT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AUDIOPREV = (int)Scancode.SDL_SCANCODE_AUDIOPREV | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AUDIOSTOP = (int)Scancode.SDL_SCANCODE_AUDIOSTOP | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AUDIOPLAY = (int)Scancode.SDL_SCANCODE_AUDIOPLAY | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AUDIOMUTE = (int)Scancode.SDL_SCANCODE_AUDIOMUTE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_MEDIASELECT = (int)Scancode.SDL_SCANCODE_MEDIASELECT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_WWW = (int)Scancode.SDL_SCANCODE_WWW | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_MAIL = (int)Scancode.SDL_SCANCODE_MAIL | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_CALCULATOR = (int)Scancode.SDL_SCANCODE_CALCULATOR | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_COMPUTER = (int)Scancode.SDL_SCANCODE_COMPUTER | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AC_SEARCH = (int)Scancode.SDL_SCANCODE_AC_SEARCH | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AC_HOME = (int)Scancode.SDL_SCANCODE_AC_HOME | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AC_BACK = (int)Scancode.SDL_SCANCODE_AC_BACK | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AC_FORWARD = (int)Scancode.SDL_SCANCODE_AC_FORWARD | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AC_STOP = (int)Scancode.SDL_SCANCODE_AC_STOP | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AC_REFRESH = (int)Scancode.SDL_SCANCODE_AC_REFRESH | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_AC_BOOKMARKS = (int)Scancode.SDL_SCANCODE_AC_BOOKMARKS | SDL_scancode.SDLK_SCANCODE_MASK,

        SDLK_BRIGHTNESSDOWN =
        (int)Scancode.SDL_SCANCODE_BRIGHTNESSDOWN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_BRIGHTNESSUP = (int)Scancode.SDL_SCANCODE_BRIGHTNESSUP | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_DISPLAYSWITCH = (int)Scancode.SDL_SCANCODE_DISPLAYSWITCH | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KBDILLUMTOGGLE =
        (int)Scancode.SDL_SCANCODE_KBDILLUMTOGGLE | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KBDILLUMDOWN = (int)Scancode.SDL_SCANCODE_KBDILLUMDOWN | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_KBDILLUMUP = (int)Scancode.SDL_SCANCODE_KBDILLUMUP | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_EJECT = (int)Scancode.SDL_SCANCODE_EJECT | SDL_scancode.SDLK_SCANCODE_MASK,
        SDLK_SLEEP = (int)Scancode.SDL_SCANCODE_SLEEP | SDL_scancode.SDLK_SCANCODE_MASK
    }
}
