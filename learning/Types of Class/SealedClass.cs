using System;

namespace CodeologyAssignment.learning
{

    public class Class2
    {
        //a virtual method can be redefined in derived class
        public virtual void method1()
        {
            Console.WriteLine("this is method1");
        }
    }
    
    //sealed indicates it  cannot be inheritance
    //No class can be derived from a sealed class
      class SealedClass: Class2
      {//vairable cannot be sealed
          //private sealed int x = 10;
        public void method2()
        {
            Console.WriteLine("this is sealed classs");
        }

        // a sealed method cannot be overridden in future
        public sealed override void method1()
        {
            Console.WriteLine("This is method2");
        }
    }

      class Class3
      {
          public static void Main()
          {
              Class2 class2 = new Class2();
              class2.method1();
              SealedClass sealedClass = new SealedClass();
              sealedClass.method2();
          }
          
      }
  
}