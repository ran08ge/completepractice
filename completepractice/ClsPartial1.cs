using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    partial class ClsPartial1
    {
        partial void m1();
        partial void m1()
        {
            Console.WriteLine("partial methos m1:");
        }
        public void m2()
        {
            Console.WriteLine("non partial method m2:");
            m1();
        }
    }
}
