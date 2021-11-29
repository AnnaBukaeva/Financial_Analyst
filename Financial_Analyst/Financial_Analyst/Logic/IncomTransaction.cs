using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic
{
    public class IncomTransaction : ITransaction
    {
        private string _paymentCategorie; // для защиты отдельного значения от внешнего изменения
                                          //категория поступления(депозитб кеш проценты)        
        public static string[] IncomCategories = new[] { "Salary", "Cashback", "Interest on bank deposits", "Other" };
        public string PaymentCategorie
        {
            get => _paymentCategorie;
            set
            {
                bool flag = false;
                for (int i = 0; i < IncomCategories.Length; i++)
                {
                    if(IncomCategories[i] == value)
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
                    throw new ArgumentException("Incom Category not found!");
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
                if(value <= 0)
                {
                    throw new ArgumentException("The amount of receipts cannot be less than or equal to 0!");
                }
                _paymentSum = value;
            } 
        } //значение будем получать из конструктора

        public DateTime Date { get; private set; }

        public IncomTransaction(decimal paymentSum, string paymentCategorie, DateTime date)
        {          
            PaymentSum = paymentSum;
            PaymentCategorie = paymentCategorie;
            Date = date;
        }
    }
}
