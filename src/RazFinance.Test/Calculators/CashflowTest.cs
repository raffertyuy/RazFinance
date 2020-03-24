using RazFinance.Calculators;
using NUnit.Framework;

namespace RazFinance.Test.Calculators
{
    public class CashflowTest
    {
        [Test]
        public void NetIncome_CorrectCalculation()
        {
            Assert.AreEqual(15000f, Cashflow.NetIncome(25000, 10000));
        }

        [Test]
        public void ExpenseRatio_CorrectCalculation()
        {
            Assert.AreEqual(0.2f, Cashflow.ExpenseRatio(5000, 25000));
        }

        [Test]
        public void SavingsRatio_CorrectCalculation()
        {
            Assert.AreEqual(0.8f, Cashflow.SavingsRatio(25000, 5000));
        }
    }
}
