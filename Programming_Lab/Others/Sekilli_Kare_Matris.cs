using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Sekilli_Kare_Matris
    {
        static void Main(string[] args)
        {
            int n = 9;
            int[,] M = new int[n, n];
            Random r = new Random();

            Console.WriteLine("A - MATRISI");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = r.Next(1, 11);
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int top = 0;
            for (int j = 1; j <= (n / 2); j++)
            {
                for (int i = j; i <= n - (j + 1); i++)
                {
                    top += M[i, j - 1] + M[i, n - j];
                    Console.Write("{0}-{1}\t", i, j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Sonuç = {0}", top);
            Console.ReadKey();
        }
    }
}
