using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Bubble_Sort
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

            // Bubble Sort
            int temp = 0;
            // Tüm sıralama için.
            for (int i = 0;i < a.Length - 1; i++)
            {
                // İkili karşılaştırma için.
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            diziyiYazdir(a);
        }
    }
}
