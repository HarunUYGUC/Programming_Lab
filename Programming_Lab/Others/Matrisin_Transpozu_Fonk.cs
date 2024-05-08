/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Matrisin_Transpozu_Fonk
    {
        static int[,] olustur(int n)
        {
            int[,] A = new int[n, n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = r.Next(1, 11);
                }
            }

            return A;
        }

        static void yazdir(int[,] d)
        {
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                {
                    Console.Write(d[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[,] transpoz(int[,] d, int n)
        {
            int[,] B = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[j, i] = d[i, j];
                }
            }

            return B;
        }

        static void Main(string[] args)
        {
            Console.Write("Pozitif bir tam sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] A;
            A = olustur(n);
            yazdir(A);

            Console.WriteLine("----- Transpoz -----");
            int[,] B;
            B = transpoz(A, n);
            yazdir(B);
        }
    }
}
*/
