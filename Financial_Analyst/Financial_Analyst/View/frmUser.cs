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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtFirstNameUser.Text == "user" && txtLastNameUser.Text == "user" 
                && txtAccountNumber.Text == "123456789")
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                txtFirstNameUser.Text = "";
                txtLastNameUser.Text = "";
                txtAccountNumber.Text = "";
                MessageBox.Show("Неправильное имя или фамилия пользователя, или счёт!");
            }

        }
    }
}
