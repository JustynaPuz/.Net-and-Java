
using API;

namespace GUI
{
    public partial class SpecificRecipe : Form
    {
        private Main main;
        public delegate void BackToMenuHandler();

        public event BackToMenuHandler BackToMenu;

        ApiResponse response = new ApiResponse();
        Meal meal = new Meal();
        public SpecificRecipe(Main main)
        {
            InitializeComponent();
            InitializeTextBox();
            this.main = main;
            this.Location = main.Location;
            this.StartPosition = main.StartPosition;
            this.BackgroundImage = Image.FromFile("C:\\Users\\Justyna\\Desktop\\.Net-and-Java\\API\\GUI\\background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void InitializeTextBox()
        {
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.WordWrap = true;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Forcefully exits the application and closes all forms
            Environment.Exit(0);
        }

        private void back_Click(object sender, EventArgs e)
        {
            main.Location = this.Location;
            main.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void nameInput_TextChanged(object sender, EventArgs e)
        {



        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameInput.Text))
            {
                textBox.Text = "";

            }
            else
            {
                string name = nameInput.Text;
                meal = await response.GetSpecificMeal(name);

                textBox.Text = meal.getInstruction();
            }

        }

        private void SpecificRecipe_Load(object sender, EventArgs e)
        {

        }
    }
}
