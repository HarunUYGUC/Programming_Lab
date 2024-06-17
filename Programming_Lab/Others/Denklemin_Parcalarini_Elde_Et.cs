using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Denklemin_Parcalarini_Elde_Et
    {
        static void Main(string[] args)
        {
            Console.Write("Fotoğraftaki formatta bir denklem giriniz: ");
            string denklem = Console.ReadLine();

            Console.WriteLine("-----------------");

            string[] p = denklem.Split('+');

            for (int i = 0; i < p.Length; i++)
            {
                p[i] = p[i].Trim();
            }

            for (int i = 0; i < p.Length; i++)
                Console.WriteLine(p[i]);

            Console.WriteLine("-----------------");

            string[] xs = new string[p.Length];

            for (int i = 0; i < p.Length; i++)
            {
                string[] x = p[i].Split('x');
                xs[i] = x[0];
            }

            for (int i = 0; i < xs.Length; i++)
                Console.WriteLine(xs[i]);

            Console.WriteLine("-----------------");

            string[] us = new string[p.Length];

            for (int i = 0; i < p.Length - 1; i++)
            {
                string[] u = p[i].Split('^');
                us[i] = u[1];
            }

            string[] c = p[p.Length - 1].Split('^');
            c = c[1].Split('=');
            us[p.Length - 1] = c[0].Trim();

            for (int i = 0; i < us.Length; i++)
                Console.WriteLine(us[i]);

            Console.WriteLine("-----------------");

            string sabit = c[1].Trim();
            int newSabit = Convert.ToInt32(sabit);

            Console.WriteLine(sabit);

            Console.WriteLine("-----------------");

            double anaTop = 0;
            double top;
            double ussu;

            for (int i = 0; i < p.Length; i++)
            {
                top = Convert.ToInt32(xs[i]) + Convert.ToInt32(us[i]);
                ussu = Math.Pow(top, newSabit);
                anaTop += ussu;
            }

            Console.WriteLine(anaTop);
        }
    }
}
