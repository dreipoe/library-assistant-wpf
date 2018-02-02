using System.Collections.Generic;

namespace Library_Assistant.Models
{
    public class LiterType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
        public LiterType()
        {
            Books = new List<Book>();
        }
    }
}
