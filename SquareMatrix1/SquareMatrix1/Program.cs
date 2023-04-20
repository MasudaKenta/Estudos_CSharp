using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareMatrix1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                    break;

                int[,] m = new int[n, n];
                int a = 0, b = 0, c=n;

                for(int nivel = 0; nivel < (n + 1) / 2; nivel++)
                {
                    for(int i = a; i < c; i++)
                    {
                        for(int j=b; j < c; j++)
                        {
                            m[i, j]++;
                        }
                    }
                    a++;
                    b++;
                    c--;
                }

                int t = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write("  ");
                    for(int j = 0; j < n; j++)
                    {
                        string aux = m[i, j].ToString();
                            if (aux.Length == 1 && t==1)
                                Console.Write("   ");
                            else if (aux.Length == 2 && t==1)
                                Console.Write("  ");
                        
                        Console.Write(m[i, j]);
                        t = 1;
                    }
                    Console.WriteLine();
                    t = 0;
                }
                Console.WriteLine();
            }
        }
    }
}
