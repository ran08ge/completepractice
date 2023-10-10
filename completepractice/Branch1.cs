using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Branch1
    {
        int Bcode;
        string Bname;
        string Baddress;
        public void getbdata()
        {
            Console.WriteLine("enter breanchh details are:");
            this.Bcode = int.Parse(Console.ReadLine());
            this.Bname = Console.ReadLine();
            this.Baddress = Console.ReadLine();
        }
        public void displaybdata()
        {
            Console.WriteLine("branch details are");
            Console.WriteLine("branch code is:" + this.Bcode);
            Console.WriteLine("branch name is:" + this.Bname);
            Console.WriteLine("branch address is:" + this.Baddress);
        } 
    }
    interface employee7
    {
        void getempdata();
        void displayempdata();
    }
    class Manager1 : Branch1, employee7
    {
        int empid;
        string ename;
        double CA, bonus;
        public void getempdata()
        {
            Console.WriteLine("Enter Manger Details:");
            this.empid = Convert.ToInt32(Console.ReadLine());
            this.ename = Console.ReadLine();
            this.CA = Convert.ToInt32(Console.ReadLine());
            this.bonus = Convert.ToInt32(Console.ReadLine());
        }
        public void displayempdata()
        {
            Console.WriteLine("Manager  details are:");
            Console.WriteLine("empid:" + " " + this.empid);
            Console.WriteLine("ename:" + " " + this.ename);
            Console.WriteLine("manager CA:" + " " + this.CA);
            Console.WriteLine("Manager Bonus:" + " " + this.bonus);
        }
    }
    class clsMultipleInheritance
    {
        static void Main(string[] args)
        {
            Manager1 obj1=new Manager1();
            obj1.getbdata();
            obj1.displaybdata();
            obj1.getempdata();
            obj1.displayempdata();
            Console.ReadKey();

        }
    }
}
