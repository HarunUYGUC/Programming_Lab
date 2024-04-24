/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Matris_Toplami_Farki
    {
        static void Main(string[] args)
        {
            int[,] A = new int[4, 5]; // Diğer programlama dillerinde "int[][] x" şeklindedir.
            int[,] B = new int[4, 5];

            int[][] dinamikdizi = new int[4][]; // Bu şekilde dizi tanımlarsak kinci boyutunu farklı farklı yapabiliriz.
            // Örnekleri için diğer dosyalara bak.


            Console.WriteLine("Dizinin toplam kapasitesi = {0}", A.Length);
            Console.WriteLine("Dizinin rank = {0}", A.Rank);
            Console.WriteLine("Dizinin 1. boyutunun kapasitesi = {0} | 2. boyutunun kapasitesi = {1}", A.GetLength(0), A.GetLength(1)); // 4 | 5, boyutu verir.
            Console.WriteLine("Dizinin 1. boyutunun kapasitesi = {0} | 2. boyutunun kapasitesi = {1}", A.GetUpperBound(0), A.GetUpperBound(1)); // 3 | 4, yani son indeksi verir.


            // Matrislerin içerisini rastgele elemanlarla doldurur.
            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = r.Next(0, 10);
                    B[i, j] = r.Next(0, 10);
                }
            }


            // Doldurduğumuz matrisleri yazdırır.
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

            Console.WriteLine("---- B Matrisi ----");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // Matrislerde Toplama ve Çıkarma İşlemleri
            int[,] C = new int[4, 5];
            
            // İki matrisin boyutlarının uygun olup olmadığına bakar.
            if (A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1))
            {
                // Toplama, çıkarma yapılacak.
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        // C[i, j] = A[i, j] + B[i, j];  // Toplama için
                        C[i, j] = A[i, j] - B[i, j];    // Çıkarma için
                    }                    
                }

                // Matris işleminin sonucu elde edilen matrisi yazdırır.
                Console.WriteLine("---- C Matrisi ----");
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(C[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
            // Matrislerin boyutu uygun değilse...
            else
            {
                Console.WriteLine("BOYUT HATASI");
            }
        }
    }
}
*/
