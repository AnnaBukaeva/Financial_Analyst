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
            this.groupBoxEditExpenses = new System.Windows.Forms.GroupBox();
            this.dateTimePickerExpenses = new System.Windows.Forms.DateTimePicker();
            this.lblDateExpenses = new System.Windows.Forms.Label();
            this.txtCommentExpenses = new System.Windows.Forms.TextBox();
            this.lblСommentExpenses = new System.Windows.Forms.Label();
            this.cmbCategoryExpenses = new System.Windows.Forms.ComboBox();
            this.lblCategoryExpenses = new System.Windows.Forms.Label();
            this.cmbTybeBill = new System.Windows.Forms.ComboBox();
            this.lblBillExpenses = new System.Windows.Forms.Label();
            this.lblSumtransaction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelExpenses = new System.Windows.Forms.Button();
            this.btnOkExpenses = new System.Windows.Forms.Button();
            this.txtSumTransaction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxEditExpenses.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEditExpenses
            // 
            this.groupBoxEditExpenses.Controls.Add(this.label2);
            this.groupBoxEditExpenses.Controls.Add(this.comboBox1);
            this.groupBoxEditExpenses.Controls.Add(this.label1);
            this.groupBoxEditExpenses.Controls.Add(this.txtSumTransaction);
            this.groupBoxEditExpenses.Controls.Add(this.dateTimePickerExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.lblDateExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.txtCommentExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.lblСommentExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.cmbCategoryExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.lblCategoryExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.cmbTybeBill);
            this.groupBoxEditExpenses.Controls.Add(this.lblBillExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.lblSumtransaction);
            this.groupBoxEditExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEditExpenses.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEditExpenses.Name = "groupBoxEditExpenses";
            this.groupBoxEditExpenses.Size = new System.Drawing.Size(337, 276);
            this.groupBoxEditExpenses.TabIndex = 0;
            this.groupBoxEditExpenses.TabStop = false;
            // 
            // dateTimePickerExpenses
            // 
            this.dateTimePickerExpenses.Location = new System.Drawing.Point(140, 239);
            this.dateTimePickerExpenses.Name = "dateTimePickerExpenses";
            this.dateTimePickerExpenses.Size = new System.Drawing.Size(191, 26);
            this.dateTimePickerExpenses.TabIndex = 0;
            // 
            // lblDateExpenses
            // 
            this.lblDateExpenses.AutoSize = true;
            this.lblDateExpenses.Location = new System.Drawing.Point(8, 239);
            this.lblDateExpenses.Name = "lblDateExpenses";
            this.lblDateExpenses.Size = new System.Drawing.Size(48, 20);
            this.lblDateExpenses.TabIndex = 8;
            this.lblDateExpenses.Text = "Дата";
            // 
            // txtCommentExpenses
            // 
            this.txtCommentExpenses.Location = new System.Drawing.Point(140, 185);
            this.txtCommentExpenses.Multiline = true;
            this.txtCommentExpenses.Name = "txtCommentExpenses";
            this.txtCommentExpenses.Size = new System.Drawing.Size(191, 37);
            this.txtCommentExpenses.TabIndex = 7;
            // 
            // lblСommentExpenses
            // 
            this.lblСommentExpenses.AutoSize = true;
            this.lblСommentExpenses.Location = new System.Drawing.Point(8, 188);
            this.lblСommentExpenses.Name = "lblСommentExpenses";
            this.lblСommentExpenses.Size = new System.Drawing.Size(113, 20);
            this.lblСommentExpenses.TabIndex = 6;
            this.lblСommentExpenses.Text = "Комментарий";
            // 
            // cmbCategoryExpenses
            // 
            this.cmbCategoryExpenses.FormattingEnabled = true;
            this.cmbCategoryExpenses.Location = new System.Drawing.Point(140, 137);
            this.cmbCategoryExpenses.Name = "cmbCategoryExpenses";
            this.cmbCategoryExpenses.Size = new System.Drawing.Size(191, 28);
            this.cmbCategoryExpenses.TabIndex = 5;
            // 
            // lblCategoryExpenses
            // 
            this.lblCategoryExpenses.AutoSize = true;
            this.lblCategoryExpenses.Location = new System.Drawing.Point(8, 140);
            this.lblCategoryExpenses.Name = "lblCategoryExpenses";
            this.lblCategoryExpenses.Size = new System.Drawing.Size(89, 20);
            this.lblCategoryExpenses.TabIndex = 4;
            this.lblCategoryExpenses.Text = "Категория";
            // 
            // cmbTybeBill
            // 
            this.cmbTybeBill.FormattingEnabled = true;
            this.cmbTybeBill.Location = new System.Drawing.Point(140, 94);
            this.cmbTybeBill.Name = "cmbTybeBill";
            this.cmbTybeBill.Size = new System.Drawing.Size(191, 28);
            this.cmbTybeBill.TabIndex = 3;
            // 
            // lblBillExpenses
            // 
            this.lblBillExpenses.AutoSize = true;
            this.lblBillExpenses.Location = new System.Drawing.Point(8, 97);
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
            this.panel1.Location = new System.Drawing.Point(12, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelExpenses
            // 
            this.btnCancelExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelExpenses.Location = new System.Drawing.Point(227, 3);
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
            this.btnOkExpenses.Location = new System.Drawing.Point(0, 3);
            this.btnOkExpenses.Name = "btnOkExpenses";
            this.btnOkExpenses.Size = new System.Drawing.Size(104, 36);
            this.btnOkExpenses.TabIndex = 0;
            this.btnOkExpenses.Text = "OK";
            this.btnOkExpenses.UseVisualStyleBackColor = true;
            this.btnOkExpenses.Click += new System.EventHandler(this.btnOkExpenses_Click);
            // 
            // txtSumTransaction
            // 
            this.txtSumTransaction.Location = new System.Drawing.Point(140, 13);
            this.txtSumTransaction.Name = "txtSumTransaction";
            this.txtSumTransaction.Size = new System.Drawing.Size(103, 26);
            this.txtSumTransaction.TabIndex = 9;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 28);
            this.comboBox1.TabIndex = 11;
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
            // frmEditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxEditExpenses);
            this.Name = "frmEditTransaction";
            this.groupBoxEditExpenses.ResumeLayout(false);
            this.groupBoxEditExpenses.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditExpenses;
        private System.Windows.Forms.ComboBox cmbCategoryExpenses;
        private System.Windows.Forms.Label lblCategoryExpenses;
        private System.Windows.Forms.ComboBox cmbTybeBill;
        private System.Windows.Forms.Label lblBillExpenses;
        private System.Windows.Forms.Label lblSumtransaction;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpenses;
        private System.Windows.Forms.Label lblDateExpenses;
        private System.Windows.Forms.TextBox txtCommentExpenses;
        private System.Windows.Forms.Label lblСommentExpenses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOkExpenses;
        private System.Windows.Forms.Button btnCancelExpenses;
        private System.Windows.Forms.TextBox txtSumTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}