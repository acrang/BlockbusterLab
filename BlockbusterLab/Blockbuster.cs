using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster()
        {
            List<string> scenes1 = new List<string>();
            scenes1.Add("Waking up from hypersleep");
            scenes1.Add("Stalked by an unknown being");
            scenes1.Add("She escapes!...or did she?");
            VHS v1 = new VHS("Alien", Genre.Horror, 117, scenes1);

            Movies.Add(v1);

            List<string> scenes2 = new List<string>();
            scenes2.Add("What an uncool guy");
            scenes2.Add("Vote for Pedro");
            scenes2.Add("Now the coolest guy around");
            VHS v2 = new VHS("Napoleon Dynamite", Genre.Comedy, 96, scenes2);

            Movies.Add(v2);

            List<string> scenes3 = new List<string>();
            scenes3.Add("An innocent Christmas party");
            scenes3.Add("Crawling through air vents and elevator shafts");
            scenes3.Add("Limo departure");
            VHS v3 = new VHS("Die Hard", Genre.Action, 132, scenes3);

            Movies.Add(v3);

            List<string> scenes4 = new List<string>();
            scenes4.Add("Kids exploring abandoned buildings");
            scenes4.Add("Narrowly avoiding ancient deathtraps");
            scenes4.Add("Escaping and saving the day");
            DVD d1 = new DVD("The Goonies", Genre.Comedy, 114, scenes4);

            Movies.Add(d1);

            List<string> scenes5 = new List<string>();
            scenes5.Add("Wandering out into the creepy woods");
            scenes5.Add("Spooky stuff starts happening");
            scenes5.Add("What are you doing standing in the corner?");
            DVD d2 = new DVD("The Blair Witch Project", Genre.Horror, 81, scenes5);

            Movies.Add(d2);

            List<string> scenes6 = new List<string>();
            scenes6.Add("Washed up and longing for days gone by");
            scenes6.Add("A chance for redemption");
            scenes6.Add("Leading the team to victory");
            DVD d3 = new DVD("The Bad News Bears", Genre.Comedy, 102, scenes6);

            Movies.Add(d3);
        }

        public void PrintMovieTitles()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                int num = i + 1;
                Movie m = Movies[i];
                Console.WriteLine(num + ": " + m.Title);
            }
        }

        public Movie Checkout()
        {
            Console.WriteLine("Please select a movie from the following list:");
            Console.WriteLine();

            PrintMovieTitles();
            string input = Console.ReadLine();
            int index = int.Parse(input);
            int num = index - 1;

            Movie output = Movies[num];

            return output;
        }
    }
}
