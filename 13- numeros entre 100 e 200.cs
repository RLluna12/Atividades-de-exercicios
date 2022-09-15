using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Digite um numero: ");
            n1= int.Parse(Console.ReadLine());

            if(n1>=100 && n1<=200)
            {
                Console.WriteLine("Esta entra 100 e 200");
            }
            else
            {
                Console.WriteLine("Não esta entre 100 e 200");
            }
        }
    }
}
