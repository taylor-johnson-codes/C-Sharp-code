using System;

namespace TryCatchFinally
{
    class TryCatchFinally
    {
        static void Main(string[] args)
        {
            // EXAMPLE 1
            Console.WriteLine("EXAMPLE 1:");

            try  // program will first try the code within the try block
            {
                int[] myNumbers = { 1, 2, 3 };  // created a new array of ints in index positions 0, 1, and 2
                Console.WriteLine(myNumbers[9]);
                Console.ReadLine();
                // trying to output index position 9 which doesn't exist in the array
                // if we don't have the following catch block, the program will crash
            }

            catch
            // if the code block above didn't produce an error, this catch block would be skipped
            // since the code block above does produce an error, the catch block will execute
            {
                Console.WriteLine("Something went wrong.");
            }

            finally  
            // this code will execute whether an error occurred or not
            // the finally block is optional
            {
                Console.WriteLine("The program will close down now.");
            }


            // EXAMPLE 2
            Console.WriteLine("EXAMPLE 2:");

            try  // TIP: typing "try" and hitting tab twice will insert a code snippet
            {
                int a = 2;
                int b = 0;
                Console.WriteLine(a/b);
                // without the catch block, the program will crash because you can't divide by zero
            }

            catch (Exception e)
            // using the built-in Exception parameter will have the system give you more info about the error
            // "e" is a variable to use in the code block; you can pick any variable you want
            {
                Console.WriteLine(e);
                // TIP: using the e.Message property will give you a shorter version of the same error message
            }

            finally
            {
                Console.WriteLine("The program will close down now.");
            }
            
            Console.ReadLine();



            /* REFERENCES:
            https://www.w3schools.com/cs/cs_exceptions.asp
            https://www.tutlane.com/tutorial/csharp/try-catch-in-csharp
            https://www.youtube.com/watch?v=ZJRg8nrNeeA
            */
        }
    }
}
