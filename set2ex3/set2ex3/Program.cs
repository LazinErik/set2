using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0, p = 1;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int n_init = n;
            while (n > 0)
            {
                s = s + n;
                p = p * n;
                n--;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n_init} este {s}, iar produsul lor este {p}");
        }
    }
}
