using System;
using System.Collections.Generic;

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
                Console.WriteLine($"{(int)DebtorUtils.DebtorSwitchEnum.ADD_DEBTOR} --> Dodaj dłużnika");
                Console.WriteLine($"{(int)DebtorUtils.DebtorSwitchEnum.EDIT_DEBTOR} --> Modyfikuj dłużnika");
                Console.WriteLine($"{(int)DebtorUtils.DebtorSwitchEnum.REMOVE_DEBTOR} --> Usuń dłużnika");
                Console.WriteLine($"{(int)DebtorUtils.DebtorSwitchEnum.SHOW_ALL_DEBTORS} --> Wyświetl wszystkich dłużników");
                Console.WriteLine($"{(int)DebtorUtils.DebtorSwitchEnum.SHOW_ALL_MONEY} --> Wyświetl sumę pożyczek");
                Console.WriteLine($"{(int)DebtorUtils.DebtorSwitchEnum.EXIT} --> Wyjście z programu");
                Console.Write("Wybrana operacja: ");
                int number = 0;
                Int32.TryParse(Console.ReadLine(), out number);
                DebtorSwitch.RunLogic(number, person);
            }
        }
    }
}
