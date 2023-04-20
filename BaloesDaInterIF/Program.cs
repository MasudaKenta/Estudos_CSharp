using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaloesDaInterIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] res = Console.ReadLine().Split(' ');
            int[] balao = new int[n];
            balao = Array.ConvertAll(res, int.Parse);
            int[] aux = new int[1000001];
            int flechas = 0;
            for (int i = 0; i < n; i++)
            {
                if (aux[balao[i]] > 0)
                {
                    aux[balao[i]]--;
                    aux[balao[i] - 1]++;
                }
                else
                {
                    flechas++;
                    aux[balao[i] - 1]++;
                }
            }

            Console.WriteLine(flechas);
        }
    }
}
