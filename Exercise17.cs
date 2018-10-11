using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = null;
            bool retry = true;

            Greeting(ref userName);
            while (retry)
            {
                Directions(userName);
                UserInput(userName);
                retry = Retry(ref retry, userName);
            }
            Exit(userName);
        }

        public static void Greeting(ref string userName)
        {
            Console.WriteLine("Welcome! Please enter your name: ");
            userName = Console.ReadLine();
        }

        public static void Directions(string userName)
        {
            Console.WriteLine("\n{0}, please press ENTER to display a pyramid of stars.", userName);
        }

        public static void UserInput(string userName)
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                DisplayResults();
            }
            else
            {
                Invalid(userName);
            }
        }

        public static void Math()
        {
            int height = 10;

            for (int i = 0; i <= height; i++)
            {
                int spacer = height * 2;
                if(spacer % 2 == 0)
                {
                    spacer = height * 2 - i - height;
                }
                else if (spacer % 2 == 1)
                {
                    spacer = height * 2 - i - 1;
                }
                string stars = string.Concat(Enumerable.Repeat("* ", i));
                string space = new string(' ', spacer);
                Console.WriteLine(space + stars + space);
            }
        }

        public static void DisplayResults()
        {
            Math();
        }

        public static void Invalid(string userName)
        {
            Console.WriteLine("\nSorry {0}, your entry was invalid...\nPlease press ENTER!", userName);
            UserInput(userName);
        }

        public static Boolean Retry(ref bool retry, string userName)
        {
            Console.WriteLine("\nWould you like to retry, {0}? (y/n)", userName);
            char answer = Console.ReadKey().KeyChar;

            if (answer == 'y' || answer == 'Y')
            {
                retry = true;
            }
            else if (answer == 'n' || answer == 'N')
            {
                retry = false;
            }
            else
            {
                Invalid(userName);
            }
            return retry;
        }

        public static void Exit(string userName)
        {
            Console.WriteLine("\nGoodbye {0}, press ESCAPE to exit", userName);
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.ReadKey();
                continue;
            }
        }
    }
}//October 11, 2018