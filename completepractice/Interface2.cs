using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal interface Interface2
    {
        void f1();
    }
    interface interface3
    {
        void f2();
    }
    class C : Interface2,interface3
    {
        public void f1()
        {
            Console.WriteLine("f1 function of interface1 and interface1");
        }
        public void f2()
        {
            Console.WriteLine("f1 function of interface 2");
        }
    }
    class clsMultiple
    {
        static void Main(string[] args)
        {
            C obj1= new C();
            Interface2 obj2 = obj1;
            interface3 obj3 = obj1;
            obj1.f1();
            obj1.f2();  
            Console.ReadKey();
        }
    }
}
