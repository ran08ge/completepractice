using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Employee
    {
        int empid;
        string ename;
        string eaddress;
        int age;
        public void getempdata()
        {
            empid = 2996;
            ename = "rangeela";
            eaddress = "patna";
            age = 27;
        }
        public void displayempdata()
        {
            Console.WriteLine("employee details are:");
            Console.WriteLine(empid);
            Console.WriteLine(ename);
            Console.WriteLine(eaddress);
            Console.WriteLine(age);
        }


    }
    class dispaly
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            obj1.getempdata();
            obj1.displayempdata();
            Console.ReadKey();
        }
    }
}
