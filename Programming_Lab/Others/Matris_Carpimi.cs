/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Matris_Carpimi
    {
        static void Main(string[] args)
        {
            int[,] A = new int[4, 5];
            int[,] C = new int[4, 5];


            // Matrisin içerisini rastgele elemanlarla doldurur.
            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = r.Next(0, 10);
                }
            }


            // Doldurduğumuz matrisi yazdırır.
            Console.WriteLine("---- A Matrisi ----");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // Skaler Bir Sayı İle Matrisin Çarpımı
            int sabit = 2;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    C[i, j] = sabit * A[i, j]; // Sabit sayı ile çarpım
                }
            }


            // İşlem sonucu oluşan matrisi yazdırır.
            Console.WriteLine("---- C Matrisi ----");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(C[i, j] + "\t");
                }
                Console.WriteLine();
            }


            int[,] D = new int[3, 5];
            int[,] E = new int[5, 7];


            // Matrislerin içerisini rastgele elemanlarla doldurur.
            Random rx = new Random();

            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    D[i, j] = rx.Next(0, 10);
                }
            }

            for (int i = 0; i < E.GetLength(0); i++)
            {
                for (int j = 0; j < E.GetLength(1); j++)
                {
                    E[i, j] = rx.Next(0, 10);
                }
            }


            // Doldurduğumuz matrisleri yazdırır.
            Console.WriteLine("---- D Matrisi ----");
            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    Console.Write(D[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("---- E Matrisi ----");
            for (int i = 0; i < E.GetLength(0); i++)
            {
                for (int j = 0; j < E.GetLength(1); j++)
                {
                    Console.Write(E[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // D ve E Matrislerinin Çarpımı
            // Matrislerde çarpma işlemi için D matrisinin sütun sayısı, E matrisinin satır sayısına eşit olmalı.
            if (D.GetLength(1) == E.GetLength(0))
            {
                // Çarpam işleminin sonucunda D matrisinin satır sayısı, E matrisiniin sütun sayısı şeklinde yeni bir F matrisi oluşur.
                int[,] F = new int[D.GetLength(0), E.GetLength(1)];

                // F matrisinin içerisi doldurulur.
                for (int i = 0; i < F.GetLength(0); i++)  // D'nin satır sayısı
                {
                    for (int j = 0; j < F.GetLength(1); j++) // E'nin sütun sayısı
                    {
                        F[i, j] = 0;

                        // D ve E matrislerinin satır ve sütun sayılarına karşılık gelen k ile F matrisinin içerisi doldurulur.
                        for (int k = 0; k < D.GetLength(1); k++)
                        {
                            F[i, j] += D[i, k] * E[k, j];
                        }
                    }
                }

                // Matris işleminin sonucu elde edilen F matrisi yazdırılır.
                Console.WriteLine("---- F Matrisi ----");
                for (int i = 0; i < F.GetLength(0); i++)
                {
                    for (int j = 0; j < F.GetLength(1); j++)
                    {
                        Console.Write(F[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
            // D matrisinin sütun sayısı, E matrisinin satır sayısına eşit değilse...
            else
            {
                Console.WriteLine("BOYUT HATASI, ÇARPILAMAZ");
            }
        }
    }
}
*/
