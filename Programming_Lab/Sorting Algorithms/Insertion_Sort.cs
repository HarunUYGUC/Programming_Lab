using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Sorting_Algorithms
{
    internal class Insertion_Sort
    {
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
            // Dizi oluştur.
            Random rnd = new Random();
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 51);
            }

            diziyiYazdir(a);

            // Insertion Sort
            int temp = 0;
            // Listenin tamamının sırlanması için kurulan döngü.
            for (int i = 1; i < a.Length; i++)
            {
                // İkili karşılaştırma ve sıralama için kurulan döngü.
                for (int j = i - 1; j > -1; j--)
                {
                    if (a[j + 1] < a[j])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                    else
                        break;
                }
            }

            diziyiYazdir(a);
        }
    }
}
