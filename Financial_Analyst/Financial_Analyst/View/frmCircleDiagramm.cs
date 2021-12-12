using Financial_Analyst.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Financial_Analyst.View
{
    public partial class frmCircleDiagramm : Form
    {
        private IUser _user;
        public frmCircleDiagramm(IUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void frmCircleDiagramm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Соотношение доходов и расходов");
            IReadOnlyCollection<ITransaction> transactionList = TransactionProcessor.GetTransactions(_user);
            IReadOnlyCollection<ICategory> categoryList = CategoryProcessor.GetCategory();

            decimal sumCategoryExpenses = 0;
            decimal sumCategoryIncom = 0;
            foreach (ITransaction transaction in transactionList)
            {
                if (transaction.Category.CType == CategoryType.Expense)
                {
                    sumCategoryExpenses += transaction.PaymentSum * (-1);
                }
                else
                {
                    sumCategoryIncom += transaction.PaymentSum;
                }
            }
            chart1.Series[0].Points.Add(new DataPoint(0, Convert.ToDouble(sumCategoryExpenses))
            {
                AxisLabel = "Расходы",
                Color = Color.Red
            });

            chart1.Series[0].Points.Add(new DataPoint(0, Convert.ToDouble(sumCategoryIncom))
            {
                AxisLabel = "Доходы",
                Color = Color.Green
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Соотношение расходов по категориям");
            IReadOnlyCollection<ITransaction> transactionList = TransactionProcessor.GetTransactions(_user);
            IReadOnlyCollection<ICategory> categoryList = CategoryProcessor.GetCategory();

            foreach (ICategory category in categoryList)
            {
                if (category.CType == CategoryType.Expense)
                {
                    decimal sumCategory = 0;
                    foreach (ITransaction transaction in transactionList)
                    {
                        if (category.Name == transaction.Category.Name)
                        {
                            sumCategory += transaction.PaymentSum * (-1);
                        }
                    }
                    chart1.Series[0].Points.Add(new DataPoint(0, Convert.ToDouble(sumCategory))
                    {
                        AxisLabel = category.Name,
                        Color = category.CategoryColor
                    });
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                {
                    chart1.Series[0].Points.Clear();
                    chart1.Titles.Clear();
                    chart1.Titles.Add("Соотношение доходов по категориям");
                    IReadOnlyCollection<ITransaction> transactionList = TransactionProcessor.GetTransactions(_user);
                    IReadOnlyCollection<ICategory> categoryList = CategoryProcessor.GetCategory();

                    foreach (ICategory category in categoryList)
                    {
                        if (category.CType == CategoryType.Incom)
                        {
                            decimal sumCategory = 0;
                            foreach (ITransaction transaction in transactionList)
                            {
                                if (category.Name == transaction.Category.Name)
                                {
                                    sumCategory += transaction.PaymentSum * (-1);
                                }
                            }
                            chart1.Series[0].Points.Add(new DataPoint(0, Convert.ToDouble(sumCategory))
                            {
                                AxisLabel = category.Name,
                                Color = category.CategoryColor
                            });
                        }
                    }
                }
            }
        }
    }
}
    

