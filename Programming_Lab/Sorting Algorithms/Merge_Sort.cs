using System;

namespace Programming_Lab.Sorting_Algorithms
{
    internal class Merge_Sort
    {
        // Diziyi yazdır.
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

        // => Merge Sort <=

        // Ana Fonksiyon
        static void mergeSort(int alt, int üst)
        {
            if (alt < üst)
            {
                int m = (alt + üst) / 2;
                mergeSort(alt, m);
                mergeSort(m + 1, üst);
                merge(alt, m, üst);
            }
        }

        // Yardımcı Fonksiyon
        static void merge(int alt, int m, int üst)
        {
            int[] b = new int[8];
            int i, j, k;

            // a dizisinin her iki yarısını yedek b dizinine kopyala
            for (i = alt; i <= üst; i++)
            {
                b[i] = a[i];
            }

            i = alt;
            j = m + 1;
            k = alt;

            // her adımda bir sonraki en büyük terimi kopyala
            while (i <= m && j <= üst)
            {
                if (b[i] <= b[j])
                    a[k++] = b[i++];
                else
                    a[k++] = b[j++];
            }

            // varsa, ilk yarıdan arta kalan terimlerin hepsini kopyala
            while (i <= m)
            {
                a[k++] = b[i++];
            }
        }

        // Global dizi.
        static int[] a = { 12, 9, 4, 99, 120, 1, 3, 10 };
        static void Main(string[] args)
        {
            diziyiYazdir(a);

            mergeSort(0, a.Length - 1);

            diziyiYazdir(a);
        }
    }
}
