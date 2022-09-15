using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("digite a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("digite b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("digite c: ");
            c = double.Parse(Console.ReadLine());
            if (a <= b && b <= c)
            {
                Console.WriteLine("{0} numero menor\n{1} numero do meio\n{2} numero maior", a, b, c); 
            }
            if (a <= c && c <= b) 
            {
                Console.WriteLine("{0} numero menor\n{1} numero do meio\n{2} numero maior", a, c, b); 
            }
            if (b <= a && a <= c) 
            {
                Console.WriteLine("{0} numero menor\n{1} numero do meio\n{2} numero maior", b, a, c); 
            }
            if (b <= c && c <= a) 
            {
                Console.WriteLine("{0} numero menor\n{1} numero do meio\n{2} numero maior", b, c, a); 
            }
            if (c <= a && a <= b) 
            {
                Console.WriteLine("{0} numero menor\n{1} numero do meio\n{2} numero maior", c, a, b); 
            }
            if (c <= b && b <= a) 
            {
                Console.WriteLine("{0} numero menor\n{1} numero do meio\n{2} numero maior", c, b, a); 
            }
        }
    }
    
}
