using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double folhas;
            Console.WriteLine("Numero de folhas:");
            folhas = double.Parse(Console.ReadLine());

            if (folhas > 200)
            {
                Console.WriteLine(folhas * 0.30);
            }
            else
            {
                Console.WriteLine(folhas * 0.50);
            }

        }
    }
}
