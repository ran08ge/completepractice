using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsFunctions
    {
       // public void display()
       public void add(int a,int b)
        {
            //Console.WriteLine("this is display function without parameter");
            Console.WriteLine("sum is" +( a + b ));
        }
        // function with parameter
        public void parameter(string message)
        {
            Console.WriteLine("who is devil"+message);
        }
        static void Main(string[] args)
        {
        //    ClsFunctions obj1=new ClsFunctions();
            //obj1.display();
            //obj1.display();
            //obj1.display();
            //ClsFunctions obj2= new ClsFunctions();
            //obj2.parameter("i am the devil");
            ClsFunctions obj3= new ClsFunctions();
            obj3.add(10,30);
            Console.ReadKey();
        }
    }
}
