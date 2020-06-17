using System;
using System.Collections.Generic;

namespace Program
{
    class DebtorLogic
    {
        public static void ShowAllPerson(List<Persons> person)
        {
            int i = 1;
            foreach (Persons debtor in person)
            {
                string date = debtor.Date.ToString("dd-MM-yyyy");
                Console.Write($"{i}. ");
                Console.WriteLine($"{debtor.Name}");
                Console.WriteLine($"Pożyczona kwota: {debtor.Money} ZŁOTYCH");
                Console.WriteLine($"Kwota do oddania (+ %) {debtor.Money + debtor.Money * (debtor.Percent / 100)}");
                Console.WriteLine($"Data pożyczki: {date}");
                i++;
            }
        }

        public static void AddNewPerson(List<Persons> person)
        {
            Persons newPerson = new Persons();
            Console.Write("Wpisz imię i nazwisko: ");
            newPerson.Name = Console.ReadLine();

            Console.Write("Wpisz pożyczoną kwotę: ");
            double money;
            Double.TryParse(Console.ReadLine(), out money);
            newPerson.Money = money;

            Console.Write("Wpisz procent pożyczki: ");
            double percent;
            Double.TryParse(Console.ReadLine(), out percent);
            newPerson.Percent = percent;

            newPerson.Date = DateTime.Now;
            person.Add(newPerson);
            ShowMessage("Pomyślnie dodano dłużnika!");
        }
        public static void EditPerson(List<Persons> person)
        {
            try
            {
                Console.Write("Podaj numer dłużnika, którego dane chcesz edytować: ");
                int code = int.Parse(Console.ReadLine());
                Console.Write("Podaj imię i nazwisko: ");
                person[code - 1].Name = Console.ReadLine();
               
                Console.Write("Podaj kwotę pożyczki: ");
                double money; 
                Double.TryParse(Console.ReadLine(), out money);
                person[code - 1].Money = money;
                Console.Write("Wpisz procent pożyczki: ");
                double percent;
                Double.TryParse(Console.ReadLine(), out percent);
                person[code - 1].Percent = percent;

                ShowMessage("Pomyślnie edytowano dłużnika!");
            }
            catch
            {
                ShowMessage("Edycja nieudana! Spróbuj ponownie!");
            }
        }
        public static void RemovePerson(List<Persons> person)
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

        public static void ShowAllMoney(List<Persons> person) 
        {
            double sum = 0;
            foreach (Persons debtor in person)
            {
                sum += debtor.Money;
            }
            Console.WriteLine("");
            Console.WriteLine($"Suma pożyczek: {sum}"); //Suma wszystkich długów
            Console.WriteLine($"Suma pożyczek z procentem: {PercentFunction(person)}");
            Console.WriteLine("");
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine("");
            Console.WriteLine(message);
            Console.WriteLine("");
        }
        private static double PercentFunction(List<Persons> person)
        {
            double sum = 0;
            foreach (Persons debtor in person)
            {
                sum += debtor.Money + debtor.Money * (debtor.Percent / 100);
            }

            return sum;
        }
    }
}
