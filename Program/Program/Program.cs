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
                Console.WriteLine("5 --> Wyjście z programu");
                Console.Write("Wybrana operacja: ");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        AddNewPerson(person);
                        ShowAllPerson(person);
                        break;
                    case 2:
                        ShowAllPerson(person);
                        EditPerson(person);
                        break;
                    case 3:
                        ShowAllPerson(person);
                        RemovePerson(person);
                        break;
                    case 4:
                        ShowAllPerson(person);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        ShowMessage("Nie ma takiej operacji!");
                        break;
                }
            }
        }
        private static void ShowAllPerson(List<Persons> person)
        {
            int i = 1;
            foreach (Persons debtor in person)
            {
                Console.Write($"{i}. ");
                Console.WriteLine($"{debtor.Name}  {debtor.Surname}");

                i++;
            }
        }

        private static void AddNewPerson(List<Persons> person)
        {
            Persons newPerson = new Persons();
            Console.Write("Wpisz imię: ");
            newPerson.Name = Console.ReadLine();

            Console.Write("Wpisz nazwisko: ");
            newPerson.Surname = Console.ReadLine();

            Console.Write("Wpisz pożyczoną kwotę: ");
            int money = int.Parse(Console.ReadLine());
            newPerson.Money = money;

            Console.Write("Wpisz datę pożyczki (DD-MM-RRRR): ");
            string date = Console.ReadLine();
            newPerson.Date = date;
            person.Add(newPerson);
            ShowMessage("Pomyślnie dodano dłużnika!");
        }
        private static void EditPerson(List<Persons> person)
        {
            try
            {
                Console.Write("Podaj numer dłużnika, którego dane chcesz edytować: ");
                int code = int.Parse(Console.ReadLine());
                Console.Write("Podaj imię: ");
                person[code - 1].Name = Console.ReadLine();
                Console.Write("Podaj nazwisko: ");
                person[code - 1].Surname = Console.ReadLine();
                Console.Write("Podaj kwotę pożyczki: ");
                person[code - 1].Money = 12; //money
                Console.Write("Podaj datę pożyczki: ");
                person[code - 1].Date = Console.ReadLine();
                ShowMessage("Pomyślnie edytowano dłużnika!");
            }
            catch
            {
                ShowMessage("Edycja nieudana! Spróbuj ponownie!");
            }
        }
        private static void RemovePerson(List<Persons> person)
        { 
                Console.Write("Podja numer dłużnika, którego chcesz usunąć: ");
                int code = int.Parse(Console.ReadLine());
            try
            {
                person.Remove(person[code - 1]);
                ShowMessage("Usunięto dłużnika!");
            }
            catch
            {
                ShowMessage("Nie udało się uzunąć użytkownika! Spróbuj ponownie!");
            }
        }
       
        private static void ShowMessage (string message)
        {
            Console.WriteLine("");
            Console.WriteLine(message);
            Console.WriteLine("");
        }
    }
}
