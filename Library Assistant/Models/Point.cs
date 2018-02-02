using System.Collections.Generic;

namespace Library_Assistant.Models
{
    public class Point
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsReadRoom { get; set; }
        public ICollection<Card> Cards { get; set; }
        public Point()
        {
            Cards = new List<Card>();
        }
    }
}
