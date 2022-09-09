using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Digite um Numero: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 >= 200 && n1 <= 300)
            {
                Console.WriteLine("Entre 200 e 300");
            }
            else if (n1 < 200 || n1 > 300)
            { 
                Console.WriteLine("nao esta entra 200 e 300"); 
            }
           

        }
    }
}
