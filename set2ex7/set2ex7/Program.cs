using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, max = 0, min;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            n--;
            min = a;
            if (a > max) max = a;
            while (n > 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max) max = a;
                if (a < min) min = a;
                n--;
            }
            Console.WriteLine($"Cel mai mic numar din secventa este {min}, iar cel mai mare este {max}");
        }
    }
}
