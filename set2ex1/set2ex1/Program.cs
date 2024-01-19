using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, k=0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int n_init = n;
            while (n > 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0) k++;
                n--;
            }
            Console.WriteLine($"Dintre cele {n_init} numere date, numarul de numere pare este: {k}");
        }
    }
}
