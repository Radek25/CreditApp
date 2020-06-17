using System;
using System.Collections.Generic;

namespace Program
{
    class DebtorSwitch
    {
        public static void RunLogic(int number, List<Persons> person){
            switch (number)
                {
                    case (int)DebtorUtils.DebtorSwitchEnum.ADD_DEBTOR:
                        DebtorLogic.AddNewPerson(person);
                        DebtorLogic.ShowAllPerson(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.EDIT_DEBTOR:
                        DebtorLogic.ShowAllPerson(person);
                        DebtorLogic.EditPerson(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.REMOVE_DEBTOR:
                        DebtorLogic.ShowAllPerson(person);
                        DebtorLogic.RemovePerson(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.SHOW_ALL_DEBTORS:
                        DebtorLogic.ShowAllPerson(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.SHOW_ALL_MONEY:
                        DebtorLogic.ShowAllMoney(person);
                        break;
                    case (int)DebtorUtils.DebtorSwitchEnum.EXIT:
                        Environment.Exit(0);
                        break;
                    default:
                        DebtorLogic.ShowMessage("Nie ma takiej operacji!");
                        break;
                }
            }
    }
}
