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

namespace GUI
{
    /// <summary>
    /// Interaction logic for LibrarianWindow.xaml
    /// </summary>
    public partial class LibrarianWindow : Window
    {
        public LibrarianWindow(string username)
        {
            InitializeComponent();
            lblFullname.Content = username;
        }

        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (lvwMenu.SelectedIndex)
            {
                case 0:
                    Child.BookLibrarianPage book = new Child.BookLibrarianPage();
                    frmChild.Navigate(book);
                    break;
                case 1:
                    Child.LoanPage loan = new Child.LoanPage("a");
                    frmChild.Navigate(loan);
                    break;
            }
        }
    }
}
