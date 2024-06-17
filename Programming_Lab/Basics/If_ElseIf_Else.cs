using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Basics
{
    class If_ElseIf_Else
    {
        static void Main(string[] args)
        {
            var number = 11;

            if (number == 10)
            {
                Console.WriteLine("Number is 10.");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20.");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20.");
            }

            // Yukarıdaki if-else mantığını bu şekilde tek satırda da yapabiliriz.
            Console.WriteLine(number == 10 ? "Number is 10." : "Number is not 10.");

            
            // Comparison Operators

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100.");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200."); ;
            }
        }
    }
}
