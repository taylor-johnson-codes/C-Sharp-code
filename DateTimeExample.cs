using System;

namespace DateTimeExample
{
    class DateTimeExample
    {
        static void Main(string[] args)
        {
            // Example: Adding a specific number of days to a specific date

            Console.Write("Type in the number of a month: ");
            string monthstr = Console.ReadLine();  // assigning the user's answer to the "monthstr" variable
            // NOTE: All user input is received as a string data type
            Console.Write("Type in the number of a day: ");
            string daystr = Console.ReadLine();  // assigning the user's answer to the "daystr" variable
            Console.Write("Type in the number of a year: ");
            string yearstr = Console.ReadLine();  // assigning the user's answer to the "yearstr" variable
            Console.Write("Type in a number of days to add: ");
            string addstr = Console.ReadLine();  // assigning the user's answer to the "addstr" variable

            string wholedatestr = monthstr + "/" + daystr + "/" + yearstr;
            // creating one variable called "wholedatestr" by using the monthstr, daystr, and yearstr variables from above

            Console.WriteLine("Your date is {0} and you want to add {1} days", wholedatestr, addstr);
            // printing out the data the user entered

            DateTime parsedDate = DateTime.Parse(wholedatestr);
            // converting the string data type into a DateTime data type so we can add days to it

            int add = Convert.ToInt32(addstr);
            // converting the string data type into an int data type so it can be added to the date

            DateTime answer = parsedDate.AddDays(add);
            // creating the "answer" variable by using the .AddDays() method

            Console.WriteLine("{0} days after {1} is {2:MM/dd/yyyy}", addstr, wholedatestr, answer);
            // NOTE: explicitly specifying the format as {2:MM/dd/yyyy} eliminates the time from being printed out
            Console.ReadLine();


        // References:
        // https://docs.microsoft.com/en-us/dotnet/api/system.datetime.adddays?view=netframework-4.8
        // https://www.geeksforgeeks.org/datetime-adddays-method-in-c-sharp/
        // https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
        }
    }
}
