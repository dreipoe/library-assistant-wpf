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
