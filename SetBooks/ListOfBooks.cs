using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SetBooks
{
    internal class ListOfBooks
    {
        public ObservableCollection<Book> books;

        public ListOfBooks()
        {
            books = new ObservableCollection<Book>();
            LoadBook("plik.txt");
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void EditBook(int index, Book book)
        {
            books[index] = book;
        }
        public void RemoveBookAt(int index)
        {
            if (index >= 0 && index < books.Count)
            {
                books.RemoveAt(index);
            }
        }

        public void SaveBook(string file)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file, false, Encoding.UTF8))
                {
                    foreach (var book in books)
                    {
                        writer.WriteLine($"{book.Title},{book.Autor},{(int)book.Education}");
                    }
                }

                MessageBox.Show("Zapisano");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd");
            }
        }
        public void LoadBook(string file)
        {
            if (File.Exists(file))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(file, Encoding.UTF8))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split(',');
                            var book = new Book(parts[0], parts[1], (EducationClass)int.Parse(parts[2]));
                            books.Add(book);
                        }
                    }

                    MessageBox.Show("Wczytano Plik");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd");
                }
            }
        }
    }
}
