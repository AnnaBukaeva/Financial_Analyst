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
        
        private List<ICategory> _categories; //потом удалить
        public frmCreatingCategories()
        {
            InitializeComponent();
            _categories = new List<ICategory>();
            RefreshList();
        }

        private void RefreshList()
        {
            dgvListCategories.Rows.Clear();
            foreach (ICategory categories in _categories)
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

        private void btnOkCatecory_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
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

                ICategory category = new Category(nameCategory, discriptionCategory, colorCategory, 
                                    (CategoryType)cmpTypeTransaction.SelectedIndex);
                _categories.Add(category);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            }

            RefreshList();
        }
    }
}
