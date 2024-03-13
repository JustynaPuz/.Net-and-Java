using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("KnapsackProblemTest"), InternalsVisibleTo("GUI")]
namespace KnapsackProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter capacity: ");
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter seed: ");
            int seed = int.Parse(Console.ReadLine());

            Instance ins = new Instance(n, seed);
            Console.WriteLine(ins.ToString() + "\n");
            int totalValue = ins.SolveDynamic(capacity);

            Result result = ins.SolveAproximation(capacity);
            Console.WriteLine("Dynamic: " + totalValue);
            Console.WriteLine(result.ToString() + "\n");


        }
    }
}
