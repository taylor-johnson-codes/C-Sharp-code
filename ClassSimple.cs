using System;

namespace ClassSimple
{
    class ClassSimple
    {
        static void Main(string[] args)
        {

            TaylorHasClass TJ = new TaylorHasClass();  // creating a new instance (called TJ) of the TaylorHasClass object
            TJ.Right();  // calling the Right method from TaylorHasClass
            TJ.Wrong();  // calling the Wrong method from TaylorHasClass

            Addition Adding = new Addition();  // creating a new instance (called Adding) of the Addition object
            Console.WriteLine(Adding.Add2(5, 10));  // calling and printing the Add2 method with two test parameters
            Console.ReadLine();
        }
    }
    class TaylorHasClass
    // creating a class called TaylorHasClass
    {
        public void Right()  // creating a method called Right
        {
            Console.WriteLine("You are right!");
            // when the Right method is called, "You are right!" will be printed
        }
        public void Wrong()  // creating a method called Wrong
        {
            Console.WriteLine("You are wrong!");
            // when the Wrong method is called, "You are wrong!" will be printed
        }

        /*
         * Note:
         * The methods are performing an action which is not the same as returning something.
         * Therefore, no return statement is used and the return type of the method before the method's name is void.
         */

    }
    class Addition
    // creating a class called Addition
    {
        public int Add2(int a, int b)  // creating a new method that will add two integer parameters together
        {
            return a + b;  // method will return the sum of the two integer parameters
        }

        /*
         * Note:
         * The method is returning an int data type.
         * Therefore, a return statement is used in the body and the return type of the method before the method's name is int.
         */
    }
}
