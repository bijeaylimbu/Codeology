using System;

namespace CodeologyAssignment.learning
{
    //able to implement single class in multiple file and at the time of compile it is combined as a single unit
    //keyword partial is used to declare method as partial
    
    //it is important that all file should be available at the time of compile
    public partial class PartialClass
    {
        
    }

    public partial class Class1
    {
        public string name = "part";
        public int roll = 1;

        public Class1(string name, int roll)
        {
            this.name = name;
            this.roll = roll;
        }
        
    }
   //the name of the partial class should be same
    public partial class Class1
    {
        public void method1()
        {
            Console.WriteLine(name);
            Console.WriteLine(roll);
        }
    }
    
    //every partial should have same access modifier 

    public class MainClass
    {
        public string name ;
        public int roll;

        public MainClass(string name, int roll)
        {
            this.name = name;
            this.roll = roll;
        }
        public  void method1()
        {
         Console.WriteLine(name);
        }

        public static void Main()
        {
            Class1 class1 = new Class1("bijay", 1);
            class1.method1();
            ;
        }
    }
}