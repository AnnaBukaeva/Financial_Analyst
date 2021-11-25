using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic
{
    public class ExpensesTransaction : ITransaction
    {
        private string _paymentCategorie; // для защиты отдельного значения от внешнего изменения
                                          //категория расходов (продукты, косметика, коммунальные платежи, одежда, автомобиль)
        public static string[] ExpensesCategorie = new[] { "Food", "Cosmetics", "Utility service", "Clothing", "Car", "Other" };
        public string PaymentCategorie
        {
            get => _paymentCategorie;
            set
            {
                bool flag = false;
                for (int i = 0; i < ExpensesCategorie.Length; i++)
                {
                    if (ExpensesCategorie[i] == value)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    _paymentCategorie = value;
                }
                else
                {
                    throw new ArgumentException("Expenses Category not found!");
                }
            }
        }
        private decimal _paymentSum;
        public decimal PaymentSum
        {
            get
            {
                return _paymentSum;
            }
            private set
            {
                if (value >= 0)
                {
                    throw new ArgumentException("The amount of receipts cannot be more than or equal to 0!");
                }
                _paymentSum = value;
            }
        }
        public DateTime Date { get; private set; }

        public ExpensesTransaction (decimal paymentSum, string paymentCategorie, DateTime date)
        {
            PaymentSum = paymentSum;
            PaymentCategorie = paymentCategorie;
            Date = date;
        }
       
    }
}

