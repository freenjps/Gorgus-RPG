using System;

namespace GorgusRPG
{
    public class Item
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public string Rarity { get; private set; }
        public string Type { get; private set; } // ex: Weapon, Armor, Potion

        public Item(string name, int value, string rarity, string type)
        {
            Name = name;
            Value = value;
            Rarity = rarity;
            Type = type;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} | {Type} | {Rarity} | Value: {Value}g");
        }
    }
}