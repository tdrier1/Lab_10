using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            Console.WriteLine("Welcome to the Movie List Application!");

            Console.WriteLine("\nThere are 10 movies in this list.");

            List<Movie> MovieList = new List<Movie>();

            MovieList.Add(new Movie("Interteller", "scifi"));
            MovieList.Add(new Movie("Batman: Returns", "drama"));
            MovieList.Add(new Movie("South Park", "animated"));
            MovieList.Add(new Movie("A Walk to Remember", "drama"));
            MovieList.Add(new Movie("2001: A Space Oddessy", "scifi"));
            MovieList.Add(new Movie("Schindler's List", "drama"));
            MovieList.Add(new Movie("Toy Story", "animated"));
            MovieList.Add(new Movie("Friday the 13th", "horror"));
            MovieList.Add(new Movie("Forrest Gump", "drama"));

            do
            {
                Console.WriteLine("\nWhat movie are you interested in? ");
                string input = Validation.InputVerify();

                foreach (Movie item in MovieList)
                {
                    if (input == item.CategoryProp)
                    {
                        Console.WriteLine(item.TitleProp);
                    }
                }

               run = Validation.Continue();

            } while (run == true);
        }
    }
}
