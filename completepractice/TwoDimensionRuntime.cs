using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class TwoDimensionRuntime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the element of row");
            int r=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Element of column");
            int c=int.Parse(Console.ReadLine());
            int[,] A = new int[r, c];
            Console.WriteLine("element" + " " + r * c + "values");
            for(int i=0;i<r;i++)
            {
                for (int j=0;j<c;j++)
                {
                    A[i,j]=int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("these are the elements");
            for(int i=0;i<r;i++)
            {
                for (int j=0;j<c;j++)
                {
                    Console.Write(A[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
