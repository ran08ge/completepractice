using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static completepractice.PRACTICE;

namespace completepractice
{
    internal class PRACTICE
    {
       public void display<g1,g2>(g1 s1,g2 s2)
        {
            Console.WriteLine("value is:"+s1+", "+s2);  
        }


    }
    class practice2
    {
        static void Main(string[] args)
        {
          PRACTICE obj1= new PRACTICE();
            obj1.display<string, int>("rangeela", 2996);
            obj1.display<string, int>("puja", 2995);
            Console.ReadKey();
        }
    }
    
}



