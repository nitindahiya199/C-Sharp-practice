using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int[] num = new int[5];
            // num[0] = 1;
            // num[1] = 2;
            // num[2] = 4;
            // num[3] = 8;
            // num[4] = 16;
            // 
            // Console.WriteLine(num[0]);
            // Console.WriteLine(num.Length);
            // Console.ReadLine();



            // int[] num = new int[] { 10, 2, };
            // 
            // for (int i = 0; i < num.Length; i++) {
            //     Console.WriteLine(num[i]);
            // }
            // 
            // foreach (var item in num)
            // {
            //     Console.WriteLine(item);
            // }
            // 
            // Console.WriteLine(num[0]);
            // Console.ReadLine();



            string name = "hey my name is Nitin" + " and i am learning C# ";

            char[] chars = name.ToCharArray();
            Array.Reverse(chars);

            foreach (var item in chars)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
