using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nun1, nun2;

            Console.WriteLine("digite numero 1 : ");
            nun1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite numero 2 : ");
            nun2 = int.Parse(Console.ReadLine());

            if (nun1 == nun2)
            {
                Console.WriteLine("sao iguais");

            }
            else if (nun1 > nun2)
            {
                Console.WriteLine("{0} maior", nun1);
            }
            else if (nun1 < nun2)
            {
                Console.WriteLine("{0} maior", nun2);
            }

            
        }
    }
}
