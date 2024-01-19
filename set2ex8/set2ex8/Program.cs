using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, ninit, nrcautat=0, f1 = 0, f2 = 1, fs=0; 
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            ninit = n;
            if (n == 1) Console.WriteLine($"Primul numar din sirul lui Fibonacci este {f1}");
            else if (n == 2) Console.WriteLine($"Al doilea numar din sirul lui Fibonacci este {f2}");
            else
            {
                n = n - 2;
                while (n > 0)
                {
                    fs = f1 + f2;
                    nrcautat = fs;
                    f1 = f2;
                    f2 = fs;
                    n--;
                }
                Console.WriteLine($"Al {ninit}-lea numar din sirul lui Fibonacci este {nrcautat}");
            }
        }
    }
}
