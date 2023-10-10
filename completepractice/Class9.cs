using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal partial class Class9
    {
        // x developer code
        int id;
        string name;
        public void getdata()
        {
            Console.WriteLine("Enter employee id");
            this.id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            this.name=Convert.ToString(Console.ReadLine()); 

        }
    }
}
