﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameNET20
{
    internal static class UI
    {
        internal static ConsoleKey GetKey()
        {
            return Console.ReadKey(intercept: true).Key;
        }

        internal static void Clear()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
        }
    }
}
