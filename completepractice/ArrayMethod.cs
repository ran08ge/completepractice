using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ArrayMethod
    {
        static void Main(string[] args)
        {
            int[] A = new int[7] { 10, 20, 30, 40, 50, 60, 70 };
            int[] B = new int[10] { 15, 5, 35, 25, 55, 45, 75, 65, 95, 85 };
            Console.WriteLine("Elements of array a are:");
            foreach(int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nElements of B are:");
            foreach (int i in B)
            {
                Console.Write(i+" "); 
            }
            // A.CopyTo(B, 2);
            // first method of copy
            // Array.Copy(A, B, 2);
            // second method of copy
            //Array.Copy(A, 2, B, 2, 2);
            Array.Sort(B);
            Console.WriteLine("\nElements of b are after copying");
            foreach (int i in B )
            {
                Console.Write(i + " ");
            }
           // Array.Reverse(B);
           Array.Clear(B,0, B.Length);
            Console.WriteLine("\n Elements after reverse:"); 
            foreach(int i in B)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
