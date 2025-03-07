using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordandoEmPontoCruz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            string[,] num = new string[7, 10];
            string[,] partes = new string[,]{
                {" XX ", "  XX"," XX ","XXX ","X  X","XXXX"," XXX","XXXX"," XX "," XX "," "},
                {"X  X", " X X","X  X","   X","X  X","X   ","X   ","   X","X  X","X  X"," "},
                {"X  X", "X  X","   X","   X","X  X","X   ","X   ","   X","X  X","X  X"," " },
                {"X  X", "   X","  X "," XX ","XXXX","XXX ","XXX ","  X "," XX "," XXX"," " },
                {"X  X", "   X"," X  ","   X","   X","   X","X  X"," X  ","X  X","   X"," " },
                {"X  X", "   X","X   ","   X","   X","   X","X  X","X   ","X  X","   X","X"},
                {" XX ", "   X","XXXX","XXX ","   X","XXX "," XX ","X   "," XX ","XXX ","X" }
            };

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if (data[j] == '0')Console.Write(partes[i, 0]);
                    else if (data[j] == '1') Console.Write(partes[i, 1]);
                    else if (data[j] == '2') Console.Write(partes[i, 2]);
                    else if (data[j] == '3' )Console.Write(partes[i, 3]);
                    else if (data[j] == '4') Console.Write(partes[i, 4]);
                    else if (data[j] == '5') Console.Write(partes[i, 5]);
                    else if (data[j] == '6') Console.Write(partes[i, 6]);
                    else if (data[j] == '7') Console.Write(partes[i, 7]);
                    else if (data[j] == '8') Console.Write(partes[i, 8]);
                    else if (data[j] == '9') Console.Write(partes[i, 9]);
                    else if (data[j] == '.') Console.Write(partes[i, 10]);
                    if (j < data.Length - 1)
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
