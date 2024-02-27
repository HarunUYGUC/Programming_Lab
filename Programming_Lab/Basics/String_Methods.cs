/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab
{
    class String_Methods
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Harun Uyguç.";

            // 23
            var result = sentence.Length;
            Console.WriteLine(result);

            // My name is Harun Uyguç.
            var result2 = sentence.Clone();
            Console.WriteLine(result2);

            // False
            var result3 = sentence.EndsWith("ğ");
            Console.WriteLine(result3);

            // True
            var result4 = sentence.StartsWith("My name");
            Console.WriteLine(result4);

            // 3
            var result5 = sentence.IndexOf("name");
            Console.WriteLine(result5);

            // 2
            var result6 = sentence.IndexOf(" ");
            Console.WriteLine(result6);

            // 16
            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result7);

            // Hello, My name is Harun Uyguç.
            var result8 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result8);

            // name is Harun Uyguç.
            var result9 = sentence.Substring(3);
            Console.WriteLine(result9);

            // name
            var result10 = sentence.Substring(3, 4);
            Console.WriteLine(result10);

            // my name is harun uyguç.
            var result11 = sentence.ToLower();
            Console.WriteLine(result11);

            // MY NAME İS HARUN UYGUÇ.
            var result12 = sentence.ToUpper();
            Console.WriteLine(result12);

            // My-name-is-Harun-Uyguç.
            var result13 = sentence.Replace(" ", "-");
            Console.WriteLine(result13);

            // My name
            var result14 = sentence.Remove(7);
            Console.WriteLine(result14);

            // My is Harun Uyguç.
            var result15 = sentence.Remove(2, 5);
            Console.WriteLine(result15);
        }
    }
}
*/
