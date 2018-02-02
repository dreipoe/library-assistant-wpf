using System.Collections.Generic;

namespace Library_Assistant.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int PrintYear { get; set; }
        public string LiterType { get; set; }
        public string Typography { get; set; }
        public ICollection<Card> Cards { get; set; }
        public Book()
        {
            Cards = new List<Card>();
        }
    }
}
