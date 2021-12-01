using System;
using System.Collections.Generic;
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
        public frmMain()
        {
            InitializeComponent();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers(); //конструктору можно передать список пользователей
            users.ShowDialog();
        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccounts accounts = new frmAccounts();
            accounts.ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTransaction frmTansactions = new frmEditTransaction();
            frmTansactions.ShowDialog();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTransaction frmTransactions = new frmEditTransaction();
            frmTransactions.ShowDialog();
        }
    }
}
