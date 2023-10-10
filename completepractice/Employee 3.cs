using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Employee3
    {

        int empid;
        string ename;
        string eaddress;
        int eage;

       
        private Employee3()
        {
            this.empid = 2996;
            this.ename = "rangeela";
            this.eaddress = "lohchi";
            this.eage = 26;
        }
        private void displayempdata()
        {
            Console.WriteLine("Employee details are:");
            Console.WriteLine("empid:" + " " + this.empid);
            Console.WriteLine("ename:" + " " + this.ename);
            Console.WriteLine("eaddress:" + " " + this.eaddress);
            Console.WriteLine("eage:" + " " + this.eage);
        }
        static void Main(string[] args)
        {
            Employee3 obj1= new Employee3();
            obj1.displayempdata();
            Console.ReadKey();
        }
    }
}

