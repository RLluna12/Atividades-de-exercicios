using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma, sub, mult, div;

            Console.WriteLine("Digite n1:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite n2:");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;
            sub = n1 - n2;
            div = n1 / n2;
            mult = n1 * n2;

            Console.WriteLine(soma);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mult);

                


        }
    }
}
