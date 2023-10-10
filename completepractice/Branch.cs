using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class Branch
    {
        int Bcode;
        string Bname;
        string Baddress;
        public void getbdata()
        {
            Console.WriteLine("enter breanchh details are:");     
            this.Bcode=int .Parse(Console.ReadLine());
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
    


    class employee5 : Branch
    {
        int empid;
        string ename;
        string eaddress;
        int eage;
        public void getempdata()
        {
            Console.WriteLine("Enter employee details");
            this.empid=int .Parse(Console.ReadLine());  
            this.ename=Console.ReadLine();
            this.eaddress=Console.ReadLine();
            this.eage = int.Parse(Console.ReadLine());
        }
        public void displayempdata()
        {
            Console.WriteLine("employee details are:");
            Console.WriteLine("employee id is:" + this.empid);
            Console.WriteLine("employee name is:" + this.ename);
            Console.WriteLine("employee address is:" + this.eaddress);
            Console.WriteLine("employee eage is:" + this.eage);
        }
    }
    class employeesalary : employee5
    {
        double basic, DA, HRA, Gross;

        public void getsal()
        {
            Console.WriteLine("emter salary"); 
            this.basic = Convert.ToDouble(Console.ReadLine());
        }
        public void calculate()
        {
            Console.WriteLine("enter employee salary to calcuate:");
            this.DA = this.basic * 0.06;
            this.HRA = basic * 0.4;
            this.Gross = this.basic + this.HRA + this.DA;
        }
        public void displaysal()
        {
            Console.WriteLine("Employee salary details is:");
            Console.WriteLine("basic is:" + this.basic);
            Console.WriteLine("hra is:" + this.HRA);
            Console.WriteLine("da is:" + this.DA);
            Console.WriteLine("gross salary is:" + this.Gross);
        }
    }
    class clsInheritance
    {
        static void Main(string[] args)
        {
            employeesalary obj1 = new employeesalary();
            obj1.getbdata();
            obj1.getempdata();
            obj1.getsal();
            obj1.calculate();
            obj1.displaybdata();
            obj1.displayempdata();
            
            obj1.displaysal();
            Console.ReadKey();
        }
    }
}
