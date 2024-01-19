using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, v, poz = 0, k = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                v = int.Parse(Console.ReadLine());
                if (v == poz) k++;
                poz++;
                n--;
            }
            Console.WriteLine($"Din secventa data, {k} elemente sunt egale cu pozitia pe care apar in secventa");
        }
    }
}
