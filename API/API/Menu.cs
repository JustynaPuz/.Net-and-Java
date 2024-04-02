using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("GUI")]
namespace API
{
    internal class Menu : DbContext
    {
        public DbSet<Meal> Recepies { get; set; }
        ApiResponse response = new ApiResponse();

        public string DbPath { get; }

        public Menu()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "menu.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        public async Task LoadAllElements()
        {
            List<Meal> meals = new List<Meal>();

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

        public async Task<Meal> getSpecificMeal(string name)
        {
            using (var context = new Menu())
            {
                var meal = await context.Recepies.FirstOrDefaultAsync(d => d.NameOfMeal == name);

                if (meal != null)
                {
                    Console.WriteLine("Z bazy \n");
                    return meal;

                }
                else
                {
                    var mealFromApi = await response.GetSpecificMeal(name);
                    if (mealFromApi != null)
                    {
                        context.Recepies.Add(mealFromApi);
                        await context.SaveChangesAsync();
                        Console.WriteLine("Z API \n");
                        return mealFromApi;
                    }
                    else
                    {
                        throw new Exception("Failed to load meal from API");
                    }
                }
            }
        }
    }


}
