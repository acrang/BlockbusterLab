using System;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster bb = new Blockbuster();

            Console.WriteLine("Welcome to Alex's Blockbuster Video!");
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();

            Movie m = bb.Checkout();

            Console.WriteLine();
            Console.WriteLine("You selected: ");
            Console.WriteLine();

            m.PrintInfo();
            Console.WriteLine($"Do you want to watch { m.Title}? y/n");


            while (true)
            {
                string userInput = Console.ReadLine();
                Console.WriteLine();

                if (userInput == "y")
                {
                    m.Play();
                    break;
                }
                else if (userInput == "n")
                {
                    Console.WriteLine("No problem. Please enjoy doing something else.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter either 'y' or 'n'.");
                    continue;
                }
            }
        }
    }
}
