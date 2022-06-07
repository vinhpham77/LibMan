using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BLL;

namespace GUI.Child
{
    /// <summary>
    /// Interaction logic for BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {

        public BookPage()
        {
            InitializeComponent();
            dtgBook_Load();
        }

        private void dtgBook_Load(string title = "")
        {
            dtgBook.ItemsSource = BookBLL.GetBookList(title);
        }

        private void txtBookSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtgBook_Load(txtBookSearch.Text);
        }
    }
}
