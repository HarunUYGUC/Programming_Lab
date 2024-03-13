/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Array_Random
    {
        static void Main(string[] args)
        {
            int[] f = { 1, 3, 5, 2, 1, 0 };
            int[] e = new int[5];
            int kapasite = e.Length; // Dizinin eleman sayısını verir.
            Console.WriteLine(kapasite);


            // Diziler ile ilgili temel işlemler için Array sınıfını kullanıyoruz.
            Array.Sort(e); // Diziyi küçükten büyüğe sıralar.
            Array.Reverse(e); // Diziyi ters çevirir.
            Array.Clear(e, 0, 3); // Dizinin 0. indisinden başlar ve arkasındaki 3 tane veriyi diziden siler.
            Array.Copy(e, f, 4); // e dizisindeki 4 tane veriyi f dizisine kopyalar.
            Array.Sort(e, 4, 6); // Dizinin 0. indisinden başlar ve arkasındaki 6 tane veriyi sıralar.


            Random r = new Random();
            double a = r.NextDouble(); // 0 <= x < 1;

            int b = r.Next(); // 0 ile 2 milyar 147 arasından bir tam sayı üretir.
            int c = r.Next(10); // 0 ile 9 arasından bir tam sayı üretir. 
            int d = r.Next(5, 15); // 5 ile 14 arasından bir tam sayı üretir.


            Random x = new Random();

            for (int i = 0; i < 10; i++)
            {
                int g = x.Next(1, 11);
                Console.WriteLine(g);
            }
            

            Console.ReadKey();
        }
    }
}
*/
