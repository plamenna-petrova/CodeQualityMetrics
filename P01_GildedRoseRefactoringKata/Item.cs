using System;
using System.Collections.Generic;
using System.Text;

namespace P01_GildedRoseRefactoringKata
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public Item()
        {

        }

        public Item(string name, int sellIn, int quality) 
            : base()
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public override string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }
    }
}
