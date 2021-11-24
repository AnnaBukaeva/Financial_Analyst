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

namespace Financial_Analyst.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //private void RefreshForm()     //метод обновления инфы в форме нужно прописать
        
        private void btnAddExpenses_Click(object sender, EventArgs e)
        {
            frmEditExpenses form = new frmEditExpenses();
            form.ShowDialog();
        }

        private void btnChangeExpenses_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteExpenses_Click(object sender, EventArgs e)
        {

        }
    }
}
