using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           String name;
            Console.WriteLine("digite seu nome: ");
            name = Console.ReadLine();
            double n1, n2, n3, p1, p2, p3, mp;
            Console.Write("Digite a nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota 3: ");
            n3 = double.Parse(Console.ReadLine());

            p1 = 0.2;
            p2 = 0.4;
            p3 = 0.6;
            mp = (n1 * p1) + (n2 * p2) + (n3 * p3) / (p1+p2+p3);
            if (mp<=10)
            {
              Console.WriteLine(name + " sua nota é : " + mp);
            }
             else 
             {
              Console.WriteLine(name + " sua nota é: 10";    



 

        }
    }
}
