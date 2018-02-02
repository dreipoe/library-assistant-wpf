using System;
using System.Collections.Generic;

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
