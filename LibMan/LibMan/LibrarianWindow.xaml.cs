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
using GUI.Child;
namespace GUI
{
    /// <summary>
    /// Interaction logic for LibrarianWindow.xaml
    /// </summary>
    public partial class LibrarianWindow : Window
    {
        private readonly BookLibrarianPage _book;
        private readonly CatalogLibrarianPage _catalog;
        private readonly LoanManPage _loan;

        public LibrarianWindow(string username)
        {
            _book = new Child.BookLibrarianPage();
            _catalog = new Child.CatalogLibrarianPage();
            _loan = new Child.LoanManPage();
            InitializeComponent();
            lblFullname.Content = username;
        }

        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (lvwMenu.SelectedIndex)
            {
                case 0:            
                    frmChild.Navigate(_book);
                    break;
                case 1:
                    frmChild.Navigate(_catalog);
                    break;
                case 2:
                    frmChild.Navigate(_loan);
                    break;
                case 3:
                    LoginWindow login = new LoginWindow();
                    Close();
                    login.Show();
                    break;
            }            
        }
    }
}
