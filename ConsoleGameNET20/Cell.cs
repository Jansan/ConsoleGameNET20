using System.Collections.Generic;

namespace ConsoleGameNET20
{
    public class Cell
    {
        public List<Item> items  { get; set; } = new List<Item>();
        public string Symbol => ". ";

        public Cell()
        {

        }


    }
}