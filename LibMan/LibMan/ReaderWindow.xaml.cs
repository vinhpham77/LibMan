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
using System.Windows.Shapes;
using BLL;

namespace GUI
{
    /// <summary>
    /// Interaction logic for ReaderWindow.xaml
    /// </summary>
    public partial class ReaderWindow : Window
    {
        private string _username { get; set; }
        Child.BookPage book;
        Child.LoanPage loan;
        public ReaderWindow(string username)
        {
            InitializeComponent();
            this._username = username;
            book = new Child.BookPage();
            loan = new Child.LoanPage(_username);
            lblFullname.Content = AccountBLL.GetAccount(username).Fullname;
            lvwMenu.SelectedIndex = 0;
        }

        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (lvwMenu.SelectedIndex)
            {
                case 0:
                    frmChild.Navigate(book);
                    break;
                case 1:
                    frmChild.Navigate(loan);
                    break;
                case 2:
                    LoginWindow login = new LoginWindow();
                    Close();
                    login.Show();
                    break;
            }
        }
    }
}
