using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <=13)
            {
                Console.WriteLine("Sua categoria é infantil");
            }
            else if (idade <= 17)
            {
                Console.WriteLine("Sua categoria é juvenil");
            }
            else
            {
                Console.WriteLine("Sua categoria é sênior");
            }
        }
    }
}
