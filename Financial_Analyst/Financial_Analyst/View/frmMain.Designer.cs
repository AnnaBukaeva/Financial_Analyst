
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnloadingTransactionListInExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalyticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.прочееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListTransactions = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAddTransaction = new System.Windows.Forms.GroupBox();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbTypeTransaction = new System.Windows.Forms.ComboBox();
            this.lblCType = new System.Windows.Forms.Label();
            this.txtCommentForTransaction = new System.Windows.Forms.TextBox();
            this.lblCommentTransaction = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.cmbAccountChoise = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserTransaction = new System.Windows.Forms.Label();
            this.cmbChoiceUserForTransaction = new System.Windows.Forms.ComboBox();
            this.lblCategoryTransaction = new System.Windows.Forms.Label();
            this.cmbChoiceCategoryTransaction = new System.Windows.Forms.ComboBox();
            this.txtSumTransaction = new System.Windows.Forms.TextBox();
            this.lblSumTransaction = new System.Windows.Forms.Label();
            this.grbFilters = new System.Windows.Forms.GroupBox();
            this.mtbFilterSumMax = new System.Windows.Forms.MaskedTextBox();
            this.mtbFilterSumMin = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFilterSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEndFilter = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginFilter = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCTypeTrans = new System.Windows.Forms.Label();
            this.cmbTypeTransactionFilter = new System.Windows.Forms.ComboBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.lblCategoryTransFilters = new System.Windows.Forms.Label();
            this.cmbCategoryTransactionsFilters = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblAccountForBalanse = new System.Windows.Forms.Label();
            this.grbBalance = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.cmbAccuntChoiseForBalance = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransactions)).BeginInit();
            this.grbAddTransaction.SuspendLayout();
            this.grbFilters.SuspendLayout();
            this.grbBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AccountsToolStripMenuItem,
            this.CategoriesToolStripMenuItem,
            this.AnalyticsToolStripMenuItem,
            this.прочееToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1019, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UnloadingTransactionListInExcelToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // UnloadingTransactionListInExcelToolStripMenuItem
            // 
            this.UnloadingTransactionListInExcelToolStripMenuItem.Name = "UnloadingTransactionListInExcelToolStripMenuItem";
            this.UnloadingTransactionListInExcelToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.UnloadingTransactionListInExcelToolStripMenuItem.Text = "Выгрузка списка транзакций в Excel";
            this.UnloadingTransactionListInExcelToolStripMenuItem.Click += new System.EventHandler(this.UnloadingTransactionListInExcelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(333, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AccountsToolStripMenuItem
            // 
            this.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem";
            this.AccountsToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.AccountsToolStripMenuItem.Text = "Счета";
            this.AccountsToolStripMenuItem.Click += new System.EventHandler(this.AccountsToolStripMenuItem_Click);
            // 
            // CategoriesToolStripMenuItem
            // 
            this.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem";
            this.CategoriesToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.CategoriesToolStripMenuItem.Text = "Категории";
            this.CategoriesToolStripMenuItem.Click += new System.EventHandler(this.CategoriesToolStripMenuItem_Click);
            // 
            // AnalyticsToolStripMenuItem
            // 
            this.AnalyticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.AnalyticsToolStripMenuItem.Name = "AnalyticsToolStripMenuItem";
            this.AnalyticsToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.AnalyticsToolStripMenuItem.Text = "Аналитика";
            this.AnalyticsToolStripMenuItem.Click += new System.EventHandler(this.AnalyticsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(70, 22);
            // 
            // прочееToolStripMenuItem
            // 
            this.прочееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutTheProgramToolStripMenuItem});
            this.прочееToolStripMenuItem.Name = "прочееToolStripMenuItem";
            this.прочееToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.прочееToolStripMenuItem.Text = "Прочее";
            // 
            // AboutTheProgramToolStripMenuItem
            // 
            this.AboutTheProgramToolStripMenuItem.Name = "AboutTheProgramToolStripMenuItem";
            this.AboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.AboutTheProgramToolStripMenuItem.Text = "О программе";
            this.AboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutTheProgramToolStripMenuItem_Click);
            // 
            // dgvListTransactions
            // 
            this.dgvListTransactions.AllowUserToAddRows = false;
            this.dgvListTransactions.AllowUserToDeleteRows = false;
            this.dgvListTransactions.AllowUserToOrderColumns = true;
            this.dgvListTransactions.AllowUserToResizeRows = false;
            this.dgvListTransactions.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colSum,
            this.colCategory,
            this.colUser,
            this.clnAccount,
            this.clmComment,
            this.transactionID});
            this.dgvListTransactions.Location = new System.Drawing.Point(15, 55);
            this.dgvListTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListTransactions.Name = "dgvListTransactions";
            this.dgvListTransactions.ReadOnly = true;
            this.dgvListTransactions.RowHeadersVisible = false;
            this.dgvListTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTransactions.Size = new System.Drawing.Size(663, 451);
            this.dgvListTransactions.TabIndex = 0;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDate.FillWeight = 80F;
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 80;
            // 
            // colSum
            // 
            this.colSum.DataPropertyName = "PaymentSum";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSum.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSum.HeaderText = "Сумма";
            this.colSum.Name = "colSum";
            this.colSum.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.DataPropertyName = "Category";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCategory.FillWeight = 120F;
            this.colCategory.HeaderText = "Категория";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 120;
            // 
            // colUser
            // 
            this.colUser.DataPropertyName = "User";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUser.DefaultCellStyle = dataGridViewCellStyle4;
            this.colUser.FillWeight = 120F;
            this.colUser.HeaderText = "Пользователь";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            this.colUser.Width = 120;
            // 
            // clnAccount
            // 
            this.clnAccount.DataPropertyName = "Account";
            this.clnAccount.HeaderText = "Счёт";
            this.clnAccount.Name = "clnAccount";
            this.clnAccount.ReadOnly = true;
            // 
            // clmComment
            // 
            this.clmComment.DataPropertyName = "Comment";
            this.clmComment.FillWeight = 140F;
            this.clmComment.HeaderText = "Комментарий";
            this.clmComment.Name = "clmComment";
            this.clmComment.ReadOnly = true;
            this.clmComment.Width = 140;
            // 
            // transactionID
            // 
            this.transactionID.DataPropertyName = "TransactionID";
            this.transactionID.HeaderText = "ID Транзакции";
            this.transactionID.Name = "transactionID";
            this.transactionID.ReadOnly = true;
            this.transactionID.Visible = false;
            // 
            // grbAddTransaction
            // 
            this.grbAddTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAddTransaction.Controls.Add(this.btnDeleteTransaction);
            this.grbAddTransaction.Controls.Add(this.dtpDate);
            this.grbAddTransaction.Controls.Add(this.lblDate);
            this.grbAddTransaction.Controls.Add(this.cmbTypeTransaction);
            this.grbAddTransaction.Controls.Add(this.lblCType);
            this.grbAddTransaction.Controls.Add(this.txtCommentForTransaction);
            this.grbAddTransaction.Controls.Add(this.lblCommentTransaction);
            this.grbAddTransaction.Controls.Add(this.lblAccount);
            this.grbAddTransaction.Controls.Add(this.btnAddTransaction);
            this.grbAddTransaction.Controls.Add(this.cmbAccountChoise);
            this.grbAddTransaction.Controls.Add(this.label3);
            this.grbAddTransaction.Controls.Add(this.lblUserTransaction);
            this.grbAddTransaction.Controls.Add(this.cmbChoiceUserForTransaction);
            this.grbAddTransaction.Controls.Add(this.lblCategoryTransaction);
            this.grbAddTransaction.Controls.Add(this.cmbChoiceCategoryTransaction);
            this.grbAddTransaction.Controls.Add(this.txtSumTransaction);
            this.grbAddTransaction.Controls.Add(this.lblSumTransaction);
            this.grbAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbAddTransaction.Location = new System.Drawing.Point(701, 33);
            this.grbAddTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.grbAddTransaction.Name = "grbAddTransaction";
            this.grbAddTransaction.Padding = new System.Windows.Forms.Padding(4);
            this.grbAddTransaction.Size = new System.Drawing.Size(309, 320);
            this.grbAddTransaction.TabIndex = 2;
            this.grbAddTransaction.TabStop = false;
            this.grbAddTransaction.Text = "Добавление транзакции";
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTransaction.BackColor = System.Drawing.Color.Thistle;
            this.btnDeleteTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTransaction.Location = new System.Drawing.Point(11, 283);
            this.btnDeleteTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(114, 29);
            this.btnDeleteTransaction.TabIndex = 18;
            this.btnDeleteTransaction.Text = "Удалить";
            this.btnDeleteTransaction.UseVisualStyleBackColor = false;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDate.Location = new System.Drawing.Point(127, 243);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(170, 23);
            this.dtpDate.TabIndex = 17;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(8, 249);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Дата";
            // 
            // cmbTypeTransaction
            // 
            this.cmbTypeTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTypeTransaction.FormattingEnabled = true;
            this.cmbTypeTransaction.Items.AddRange(new object[] {
            "Доход",
            "Расход"});
            this.cmbTypeTransaction.Location = new System.Drawing.Point(127, 124);
            this.cmbTypeTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTypeTransaction.Name = "cmbTypeTransaction";
            this.cmbTypeTransaction.Size = new System.Drawing.Size(170, 24);
            this.cmbTypeTransaction.TabIndex = 15;
            this.cmbTypeTransaction.SelectedIndexChanged += new System.EventHandler(this.cmbTypeTransaction_SelectedIndexChanged);
            // 
            // lblCType
            // 
            this.lblCType.AutoSize = true;
            this.lblCType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCType.Location = new System.Drawing.Point(8, 131);
            this.lblCType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCType.Name = "lblCType";
            this.lblCType.Size = new System.Drawing.Size(114, 17);
            this.lblCType.TabIndex = 14;
            this.lblCType.Text = "Тип транзакции";
            // 
            // txtCommentForTransaction
            // 
            this.txtCommentForTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCommentForTransaction.Location = new System.Drawing.Point(127, 187);
            this.txtCommentForTransaction.Multiline = true;
            this.txtCommentForTransaction.Name = "txtCommentForTransaction";
            this.txtCommentForTransaction.Size = new System.Drawing.Size(170, 50);
            this.txtCommentForTransaction.TabIndex = 12;
            // 
            // lblCommentTransaction
            // 
            this.lblCommentTransaction.AutoSize = true;
            this.lblCommentTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCommentTransaction.Location = new System.Drawing.Point(8, 190);
            this.lblCommentTransaction.Name = "lblCommentTransaction";
            this.lblCommentTransaction.Size = new System.Drawing.Size(98, 17);
            this.lblCommentTransaction.TabIndex = 11;
            this.lblCommentTransaction.Text = "Комментарий";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccount.Location = new System.Drawing.Point(8, 99);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(40, 17);
            this.lblAccount.TabIndex = 9;
            this.lblAccount.Text = "Счёт";
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTransaction.BackColor = System.Drawing.Color.Thistle;
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTransaction.Location = new System.Drawing.Point(183, 283);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(114, 29);
            this.btnAddTransaction.TabIndex = 6;
            this.btnAddTransaction.Text = "Добавить";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // cmbAccountChoise
            // 
            this.cmbAccountChoise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccountChoise.FormattingEnabled = true;
            this.cmbAccountChoise.Location = new System.Drawing.Point(127, 92);
            this.cmbAccountChoise.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccountChoise.Name = "cmbAccountChoise";
            this.cmbAccountChoise.Size = new System.Drawing.Size(170, 24);
            this.cmbAccountChoise.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(253, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "руб.";
            // 
            // lblUserTransaction
            // 
            this.lblUserTransaction.AutoSize = true;
            this.lblUserTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserTransaction.Location = new System.Drawing.Point(8, 67);
            this.lblUserTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserTransaction.Name = "lblUserTransaction";
            this.lblUserTransaction.Size = new System.Drawing.Size(101, 17);
            this.lblUserTransaction.TabIndex = 5;
            this.lblUserTransaction.Text = "Пользователь";
            // 
            // cmbChoiceUserForTransaction
            // 
            this.cmbChoiceUserForTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoiceUserForTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChoiceUserForTransaction.FormattingEnabled = true;
            this.cmbChoiceUserForTransaction.Location = new System.Drawing.Point(127, 60);
            this.cmbChoiceUserForTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChoiceUserForTransaction.Name = "cmbChoiceUserForTransaction";
            this.cmbChoiceUserForTransaction.Size = new System.Drawing.Size(170, 24);
            this.cmbChoiceUserForTransaction.TabIndex = 4;
            // 
            // lblCategoryTransaction
            // 
            this.lblCategoryTransaction.AutoSize = true;
            this.lblCategoryTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoryTransaction.Location = new System.Drawing.Point(8, 163);
            this.lblCategoryTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryTransaction.Name = "lblCategoryTransaction";
            this.lblCategoryTransaction.Size = new System.Drawing.Size(77, 17);
            this.lblCategoryTransaction.TabIndex = 3;
            this.lblCategoryTransaction.Text = "Категория";
            // 
            // cmbChoiceCategoryTransaction
            // 
            this.cmbChoiceCategoryTransaction.DisplayMember = "Name";
            this.cmbChoiceCategoryTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoiceCategoryTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChoiceCategoryTransaction.FormattingEnabled = true;
            this.cmbChoiceCategoryTransaction.Location = new System.Drawing.Point(127, 156);
            this.cmbChoiceCategoryTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChoiceCategoryTransaction.Name = "cmbChoiceCategoryTransaction";
            this.cmbChoiceCategoryTransaction.Size = new System.Drawing.Size(170, 24);
            this.cmbChoiceCategoryTransaction.TabIndex = 2;
            // 
            // txtSumTransaction
            // 
            this.txtSumTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumTransaction.Location = new System.Drawing.Point(127, 29);
            this.txtSumTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumTransaction.Name = "txtSumTransaction";
            this.txtSumTransaction.Size = new System.Drawing.Size(121, 23);
            this.txtSumTransaction.TabIndex = 1;
            // 
            // lblSumTransaction
            // 
            this.lblSumTransaction.AutoSize = true;
            this.lblSumTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumTransaction.Location = new System.Drawing.Point(8, 35);
            this.lblSumTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumTransaction.Name = "lblSumTransaction";
            this.lblSumTransaction.Size = new System.Drawing.Size(50, 17);
            this.lblSumTransaction.TabIndex = 0;
            this.lblSumTransaction.Text = "Сумма";
            // 
            // grbFilters
            // 
            this.grbFilters.Controls.Add(this.mtbFilterSumMax);
            this.grbFilters.Controls.Add(this.mtbFilterSumMin);
            this.grbFilters.Controls.Add(this.label9);
            this.grbFilters.Controls.Add(this.lblFilterSum);
            this.grbFilters.Controls.Add(this.label7);
            this.grbFilters.Controls.Add(this.dtpEndFilter);
            this.grbFilters.Controls.Add(this.dtpBeginFilter);
            this.grbFilters.Controls.Add(this.label6);
            this.grbFilters.Controls.Add(this.lblCTypeTrans);
            this.grbFilters.Controls.Add(this.cmbTypeTransactionFilter);
            this.grbFilters.Controls.Add(this.btnApplyFilters);
            this.grbFilters.Controls.Add(this.lblCategoryTransFilters);
            this.grbFilters.Controls.Add(this.cmbCategoryTransactionsFilters);
            this.grbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbFilters.Location = new System.Drawing.Point(701, 379);
            this.grbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.grbFilters.Name = "grbFilters";
            this.grbFilters.Padding = new System.Windows.Forms.Padding(4);
            this.grbFilters.Size = new System.Drawing.Size(309, 193);
            this.grbFilters.TabIndex = 7;
            this.grbFilters.TabStop = false;
            this.grbFilters.Text = "Фильтры";
            // 
            // mtbFilterSumMax
            // 
            this.mtbFilterSumMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbFilterSumMax.Location = new System.Drawing.Point(227, 124);
            this.mtbFilterSumMax.Mask = "9999999.99";
            this.mtbFilterSumMax.Name = "mtbFilterSumMax";
            this.mtbFilterSumMax.Size = new System.Drawing.Size(70, 23);
            this.mtbFilterSumMax.TabIndex = 27;
            this.mtbFilterSumMax.ValidatingType = typeof(int);
            // 
            // mtbFilterSumMin
            // 
            this.mtbFilterSumMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbFilterSumMin.Location = new System.Drawing.Point(127, 124);
            this.mtbFilterSumMin.Mask = "0000000.00";
            this.mtbFilterSumMin.Name = "mtbFilterSumMin";
            this.mtbFilterSumMin.Size = new System.Drawing.Size(72, 23);
            this.mtbFilterSumMin.TabIndex = 26;
            this.mtbFilterSumMin.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(206, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "-";
            // 
            // lblFilterSum
            // 
            this.lblFilterSum.AutoSize = true;
            this.lblFilterSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterSum.Location = new System.Drawing.Point(8, 127);
            this.lblFilterSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterSum.Name = "lblFilterSum";
            this.lblFilterSum.Size = new System.Drawing.Size(50, 17);
            this.lblFilterSum.TabIndex = 22;
            this.lblFilterSum.Text = "Сумма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(166, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "-";
            // 
            // dtpEndFilter
            // 
            this.dtpEndFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEndFilter.Location = new System.Drawing.Point(189, 27);
            this.dtpEndFilter.Name = "dtpEndFilter";
            this.dtpEndFilter.Size = new System.Drawing.Size(108, 23);
            this.dtpEndFilter.TabIndex = 20;
            // 
            // dtpBeginFilter
            // 
            this.dtpBeginFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBeginFilter.Location = new System.Drawing.Point(54, 27);
            this.dtpBeginFilter.Name = "dtpBeginFilter";
            this.dtpBeginFilter.Size = new System.Drawing.Size(108, 23);
            this.dtpBeginFilter.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дата";
            // 
            // lblCTypeTrans
            // 
            this.lblCTypeTrans.AutoSize = true;
            this.lblCTypeTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCTypeTrans.Location = new System.Drawing.Point(8, 64);
            this.lblCTypeTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTypeTrans.Name = "lblCTypeTrans";
            this.lblCTypeTrans.Size = new System.Drawing.Size(114, 17);
            this.lblCTypeTrans.TabIndex = 10;
            this.lblCTypeTrans.Text = "Тип транзакции";
            // 
            // cmbTypeTransactionFilter
            // 
            this.cmbTypeTransactionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeTransactionFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTypeTransactionFilter.FormattingEnabled = true;
            this.cmbTypeTransactionFilter.Items.AddRange(new object[] {
            "Доход",
            "Расход",
            "Все"});
            this.cmbTypeTransactionFilter.Location = new System.Drawing.Point(127, 61);
            this.cmbTypeTransactionFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTypeTransactionFilter.Name = "cmbTypeTransactionFilter";
            this.cmbTypeTransactionFilter.Size = new System.Drawing.Size(170, 24);
            this.cmbTypeTransactionFilter.TabIndex = 9;
            this.cmbTypeTransactionFilter.SelectedIndexChanged += new System.EventHandler(this.cmbTypeTransactionFilter_SelectedIndexChanged);
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyFilters.BackColor = System.Drawing.Color.Thistle;
            this.btnApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyFilters.Location = new System.Drawing.Point(74, 160);
            this.btnApplyFilters.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(161, 29);
            this.btnApplyFilters.TabIndex = 8;
            this.btnApplyFilters.Text = "Применить";
            this.btnApplyFilters.UseVisualStyleBackColor = false;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // lblCategoryTransFilters
            // 
            this.lblCategoryTransFilters.AutoSize = true;
            this.lblCategoryTransFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoryTransFilters.Location = new System.Drawing.Point(8, 96);
            this.lblCategoryTransFilters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryTransFilters.Name = "lblCategoryTransFilters";
            this.lblCategoryTransFilters.Size = new System.Drawing.Size(77, 17);
            this.lblCategoryTransFilters.TabIndex = 3;
            this.lblCategoryTransFilters.Text = "Категория";
            // 
            // cmbCategoryTransactionsFilters
            // 
            this.cmbCategoryTransactionsFilters.DisplayMember = "Name";
            this.cmbCategoryTransactionsFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryTransactionsFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCategoryTransactionsFilters.FormattingEnabled = true;
            this.cmbCategoryTransactionsFilters.Location = new System.Drawing.Point(127, 93);
            this.cmbCategoryTransactionsFilters.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoryTransactionsFilters.Name = "cmbCategoryTransactionsFilters";
            this.cmbCategoryTransactionsFilters.Size = new System.Drawing.Size(170, 24);
            this.cmbCategoryTransactionsFilters.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Thistle;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(799, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(115, 23);
            this.txtUserName.TabIndex = 10;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Thistle;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(698, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(105, 17);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Пользователь:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblAccountForBalanse
            // 
            this.lblAccountForBalanse.AutoSize = true;
            this.lblAccountForBalanse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccountForBalanse.Location = new System.Drawing.Point(7, 29);
            this.lblAccountForBalanse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountForBalanse.Name = "lblAccountForBalanse";
            this.lblAccountForBalanse.Size = new System.Drawing.Size(40, 17);
            this.lblAccountForBalanse.TabIndex = 19;
            this.lblAccountForBalanse.Text = "Счет";
            // 
            // grbBalance
            // 
            this.grbBalance.Controls.Add(this.label2);
            this.grbBalance.Controls.Add(this.txtBalance);
            this.grbBalance.Controls.Add(this.cmbAccuntChoiseForBalance);
            this.grbBalance.Controls.Add(this.lblAccountForBalanse);
            this.grbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbBalance.Location = new System.Drawing.Point(15, 511);
            this.grbBalance.Name = "grbBalance";
            this.grbBalance.Size = new System.Drawing.Size(419, 61);
            this.grbBalance.TabIndex = 20;
            this.grbBalance.TabStop = false;
            this.grbBalance.Text = "Баланс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(370, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "руб.";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBalance.Location = new System.Drawing.Point(232, 23);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(131, 23);
            this.txtBalance.TabIndex = 20;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbAccuntChoiseForBalance
            // 
            this.cmbAccuntChoiseForBalance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccuntChoiseForBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccuntChoiseForBalance.FormattingEnabled = true;
            this.cmbAccuntChoiseForBalance.Location = new System.Drawing.Point(62, 23);
            this.cmbAccuntChoiseForBalance.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccuntChoiseForBalance.Name = "cmbAccuntChoiseForBalance";
            this.cmbAccuntChoiseForBalance.Size = new System.Drawing.Size(148, 24);
            this.cmbAccuntChoiseForBalance.TabIndex = 19;
            this.cmbAccuntChoiseForBalance.SelectedIndexChanged += new System.EventHandler(this.cmbAccuntChoiseForBalance_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Лента транзакций";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1019, 586);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvListTransactions);
            this.Controls.Add(this.grbBalance);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.grbFilters);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.grbAddTransaction);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Финансовый помощник";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransactions)).EndInit();
            this.grbAddTransaction.ResumeLayout(false);
            this.grbAddTransaction.PerformLayout();
            this.grbFilters.ResumeLayout(false);
            this.grbFilters.PerformLayout();
            this.grbBalance.ResumeLayout(false);
            this.grbBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnloadingTransactionListInExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnalyticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem AboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvListTransactions;
        private System.Windows.Forms.GroupBox grbAddTransaction;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label lblUserTransaction;
        private System.Windows.Forms.ComboBox cmbChoiceUserForTransaction;
        private System.Windows.Forms.Label lblCategoryTransaction;
        private System.Windows.Forms.ComboBox cmbChoiceCategoryTransaction;
        private System.Windows.Forms.TextBox txtSumTransaction;
        private System.Windows.Forms.Label lblSumTransaction;
        private System.Windows.Forms.GroupBox grbFilters;
        private System.Windows.Forms.Label lblCategoryTransFilters;
        private System.Windows.Forms.ComboBox cmbCategoryTransactionsFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cmbAccountChoise;
        private System.Windows.Forms.TextBox txtCommentForTransaction;
        private System.Windows.Forms.Label lblCommentTransaction;
        private System.Windows.Forms.ToolStripMenuItem AccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriesToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbTypeTransaction;
        private System.Windows.Forms.Label lblCType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionID;
        private System.Windows.Forms.Label lblAccountForBalanse;
        private System.Windows.Forms.GroupBox grbBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ComboBox cmbAccuntChoiseForBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFilterSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEndFilter;
        private System.Windows.Forms.DateTimePicker dtpBeginFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCTypeTrans;
        private System.Windows.Forms.ComboBox cmbTypeTransactionFilter;
        private System.Windows.Forms.MaskedTextBox mtbFilterSumMax;
        private System.Windows.Forms.MaskedTextBox mtbFilterSumMin;
    }
}