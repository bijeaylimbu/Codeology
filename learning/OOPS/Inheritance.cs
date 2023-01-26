using System;

namespace CodeologyAssignment.learning.OOPS
{
    //it allow us to inherit features of another class
    //derived class
    public class Inheritance
    {
        //data members
        public string name = "bijay";
        public int roll = 5;

        //method of base class
        public void method1(string name, int roll)
        {
            Console.WriteLine(name+ this.roll);
        }

    }

//derived class
    public class BaseClass : Inheritance
    {
        public void method2()
        {
            Console.WriteLine("This is method2");
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            
            //creating object of base class
            BaseClass baseClass = new BaseClass();
            baseClass.method1("bijay", 5);
            baseClass.method2();
        }
    }
    
}