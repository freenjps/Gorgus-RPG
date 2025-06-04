using System;
using System.Collections.Generic;

namespace GorgusRPG
{
    public class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        // Add an item to the inventory
        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"Added: {item.Name}");
        }

        // Remove an item by name
        public void RemoveItem(string itemName)
        {
            Item itemToRemove = items.Find(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
                Console.WriteLine($"Removed: {itemToRemove.Name}");
            }
            else
            {
                Console.WriteLine($"Item '{itemName}' not found.");
            }
        }

        // Print the inventory
        public void ShowInventory()
        {
            Console.WriteLine("===== Player Inventory =====");

            if (items.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            for (int i = 0; i < items.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                items[i].ShowInfo();
            }
        }

        // Check inventory size (under constuction, probably for future use)
        public int Count => items.Count;
    }
}