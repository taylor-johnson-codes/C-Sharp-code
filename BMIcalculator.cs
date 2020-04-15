using System;

namespace BMIcalculator
{
    class BMIcalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height in inches: ");
            string heightstr = Console.ReadLine();  // assigning the user's answer to the "heightstr" variable
            Console.WriteLine("Enter your weight in pounds: ");
            string weightstr = Console.ReadLine();  // assigning the user's answer to the "weightstr" variable
            // NOTE: all user input is received as a string data type

            double heightdbl = Convert.ToDouble(heightstr);
            double weightdbl = Convert.ToDouble(weightstr);
            // converting the string data type to a double data type so we can use them for math calculations

            // testing to see if the code above works:
            Console.WriteLine("Your height is: {0} inches", heightdbl);
            Console.WriteLine("Your weight is: {0} pounds", weightdbl);

            double BMI = (weightdbl * 703) / (heightdbl * heightdbl);
            Console.WriteLine($"Your Body Mass Index calculated to: {BMI}");
            // NOTE: the $ character in front of a string allows you to insert a variable value inside of the string with curly braces

            if (BMI < 0)
            {
                Console.WriteLine("An error occurred");
            }
            
            else if (BMI > 0 && BMI < 16)
            {
                Console.WriteLine("You have Severe Thinness");
            }

            else if (BMI >= 16 && BMI < 17)
            {
                Console.WriteLine("You have Moderate Thinness");
            }

            else if (BMI >= 17 && BMI < 18.5)
            {
                Console.WriteLine("You have Mild Thinness");
            }

            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("You are Normal Weight");
            }

            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("You are Overweight");
            }

            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("You are Obese Class 1");
            }

            else if (BMI >= 35 && BMI < 40)
            {
                Console.WriteLine("You are Obese Class 2");
            }

            else if (BMI >= 40)
            {
                Console.WriteLine("You are Obese Class 3");
            }

            else
            {
                Console.WriteLine("An error occurred");
            }

            Console.ReadLine();
        }
    }
}
