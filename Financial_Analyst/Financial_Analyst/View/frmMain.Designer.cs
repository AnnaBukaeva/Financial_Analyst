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
            this.dgvAccountsList = new System.Windows.Forms.DataGridView();
            this.ColumnAccauntName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabExpenses = new System.Windows.Forms.TabPage();
            this.txtPaymentSum = new System.Windows.Forms.TextBox();
            this.cmbSelectCategoriePayment = new System.Windows.Forms.ComboBox();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.cmbSelectAccountForTransaction = new System.Windows.Forms.ComboBox();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.lblCategoriePayment = new System.Windows.Forms.Label();
            this.lblDatePayment = new System.Windows.Forms.Label();
            this.lblAccauntNameExpenses = new System.Windows.Forms.Label();
            this.lblTypeTransaction = new System.Windows.Forms.Label();
            this.lblPaymentSum = new System.Windows.Forms.Label();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.tabIncome = new System.Windows.Forms.TabPage();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.panelBtnIncome = new System.Windows.Forms.Panel();
            this.btnDeliteIncome = new System.Windows.Forms.Button();
            this.btnChangeIncome = new System.Windows.Forms.Button();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvlLIstTransaction = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabAddAccount.SuspendLayout();
            this.grboxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountsList)).BeginInit();
            this.tabExpenses.SuspendLayout();
            this.tabIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.panelBtnIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlLIstTransaction)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(846, 473);
            this.tabControl.TabIndex = 0;
            // 
            // tabAddAccount
            // 
            this.tabAddAccount.Controls.Add(this.grboxUser);
            this.tabAddAccount.Controls.Add(this.dgvAccountsList);
            this.tabAddAccount.Location = new System.Drawing.Point(4, 29);
            this.tabAddAccount.Name = "tabAddAccount";
            this.tabAddAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddAccount.Size = new System.Drawing.Size(838, 440);
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
            this.grboxUser.Size = new System.Drawing.Size(219, 232);
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
            // dgvAccountsList
            // 
            this.dgvAccountsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAccauntName,
            this.ColumnBalance});
            this.dgvAccountsList.Location = new System.Drawing.Point(456, 22);
            this.dgvAccountsList.Name = "dgvAccountsList";
            this.dgvAccountsList.Size = new System.Drawing.Size(306, 185);
            this.dgvAccountsList.TabIndex = 3;
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
            this.tabExpenses.Controls.Add(this.dgvlLIstTransaction);
            this.tabExpenses.Controls.Add(this.txtPaymentSum);
            this.tabExpenses.Controls.Add(this.cmbSelectCategoriePayment);
            this.tabExpenses.Controls.Add(this.cmbTransactionType);
            this.tabExpenses.Controls.Add(this.cmbSelectAccountForTransaction);
            this.tabExpenses.Controls.Add(this.datePayment);
            this.tabExpenses.Controls.Add(this.lblCategoriePayment);
            this.tabExpenses.Controls.Add(this.lblDatePayment);
            this.tabExpenses.Controls.Add(this.lblAccauntNameExpenses);
            this.tabExpenses.Controls.Add(this.lblTypeTransaction);
            this.tabExpenses.Controls.Add(this.lblPaymentSum);
            this.tabExpenses.Controls.Add(this.btnAddTransaction);
            this.tabExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabExpenses.Location = new System.Drawing.Point(4, 29);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpenses.Size = new System.Drawing.Size(838, 440);
            this.tabExpenses.TabIndex = 0;
            this.tabExpenses.Text = "Расходы";
            // 
            // txtPaymentSum
            // 
            this.txtPaymentSum.Location = new System.Drawing.Point(25, 294);
            this.txtPaymentSum.Name = "txtPaymentSum";
            this.txtPaymentSum.Size = new System.Drawing.Size(200, 26);
            this.txtPaymentSum.TabIndex = 47;
            // 
            // cmbSelectCategoriePayment
            // 
            this.cmbSelectCategoriePayment.FormattingEnabled = true;
            this.cmbSelectCategoriePayment.Location = new System.Drawing.Point(26, 219);
            this.cmbSelectCategoriePayment.Name = "cmbSelectCategoriePayment";
            this.cmbSelectCategoriePayment.Size = new System.Drawing.Size(199, 28);
            this.cmbSelectCategoriePayment.TabIndex = 46;
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Location = new System.Drawing.Point(26, 134);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(199, 28);
            this.cmbTransactionType.TabIndex = 45;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // cmbSelectAccountForTransaction
            // 
            this.cmbSelectAccountForTransaction.FormattingEnabled = true;
            this.cmbSelectAccountForTransaction.Location = new System.Drawing.Point(26, 57);
            this.cmbSelectAccountForTransaction.Name = "cmbSelectAccountForTransaction";
            this.cmbSelectAccountForTransaction.Size = new System.Drawing.Size(200, 28);
            this.cmbSelectAccountForTransaction.TabIndex = 44;
            // 
            // datePayment
            // 
            this.datePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePayment.Location = new System.Drawing.Point(26, 365);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(200, 26);
            this.datePayment.TabIndex = 42;
            // 
            // lblCategoriePayment
            // 
            this.lblCategoriePayment.AutoSize = true;
            this.lblCategoriePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoriePayment.Location = new System.Drawing.Point(21, 183);
            this.lblCategoriePayment.Name = "lblCategoriePayment";
            this.lblCategoriePayment.Size = new System.Drawing.Size(89, 20);
            this.lblCategoriePayment.TabIndex = 39;
            this.lblCategoriePayment.Text = "Категория";
            // 
            // lblDatePayment
            // 
            this.lblDatePayment.AutoSize = true;
            this.lblDatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDatePayment.Location = new System.Drawing.Point(22, 333);
            this.lblDatePayment.Name = "lblDatePayment";
            this.lblDatePayment.Size = new System.Drawing.Size(48, 20);
            this.lblDatePayment.TabIndex = 38;
            this.lblDatePayment.Text = "Дата";
            // 
            // lblAccauntNameExpenses
            // 
            this.lblAccauntNameExpenses.AutoSize = true;
            this.lblAccauntNameExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccauntNameExpenses.Location = new System.Drawing.Point(21, 23);
            this.lblAccauntNameExpenses.Name = "lblAccauntNameExpenses";
            this.lblAccauntNameExpenses.Size = new System.Drawing.Size(131, 20);
            this.lblAccauntNameExpenses.TabIndex = 36;
            this.lblAccauntNameExpenses.Text = "Название счёта";
            // 
            // lblTypeTransaction
            // 
            this.lblTypeTransaction.AutoSize = true;
            this.lblTypeTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeTransaction.Location = new System.Drawing.Point(21, 100);
            this.lblTypeTransaction.Name = "lblTypeTransaction";
            this.lblTypeTransaction.Size = new System.Drawing.Size(106, 20);
            this.lblTypeTransaction.TabIndex = 34;
            this.lblTypeTransaction.Text = "Тип платежа";
            // 
            // lblPaymentSum
            // 
            this.lblPaymentSum.AutoSize = true;
            this.lblPaymentSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaymentSum.Location = new System.Drawing.Point(22, 261);
            this.lblPaymentSum.Name = "lblPaymentSum";
            this.lblPaymentSum.Size = new System.Drawing.Size(58, 20);
            this.lblPaymentSum.TabIndex = 33;
            this.lblPaymentSum.Text = "Сумма";
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTransaction.Location = new System.Drawing.Point(70, 403);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(107, 37);
            this.btnAddTransaction.TabIndex = 32;
            this.btnAddTransaction.Text = "Добавить";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // tabIncome
            // 
            this.tabIncome.Controls.Add(this.dgvIncome);
            this.tabIncome.Controls.Add(this.panelBtnIncome);
            this.tabIncome.Location = new System.Drawing.Point(4, 29);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncome.Size = new System.Drawing.Size(838, 440);
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
            this.dgvIncome.Size = new System.Drawing.Size(778, 238);
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
            this.tabStatistics.Size = new System.Drawing.Size(838, 440);
            this.tabStatistics.TabIndex = 2;
            this.tabStatistics.Text = "Статистика";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvlLIstTransaction
            // 
            this.dgvlLIstTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlLIstTransaction.Location = new System.Drawing.Point(305, 23);
            this.dgvlLIstTransaction.Name = "dgvlLIstTransaction";
            this.dgvlLIstTransaction.Size = new System.Drawing.Size(509, 417);
            this.dgvlLIstTransaction.TabIndex = 48;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 501);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "Финансовый аналитик";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAddAccount.ResumeLayout(false);
            this.grboxUser.ResumeLayout(false);
            this.grboxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountsList)).EndInit();
            this.tabExpenses.ResumeLayout(false);
            this.tabExpenses.PerformLayout();
            this.tabIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.panelBtnIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlLIstTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabExpenses;
        private System.Windows.Forms.TabPage tabIncome;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelBtnIncome;
        private System.Windows.Forms.Button btnDeliteIncome;
        private System.Windows.Forms.Button btnChangeIncome;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.GroupBox grboxUser;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.DataGridView dgvAccountsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccauntName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBalance;
        private System.Windows.Forms.TabPage tabAddAccount;
        private System.Windows.Forms.Label lblCategoriePayment;
        private System.Windows.Forms.Label lblDatePayment;
        private System.Windows.Forms.Label lblAccauntNameExpenses;
        private System.Windows.Forms.Label lblTypeTransaction;
        private System.Windows.Forms.Label lblPaymentSum;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.TextBox txtPaymentSum;
        private System.Windows.Forms.ComboBox cmbSelectCategoriePayment;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.ComboBox cmbSelectAccountForTransaction;
        private System.Windows.Forms.DataGridView dgvlLIstTransaction;
    }
}

