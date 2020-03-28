using System;

namespace ArraysMultidimensional
{
    class ArraysMultidimensional
    {
        static void Main(string[] args)
        {

            // EXAMPLE 1

            // creating a new two-dimensional (2D) array
            // it's a 3x2 array meaning it has three separate arrays each containing two elements
            int[,] numbers2D = new int[3, 2] { { 22, 33 }, { 44, 55 }, { 66, 77 } };

            for (int i = 0; i < 3; i++)  // iterating through each of the three arrays
            {
                for (int d = 0; d < 2; d++)  // iterating through each of the elements in the array
                {
                    Console.WriteLine(numbers2D[i, d]);  // outputs each value of each index position of each of the three arrays
                }
            }


            // EXAMPLE 2

            // creating a new three-dimensional (3D) array
            // it's a 3x3 array meaning it has three separate arrays each containing three elements
            int[,] numbers3D = new int[3, 3] { { 11, 22, 33 }, { 44, 55, 66 }, { 77, 88, 99 } };

            for (int a = 0; a < 3; a++)  // iterating through each of the three arrays
            {
                for (int b = 0; b < 3; b++)  // iterating through each of the elements in the array
                {
                    Console.WriteLine("numbers3D [{0},{1}] = {2}", a, b, numbers3D[a, b]);
                    // outputs the name of the array and the value of each index position in the array
                }
            }
            Console.ReadLine();


            /*
            REFERENCES:
            https://www.tutorialspoint.com/csharp/csharp_multi_dimensional_arrays.htm
            https://www.tutorialsteacher.com/csharp/csharp-class
            */
        }
    }
}
