using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SetBooks
{
    public partial class MainWindow : Window
    {
        ListOfBooks pList = new ListOfBooks();
        public MainWindow()
        {
            InitializeComponent();
            pListBox.ItemsSource = pList.books;
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            BookWindow bookWindow = new BookWindow();
            bookWindow.book = new Book();
            bookWindow.DataContext = bookWindow.book;
            var result = bookWindow.ShowDialog();
            if (result == true)
            {
                pList.AddBook(bookWindow.book);
            }


        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            BookWindow bookWindow = new BookWindow();
            Book bo = pList.books[pListBox.SelectedIndex];
            bookWindow.book = new Book(bo.Title, bo.Autor, bo.Education);
            bookWindow.DataContext = bookWindow.book;
            var result = bookWindow.ShowDialog();
            if (result == true)
            {
                pList.EditBook(pListBox.SelectedIndex, bookWindow.book);
            }

        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            pList.RemoveBookAt(pListBox.SelectedIndex);

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var path = "File.txt";
            pList.SaveBook(path);
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            var path = "File.txt";
            pList.LoadBook(path);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    
}
