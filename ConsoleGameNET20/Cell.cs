using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleGameNET20
{
    public class Cell : IDrawable
    {
        public int X { get; }
        public int Y { get; }
        public List<Item> Items  { get;  } = new List<Item>();
        public string Symbol => ". ";

        public ConsoleColor Color { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            Color = ConsoleColor.Red;
        }


    }
}