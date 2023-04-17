using System;

namespace NormaABNT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string autor, livro, ano, edicao, local, editora;
            autor = Console.ReadLine(); livro = Console.ReadLine(); ano = Console.ReadLine(); edicao = Console.ReadLine(); local = Console.ReadLine(); editora = Console.ReadLine();

            autor = autor.Replace(" de", "");
            autor = autor.Replace(" da", "");

            autor = autor.ToUpper();
            string[] aux = autor.Split(',');

            if (aux.Length == 1)
            {
                string[] partes = aux[0].Split(' ');
                Console.Write(partes[partes.Length - 1] + ", ");
                int i = 0;
                while (i < (partes.Length - 1))
                {
                    Console.Write(partes[i].Substring(0, 1) + ". ");
                    i++;
                }
            }
            else if (aux.Length > 1 && aux.Length < 4)
            {
                int quant = aux.Length;
                string[] partes1;
                for (int j = 0; j < quant; j++)
                {
                    partes1 = aux[j].Split(' ');
                    int p = 0;
                    Console.Write(partes1[partes1.Length - 1] + ",");
                    while (p < (partes1.Length - 1))
                    {
                        Console.Write(" ");
                        Console.Write(partes1[p].Substring(0, 1) + ".");
                        p++;
                    }
                    if (j < quant - 1)
                        Console.Write("; ");
                }
                Console.Write(" ");
            }
            else if (aux.Length >= 4)
            {
                string[] partes2 = aux[0].Split(' ');
                Console.Write(partes2[partes2.Length - 1] + ", ");
                int m = 0;
                while (m < (partes2.Length - 1))
                {
                    Console.Write(partes2[m].Substring(0, 1) + ". ");
                    m++;
                }
                Console.Write("et al. ");
            }

            Console.WriteLine("{0}. {1} ed. {2}: {3}, {4}.", livro, edicao, local, editora, ano);
        }
    }
}
