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
    public partial class frmEditExpenses : Form
    {
        public frmEditExpenses()
        {
            InitializeComponent();
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
