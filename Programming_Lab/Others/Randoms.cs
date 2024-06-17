using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Randoms
    {
        static int[] rastgele(int a, int b)
        {
            int[] sayi = new int[a];
            int[] cevap = new int[b];

            for (int i = 0; i < a; i++)
                sayi[i] = i;

            Random r = new Random();

            int boyut = sayi.Length;

            for (int i = 0; i < b; i++)
            {
                int n = r.Next(boyut);
                cevap[i] = sayi[n];

                for (int j = n; j < boyut - 1; j++)
                    sayi[j] = sayi[j + 1];

                boyut--;
            }

            return cevap;
        }

        static void Main(string[] args)
        {
             Random r = new Random();

             for (int i = 0; i < 10; i++)
             {                
                 Console.WriteLine(r.Next(6, 24));
             }


             Console.WriteLine("--------");

            // Tekrarsız rastgele sayı.
            // rastgele(a,b); 0 ile a-1 arası.

            Console.Write("Rastgele sayı sınırının tavan değerini giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kaç sayı çekilecek?: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[] sayi = new int[a];

            for (int i = 0; i < a; i++)
                sayi[i] = i;

            int boyut = sayi.Length;

            for (int i = 0; i < b; i++)
            {
                int n = r.Next(boyut);

                Console.WriteLine("Rastgele Sayı = " + sayi[n]);

                for (int j = n; j < boyut - 1; j++)
                    sayi[j] = sayi[j + 1];

                boyut--;
            }


            Console.WriteLine("--------");

            int[] ras = rastgele(a, b);

            foreach(int i in ras)
                Console.WriteLine(i);

            // Console.ReadKey();
        }
    }
}
