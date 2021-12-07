using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Financial_Analyst.Logic;

namespace Financial_Analyst.View
{
    public partial class frmAccounts : Form
    {
        private IUser _user;
        private Dictionary<string, int> _userIDs;
        
        public frmAccounts(IUser user)
        {
            InitializeComponent();
            _user = user;
            _userIDs = new Dictionary<string, int>();
            foreach (IUser us in UserProcessor.GetUsers())
            {
                _userIDs.Add(us.FIO, us.ID);
                clbAccountUserAccess.Items.Add(us.FIO);
            }
            RefreshDgvListAccounts();
        }

        private void RefreshDgvListAccounts()
        {
            dgvListAccounts.Rows.Clear();
            foreach (IAccount accounts in AccountProcessor.GetAccounts(_user))
            {
                dgvListAccounts.Rows.Add(accounts.Name, accounts.Balance, accounts.Comment, accounts.UsersAccess);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string nameAccount = txtAccountName.Text;
                if (string.IsNullOrEmpty(txtAccountName.Text))
                {
                    throw new Exception("Отсутствует название счёта!");
                }

                decimal balance = Convert.ToDecimal(txtAccountBalance.Text);
                string commentAccount = txtAccountComment.Text;

                List<int> IDs = new List<int>();
                if (clbAccountUserAccess.CheckedItems.Count != 0)
                {
                    foreach (var check in clbAccountUserAccess.CheckedItems)
                    {
                        IDs.Add(_userIDs[check.ToString()]);
                    }
                }
                else
                {
                    throw new Exception("Отсутствует выбранные элементы!");
                }

                AccountProcessor.CreateAccount(nameAccount, balance, commentAccount, IDs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }

            RefreshDgvListAccounts();
        }

        private void btnOKAccounts_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }            
    }
}
