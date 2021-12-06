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
    public partial class frmCreatingCategories : Form
    {
        
        public frmCreatingCategories()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            dgvListCategories.Rows.Clear();
            foreach (ICategory categories in CategoryProcessor.GetCategory())
            {
                dgvListCategories.Rows.Add(categories.Name, categories.CType, categories.Discription,
                                           categories.CategoryColor);
            }
        }

        private void btnColorCategory_Click(object sender, EventArgs e)
        {
            colorDialogCategory.ShowDialog();
            txtColorCategory.BackColor = colorDialogCategory.Color;
        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string nameCategory = txtNameCategory.Text;
                if (string.IsNullOrEmpty(txtNameCategory.Text))
                {
                    throw new Exception("Отсутствует название категории!");
                } 
      
                string discriptionCategory = txtDiscriptionCategory.Text;
                Color colorCategory = colorDialogCategory.Color;     

                CategoryProcessor.CreateCategory(nameCategory, discriptionCategory, colorCategory,
                                    (CategoryType)cmpTypeTransaction.SelectedIndex);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            }

            RefreshList();
        }

        private void btnOkCatecory_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
