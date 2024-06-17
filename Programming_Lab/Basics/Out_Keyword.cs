using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Basics
{
    internal class Out_Keyword
    {
        static void Main(string[] args)
        {
            // Ref kullandığımızda değişkenin başta bir değeri olmalı fakat
            // out kullandığımızda değişkenin başta bir değeri olmasa da olur.
            int number1 = 20;
            int number2 = 100;

            var result2 = Add3(out number1, number2);

            Console.WriteLine(result2); // 130
            Console.WriteLine(number1); // 30
        }

        static int Add3(out int number1, int number2)
        {
            // Out anahtar kelimesi de ref anahtar kelimesi gibi çalışır
            // fakat out kullanıldığında bu değişkenin değerini değiştirmek zorundayız.
            number1 = 30;
            return number1 + number2;
        }
    }
}
