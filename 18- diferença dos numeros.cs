﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite o primeiro numero: ");
                n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
                n2 = int.Parse(Console.ReadLine());
            if(n1 > n2)
            {
                Console.Write("a diferença dos numero é: ");
                Console.WriteLine(n1 - n2);
            }
            else
            {
                Console.Write("a diferença dos numero é: ");
                Console.WriteLine(n2 - n1);
            }

        }
    }
}
