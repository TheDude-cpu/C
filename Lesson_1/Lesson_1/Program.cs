using System;

namespace Hello_200212
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ; ) // loop infinit
            {
                Greeting();

                Age();

                Settings();
            }
        }

        /// <summary>
        /// min and max int value
        /// </summary>
        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("MaxInt =" + maxInt);
            Console.WriteLine("MinInt =" + minInt);
            Console.WriteLine("MaxLong =" + maxLong);
            Console.WriteLine("MinLong =" + minLong);


        }

        /// <summary>
        /// settings
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();  // powstrzymywanie konsoli przed zamknięciem :)
            Console.Clear();
            Console.ResetColor(); // resetowanie koloru
        }

        /// <summary>
        /// check user's age
        /// </summary>
        private static void Age()
        {
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
        }

        /// <summary>
        /// write user's greeting
        /// </summary>
        private static void Greeting()
        {
            string name; //= args[0];
            Console.Write("Wpisz swoje imie: ");
            //samo write powoduje ze pytanie i odp beda w tej samej linii
            name = Console.ReadLine();
            Console.WriteLine("Hello" + " " + name);
        }
    }

}
