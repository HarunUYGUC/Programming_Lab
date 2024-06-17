using System; // Temel işlemler için gerekli.
using System.Collections.Generic; // Dictionary işlemleri için gerekli.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Dictionaryy_Function
    {
        // Fonksiyona gönderilen dizideki elemanların dizide kaçar tane olduğunu bulur.
        // Elemanları ve kaçar adet olduğunu dictionary şeklinde döndürür.
        static Dictionary<int, int> frekans(int[] d)
        {
            Dictionary<int, int> fre = new Dictionary<int, int>();

            foreach (int i in d)
            {
                if (fre.ContainsKey(i))
                {
                    fre[i]++; // Dictionary'nin i. key'inin değerini (value) bir arttırır.
                    // Dizide kaç tane olduğunu baktığımız eleman dictionary'ye önceden eklendiyse o elemanın adedini artırır.
                }
                else
                {
                    fre.Add(i, 1); // Dictionary'nin içine belirtilen key'i ekle ve değerini 1 yap.
                    // Dizide kaç tane olduğunu baktığımız eleman dictionary'e hiç eklenmediyse ilk ekleme işlemini burası yapar.
                }
            }

            return fre;
        }

        static void Main(string[] args)
        {
            //ArrayList alist = new ArrayList() { 2, 2, 3, 4, 5, 5, 66, 66, 66, 75, 75, 75, 75, 75, 4, 6, 7, 8, 3, 7, 0 } ;
            //List<int> llist = new List<int>() { 2, 2, 3, 4, 5, 5, 66, 66, 66, 75, 75, 75, 75, 75, 4, 6, 7, 8, 3, 7, 0 } ;
            
            int[] diz = { 2, 2, 3, 3, 4, 5, 5, 66, 66, 3, 66, 75, 75, 75, 75, 75, 4, 6, 7, 8, 3, 7, 0 };

            Console.WriteLine("Eleman --- Frekans");
            Dictionary<int, int> frekanslistesi = frekans(diz);

            foreach (KeyValuePair<int, int> x in frekanslistesi)
                Console.WriteLine("Sayı: {0}  --- Frekans: {1}", x.Key, x.Value);

            // Console.ReadKey();
        }
    }
}
