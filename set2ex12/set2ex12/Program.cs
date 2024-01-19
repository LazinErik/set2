using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, grupuri = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            n--;
            if (a == 0)
            {
                while (a == 0 && n>0)
                {
                    a = int.Parse(Console.ReadLine());
                    n--;
                }
            }
            if (n == 0) Console.WriteLine("Nu exista grupuri de numere consecutive diferite de 0");
            else
            {
                b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    while (b == 0 && n>0)
                    {
                        b = int.Parse(Console.ReadLine());
                        a = b;
                        n--;
                    }
                    if (b != 0)
                    {
                        b = int.Parse(Console.ReadLine());
                        if (b == a + 1)
                        {
                            a = b;
                            grupuri++;
                        }
                    }
                }    
            }
            
        }
    }
}
