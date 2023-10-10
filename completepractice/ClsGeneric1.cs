using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsGeneric1<G1,G2>

    {
        public void display(G1 s1,G2 s2)
        {
            Console.WriteLine("values is:" + s1 + ", " + s2);
        }
    }
    class generic2
    {
        static void Main(string[] args)
        {
            ClsGeneric1 <int,float>obj1= new ClsGeneric1<int,float>();
            ClsGeneric1 <double,int> obj2 = new ClsGeneric1<double,int>();
            ClsGeneric1<string,int> obj3= new ClsGeneric1<string,int>();
            obj1.display(20, 201.5f);
            obj2.display(44.32, 50);
            obj3.display("rangeela", 20);
            Console.ReadKey();
        }
    }
}
