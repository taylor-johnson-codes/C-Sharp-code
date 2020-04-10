using System;

namespace Properties
{
    class Properties
    {
        static void Main(string[] args)
        {
            // EXAMPLE 1
            Console.WriteLine("EXAMPLE 1:");
            
            // First, a new class called Person was created below the class called Properties

            Person myPerson = new Person();  // creating an object/instance of the Person class called myPerson
            Console.WriteLine("What is your first name?");  // asking the user for their first name
            myPerson.Name = Console.ReadLine();  
            // setting the user's first name as the value of the Name variable established in the Person class
            Console.WriteLine("Your name is {0}.", myPerson.Name);  
            // outputting/getting the variable Name back to the user to show it stored properly


            // EXAMPLE 2
            Console.WriteLine("EXAMPLE 2:");

            // First, a new class called Num was created below the class called Person

            Num myExample = new Num();  // creating an object/instance of the Num class called myExample
            myExample.Number = 5;  // setting the value of the Number variable to 5
            // if the Number property or set function in the class was private instead of public, this would create an error
            Console.WriteLine("The number is: {0}", myExample.Number);
            // outputting/getting the value of the Number variable
            // if the Number property or get function in the class was private instead of public, this would create an error

            Console.ReadLine();
        }
    }
    // PART OF EXAMPLE 1
    class Person
    {
        public string Name
        { get; set; }

        // Name is a property of the Person class; properties contain get and set (aka "getters" and "setters")
        // get lets the user in the Main method read the value of the Name variable
        // set lets the user in the Main method write/change/edit the value of the Name variable
        // because the Person class is public, it's accessible in the Main method above
        // if it was set as private, it wouldn't be accessible in the Main method above
    }


    // PART OF EXAMPLE 2
    class Num
    // showing a more detailed version of {get;set}
    {
        private int _number;  // field or attribute of the class
        // _number can't be accessed/changed/edited anywhere else in the program because it's private
        public int Number  // property of the class
        // the Number property is associated with the _number field
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                // "value" is a reference to whatever got assigned to Number in the Main method
            }
        }
    }


    /* REFERENCES:
    https://www.w3schools.com/cs/cs_properties.asp
    https://www.dotnetperls.com/property
    */
}
