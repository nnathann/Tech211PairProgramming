using CodeKataDanyal_Nathan;
namespace MoneyProblemTests
{
    public class Tests
    {
        [TestCase(5.47, "$20: 0, $10: 0, $5: 1, $2: 0, $1: 0, $0.50: 0, $0.20: 2, $0.10: 0, $0.05: 2, $0.01: 2")]
        [TestCase(20.80, "$20: 1, $10: 0, $5: 1, $2: 0, $1: 0, $0.50: 1, $0.20: 1, $0.10: 1, $0.05: 0, $0.01: 0")]
        [TestCase(1, "$20: 0, $10: 0, $5: 0, $2: 0, $1: 1, $0.50: 0, $0.20: 0, $0.10: 0, $0.05: 0, $0.01: 0")]
        [TestCase(0, "$20: 0, $10: 0, $5: 0, $2: 0, $1: 0, $0.50: 0, $0.20: 0, $0.10: 0, $0.05: 0, $0.01: 0")]
        [TestCase(100, "$20: 5, $10: 0, $5: 0, $2: 0, $1: 0, $0.50: 0, $0.20: 0, $0.10: 0, $0.05: 0, $0.01: 0")]
        [TestCase(0.50, "$20: 0, $10: 0, $5: 0, $2: 0, $1: 0, $0.50: 1, $0.20: 0, $0.10: 0, $0.05: 0, $0.01: 0")]
        [TestCase(38.86, "$20: 1, $10: 1, $5: 1, $2: 1, $1: 1, $0.50: 1, $0.20: 1, $0.10: 1, $0.05: 1, $0.01: 1")]
        public void GivenMoney_GetValue_ReturnExpectedString(double money, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.MoneyProblem(money)));
        }
    }
}