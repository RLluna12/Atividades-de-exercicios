using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite o n1: ");
            n1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite o n2: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("{0} o maior", n1);
            }
            else
            {
                Console.WriteLine("{0} o maior", n2);
            }
        }
    }
}
