using System.ComponentModel.DataAnnotations;

namespace API
{
    internal class Meal
    {

        String? category { get; set; }
        String instruction { get; set; }
        public int Id { get; set; }

        [Required]

        int IdOfMeal { get; set; }
        String nameOfMeal { get; set; }
        public Meal(String name, String? category, String instruction, int id)
        {
            nameOfMeal = name;
            this.category = category;
            this.instruction = instruction;
            IdOfMeal = id;
        }
        public Meal()
        {
            this.nameOfMeal = "";
            this.category = "";
            this.instruction = "";

        }

        public override string ToString()
        {
            return $"Meal: {nameOfMeal}\nCategory: {category} \nInstruction: {instruction}";
        }

    }
}
