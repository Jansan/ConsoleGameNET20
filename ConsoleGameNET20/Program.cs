using System;

namespace ConsoleGameNET20
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();

            Console.WriteLine("Thank you for playing.");
            Console.ReadKey();
        }
    }
}
