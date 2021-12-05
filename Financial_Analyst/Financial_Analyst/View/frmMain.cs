using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_Analyst.Logic;

namespace Financial_Analyst.View
{
    public partial class frmMain : Form
    {
        private IUser _user;
        private Form _userAuth;
        private List<ITransaction> _transactions;
        private List<User> _users;
        private List<IAccount> _accounts;
        private List<ICategory> _categories;

        public frmMain(IUser user, Form userAuth)
        {
            InitializeComponent();
            _userAuth = userAuth;
            _user = user;
            txtUserName.Text = _user.FIO;

            _transactions = new List<ITransaction>();   //переписать на transactionRepozitory

            _users = UserProcessor.GetUsers(); //переписать на user Repozitory
                                                      
            _accounts = new List<IAccount>();          //переписать на account Repozitory
            _accounts.Add(new Account("Мама", 2345, new List<int> { 1,2,3}));

            _categories = new List<ICategory>();
            //_categories.Add(new Category("Еда", "Ашан", Color.Red, CategoryType.Expense));
            //_categories.Add(new Category("Зарплата", "Работа", Color.Green, CategoryType.Incom)); //переписать

            dgvListTransactions.AutoGenerateColumns = false;
            RefreshForm();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _userAuth.Show();
        }
      
        private void RefreshForm()
        {
            dgvListTransactions.Rows.Clear();
            foreach(ITransaction transaction in _transactions)
            {
                dgvListTransactions.Rows.Add(transaction.Date, transaction.PaymentSum, transaction.Category.Name, 
                                             transaction.User.FIO, transaction.Comment);
            }
        }

        private void RefreshCmbChoiceCategoryFastAddExpenses()
        {
            // обновить список категорий
            cmbChoiceCategoryFastAddExpenses.Items.Clear();
            foreach(ICategory category in _categories)
            {
                cmbChoiceCategoryFastAddExpenses.Items.Add(category.Name);
            }
        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccounts accounts = new frmAccounts();
            accounts.ShowDialog();
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
            //if (creatingCategories.ShowDialog() == DialogResult.OK)
            //{
            //    _categories.Add(creatingCategories);
            // RefreshCmbChoiceCategoryFastAddExpenses()
            //}
            creatingCategories.ShowDialog();
        }

        private void btnAddFastAddExpenses_Click(object sender, EventArgs e) //добавить быструю транзакцию
        { 
            try
            {
                DateTime dateTime = DateTime.Now;
                decimal paymentSum = Convert.ToDecimal(txtSumFastAddExpenses.Text);

                User currentUser = null;
                foreach (User user in _users)
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
                foreach (Category category in _categories)
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

      
                ITransaction fastExpenses = new Transaction(dateTime, paymentSum, currentUser,
                                                              currentAccount, currentCategory);
                _transactions.Add(fastExpenses);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!"); 
                //MessageBoxButtons., MessageBoxIcon.Error
            }

            RefreshForm();
        }


        private void CheckComboBoxAccountChoise()
        {
            cmbAccountChoise.Items.Clear();
            foreach (IAccount accounts in _accounts)
            {
                cmbAccountChoise.Items.Add(accounts.Name);
            }
        }

        private void CheckComboBoxChoiceCategoryFastAddExpenses()
        {
            cmbChoiceCategoryFastAddExpenses.Items.Clear();
            foreach (ICategory categories in _categories)
            {
                cmbChoiceCategoryFastAddExpenses.Items.Add(categories.Name);
            }
        }

        private void CheckComboBoxUserFastAddExpenses()
        {
            cmbChoiceUserFastAddExpenses.Items.Clear();
            foreach (User users in _users)
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
    }
}
