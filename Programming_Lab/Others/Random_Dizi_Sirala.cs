/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Random_Dizi_Sirala
    {
        static void yazdir(int[] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i] + ", ");
            }

            Console.WriteLine();
        }

        static int[] sirala(int[] d)
        {
            Array.Sort(d);
            return d;
        }

        static void Main(string[] args)
        {
            Console.Write("Dizinin kapasitesini giriniz: ");
            int kapasite = Convert.ToInt32(Console.ReadLine());
            int[] d = new int[kapasite];

            Random r = new Random();

            for (int i = 0; i < d.Length; i++)
            {
                d[i] = r.Next(10, 101);
            }

            yazdir(d);
            int[] sirali = sirala(d);
            yazdir(sirali);
        }
    }
}
*/
