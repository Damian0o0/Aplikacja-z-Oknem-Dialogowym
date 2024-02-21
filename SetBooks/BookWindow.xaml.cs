using System;
using System.Collections.Generic;
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

namespace SetBooks
{
    /// <summary>
    /// Logika interakcji dla klasy BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        public Book book;

        public BookWindow()
        {
            InitializeComponent();
            education.ItemsSource = Enum.GetValues(typeof(EducationClass)).Cast<EducationClass>();

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true; 

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
