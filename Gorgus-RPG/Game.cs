using System;
using GorgusRPG; // Access Player, Inventory, Enemy, Item, Utilities

namespace GorgusRPG
{
    public class Game
    {
        private bool isRunning = true;

        // Core Game Fields
        private Player player;
        private Inventory inventory;

        public void Run()
        {
            Console.Title = "Gorgus RPG";
            inventory = new Inventory();

            while (isRunning)
            {
                ShowMainMenu();
                HandleMainMenuInput();
            }
        }

        private void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("======= Gorgus RPG =======");
            Console.WriteLine("1. Create Player");
            Console.WriteLine("2. View Player Stats");
            Console.WriteLine("3. View Inventory");
            Console.WriteLine("4. View Enemies");
            Console.WriteLine("5. Exit");
            Console.Write("\nChoose an option: ");
        }

        private void HandleMainMenuInput()
        {
            string input = Console.ReadLine()?.Trim();

            switch (input)
            {
                case "1":
                    CreatePlayer();
                    break;
                case "2":
                    ShowPlayerStats();
                    break;
                case "3":
                    Console.Clear();
                    inventory.ShowInventory();
                    Utilities.Pause();
                    break;
                case "4":
                    ShowEnemies();
                    break;
                case "5":
                    isRunning = false;
                    Console.WriteLine("Thanks for playing!");
                    Utilities.Pause();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    Utilities.Pause();
                    break;
            }
        }

        private void CreatePlayer()
        {
            string name = "";
            bool validName = false;

            while (!validName)
            {
                Console.Clear();
                Console.WriteLine("===== Character Creation =====");
                name = Utilities.GetString("Enter your Characters name: ");

                if (string.IsNullOrWhiteSpace(name) || !Utilities.ContainsLetter(name))
                {
                    Console.WriteLine("Name must include at least one letter.");
                    Utilities.Pause();
                }
                else
                {
                    validName = true;
                }
            }

            CharacterClass selectedClass = CharacterClass.Adventurer;
            string classType = "";
            bool validClass = false;

            while (!validClass)
            {
                Console.Clear();
                Console.WriteLine("Choose a class:");
                Console.WriteLine(" - Warrior");
                Console.WriteLine(" - Sorceror");
                Console.WriteLine(" - Assassin");

                classType = Utilities.GetString("\nYour choice: ").ToLower();

                if (!Utilities.ContainsLetter(classType))
                {
                    Console.WriteLine("Invalid class. Please type a class name, not a number.");
                    Utilities.Pause();
                    continue;
                }

                switch (classType)
                {
                    case "warrior":
                        selectedClass = CharacterClass.Warrior;
                        validClass = true;
                        break;
                    case "sorceror":
                        selectedClass = CharacterClass.Sorceror;
                        validClass = true;
                        break;
                    case "assassin":
                        selectedClass = CharacterClass.Assassin;
                        validClass = true;
                        break;
                    default:
                        Console.WriteLine("Invalid class. Please choose Warrior, Sorceror, or Assassin.");
                        Utilities.Pause();
                        break;
                }
            }

            int hp = 0, attack = 0, defense = 0, speed = 0;

            switch (selectedClass)
            {
                case CharacterClass.Warrior:
                    hp = 120; attack = 15; defense = 10; speed = 5;
                    break;
                case CharacterClass.Sorceror:
                    hp = 80; attack = 20; defense = 5; speed = 10;
                    break;
                case CharacterClass.Assassin:
                    hp = 90; attack = 12; defense = 8; speed = 15;
                    break;
                default:
                    hp = 100; attack = 10; defense = 10; speed = 10;
                    break;
            }

            player = new Player(name, selectedClass, hp, attack, defense, speed);
            Console.WriteLine("Player created!");
            Utilities.Pause();
        }

        private void ShowPlayerStats()
        {
            Console.Clear();

            if (player == null)
            {
                Console.WriteLine("No player created yet.");
            }
            else
            {
                player.ShowStats();
            }

            Utilities.Pause();
        }

        private void ShowEnemies()
        {
            Console.Clear();

            Enemy[] enemies = new Enemy[]
            {
                new Enemy("Goblin", 50, 8, 5, EnemyType.Basic),
                new Enemy("Orc", 90, 12, 10, EnemyType.Elite),
                new Enemy("Fire Wyvern", 200, 25, 30, EnemyType.Boss)
            };

            foreach (var enemy in enemies)
            {
                enemy.ShowStats();
                Console.WriteLine();
            }

            Utilities.Pause();
        }
    }
}
