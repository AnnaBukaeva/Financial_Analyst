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

namespace Financial_Analyst.View
{
    public partial class frmMain : Form
    {
        private List<ITransaction> _transactions;
        public frmMain()
        {
            InitializeComponent();
            //dgvListTransactions.AutoGenerateColumns = false;
            dgvListTransactions.DataSource = _transactions;
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
            //List<string> type_names = EnumText.GetEnumNames(typeof(ItemType));
            //frmEdit form = new frmEdit(type_names);
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    _items.Add(form.Context);
            //    RefreshForm();
            //}

            frmEditTransaction transactions = new frmEditTransaction();
            //if (transactions.ShowDialog() == DialogResult.OK)
            //{
            //    _transactions.Add(transactions.);
            //    RefreshForm();
            //}
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
