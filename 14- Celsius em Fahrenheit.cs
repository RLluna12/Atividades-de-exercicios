using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, c;
            Console.WriteLine("temperatura em grau Celsius: ");
            c = double.Parse(Console.ReadLine());

            f = (9 * c + 160) / 5;
            Console.WriteLine("a conversao de grau Celsius em grau Fahrenheit é : "+ f);

               
            


        }
    }
}
