using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Employee2
    {
        int empid;
        string ename;
        string eaddress;
        int eage;

        public Employee2 (int id,string n,string a, int ag)
        {
            empid = id;
            ename = n;
            eaddress = a;
            eage = ag;
        }
        public Employee2()
        {
            this.empid = 2996;
            this.ename = "rangeela";
            this.eaddress = "lohchi";
            this.eage = 26;
        }
        public void displayempdata()
        {
            Console.WriteLine("Employee details are:");
            Console.WriteLine("empid:" + " " + this.empid);
            Console.WriteLine("ename:" + " " + this.ename);
            Console.WriteLine("eaddress:" + " " + this.eaddress);
            Console.WriteLine("eage:" + " " + this.eage);
        }
    }
    class ClsParameter
    {
        static void Main(string[] args)
        {
            Employee2 obj1 = new Employee2(2996,"rangeela","lohchi",27);
            Employee2 obj2 = new Employee2(1506, "rahul", "lohchi", 29);
            Employee2 obj3 = new Employee2();
            obj1.displayempdata();
            obj2.displayempdata();
            obj3.displayempdata();
            Console.ReadKey();
        }
    }
}
