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
    /// Interaction logic for LoanManPage.xaml
    /// </summary>
    public partial class LoanManPage : Page
    {
        public LoanManPage()
        {
            InitializeComponent();
            dtgLoan_Load();
        }

        public void dtgLoan_Load(string username = "")
        {
            dtgLoan.ItemsSource = LoanReturnedBLL.GetLoanReturnedList(username);

        }
    }
}
