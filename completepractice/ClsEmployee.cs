using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsEmployee
    {
        static void Main(string[] args)
        {
            ClsEmp obj1=new ClsEmp(1234,"sai","hyderabad",45000);
            Console.WriteLine("Employee details are:");
            Console.WriteLine("Employee no is:" + obj1[0]);
            Console.WriteLine("Employee name is:" + obj1[1]);
            Console.WriteLine("Employee address is:" + obj1[2]);
            Console.WriteLine("Employee salary is:" + obj1[3]);
            Console.WriteLine("Employe ----" + obj1[4]);

            obj1[1] = "mohan";
            obj1[3] = 54000;
            
            Console.WriteLine("Employee details are:");
            Console.WriteLine("Employee no is:" + obj1[0]);
            Console.WriteLine("Employee name is:" + obj1[1]);
            Console.WriteLine("Employee address is:" + obj1[2]);
            Console.WriteLine("Employee salary is:" + obj1[3]);
            Console.WriteLine("Employe ----" + obj1[4]);
            Console.ReadKey();
        }
    }
}
