using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, primulnr, a, k=1, max=0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            primulnr = int.Parse(Console.ReadLine());
            n--;
            while (n > 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a == primulnr) k++;
                else
                {
                    primulnr = a;
                    k = 1;
                }
                n--;
                if (k > max) max = k;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale este {max}");

        }
    }
}
