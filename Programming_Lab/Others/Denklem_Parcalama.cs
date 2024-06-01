/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Denklem_Parcalama
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen ax^2 + bx + c = 0 biçimindenki denklemi a, b, c'lerini bulma.
            // 3x^2 + 4x + 5 = 0

            // 1. Yöntem

            int a, b, c;

            Console.Write("Denklemi giriniz: ");
            string d = Console.ReadLine();

            string[] s = d.Split(' ');

            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);

            Console.WriteLine("-----------");

            string[] x1 = s[0].Split('x');
            a = Convert.ToInt32(x1[0]);

            string[] x2 = s[2].Split('x');
            b = Convert.ToInt32(x2[0]);

            c = Convert.ToInt32(s[4]);

            Console.WriteLine($"a: {a}, b: {b}, c: {c}");


            // 2. Yöntem

            Console.Write("Denklemi giriniz: ");
            string ax = Console.ReadLine();

            s = ax.Split('x');
            string[] t = s[1].Split(' ');
            string[] v = s[2].Split(' ');

            a = Convert.ToInt32(s[0]);
            b = Convert.ToInt32(t[2]);
            c = Convert.ToInt32(v[2]);

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
}
*/
