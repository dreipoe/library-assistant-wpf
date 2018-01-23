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
    public class Record
    {
        public int Id { get; set; }
        public int? ReaderId { get; set; }
        public Reader Reader { get; set; }
        public int? CardId { get; set; }
        public Card Card { get; set; }
        public DateTime Gave { get; set; }
        public DateTime _Return { get; set; }
        public DateTime? Returned { get; set; }

        public Record()
        {
            Gave = DateTime.Today;
            _Return = DateTime.Today.AddMonths(1);
        }
    }
}
