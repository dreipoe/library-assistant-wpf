using System;
using System.Collections.Generic;

namespace Library_Assistant.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public int? PointId { get; set; }
        public Point Point { get; set; }
        public int volume { get; set; }
        public DateTime Supply { get; set; }
        public decimal Price { get; set; }
        public int Given { get; set; }
        public int Lost { get; set; }
        public ICollection<Record> Records { get; set; }
        public Card()
        {
            Records = new List<Record>();
        }
    }
}
