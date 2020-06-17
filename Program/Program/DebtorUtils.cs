using System;
using System.Collections.Generic;

namespace Program
{
    class DebtorUtils
    {
        public enum DebtorSwitchEnum
        {
            ADD_DEBTOR = 1,
            EDIT_DEBTOR = 2,
            REMOVE_DEBTOR = 3,
            SHOW_ALL_DEBTORS = 4,
            SHOW_ALL_MONEY = 5,
            EXIT = 6,
        }
        public static double GetMoneyWithPercent(List<Persons> person)
        {
            double sum = 0;
            foreach (Persons debtor in person)
            {
                sum += debtor.Money + debtor.Money * (debtor.Percent / 100);
            }

            return sum;
        }

        public static double GetMoneyWithoutPercent(List<Persons> person)
        {
            double sum = 0;
            foreach (Persons debtor in person)
            {
                sum += debtor.Money;
            }

            return sum;
        }

    }
}
