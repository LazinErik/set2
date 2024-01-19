using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, a, ok = 0, monoton = 1;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            n--;
            a = int.Parse(Console.ReadLine());n--;
            if (m == a)
            {
                while (m == a && n > 0)
                {
                    a = int.Parse(Console.ReadLine());
                    n--;
                }
                if (n == 0) Console.WriteLine("Secventa data este monotona");
            }
            if (m < a)
            {
                ok = 1;
                m = a;
            }
            else if (m > a)
            {
                ok = 0;
                m = a;
            }
            if (ok == 1 && n>0)
            {
                while (n > 0)
                {
                    a = int.Parse(Console.ReadLine());
                    if (a < m)
                    {
                        monoton = 0;
                        break;
                    }
                    else m = a;
                    n--;
                }
                if (monoton == 0) Console.WriteLine("Secventa data NU este monotona");
                else Console.WriteLine("Secventa data este monotona");

            }
            else if(ok == 0 && n>0)
            {
                while (n > 0)
                {
                    a = int.Parse(Console.ReadLine());
                    if (a > m)
                    {
                        monoton = 0;
                        break;
                    }
                    else m = a;
                    n--;
                }
                if (monoton == 0) Console.WriteLine("Secventa data NU este monotona");
                else Console.WriteLine("Secventa data este monotona");
            }
            
        }
    }
}
