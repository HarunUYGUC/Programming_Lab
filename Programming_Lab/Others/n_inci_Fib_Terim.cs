using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class n_inci_Fib_Terim
    {
        static int fib_terim_n(int x)
        {
            int a = 1; // 1. Terim.
            int b = 1; // 2. Terim.
            int adet = 2; // a ve b baştan tanımlı.
            int top = 0; // Diğer terimleri bulmak için.

            if (x == 1 || x == 2)
            {
                return a;
            }
            else
            {
                while (adet < x)
                {
                    top = a + b;
                    a = b;
                    b = top;
                    adet += 1;
                }

                return b;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Bir tam sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n}. Fib sayısı: {fib_terim_n(n)}");
        }
    }
}
