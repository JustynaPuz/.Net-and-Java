using System.ComponentModel.DataAnnotations;

namespace Books.Components
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public double? Rate { get; set; }
        public List<double>? Ratings { get; set; }

        public Book()
        {
            Ratings = new List<double>();
        }
        public override string ToString()
        {
            return $"Id: {Id} , Title: {Title}\t, Author: {Author} , Description: {Description}, RelaseDate: {RelaseDate}, Rate: {Rate}";
        }
    }
}
