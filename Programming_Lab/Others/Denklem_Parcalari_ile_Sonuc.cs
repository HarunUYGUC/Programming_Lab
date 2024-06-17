using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Denklem_Parcalari_ile_Sonuc
    {
        static void Main(string[] args)
        {
            Console.Write("Fotoğraftaki formatta bir denklem giriniz: ");
            string denklem = Console.ReadLine();

            Console.WriteLine("-----------------");
            
            string[] s = denklem.Split(' ');

            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);

            Console.WriteLine("-----------------");

            uint sabit = Convert.ToUInt32(s[s.Length - 1]);

            Console.WriteLine(sabit);

            Console.WriteLine("-----------------");

            uint[] ps = new uint[s.Length - 2];
            uint[] us = new uint[s.Length - 2];
            int n = 0;

            for (int i = 0; i < s.Length - 2; i += 2)
            {
                string[] p = s[i].Split('x');
                ps[n] = Convert.ToUInt32(p[0]);

                string[] u = s[i].Split('^');
                us[n] = Convert.ToUInt32(u[1]);

                n++;
            }

            for (int i = 0; i < ps.Length; i++)
                Console.WriteLine(ps[i]);

            Console.WriteLine("-----------------");

            for (int i = 0; i < us.Length; i++)
                Console.WriteLine(us[i]);

            Console.WriteLine("-----------------");

            double sonuc = 0;

            for (int i = 0; i < ps.Length; i++)
            {
                sonuc += Math.Pow(ps[i] + us[i], sabit);
            }

            Console.WriteLine(sonuc);
        }
    }
}
