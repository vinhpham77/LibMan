using System.Windows.Controls;
using BLL;

namespace GUI.Child
{
    public partial class LoanPage : Page
    {
        public LoanPage(string username)
        {
            InitializeComponent();
            dtgLoan_Load(username);
        }

        public void dtgLoan_Load(string username)
        {
            dtgLoan.ItemsSource = LoanReturnedBookBLL.GetLoanReturneds(username);
        }
    }
}
