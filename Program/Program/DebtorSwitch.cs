using System;
using System.Collections.Generic;

namespace Program
{
    class DebtorSwitch
    {
        public static void RunLogic(int number, List<Persons> person){
            switch (number)
                {
                    case 1:
                        DebtorLogic.AddNewPerson(person);
                        DebtorLogic.ShowAllPerson(person);
                        break;
                    case 2:
                        DebtorLogic.ShowAllPerson(person);
                        DebtorLogic.EditPerson(person);
                        break;
                    case 3:
                        DebtorLogic.ShowAllPerson(person);
                        DebtorLogic.RemovePerson(person);
                        break;
                    case 4:
                        DebtorLogic.ShowAllPerson(person);
                        break;
                    case 5:
                        DebtorLogic.ShowAllMoney(person);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        DebtorLogic.ShowMessage("Nie ma takiej operacji!");
                        break;
                }
            }
    }
}
