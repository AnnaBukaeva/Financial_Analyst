using Financial_Analyst.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Analyst.View
{
    public partial class frmMain : Form
    {
        private IUser _user;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _user = new User("Vasilii", "Rogov");
            ReadOnlyCollection<IAccount> accounts = _user.GetAccount();
            foreach (IAccount item in accounts)
            {
                listAccounts.Rows.Add(selectAccountTransaction);
            }
            foreach (IAccount item in accounts)
            {
                selectAccountTransaction.Items.Add(item.Name);
            }
        }
        private void add_account_button_Click(object sender, EventArgs e)
        {
            IAccount acc = new Account(name.Text, Convert.ToDecimal(balance.Text));
            _user.AddAccount(acc);
            listAccounts.Rows.Add(acc.Name, acc.Balance);
            selectAccountTransaction.Items.Add(acc.Name);
        }
        private void add_type_transaction_Click(object sender, EventArgs e)
        {
            ITransaction transaction = null;
            if (transactionType.SelectedItem.ToString() == "incom pay")
            {
                transaction = new IncomTransaction(Convert.ToDecimal(paymentSum.Text), paymentCategorieSelect.Text, DateTime.Now);

            }
            if (transactionType.SelectedItem.ToString() == "expenses pay")
            {
                transaction = new ExpensesTransaction(Convert.ToDecimal(paymentSum.Text), paymentCategorieSelect.Text, DateTime.Now);                
            }
            string accountName = selectAccountTransaction.SelectedItem.ToString();
            ReadOnlyCollection<IAccount> accounts = _user.GetAccount();
            foreach (IAccount item in accounts)
            {
                if (item.Name == accountName)
                {
                    item.AddTransaction(transaction);
                }
            }
        }
        private void transactionType_TextChanged(object sender, EventArgs e)
        {
            paymentCategorieSelect.Items.Clear();
            paymentCategorieSelect.Text= "";
            if (transactionType.SelectedItem.ToString() == "incom pay")
            {
                paymentCategorieSelect.Items.AddRange(IncomTransaction.IncomCategories);
            }
            if (transactionType.SelectedItem.ToString() == "expenses pay")
            {
                paymentCategorieSelect.Items.AddRange(ExpensesTransaction.ExpensesCategorie);
            }
        }
    }
}
