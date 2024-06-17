using System; // Temel işlemler için gerekli.
using System.Collections; // ArrayList işlemleri için gerekli.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Array_List
    {
        static void Main(string[] args)
        {
            ArrayList DinamikDizi = new ArrayList();

            // Koleksiyona 128,18,56 değerlerini ekledik. 
            DinamikDizi.Add(128);
            DinamikDizi.Add(18);
            DinamikDizi.Add(56);
            DinamikDizi.Add(1869);

            // foreach ile koleksiyonun tüm elemanlarını ekrana yazdırdık. 
            foreach (var i in DinamikDizi)
                Console.WriteLine(i);

            Console.WriteLine("Listenin kapasitesi = " + DinamikDizi.Capacity);

            // 18 değerini koleksiyondan çıkardık. 
            DinamikDizi.Remove(18);

            // Bu sefer for döngüsü ile koleksiyonun tüm elemanlarını ekrana yazdırdık.
            for (int i = 0; i < DinamikDizi.Count; i++)
                Console.WriteLine(DinamikDizi[i]);

            // 18 artık ArrayList'de yok fakat ArrayList'in kapasitesi hala 4 olarak gözüküyor.
            Console.WriteLine("18 Silindi. Listenin kapasitesi hala = " + DinamikDizi.Capacity);

            Console.WriteLine("--------------");

            if (DinamikDizi.Contains(56))
                Console.WriteLine("Mevcut. 56.");
            else
                Console.WriteLine("Mevcut Değil. 56.");

            // ArrayList'i küçükten büyüğe sıraladık.
            Console.WriteLine("ArrayList küçükten büyüğe sıralandı.");
            DinamikDizi.Sort();

            foreach (var i in DinamikDizi)
                Console.WriteLine(i);

            // 128 değerinin indeks numarasını ekrana yazdırdık. (İndeksi: 1) 
            Console.WriteLine("128'in bulunduğu indis: " + DinamikDizi.BinarySearch(128));
        }
    }
}
