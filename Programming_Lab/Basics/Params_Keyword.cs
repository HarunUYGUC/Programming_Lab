using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Basics
{
    internal class Params_Keyword
    {
        static void Main(string[] args)
        {
            int number1 = 2;
            int number2 = 10;
            int number3 = 4;

            Console.WriteLine(Add4(number1, number2));
            Console.WriteLine(Add4(number1, number2, number3));
        }

        // Params anahtar kelimesi ile istediğimiz kadar değişkeni
        // bu fonksiyona gönderebiliriz.
        // Params sayesinde oluşturduğumuz int dizisine (int[]) istediğimiz
        // kadar değişkeni gönderebiliyoruz.
        // Kullandığımız hesap makinelerinde olduğu gibi.

        static int Add4(params int[] numbers)
        {
            // number değişkeni bir int dizisi olduğu için ona ait olan
            // .Sum() hazır metotunu kullanabiliyoruz.
            // Bu fonksiyon, gönderdiğimiz sayıların toplamını hesaplıyor.
            return numbers.Sum();
        }
    }
}
