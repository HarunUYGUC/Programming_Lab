/*
using System; // Temel kodlar için gerekli kütüphane.
using System.Collections.Generic; // Liste kullanımı için gerekli kütüphane.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Başlangıç ve bitiş saatleriyle birlikte -n- etkinlik verilir.
// Bir kişinin aynı anda yalnızca tek bir etkinlik üzerinde çalışabileceğini varsayarak,
// tek bir kişi tarafından gerçekleştirilebilecek maksimum etkinlik sayısını ve etkinlikleri
// ekrana yazan program.

// ??????
// Bu örnekteki bitiş zamanları sıralı şekildedir.
// Aksi takdirde önce bitiş zamanlarına göre sıralanmalıdır.
// ??????

namespace Programming_Lab.Others
{
    class Etkinlik_Planlama_Programi
    {
        public static List<int> maxEtkinlik(int[] s, int[] f)
        {
            int i, j;             
            int n = s.Length; // Etkinliklerin toplam sayısı.
            List<int> liste = new List<int>();

            Console.WriteLine("Seçilen etkinlikler: ");

            // İlk etkinlik her zaman ilk başta seçiliyor.
            i = 0;
            Console.WriteLine("i: " + i);
            liste.Add(i);
            int etkinlikSayi = 1;
            
            // Geri kalan etkinlikler göz önüne alınıyor.
            for (j = 1; j < n; j++)
            {
                // Bu aktivitenin başlangıç zamanı önceden seçilen aktivitenin bitiş zamanından büyük
                // veya ona eşitse o zaman bu etkinliği seçelim.
                if (s[j] >= f[i])
                {
                    Console.WriteLine("j: " + j);
                    liste.Add(j);
                    i = j;
                    etkinlikSayi++;
                }
            }

            Console.WriteLine("Toplam etkinlik sayısı: {0} \n", etkinlikSayi);

            return liste;
        }

        static void Main(string[] args)
        {
            int[] s = { 1, 3, 0, 5, 8, 5 }; // Tüm etkinliklerin başlama zamanlarını içeren dizi.
            int[] f = { 2, 4, 6, 7, 9, 9 }; // Tüm etkinliklerin bitiş zamanlarını içeren dizi.

            List<int> liste = maxEtkinlik(s, f);

            Console.WriteLine("Toplam etkinlik sayısı: {0}", liste.Count);

            Console.Write("Etkinliklerin indis numaraları: ");
            Console.WriteLine(String.Join("; ", liste)); // Listenin elemanlarını " " arasına konulan 
                                                         // sembol ile ayırılacak şekilde düzenler.

            foreach (int i in liste)
            {
                Console.WriteLine("Etkinlik başlangıç zamanı: {0}, bitiş zamanı: {1}", s[i], f[i]);
            }

            Console.WriteLine("\n-----------");

            // Bu döngüyü kullanmak yerine Liste'lere özgü aşağıdaki döngü de kullanılabilir.
            foreach (int i in liste)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");

            // Yukarıdaki döngü yerine Liste'lere özgü bu şekilde bir kullanım da yapılabilir.
            liste.ForEach(Console.WriteLine);
        }
    }
}
*/
