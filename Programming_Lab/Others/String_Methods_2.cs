using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class String_Methods_2
    {
        static void Main(string[] args)
        {
            int indis = -1;
            int sayac = 0;
            string e = "xx xx xxx. yy yyyy. yyy yyy yy. zzzz. zzz zzzzz.";

            // "cümle sayısı - indexof" ile yöntem 1
            while (1 == 1)
            {
                try
                {
                    indis = e.IndexOf(".", (indis + 1));

                    if (indis != -1)
                        sayac++;
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("HATA");
                }
            }

            Console.WriteLine("Cümle sayısı = {0}", sayac);


            Console.WriteLine("-----------");


            // "cümle sayısı - split" ile yöntem 2
            string[] cevap = e.Split('.');
            sayac = cevap.Length - 1;
            Console.WriteLine("Cümle sayısı = {0}", sayac);

            for (int i = 0; i < cevap.Length; i++)
                Console.WriteLine(cevap[i]);


            Console.WriteLine("-----------");


            // "kelime sayısı - split"
            cevap = e.Split(' ');
            sayac = cevap.Length;
            Console.WriteLine("Kelime sayısı = {0}", sayac);

            for (int i = 0; i < cevap.Length; i++)
                Console.WriteLine(cevap[i]);


            Console.WriteLine("-----------");


            // Ekrandan girilen ax^2 + bx + c = 0 biçimindenki denklemi a, b, c'lerini bulma.
            int a , b, c;

            Console.Write("Denklemi giriniz: ");
            string ax = Console.ReadLine();

            string[] s = ax.Split('x');
            string[] t = s[1].Split(' ');
            string[] v = s[2].Split(' ');

            a = Convert.ToInt32(s[0]);
            b = Convert.ToInt32(t[2]);
            c = Convert.ToInt32(v[2]);

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            // Ekrandan girilen ax^2 + bx + c = 0 biçimindenki denklemin köklerini bulma.
            int delta = b*b - 4*a*c;

            if (delta > 0)
            {
                double kok1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double kok2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Kök1 = {0}, Kök2 = {1}", kok1, kok2);
            }
            else if (delta == 0)
            {
                double kok1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("İki kök birbirine eşit, Kökler = {0}", kok1);
            }
            else
            {
                Console.WriteLine("Reel kökü yoktur.");
            }

            Console.ReadKey();
        }
    }
}
