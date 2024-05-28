/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// "Güzel Algoritma Sorusu" => Yeşil karelerdeki sayıları yazdıran ve
// yeşil karelerdeki sayıların toplamını veren program.

namespace Programming_Lab.Others
{
    internal class Matrisdeki_Yesillerin_Toplami
    {
        // Dizi oluşturur.
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

        // Dizi yazdırır.
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

        // Main
        static void Main(string[] args)
        {
            int[,] A;
            A = olustur(9);
            yazdir(A);

            int toplam = 0; // Yeşil karelerdeki sayıların toplamı.
            int n = 0; // Sütunlarda ilerlemek için.
            int start = 1; // Yeşil karelerin başladığı satır.
            int end = 7; // Yeşil karelerin bittiği satır.

            // Baştan ortaya kadar ilerleyecek.
            Console.WriteLine("Baştan ortaya kadarki yeşil kareler:");
            while (n < 4)
            {
                for (int i = start; i <= end; i++)
                {
                    toplam += A[i, n];
                    Console.Write(A[i, n] + ", ");
                }
                Console.WriteLine();

                start += 1;
                end -= 1;
                n++;
            }

            n = 5;
            start = 4;
            end = 4;

            // Ortadan sona kadar ilerleyecek.
            Console.WriteLine("Ortadan sona kadarki yeşil kareler:");
            while (n < 9)
            {
                for (int i = start; i <= end; i++)
                {
                    toplam += A[i, n];
                    Console.Write(A[i, n] + ", ");
                }
                Console.WriteLine();

                start -= 1;
                end += 1;
                n++;
            }

            Console.WriteLine("Yeşil alanlardaki sayıların toplamı: " + toplam);
        }
    }
}
*/
