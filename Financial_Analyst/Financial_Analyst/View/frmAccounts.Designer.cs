
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
            this.clbAccountUserAccess = new System.Windows.Forms.CheckedListBox();
            this.lblRuble = new System.Windows.Forms.Label();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnOKAccounts = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtAccountComment = new System.Windows.Forms.TextBox();
            this.lblAccountDescription = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.grbAccounts = new System.Windows.Forms.GroupBox();
            this.dgvListAccounts = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAddAccounts.SuspendLayout();
            this.grbAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddAccounts
            // 
            this.grbAddAccounts.Controls.Add(this.clbAccountUserAccess);
            this.grbAddAccounts.Controls.Add(this.lblRuble);
            this.grbAddAccounts.Controls.Add(this.txtAccountBalance);
            this.grbAddAccounts.Controls.Add(this.lblBalance);
            this.grbAddAccounts.Controls.Add(this.btnOKAccounts);
            this.grbAddAccounts.Controls.Add(this.btnAddAccount);
            this.grbAddAccounts.Controls.Add(this.txtAccountComment);
            this.grbAddAccounts.Controls.Add(this.lblAccountDescription);
            this.grbAddAccounts.Controls.Add(this.txtAccountName);
            this.grbAddAccounts.Controls.Add(this.lblAccountName);
            this.grbAddAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbAddAccounts.Location = new System.Drawing.Point(382, 6);
            this.grbAddAccounts.Name = "grbAddAccounts";
            this.grbAddAccounts.Size = new System.Drawing.Size(339, 325);
            this.grbAddAccounts.TabIndex = 3;
            this.grbAddAccounts.TabStop = false;
            // 
            // clbAccountUserAccess
            // 
            this.clbAccountUserAccess.FormattingEnabled = true;
            this.clbAccountUserAccess.Location = new System.Drawing.Point(9, 187);
            this.clbAccountUserAccess.Name = "clbAccountUserAccess";
            this.clbAccountUserAccess.Size = new System.Drawing.Size(200, 130);
            this.clbAccountUserAccess.TabIndex = 9;
            // 
            // lblRuble
            // 
            this.lblRuble.AutoSize = true;
            this.lblRuble.Location = new System.Drawing.Point(273, 63);
            this.lblRuble.Name = "lblRuble";
            this.lblRuble.Size = new System.Drawing.Size(35, 17);
            this.lblRuble.TabIndex = 8;
            this.lblRuble.Text = "руб.";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(84, 60);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(183, 23);
            this.txtAccountBalance.TabIndex = 7;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(6, 63);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(56, 17);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Баланс";
            // 
            // btnOKAccounts
            // 
            this.btnOKAccounts.BackColor = System.Drawing.Color.Thistle;
            this.btnOKAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOKAccounts.Location = new System.Drawing.Point(231, 278);
            this.btnOKAccounts.Name = "btnOKAccounts";
            this.btnOKAccounts.Size = new System.Drawing.Size(97, 37);
            this.btnOKAccounts.TabIndex = 5;
            this.btnOKAccounts.Text = "ОК";
            this.btnOKAccounts.UseVisualStyleBackColor = false;
            this.btnOKAccounts.Click += new System.EventHandler(this.btnOKAccounts_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Thistle;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAccount.Location = new System.Drawing.Point(231, 187);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(97, 38);
            this.btnAddAccount.TabIndex = 2;
            this.btnAddAccount.Text = "Добавить";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtAccountComment
            // 
            this.txtAccountComment.Location = new System.Drawing.Point(84, 103);
            this.txtAccountComment.Multiline = true;
            this.txtAccountComment.Name = "txtAccountComment";
            this.txtAccountComment.Size = new System.Drawing.Size(244, 73);
            this.txtAccountComment.TabIndex = 3;
            // 
            // lblAccountDescription
            // 
            this.lblAccountDescription.AutoSize = true;
            this.lblAccountDescription.Location = new System.Drawing.Point(6, 109);
            this.lblAccountDescription.Name = "lblAccountDescription";
            this.lblAccountDescription.Size = new System.Drawing.Size(74, 17);
            this.lblAccountDescription.TabIndex = 2;
            this.lblAccountDescription.Text = "Описание";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(84, 19);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(244, 23);
            this.txtAccountName.TabIndex = 1;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(6, 22);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(72, 17);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Название";
            // 
            // grbAccounts
            // 
            this.grbAccounts.Controls.Add(this.dgvListAccounts);
            this.grbAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbAccounts.Location = new System.Drawing.Point(3, 6);
            this.grbAccounts.Name = "grbAccounts";
            this.grbAccounts.Size = new System.Drawing.Size(373, 325);
            this.grbAccounts.TabIndex = 2;
            this.grbAccounts.TabStop = false;
            this.grbAccounts.Text = "Счета";
            // 
            // dgvListAccounts
            // 
            this.dgvListAccounts.AllowUserToAddRows = false;
            this.dgvListAccounts.AllowUserToDeleteRows = false;
            this.dgvListAccounts.AllowUserToOrderColumns = true;
            this.dgvListAccounts.AllowUserToResizeRows = false;
            this.dgvListAccounts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clnBalance,
            this.clnComment});
            this.dgvListAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListAccounts.Location = new System.Drawing.Point(3, 19);
            this.dgvListAccounts.Name = "dgvListAccounts";
            this.dgvListAccounts.ReadOnly = true;
            this.dgvListAccounts.RowHeadersVisible = false;
            this.dgvListAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListAccounts.Size = new System.Drawing.Size(367, 303);
            this.dgvListAccounts.TabIndex = 0;
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.FillWeight = 120F;
            this.clmName.HeaderText = "Название";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 120;
            // 
            // clnBalance
            // 
            this.clnBalance.DataPropertyName = "Balance";
            this.clnBalance.HeaderText = "Баланс";
            this.clnBalance.Name = "clnBalance";
            this.clnBalance.ReadOnly = true;
            // 
            // clnComment
            // 
            this.clnComment.DataPropertyName = "Comment";
            this.clnComment.FillWeight = 140F;
            this.clnComment.HeaderText = "Описание";
            this.clnComment.Name = "clnComment";
            this.clnComment.ReadOnly = true;
            this.clnComment.Width = 140;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(723, 334);
            this.Controls.Add(this.grbAddAccounts);
            this.Controls.Add(this.grbAccounts);
            this.MinimumSize = new System.Drawing.Size(739, 373);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счета";
            this.grbAddAccounts.ResumeLayout(false);
            this.grbAddAccounts.PerformLayout();
            this.grbAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddAccounts;
        private System.Windows.Forms.Button btnOKAccounts;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtAccountComment;
        private System.Windows.Forms.Label lblAccountDescription;
        private System.Windows.Forms.GroupBox grbAccounts;
        private System.Windows.Forms.Label lblRuble;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.DataGridView dgvListAccounts;
        private System.Windows.Forms.CheckedListBox clbAccountUserAccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnComment;
    }
}