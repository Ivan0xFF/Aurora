﻿using LedCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Devices.Logitech
{
    public static class LedMaps
    {
        public static readonly Dictionary<DeviceKeys, keyboardNames> KeyMap = new Dictionary<DeviceKeys, keyboardNames>()
        {
            [DeviceKeys.ESC] = keyboardNames.ESC,
            [DeviceKeys.F1] = keyboardNames.F1,
            [DeviceKeys.F2] = keyboardNames.F2,
            [DeviceKeys.F3] = keyboardNames.F3,
            [DeviceKeys.F4] = keyboardNames.F4,
            [DeviceKeys.F5] = keyboardNames.F5,
            [DeviceKeys.F6] = keyboardNames.F6,
            [DeviceKeys.F7] = keyboardNames.F7,
            [DeviceKeys.F8] = keyboardNames.F8,
            [DeviceKeys.F9] = keyboardNames.F9,
            [DeviceKeys.F10] = keyboardNames.F10,
            [DeviceKeys.F11] = keyboardNames.F11,
            [DeviceKeys.F12] = keyboardNames.F12,
            [DeviceKeys.PRINT_SCREEN] = keyboardNames.PRINT_SCREEN,
            [DeviceKeys.SCROLL_LOCK] = keyboardNames.SCROLL_LOCK,
            [DeviceKeys.PAUSE_BREAK] = keyboardNames.PAUSE_BREAK,
            [DeviceKeys.TILDE] = keyboardNames.TILDE,
            [DeviceKeys.ONE] = keyboardNames.ONE,
            [DeviceKeys.TWO] = keyboardNames.TWO,
            [DeviceKeys.THREE] = keyboardNames.THREE,
            [DeviceKeys.FOUR] = keyboardNames.FOUR,
            [DeviceKeys.FIVE] = keyboardNames.FIVE,
            [DeviceKeys.SIX] = keyboardNames.SIX,
            [DeviceKeys.SEVEN] = keyboardNames.SEVEN,
            [DeviceKeys.EIGHT] = keyboardNames.EIGHT,
            [DeviceKeys.NINE] = keyboardNames.NINE,
            [DeviceKeys.ZERO] = keyboardNames.ZERO,
            [DeviceKeys.MINUS] = keyboardNames.MINUS,
            [DeviceKeys.EQUALS] = keyboardNames.EQUALS,
            [DeviceKeys.BACKSPACE] = keyboardNames.BACKSPACE,
            [DeviceKeys.INSERT] = keyboardNames.INSERT,
            [DeviceKeys.HOME] = keyboardNames.HOME,
            [DeviceKeys.PAGE_UP] = keyboardNames.PAGE_UP,
            [DeviceKeys.NUM_LOCK] = keyboardNames.NUM_LOCK,
            [DeviceKeys.NUM_SLASH] = keyboardNames.NUM_SLASH,
            [DeviceKeys.NUM_ASTERISK] = keyboardNames.NUM_ASTERISK,
            [DeviceKeys.NUM_MINUS] = keyboardNames.NUM_MINUS,
            [DeviceKeys.TAB] = keyboardNames.TAB,
            [DeviceKeys.Q] = keyboardNames.Q,
            [DeviceKeys.W] = keyboardNames.W,
            [DeviceKeys.E] = keyboardNames.E,
            [DeviceKeys.R] = keyboardNames.R,
            [DeviceKeys.T] = keyboardNames.T,
            [DeviceKeys.Y] = keyboardNames.Y,
            [DeviceKeys.U] = keyboardNames.U,
            [DeviceKeys.I] = keyboardNames.I,
            [DeviceKeys.O] = keyboardNames.O,
            [DeviceKeys.P] = keyboardNames.P,
            [DeviceKeys.OPEN_BRACKET] = keyboardNames.OPEN_BRACKET,
            [DeviceKeys.CLOSE_BRACKET] = keyboardNames.CLOSE_BRACKET,
            [DeviceKeys.BACKSLASH] = keyboardNames.BACKSLASH,
            [DeviceKeys.DELETE] = keyboardNames.KEYBOARD_DELETE,
            [DeviceKeys.END] = keyboardNames.END,
            [DeviceKeys.PAGE_DOWN] = keyboardNames.PAGE_DOWN,
            [DeviceKeys.NUM_SEVEN] = keyboardNames.NUM_SEVEN,
            [DeviceKeys.NUM_EIGHT] = keyboardNames.NUM_EIGHT,
            [DeviceKeys.NUM_NINE] = keyboardNames.NUM_NINE,
            [DeviceKeys.NUM_PLUS] = keyboardNames.NUM_PLUS,
            [DeviceKeys.CAPS_LOCK] = keyboardNames.CAPS_LOCK,
            [DeviceKeys.A] = keyboardNames.A,
            [DeviceKeys.S] = keyboardNames.S,
            [DeviceKeys.D] = keyboardNames.D,
            [DeviceKeys.F] = keyboardNames.F,
            [DeviceKeys.G] = keyboardNames.G,
            [DeviceKeys.H] = keyboardNames.H,
            [DeviceKeys.J] = keyboardNames.J,
            [DeviceKeys.K] = keyboardNames.K,
            [DeviceKeys.L] = keyboardNames.L,
            [DeviceKeys.SEMICOLON] = keyboardNames.SEMICOLON,
            [DeviceKeys.APOSTROPHE] = keyboardNames.APOSTROPHE,
            [DeviceKeys.ENTER] = keyboardNames.ENTER,
            [DeviceKeys.NUM_FOUR] = keyboardNames.NUM_FOUR,
            [DeviceKeys.NUM_FIVE] = keyboardNames.NUM_FIVE,
            [DeviceKeys.NUM_SIX] = keyboardNames.NUM_SIX,
            [DeviceKeys.LEFT_SHIFT] = keyboardNames.LEFT_SHIFT,
            [DeviceKeys.Z] = keyboardNames.Z,
            [DeviceKeys.X] = keyboardNames.X,
            [DeviceKeys.C] = keyboardNames.C,
            [DeviceKeys.V] = keyboardNames.V,
            [DeviceKeys.B] = keyboardNames.B,
            [DeviceKeys.N] = keyboardNames.N,
            [DeviceKeys.M] = keyboardNames.M,
            [DeviceKeys.COMMA] = keyboardNames.COMMA,
            [DeviceKeys.PERIOD] = keyboardNames.PERIOD,
            [DeviceKeys.FORWARD_SLASH] = keyboardNames.FORWARD_SLASH,
            [DeviceKeys.RIGHT_SHIFT] = keyboardNames.RIGHT_SHIFT,
            [DeviceKeys.ARROW_UP] = keyboardNames.ARROW_UP,
            [DeviceKeys.NUM_ONE] = keyboardNames.NUM_ONE,
            [DeviceKeys.NUM_TWO] = keyboardNames.NUM_TWO,
            [DeviceKeys.NUM_THREE] = keyboardNames.NUM_THREE,
            [DeviceKeys.NUM_ENTER] = keyboardNames.NUM_ENTER,
            [DeviceKeys.LEFT_CONTROL] = keyboardNames.LEFT_CONTROL,
            [DeviceKeys.LEFT_WINDOWS] = keyboardNames.LEFT_WINDOWS,
            [DeviceKeys.LEFT_ALT] = keyboardNames.LEFT_ALT,
            [DeviceKeys.SPACE] = keyboardNames.SPACE,
            [DeviceKeys.RIGHT_ALT] = keyboardNames.RIGHT_ALT,
            [DeviceKeys.RIGHT_WINDOWS] = keyboardNames.RIGHT_WINDOWS,
            [DeviceKeys.APPLICATION_SELECT] = keyboardNames.APPLICATION_SELECT,
            [DeviceKeys.RIGHT_CONTROL] = keyboardNames.RIGHT_CONTROL,
            [DeviceKeys.ARROW_LEFT] = keyboardNames.ARROW_LEFT,
            [DeviceKeys.ARROW_DOWN] = keyboardNames.ARROW_DOWN,
            [DeviceKeys.ARROW_RIGHT] = keyboardNames.ARROW_RIGHT,
            [DeviceKeys.NUM_ZERO] = keyboardNames.NUM_ZERO,
            [DeviceKeys.NUM_PERIOD] = keyboardNames.NUM_PERIOD,
            [DeviceKeys.G1] = keyboardNames.G_1,
            [DeviceKeys.G2] = keyboardNames.G_2,
            [DeviceKeys.G3] = keyboardNames.G_3,
            [DeviceKeys.G4] = keyboardNames.G_4,
            [DeviceKeys.G5] = keyboardNames.G_5,
            [DeviceKeys.G6] = keyboardNames.G_6,
            [DeviceKeys.G7] = keyboardNames.G_7,
            [DeviceKeys.G8] = keyboardNames.G_8,
            [DeviceKeys.G9] = keyboardNames.G_9,
            [DeviceKeys.LOGO] = keyboardNames.G_LOGO,
            [DeviceKeys.LOGO2] = keyboardNames.G_BADGE,
        };

        public static readonly Dictionary<DeviceKeys, (DeviceType type, int zone)> PeripheralMap = new Dictionary<DeviceKeys, (DeviceType, int)>()
        {
            [DeviceKeys.Peripheral_Logo] = (DeviceType.Mouse, 1),
            [DeviceKeys.Peripheral_FrontLight] = (DeviceType.Mouse, 0),
            [DeviceKeys.Peripheral_ScrollWheel] = (DeviceType.Mouse, 2),
            [DeviceKeys.MOUSEPADLIGHT1] = (DeviceType.Mousemat, 0)
        };

        public static readonly Dictionary<DeviceKeys, int> HidCodeMap = new Dictionary<DeviceKeys, int>()
        {
            [DeviceKeys.BACKSLASH_UK] = 0x64,
            [DeviceKeys.HASHTAG] = 0x32
        };
    }
}
