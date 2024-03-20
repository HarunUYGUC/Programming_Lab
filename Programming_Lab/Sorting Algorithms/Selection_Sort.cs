/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Sorting_Algorithms
{
    internal class Selection_Sort
    {
        // Dizi oluştur.
        static int[] diziOlustur()
        {
            Random rnd = new Random();
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 51);
            }

            return a;
        }

        // Dizinin içeriğini yazdır.
        static void diziyiYazdir(int[] a)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.Write(a[i]);
            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            int[] a = diziOlustur();

            diziyiYazdir(a);

            // Selection Sort
            for (int i = 0; i < a.Length - 1; i++)
            {
                int enKucuk = a[i];
                int enKucukIndis = i;

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < enKucuk)
                    {
                        enKucuk = a[j];
                        enKucukIndis = j;
                    }
                }

                int temp = a[i];
                a[i] = a[enKucukIndis];
                a[enKucukIndis] = temp;
            }

            diziyiYazdir(a);
        }
    }
}
*/
