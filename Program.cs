using System;
/// <summary>
/// Author: Paul Madduma
/// </summary>
namespace CreatureMaker
{
    /// <summary>
    /// Program Class - console application
    /// connects with Monster class to configure a creature
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main - user interacts with the console
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to Monster Mix-Match Maker!\n\n");
                Console.WriteLine("Instructions: you have three parts to fill in: head, body and feet\n" +
                    "You have three choices: bug, monster and ghost\n");

                try
                {
                    ConsoleReader();
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine($"Error message: {ex.Message}");
                }

                Console.WriteLine("\nEnter X to stop playing:");
                string fin = Console.ReadLine().ToLower();
                if (fin == "x")
                {
                    isRunning = false;
                }
            }

        } //end of isRunning while loop
        /// <summary>
        /// ConsoleReader where all the user inputs being evaluated
        /// Where a creature has been configured
        /// </summary>
        static void ConsoleReader()
        {
            Console.WriteLine("Enter a head: ");
            string head = Console.ReadLine().ToLower();
            Console.WriteLine("Enter a body: ");
            string body = Console.ReadLine().ToLower();
            Console.WriteLine("Enter a feet: ");
            string feet = Console.ReadLine().ToLower();
            string[] monsterParts = { "bug", "monster", "ghost" };
            Monster monster = new Monster(head, body, feet);
            int headCheck = Array.IndexOf(monsterParts, head);
            int bodyCheck = Array.IndexOf(monsterParts, body);
            int feetCheck = Array.IndexOf(monsterParts, feet);
            string Results = "";
            if (headCheck > -1 && bodyCheck > -1 && feetCheck > -1)
            {
                Results = "WOOOOWOOOWOOOWOOO\nA new freaky creature has been made!";
                Console.WriteLine(Results);
                monster.BuildACreature(head, body, feet);
            }
            else
            {
                Results = "You unsuccessfully build a monster\n but we have CheekyFeet for you as default monster!!!";
                Console.WriteLine(Results);
                monster.BuildACreature();
            }
        }
    }
}
