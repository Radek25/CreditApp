using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new List<Persons>();
            Console.WriteLine("Witaj!");
            while (true)
            {
                Console.WriteLine("Wybierz operacje z listy:");
                Console.WriteLine("1 --> Dodaj dłużnika");
                Console.WriteLine("2 --> Modyfikuj dłużnika");
                Console.WriteLine("3 --> Usuń dłużnika");
                Console.WriteLine("4 --> Wyświetl wszystkich dłużników");
                Console.WriteLine("5 --> Wyświetl sumę pożyczek");
                Console.WriteLine("6 --> Wyjście z programu");
                Console.Write("Wybrana operacja: ");
                int number = 0;
                Int32.TryParse(Console.ReadLine(), out number);
                DebtorSwitch.RunLogic(number, person);
            }
        }
    }
}
