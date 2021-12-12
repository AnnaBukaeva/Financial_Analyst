using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic.SaveFile
{
    class TextFileSaver
    {
		public static void Save(string path, IUser user)
		{
			var sep = ";";
			using (StreamWriter myWriter = new StreamWriter(path))
			{
				myWriter.WriteLine($"Date{sep}Sum{sep}Category{sep}User");
				foreach (var t in TransactionProcessor.GetTransactions(user))
				{
					myWriter.WriteLine($"{t.Date}{sep}{t.PaymentSum}{sep}{t.Category.Name}{sep}{t.User.FIO}");
				}
			}
		}

	}
}
