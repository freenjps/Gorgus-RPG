using System;

namespace GorgusRPG
{
    public class Enemy
    {
        public string Name;
        public int HP;
        public int Damage;
        public int Defense;
        public EnemyType Role;

        public Enemy(string name, int hp, int damage, int defense, EnemyType role)
        {
            Name = name;
            HP = hp;
            Damage = damage;
            Defense = defense;
            Role = role;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Enemy: {Name} ({Role})");
            Console.WriteLine($" - HP: {HP}");
            Console.WriteLine($" - DMG: {Damage}");
            Console.WriteLine($" - DEF: {Defense}");
        }
    }
}