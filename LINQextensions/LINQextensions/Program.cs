using System;
using System.Linq;

namespace LINQextensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //FitstorDeffault
            //Any
            //All
            string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
                            "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            Console.WriteLine("DefaultLinq:");

            Console.WriteLine(cars.FirstOrDefault());
            Console.WriteLine(cars.FirstOrDefault(c => c.Contains("Ж")));
            TrueOrFalsePrint(cars.Any());
            TrueOrFalsePrint(cars.Any(c => c.Contains("Audi")));
            TrueOrFalsePrint(cars.Any(c => c.Contains("33333333333")));
            TrueOrFalsePrint(cars.All(c => c.Contains("Toyota")));
            TrueOrFalsePrint(cars.All(c => char.IsUpper(c[0])));

            Console.WriteLine("\nMyLinq:");

            Console.WriteLine(cars.FirstOrDefaultMy());
            Console.WriteLine(cars.FirstOrDefaultMy(c => c.Contains("Ж")));
            TrueOrFalsePrint(cars.AnyMy());
            TrueOrFalsePrint(cars.AnyMy(c => c.Contains("Audi")));
            TrueOrFalsePrint(cars.AnyMy(c => c.Contains("33333333333")));
            TrueOrFalsePrint(cars.AllMy(c => c.Contains("Toyota")));
            TrueOrFalsePrint(cars.AllMy(c => char.IsUpper(c[0])));

            Console.Read();
        }

        public static void TrueOrFalsePrint(bool trueOrFalse)
        {
            if (trueOrFalse)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
           
    }
}
