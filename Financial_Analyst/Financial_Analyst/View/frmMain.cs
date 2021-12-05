using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_Analyst.Logic;

namespace Financial_Analyst.View
{
    public partial class frmMain : Form
    {
        private IUser _user;
        private Form _userAuth;
        private List<ITransaction> _transactions;

        public frmMain(IUser user, Form userAuth)
        {
            InitializeComponent();
            _userAuth = userAuth;
            _user = user;
            txtUserName.Text = _user.FIO;
            dgvListTransactions.AutoGenerateColumns = false;
            dgvListTransactions.DataSource = _transactions;
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _userAuth.Show();
        }


        //private void frmMain_Load(object sender, EventArgs e)
        //{
        //
        // во время авторизации дается доступ к счетам, только к тем,
        // которые принадлежат конкретному(тому, кто вошел) пользователю
        //}

        private void RefreshForm()
        {
            dgvListTransactions.DataSource = null;
            dgvListTransactions.DataSource = _transactions;
            dgvListTransactions.Refresh();
        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccounts accounts = new frmAccounts();
            accounts.ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            frmEditTransaction transactions = new frmEditTransaction();
            if (transactions.ShowDialog() == DialogResult.OK)
            {
                _transactions.Add(transactions);
                RefreshForm();
            }
            transactions.ShowDialog();

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTransaction transactions = new frmEditTransaction();
            transactions.ShowDialog();
        }

        private void категорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreatingCategories creatingCategories = new frmCreatingCategories();
            creatingCategories.ShowDialog();
        }

        
    }
}
