using KnapsackProblem;

namespace GUI
{
    public partial class Knapsack : Form
    {
        int numberOfItems = 0;
        int seed = 0;
        int capacity = 0;
        Instance instance;
        Result result;
        public Knapsack()
        {
            InitializeComponent();
        }

        private void Solve_button_Click(object sender, EventArgs e)
        {
            instance = new Instance(numberOfItems, seed);
            Instance_listbox.DataSource = instance.GetItems();
            result = instance.SolveAproximation(capacity);
            Result_textbox.Text = result.ToString();



        }

        private void Items_textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(Items_textbox.Text))
                {
                    numberOfItems = 0;

                }
                else if (int.Parse(Items_textbox.Text) > 0)
                {
                    numberOfItems = int.Parse(Items_textbox.Text);
                }
                else
                {
                    MessageBox.Show("Number must be greater than 0");
                    Items_textbox.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter an integer");
            }

        }

        private void NumberOfItems_label_Click(object sender, EventArgs e)
        {

        }

        private void Capacity_textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(Capacity_textbox.Text))
                {
                    capacity = 0;

                }
                else if (int.Parse(Capacity_textbox.Text) > 0)
                {
                    capacity = int.Parse(Capacity_textbox.Text);
                }
                else
                {
                    MessageBox.Show("Number must be greater than 0");
                    Capacity_textbox.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter an integer");
            }
        }

        private void Seed_textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(Seed_textbox.Text))
                {
                    seed = 0;
                }
                else if (int.Parse(Seed_textbox.Text) >= 0)
                {
                    seed = int.Parse(Seed_textbox.Text);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Enter an integer");
            }
        }

        private void Instance_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Instance_listbox.DataSource = instance.GetItems();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Result_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Knapsack_Load(object sender, EventArgs e)
        {

        }
    }
}
