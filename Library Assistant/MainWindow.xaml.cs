using Library_Assistant.Models;

using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Library_Assistant
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new LibContext();

            try
            {
                db.Readers.Load();
                db.Records.Load();
                db.Cards.Load();
                db.Books.Load();
            }
            catch (SqlException) {
                MessageBox.Show(
                    "Невозможно подключиться к базе данных.\nПроверьте настройки подключения.",
                    "Library Assistant",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
                Close();
            }

            readerGrid.ItemsSource = db.Readers.Local.ToBindingList();
        }

        public void miExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void AddReader(object sender, RoutedEventArgs e)
        {
            
        }

        public void EditReader(object sender, RoutedEventArgs e)
        {
            
        }

        public void DeleteReader(object sender, RoutedEventArgs e)
        {

        }

        public void Add(object sender, RoutedEventArgs e)
        {
            EditRecord recordEdit = new EditRecord(new Record());
            recordEdit.record.Reader = readerGrid.SelectedItem as Reader;

            if (recordEdit.ShowDialog() == true){
                Record record = recordEdit.record;

                record.ReaderId = recordEdit.record.Reader.Id;
                record.CardId = (int)recordEdit.cardCombo.SelectedItem;
                record.Gave = (DateTime)recordEdit.dpGave.SelectedDate;
                record._Return = (DateTime)recordEdit.dpHaveToReturn.SelectedDate;
                record.Returned = recordEdit.dpReturned.SelectedDate;

                db.Records.Add(record);
                db.SaveChanges();
                readerGridChange(readerGrid, null);
            }
        }

        public void Edit(object sender, RoutedEventArgs e)
        {
            if (recordGrid.SelectedItem == null) return;
            Record record = recordGrid.SelectedItem as Record;

            EditRecord recordEdit = new EditRecord(new Record
            {
                Id = record.Id,
                ReaderId = record.ReaderId,
                CardId = record.CardId,
                Gave = record.Gave,
                _Return = record._Return,
                Returned = record.Returned,
                Reader = readerGrid.SelectedItem as Reader,
                Card = record.Card
            });

            if (recordEdit.ShowDialog() == true) {
                record = db.Records.First(p => p.Id == recordEdit.record.Id);
                if (record != null)
                {
                    record.ReaderId = recordEdit.record.Reader.Id;
                    record.CardId = (int)recordEdit.cardCombo.SelectedItem;
                    record.Gave = (DateTime)recordEdit.dpGave.SelectedDate;
                    record._Return = (DateTime)recordEdit.dpHaveToReturn.SelectedDate;
                    record.Returned = recordEdit.dpReturned.SelectedDate;

                    db.Entry(record).State = EntityState.Modified;
                    db.SaveChanges();
                    readerGridChange(readerGrid, null);
                }
            }          
        }

        public void Delete(object sender, RoutedEventArgs e)
        {
            if (recordGrid.SelectedItem == null) return;

            MessageBoxResult question = MessageBox.Show(
                "Вы уверены, что хотите удалить эту запись?",
                "Library Assistant",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

            if (question == MessageBoxResult.Yes)
            {
                Record record = recordGrid.SelectedItem as Record;
                db.Records.Remove(record);
                db.SaveChanges();
                readerGridChange(readerGrid, null);
            }
        }

        public void About(object sender, RoutedEventArgs e)
        {
            
        }

        public void readerGridChange(object sender, SelectionChangedEventArgs e)
        {
            Reader reader = readerGrid.SelectedItem as Reader;
            recordGrid.ItemsSource = db.Records.Where(p => p.ReaderId == reader.Id).ToList();
        }
    }
}

/*
 * record.CardId = (int)cardCombo.SelectedItem;
*/
