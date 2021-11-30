namespace Financial_Analyst.View
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAddAccount = new System.Windows.Forms.TabPage();
            this.grboxUser = new System.Windows.Forms.GroupBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.ColumnAccauntName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabExpenses = new System.Windows.Forms.TabPage();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBtnExpenses = new System.Windows.Forms.Panel();
            this.btnDeleteExpenses = new System.Windows.Forms.Button();
            this.btnChangeExpenses = new System.Windows.Forms.Button();
            this.btnAddExpenses = new System.Windows.Forms.Button();
            this.tabIncome = new System.Windows.Forms.TabPage();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.panelBtnIncome = new System.Windows.Forms.Panel();
            this.btnDeliteIncome = new System.Windows.Forms.Button();
            this.btnChangeIncome = new System.Windows.Forms.Button();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl.SuspendLayout();
            this.tabAddAccount.SuspendLayout();
            this.grboxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.tabExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.panelBtnExpenses.SuspendLayout();
            this.tabIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.panelBtnIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabAddAccount);
            this.tabControl.Controls.Add(this.tabExpenses);
            this.tabControl.Controls.Add(this.tabIncome);
            this.tabControl.Controls.Add(this.tabStatistics);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(846, 444);
            this.tabControl.TabIndex = 0;
            // 
            // tabAddAccount
            // 
            this.tabAddAccount.Controls.Add(this.grboxUser);
            this.tabAddAccount.Controls.Add(this.dgvAccount);
            this.tabAddAccount.Location = new System.Drawing.Point(4, 29);
            this.tabAddAccount.Name = "tabAddAccount";
            this.tabAddAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddAccount.Size = new System.Drawing.Size(838, 411);
            this.tabAddAccount.TabIndex = 3;
            this.tabAddAccount.Text = "Счета";
            this.tabAddAccount.UseVisualStyleBackColor = true;
            // 
            // grboxUser
            // 
            this.grboxUser.Controls.Add(this.btnAddAccount);
            this.grboxUser.Controls.Add(this.txtBalance);
            this.grboxUser.Controls.Add(this.txtAccountName);
            this.grboxUser.Controls.Add(this.lblBalance);
            this.grboxUser.Controls.Add(this.lblAccountName);
            this.grboxUser.Location = new System.Drawing.Point(29, 22);
            this.grboxUser.Name = "grboxUser";
            this.grboxUser.Size = new System.Drawing.Size(326, 295);
            this.grboxUser.TabIndex = 2;
            this.grboxUser.TabStop = false;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAccount.Location = new System.Drawing.Point(60, 171);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(96, 35);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "Добавить";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBalance.Location = new System.Drawing.Point(9, 117);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(194, 26);
            this.txtBalance.TabIndex = 3;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAccountName.Location = new System.Drawing.Point(9, 45);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(194, 26);
            this.txtAccountName.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.Location = new System.Drawing.Point(6, 94);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(65, 20);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Баланс";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccountName.Location = new System.Drawing.Point(6, 16);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(131, 20);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Название счёта";
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAccauntName,
            this.ColumnBalance});
            this.dgvAccount.Location = new System.Drawing.Point(471, 34);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(308, 147);
            this.dgvAccount.TabIndex = 3;
            // 
            // ColumnAccauntName
            // 
            this.ColumnAccauntName.HeaderText = "Название";
            this.ColumnAccauntName.Name = "ColumnAccauntName";
            // 
            // ColumnBalance
            // 
            this.ColumnBalance.HeaderText = "Баланс";
            this.ColumnBalance.Name = "ColumnBalance";
            // 
            // tabExpenses
            // 
            this.tabExpenses.BackColor = System.Drawing.Color.Transparent;
            this.tabExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabExpenses.Controls.Add(this.dgvExpenses);
            this.tabExpenses.Controls.Add(this.panelBtnExpenses);
            this.tabExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabExpenses.Location = new System.Drawing.Point(4, 29);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpenses.Size = new System.Drawing.Size(838, 411);
            this.tabExpenses.TabIndex = 0;
            this.tabExpenses.Text = "Расходы";
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSum,
            this.ColumnBill,
            this.ColumnaCategory,
            this.ColumnComment,
            this.ColumnDate});
            this.dgvExpenses.Location = new System.Drawing.Point(7, 76);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.Size = new System.Drawing.Size(800, 289);
            this.dgvExpenses.TabIndex = 1;
            // 
            // ColumnSum
            // 
            this.ColumnSum.HeaderText = "Сумма";
            this.ColumnSum.Name = "ColumnSum";
            // 
            // ColumnBill
            // 
            this.ColumnBill.FillWeight = 150F;
            this.ColumnBill.HeaderText = "Счёт";
            this.ColumnBill.Name = "ColumnBill";
            this.ColumnBill.Width = 150;
            // 
            // ColumnaCategory
            // 
            this.ColumnaCategory.FillWeight = 200F;
            this.ColumnaCategory.HeaderText = "Категория";
            this.ColumnaCategory.Name = "ColumnaCategory";
            this.ColumnaCategory.Width = 200;
            // 
            // ColumnComment
            // 
            this.ColumnComment.FillWeight = 200F;
            this.ColumnComment.HeaderText = "Комментарий";
            this.ColumnComment.Name = "ColumnComment";
            this.ColumnComment.Width = 200;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // panelBtnExpenses
            // 
            this.panelBtnExpenses.Controls.Add(this.btnDeleteExpenses);
            this.panelBtnExpenses.Controls.Add(this.btnChangeExpenses);
            this.panelBtnExpenses.Controls.Add(this.btnAddExpenses);
            this.panelBtnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelBtnExpenses.Location = new System.Drawing.Point(6, 6);
            this.panelBtnExpenses.Name = "panelBtnExpenses";
            this.panelBtnExpenses.Size = new System.Drawing.Size(779, 63);
            this.panelBtnExpenses.TabIndex = 0;
            // 
            // btnDeleteExpenses
            // 
            this.btnDeleteExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteExpenses.Location = new System.Drawing.Point(234, 15);
            this.btnDeleteExpenses.Name = "btnDeleteExpenses";
            this.btnDeleteExpenses.Size = new System.Drawing.Size(92, 36);
            this.btnDeleteExpenses.TabIndex = 2;
            this.btnDeleteExpenses.Text = "Удалить";
            this.btnDeleteExpenses.UseVisualStyleBackColor = true;
            this.btnDeleteExpenses.Click += new System.EventHandler(this.btnDeleteExpenses_Click);
            // 
            // btnChangeExpenses
            // 
            this.btnChangeExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeExpenses.Location = new System.Drawing.Point(123, 15);
            this.btnChangeExpenses.Name = "btnChangeExpenses";
            this.btnChangeExpenses.Size = new System.Drawing.Size(92, 36);
            this.btnChangeExpenses.TabIndex = 1;
            this.btnChangeExpenses.Text = "Изменить";
            this.btnChangeExpenses.UseVisualStyleBackColor = true;
            this.btnChangeExpenses.Click += new System.EventHandler(this.btnChangeExpenses_Click);
            // 
            // btnAddExpenses
            // 
            this.btnAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExpenses.Location = new System.Drawing.Point(13, 15);
            this.btnAddExpenses.Name = "btnAddExpenses";
            this.btnAddExpenses.Size = new System.Drawing.Size(92, 36);
            this.btnAddExpenses.TabIndex = 0;
            this.btnAddExpenses.Text = "Добавить";
            this.btnAddExpenses.UseVisualStyleBackColor = true;
            this.btnAddExpenses.Click += new System.EventHandler(this.btnAddExpenses_Click);
            // 
            // tabIncome
            // 
            this.tabIncome.Controls.Add(this.dgvIncome);
            this.tabIncome.Controls.Add(this.panelBtnIncome);
            this.tabIncome.Location = new System.Drawing.Point(4, 29);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncome.Size = new System.Drawing.Size(838, 411);
            this.tabIncome.TabIndex = 1;
            this.tabIncome.Text = "Доходы";
            this.tabIncome.UseVisualStyleBackColor = true;
            // 
            // dgvIncome
            // 
            this.dgvIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(6, 75);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.Size = new System.Drawing.Size(778, 356);
            this.dgvIncome.TabIndex = 2;
            // 
            // panelBtnIncome
            // 
            this.panelBtnIncome.Controls.Add(this.btnDeliteIncome);
            this.panelBtnIncome.Controls.Add(this.btnChangeIncome);
            this.panelBtnIncome.Controls.Add(this.btnAddIncome);
            this.panelBtnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelBtnIncome.Location = new System.Drawing.Point(6, 6);
            this.panelBtnIncome.Name = "panelBtnIncome";
            this.panelBtnIncome.Size = new System.Drawing.Size(773, 63);
            this.panelBtnIncome.TabIndex = 1;
            // 
            // btnDeliteIncome
            // 
            this.btnDeliteIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeliteIncome.Location = new System.Drawing.Point(234, 15);
            this.btnDeliteIncome.Name = "btnDeliteIncome";
            this.btnDeliteIncome.Size = new System.Drawing.Size(92, 36);
            this.btnDeliteIncome.TabIndex = 2;
            this.btnDeliteIncome.Text = "Удалить";
            this.btnDeliteIncome.UseVisualStyleBackColor = true;
            // 
            // btnChangeIncome
            // 
            this.btnChangeIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeIncome.Location = new System.Drawing.Point(123, 15);
            this.btnChangeIncome.Name = "btnChangeIncome";
            this.btnChangeIncome.Size = new System.Drawing.Size(92, 36);
            this.btnChangeIncome.TabIndex = 1;
            this.btnChangeIncome.Text = "Изменить";
            this.btnChangeIncome.UseVisualStyleBackColor = true;
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddIncome.Location = new System.Drawing.Point(13, 15);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(92, 36);
            this.btnAddIncome.TabIndex = 0;
            this.btnAddIncome.Text = "Добавить";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            // 
            // tabStatistics
            // 
            this.tabStatistics.Location = new System.Drawing.Point(4, 29);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(838, 411);
            this.tabStatistics.TabIndex = 2;
            this.tabStatistics.Text = "Статистика";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 472);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "Финансовый аналитик";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAddAccount.ResumeLayout(false);
            this.grboxUser.ResumeLayout(false);
            this.grboxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.tabExpenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.panelBtnExpenses.ResumeLayout(false);
            this.tabIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.panelBtnIncome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabExpenses;
        private System.Windows.Forms.TabPage tabIncome;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelBtnExpenses;
        private System.Windows.Forms.Button btnAddExpenses;
        private System.Windows.Forms.Button btnDeleteExpenses;
        private System.Windows.Forms.Button btnChangeExpenses;
        private System.Windows.Forms.Panel panelBtnIncome;
        private System.Windows.Forms.Button btnDeliteIncome;
        private System.Windows.Forms.Button btnChangeIncome;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.GroupBox grboxUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccauntName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBalance;
        private System.Windows.Forms.TabPage tabAddAccount;
    }
}

