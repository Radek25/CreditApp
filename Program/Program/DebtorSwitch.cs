using System;
using System.Collections.Generic;

namespace Program
{
    class DebtorSwitch //Klasa obsługująca wybór użytkownika w interface
    {
        public static void RunLogic(int number, List<Persons> person){
            switch (number) //W zależności od wybranego numeru załączamy odpowiedni case
                {
                    case (int)DebtorUtils.DebtorSwitchEnum.ADD_DEBTOR: //Dodanie dłużnika
                        DebtorLogic.AddNewPerson(person);
                        DebtorLogic.ShowAllPerson(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.EDIT_DEBTOR: //Edycja dłużnika
                        DebtorLogic.ShowAllPerson(person);
                        DebtorLogic.EditPerson(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.REMOVE_DEBTOR: //Usunięcie dłużnika
                        DebtorLogic.ShowAllPerson(person);
                        DebtorLogic.RemovePerson(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.SHOW_ALL_DEBTORS: //Wyświetlenie wszystkich dłużników
                        DebtorLogic.ShowAllPerson(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.SHOW_ALL_MONEY: //Wyświetlenie całości długów
                        DebtorLogic.ShowAllMoney(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.EXIT: //Wyjście z programu
                        Environment.Exit(0);
                        break;
                    default:
                        DebtorLogic.ShowMessage("Nie ma takiej operacji!"); //Zabezpieczenie przed wybraniem nieistniejącej indtrukcji w interface
                        break;
                }
            }
    }
}
