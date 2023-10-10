using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Properties
    {
        static void Main(string[] args)
        {
            Arithmetic obj1= new Arithmetic();
            Console.WriteLine("Enter two numbers:");
            obj1.pnum1=Convert.ToInt32(Console.ReadLine());
            obj1.Pnum2 = Convert.ToInt32(Console.ReadLine());

            obj1.add();
            Console.WriteLine("sum is:" + obj1.presult);
            obj1.sub();
            Console.WriteLine("sub is:" + obj1.presult);
            obj1.mul();
            Console.WriteLine("multiplicaion is:"+ obj1.presult);
            obj1.div();
            Console.WriteLine("division is:" + obj1.presult);
            Console.ReadKey();
        }
    }
}
