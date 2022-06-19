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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private readonly AccountManPage _account;
        private readonly BookManPage _book;
        private readonly CatalogManPage _catalog;
        private readonly LoanManPage _loan;

        public AdminWindow(string username)
        {
            InitializeComponent();
            lblUsername.Content = username;
            _account = new AccountManPage();
            _book = new BookManPage();
            _catalog = new CatalogManPage();
            _loan = new LoanManPage();
            lwiAccount.IsSelected = true;
        }

        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (lvwMenu.SelectedIndex)
            {
                case 0:
                    frmChild.Navigate(_account);
                    break;
                case 1:
                    frmChild.Navigate(_book);
                    break;
                case 2:
                    frmChild.Navigate(_catalog);
                    break;
                case 3:
                    frmChild.Navigate(_loan);
                    break;
                case 4:
                    LoginWindow login = new LoginWindow();
                    Close();
                    login.Show();
                    break;
            }
        }
    }
}
