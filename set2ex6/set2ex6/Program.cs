using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace set2ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, a, ok=1;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            if (n <= 1) Console.WriteLine("n trebuie sa fie un numar mai mare decat 1");
            m = int.Parse(Console.ReadLine());
            n--;
            while (n > 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a < m)
                {
                    ok = 0;
                    break;
                }
                m = a;
                n--;
            }
            if (ok == 1) Console.WriteLine("Numerele din secventa sunt in ordine crescatoare");
            else Console.WriteLine("Numerele din secventa NU sunt in ordine crescatoare");
        }
    }
}
