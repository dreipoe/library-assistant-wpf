using Library_Assistant.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_Assistant
{
    public partial class EditReader : Window
    {
        public Reader Reader { get; set; }
        LibContext db;
        public EditReader(Reader r)
        {
            InitializeComponent();
            db = new LibContext();
            db.Readers.Load();
        }

        private void Accept(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;           
        }
    }
}
