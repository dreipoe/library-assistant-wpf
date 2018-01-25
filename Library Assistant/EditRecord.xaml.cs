using Library_Assistant.Models;

using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Library_Assistant
{
    public partial class EditRecord : Window
    {
        public Record record { get; set; }
        public LibContext db;

        public EditRecord(Record r)
        {
            InitializeComponent();

            db = new LibContext();
            db.Readers.Load();
            db.Books.Load();
            db.Cards.Load();

            record = r;
            DataContext = record;

            bookCombo.ItemsSource = db.Books.Select(p => p.Name).ToList();
        }

        //все необходимые поля заполнены?
        public void Accept(object sender, RoutedEventArgs e)
        {
            if (bookCombo.SelectedItem != null && cardCombo.SelectedItem != null) DialogResult = true;
        }

        private void bookComboChange(object sender, SelectionChangedEventArgs e)
        {
            record.Card = null;
            int bookId = db.Books.First(p => p.Name == (string)bookCombo.SelectedItem).Id;
            cardCombo.ItemsSource = db.Cards.Where(p => p.BookId == bookId).Select(p => p.Id).ToList();
        }
    }
}
