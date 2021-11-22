using NUnit.Framework;
using WebTrainingRoom;
namespace NUnitTestProject
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AddMethodTest()
        {
            Calculator add = new Calculator();
            int result = add.Add(15, 65);
            Assert.That(result, Is.EqualTo(80));
        }

        [Test]
        [TestCase(15, 35, 50)]
        [TestCase(10, 45, 55)]
        [TestCase(20, 50, 60)]
        public void AddMethodTest(int num1, int num2, int expected)
        {
            Calculator add = new Calculator();
            int result = add.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }
    }
}