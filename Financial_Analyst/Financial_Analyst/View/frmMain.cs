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
        }
        private void add_account_button_Click(object sender, EventArgs e)
        {
            IAccount acc = new Account(name.Text, Convert.ToDecimal(balance.Text));
            _user.AddAccount(acc);
            ReadOnlyCollection<IAccount> accounts = _user.GetAccount();
            listAccounts.Rows.Clear();
            foreach (IAccount item in accounts)
            {
                listAccounts.Rows.Add(item.Name, item.Balance);
            }
        }
    }
}
