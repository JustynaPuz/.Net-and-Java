using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("KnapsackProblemTest"), InternalsVisibleTo("GUI")]


namespace KnapsackProblem
{
    internal class Item
    {
        int value = -1;
        int weight = -1;
        bool isIn = false;
        int idNumber = 0;
        float valueToWeightRatio = 0;

        public Item(int value, int weight, int idNumber)
        {
            this.value = value;
            this.weight = weight;
            this.idNumber = idNumber;

            if (weight > 0)
            {
                valueToWeightRatio = (float)value / (float)weight;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
        }

        public int getValue() { return value; }
        public int getWeight() { return weight; }

        public float getValueToWeighRatio() { return valueToWeightRatio; }

        public void setIsIn(bool isIn) { this.isIn = isIn; }

        public bool getIsIn() { return isIn; }

        public override string ToString()
        {
            return " Number: " + idNumber + " Value: " + value + " Weight: " + weight + " Ratio: " + valueToWeightRatio;
        }


    }
}
