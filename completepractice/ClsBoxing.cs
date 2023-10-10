using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsBoxing
    {
        static void Main(string[] args)
        {
            int i = 10;//normal intialization
            object o = i;//implicit boxing
            object x=(object)i;//explicit boxing
            int j = (int)o;//Explicit unboxing
            Console.WriteLine("value of i is:" + i);
            Console.WriteLine("value of o after implicit boxing is:" + o);
            Console.WriteLine("value of x after explicit boxing is:" + x);
            Console.WriteLine("value ojf j after impicit unboxing is:" + j);
            Console.ReadKey();  
        }
    }
}
