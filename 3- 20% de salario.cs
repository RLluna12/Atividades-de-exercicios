using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salfx, totalvend, salfin;

            Console.WriteLine("Digite seu nome");
            name = Console.ReadLine();

            Console.WriteLine("seu salario fixo: ");
            salfx = double.Parse(Console.ReadLine());
            Console.WriteLine("total de vendas: ");
            totalvend = double.Parse(Console.ReadLine());
            Console.WriteLine("Seu salario final é : ");
            salfin = salfx * 20/ 1000 + salfx;
            
            Console.WriteLine(salfin);


        }
    }
}
