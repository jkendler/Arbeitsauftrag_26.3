using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jkendler_summe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1;
            double zahl2;

            try
            {

                Console.Write("Geben Sie eine Zahl ein: ");
                zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Geben Sie eine Zahl ein: ");
                zahl2 = Convert.ToDouble(Console.ReadLine());

                if (zahl2 == 10)
                {
                    throw new Exception("10 ist nicht erlaubt");
                }

                double erg = zahl1 + zahl2;
                Console.WriteLine(erg);



              



            }
          
            catch 
            {
                throw new Exception("10 ist nicht erlaubt");

            }
        }
    }
}
