using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Clsproperty
    {
        static void Main(string[] args)
        {
            Employee9 obj1= new Employee9();
            Console.WriteLine("Enter Employee details:");
            obj1.PEmpid = int.Parse(Console.ReadLine());
            obj1.PEname = Console.ReadLine();
            obj1.PEaddress= Console.ReadLine();
            obj1.PEage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee details is");
            Console.WriteLine("Employee id is:" + obj1.PEmpid);
            Console.WriteLine("Employee name is:" + obj1.PEname);
            Console.WriteLine("Employee address is:" + obj1.PEaddress);
            Console.WriteLine("Employee age is:" + obj1.PEage);
            Console.ReadKey(); 
        }
    }
}
