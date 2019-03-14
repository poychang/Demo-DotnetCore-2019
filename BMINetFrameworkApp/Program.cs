using BMILogicLib;
using System;

namespace BMINetFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new BMIModel
            {
                Feet = 5,
                Inche = 11,
                Pounds = 181
            };
            var result = BMILogic.CalBMI(person);
            Console.WriteLine($"Your BMI is: {result}");
        }
    }
}
