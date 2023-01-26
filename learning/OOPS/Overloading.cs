using System;

namespace CodeologyAssignment.learning.OOPS
{
    /* There are two types of polymorthism
     * 1-> Static or compile time
     *      ->Method Overlaoding
     *      -> Operator Overlaoding
     * 2-> Dyanmic or Runtime
     *      -> Virtual/Overriding
     * 
     */
    
    
    
    //one name many form
    //many form of single object
    public class Polymorphism
    {
        
    }
    
    //Compile time polymorphism
    //method overloading
    //two or more functions can share same name
    
    public class Class1
    {
        //method with no parameter
        public void method1()
        {
            Console.WriteLine("This is method1");
        }
        
        //it will throw error it two parameter have same method signature
        
        //method with parameter
        public void method1(int roll, string name)
        {
            Console.WriteLine(roll+ name);
        }
    }

    public class MainClas
    {
        public static void Main()
        {
            Class1 class1 = new Class1();
            class1.method1();
            class1.method1(1, "bijay");
        }
    }
}




