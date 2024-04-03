using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("GUI")]
namespace API
{
    internal class Meal
    {

        public String? category { get; set; }
        public String instruction { get; set; }


        [Required]

        public string NameOfMeal { get; set; }
        public int Id { get; set; }
        public Meal(String name, String? category, String instruction, int id)
        {
            NameOfMeal = name;
            this.category = category;
            this.instruction = instruction;
            Id = id;
        }
        public Meal()
        {
            this.NameOfMeal = "";
            this.category = "";
            this.instruction = "";

        }
        public string getInstruction()
        {
            return this.instruction;
        }

        public string getName()
        {
            return this.NameOfMeal;
        }

        public override string ToString()
        {
            return $"Meal: {NameOfMeal}\nCategory: {category} \n Instruction: {instruction}";
        }

    }
}
