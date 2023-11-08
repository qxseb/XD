using System;
using System.Windows.Forms;

namespace XD_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 120);

            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
            Ford.fullThrotle();
            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Opel.maxSpeed);

            Opel.fullThrotle();
            Console.ReadKey();
        }
    }
}
