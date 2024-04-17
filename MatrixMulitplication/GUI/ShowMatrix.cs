using System.Data;

namespace GUI
{
    public partial class ShowMatrix : Form
    {
        DataTable dataTable = new DataTable();
        public ShowMatrix()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:\\Users\\Justyna\\Desktop\\.Net-and-Java\\MatrixMulitplication\\GUI\\tlo_matrix.jpg");

        }

        private void Matrix_Load(object sender, EventArgs e)
        {

        }
        public void DisplayMatrix(int[,] matrix)
        {
            dataTable.Clear();

            for (int i = 0; i < matrix.GetLength(1); i++) { dataTable.Columns.Add(); }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                DataRow row = dataTable.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];

                }
                dataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = dataTable;

        }
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }

        public void DisplayComparison(DataTable newDataTable)
        {
            dataTable.Clear();
            dataGridView1.DataSource = newDataTable;

        }
    }
}
