using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GUI")]
namespace MatrixMulitplication
{
    internal class Matrix
    {
        readonly int rows;
        readonly int columns;
        int seed;
        readonly int[,] matrixValues;

        public Matrix(int rows, int columns, int seed)
        {
            this.rows = rows;

            this.columns = columns;
            this.seed = seed;
            matrixValues = new int[rows, columns];
            generateValues();

        }

        public Matrix(int rows, int columns)
        {
            this.rows = rows;

            this.columns = columns;
            matrixValues = new int[rows, columns];

        }
        public Matrix(int[,] matrix)
        {
            this.matrixValues = matrix;
            this.rows = matrix.GetLength(0);
            this.columns = matrix.GetLength(1);

        }
        private void generateValues()
        {
            Random random = new Random(seed);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    int numberInRange = random.Next(0, 101);
                    bool isNegative = random.Next(2) == 0;
                    int randomNumber = isNegative ? -numberInRange : numberInRange;
                    matrixValues[row, col] = randomNumber;

                }
            }

        }
        public int getRows() { return rows; }
        public int getColumns() { return columns; }
        public int getValue(int row, int col) { return matrixValues[row, col]; }
        public int[,] getAllValues() { return matrixValues; }
        public void setValue(int row, int col, int value) { matrixValues[row, col] = value; }

        public bool AreEqualTo(Matrix second)
        {
            if (this.columns != second.getColumns() || this.rows != second.getRows())
            {
                return false;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (matrixValues[row, col] != second.getValue(row, col)) { return false; }

                }
            }
            return true;
        }
    }

}
