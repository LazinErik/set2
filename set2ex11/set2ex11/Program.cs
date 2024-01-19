using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, s = 0;
            int n;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            while (n > 0) 
            {
                a = float.Parse(Console.ReadLine());
                s = s + (1 / a);
                n--;
            }
            Console.WriteLine($"Suma inverselor acestor numere este {s}");
        }
    }
}
