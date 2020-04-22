using System; // EXAMPLE 1
using System.Collections.Generic; // EXAMPLE 2
using System.Text; // EXAMPLE 3

namespace NamespaceExamples
{
    class NamespaceExamples
    {
        static void Main(string[] args)
        {
            // Built-in namespaces contain useful built-in classes, methods, and properties
            // Here are three different built-in namespace examples

            // EXAMPLE 1a: 
            Console.WriteLine("NAMESPACE System; CLASS Console; METHOD SetCursorPosition");

            Console.WriteLine("Hi Class!");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Hi Class!");
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Hi Class!");
            Console.ReadLine();

            /*  DESCRIPTION:
             *  The SetCursorPosition() method is in the Console class and the method requires two positive int parameters
             *  The first parameter sets the cursor position from the left column (columns are numbered from left to right starting at 0)
             *  The second parameter sets the cursor position from the top row (rows are numbered from top to bottom starting at 0)
             */


            // EXAMPLE 1b:
            Console.WriteLine("NAMESPACE System; CLASS Console; METHOD SetWindowSize");
            //Console.WriteLine("Also using two properties: WindowWidth and WindowHeight\n");

            Console.WriteLine($"Default window size before method invoked. Window width: {Console.WindowWidth}. Window height: {Console.WindowHeight}");
            //  WindowWidth and WindowHeight are two properties of the Console class
            Console.ReadLine();
            Console.SetWindowSize(160, 20);
            Console.WriteLine($"Window size after method invoked. Window width: {Console.WindowWidth}. Window height: {Console.WindowHeight}");
            Console.ReadLine();

            /*  DESCRIPTION:
             *  SetWindowSize() is a method in the Console class and the method requires two positive int parameters
             *  The first parameter sets the window size from the left measured in column width (columns are numbered from left to right starting at 0)
             *  The second parameter sets the window size from the top measured in row width (rows are numbered from top to bottom starting at 0)
             */


            // EXAMPLE 1c:
            Console.WriteLine("NAMESPACE System; CLASS Console; METHOD Clear");

            Console.WriteLine("Get ready to see it all disappear!");
            Console.ReadLine();
            Console.Clear();

            // DESCRIPTION: The Clear method will clear all of the preceding output in the Console window


            Console.WriteLine("NAMESPACE System; CLASS Console; METHOD Beep");

            Console.WriteLine("PRESS ENTER TO HEAR 3 BEEPS (make sure audio is on)");
            Console.ReadLine();
            Console.Beep();
            Console.Beep();
            Console.Beep();

            // DESCRIPTION: Console.Beep() will play a beep sound through the speakers associated with the console window


            Console.WriteLine("NAMESPACE System; CLASS Math; METHOD Max");

            var a = 5;
            var b = 10;
            var c = Math.Max(a, b);
            Console.WriteLine($"The largest number of {a} and {b} is {c}.");
            Console.ReadLine();

            // DESCRIPTION: Math.Max() takes in two number parameters and returns the larger number


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // EXAMPLE 2a: 
            Console.WriteLine("NAMESPACE System.Collections.Generic; CLASS Dictionary; METHOD Add");
            Console.WriteLine("(also using two properties: Key and Value)");

            Dictionary<string, int> Numbers = new Dictionary<string, int>() {{"One", 1}, {"Two", 2}};
            // Creating a new Dictionary called "Numbers" that takes a string as a key and an int as the key's value and populating it with two elements

            Console.WriteLine("Printing out the contents of the dictionary:");
            foreach (KeyValuePair<string, int> item in Numbers)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Numbers.Add("Three", 3);
            Console.WriteLine("Adding a new key/value element and printing out the contents of the dictionary:");
            
            foreach (KeyValuePair<string, int> item in Numbers)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.ReadLine();

            // DESCRIPTION: Dictionary.Add() takes two parameters (a key and a value) to add the key/value element to an existing dictionary


            // EXAMPLE 2b: 
            Console.WriteLine("NAMESPACE System.Collections.Generic; CLASS Dictionary; METHOD ContainsKey");

            Console.WriteLine("Contains key On:");
            Console.WriteLine(Numbers.ContainsKey("On"));

            Console.WriteLine("Contains key One:");
            Console.WriteLine(Numbers.ContainsKey("One"));
            Console.ReadLine();

            // DESCRIPTION: Dictionary.ContainsKey() tests if a key exists or not and returns True or False


            // EXAMPLE 2c: 
            Console.WriteLine("NAMESPACE System.Collections.Generic; CLASS Dictionary; METHOD ContainsValue");

            Console.WriteLine("Contains value 1:");
            Console.WriteLine(Numbers.ContainsValue(1));

            Console.WriteLine("Contains value 10:");
            Console.WriteLine(Numbers.ContainsValue(10));
            Console.ReadLine();

            // DESCRIPTION: Dictionary.ContainsValue() tests if a value exists or not and returns True or False


            // EXAMPLE 2d: 
            Console.WriteLine("NAMESPACE System.Collections.Generic; CLASS Dictionary; METHOD Remove");

            Console.WriteLine("Removing One:");
            Console.WriteLine(Numbers.Remove("One"));

            Console.WriteLine("Printing out the contents of the dictionary:");
            foreach (KeyValuePair<string, int> item in Numbers)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.ReadLine();

            // DESCRIPTION: Dictionary.Remove() is used to remove a key and its associated value 
            // Returns True if element is found and removed; otherwise returns False


            // EXAMPLE 2e: 
            Console.WriteLine("NAMESPACE System.Collections.Generic; CLASS Dictionary; METHOD Clear");
            Console.WriteLine("(also using Count property)");
            Console.WriteLine($"Number of key/value pairs in the dictionary: {Numbers.Count}");

            Numbers.Clear();
            Console.WriteLine($"Number of key/value pairs in the dictionary: {Numbers.Count}");
            Console.ReadLine();

            // DESCRIPTION: Dictionary.Clear() resets the count to 0 and all elements are released; the capacity the dictionary can hold remains unchanged


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // EXAMPLE 3a: 
            Console.WriteLine("NAMESPACE System.Text; CLASS StringBuilder; METHOD Append");

            /* 
			StringBuilder Summary:
			A string object is immutable meaning it cannot be changed once created. Every time you use any of the methods
			in the System.String class, you create a new string object in memory.
			In situations where you need to perform repeated modifications to a string, use the StringBuilder class instead. 
			StringBuilder is a dynamic object. It doesn’t create a new object in the memory but dynamically expands the 
			needed memory to accommodate the modified.
			*/

            StringBuilder mmmbop = new StringBuilder("Mmmbop, ba duba dop, ");
            Console.WriteLine("New object called mmmbop contains these song lyrics:");
            Console.WriteLine(mmmbop);

            mmmbop.Append("Ba du bop, ba duba dop, ");
            mmmbop.Append("Ba du bop, ba duba dop, ");
            mmmbop.Append("Ba du, yeah-e-yeah. ");
            Console.WriteLine("Appended these new strings to mmmbop:");
            Console.WriteLine(mmmbop);
            Console.ReadLine();

            // DESCRIPTION: Append() adds a string to the end of a StringBuilder object


            // EXAMPLE 3b: 
            Console.WriteLine("NAMESPACE System.Text; CLASS StringBuilder; METHOD Insert");

            mmmbop.Insert(0, "HANSON: ");
            Console.WriteLine("Inserted the name of the band:");
            Console.WriteLine(mmmbop);
            Console.ReadLine();

            // DESCRIPTION: Insert() inserts a string at a specified index position in a StringBuilder object


            // EXAMPLE 3c: 
            Console.WriteLine("NAMESPACE System.Text; CLASS StringBuilder; METHOD Replace");

            mmmbop.Replace("HANSON: ", "N*SYNC: ");
            Console.WriteLine("Replaced the name of the band:");
            Console.WriteLine(mmmbop);
            Console.ReadLine();

            // DESCRIPTION: Replace() replaces existing characters in a StringBuilder object with new characters


            // EXAMPLE 3d: 
            Console.WriteLine("NAMESPACE System.Text; CLASS StringBuilder; METHOD Remove");

            mmmbop.Remove(0, 8);
            Console.WriteLine("Removed the first 8 characters of the string:");
            Console.WriteLine(mmmbop);
            Console.ReadLine();

            // DESCRIPTION: Remove() removes a specified number of characters in a StringBuilder object
            // The removing process begins at a specified index and extends up to another specified index


            // EXAMPLE 3e: 
            Console.WriteLine("NAMESPACE System.Text; CLASS StringBuilder; METHOD Clear");
            Console.WriteLine("(also using Length property)");

            Console.WriteLine($"Length of mmmbop object before clear: {mmmbop.Length}");
            mmmbop.Clear();
            Console.WriteLine($"Length of mmmbop object after clear: {mmmbop.Length}");
            Console.ReadLine();

            // DESCRIPTION: Clear() removes all the characters in the StringBuilder object and sets the length to 0




            /*
			REFERENCES:

			https://www.geeksforgeeks.org/console-clear-method-in-c-sharp/
			https://docs.microsoft.com/en-us/dotnet/api/system.console.beep?view=netframework-4.8
			https://www.geeksforgeeks.org/console-setcursorposition-method-in-c-sharp/
			https://www.geeksforgeeks.org/console-setwindowsize-method-in-c-sharp/
			https://www.dotnetperls.com/math-max

			https://www.tutorialsteacher.com/csharp/csharp-dictionary
			https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.containskey?view=netframework-4.8
			https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.containsvalue?view=netframework-4.8
			https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.remove?view=netframework-4.8
			https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.clear?view=netframework-4.8

			https://www.geeksforgeeks.org/stringbuilder-in-c-sharp/
			https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=netframework-4.8
			https://www.google.com/search?q=mmmbop+lyrics&oq=mmmbop&aqs=chrome.1.69i57j0l7.1910j0j7&sourceid=chrome&ie=UTF-8
			*/
        }
    }
}
