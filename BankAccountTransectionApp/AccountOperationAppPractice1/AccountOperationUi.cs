using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account _account = new Account();
        public AccountOperationUi()
        {
            InitializeComponent();
        }
       

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
            _account.acnumber = Convert.ToInt32(accountNoTextBox.Text);
            _account.cname = customerNameTextBox.Text;


        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
           
            double amount = Convert.ToDouble(amountTextBox.Text);
           double deposit= _account.Deposit(amount);

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            
            double amount = Convert.ToDouble(amountTextBox.Text);
            double withdraw=_account.withdraw(amount);

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string message =_account.getinfo();
            MessageBox.Show(message);
        }
    }
}
