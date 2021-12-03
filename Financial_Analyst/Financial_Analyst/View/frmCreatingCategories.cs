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
    public partial class frmCreatingCategories : Form
    {
        public frmCreatingCategories()
        {
            InitializeComponent();
        }

        private void btnColorCategory_Click(object sender, EventArgs e)
        {
            colorDialogCategory.ShowDialog();
            txtColorCategory.BackColor = colorDialogCategory.Color;
        }

        private void btnOkCatecory_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
