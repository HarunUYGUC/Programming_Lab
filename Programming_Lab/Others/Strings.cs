using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programming_Lab.Others
{
    internal class Strings
    {
        static void Main(string[] args)
        {
            string[] isimler = {"Leon S. Kennedy","Jill Valentine","Tifa Lockhart",
                                "Kyle Crane","Ada Wong"};

            for (int i = 0; i < isimler.Length; i++)
                Console.WriteLine(isimler[i]);

            Console.WriteLine("--------------");

            foreach (string eleman in isimler)
                Console.WriteLine(eleman);
        }
    }
}
