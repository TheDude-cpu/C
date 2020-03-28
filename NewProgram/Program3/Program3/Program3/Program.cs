using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            // pseudo losowosc w c#

            //class
            Random rnd = new Random();  // klasa rnd przyjmuje nowy obiekt klasy Random
            int los = rnd.Next(1,11);
            int myNumber;

            Console.WriteLine("zgadnij liczbe z zakresu 1-10");

            do
            {
                Console.Write("Podaj liczbe: ");
                myNumber = int.Parse(Console.ReadLine());
                if(los < myNumber)
                {
                    Console.WriteLine("Podana liczba jest wieksza niz wylosowana. Sproboj ponownie");
                }
                else if (los == myNumber)
                {
                    Console.WriteLine("Odgadles wylosowna liczbe");
                }
                else
                {
                    Console.WriteLine("Podana liczba jest mniejsza niz wylosowana. Sproboj ponownie");
                }
            } while (los != myNumber);



            Console.ReadKey();
        }
    }
}
