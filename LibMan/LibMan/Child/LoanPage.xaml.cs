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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;

namespace GUI.Child
{
    /// <summary>
    /// Interaction logic for LoanBookPage.xaml
    /// </summary>
    public partial class LoanPage : Page
    {
        public LoanPage(string username)
        {
            InitializeComponent();
            dtgLoan_Load(username);
        }

        public void dtgLoan_Load(string username)
        {
            dtgLoan.ItemsSource = LoanReturnedBookBLL.GetLoanReturnedList(username);
        }
    }
}
