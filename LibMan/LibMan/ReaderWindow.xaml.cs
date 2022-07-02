using System.Windows;
using System.Windows.Controls;
using GUI.Child;

namespace GUI
{
    public partial class ReaderWindow : Window
    {
        private readonly BookPage _book;
        private readonly LoanPage _loan;

        public ReaderWindow(string username)
        {
            InitializeComponent();
            _book = new BookPage();
            _loan = new LoanPage(username);
            lblUsername.Content = username;
            lwiBook.IsSelected = true;
        }

        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (lvwMenu.SelectedIndex)
            {
                case 0:
                    frmChild.Navigate(_book);
                    break;
                case 1:
                    frmChild.Navigate(_loan);
                    break;
                case 2:
                    var login = new LoginWindow();
                    Close();
                    login.Show();
                    break;
            }
        }
    }
}
