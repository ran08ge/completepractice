using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal interface Interface1
    {
        void wheel();
        void color();
    }
    class car1 : Vehicle1
    {
        public override void wheels()
        {
            Console.WriteLine("4 wheels:");
        }
        public override void color()
        {
            Console.WriteLine("white:");
        }

    }
    class bike1 : Vehicle1
    {
        public override void wheels()
        {
            Console.WriteLine("2 WHEEL:");
        }
        public override void color()
        {
            Console.WriteLine("black");
        }
    }
    class callInterface
    {
        static void Main(string[] args)
        {
            car1 obj1= new car1();
            obj1.wheels();
            obj1.color();
            bike1 obj2= new bike1();
            obj2.wheels();
            obj2.color();
            Console.ReadKey();
        }
    }
}
