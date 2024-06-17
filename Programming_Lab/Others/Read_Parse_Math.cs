using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Read_Parse_Math
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba");
            Console.WriteLine("Merhaba");


            bool mantik;
            mantik = false;
            Console.WriteLine(mantik);
            mantik = true;
            Console.WriteLine(mantik);


            int[,] m = new int[3, 4];
            m[0, 0] = 12;

            int[][] z = new int[3][]; // Burada [3][4] şeklinde kullanım yapamayız.
            // Bu şekilde bir kullanım sayesinde 3 satırlık fakat satırların sütun sayısı
            // farklı olabilecek şekilde bir dizi tanımlarız.
            z[0] = new int[4]; // Her satırın sütün sayısı buradaki gibi farklı olabilir.
            z[1] = new int[2];
            z[2] = new int[3];
            z[2][1] = 12;


            string s;
            Console.Write("Veri Gir: ");
            s = Console.ReadLine();
            Console.WriteLine("Girilen Veri: " + s);


            int a, b, c;
            // Satırı okurken anladığım kadarıyla sadece string olarak okuyabiliyoruz.
            Console.Write("1. Sayıyı Giriniz: ");
            string s1 = Console.ReadLine();
            // Bu yüzden sayısal işlemler için integer'a dönüştürme işlemi yapmalıyız.
            a = Convert.ToInt32(s1);

            Console.Write("2. Sayıyı Giriniz: ");
            string s2 = Console.ReadLine();
            b = Convert.ToInt32(s2);
            // e = Convert.ToDouble(s2);

            Console.WriteLine(s1 + s2);
            Console.WriteLine(a + b);

            Console.Write("3. Sayıyı Giriniz: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c + b);


            string s3;
            int d;
            Console.Write("Bir veri giriniz: ");
            s3 = Console.ReadLine();
            Console.WriteLine(s3 + c);
            d = int.Parse(s3); // String s3 değişkenini int'e dönüştürür.
            Console.WriteLine(d + c);


            double e = Math.Pow(10, 3);
            Console.WriteLine(e);

            Console.WriteLine(Math.Floor(4.6)); // 4 => Küçük sayıya yuvarlar.
            Console.WriteLine(Math.Ceiling(4.1)); // 5 => Büyük sayıya yuvarlar.
            Console.WriteLine(Math.Round(4.5)); // 4 => 0.5 gibi olduğunda çift sayıya yuvarlar.
            Console.WriteLine(Math.Round(5.5)); // 6 => 0.5 gibi olduğunda çift sayıya yuvarlar.


            Console.ReadKey();
        }
    }
}
