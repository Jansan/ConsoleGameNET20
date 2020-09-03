using System;

namespace ConsoleGameNET20
{
    public interface ICreature
    {
        ConsoleColor Color { get; set; }
        string Symbol { get; }
    }
}