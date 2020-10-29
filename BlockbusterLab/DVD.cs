using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int Runtime, List<string> Scenes) : base(Title, Category, Runtime, Scenes)
        {

        }
        public override void Play()
        {
            while (true)
            {
                Console.WriteLine("What scene would you like to watch?");
                Console.WriteLine();

                PrintScenes();

                string userInput = Console.ReadLine();
                Console.WriteLine();

                int selection = int.Parse(userInput);

                int num = selection - 1;

                Console.WriteLine(Scenes[num]);

                Console.WriteLine("Do you want to watch another scene? y/n");
                Console.WriteLine();

                userInput = Console.ReadLine();

                if (userInput == "y")
                {
                    continue;
                }
                else if (userInput == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine($"No problem. Please enjoy the rest of your evening.");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid entry. Please enter either 'y' or 'n'.");
                }
            }
        }
    }
}
