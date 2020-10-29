using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public VHS(string Title, Genre Category, int Runtime, List<string> Scenes) : base(Title, Category, Runtime, Scenes)
        {

        }
        public override void Play()
        {
            while (true)
            {
                if (CurrentTime < Scenes.Count)
                {
                    string scene = Scenes[CurrentTime];

                    int num = CurrentTime + 1;

                    Console.WriteLine(num + ": " + scene);
                    CurrentTime++;

                    Console.WriteLine("Do you want to watch the next scene?");

                    string userInput = Console.ReadLine();

                    if (userInput == "y")
                    {
                        Console.WriteLine();
                        continue;
                    }
                    else if (userInput == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("All righty. Would you like to rewind? y/n");
                        string input = Console.ReadLine();

                        if (input == "y")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Thank you for being kind!");
                            Console.WriteLine("Bye!");
                            break;
                        }
                        else if (input == "n")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Okay...just don't forget.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid entry. Please enter 'y' or 'n'.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid entry. Please enter either 'y' or 'n'.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("You need to rewind the movie. It's over! Would you like to rewind now? y/n");
                    string userInput = Console.ReadLine();
                    if (userInput == "y")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thank you for being kind!");
                        Console.WriteLine("Bye!");
                        Rewind();
                        break;
                    }
                    else if (userInput == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Okay...just don't forget.");
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

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
