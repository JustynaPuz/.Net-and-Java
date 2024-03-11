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
            Console.WriteLine(n);
            Instance ins = new Instance(n, 20);
            Console.WriteLine(ins.ToString());
            int totalValue = ins.SolveDynamic(50);

            Result result = ins.SolveAproximation(50);
            Console.WriteLine("Dynamic: " + totalValue);
            Console.WriteLine(result.ToString());


        }
    }
}
