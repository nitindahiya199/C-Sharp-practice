using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Classes_practice_day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "OldsMobile";
            myCar.Model = "Thar";
            myCar.Year = 1986;
            myCar.Color = "Black";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            //   decimal value = DetermineValue(myCar);
            //   Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetermineValue());

            Console.ReadLine();
        }

        private static decimal DetermineValue(Car car)
        {
            decimal carValue = 100.0M;
            return carValue;

        }


    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineValue()
        {


            decimal carValue;

            if (Year > 1990)

                carValue = 10000;
            else
                carValue = 2000;
            return carValue;

        }


    }
}
