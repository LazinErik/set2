using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, v, poz = 0, ok = 0;
            Console.Write("n = ");
            n= int.Parse(Console.ReadLine());
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                v = int.Parse(Console.ReadLine());
                if (v == a)
                {
                    Console.WriteLine($"Numarul {a} se afla pe pozitia {poz}");
                    ok = 1;
                    break;
                }
                poz++;
                n--;
            }
            if (ok == 0) Console.WriteLine("-1");
        }
    }
}
