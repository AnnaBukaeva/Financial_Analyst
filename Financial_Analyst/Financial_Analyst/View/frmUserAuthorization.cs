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
    public partial class frmUserAuthorization : Form
    {

        public frmUserAuthorization()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                IUser user = UserProcessor.FindAndCheckPassword(txtFIO.Text, txtPassword.Text);
                if (user == null)
                    throw new Exception("Пользователь с таким логином/паролем не существует");

                frmMain mainForm = new frmMain(user, this);
                mainForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Нет пользователя!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmRegistration registration = new frmRegistration();
            registration.ShowDialog();
        }
    }
}
