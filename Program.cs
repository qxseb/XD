using System;
using System.Windows.Forms;

namespace XD_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 120, "electric");
            Car Volvo = new Car("XC-90");

            Console.WriteLine(Ford.Name);
            Console.WriteLine(Ford.Color);
            Console.WriteLine(Ford.Year);
            Console.WriteLine(Ford.engine_type);
            Ford.fullThrotle();
            Ford.honk();

            Console.WriteLine(Opel.Name);
            Console.WriteLine(Opel.Color);
            Console.WriteLine(Opel.Year);
            Console.WriteLine(Opel.engine_type);
            Opel.fullThrotle();
            Opel.honk();

            bool ok = false;
            while (!ok)
            {
                Console.WriteLine("Enter Volvo's age:");
                try
                {
                    Volvo.Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Volvo age is: " + Volvo.Year);
                    ok = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
