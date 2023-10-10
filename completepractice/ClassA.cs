using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClassA
    {
         public void f1()
        {
            Console.WriteLine("f1 function of class A");
        }
    }
    internal class ClassB:ClassA
    {
        public void f2()
        {
            Console.WriteLine("f2 function of class B");
        }
    }
    internal class ClassC : ClassA
    {
        public void f3()
        {
            Console.WriteLine("f3 function of class C");
        }
    }
    class clsINheritance
    {
        static void Main(string[] args)
        {
            ClassB obj1 = new ClassB();
            obj1.f1();
            obj1.f2();
           

            ClassC obj2 = new ClassC();
            obj2.f1();
            obj2.f3();


            Console.ReadKey(); 

        }

    }
}
