using System;

namespace ConsoleGameNET20
{
    internal class Game
    {
        private Map map;
        private Hero hero;
        internal void Run()
        {
            Initializer();
            Play();

        }

        private void Play()
        {
            
        }

        private void Initializer()
        {
            // ToDo: Read from config
            map = new Map(width: 10, height: 10);
            hero = new Hero();
        }
    }
}