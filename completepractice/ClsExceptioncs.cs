using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class ClsException
    {
        static void Main(string[] args)
        {

            try
            {
                int a, b, c;
                Console.WriteLine("Enter two number:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                c = a / b;
                Console.WriteLine("result is:" + c);

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally the code is executed");
            }
            Console.ReadKey();
        }
    }
}
