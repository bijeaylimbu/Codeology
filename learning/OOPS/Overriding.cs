using System;

namespace CodeologyAssignment.learning.OOPS
{
    //late binding
    //same method name and method signature but in different class
    public class Overriding
    {
        public void method1()
        {
            Console.WriteLine("this is base class method");
        }
    }

    public class Class3: Overriding
    {
        //override
        public void method1()
        {
            Console.WriteLine("This is derived class method");
        }
    }

    public class MainC
    {
        public static void Main()
        {
            Overriding overriding = new Overriding();
            overriding.method1();
            overriding = new Class3();
            overriding.method1();

        }
    }
    
    
    
}