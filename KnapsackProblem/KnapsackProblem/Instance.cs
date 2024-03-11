using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("KnapsackProblemTest"), InternalsVisibleTo("GUI")]

namespace KnapsackProblem
{
    internal class Instance
    {
        List<Item> items = new List<Item>();
        int n = 0;
        int seed = 0;

        public Instance(int number, int seed)
        {
            this.n = number;
            this.seed = seed;
            FillListWithItems();
        }

        public Instance(int number, List<Item> items)
        {
            this.n = number;
            this.items = items;
        }

        public void FillListWithItems()
        {
            Random rnd = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                items.Add(new Item(rnd.Next(10), rnd.Next(1, 11), i));
            }
        }



        public List<Item> GetItems() { return items; }

        public override string ToString()
        {
            string output = "";

            foreach (Item item in items)
            {
                output = output + item.ToString() + "\n";
            }
            return output;
        }

        public Result SolveAproximation(int capacity)
        {

            items.Sort((item1, item2) => item2.getValueToWeighRatio().CompareTo(item1.getValueToWeighRatio()));

            Console.WriteLine("Posortowane: \n");

            string output = "";

            foreach (Item item in items)
            {
                output = output + item.ToString() + "\n";
            }
            Console.WriteLine(output);


            List<Item> itemsIn = new List<Item>();
            int totalWeight = 0;

            foreach (Item item in items)
            {
                if (totalWeight + item.getWeight() <= capacity)
                {
                    item.setIsIn(true);
                    itemsIn.Add(item);
                    totalWeight += item.getWeight();
                }

            }
            return new Result(itemsIn);


        }

        public int SolveDynamic(int capacity)
        {
            int[,] A = new int[n, capacity + 1];

            for (int x = 0; x < capacity + 1; x++)
            {
                if (items[0].getWeight() <= x)
                {
                    A[0, x] = items[0].getValue();
                }

            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < capacity + 1; j++)
                {
                    if (items[i].getWeight() > j)
                    {
                        A[i, j] = A[i - 1, j];
                    }
                    else
                    {
                        A[i, j] = Math.Max(A[i - 1, j], A[i - 1, j - items[i].getWeight()] + items[i].getValue());
                    }
                }
            }
            return A[n - 1, capacity];
        }


    }
}
