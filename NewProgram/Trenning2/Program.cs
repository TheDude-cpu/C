using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trenning2
{
    class Program
    {
        static void Main(string[] args)
        {
            // wyswietlanie w konsoli prostokatu o szerokosci x oraz wysokoci y
            // x oraz y podaje uzytkownikowi, prostokat zbudowany jest z "*"
            Console.WriteLine("Podaj szerokosc:");
            string xs = Console.ReadLine();
            //Console.WriteLine("Podana szerokosc to" +" " + xs);
            Console.WriteLine("Podaj wysokosc:");
            string ys = Console.ReadLine();
            //Console.WriteLine("Podana szerokosc to" +" " + ys);

            int x = int.Parse(xs); // convert string to ing
            int y = int.Parse(ys);

            for (int i = 0; i<y; i++) // or i <= y-1 or i<y
            {
                for (int j = 0; j <x; j++)
                {
                    Console.Write("*'");  // obok siebie
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
