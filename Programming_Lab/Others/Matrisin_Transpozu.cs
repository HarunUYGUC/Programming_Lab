/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Matrisin_Transpozu
    {
        static void Main(string[] args)
        {
            // Matrisin içerisini rastgele elemanlarla doldurur ve yazdırır.
            int n = 5, m = 3;
            int[,] M = new int[n, m];
            Random r = new Random();

            Console.WriteLine("A - MATRISI");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    M[i, j] = r.Next(1, 11);
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Matrisin Transpozu'nu alır.
            int[,] T = new int[m, n];

            Console.WriteLine("A - TRANSPOZE MATRISI");
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    T[y, x] = M[x, y];
                }
            }

            // Matrisin Transpozu'nu yazdırır.
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    Console.Write(T[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
*/
