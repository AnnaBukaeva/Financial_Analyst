﻿using System;
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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    AuthProcessor.RegisterUser(txtFIO.Text, txtPassword.Text);
            //    MessageBox.Show("Пользователь зарегистрирован! Можно под ним войти!", "Готово!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Ошибка!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}