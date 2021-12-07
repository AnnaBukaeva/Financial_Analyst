using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Financial_Analyst.Logic;

namespace Financial_Analyst.View
{
    public partial class frmMain : Form
    {
        private IUser _user;
        private Form _userAuth;      
        
        public frmMain(IUser user, Form userAuth)
        {
            InitializeComponent();
            _userAuth = userAuth;
            _user = user;
            txtUserName.Text = _user.FIO;          
            
            dgvListTransactions.AutoGenerateColumns = false;
            RefreshForm();            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _userAuth.Show();
        }
      
        private void RefreshForm()   //обновить список транзакций
        {
            dgvListTransactions.Rows.Clear();
            foreach(ITransaction transaction in TransactionProcessor.GetTransactions(_user))
            {
                dgvListTransactions.Rows.Add(transaction.Date, transaction.PaymentSum, transaction.Category.Name, 
                                             transaction.User.FIO, transaction.Comment,transaction.TransactionID);
            }
        }

        private void RefreshCmbChoiceCategoryFastAddExpenses()
        {
            // обновить список категорий в комбо боксе
            cmbChoiceCategoryFastAddExpenses.Items.Clear();
            foreach(ICategory category in CategoryProcessor.GetCategory())
            {
                cmbChoiceCategoryFastAddExpenses.Items.Add(category.Name);
            }
        }

        private void RefreshCmbAccountChoise()   // обновить список счетов в комбо боксе
        {
            // обновить список счетов
            cmbAccountChoise.Items.Clear();
            foreach (IAccount account in AccountProcessor.GetAccounts(_user))
            {
                cmbAccountChoise.Items.Add(account.Name);
            }
        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccounts accounts = new frmAccounts(_user);
            if (accounts.ShowDialog() == DialogResult.OK)
            {
                RefreshCmbAccountChoise();
            }
            //accounts.ShowDialog();
        }

        private void AddTransactionToolStripMenuItem_Click(object sender, EventArgs e) //добавить транзакции
        {

            frmEditTransaction transactions = new frmEditTransaction();
            //if (transactions.ShowDialog() == DialogResult.OK)
            //{
            //    //_transaction.Add(transactions);
            //   RefreshForm
            //}
            transactions.ShowDialog();
        }

        private void EditTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTransaction transactions = new frmEditTransaction();
            transactions.ShowDialog();
        }

        private void AddCategoriesToolStripMenuItem_Click(object sender, EventArgs e) //добавить категорию
        {
            frmCreatingCategories creatingCategories = new frmCreatingCategories();
            if (creatingCategories.ShowDialog() == DialogResult.OK)
            {
                RefreshCmbChoiceCategoryFastAddExpenses();
            }
            //creatingCategories.ShowDialog();
        }

        private void btnAddFastAddExpenses_Click(object sender, EventArgs e) //добавить быструю транзакцию
        { 
            try
            {
                DateTime dateTime = DateTime.Now;
                decimal paymentSum = Convert.ToDecimal(txtSumFastAddExpenses.Text);
                IUser currentUser = null;
                foreach (IUser user in UserProcessor.GetUsers())
                {
                    if (cmbChoiceUserFastAddExpenses.Text == user.FIO)
                    {
                        currentUser = user;
                        break;
                    }
                }
                if (currentUser == null)
                {
                    throw new Exception("Пользователь не найден!");
                }

                IAccount currentAccount = null;
                foreach (Account account in AccountProcessor.GetAccounts(_user))
                {
                    if (cmbAccountChoise.Text == account.Name)
                    {
                        currentAccount = account;
                        break;
                    }
                }
                if (currentAccount == null)
                {
                    throw new Exception("Счёт не найден!");
                }

                ICategory currentCategory = null;
                foreach (Category category in CategoryProcessor.GetCategory())
                {
                    if (cmbChoiceCategoryFastAddExpenses.Text == category.Name)
                    {
                        currentCategory = category;
                        break;
                    }
                }
                if (currentCategory == null)
                {
                    throw new Exception("Категория не найдена");
                }

                TransactionProcessor.CreateTransaction(dateTime, paymentSum, currentUser, 
                                                       currentAccount,currentCategory);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!"); 
            }
            RefreshForm();
        }

        private void CheckComboBoxAccountChoise()
        {
            cmbAccountChoise.Items.Clear();
            foreach (IAccount accounts in AccountProcessor.GetAccounts(_user))
            {
                cmbAccountChoise.Items.Add(accounts.Name);
            }
        }

        private void CheckComboBoxChoiceCategoryFastAddExpenses()
        {
            cmbChoiceCategoryFastAddExpenses.Items.Clear();
            foreach (ICategory categories in CategoryProcessor.GetCategory())
            {
                cmbChoiceCategoryFastAddExpenses.Items.Add(categories.Name);
            }
        }

        private void CheckComboBoxUserFastAddExpenses()
        {
            cmbChoiceUserFastAddExpenses.Items.Clear();
            foreach (User users in UserProcessor.GetUsers())
            {
                cmbChoiceUserFastAddExpenses.Items.Add(users.FIO);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {           
            CheckComboBoxAccountChoise();
            CheckComboBoxChoiceCategoryFastAddExpenses();
            CheckComboBoxUserFastAddExpenses();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            _userAuth.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            TransactionProcessor.RemoveTransaction(Convert.ToInt32(textBoxTransactionID.Text));
            RefreshForm();
        }

        private void аналитикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircleDiagramm analyticForm = new frmCircleDiagramm(_user);
            analyticForm.Show();
        }
    }
}
