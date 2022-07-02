using System.Windows;
using System.Windows.Controls;
using GUI.Child;

namespace GUI
{
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
                    var login = new LoginWindow();
                    Close();
                    login.Show();
                    break;
            }
        }
    }
}
