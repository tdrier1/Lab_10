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
            Console.WriteLine("\n1:scifi\n2:horror\n3:animated\n4:drama");
            
            List<Movie> MovieList = new List<Movie>();

            MovieList.Add(new Movie("Interteller", "scifi", 1));
            MovieList.Add(new Movie("Batman: Returns", "drama", 4));
            MovieList.Add(new Movie("South Park", "animated", 3));
            MovieList.Add(new Movie("A Walk to Remember", "drama", 4));
            MovieList.Add(new Movie("2001: A Space Oddessy", "scifi", 1));
            MovieList.Add(new Movie("Schindler's List", "drama", 4));
            MovieList.Add(new Movie("Toy Story", "animated", 3));
            MovieList.Add(new Movie("Friday the 13th", "horror", 2));
            MovieList.Add(new Movie("Forrest Gump", "drama", 4));

            do
            {
                Console.WriteLine("\nWhat movie category are you interested in? (Please enter 1-4) ");

                int input = Validation.GetIntWithinRange();

                foreach (Movie item in MovieList)
                {
                    if (input == item.NumSelect)
                    {
                        Console.WriteLine("\n"+ item.TitleProp);
                    }
                }

               run = Validation.Continue();

            } while (run == true);
        }
    }
}
