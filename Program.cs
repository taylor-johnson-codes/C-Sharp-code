using System;

namespace Assignment___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // EXAMPLE 1

            string[] cars = { "Ford", "Ferrari", "Honda", "BMW" };
            // I created a new array that can contain string values.  
            // I called the new array "cars".  
            // I populated the new "cars" array with four values.
            // Arrays start at position 0 (zero).

            Console.WriteLine(cars[0]);  // outputting array position 0
            Console.WriteLine(cars[1]);  // outputting array position 1
            Console.WriteLine(cars[2]);  // outputting array position 2
            Console.WriteLine(cars[3]);  // outputting array position 3
            
            
            // EXAMPLE 2

            int[] numbers = { 10, 20, 30, 40, 50 };
            // I created a new array that can contain integer values.  
            // I called the new array "numbers".  
            // I populated the new "numbers" array with five values.
            
            foreach (int number in numbers)  // for each integer "number" in the array called "numbers"...
            {
                Console.WriteLine(number);  // output that number
            }

            Console.ReadLine();

            
            /* 
            REFERENCES:
            https://www.w3schools.com/cs/cs_arrays.asp
            https://www.geeksforgeeks.org/c-sharp-arrays/
            */
        }
    }
}
