using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_2023
{
    public class Car : Vehicle
    {
        private string color;
        private string name;
        private int maxSpeed;
        private int year;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1980)
                {
                    throw new Exception("Please pass a correct value!");
                } else 
                {
                    year = value;
                }
            }
        }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
        }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue, string eng_type)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
            engine_type = eng_type;
        }

        public Car(string nameName)
        {
            name = nameName;
        }

        public void fullThrotle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }
    }
}
