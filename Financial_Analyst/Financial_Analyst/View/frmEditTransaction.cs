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
    public partial class frmEditTransaction : Form
    {
        //private ITransaction _context;
        
        //private bool IsEdit = false;

        public frmEditTransaction(/*ITransaction transaction = null*/)
        {
            InitializeComponent();

            //if (transaction != null)
            //{
            //    Text = "Редактирование";
            //    _context = transaction;
            //    IsEdit = true;
            //    RefreshView();
            //}
            //else
            //{
            //    Text = "Добавление";
            //    cmbTypeTransactionChoice.SelectedIndex = 0;
            //}
        }



        private void RefreshView()
        {
            
            //txtSumTransaction.Text = _context.PaymentSum.ToString();

           // cmbTypeTransactionChoice.SelectedIndex = (int)_context.; / сделать проверку, на то, что выбрана категория доход, расход
            //txtCommentTransaction.Text = _context.Comment;
        }


        // private void RefreshView()     // прописать метод обновления
        // private void RefreshContext()  // нужно написать свой метод обновления полей контекста
        // private void CheckField()        // метод проверки правильнисти или заполненности полей


        private void btnOkExpenses_Click(object sender, EventArgs e)
        {
            //RefreshContex();  // обновление контекста полей, нужно сделать метод
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelExpenses_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
