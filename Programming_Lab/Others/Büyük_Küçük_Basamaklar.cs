using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Büyük_Küçük_Basamaklar
    {
        static void Main(string[] args)
        {
            Console.Write("Bir tam sayı giriniz (Pozitif veya negatif olabilir.): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
                n *= -1;

            int rakam = n % 10;
            n /= 10;
            int buyuk = rakam;
            int kucuk = rakam;

            while (n > 0)
            {
                rakam = n % 10;
                n /= 10;

                if (rakam > buyuk)
                    buyuk = rakam;
                
                if (rakam < kucuk)
                    kucuk = rakam;
            }

            Console.WriteLine($"En büyük basamak: {buyuk}, En küçük basamak: {kucuk}");
        }
    }
}
