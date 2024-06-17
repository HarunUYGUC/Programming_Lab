using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab
{
    class Two_Dimensional_Arrays
    {
        static void Main(string[] args)
        {
            string[,] regions2 = new string[7, 3];

            regions2[0, 0] = "İstanbul";
            Console.WriteLine(regions2[0, 0]);

            Console.WriteLine("-------------");

            string[,] regions = { { "İstanbul", "İzmit", "Balıkesir" }, { "Ankara", "Konya", "Kırıkkale" } };

            // GetUpperBound(0) ile regions iki boyutlu dizisinin ilk boyutunu alırız. Yani 2.
            // Döngüde bu sayının bir eksiğine kadar ilerleyeceği için yani 1'e kadar 
            // <= kullanmalıyız. Çünkü dizinin indeksi 2'de biter.
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                // GetUpperBound(1) ile regions iki boyutlu dizisinin ikinci boyutunu alırız. Yani 3.
                // Yukarıdaki ile aynı şeyler geçerli.
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                    {
                    Console.WriteLine(regions[i, j]);
                }
            }
        }
    }
}
