
namespace Financial_Analyst.View
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.add_acc_button = new System.Windows.Forms.Button();
            this.listAccounts = new System.Windows.Forms.DataGridView();
            this.transactionType = new System.Windows.Forms.ComboBox();
            this.paymentSum = new System.Windows.Forms.TextBox();
            this.add_type_transaction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listTransaction = new System.Windows.Forms.DataGridView();
            this.accountNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectAccountTransaction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addExpensesTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addIncomTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriePayment = new System.Windows.Forms.Label();
            this.paymentCategorieSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(275, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 2;
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(275, 108);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(100, 20);
            this.balance.TabIndex = 3;
            // 
            // add_acc_button
            // 
            this.add_acc_button.Location = new System.Drawing.Point(275, 144);
            this.add_acc_button.Name = "add_acc_button";
            this.add_acc_button.Size = new System.Drawing.Size(75, 23);
            this.add_acc_button.TabIndex = 4;
            this.add_acc_button.Text = "добавить";
            this.add_acc_button.UseVisualStyleBackColor = true;
            this.add_acc_button.Click += new System.EventHandler(this.add_account_button_Click);
            // 
            // listAccounts
            // 
            this.listAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNameColumn,
            this.BalanceColumn});
            this.listAccounts.Location = new System.Drawing.Point(12, 58);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(257, 284);
            this.listAccounts.TabIndex = 5;
            // 
            // transactionType
            // 
            this.transactionType.FormattingEnabled = true;
            this.transactionType.Items.AddRange(new object[] {
            "incom pay",
            "expenses pay"});
            this.transactionType.Location = new System.Drawing.Point(410, 108);
            this.transactionType.Name = "transactionType";
            this.transactionType.Size = new System.Drawing.Size(121, 21);
            this.transactionType.TabIndex = 6;
            this.transactionType.TextChanged += new System.EventHandler(this.transactionType_TextChanged);
            // 
            // paymentSum
            // 
            this.paymentSum.Location = new System.Drawing.Point(431, 208);
            this.paymentSum.Name = "paymentSum";
            this.paymentSum.Size = new System.Drawing.Size(100, 20);
            this.paymentSum.TabIndex = 7;
            // 
            // add_type_transaction
            // 
            this.add_type_transaction.Location = new System.Drawing.Point(456, 282);
            this.add_type_transaction.Name = "add_type_transaction";
            this.add_type_transaction.Size = new System.Drawing.Size(75, 23);
            this.add_type_transaction.TabIndex = 8;
            this.add_type_transaction.Text = "добавить";
            this.add_type_transaction.UseVisualStyleBackColor = true;
            this.add_type_transaction.Click += new System.EventHandler(this.add_type_transaction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // listTransaction
            // 
            this.listTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountName,
            this.addExpensesTransaction,
            this.addIncomTransaction,
            this.date});
            this.listTransaction.Location = new System.Drawing.Point(546, 58);
            this.listTransaction.Name = "listTransaction";
            this.listTransaction.Size = new System.Drawing.Size(414, 284);
            this.listTransaction.TabIndex = 11;
            // 
            // accountNameColumn
            // 
            this.accountNameColumn.HeaderText = "Account name";
            this.accountNameColumn.Name = "accountNameColumn";
            this.accountNameColumn.ReadOnly = true;
            // 
            // BalanceColumn
            // 
            this.BalanceColumn.HeaderText = "Balance";
            this.BalanceColumn.Name = "BalanceColumn";
            this.BalanceColumn.ReadOnly = true;
            // 
            // selectAccountTransaction
            // 
            this.selectAccountTransaction.FormattingEnabled = true;
            this.selectAccountTransaction.Location = new System.Drawing.Point(410, 57);
            this.selectAccountTransaction.Name = "selectAccountTransaction";
            this.selectAccountTransaction.Size = new System.Drawing.Size(121, 21);
            this.selectAccountTransaction.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Account";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(431, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date";
            // 
            // accountName
            // 
            this.accountName.HeaderText = "Account name";
            this.accountName.Name = "accountName";
            this.accountName.ReadOnly = true;
            // 
            // addExpensesTransaction
            // 
            this.addExpensesTransaction.HeaderText = "Payment categorie";
            this.addExpensesTransaction.Name = "addExpensesTransaction";
            this.addExpensesTransaction.ReadOnly = true;
            // 
            // addIncomTransaction
            // 
            this.addIncomTransaction.HeaderText = "Sum transaction";
            this.addIncomTransaction.Name = "addIncomTransaction";
            this.addIncomTransaction.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date transaction";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // categoriePayment
            // 
            this.categoriePayment.AutoSize = true;
            this.categoriePayment.Location = new System.Drawing.Point(479, 144);
            this.categoriePayment.Name = "categoriePayment";
            this.categoriePayment.Size = new System.Drawing.Size(52, 13);
            this.categoriePayment.TabIndex = 17;
            this.categoriePayment.Text = "Categorie";
            // 
            // paymentCategorieSelect
            // 
            this.paymentCategorieSelect.FormattingEnabled = true;
            this.paymentCategorieSelect.Items.AddRange(new object[] {
            "incom pay",
            "expenses pay"});
            this.paymentCategorieSelect.Location = new System.Drawing.Point(410, 160);
            this.paymentCategorieSelect.Name = "paymentCategorieSelect";
            this.paymentCategorieSelect.Size = new System.Drawing.Size(121, 21);
            this.paymentCategorieSelect.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.paymentCategorieSelect);
            this.Controls.Add(this.categoriePayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectAccountTransaction);
            this.Controls.Add(this.listTransaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_type_transaction);
            this.Controls.Add(this.paymentSum);
            this.Controls.Add(this.transactionType);
            this.Controls.Add(this.listAccounts);
            this.Controls.Add(this.add_acc_button);
            this.Controls.Add(this.name);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox balance;        
        private System.Windows.Forms.Button add_acc_button;
        private System.Windows.Forms.DataGridView listAccounts;
        private System.Windows.Forms.ComboBox transactionType;
        private System.Windows.Forms.TextBox paymentSum;
        private System.Windows.Forms.Button add_type_transaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView listTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceColumn;
        private System.Windows.Forms.ComboBox selectAccountTransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addExpensesTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn addIncomTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label categoriePayment;
        private System.Windows.Forms.ComboBox paymentCategorieSelect;
    }
}