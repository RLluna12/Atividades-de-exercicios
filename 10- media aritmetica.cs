using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            Console.Write("Digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro numero: ");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("media = "+ media);



        }
    }
}
