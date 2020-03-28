using System;

namespace MethodsSimple
{
    class MethodsSimple
    {
        static void Main(string[] args)
        {

            // EXAMPLE 1:
            Console.WriteLine("Example 1 Output:");
            DoStuff();

            // EXAMPLE 2:
            Console.WriteLine("Example 2 Output:");
            Console.WriteLine(Multiply(3, 5));
            
            // EXAMPLE 3:
            Console.WriteLine("Example 3 Output:");
            Console.WriteLine(Min(50, 100));

            Console.ReadLine();
        }

        /* Method notes:
         * Methods created in the same class as the Main method should have public or private in front of it
         * Methods created in the same class as the Main method need to have static after public/private
         */

        // EXAMPLE 1:
        public static void DoStuff()
        // Method called DoStuff is not returning anything (void) and doesn't take in any parameters
        {
            Console.WriteLine("I'm doing something");
            // the WriteLine action isn't the same as returning something so that's why it's a void method that doesn't need a return statement
        }
        
        // EXAMPLE 2:
        public static int Multiply(int a, int b)
        // Method called Multiply is going to take in two int parameters and return an int
        {
            return a * b;
        }

        // EXAMPLE 3:
        public static int Min(int a, int b)
        // Method called Min is going to take in two int parameters and return an int
        {
            if (a < b)
                return a;
            else
                return b;
        }
        // this will return the smaller/minimum int of two ints


        /*  REFERENCES:  
        https://www.learncs.org/en/Methods
        https://csharp.net-tutorials.com/basics/functions/
        https://www.w3schools.in/csharp-tutorial/methods/
        */
    }
}
