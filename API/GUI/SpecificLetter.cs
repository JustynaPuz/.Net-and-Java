using API;

namespace GUI
{
    public partial class SpecificLetter : Form
    {
        private Main main;
        public SpecificLetter(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.Location = main.Location;
            this.StartPosition = main.StartPosition;
            InitializeTextBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void InitializeTextBox()
        {
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.WordWrap = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            main.Location = this.Location;

            main.Show();
            this.Close();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            ApiResponse response = new ApiResponse();
            if (String.IsNullOrWhiteSpace(letterInput.Text))
            {
                textBox.Text = "";

            }
            else
            {
                char letter = letterInput.Text[0];
                List<Meal> meals = await response.GetListOfAllMealsByFirstLetter(letter);

                foreach (Meal meal in meals)
                {
                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.AppendText(Environment.NewLine);
                    }
                    textBox.AppendText(meal.getName() + "\n");
                }

            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpecificLetter_Load(object sender, EventArgs e)
        {

        }

        private void letterInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
