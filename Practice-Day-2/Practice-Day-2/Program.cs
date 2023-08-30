using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Write Your Name...");
            // Console.Write("Enter Your First Name: ");
            // String Fname = Console.ReadLine();
            // Console.Write("Enter Your Last Name: ");
            // String lname = Console.ReadLine();
            // 
            // Console.WriteLine($"Hello, {Fname} {lname}! Welcome to the Dashboard");
            // Console.ReadLine();



            Console.WriteLine("Big Billion Sale..!!");
            Console.Write("Choose door no. 1, 2 oe 3: ");
            String choose = Console.ReadLine();
            
            if (choose == "1")
            {
                Console.WriteLine("Congratulation..You won a car");
            }
            
            else if (choose == "2") {
                Console.WriteLine("You won toilet paper");
            }
            
            else {
                Console.WriteLine("Better Luck Next Time");
            }
            
            Console.WriteLine("Big Billion Sale Finish");
            Console.ReadLine();
        }
    }
}
