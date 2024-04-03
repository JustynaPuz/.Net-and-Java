using API;

namespace GUI
{
    public partial class AllMealsInCategory : Form
    {
        private Main main;
        ApiResponse response = new ApiResponse();
        List<string> categories;

        public AllMealsInCategory(Main main)
        {
            InitializeComponent();
            InitializeTextBox();
            this.main = main;
            this.Location = main.Location;
            this.StartPosition = main.StartPosition;
            LoadCategories();
            this.BackgroundImage = Image.FromFile("C:\\Users\\Justyna\\Desktop\\.Net-and-Java\\API\\GUI\\background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            comboBoxCategory.SelectedIndexChanged += comboBox_SelectedIndexChanged;

        }
        public void InitializeTextBox()
        {
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.WordWrap = true;
        }

        public async void LoadCategories()
        {
            categories = await response.GetAllCategories();
            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }

        }
        private void AllMealsInCategory_Load(object sender, EventArgs e)
        {

        }
        private void Back_Click(object sender, EventArgs e)
        {
            main.Location = this.Location;
            main.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboBoxCategory.Text;
            List<string> meals = await response.GetAllMealFromSpecificCategory(category);
            comboBoxMeal.Items.Clear();
            foreach (string meal in meals)
            {
                comboBoxMeal.Items.Add(meal);
            }
            textBox.Text = "";
        }

        private async void comboBoxMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBoxMeal.Text;
            Meal meal = await response.GetSpecificMeal(name);
            textBox.Text = meal.getInstruction();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
