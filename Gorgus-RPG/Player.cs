using System;

namespace GorgusRPG
{ //// Getter Setter:: Look up to tweak this file
    public class Player
    {
        public string Name;
        public CharacterClass ClassType;
        public int HP;
        public int Attack;
        public int Defense;
        public int Speed;

        public Player(string name, CharacterClass classType, int hp, int atk, int def, int spd)
        {
            Name = name;
            ClassType = classType;
            HP = hp;
            Attack = atk;
            Defense = def;
            Speed = spd;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {ClassType}");
            Console.WriteLine($"HP: {HP}, Attack: {Attack}, Defense: {Defense}, Speed: {Speed}");
        }
    }
}