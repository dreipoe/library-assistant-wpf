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
    public class Reader
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime Reg { get; set; }
        public DateTime? Quit { get; set; }
        public ICollection<Record> Records { get; set; }
        public Reader()
        {
            Records = new List<Record>();
        }
    }
}
