
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
            this.accountNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(578, 122);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(100, 20);
            this.balance.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(460, 122);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 2;
            // 
            // add_acc_button
            // 
            this.add_acc_button.Location = new System.Drawing.Point(534, 175);
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
            // accountNameColumn
            // 
            this.accountNameColumn.HeaderText = "Account Name";
            this.accountNameColumn.Name = "accountNameColumn";
            this.accountNameColumn.ReadOnly = true;
            // 
            // BalanceColumn
            // 
            this.BalanceColumn.HeaderText = "Balance";
            this.BalanceColumn.Name = "BalanceColumn";
            this.BalanceColumn.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceColumn;
    }
}