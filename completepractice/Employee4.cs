using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Employee4
    {

        int empid;
        string ename;
        string eaddress;
        int eage;

        public Employee4()
        {
            this.empid = 2996;
            this.ename = "rangeela";
            this.eaddress = "lohchi";
            this.eage = 26;
        }
        public Employee4(Employee4 tempobj)
        {
            this.empid= tempobj.empid;
            this.ename = tempobj.ename;
            this.eaddress=tempobj.eaddress;
            this.eage=tempobj.eage;
        }
        public void displayempdata()
        {
            Console.WriteLine("Employee details are:");
            Console.WriteLine("empid:" + " " + this.empid);
            Console.WriteLine("ename:" + " " + this.ename);
            Console.WriteLine("eaddress:" + " " + this.eaddress);
            Console.WriteLine("eage:" + " " + this.eage);
        }
        static void Main(string[] args)
        {
            Employee4 obj1= new Employee4();    
            Employee4 obj2= new Employee4(obj1);
            obj1.displayempdata();
            obj2.displayempdata();
            Console.ReadKey();
        }

    }
}
