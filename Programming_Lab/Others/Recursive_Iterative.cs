using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Others
{
    internal class Recursive_Iterative
    {
        static void diziBilgiYaz(Array arr)
        {
            Console.WriteLine("Dizinin Eleman Sayısı = " + arr.Length);
            Console.WriteLine("Dizinin Boyutu = " + arr.Rank);
        }

        static void diziEkranaYaz(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + ", ");
        }

        static int fak_ite(int n)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
                f = f * i;

            return f;
        }

        static int fak_rec(int n)
        {
            if (n == 0) return 1;
            return n * fak_rec(n - 1);
        }

        // Iterative Fibonacci için başka yöntem.
        static int fib(int x)
        {
            int a = 1, b = 1, top = 0, adet = 2;

            if (x == 0) return 0;

            while (adet < x)
            {
                top = a + b;
                a = b;
                b = top;
                adet++;
            }

            return b;
        }

        static int fib_ite(int n)
        {
            if (n == 0) return 0;
            else if (n == 1 || n == 2) return 1;
            else
            {
                int a = 0, b = 1, temp = 0;

                for (int i = 0; i <= n - 2; i++)
                {
                    temp = a;
                    a = b;
                    b = b + temp;
                }

                return b;
            }
        }

        static int fib_rec(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return fib_rec(n - 1) + fib_rec(n - 2);
        }

        static int us_ite(int x, int n)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
                f *= x;

            return f;
        }

        static int us_rec(int x, int n)
        {
            if (n == 0) return 1;
            else if (n == 1) return x;
            else if (n % 2 == 0) return us_rec(x * x, n / 2);
            else return x * us_rec(x * x, n / 2);
        }

        static void Main(string[] args)
        {
            int[] a = new int[5];
            diziBilgiYaz(a);

            int[,] b = new int[5, 5];
            diziBilgiYaz(b);


            int[] c = {1, 2, 3, 4 , 5};
            diziEkranaYaz(c);
            Console.WriteLine();


            Console.Write("Hesaplanmasını istediğiniz faktoriyel: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " sayısının faktoriyeli, ite = " +  fak_ite(n));
            Console.WriteLine(n + " sayısının faktoriyeli, rec = " + fak_rec(n));


            Console.Write("Hesaplanmasını istediğiniz fibonacci: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + ". fibonacci değeri, diğer ite yöntemi = " + fib(n));
            Console.WriteLine(n + ". fibonacci değeri, ite = " + fib_ite(n));
            Console.WriteLine(n + ". fibonacci değeri, rec = " + fib_rec(n));


            Console.Write("Üssünün hesaplanmasını istediğiniz sayı: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üssü kaç olacak?: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ite => " + d + "^" + e + " = " + us_ite(d, e));
            Console.WriteLine("rec => " + d + "^" + e + " = " + us_rec(d, e));
        }
    }
}
