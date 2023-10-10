using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class DynamicArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 };
            Console.WriteLine("Elements of array are");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" \nEnter new size of array:");
            int n=int.Parse(Console.ReadLine());
            Array.Resize(ref a, n);
            Console.WriteLine("value after resize");
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

       
    }
}
