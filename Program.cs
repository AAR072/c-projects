using System;

namespace program
{

    class Program
    {
        // Declaring variables
        public static double scale = 0;
        public static double temperature = 0;
        public static double temperatureConversionScale = 0;

        public static double outputTemperature = 0;
        // Function to check the scale of the temp
        public static void checkScale()
        {

            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");
            Console.WriteLine("What is the scale of the input temperature? Enter the number listed before the scale");
            string scaleInput = Console.ReadLine();
            bool correctInput = false;
            if (scaleInput.Equals("1"))
            {
                scale = 1;
                correctInput = true;
                Console.WriteLine("The scale is Celsius");
            }
            if (scaleInput.Equals("2"))
            {
                scale = 2;
                correctInput = true;
                Console.WriteLine("The scale is Fahrenheit");
            }
            if (scaleInput.Equals("3"))
            {
                scale = 3;
                correctInput = true;
                Console.WriteLine("The scale is Kelvin");
            }
            if (!correctInput)
            {
                // Exit Lines
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        // Function to check the temperature
        public static void checkTemperature()
        {
            Console.WriteLine("This is a temperature checker. This may not be 100% accurate. Please write the temperature...");
            string inputTemperature = Console.ReadLine();
            try
            {
                temperature = double.Parse(inputTemperature);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse {inputTemperature}");
                // Exit Lines
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine($"The temperature is {temperature}");
        }
        // Function to check conversion scale
        public static void checkConversionScale()
        {
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");
            Console.WriteLine("What scale do you want the output temperature to be?");
            string inputConversion = Console.ReadLine();
            try
            {
                temperatureConversionScale = double.Parse(inputConversion);
                if (temperatureConversionScale == 1)
                {

                    Console.WriteLine("The scale is Celsius");

                }
                if (temperatureConversionScale == 2)
                {
                    Console.WriteLine("The scale is Fahrenheit");
                }
                if (temperatureConversionScale == 3)
                {
                    Console.WriteLine("The scale is Kelvin");
                }
                if (temperatureConversionScale > 3)
                {
                    Console.WriteLine("Incorrect scale given");
                    // Exit Lines
                    Console.WriteLine("Press any key to close...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse {inputConversion}");
                // Exit Lines
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
                Environment.Exit(0);

            }

        }

        // Function to convert temperature
        public static void convertTemperature()
        {
            if (scale == temperatureConversionScale)
            {
                Console.WriteLine($"The scale was the same! The final temperature is {temperature}");

            }
            // Celsius to Fahrenheit
            else if ((scale == 1) && (temperatureConversionScale == 2))
            {
                outputTemperature = (temperature * 1.8) + 32;
                Console.WriteLine("Celsius to Fahrenheit");
                Console.WriteLine($"The converted temperature is {outputTemperature}");
            }
            // Fahrenheit to Celsius
            else if ((scale == 2) && (temperatureConversionScale == 1))
            {
                Console.WriteLine("Fahrenheit to Celsius");
                outputTemperature = (temperature - 32) * 0.5556;
                Console.WriteLine($"The converted temperature is {outputTemperature}");
            }
            // Celsius to Kelvin
            else if ((scale == 1) && (temperatureConversionScale == 3))
            {
                Console.WriteLine("Celsius to Kelvin");
                outputTemperature = temperature + 273.15;
                Console.WriteLine($"The converted temperature is {outputTemperature}");
            }
            // Fahrenheit to Kelvin
            else if ((scale == 2) && (temperatureConversionScale == 3))
            {
                Console.WriteLine("Fahrenheit to Kelvin");
                outputTemperature = (((temperature - 32) * 5) / 9) + 273.15;
                Console.WriteLine($"The converted temperature is {outputTemperature}");

            }
            // Kelvin to Celsius
            else if ((scale == 3) && (temperatureConversionScale == 1))
            {
                Console.WriteLine("Kelvin to Celsius");
                outputTemperature = temperature - 273.15;
                Console.WriteLine($"The converted temperature is {outputTemperature}");

            }
            // Kelvin to Fahrenheit
            else if ((scale == 3) && (temperatureConversionScale == 2))
            {
                Console.WriteLine("Kelvin to Fahrenheit");
                outputTemperature = (((temperature - 273.15) * 1.8) + 32);
                Console.WriteLine($"The converted temperature is {outputTemperature}");

            }
        }

        static void Main(string[] args)
        {
            bool restartChecker = true;
            string restartInput;
            while (restartChecker)
            {
                checkTemperature();
                checkScale();
                checkConversionScale();
                convertTemperature();
                // Exit question
                Console.WriteLine("Do you want to restart? Answer with y or n");
                restartInput = Console.ReadLine();

                if (!restartInput.Equals("y"))
                {
                    restartChecker = false;

                }
            }
            // Exit Lines
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

        }
    }
}
// Help me this is stressfull : AA
