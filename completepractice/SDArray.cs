using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class SDArray
    {
        static void Main(string[] args)
        { // creating a single dimension array by accepting length and values
            Console.WriteLine("Enater the length of elements:");
            int l=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the values of "+l);
            int[]A=new int[l];
            for(int i=0;i<l;i++)
            {
                A[i]=int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Elements of array are");
            for(int i=0;i<l;i++)
            
                {
                Console.Write(A[i] + " ");
                }
            Console.ReadKey();
        }
    }
}
