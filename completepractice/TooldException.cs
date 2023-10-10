using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completepractice
{
    internal class TooldException : Exception 
    {
        public TooldException(string message) : base(message)
        {

        }

    }
    internal class ToyoundException : Exception
    {
        public ToyoundException(string message) :base(message)
        {

        }
    }
    class Exception1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age:");
                int age = int.Parse(Console.ReadLine());
                if (age >= 60)
                {
                    throw new TooldException("age should not be 60 or more");
                }
                else if (age <= 16)
                {
                    throw new ToyoundException("age should not be 16 or below");
                }
                else
                {
                    Console.WriteLine("you are eligible:");
                }
            }
            //Generic catch block
            //catch
            //{
            //    Console.WriteLine("something went wrong:");

            //}
            //Specific catch block
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey(); 
        }
    }
}
