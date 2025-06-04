using System;

namespace GorgusRPG
{
    public static class Utilities
    {
        // Wait for user key to continue
        public static void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        // Prompt and return a trimmed string
        public static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine()?.Trim() ?? "";
        }

        // Check if input contains at least one letter
        public static bool ContainsLetter(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                    return true;
            }

            return false;
        }

        // Convert a string to an int with basic validation (optional)
        public static int GetPositiveInt(string prompt)
        {
            int value;
            string input;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

            } while (!int.TryParse(input, out value) || value <= 0);

            return value;
        }
    }
}