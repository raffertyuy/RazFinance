using System;
using System.Collections.Generic;
using System.Text;

namespace RazFinance.Calculators
{
    public static class BalanceSheet
    {
        public static float CurrentRatio(float debt, float netWorth) => netWorth / debt;

        public static float DebtToIncomeRatio(float debt, float netIncome) => debt / netIncome;
    }
}
