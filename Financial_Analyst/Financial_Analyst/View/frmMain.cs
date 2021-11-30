using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_Analyst.View;
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
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            IAccount acc = new Account(txtAccountName.Text, Convert.ToDecimal(txtBalance.Text));
            _user.AddAccount(acc);
            ReadOnlyCollection<IAccount> accounts = _user.GetAccount();
            dgvAccount.Rows.Clear();
            foreach (IAccount item in accounts)
            {
                dgvAccount.Rows.Add(item.Name, item.Balance);
            }
        }






        //private void RefreshForm()     //метод обновления инфы в форме нужно прописать

        private void btnAddExpenses_Click(object sender, EventArgs e)
        {
            frmEditExpenses formEditExpenses = new frmEditExpenses();
            formEditExpenses.ShowDialog();
        }

        private void btnChangeExpenses_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteExpenses_Click(object sender, EventArgs e)
        {

        }

        
    }
}
