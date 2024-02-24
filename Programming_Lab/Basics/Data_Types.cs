/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace Programming_Lab.Basics
// olarak otomatik geldi fakat iki şekilde de doğru çalışıyor.
// Klasör ismini .name olarak almış yani.
namespace Programming_Lab
{
    class Data_Types
    {
        static void Main(string[] args)
        {
            double number5 = 10.4;
            decimal number6 = 10.4m;
            decimal number7 = 10.4M;
            decimal number8 = 10;

            var number9 = 'A';
            var number10 = 1;

            char character = 'A';

            bool condition = false;

            byte number4 = 255; // Pozitif olarak alabileceği maks değer.
            short number3 = 32767; // Pozitif olarak alabileceği maks değer.
            int number1 = 2147483647; // Pozitif olarak alabileceği maks değer.
            long number2 = 9223372036854775807; // Pozitif olarak alabileceği maks değer.

            Console.WriteLine("Condition is {0}", condition);

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);

            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Number8 is {0}", number8);

            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Character is {0}", (int)character); // Tip dönüşümü.

            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);

            Console.WriteLine("Number9 is {0}", number9);
            Console.WriteLine("Number10 is {0}", number10);
        }

        // enum keyword'u Main dışında tanımlanmalıdır.
        // Main'den önce veya sonra fark etmiyor.
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}
*/
