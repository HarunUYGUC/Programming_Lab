using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab
{
    class Ref_Keyword
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;

            var result2 = Add3(ref number1, number2);

            Console.WriteLine(result2); // 130
            Console.WriteLine(number1); // 30
        }
        
        // Ref, Referans demek yani adres.
        // number1 değişkeninin değerini değil adresini göndermiş oluyoruz bu şekilde.
        // Yani Main() fonksiyonu dışında bir yerde o değişkenin değerini değiştirdiğimizde
        // her yerde değişkenin değeri değişmiş oluyor.
        static int Add3(ref int number1, int number2) 
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
