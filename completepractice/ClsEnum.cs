 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsEnum
    {
        enum months
        {
            january,
            february,
            march,
            april,
            may,
            june,july
        }
        static void Main(string[] args)
        {
            //months m=months.january;
            //Console.WriteLine("this month is:" + m);
            int m=(int)months.march;
            Console.WriteLine(m);
            Console.ReadKey();
        }
             
    }
}
