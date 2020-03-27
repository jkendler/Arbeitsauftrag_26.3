using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jkendler_namen_1
{
    class Program
    {
        static void Main(string[] args)
        {

            

            try
            {

                string[] namen = new string[3];
                string na;

                for (int i = 0; i < 4 ; i++)
                {
                    
                    Console.Write("Geben Sie einen Namen ein: ");
                    na = Console.ReadLine();
                    namen[i] = na;            

                }

            }
            catch (IndexOutOfRangeException)
            {
                throw new Exception("Bitte nur drei Namen eingeben.");
            }
            


        }
    }
}
