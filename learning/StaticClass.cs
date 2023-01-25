using System;
using CodeologyAssignment.learning;

namespace CodeologyAssignment.learning
{
    //static class
    //it can only contain static member, method, and constructor
    //we cannot create object of static class
    public static class StaticClass
    {
        public static string name = "bijay";
        
//cannot create non static variable;
       // public string roll = 1;

       //cannot create non static method;
       // public void method1()
       // {
       //     
       // }

       
       //static method
       public static void method1()
       {
           Console.WriteLine("This is method one");
       }
    }
}

public class MainMethod
{
    public static void Main()
    {
        StaticClass.method1();
    }
}


//cannot inherit static class
// public class Class2 : StaticClass
// {
//     
// }