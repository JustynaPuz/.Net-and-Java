using System.Text.Json;

namespace API
{
    internal class ApiResponse
    {
        HttpClient client = new HttpClient();
        String nameOfMeal = "";


        public async Task<Meal> GetNameOfMeal(String nameOfMeal)
        {

            //By name of meal
            string call = "https://www.themealdb.com/api/json/v1/1/search.php?s=" + nameOfMeal;
            Meal meal = new Meal();
            // Console.WriteLine(call);

            string response = await client.GetStringAsync(call);


            using (JsonDocument doc = JsonDocument.Parse(response))
            {
                JsonElement root = doc.RootElement;
                JsonElement mealsArray = root.GetProperty("meals");
                if (mealsArray.GetArrayLength() > 0)
                {
                    JsonElement firstMeal = mealsArray[0];
                    //  string strMeal = firstMeal.GetProperty("strMeal").GetString();
                    meal = new Meal(firstMeal.GetProperty("strMeal").ToString(), firstMeal.GetProperty("strCategory").ToString(),
                   firstMeal.GetProperty("strInstructions").ToString(), int.Parse(firstMeal.GetProperty("idMeal").ToString()));
                    //Console.WriteLine($"Nazwa posiłku: {strMeal}");
                }
            }

            return meal;

        }

        public async Task<List<Meal>> GetListOfAllMealsByFirstLetter(char letter)
        {

            //By name of meal
            string call = "https://www.themealdb.com/api/json/v1/1/search.php?f=" + letter;
            Console.WriteLine(call);
            Meal meal;
            List<Meal> meals = new List<Meal>();

            string response = await client.GetStringAsync(call);
            //Console.WriteLine(response);


            using (JsonDocument doc = JsonDocument.Parse(response))
            {
                JsonElement root = doc.RootElement;
                JsonElement mealsArray = root.GetProperty("meals");
                if (mealsArray.ValueKind != JsonValueKind.Null)
                {
                    for (int i = 0; i < mealsArray.GetArrayLength(); i++)
                    {
                        JsonElement firstMeal = mealsArray[i];
                        meal = new Meal(firstMeal.GetProperty("strMeal").ToString(), firstMeal.GetProperty("strCategory").ToString(),
                       firstMeal.GetProperty("strInstructions").ToString(), int.Parse(firstMeal.GetProperty("idMeal").ToString()));
                        meals.Add(meal);

                        //Console.WriteLine($"Nazwa posiłku: {strMeal}");
                    }
                }
            }
            return meals;

        }


        public async Task<List<String>> GetAllCategories()
        {

            //By name of meal
            string call = "https://www.themealdb.com/api/json/v1/1/categories.php";
            List<String> meals = new List<String>();

            string response = await client.GetStringAsync(call);
            //Console.WriteLine(response);


            using (JsonDocument doc = JsonDocument.Parse(response))
            {
                JsonElement root = doc.RootElement;
                JsonElement mealsArray = root.GetProperty("categories");
                for (int i = 0; i < mealsArray.GetArrayLength(); i++)
                {
                    JsonElement firstMeal = mealsArray[i];
                    string category = firstMeal.GetProperty("strCategory").ToString();
                    meals.Add(category);

                    //Console.WriteLine($"Nazwa posiłku: {strMeal}");
                }
            }
            return meals;

        }

        public async Task<List<String>> GetAllMealFromSpecificCategory(string category)
        {

            //By name of meal
            string call = "https://www.themealdb.com/api/json/v1/1/filter.php?c=" + category;
            List<String> meals = new List<String>();

            string response = await client.GetStringAsync(call);



            using (JsonDocument doc = JsonDocument.Parse(response))
            {
                JsonElement root = doc.RootElement;
                JsonElement mealsArray = root.GetProperty("meals");
                for (int i = 0; i < mealsArray.GetArrayLength(); i++)
                {
                    JsonElement firstMeal = mealsArray[i];
                    string meal = firstMeal.GetProperty("strMeal").ToString();
                    meals.Add(meal);

                }
            }
            return meals;

        }
    }
}

//List all meal categories    www.themealdb.com / api / json / v1 / 1 / categories.php
// string call = "https://www.themealdb.com/api/json/v1/1/categories.php";
