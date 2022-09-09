using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_lista_de_exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area, bas, alt;
            Console.Write("Digite o valor da base: ");
            bas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            alt = int.Parse(Console.ReadLine());

            area = bas * alt / 2;

            Console.WriteLine("a area do quadrado é: "+ area);
            





        }
    }
}
