using MatrixMulitplication;
using System.Data;
using System.Diagnostics;
using Matrix = MatrixMulitplication.Matrix;

namespace GUI
{
    public partial class Form1 : Form
    {
        Matrix first;
        Matrix second;
        Matrix result;
        ShowMatrix showMatrix;
        int numberOfThreads;
        int seed1;
        int seed2;
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:\\Users\\Justyna\\Desktop\\.Net-and-Java\\MatrixMulitplication\\GUI\\tlo_matrix.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            groupBox1.BackColor = Color.Transparent;
            radioButtonParallel.ForeColor = Color.White;
            radioButtonThreads.ForeColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Boolean isThreads = radioButtonThreads.Checked ? true : false;
            CalculateButton.BackColor = Color.White;

            if (!string.IsNullOrEmpty(ThreadstextBox.Text) && !string.IsNullOrEmpty(Seed1textBox.Text) && !string.IsNullOrEmpty(Seed2textBox.Text) && !string.IsNullOrEmpty(Mat1RowstextBox.Text) &&
                !string.IsNullOrEmpty(Mat1ColtextBox.Text) && !string.IsNullOrEmpty(Mat2RowstextBox.Text) && !string.IsNullOrEmpty(Mat2ColtextBox.Text) && (radioButtonParallel.Checked || radioButtonThreads.Checked))
            {
                if (int.Parse(Mat1ColtextBox.Text) != int.Parse(Mat2RowstextBox.Text) || int.Parse(Mat1RowstextBox.Text) != int.Parse(Mat2ColtextBox.Text))
                {
                    MessageBox.Show("Wrong matrixes size");
                }
                else
                {
                    first = null;
                    second = null;

                    numberOfThreads = int.Parse(ThreadstextBox.Text);
                    seed1 = int.Parse(Seed1textBox.Text);
                    seed2 = int.Parse(Seed2textBox.Text);

                    first ??= new Matrix(int.Parse(Mat1RowstextBox.Text), int.Parse(Mat1ColtextBox.Text), seed1);
                    second ??= new Matrix(int.Parse(Mat2RowstextBox.Text), int.Parse(Mat2ColtextBox.Text), seed2);

                    TwoMatrixMultiplication multiplication = new TwoMatrixMultiplication(first, second);

                    result = isThreads ? multiplication.multiplyTwoMatrixThreads(numberOfThreads) : multiplication.multiplyTwoMatrixParallel(numberOfThreads);

                    CalculateButton.BackColor = Color.Gray;
                }
            }
            else
            {
                MessageBox.Show("Fill in all parameters");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Matrix1Button_Click(object sender, EventArgs e)
        {

            showMatrix = new ShowMatrix();
            showMatrix.Text = "Matrix 1";

            if (!string.IsNullOrEmpty(Seed1textBox.Text) && !string.IsNullOrEmpty(Mat1RowstextBox.Text) && !string.IsNullOrEmpty(Mat1ColtextBox.Text))
            {
                first = new Matrix(int.Parse(Mat1RowstextBox.Text), int.Parse(Mat1ColtextBox.Text), int.Parse(Seed1textBox.Text));
                showMatrix.Show();
                showMatrix.DisplayMatrix(first.getAllValues());
            }
            else { MessageBox.Show("Fill in all parameters"); }

        }

        private void Matrix2Button_Click(object sender, EventArgs e)
        {
            showMatrix = new ShowMatrix();
            showMatrix.Text = "Matrix 2";

            if (!string.IsNullOrEmpty(Seed2textBox.Text) && !string.IsNullOrEmpty(Mat2RowstextBox.Text) && !string.IsNullOrEmpty(Mat2ColtextBox.Text))
            {
                second = new Matrix(int.Parse(Mat2RowstextBox.Text), int.Parse(Mat2ColtextBox.Text), int.Parse(Seed2textBox.Text));
                showMatrix.Show();
                showMatrix.DisplayMatrix(second.getAllValues());
            }
            else { MessageBox.Show("Fill in all parameters"); }

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            showMatrix = new ShowMatrix();
            showMatrix.Text = "Result";

            if (result != null)
            {
                showMatrix.Show();
                showMatrix.DisplayMatrix(result.getAllValues());
            }
            else { MessageBox.Show("No result, press CALCULATE"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showMatrix = new ShowMatrix();
            showMatrix.Width = 350;

            double[] timeThread = new double[10];
            double[] timeParallel = new double[10];
            first ??= new Matrix(int.Parse(Mat1RowstextBox.Text), int.Parse(Mat1ColtextBox.Text), int.Parse(Seed1textBox.Text));
            second ??= new Matrix(int.Parse(Mat2RowstextBox.Text), int.Parse(Mat2ColtextBox.Text), int.Parse(Seed2textBox.Text));


            showMatrix.Show();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Time in miliseconds");

            TwoMatrixMultiplication matrixMultiplication = new TwoMatrixMultiplication(first, second);
            Stopwatch stopwatch = new Stopwatch();


            for (int i = 1; i < 11; i++)
            {

                DataRow row = dataTable.NewRow();
                DataRow row2 = dataTable.NewRow();
                DataRow row3 = dataTable.NewRow();

                stopwatch.Start();
                Matrix reslut1 = matrixMultiplication.multiplyTwoMatrixThreads(i);
                stopwatch.Stop();

                row[0] = i.ToString() + " threads ";
                row[1] = stopwatch.Elapsed.TotalMilliseconds;
                timeThread[i - 1] = stopwatch.Elapsed.TotalMilliseconds;
                stopwatch.Restart();

                stopwatch.Start();
                Matrix result2 = matrixMultiplication.multiplyTwoMatrixThreads(1);
                stopwatch.Stop();

                row2[0] = "1 thread ";
                row2[1] = stopwatch.Elapsed.TotalMilliseconds;

                stopwatch.Restart();
                stopwatch.Start();
                Matrix result3 = matrixMultiplication.multiplyTwoMatrixParallel(i);
                stopwatch.Stop();

                row3[0] = i.ToString() + " threads - parallel ";
                row3[1] = stopwatch.Elapsed.TotalMilliseconds;
                timeParallel[i - 1] = stopwatch.Elapsed.TotalMilliseconds;


                dataTable.Rows.Add(row);
                dataTable.Rows.Add(row2);
                dataTable.Rows.Add(row3);

            }

            DataRow rowlast = dataTable.NewRow();
            rowlast[0] = " Thread to Parallel ";
            double average = 0;

            for (int j = 0; j < timeParallel.Length; j++)
            {
                average += (timeThread[j] - timeParallel[j]) / (j + 1);
            }
            average /= 10;
            rowlast[1] = average;
            dataTable.Rows.Add(rowlast);

            showMatrix.DisplayComparison(dataTable);
        }


        private void ThreadstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThreadstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculateButton.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Seed1textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculateButton.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Seed2textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculateButton.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Mat1RowstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculateButton.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Mat1ColtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculateButton.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Mat2RowstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculateButton.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Mat2ColtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculateButton.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
