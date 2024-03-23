/*
using System; // Temel işlemler için gerekli.
using System.Collections.Generic; // Dictionary işlemleri için gerekli.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Dictionaryy
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

            Ogrenci.Add(134, "Leon S. Kennedy");
            Ogrenci.Add(158, "Jill Valentine");
            Ogrenci.Add(115, "Kyle Crane");
            Ogrenci.Add(174, "Tifa Lockhart");

            Console.WriteLine("--- Anahtarlar (Key): ");
            Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys;

            foreach (int Anahtar in AnahtarListesi)
                Console.WriteLine(Anahtar);

            Console.WriteLine("--- Değerler (Value): ");
            Dictionary<int, string>.ValueCollection DegerListesi = Ogrenci.Values;

            foreach (string Deger in DegerListesi)
                Console.WriteLine(Deger);
        }
    }
}
*/
