using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GUI")]

namespace MatrixMulitplication
{
    internal class TwoMatrixMultiplication
    {
        Matrix first;
        Matrix second;
        Matrix result;
        int numberOfThreads;

        public TwoMatrixMultiplication(Matrix first, Matrix second)
        {
            this.first = first;
            this.second = second;
            if (second.getRows() != first.getColumns()) throw new Exception("Can't multiply matrixes");
            result = new Matrix(first.getRows(), second.getColumns());
            if (numberOfThreads > first.getRows())
            {
                Console.WriteLine("Too many threads! Not all of them will be used");
                this.numberOfThreads = first.getRows();
            }

        }

        public Matrix multiplyTwoMatrixThreads(int numthreads)
        {
            this.numberOfThreads = numthreads;
            int rows = first.getRows();

            Thread[] threads = new Thread[numberOfThreads];

            for (int t = 0; t < threads.Length; t++)
            {
                int startRow = t * rows / numberOfThreads;

                int endRow = (t + 1) * rows / numberOfThreads;

                threads[t] = new Thread(() => multiplyRows(startRow, endRow));
                threads[t].Name = String.Format("Thread {0}", t);
            }
            foreach (Thread t in threads)
            {
                t.Start();
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
            return result;
        }

        public Matrix multiplyTwoMatrixParallel(int numthreads)
        {
            this.numberOfThreads = numthreads;

            ParallelOptions parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = numberOfThreads };

            Parallel.For(0, first.getRows(), parallelOptions, x =>
            {

                int value = 0;
                for (int col = 0; col < second.getColumns(); col++)
                {
                    for (int i = 0; i < second.getRows(); i++)
                    {
                        value += first.getValue(x, i) * second.getValue(i, col);
                    }
                    result.setValue(x, col, value);
                    value = 0;
                }

            });

            return result;
        }

        private void multiplyRows(int startRow, int endRow)
        {
            for (int row = startRow; row < endRow; row++)
            {
                int value = 0;
                for (int col = 0; col < second.getColumns(); col++)
                {
                    for (int i = 0; i < second.getRows(); i++)
                    {
                        value += first.getValue(row, i) * second.getValue(i, col);
                    }
                    result.setValue(row, col, value);
                    value = 0;
                }
            }
        }
    }
}
