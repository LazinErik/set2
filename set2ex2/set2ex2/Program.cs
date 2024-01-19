using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, negative = 0, zero = 0, pozitive = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int n_init = n;
            while (n > 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a < 0) negative++;
                else if (a == 0) zero++;
                else pozitive++;
                n--;
            }
            Console.WriteLine($"Dintre cele {n_init} numere date in secventa, {negative} sunt negative, {pozitive} sunt pozitive si {zero} sunt zero");
        }
    }
}
