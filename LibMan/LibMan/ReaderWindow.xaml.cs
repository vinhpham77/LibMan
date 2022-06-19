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
using GUI.Child;

namespace GUI
{
    /// <summary>
    /// Interaction logic for ReaderWindow.xaml
    /// </summary>
    public partial class ReaderWindow : Window
    {
        private string _username { get; set; }
        private readonly BookPage _book;
        private readonly LoanPage _loan;
        public ReaderWindow(string username)
        {
            InitializeComponent();
            this._username = username;
            _book = new BookPage();
            _loan = new LoanPage(_username);
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
                    LoginWindow login = new LoginWindow();
                    Close();
                    login.Show();
                    break;
            }
        }
    }
}
