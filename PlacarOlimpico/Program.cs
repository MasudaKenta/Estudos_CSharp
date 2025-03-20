using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacarOlimpico
{
    internal class Program
    {
        struct MEDAL
        {
            public string Pais;
            public long Ouro;
            public long Prata;
            public long Bronze;
            public long Colocacao;
        };
        static void Main(string[] args)
        {
            MEDAL[] paises = new MEDAL[10000];
            string nome = "";
            long cont = 0;
            while (nome != "FIM")
            {
                nome = Console.ReadLine();
                if (nome == "FIM")
                    break;

                string[] medalhas = Console.ReadLine().Split(' ');
                paises[cont] = new MEDAL { Pais = nome, Ouro = int.Parse(medalhas[0]), Prata = int.Parse(medalhas[1]), Bronze = int.Parse(medalhas[2]) };

                cont++;
            }
            MEDAL backup;
            for (long i = 1; i < cont; i++)
            {
                for (long j = 0; j < cont; j++)
                {
                    if (paises[i].Ouro > paises[j].Ouro)
                    {
                        backup = new MEDAL { Pais = paises[i].Pais, Ouro = paises[i].Ouro, Prata = paises[i].Prata, Bronze = paises[i].Bronze };
                        paises[i] = new MEDAL { Pais = paises[j].Pais, Ouro = paises[j].Ouro, Prata = paises[j].Prata, Bronze = paises[j].Bronze };
                        paises[j] = new MEDAL { Pais = backup.Pais, Ouro = backup.Ouro, Prata = backup.Prata, Bronze = backup.Bronze };
                    }
                    if (paises[i].Ouro == paises[j].Ouro && paises[i].Prata > paises[j].Prata)
                    {
                        backup = new MEDAL { Pais = paises[i].Pais, Ouro = paises[i].Ouro, Prata = paises[i].Prata, Bronze = paises[i].Bronze };
                        paises[i] = new MEDAL { Pais = paises[j].Pais, Ouro = paises[j].Ouro, Prata = paises[j].Prata, Bronze = paises[j].Bronze };
                        paises[j] = new MEDAL { Pais = backup.Pais, Ouro = backup.Ouro, Prata = backup.Prata, Bronze = backup.Bronze };
                    }
                    if (paises[i].Ouro == paises[j].Ouro && paises[i].Prata == paises[j].Prata && paises[i].Bronze > paises[j].Bronze)
                    {
                        backup = new MEDAL { Pais = paises[i].Pais, Ouro = paises[i].Ouro, Prata = paises[i].Prata, Bronze = paises[i].Bronze };
                        paises[i] = new MEDAL { Pais = paises[j].Pais, Ouro = paises[j].Ouro, Prata = paises[j].Prata, Bronze = paises[j].Bronze };
                        paises[j] = new MEDAL { Pais = backup.Pais, Ouro = backup.Ouro, Prata = backup.Prata, Bronze = backup.Bronze };
                    }
                    if (paises[i].Ouro == paises[j].Ouro && paises[i].Prata == paises[j].Prata && paises[i].Bronze == paises[j].Bronze)
                    {
                        if (paises[j].Pais.CompareTo(paises[i].Pais) > 0)
                        {
                            backup = new MEDAL { Pais = paises[i].Pais, Ouro = paises[i].Ouro, Prata = paises[i].Prata, Bronze = paises[i].Bronze };
                            paises[i] = new MEDAL { Pais = paises[j].Pais, Ouro = paises[j].Ouro, Prata = paises[j].Prata, Bronze = paises[j].Bronze };
                            paises[j] = new MEDAL { Pais = backup.Pais, Ouro = backup.Ouro, Prata = backup.Prata, Bronze = backup.Bronze };
                        }
                    }
                }
            }

            int aux = 1;
            int aux2 = 1;
            for(long i = 0; i < cont; i++)
            {
                if(i!=0 && paises[i].Ouro == paises[i-1].Ouro && paises[i].Prata == paises[i - 1].Prata && paises[i].Bronze == paises[i - 1].Bronze)
                {
                    paises[i].Colocacao = aux;
                    aux2++;
                }
                else
                {
                    paises[i].Colocacao = aux2;
                    aux = aux2;
                    aux2++;
                    
                }
            }

            for (long i = 0; i < cont; i++)
            {   
                Console.WriteLine(paises[i].Colocacao + ": " + paises[i].Pais);
            }
        }
    }
}
