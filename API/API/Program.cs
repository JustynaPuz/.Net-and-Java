namespace API
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ApiResponse response = new ApiResponse();

            // Meal meal = await response.getNameOfMeal("Arrabiata");
            // List<0Meal> meals = await response.getListOfAllMealsByFirstLetter("a");
            // Console.WriteLine(meal.ToString());
            //List<String> categories = await response.GetAllCategories();
            //Console.WriteLine(categories);
            // List<String> meals = await response.GetAllMealFromSpecificCategory("Seafood");

            var db = new Menu();
            await db.LoadAllElements();
            // Meal meal = await response.getNameOfMeal("Arrabiata");
            /*  List<Meal> meals = await response.GetListOfAllMealsByFirstLetter("a");
              foreach (Meal element in meals)
              {
                  db.Recepies.Add(element);
                  db.SaveChanges();
              }

              List<Meal> mealsOutput = db.Recepies.ToList<Meal>();
              Console.WriteLine(categories);*/

        }
    }
}
