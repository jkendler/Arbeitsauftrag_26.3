using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jkendler_zahlen_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Geben Sie eine Zahl ein: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geben Sie eine Zahl ein: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                throw new Exception("Man kann nicht durch null dividieren.");

            }

          
       


        }
    }
}
