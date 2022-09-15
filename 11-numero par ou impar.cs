using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.Write("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            
            if (n1%2==0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
            
        }
    }
}
