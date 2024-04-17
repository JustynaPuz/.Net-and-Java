namespace API
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ApiResponse response = new ApiResponse();
            Menu db = new Menu();

            Meal mealll = await db.getSpecificMeal("Spaghetti");
            Console.WriteLine(mealll.ToString());


            Meal meal = new Meal();
            /*    int option = -1;

                while (option != 4)
                {

                    Console.WriteLine("\nChoose one option: \n 1 - get recipes of specific meal\n 2 - get all meals that start on specific letter\n 3 - get all meals from specific category \n 4 - quit\n Answer: \n");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                Console.WriteLine("Name of meal :");
                                string name = Console.ReadLine();

                                meal = await response.GetSpecificMeal(name);

                                if (meal != null)
                                {
                                    Console.WriteLine(meal.ToString());
                                }

                                break;
                            }

                        case 2:
                            {
                                *//* Console.WriteLine("Letter : ");
                                 ConsoleKeyInfo letterKey = Console.ReadKey();
                                 char letter = letterKey.KeyChar;

                                 List<Meal> mealsLetter = await response.GetListOfAllMealsByFirstLetter(letter);

                                 foreach (Meal item in mealsLetter)
                                 {
                                     Console.WriteLine(" -" + item.getName());
                                 }
                                 option = -2;*//*
                                break;

                            }

                        case 3:
                            {
                                Console.WriteLine("Categories");
                                List<string> categories = await response.GetAllCategories();

                                foreach (string category in categories)
                                {
                                    Console.WriteLine(category);
                                }
                                Console.WriteLine("Choose one: ");
                                string categoryInput = Console.ReadLine();

                                List<string> meals = await response.GetAllMealFromSpecificCategory(categoryInput);

                                foreach (string item in meals)
                                {
                                    Console.WriteLine(" -" + item);
                                }

                                break;
                            }
                        default: break;

                    }
                }*/


        }
    }
}
