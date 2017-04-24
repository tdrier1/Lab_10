using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Validation
    {
        public static int GetIntWithinRange()
        {
            int Min = 1;
            int Max = 4;
            int value;

            while (true)
            {
                if (!Int32.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Please enter a valid number between 1 and 4:");
                }
                else if (value < Min || value > Max)
                {
                    Console.Write("Please enter a valid input year between {0} and {1}: ", Min, Max);
                }
                else
                {
                    break;
                }
            }
            return value;
        }

        public static bool Continue()
        {
            string conf;
            bool check = true;
            bool run = true;

            Console.WriteLine("\n=============================");
            Console.WriteLine("\nWould you like to search again?");
            Console.Write("\nPlease Enter (y/n): ");

            do
            {
                conf = Console.ReadLine();
                var t = conf.ToLower();

                if (t != "y" || t != "n")
                {
                    Console.Write("\nPlease Enter (y/n): ");
                }
                if (t == "y")
                {
                    Console.Clear();
                    check = false;
                }

                if (t == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for visiting!");

                    run = false;
                    check = false;
                }
            } while (check == true);

            return run;
        }

    }
}
