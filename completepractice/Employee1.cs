using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Employee1
    {
        int empid;
        string ename;
        string eaddress;
        int eage;
        public Employee1()
        {
            this .empid = 2996;
            this.ename = "rangeela";
            this.eaddress = "lohchi";
            this.eage = 26;
        }
        public void displayempdata()
        {
            Console.WriteLine("Employee details are:");
            Console.WriteLine("empid:"+" " + this.empid);
            Console.WriteLine("ename:"+" " + this.ename);
            Console.WriteLine("eaddress:"+" " + this.eaddress);
            Console.WriteLine("eage:"+" " + this.eage);
        }
        static void Main(string[] args)
        {
            Employee1 emp= new Employee1();
            emp.displayempdata();
            Console.ReadKey();
        }
      
    }

}
