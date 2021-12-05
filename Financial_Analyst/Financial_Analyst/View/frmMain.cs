using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Financial_Analyst.Logic;

namespace Financial_Analyst.View
{
    public partial class frmMain : Form
    {
        private IUser _user;
        private Form _userAuth;
        private List<IAccount> _accounts;
        private List<ICategory> _category;

        public frmMain(IUser user, Form userAuth)
        {
            InitializeComponent();
            _userAuth = userAuth;
            _user = user;
            txtUserName.Text = _user.FIO;          
            
            _accounts = new List<IAccount>();          //переписать на transactionRepozitory
            _accounts.Add(new Account("Мама", 2345, new List<int> { 1,2,3}));

            _category = new List<ICategory>();
            _category.Add(new Category("Еда", "Ашан", Color.Red, CategoryType.Expense));
            _category.Add(new Category("Зарплата", "Работа", Color.Green, CategoryType.Incom)); //переписать

            dgvListTransactions.AutoGenerateColumns = false;
            RefreshForm();            
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
            dgvListTransactions.Rows.Clear();
            foreach(ITransaction transaction in TransactionProcessor.GetTransactions(_user))
            {
                dgvListTransactions.Rows.Add(transaction.Date, transaction.PaymentSum, transaction.Category.Name, 
                                             transaction.User.FIO, transaction.Comment);
            }
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
                //_transactions.Add(transactions);
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

        private void btnAddFastAddExpenses_Click(object sender, EventArgs e)
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
                foreach (Account account in _accounts)
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
                foreach (Category category in _category)
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

                TransactionProcessor.CreateTransaction(dateTime, paymentSum, currentUser, currentAccount, currentCategory);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBoxButtons., MessageBoxIcon.Error
            }
            RefreshForm();
        }

        private void FieldComboBoxAccountChoise()
        {
            cmbAccountChoise.Items.Clear();
            foreach (IAccount accounts in _accounts)
            {
                cmbAccountChoise.Items.Add(accounts.Name);
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //foreach(IAccount accounts in _accounts)
            //{
            //    cmbAccountChoise.Items.Add(accounts.Name);
            //}
            FieldComboBoxAccountChoise();
        }
    }
}
