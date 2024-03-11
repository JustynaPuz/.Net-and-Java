
using KnapsackProblem;

namespace KnapsackProblemTest
{
    [TestClass]
    public class TestInstanceAprox
    {
        [TestMethod]
        public void TestAtLeastOneElement()
        {
            Instance instance = new Instance(1, 10);
            Result result = instance.SolveAproximation(100);

            Assert.AreEqual(1, result.getItemsIn().Count);
        }

        [TestMethod]
        public void TestNoElement()
        {
            Instance instance = new Instance(1, 10);
            Result result = instance.SolveAproximation(0);
            Assert.AreEqual(0, result.getItemsIn().Count);
        }

        [TestMethod]
        public void TestDoesOrderMatter()
        {
            List<Item> items1 = new List<Item> { new Item(1, 4, 1), new Item(2, 5, 2), new Item(3, 1, 3) };
            List<Item> items2 = new List<Item>(items1);
            items2.Reverse();

            Instance instance1 = new Instance(3, items1);
            Result result1 = instance1.SolveAproximation(4);

            Instance instance2 = new Instance(3, items2);
            Result result2 = instance2.SolveAproximation(4);

            Assert.AreEqual(result1.CalculateTotalValue(), result2.CalculateTotalValue());

        }

        [TestMethod]
        public void TestSpecificInstance()
        {
            List<Item> items = new List<Item> { new Item(1, 4, 1), new Item(2, 5, 2), new Item(3, 1, 3) };
            Instance instance = new Instance(3, items);
            Result result = instance.SolveAproximation(4);
            Assert.AreEqual(3, result.CalculateTotalValue());



        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestZeroWeight()
        {
            List<Item> items = new List<Item> { new Item(50, 0, 1), new Item(2, 0, 2), new Item(3, 0, 3) };
            Instance instance = new Instance(3, items);

            Assert.ThrowsException<DivideByZeroException>(() =>
            {
                Result result = instance.SolveAproximation(0);
            });

        }

        [TestMethod]
        public void TestAllItemsFitPerfectly()
        {
            List<Item> items = new List<Item> { new Item(1, 2, 1), new Item(2, 5, 2), new Item(3, 3, 3) };
            Instance instance = new Instance(3, items);
            Result result = instance.SolveAproximation(10);
            Assert.AreEqual(6, result.CalculateTotalValue());

        }
        [TestMethod]
        public void TestIdenticalRatio()
        {
            List<Item> items = new List<Item> { new Item(5, 10, 1), new Item(10, 20, 2), new Item(15, 30, 3) };
            Instance instance = new Instance(3, items);
            Result result = instance.SolveAproximation(30);
            Assert.AreEqual(15, result.CalculateTotalValue());


        }
        [TestMethod]
        public void TestLargeNumbers()
        {

            List<Item> items = new List<Item> { new Item(2000, 3000, 1), new Item(10000, 5000, 2), new Item(6000, 8000, 3) };
            Instance instance = new Instance(3, items);
            Result result = instance.SolveAproximation(8000);
            Assert.AreEqual(12000, result.CalculateTotalValue());
        }




    }
}