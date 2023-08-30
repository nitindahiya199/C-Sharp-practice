using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }


        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Lets Do Something");
            Console.WriteLine("2) Play Game");
            Console.WriteLine("Press Enter To Exit !!");
            string rslt = Console.ReadLine();

            if (rslt == "1")
            {
                RandomNum();
                return true;
            }

            else if (rslt == "2")
            {
                RandomGame();
                return true;
            }

            else
            {
                return false;
            }

        }

        private static void RandomNum()
        {
            Console.Clear();
            Console.WriteLine("Enter Any Number");
            Console.Write("Type your number Here: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write(" - ");
                counter++;
            }
            Console.ReadLine();
        }

        private static void RandomGame()
        {
            Console.Clear();
            Random RandomNum = new Random();
            int randomNumber = RandomNum.Next(1, 11);

            int gusses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess the Number Between 1 to 10");
                Console.Write("Enter your Number: ");
                string result = Console.ReadLine();
                gusses++;
                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            } while (incorrect );
            
            Console.WriteLine("Correct! It Took You {0} guesses.", gusses);
            
            Console.ReadLine();
        }

    }
}
