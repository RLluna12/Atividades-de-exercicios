using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, c;
            Console.WriteLine("temperatura em grau Fahrenheit: ");
            f = double.Parse(Console.ReadLine());

            c = ((f - 32) * 5) / 9;
            Console.WriteLine("a conversao de grau Fahrenheit em grau Celsius é : " + c);
        }
    }
}
