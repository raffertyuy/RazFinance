using System;
using System.Collections.Generic;
using System.Text;

namespace RazFinance.Calculators
{
    public static class Cashflow
    {
        public static float NetIncome(float income, float expense) => income - expense;

        public static float ExpenseRatio(float expense, float income) => expense / income;

        public static float SavingsRatio(float income, float expense) => (income - expense) / income;
    }
}
