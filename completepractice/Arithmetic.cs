using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace completepractice
{
    internal class Arithmetic
    {
        int num1, num2, result;
        public int pnum1
        {
            set { num1 = value; }
        }
        public int Pnum2
        {
            set { num2 = value; }
        }
        public int presult
        {
            get { return result; }
        }
        public void add()
        {
            result = num1 + num2;
        }
        public void sub()
        {
            result = num1 - num2;
        }
        public void mul()
        {
            result = num1 * num2;
        }
        public void div()
        {
            result = num1 / num2;
        }


    }
}
