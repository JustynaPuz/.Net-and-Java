using Microsoft.EntityFrameworkCore;

namespace API
{
    internal class Menu : DbContext
    {
        public DbSet<Meal> Recepies { get; set; }
        public Menu()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Menu.db");
        }

        public async Task LoadAllElements()
        {
            List<Meal> meals = new List<Meal>();
            ApiResponse response = new ApiResponse();

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                meals = await response.GetListOfAllMealsByFirstLetter(letter);

                foreach (Meal meal in meals)
                {
                    Recepies.Add(meal);
                    this.SaveChanges();
                }
            }

        }

    }
}
