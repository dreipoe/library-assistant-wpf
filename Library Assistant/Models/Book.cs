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
