using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsEmp
    {
        int eno;
        string ename;
        string eaddress;
        int salary;
        public ClsEmp (int eno, string ename,string eaddress,int salary)
        {
            this.eno = eno; 
            this.ename = ename;

            this.eaddress = eaddress;
            this.salary = salary;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return eno;
                else if(index == 1)
                    return ename;
                else if(index == 2)
                    return eaddress;
                else if(index == 3)
                    return salary;
                else return null;
            }
            set
            {
                if (index == 0)
                    eno = (int)value;
                else if (index == 1)
                    ename = (string)value;
                else if (index == 2)
                    eaddress = (string)value;
                else if (index == 3)
                    salary = (int)value;

            }
        }
    }

}
