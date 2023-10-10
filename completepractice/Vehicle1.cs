using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal abstract class Vehicle1
    {
        public abstract void wheels();
        public void enginetype()
        {
            Console.WriteLine("BS-6 engine");
        }
        public abstract void color();

    }
    class car : Vehicle1
    {
        public override void wheels()
        {
            Console.WriteLine("car:4 wheel");
        }
        public override void color()
        {
            Console.WriteLine("black");
        }
    }
    class bike : Vehicle1
    {
        public override void wheels()
        {
            Console.WriteLine("bike : 2 wheels");
        }
        public override void color()
        {
            Console.WriteLine("army color");
        }
    }
     class clsabstract
    {
        static void Main(string[] args)
        {
            car obj1= new car();
            obj1.wheels();
            obj1.enginetype();
            obj1.color();
            bike obj2= new bike();  
             obj2.wheels();
            obj2.enginetype();
            obj2.color();
            Console.ReadKey();
        }
    }
}
