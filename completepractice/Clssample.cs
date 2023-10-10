using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Clssample
    {
        int i;
        static int j;

        public Clssample()
        {
            i = 100;
        }
        static Clssample()
        {
            j = 100; 
        }
        public void display()
        {
            Console.WriteLine("non static constructior i:" + i);
            i++;
            Console.WriteLine("static constructor j:" + j);
            j++;

        }
    }
    class classtaticconstructor
    {
        static void Main(string[] args)
        {
            Clssample obj1= new Clssample();    
            obj1.display();
            Clssample obj2 = new Clssample();
            obj2.display();
            Clssample obj3 = new Clssample();
            obj3.display();
            Console.ReadKey(); 
        }
    }
}
