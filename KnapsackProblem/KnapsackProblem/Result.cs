using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("KnapsackProblemTest"), InternalsVisibleTo("GUI")]
namespace KnapsackProblem
{
    internal class Result
    {
        List<Item> itemsIn = new List<Item>();
        int totalValue;
        int totalWeight;

        public Result(List<Item> items)
        {
            itemsIn = items;
            totalValue = CalculateTotalValue();
            totalWeight = CalculateTotalWeight();
        }

        public List<Item> getItemsIn() { return itemsIn; }

        public int CalculateTotalValue()
        {
            int value = 0;
            foreach (Item item in itemsIn)
            {
                value += item.getValue();
            }
            return value;
        }

        public int CalculateTotalWeight()
        {
            int value = 0;
            foreach (Item item in itemsIn)
            {
                value += item.getWeight();
            }
            return value;
        }


        public override string ToString()
        {
            string output = "";

            foreach (Item item in itemsIn)
            {
                output = output + item.ToString() + "\r\n";
            }
            output = output + "Total value: " + totalValue + " Total weight: " + totalWeight;
            return output;
        }
    }
}

