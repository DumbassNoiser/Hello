
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Wpisz swoje imie: ");
                string name = Console.ReadLine();

                Console.WriteLine("Witaj " + name);

                Console.Write(" Wpisz ile masz lat: ");

                int age;
                bool result = int.TryParse(Console.ReadLine(), out age);

                if (age > 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Brawo, jesteś pełnoletni możesz wypić browara");
                }
                else if (result == false)
                {
                    Console.WriteLine("Wprowadziłeś zły wiek");
                }
                else
                {
                    Console.WriteLine("Możemy Ci zaoferować mleko");
                }

                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            }                   
        }
    }
}
