using System;
using CodeologyAssignment.learning;

namespace CodeologyAssignment.learning
{
    //cannot create object of Abstract class
    //indicate class is abstract
    //it must implement by non abstact class using override keyword
    //after override it is non abstact method
    public abstract class AbstractClass
    {
        public string name = "Bijay";
        public int roll = 1;

        public void method1()
        {
          Console.WriteLine(name);
        }
        //indicate method is abstract
        public abstract void method2();

        
        //it can also contain constructors and destructors
        public AbstractClass()
        {
            
        }
        //it can also contain getter and setter 
        public abstract  int std_class { get; set; }
    }
}


public class Class2 : AbstractClass
{
    //override indicates that child method is over writing its base class method
    //declare with override keyword
    public override  void method2()
    {
        Console.WriteLine("This is method 2");
    }

    public override int std_class
    {
        get { return roll;}
        set { roll = value; }
    }
    
}

public class MainClass
{
    public static void Main()
    {
        Class2 class2 = new Class2();
        class2.method2();
        class2.name = "bijay";
        class2.roll = 5;
     Console.WriteLine(class2.roll);


        //cannot create object of an abstract class
        //AbstractClass cAbstractClass = new AbstractClass();


    }
    

}