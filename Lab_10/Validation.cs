using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Validation
    {

        public static string InputVerify()
        {
            bool run = true;
            string input;

            List<string> InputList = new List<string>();

            InputList.Add("horror");
            InputList.Add("scifi");
            InputList.Add("drama");
            InputList.Add("animation");

            do
            {
                input = Console.ReadLine().ToLower();

                    if (InputList.Any(input.Contains))
                    {
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter: horror, animation, drama or scifi!");
                    }

            } while (run == true);

            return input;
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
