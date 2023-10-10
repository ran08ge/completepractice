using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Employee6
    {
        protected int empid;
        protected string ename;
        string eaddress;
        int eage;
        public virtual void getempdata()
        {
            Console.WriteLine("Enter Employee details");
            this.empid=Convert .ToInt32(Console.ReadLine());
            this.ename=Console.ReadLine();
            this.eaddress=Console.ReadLine();
            this .eage=Convert .ToInt32(Console.ReadLine());
        }
        public virtual void displayempdata()
        {
            Console.WriteLine("Employee details are:");
            Console.WriteLine("empid:" + " " + this.empid);
            Console.WriteLine("ename:" + " " + this.ename);
            Console.WriteLine("eaddress:" + " " + this.eaddress);
            Console.WriteLine("eage:" + " " + this.eage);
        }
    }
    class manager : Employee6
    {
        double CA, bonus;
        public override void getempdata()
        {
            base.getempdata(); 
            Console.WriteLine("Enter Manger Details:");
            this.empid=Convert.ToInt32(Console.ReadLine());
            this.ename = Console.ReadLine();
            this.CA=Convert .ToInt32(Console.ReadLine());
              this.bonus = Convert.ToInt32(Console.ReadLine());
        }
        public override void displayempdata()
        {
            base.displayempdata();
            Console.WriteLine("Manager  details are:");
            Console.WriteLine("empid:" + " " + this.empid);
            Console.WriteLine("ename:" + " " + this.ename);
            Console.WriteLine("manager CA:" + " " + this.CA);
            Console.WriteLine("Manager Bonus:" + " " + this.bonus );
        }
    }
    class clsoverride1
    {
        static void Main(string[] args)
        {
            manager obj1= new manager();
            obj1.getempdata();
            obj1.displayempdata();
            Console.ReadKey();
        }
    }
}
