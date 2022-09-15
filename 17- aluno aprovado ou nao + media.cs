using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, media;
            Console.WriteLine("Digite a nota 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4: ");
            n4 = int.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            
            if (media < 5)
            {
                Console.WriteLine("Reprovado "+media);
            }
            else
            {
                Console.WriteLine("Aprovado " + media);
            }

        }
    }
}
