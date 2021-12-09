using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Financial_Analyst.Logic;
using Financial_Analyst.Logic.SaveFile;

namespace Financial_Analyst.View
{
    public partial class frmMain : Form
    {
        private IUser _user;
        private Form _userAuth;
        private List<ITransaction> _transactions;

        public frmMain(IUser user, Form userAuth)
        {
            InitializeComponent();
            _userAuth = userAuth;
            _user = user;
            txtUserName.Text = _user.FIO; 
            
            dgvListTransactions.AutoGenerateColumns = false;
            RefreshDgvListTransactions();            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _userAuth.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            _userAuth.Show();
        }

        private void RefreshDgvListTransactions()   //обновить список транзакций (в табличке)
        {
            dgvListTransactions.Rows.Clear();
            _transactions = new List<ITransaction> (TransactionProcessor.GetTransactions(_user));
            foreach (ITransaction transaction in _transactions)
            {            
                dgvListTransactions.Rows.Add(transaction.Date, transaction.PaymentSum, transaction.Category.Name, 
                                             transaction.User.FIO, transaction.Account.Name, transaction.Comment,
                                             transaction.TransactionID);
            }
        }

        private void RefreshCmbChoiceCategoryTransaction() // обновить список категорий в комбо боксе
        {
            cmbChoiceCategoryTransaction.Items.Clear();
            foreach(ICategory category in CategoryProcessor.GetCategory())
            {
                cmbChoiceCategoryTransaction.Items.Add(category.Name);
            }
        }

        private void RefreshCmbAccountChoise()   // обновить список счетов в комбо боксе
        {
            cmbAccountChoise.Items.Clear();
            cmbAccuntChoiseForBalance.Items.Clear(); //
            foreach (IAccount account in AccountProcessor.GetAccounts(_user))
            {
                cmbAccountChoise.Items.Add(account.Name);
                cmbAccuntChoiseForBalance.Items.Add(account.Name); //
            }
        }



        private void AccountsToolStripMenuItem_Click(object sender, EventArgs e) // создать счета
        {
            frmAccounts accounts = new frmAccounts(_user);
            if (accounts.ShowDialog() == DialogResult.OK)
            {
                RefreshCmbAccountChoise();
            }
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e) // создать категоию транзакции
        {
            frmCreatingCategories creatingCategories = new frmCreatingCategories();
            if (creatingCategories.ShowDialog() == DialogResult.OK)
            {
                RefreshCmbChoiceCategoryTransaction();
            }
        }

        private void cmbTypeTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {

            //(CategoryType)cmpTypeTransaction.SelectedIndex

            //if ((CategoryType)cmbTypeTransaction.SelectedIndex == 0)
            //{
                //cmbChoiceCategoryTransaction.Items.Clear();
                //foreach (ICategory cat in CategoryProcessor.GetCategory())
                //{
                //    cmbChoiceCategoryTransaction.Items.Add(cat.Name);
                //}

            //}
            //else
            //{
            //    cmbChoiceCategoryTransaction.Items.Clear();
            //    foreach (ICategory cat in CategoryProcessor.GetCategory())
            //    {
            //        cmbChoiceCategoryTransaction.Items.Add(cat.Name);
            //    }
            //}
        }

        private void btnAddTransaction_Click(object sender, EventArgs e) //добавить транзакцию
        {
            try
            {
                DateTime dateTime = dtpDate.Value;
                decimal paymentSum = Convert.ToDecimal(txtSumTransaction.Text);
                string comment = txtCommentForTransaction.Text;

                IUser currentUser = null;
                foreach (IUser user in UserProcessor.GetUsers())
                {
                    if (cmbChoiceUserForTransaction.Text == user.FIO)
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
                    if (cmbChoiceCategoryTransaction.Text == category.Name)
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
                                                       currentAccount,currentCategory, comment);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!"); 
            }

            RefreshDgvListTransactions();
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранные строки?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<int> to_del = new List<int>();
                foreach(DataGridViewRow row in dgvListTransactions.SelectedRows)
                {
                    to_del.Add(_transactions[row.Index].TransactionID);
                }
                
                foreach(int id in to_del)
                {
                    TransactionProcessor.RemoveTransactionsList(id);
                }

                RefreshDgvListTransactions();           
            }
        }

        private void CheckComboBoxAccountChoise() // проверить комбо бокс выбора счетов
        {
            cmbAccountChoise.Items.Clear();
            cmbAccuntChoiseForBalance.Items.Clear(); //
            foreach (IAccount accounts in AccountProcessor.GetAccounts(_user))
            {
                cmbAccountChoise.Items.Add(accounts.Name);
                cmbAccuntChoiseForBalance.Items.Add(accounts.Name); //
            }

        }

        private void CheckComboBoxChoiceCategoryTransaction()   // проверить комбо бокс выбора категории
        {
            cmbChoiceCategoryTransaction.Items.Clear();
            foreach (ICategory categories in CategoryProcessor.GetCategory())
            {
                cmbChoiceCategoryTransaction.Items.Add(categories.Name);
            }
        }

        private void CheckComboBoxUserForTransaction() // проверить комбо бокс выбора пользователя, кот. принадл. транз.
        {
            cmbChoiceUserForTransaction.Items.Clear();
            foreach (User users in UserProcessor.GetUsers())
            {
                cmbChoiceUserForTransaction.Items.Add(users.FIO);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CheckComboBoxAccountChoise();
            CheckComboBoxChoiceCategoryTransaction();
            CheckComboBoxUserForTransaction();

            // чтобы при запуске формы отображалось первое значение в комбо боксах
            cmbChoiceUserForTransaction.SelectedIndex = 0;
            cmbTypeTransaction.SelectedIndex = 1;
            cmbChoiceCategoryTransaction.SelectedIndex = 0;                   
            try    // завернула в try-catch, т.к. если создал нового пользователя, у него еще нет счетов, ошибка высвеч.
            {     
                cmbAccountChoise.SelectedIndex = 0;
                cmbAccuntChoiseForBalance.SelectedIndex = 0;
            }
            catch { }        
        }

        private void AnalyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircleDiagramm analyticForm = new frmCircleDiagramm(_user);
            analyticForm.Show();
        }

        private void UnloadingTransactionListInExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|text files(*.txt)|*.txt|all files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "*.csv";
            saveFileDialog1.Title = "Выберите файл для сохранения транзакций";
            saveFileDialog1.CheckPathExists = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextFileSaver.Save(saveFileDialog1.FileName, _user);
            }
        }

        private void AboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutProgram about_program = new frmAboutProgram();
            about_program.ShowDialog();
        }

        private void cmbAccuntChoiseForBalance_SelectedIndexChanged(object sender, EventArgs e) //просмотр баланса счетов
        {
            IAccount currentAccountForBalance = null;
            foreach (Account account in AccountProcessor.GetAccounts(_user))
            {
                if (cmbAccuntChoiseForBalance.Text == account.Name)
                {
                    currentAccountForBalance = account;
                    break;
                }
            }
            if (currentAccountForBalance == null)
            {
                throw new Exception("Счёт не найден!");
            }

            txtBalance.Text = Convert.ToString( currentAccountForBalance.Balance);
        }
    }
}
