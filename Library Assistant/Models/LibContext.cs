using System.Data.Entity;

namespace Library_Assistant.Models
{
    public class LibContext: DbContext
    {
        public LibContext()
            :base("DbConnection")
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<LiterType> LiterTypes { get; set; }
    }
}
