using RazFinance.Calculators;
using NUnit.Framework;

namespace RazFinance.Test.Calculators
{
    public class BalanceSheetTest
    {
        [Test]
        public void CurrentRatio_CorrectCalculation()
        {
            Assert.AreEqual(20f, BalanceSheet.CurrentRatio(5000, 100000));
        }

        [Test]
        public void DebtToIncomeRatio_CorrectCalculation()
        {
            Assert.AreEqual(0.2f, BalanceSheet.DebtToIncomeRatio(5000, 25000));
        }
    }
}
