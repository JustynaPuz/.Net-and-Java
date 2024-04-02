namespace GUI
{
    public partial class Main : Form
    {

        private AllMealsInCategory allMeals;
        private SpecificLetter specificLetter;


        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void specificRecipe_Click(object sender, EventArgs e)
        {
            SpecificRecipe specificRecipe = new SpecificRecipe(this);
            specificRecipe.StartPosition = FormStartPosition.CenterScreen;
            specificRecipe.Location = this.Location;
            this.Hide();
            specificRecipe.Show();
        }

        private void allCategory_Click(object sender, EventArgs e)
        {
            AllMealsInCategory allMeals = new AllMealsInCategory(this);
            allMeals.StartPosition = FormStartPosition.CenterScreen;

            allMeals.Location = this.Location;
            this.Hide();
            allMeals.Show();

        }

        private void specificLetter_button_Click(object sender, EventArgs e)
        {
            SpecificLetter specificLetter = new SpecificLetter(this);
            specificLetter.StartPosition = FormStartPosition.CenterScreen;
            specificLetter.Location = this.Location;
            this.Hide();
            specificLetter.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
