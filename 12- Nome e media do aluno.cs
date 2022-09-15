using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Digite seu nome: ");
            name = Console.ReadLine();
           double n1, n2, n3, media;
            Console.WriteLine("Digite sua nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua nota 3: ");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;
            Console.WriteLine(name +" sua media é: " + media);





        }
    }
}
