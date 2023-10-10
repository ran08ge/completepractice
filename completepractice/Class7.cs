using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Class7
    {
        //public void add(int a,int b)
        //{
        //    Console.WriteLine("sum is:" + (a + b));
        //}
        //public void add(float a, int b)
        //{
        //    Console.WriteLine("sum is:" + (a + b));
        //}
        //public void add(int a, int b, int c)
        //{
        //    Console.WriteLine("sum is:" + (a + b+c));
        //}
        //public int add(int a,int b)
        //{
        //    return a + b;

        //}
        //public float add(float a, int b)
        //{
        //    return (a + b);
        //}
        //public int add(int a,int b,int c)
        //{
        //    return a + b + c;
        //} 

        static int add(int a, int b)
        {
            return a + b;

        }
        static float add(float a, int b)
        {
            return (a + b);
        }
        static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int i = add(10, 20);
            float j = add(10.5f, 50);
            int k = add(10, 20, 30);
            Console.WriteLine("sum is:" + i);
            Console.WriteLine("sum is:" + j);
            Console.WriteLine("sum is:" + j);
            Console.ReadKey();
        }

        //static void Main(string[] args)
        //{
        //    Class7 obj1= new Class7();
        //    obj1.add(10, 20);
        //    obj1.add(10.5f, 20);
        //    obj1.add(10, 20,30);
        //    Console.ReadKey();
        //}
    }
    //class class8
    //{
        //static void Main(string[] args)
        //{
        //    Class7 obj1= new Class7();
        //    obj1.add(10, 20);
        //    obj1.add(20.5f, 30);
        //    obj1.add(10, 20, 30);
        //    Console.ReadKey();
    //    //}
    //    static void Main(string[] args)
    //    {
    //        Class7 obj1= new Class7();
    //        int x = obj1.add(10, 20);
    //        float y = obj1.add(10.2f, 50);
    //        int z = obj1.add(10, 20, 30);
    //        Console.WriteLine("sum is:" + x);
    //        Console.WriteLine("sum is :" + y);
    //        Console.WriteLine("sum is:" + z);
    //        Console.ReadKey();
    //    }

    //}
}
