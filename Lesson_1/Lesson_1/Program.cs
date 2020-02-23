using System;

namespace Hello_200212
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string name; //= args[0];
                Console.Write("Wpisz swoje imie: ");
                //samo write powoduje ze pytanie i odp beda w tej samej linii
                name = Console.ReadLine();
                Console.WriteLine("Hello" + " " + name);

                Console.Write("Wpisz ile masz lat: ");

                int age;
                bool result = int.TryParse(Console.ReadLine(), out age); // change string to ing 
                                                                         //int age = int.Parse(Console.ReadLine()); // change string to ing 

                if (age > 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // zmiana koloru tekstu
                    Console.WriteLine("Brawo jesteś pełnoletni, możesz wypić browara!");
                }
                else if (result == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // zmiana koloru tekstu
                    Console.WriteLine("wprowadziłeś niepoprawny wiek!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue; // zmiana koloru tekstu
                    Console.WriteLine("możemy Ci zaoferować mleko");
                }

                Console.ReadKey();  // powstrzymywanie konsoli przed zamknięciem :)
                Console.Clear(); // wyczyszenie ekranu
                Console.ResetColor(); // resetowanie koloru
            }
        }

    }

}
