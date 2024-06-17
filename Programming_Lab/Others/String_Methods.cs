using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class String_Methods
    {
        static void Main(string[] args)
        {
            string a;
            long x = 8000000; // 8 milyon.

            a = x.ToString("N"); // Basamaklara nokta ve ondalık ayracı. => 8.000.000,00 (Sonuç "string" olarak tutulur.)
            Console.WriteLine(a);

            // Console.Write("Bir ifade giriniz: ");
            // a = Console.ReadLine();
            // Console.WriteLine("Değer = .{0}.", a);
            // Console.WriteLine();

            a = "Merhaba Dünya.";
            string b = "Dünya";
            Console.WriteLine("Yeni = .{0}.", a.Trim()); // Hem baştaki hem sondaki boşlukları atar.
            Console.WriteLine("Yeni = .{0}.", a.TrimStart()); // Baştaki boşlukları atar.
            Console.WriteLine("Yeni = .{0}.", a.TrimEnd()); // Sondaki boşlukları atar.

            Console.WriteLine("Karşılaştırma = {0}", String.Compare(a, b)); // Aynı ise 0 değeri, a b'den önce geliyorsa -1 gelir, b a'dan önce ise 1 gelir.
            Console.WriteLine("Birleştirme = {0}", String.Concat(a, b)); // a'nın sonua b'yi ekler geriye döndürür.

            Console.WriteLine("Arama = {0}", a.IndexOf("ha")); // a stringinin başından sonuna belirtilen ifadeyi arar, bulamazsa -1 değerini döndürür. Bulursa ilk indisi döndürür.
            Console.WriteLine("Arama = {0}", a.IndexOf("ba", 4)); // a stringinin belirtilen indisinden sonuna kadar belirtilen ifadeyi arar, bulamazsa -1 değerini döndürür. Bulursa ilk indisi döndürür.
            Console.WriteLine("Arama = {0}", a.IndexOf("ün", 4, 5)); // a stringinin belirtilen indisinden itibaren belirtilen uzunluk kadarlık yerde belirtilen ifadeyi arar, bulamazsa -1 değerini döndürür. Bulursa ilk indisi döndürür.

            Console.WriteLine("Arama = {0}", a.LastIndexOf("a")); // a stringinin sonundan başına belirtilen ifadeyi arar, bulamazsa -1 değerini döndürür. Bulursa ilk indisi döndürür.
            Console.WriteLine("Arama = {0}", a.LastIndexOf("a", 4)); // a stringinin belirtilen indisinden sola doğru, başa doğru, belirtilen ifadeyi arar. Bulamazsa -1 değerini döndürür. Bulursa ilk indisi döndürür.
            Console.WriteLine("Arama = {0}", a.LastIndexOf("a", 4, 2)); // a stringinin belirtilen indisinden itibaren sol tarafa doğru belirtlen uzunluk kadarlık yerde sondan başa belirtilen ifadeyi arar, bulamazsa -1 değerini döndürür. Bulursa ilk indisi döndürür.

            string[] y = a.Split('a');
            // foreach (string i in y)
            for(int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("Parçalı dizinin {0}. elemanı = {1}", i, y[i]);
            }

            y = a.Split('.');
            Console.WriteLine("Cümle sayısı = {0}", y.Length - 1);

            b = a.Substring(4); // Belirtilen indisten itibaren dizinin sonuna kadar alır geri döndürür.
            Console.WriteLine("Alt ifade = " + b);

            b = a.Substring(4, 5); // Belirtilen indisten itibaren belirtilen uzunluk kadarını alır geri döndürür.
            Console.WriteLine("Alt ifade = " + b);

            Console.ReadKey();
        }
    }
}
