using System.Diagnostics;

namespace MatrixMulitplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = { { 2, 3, 4, 5 }, { 6, 7, 8, 9 } };
            int[,] matrix2 = { { 2, 3 }, { 4, 5 }, { 6, 7 }, { 8, 9 } };
            int seed1 = 90;
            int seed2 = 67;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            //  TwoMatrixMultiplication multi = new TwoMatrixMultiplication(new Matrix(matrix1), new Matrix(matrix2), 100);
            TwoMatrixMultiplication multi = new TwoMatrixMultiplication(new Matrix(500, 500, seed1), new Matrix(500, 500, seed2));
            Matrix reslut1 = multi.multiplyTwoMatrixThreads(4);
            stopwatch.Stop();
            Console.WriteLine("4 threads - time in milisec: " + stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Restart();

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            // TwoMatrixMultiplication multi2 = new TwoMatrixMultiplication(new Matrix(matrix1), new Matrix(matrix2), 1);
            TwoMatrixMultiplication multi2 = new TwoMatrixMultiplication(new Matrix(500, 500, seed1), new Matrix(500, 500, seed2));
            Matrix result2 = multi2.multiplyTwoMatrixThreads(1);
            stopwatch2.Stop();
            Console.WriteLine("1 thread - time in milisec: " + stopwatch2.Elapsed.TotalMilliseconds);

            stopwatch.Restart();
            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            // TwoMatrixMultiplication multi2 = new TwoMatrixMultiplication(new Matrix(matrix1), new Matrix(matrix2), 1);
            TwoMatrixMultiplication multi3 = new TwoMatrixMultiplication(new Matrix(500, 500, seed1), new Matrix(500, 500, seed2));
            Matrix result3 = multi3.multiplyTwoMatrixParallel(4);
            stopwatch3.Stop();
            Console.WriteLine("Parallel 4 threads- time in milisec: " + stopwatch3.Elapsed.TotalMilliseconds);


            Console.WriteLine(reslut1.AreEqualTo(result3) ? "Matrixes are equal" : "Matrixes are not equal");



        }
    }
}
