using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_Analyst.Logic;
using System.Collections.ObjectModel;

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
                dgvAccountsList.Rows.Add(cmbSelectAccountForTransaction);
           }
           foreach (IAccount item in accounts)
           {
                cmbSelectAccountForTransaction.Items.Add(item.Name);
           }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            IAccount account = new Account(txtAccountName.Text, Convert.ToDecimal(txtBalance.Text));
            _user.AddAccount(account);
            dgvAccountsList.Rows.Add(account.Name, account.Balance);
            cmbSelectAccountForTransaction.Items.Add(account.Name);
        }


        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }














        //private void RefreshForm()     //метод обновления инфы в форме нужно прописать

        //private void btnAddExpenses_Click(object sender, EventArgs e)
        //{
        //    frmEditExpenses formEditExpenses = new frmEditExpenses();
        //    formEditExpenses.ShowDialog();
        //}

    
}
