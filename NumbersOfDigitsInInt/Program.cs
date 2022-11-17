using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersOfDigitsInInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int number = 0, count = 0;
                Console.Write("Skriv ditt nummer :");
                number = Convert.ToInt32(Console.ReadLine());
                while (number > 0)
                {
                    number = number / 10;
                    count++;
                }
                Console.WriteLine("Mengden av sifre er : " + count);
                Console.ReadLine();

        }
    }
}
