namespace Financial_Analyst.View
{
    partial class frmEditTransaction
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
            this.groupBoxEditTransaction = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTypeTransactionChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSumTransaction = new System.Windows.Forms.TextBox();
            this.dateTimePickerExpenses = new System.Windows.Forms.DateTimePicker();
            this.lblDateExpenses = new System.Windows.Forms.Label();
            this.txtCommentTransaction = new System.Windows.Forms.TextBox();
            this.lblСommentTransaction = new System.Windows.Forms.Label();
            this.cmbCategoryTransaction = new System.Windows.Forms.ComboBox();
            this.lblCategoryExpenses = new System.Windows.Forms.Label();
            this.cmbChoiceAccount = new System.Windows.Forms.ComboBox();
            this.lblBillExpenses = new System.Windows.Forms.Label();
            this.lblSumtransaction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelExpenses = new System.Windows.Forms.Button();
            this.btnOkExpenses = new System.Windows.Forms.Button();
            this.cmbChoiceUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxEditTransaction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEditTransaction
            // 
            this.groupBoxEditTransaction.Controls.Add(this.cmbChoiceUser);
            this.groupBoxEditTransaction.Controls.Add(this.label3);
            this.groupBoxEditTransaction.Controls.Add(this.label2);
            this.groupBoxEditTransaction.Controls.Add(this.cmbTypeTransactionChoice);
            this.groupBoxEditTransaction.Controls.Add(this.label1);
            this.groupBoxEditTransaction.Controls.Add(this.txtSumTransaction);
            this.groupBoxEditTransaction.Controls.Add(this.dateTimePickerExpenses);
            this.groupBoxEditTransaction.Controls.Add(this.lblDateExpenses);
            this.groupBoxEditTransaction.Controls.Add(this.txtCommentTransaction);
            this.groupBoxEditTransaction.Controls.Add(this.lblСommentTransaction);
            this.groupBoxEditTransaction.Controls.Add(this.cmbCategoryTransaction);
            this.groupBoxEditTransaction.Controls.Add(this.lblCategoryExpenses);
            this.groupBoxEditTransaction.Controls.Add(this.cmbChoiceAccount);
            this.groupBoxEditTransaction.Controls.Add(this.lblBillExpenses);
            this.groupBoxEditTransaction.Controls.Add(this.lblSumtransaction);
            this.groupBoxEditTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEditTransaction.Location = new System.Drawing.Point(12, 3);
            this.groupBoxEditTransaction.Name = "groupBoxEditTransaction";
            this.groupBoxEditTransaction.Size = new System.Drawing.Size(337, 355);
            this.groupBoxEditTransaction.TabIndex = 0;
            this.groupBoxEditTransaction.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "руб.";
            // 
            // cmbTypeTransactionChoice
            // 
            this.cmbTypeTransactionChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeTransactionChoice.FormattingEnabled = true;
            this.cmbTypeTransactionChoice.Location = new System.Drawing.Point(140, 53);
            this.cmbTypeTransactionChoice.Name = "cmbTypeTransactionChoice";
            this.cmbTypeTransactionChoice.Size = new System.Drawing.Size(191, 28);
            this.cmbTypeTransactionChoice.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тип транзакции";
            // 
            // txtSumTransaction
            // 
            this.txtSumTransaction.Location = new System.Drawing.Point(140, 13);
            this.txtSumTransaction.Name = "txtSumTransaction";
            this.txtSumTransaction.Size = new System.Drawing.Size(103, 26);
            this.txtSumTransaction.TabIndex = 9;
            // 
            // dateTimePickerExpenses
            // 
            this.dateTimePickerExpenses.Location = new System.Drawing.Point(138, 319);
            this.dateTimePickerExpenses.Name = "dateTimePickerExpenses";
            this.dateTimePickerExpenses.Size = new System.Drawing.Size(191, 26);
            this.dateTimePickerExpenses.TabIndex = 0;
            // 
            // lblDateExpenses
            // 
            this.lblDateExpenses.AutoSize = true;
            this.lblDateExpenses.Location = new System.Drawing.Point(6, 319);
            this.lblDateExpenses.Name = "lblDateExpenses";
            this.lblDateExpenses.Size = new System.Drawing.Size(48, 20);
            this.lblDateExpenses.TabIndex = 8;
            this.lblDateExpenses.Text = "Дата";
            // 
            // txtCommentTransaction
            // 
            this.txtCommentTransaction.Location = new System.Drawing.Point(138, 231);
            this.txtCommentTransaction.Multiline = true;
            this.txtCommentTransaction.Name = "txtCommentTransaction";
            this.txtCommentTransaction.Size = new System.Drawing.Size(191, 71);
            this.txtCommentTransaction.TabIndex = 7;
            // 
            // lblСommentTransaction
            // 
            this.lblСommentTransaction.AutoSize = true;
            this.lblСommentTransaction.Location = new System.Drawing.Point(6, 234);
            this.lblСommentTransaction.Name = "lblСommentTransaction";
            this.lblСommentTransaction.Size = new System.Drawing.Size(113, 20);
            this.lblСommentTransaction.TabIndex = 6;
            this.lblСommentTransaction.Text = "Комментарий";
            // 
            // cmbCategoryTransaction
            // 
            this.cmbCategoryTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryTransaction.FormattingEnabled = true;
            this.cmbCategoryTransaction.Location = new System.Drawing.Point(140, 185);
            this.cmbCategoryTransaction.Name = "cmbCategoryTransaction";
            this.cmbCategoryTransaction.Size = new System.Drawing.Size(191, 28);
            this.cmbCategoryTransaction.TabIndex = 5;
            // 
            // lblCategoryExpenses
            // 
            this.lblCategoryExpenses.AutoSize = true;
            this.lblCategoryExpenses.Location = new System.Drawing.Point(8, 188);
            this.lblCategoryExpenses.Name = "lblCategoryExpenses";
            this.lblCategoryExpenses.Size = new System.Drawing.Size(89, 20);
            this.lblCategoryExpenses.TabIndex = 4;
            this.lblCategoryExpenses.Text = "Категория";
            // 
            // cmbChoiceAccount
            // 
            this.cmbChoiceAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoiceAccount.FormattingEnabled = true;
            this.cmbChoiceAccount.Location = new System.Drawing.Point(140, 143);
            this.cmbChoiceAccount.Name = "cmbChoiceAccount";
            this.cmbChoiceAccount.Size = new System.Drawing.Size(191, 28);
            this.cmbChoiceAccount.TabIndex = 3;
            // 
            // lblBillExpenses
            // 
            this.lblBillExpenses.AutoSize = true;
            this.lblBillExpenses.Location = new System.Drawing.Point(8, 146);
            this.lblBillExpenses.Name = "lblBillExpenses";
            this.lblBillExpenses.Size = new System.Drawing.Size(47, 20);
            this.lblBillExpenses.TabIndex = 2;
            this.lblBillExpenses.Text = "Счёт";
            // 
            // lblSumtransaction
            // 
            this.lblSumtransaction.AutoSize = true;
            this.lblSumtransaction.Location = new System.Drawing.Point(8, 16);
            this.lblSumtransaction.Name = "lblSumtransaction";
            this.lblSumtransaction.Size = new System.Drawing.Size(62, 20);
            this.lblSumtransaction.TabIndex = 0;
            this.lblSumtransaction.Text = "Сумма ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelExpenses);
            this.panel1.Controls.Add(this.btnOkExpenses);
            this.panel1.Location = new System.Drawing.Point(6, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelExpenses
            // 
            this.btnCancelExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelExpenses.Location = new System.Drawing.Point(230, 3);
            this.btnCancelExpenses.Name = "btnCancelExpenses";
            this.btnCancelExpenses.Size = new System.Drawing.Size(104, 36);
            this.btnCancelExpenses.TabIndex = 1;
            this.btnCancelExpenses.Text = "Отмена";
            this.btnCancelExpenses.UseVisualStyleBackColor = true;
            this.btnCancelExpenses.Click += new System.EventHandler(this.btnCancelExpenses_Click);
            // 
            // btnOkExpenses
            // 
            this.btnOkExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOkExpenses.Location = new System.Drawing.Point(3, 3);
            this.btnOkExpenses.Name = "btnOkExpenses";
            this.btnOkExpenses.Size = new System.Drawing.Size(104, 36);
            this.btnOkExpenses.TabIndex = 0;
            this.btnOkExpenses.Text = "OK";
            this.btnOkExpenses.UseVisualStyleBackColor = true;
            this.btnOkExpenses.Click += new System.EventHandler(this.btnOkExpenses_Click);
            // 
            // cmbChoiceUser
            // 
            this.cmbChoiceUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoiceUser.FormattingEnabled = true;
            this.cmbChoiceUser.Location = new System.Drawing.Point(140, 96);
            this.cmbChoiceUser.Name = "cmbChoiceUser";
            this.cmbChoiceUser.Size = new System.Drawing.Size(191, 28);
            this.cmbChoiceUser.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пользователь";
            // 
            // frmEditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxEditTransaction);
            this.Name = "frmEditTransaction";
            this.groupBoxEditTransaction.ResumeLayout(false);
            this.groupBoxEditTransaction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditTransaction;
        private System.Windows.Forms.ComboBox cmbCategoryTransaction;
        private System.Windows.Forms.Label lblCategoryExpenses;
        private System.Windows.Forms.ComboBox cmbChoiceAccount;
        private System.Windows.Forms.Label lblBillExpenses;
        private System.Windows.Forms.Label lblSumtransaction;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpenses;
        private System.Windows.Forms.Label lblDateExpenses;
        private System.Windows.Forms.TextBox txtCommentTransaction;
        private System.Windows.Forms.Label lblСommentTransaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOkExpenses;
        private System.Windows.Forms.Button btnCancelExpenses;
        private System.Windows.Forms.TextBox txtSumTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypeTransactionChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChoiceUser;
        private System.Windows.Forms.Label label3;
    }
}