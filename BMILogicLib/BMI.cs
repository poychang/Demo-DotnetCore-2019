using System;

namespace BMILogicLib
{
    public class BMIModel
    {
        public int Feet { get; set; }
        public int Inche { get; set; }
        public int Pounds { get; set; }
    }

    public class BMILogic
    {
        public static double CalBMI(BMIModel data)
        {
            // The imperial BMI formula = Weight (LBS) x 703 ÷ Height (Inches²)
            return data.Pounds * 703 / Math.Pow(((data.Feet * 12) + data.Inche), 2);
        }
    }
}
