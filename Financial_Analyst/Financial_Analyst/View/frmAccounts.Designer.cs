
namespace Financial_Analyst.View
{
    partial class frmAccounts
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
            this.grbAddAccounts = new System.Windows.Forms.GroupBox();
            this.lblRuble = new System.Windows.Forms.Label();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnOKSaveAccounts = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtAccountDescription = new System.Windows.Forms.TextBox();
            this.lblAccountDescription = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.grbAccounts = new System.Windows.Forms.GroupBox();
            this.lbListAccounts = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.grbAddAccounts.SuspendLayout();
            this.grbAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAddAccounts
            // 
            this.grbAddAccounts.Controls.Add(this.checkedListBox1);
            this.grbAddAccounts.Controls.Add(this.lblRuble);
            this.grbAddAccounts.Controls.Add(this.txtAccountBalance);
            this.grbAddAccounts.Controls.Add(this.lblBalance);
            this.grbAddAccounts.Controls.Add(this.btnOKSaveAccounts);
            this.grbAddAccounts.Controls.Add(this.btnDeleteAccount);
            this.grbAddAccounts.Controls.Add(this.btnAddAccount);
            this.grbAddAccounts.Controls.Add(this.txtAccountDescription);
            this.grbAddAccounts.Controls.Add(this.lblAccountDescription);
            this.grbAddAccounts.Controls.Add(this.txtAccountName);
            this.grbAddAccounts.Controls.Add(this.lblAccountName);
            this.grbAddAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbAddAccounts.Location = new System.Drawing.Point(351, 6);
            this.grbAddAccounts.Name = "grbAddAccounts";
            this.grbAddAccounts.Size = new System.Drawing.Size(351, 377);
            this.grbAddAccounts.TabIndex = 3;
            this.grbAddAccounts.TabStop = false;
            // 
            // lblRuble
            // 
            this.lblRuble.AutoSize = true;
            this.lblRuble.Location = new System.Drawing.Point(290, 63);
            this.lblRuble.Name = "lblRuble";
            this.lblRuble.Size = new System.Drawing.Size(38, 20);
            this.lblRuble.TabIndex = 8;
            this.lblRuble.Text = "руб.";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(101, 57);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(183, 26);
            this.txtAccountBalance.TabIndex = 7;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(6, 63);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(65, 20);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Баланс";
            // 
            // btnOKSaveAccounts
            // 
            this.btnOKSaveAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOKSaveAccounts.Location = new System.Drawing.Point(248, 332);
            this.btnOKSaveAccounts.Name = "btnOKSaveAccounts";
            this.btnOKSaveAccounts.Size = new System.Drawing.Size(97, 39);
            this.btnOKSaveAccounts.TabIndex = 5;
            this.btnOKSaveAccounts.Text = "ОК";
            this.btnOKSaveAccounts.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(248, 247);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(97, 38);
            this.btnDeleteAccount.TabIndex = 4;
            this.btnDeleteAccount.Text = "Удалить";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAccount.Location = new System.Drawing.Point(248, 193);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(97, 38);
            this.btnAddAccount.TabIndex = 2;
            this.btnAddAccount.Text = "Добавить";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccountDescription
            // 
            this.txtAccountDescription.Location = new System.Drawing.Point(101, 103);
            this.txtAccountDescription.Multiline = true;
            this.txtAccountDescription.Name = "txtAccountDescription";
            this.txtAccountDescription.Size = new System.Drawing.Size(244, 73);
            this.txtAccountDescription.TabIndex = 3;
            // 
            // lblAccountDescription
            // 
            this.lblAccountDescription.AutoSize = true;
            this.lblAccountDescription.Location = new System.Drawing.Point(6, 109);
            this.lblAccountDescription.Name = "lblAccountDescription";
            this.lblAccountDescription.Size = new System.Drawing.Size(83, 20);
            this.lblAccountDescription.TabIndex = 2;
            this.lblAccountDescription.Text = "Описание";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(101, 16);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(244, 26);
            this.txtAccountName.TabIndex = 1;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(6, 22);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(83, 20);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Название";
            // 
            // grbAccounts
            // 
            this.grbAccounts.Controls.Add(this.lbListAccounts);
            this.grbAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbAccounts.Location = new System.Drawing.Point(4, 6);
            this.grbAccounts.Name = "grbAccounts";
            this.grbAccounts.Size = new System.Drawing.Size(341, 380);
            this.grbAccounts.TabIndex = 2;
            this.grbAccounts.TabStop = false;
            this.grbAccounts.Text = "Счета";
            // 
            // lbListAccounts
            // 
            this.lbListAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbListAccounts.FormattingEnabled = true;
            this.lbListAccounts.ItemHeight = 20;
            this.lbListAccounts.Location = new System.Drawing.Point(3, 22);
            this.lbListAccounts.Name = "lbListAccounts";
            this.lbListAccounts.Size = new System.Drawing.Size(335, 355);
            this.lbListAccounts.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(10, 193);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(212, 172);
            this.checkedListBox1.TabIndex = 9;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 390);
            this.Controls.Add(this.grbAddAccounts);
            this.Controls.Add(this.grbAccounts);
            this.Name = "frmAccounts";
            this.Text = "Счета";
            this.grbAddAccounts.ResumeLayout(false);
            this.grbAddAccounts.PerformLayout();
            this.grbAccounts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddAccounts;
        private System.Windows.Forms.Button btnOKSaveAccounts;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtAccountDescription;
        private System.Windows.Forms.Label lblAccountDescription;
        private System.Windows.Forms.GroupBox grbAccounts;
        private System.Windows.Forms.ListBox lbListAccounts;
        private System.Windows.Forms.Label lblRuble;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}