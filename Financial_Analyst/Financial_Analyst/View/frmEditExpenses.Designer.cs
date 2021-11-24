namespace Financial_Analyst.View
{
    partial class frmEditExpenses
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
            this.cmbCategoryExpenses = new System.Windows.Forms.ComboBox();
            this.lblCategoryExpenses = new System.Windows.Forms.Label();
            this.cmbTybeBill = new System.Windows.Forms.ComboBox();
            this.lblBillExpenses = new System.Windows.Forms.Label();
            this.txtSumExpenses = new System.Windows.Forms.MaskedTextBox();
            this.lblSumExpenses = new System.Windows.Forms.Label();
            this.lblСommentExpenses = new System.Windows.Forms.Label();
            this.txtCommentExpenses = new System.Windows.Forms.TextBox();
            this.lblDateExpenses = new System.Windows.Forms.Label();
            this.dateTimePickerExpenses = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOkExpenses = new System.Windows.Forms.Button();
            this.btnCancelExpenses = new System.Windows.Forms.Button();
            this.groupBoxEditExpenses.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEditExpenses
            // 
            this.groupBoxEditExpenses.Controls.Add(this.dateTimePickerExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.lblDateExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.txtCommentExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.lblСommentExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.cmbCategoryExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.lblCategoryExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.cmbTybeBill);
            this.groupBoxEditExpenses.Controls.Add(this.lblBillExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.txtSumExpenses);
            this.groupBoxEditExpenses.Controls.Add(this.lblSumExpenses);
            this.groupBoxEditExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEditExpenses.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEditExpenses.Name = "groupBoxEditExpenses";
            this.groupBoxEditExpenses.Size = new System.Drawing.Size(337, 226);
            this.groupBoxEditExpenses.TabIndex = 0;
            this.groupBoxEditExpenses.TabStop = false;
            // 
            // cmbCategoryExpenses
            // 
            this.cmbCategoryExpenses.FormattingEnabled = true;
            this.cmbCategoryExpenses.Location = new System.Drawing.Point(110, 92);
            this.cmbCategoryExpenses.Name = "cmbCategoryExpenses";
            this.cmbCategoryExpenses.Size = new System.Drawing.Size(221, 24);
            this.cmbCategoryExpenses.TabIndex = 5;
            // 
            // lblCategoryExpenses
            // 
            this.lblCategoryExpenses.AutoSize = true;
            this.lblCategoryExpenses.Location = new System.Drawing.Point(6, 99);
            this.lblCategoryExpenses.Name = "lblCategoryExpenses";
            this.lblCategoryExpenses.Size = new System.Drawing.Size(77, 17);
            this.lblCategoryExpenses.TabIndex = 4;
            this.lblCategoryExpenses.Text = "Категория";
            // 
            // cmbTybeBill
            // 
            this.cmbTybeBill.FormattingEnabled = true;
            this.cmbTybeBill.Location = new System.Drawing.Point(110, 52);
            this.cmbTybeBill.Name = "cmbTybeBill";
            this.cmbTybeBill.Size = new System.Drawing.Size(221, 24);
            this.cmbTybeBill.TabIndex = 3;
            // 
            // lblBillExpenses
            // 
            this.lblBillExpenses.AutoSize = true;
            this.lblBillExpenses.Location = new System.Drawing.Point(6, 59);
            this.lblBillExpenses.Name = "lblBillExpenses";
            this.lblBillExpenses.Size = new System.Drawing.Size(40, 17);
            this.lblBillExpenses.TabIndex = 2;
            this.lblBillExpenses.Text = "Счёт";
            // 
            // txtSumExpenses
            // 
            this.txtSumExpenses.Location = new System.Drawing.Point(110, 13);
            this.txtSumExpenses.Mask = "99999999.99";
            this.txtSumExpenses.Name = "txtSumExpenses";
            this.txtSumExpenses.Size = new System.Drawing.Size(101, 23);
            this.txtSumExpenses.TabIndex = 1;
            // 
            // lblSumExpenses
            // 
            this.lblSumExpenses.AutoSize = true;
            this.lblSumExpenses.Location = new System.Drawing.Point(6, 19);
            this.lblSumExpenses.Name = "lblSumExpenses";
            this.lblSumExpenses.Size = new System.Drawing.Size(54, 17);
            this.lblSumExpenses.TabIndex = 0;
            this.lblSumExpenses.Text = "Сумма ";
            // 
            // lblСommentExpenses
            // 
            this.lblСommentExpenses.AutoSize = true;
            this.lblСommentExpenses.Location = new System.Drawing.Point(6, 138);
            this.lblСommentExpenses.Name = "lblСommentExpenses";
            this.lblСommentExpenses.Size = new System.Drawing.Size(98, 17);
            this.lblСommentExpenses.TabIndex = 6;
            this.lblСommentExpenses.Text = "Комментарий";
            // 
            // txtCommentExpenses
            // 
            this.txtCommentExpenses.Location = new System.Drawing.Point(110, 132);
            this.txtCommentExpenses.Multiline = true;
            this.txtCommentExpenses.Name = "txtCommentExpenses";
            this.txtCommentExpenses.Size = new System.Drawing.Size(221, 37);
            this.txtCommentExpenses.TabIndex = 7;
            // 
            // lblDateExpenses
            // 
            this.lblDateExpenses.AutoSize = true;
            this.lblDateExpenses.Location = new System.Drawing.Point(6, 187);
            this.lblDateExpenses.Name = "lblDateExpenses";
            this.lblDateExpenses.Size = new System.Drawing.Size(42, 17);
            this.lblDateExpenses.TabIndex = 8;
            this.lblDateExpenses.Text = "Дата";
            // 
            // dateTimePickerExpenses
            // 
            this.dateTimePickerExpenses.Location = new System.Drawing.Point(110, 181);
            this.dateTimePickerExpenses.Name = "dateTimePickerExpenses";
            this.dateTimePickerExpenses.Size = new System.Drawing.Size(221, 23);
            this.dateTimePickerExpenses.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelExpenses);
            this.panel1.Controls.Add(this.btnOkExpenses);
            this.panel1.Location = new System.Drawing.Point(12, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 47);
            this.panel1.TabIndex = 1;
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
            // frmEditExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxEditExpenses);
            this.MaximumSize = new System.Drawing.Size(377, 349);
            this.MinimumSize = new System.Drawing.Size(377, 349);
            this.Name = "frmEditExpenses";
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
        private System.Windows.Forms.MaskedTextBox txtSumExpenses;
        private System.Windows.Forms.Label lblSumExpenses;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpenses;
        private System.Windows.Forms.Label lblDateExpenses;
        private System.Windows.Forms.TextBox txtCommentExpenses;
        private System.Windows.Forms.Label lblСommentExpenses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOkExpenses;
        private System.Windows.Forms.Button btnCancelExpenses;
    }
}