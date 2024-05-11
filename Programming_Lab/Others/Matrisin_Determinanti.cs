/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Matrisin_Determinanti
    {
        static int DET(int[,] Matris)
        {
            int d = 0;
            int n = Matris.GetLength(0);
            int[,] AltMatris = new int[n - 1, n - 1];
            int alt_i, alt_j;

            if (n == 2)
            {
                return (Matris[0, 0] * Matris[1, 1] - Matris[1, 0] * Matris[0, 1]);
            }
            else
            {
                for (int k = 0; k < n; k++)
                { 
                    // -1^k
                    alt_i = 0;

                    for (int i = 1; i < n; i++)
                    {
                        alt_j = 0;

                        for (int j = 0; j < n; j++)
                        {
                            if (j == k) continue;
                            AltMatris[alt_i, alt_j] = Matris[i, j];
                            alt_j++;

                            // if (j != k)
                            // {
                            //     AltMatris[alt_i, alt_j] = Matris[i, j];
                            //     alt_j++;
                            // }
                        }

                        alt_i++;
                    }

                    d = d + Convert.ToInt32(Math.Pow(-1, k)) * Matris[0, k] * DET(AltMatris);
                }
            }

            return d;
        }

        static void Main(string[] args)
        {
            Console.Write("Matris Kapasitesi: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] Matris = new int[n, n];

            Console.WriteLine("Matris Elemanları:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("M[{0}, {1}] = ", i, j);
                    Matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matris");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Matris[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Determinat = {0}", DET(Matris));
            Console.ReadKey();
        }
    }
}
*/
