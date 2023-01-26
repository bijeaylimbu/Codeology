using System;

namespace CodeologyAssignment.learning.OOPS
{
    //it is used to wrap data member and method together into single unit
    //it hides internal details of an object 
    //hides how an object perform some operations
    public class Encapsulation
    {

         //private is used so that it can only be access by public method of class
        private int number;
        private string name;

        //using getter and setter to set and get the value
        public int Number
        {
            get { return number; }
            set { number = value; }

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

    public class MainClass
    {
        public static void Main()
        {
            //creating object
            Encapsulation cEncapsulation = new Encapsulation();
            //calling the access and passing the value
            cEncapsulation.Name = "bijay";
            cEncapsulation.Number = 5;
            
            //displaying the value of variables
            Console.WriteLine(cEncapsulation.Number);
            Console.WriteLine(cEncapsulation.Name);

        }
    }
}