using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreBugged
{
    internal class Program
    {
        struct EQUIPE
        {
            public string Nome;
            public int Ex;
            public int Tempo;
        };
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());//qtd. de equipes
            EQUIPE[] dados = new EQUIPE[num];

            for (int i = 0; i < num; i++)
            {
                string[] a = Console.ReadLine().Split(','); //separador nome/pontuação
                int tempo = 0;
                int exercicios = 0;
                for (int j = 1; j < a.Length; j++)
                {
                    a[j] = a[j].Replace(" ", "1/0"); //evitar erros com o espaço " "
                    string[] b = a[j].Split('/');//separador tentativa/tempo
                    int b1 = int.Parse(b[0]); //tentativa
                    b[1] = b[1].Replace('-', '0'); //evitar erros com o traço "-"
                    int b2 = int.Parse(b[1]); //tempo
                    tempo += b2 + ((b1 - 1) * 20);
                    if (b2 > 0)
                        exercicios++;
                }

                dados[i] = new EQUIPE { Nome = a[0], Ex = exercicios, Tempo = tempo };
            }

            EQUIPE backup;

            for (int i = 1; i < dados.Length; i++)
            {
                for (int j = 0; j < dados.Length; j++)
                {
                    if (dados[j].Ex < dados[i].Ex)
                    {
                        backup = new EQUIPE { Nome = dados[i].Nome, Ex = dados[i].Ex, Tempo = dados[i].Tempo };
                        dados[i] = new EQUIPE { Nome = dados[j].Nome, Ex = dados[j].Ex, Tempo = dados[j].Tempo };
                        dados[j] = new EQUIPE { Nome = backup.Nome, Ex = backup.Ex, Tempo = backup.Tempo };
                    }

                    if (dados[j].Ex == dados[i].Ex && dados[j].Tempo > dados[i].Tempo)
                    {
                        backup = new EQUIPE { Nome = dados[i].Nome, Ex = dados[i].Ex, Tempo = dados[i].Tempo };
                        dados[i] = new EQUIPE { Nome = dados[j].Nome, Ex = dados[j].Ex, Tempo = dados[j].Tempo };
                        dados[j] = new EQUIPE { Nome = backup.Nome, Ex = backup.Ex, Tempo = backup.Tempo };
                    }
                }
            }

            for (int i = 0; i < dados.Length; i++)
            {
                Console.WriteLine((i + 1) + " | " + dados[i].Nome + " | " + dados[i].Ex + " (" + dados[i].Tempo + ")");
            }
        }
    }
}
