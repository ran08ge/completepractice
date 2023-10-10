using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsGeneric
    {
        //public void display<g>(g s)
        //{
        //    Console.WriteLine("values is:" + s);
        //}
        //static void Main(string[] args)
        //{
        //    ClsGeneric obj1= new ClsGeneric();
        //    obj1.display<int>(2996);
        //    obj1.display<float>(299.5f);
        //    obj1.display<double>(25.03);
        //    obj1.display<string>("rangeela");
        //    Console.ReadKey();

        //}
        //static void display<g>(g s)
        //{
        //    Console.WriteLine("values is:" + s);
        //}
        //static void Main(string[] args)
        //{
        //    ClsGeneric obj1 = new ClsGeneric();
        //    display<int>(2996);
        //    display<float>(299.5f);
        //    display<double>(25.03);
        //    display<string>("rangeela");
        //    Console.ReadKey();

        //}
        public void display<G1,G2>(G1 S1,G2 S2)
        {
            Console.WriteLine("values are:"+S1+","+S2+" ");
        }
        static void Main(string[] args)
        {
            ClsGeneric obj1 = new ClsGeneric();
            obj1.display<int,float>(2996,2365f);
            obj1.display<float,string>(299.5f,"rahul");
            obj1.display<double,bool>(25.03,true);
            obj1.display<string,int>("rangeela",345);
            Console.ReadKey();

        } 
    }
}
