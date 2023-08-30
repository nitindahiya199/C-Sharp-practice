using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_first_project
{
    internal class Program
    {
        static void Hii()
        {
            Console.WriteLine("Write Your Name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hii {name}");
        }

        static float Sum1(int a, int b)
        {
            float add = a + b;
            return add;
        }
        static float Sub(int a = 10, int b = 8)
        {
            float sub = a - b;
            return sub;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hey Enter Your Name");
            //string name = Console.ReadLine();
            // Console.WriteLine("Hello " + name);
            // 
            // Console.WriteLine("So " + name + " How many candies do you want?");
            // string candy = Console.ReadLine();            
            // Console.WriteLine("You will get 4 more candies..so total candies are " + (Convert.ToInt32(candy) + 4));
            // Console.WriteLine("Have a wonderfun day");
            // Console.ReadLine();



            // string name = Console.ReadLine();
            // string good = Console.ReadLine();
            // Console.WriteLine($"your name is {name} and it is very {good} name");
            // Console.ReadLine();



            // Console.WriteLine("Enter Your Age");
            // string age = Console.ReadLine();
            // int car = Convert.ToInt32(age);
            // if (car >= 18) {
            //     Console.WriteLine("You can drive this car");
            // }
            // else
            // {
            //     Console.WriteLine($"You cannot drive this car..comeback in {18 - car}");
            // }
            // Console.ReadLine();

            // Hii();
            // Console.ReadLine();

            // Console.WriteLine(Sum1(1, 2));
            // Console.ReadLine();

            // Console.WriteLine(Sub());
            // Console.ReadLine();
        
        }
    }
}
