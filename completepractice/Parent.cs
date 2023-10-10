using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Parent
    {
        public void property()
        {
            Console.WriteLine("cash+gold+lands");
        }
        public void car()
        {
            Console.WriteLine("landrover");
        }
    }
    class child:Parent
    {
        public new void car()
        {
            base.car(); 
            Console.WriteLine("defender");
        }
    }
    class clsoverride
    {
        static void Main(string[] args)
        {
            child obj1= new child();    
            obj1.car();
            obj1.property();
            Console.ReadKey();
        }
    }
}
