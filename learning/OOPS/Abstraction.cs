using System;

namespace CodeologyAssignment.learning.OOPS
{
    //it only represent features without background details
    //it only focus on what it does rather than how it does
    
    //abstract indicates the class is abstract
    //it doesnt support multiple inheritances
    //it can't be static
    public abstract class Abstraction
    {
        //abstract indicates the method is abstract
        public abstract void method1();

        //non abstract method can also be used in abstract class
        public void method2()
        {
            Console.WriteLine("this is method 2");
        }

    }

    public class Class2 : Abstraction
    {
        //override keyword should be used in the child class before the method is declared as abstract 
        public override void method1()
        {
            
            Console.WriteLine("This is method 1");
        }
    }

   

    public class MainClass
    {
        public static void Main()
        {
            Class2 class2 = new Class2();
            class2.method2();
            class2.method1();
        }
    }
}