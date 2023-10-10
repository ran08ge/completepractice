using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] A = new int[3][];
            A[0]=new int[3] {10,20,30};
            A[1] = new int[2] { 40, 50 };
            A[2] = new int[4] { 60, 70, 80, 90 };
            Console.WriteLine("Elements of jagged array are:");
            for(int r=0;r<A.Length;r++)
            {
                for(int c = 0; c < A[r].Length;c++)
                {
                    Console.Write(A[r][c]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
