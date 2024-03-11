
using KnapsackProblem;

namespace KnapsackProblemTest
{
    [TestClass]
    public class TestResult
    {
        Result result = new Result(new List<Item> { new Item(10, 5, 1), new Item(6, 2, 2) });
        [TestMethod]
        public void TestCalculateTotalValue()
        {
            Assert.AreEqual(16, result.CalculateTotalValue());
        }

        [TestMethod]
        public void TesCalculateTotalWeight()
        {
            Assert.AreEqual(7, result.CalculateTotalWeight());
        }
    }
}