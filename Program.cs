using System;

namespace program // Note: actual namespace depends on the project name.
{

    class Program
    {
        public static int scale = 0;
        public static int temprature = 0;
        public static void checkScale()
        {

            Console.WriteLine("1. Celcius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");
            Console.WriteLine("What is the scale of the input temprature? Enter the number listed before the scale");
            string scaleInput = Console.ReadLine();
            if (scaleInput.Equals("1"))
            {
                scale = 1;
                Console.WriteLine("The scale is 1");
            }
            if (scaleInput.Equals("2"))
            {
                scale = 2;
                Console.WriteLine("The scale is 2");
            }
            if (scaleInput.Equals("3"))
            {
                scale = 3;
                Console.WriteLine("The scale is 3");
            }
        }

        public static void checkTemprature()
        {
            Console.WriteLine("This is a temprature checker. Please write the temprature...");
            string inputTemprature = Console.ReadLine();
            try
            {
                temprature = Int32.Parse(inputTemprature);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse {inputTemprature}");
            }
            Console.WriteLine($"The temprature is {temprature}");
        }




        static void Main(string[] args)
        {

            checkTemprature();
            checkScale();

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

        }
    }
}