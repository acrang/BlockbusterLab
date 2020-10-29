using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, Genre Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {Runtime} minutes");
            Console.WriteLine();
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                int num = i + 1;
                string scene = Scenes[i];
                Console.WriteLine($"{num}: {scene}");
            }
        }

        public abstract void Play();
    }
}
