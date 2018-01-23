using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
