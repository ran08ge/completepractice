using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsPointer
    {
        static void Main(string[] args)
        {

            int a = 100;
            unsafe
            {
                int* X = &a;
                Console.WriteLine("value os a is:" + *X);
                Console.WriteLine("Address of a is:" + (int)X);
            }
            Console.ReadKey();
        }
    }
}
