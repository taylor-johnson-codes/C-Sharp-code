using System;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            // For loop example 1
            Console.WriteLine("For loop example 1:");

            for (int x = 0; x <= 5; x++)      
            {
                Console.WriteLine("Taylor");
            }
            /*
            TIP: type "for" and hit tab twice for code snippet
            First parameter: declaring and initializing the int variable x to zero
            Second parameter: while x is less than or equal to 5 keep running the loop
            Third parameter: adds 1 to the value of x during each iteration until x gets to 5
            Code body: keeps printing out "Taylor" until the value of x is 5 then the loop stops
            */


            // For loop example 2
            Console.WriteLine("For loop example 2:");

            for (int y = 0; y >= 0; y++)
            {
                Console.WriteLine("Johnson");
                break;
            }
            /*
            First parameter: declaring and initializing the int variable y to zero
            Second parameter: while y is greater than or equal to 0 run the loop
            Third parameter: adds 1 to the value of y during each iteration and will never stop without a break statement
            Code body: would keep printing out "Johnson" indefinitely if there wasn't a break statement
            */


            // While loop example 1
            Console.WriteLine("While loop example 1:");

            int z = 0;                          // declaring and initializing the int variable z to zero so we can use it in the loop
            while (z <= 5)                      // while the value of z is less than or equal to 5 execute the code body
            {
                Console.WriteLine("Macaroni");  // keeps printing out "Macaroni" until the value of z is 5
                z++;                            // this adds 1 to the value of z during each iteration until z is 5
            }                                   // TIP: type "while" and hit tab twice for code snippet


            // While loop example 2
            Console.WriteLine("While loop example 2:");

            while (5 == 5)                          // while the parameter (5==5) is true execute the code body
            {
                Console.WriteLine("This is true");  // this executes because the parameter is true; if it was false, nothing would execute
                break;                              // since 5==5 is always true, the while loop will run indefinitely without the break statement to stop it
            }

            Console.ReadLine();


            /*
            REFERENCE:
            https://www.geeksforgeeks.org/loops-in-c-sharp/
            */
        }
    }
}
