/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Guzel_Algoritma_Sorusu_2
    {
        static int yesilAlanToplami(int[,] dizi)
        {
            int top = 0;
            int n = 0;
            int start = 1;
            int end = dizi.GetLength(0) - 2;
            
            // Üstten ortaya.
            while (n < dizi.GetLength(0) / 2)
            {
                for (int i = start; i <= end; i++)
                {
                    top += dizi[n, i];
                    Console.Write(dizi[n, i] + "\t");
                }

                Console.WriteLine();

                n++;
                start++;
                end--;
            }

            n = dizi.GetLength(0) / 2 + 1;
            start = dizi.GetLength(0) / 2;
            end = dizi.GetLength(0) / 2;

            // Ortadan alta.
            while (n < dizi.GetLength(0))
            {
                for (int i = start; i <= end; i++)
                {
                    top += dizi[n, i];
                    Console.Write(dizi[n, i] + "\t");
                }

                Console.WriteLine();

                n++;
                start--;
                end++;
            }

            Console.WriteLine();

            return top;
        }

        static void yazdir(int[,] dizi)
        {
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    Console.Write(dizi[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Kare Matris oluşturmak için bir Tek Sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] dizi = new int[n, n];
            Random rnd = new Random();

            int[] tekSayilar = new int[n*n];
            int k = 0;

            while (k < n*n)
            {
                int num = rnd.Next(10, 101);

                if (num % 2 != 0)
                {
                    tekSayilar[k] = num;
                    k++;
                }
            }

            k = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dizi[i, j] = tekSayilar[k];
                    k++;
                }
            }

            yazdir(dizi);

            Console.WriteLine("Yeşil alandaki değerlerin toplamı = " + yesilAlanToplami(dizi));
        }
    }
}
*/
