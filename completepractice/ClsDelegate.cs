using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsDelegate
    {
        static void display(string s )
        {
            Console.WriteLine("value is:" + s);
        }
        //creating a delegate
        delegate void mydelegate(string s);
        static void Main(string[] args)
        {
            //instiating a delegate
            mydelegate obj1 = new mydelegate(display);
            //invoking a delegate
            obj1("rangeela");
            Console.ReadKey();
        }
    }
}
