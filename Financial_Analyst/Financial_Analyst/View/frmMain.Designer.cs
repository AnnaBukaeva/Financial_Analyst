
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnloadingTransactionListInExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalyticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PieChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.прочееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTransactionFeed = new System.Windows.Forms.GroupBox();
            this.dgvListTransactions = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAddTransaction = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbTypeTransaction = new System.Windows.Forms.ComboBox();
            this.lblCType = new System.Windows.Forms.Label();
            this.txtCommentForTransaction = new System.Windows.Forms.TextBox();
            this.lblCommentTransaction = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cmbAccountChoise = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.lblUserTransaction = new System.Windows.Forms.Label();
            this.cmbChoiceUserForTransaction = new System.Windows.Forms.ComboBox();
            this.lblCategoryTransaction = new System.Windows.Forms.Label();
            this.cmbChoiceCategoryTransaction = new System.Windows.Forms.ComboBox();
            this.txtSumTransaction = new System.Windows.Forms.TextBox();
            this.lblSumTransaction = new System.Windows.Forms.Label();
            this.grbFilters = new System.Windows.Forms.GroupBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCategoryTransFilters = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbTransactionFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransactions)).BeginInit();
            this.grbAddTransaction.SuspendLayout();
            this.grbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.PieChartToolStripMenuItem,
            this.toolStripMenuItem3});
            this.AnalyticsToolStripMenuItem.Name = "AnalyticsToolStripMenuItem";
            this.AnalyticsToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.AnalyticsToolStripMenuItem.Text = "Аналитика";
            // 
            // PieChartToolStripMenuItem
            // 
            this.PieChartToolStripMenuItem.Name = "PieChartToolStripMenuItem";
            this.PieChartToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.PieChartToolStripMenuItem.Text = "Круговая диаграмма";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(228, 26);
            this.toolStripMenuItem3.Text = "???";
            // 
            // прочееToolStripMenuItem
            // 
            this.прочееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.прочееToolStripMenuItem.Name = "прочееToolStripMenuItem";
            this.прочееToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.прочееToolStripMenuItem.Text = "Прочее";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // grbTransactionFeed
            // 
            this.grbTransactionFeed.Controls.Add(this.dgvListTransactions);
            this.grbTransactionFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbTransactionFeed.Location = new System.Drawing.Point(11, 33);
            this.grbTransactionFeed.Margin = new System.Windows.Forms.Padding(4);
            this.grbTransactionFeed.Name = "grbTransactionFeed";
            this.grbTransactionFeed.Padding = new System.Windows.Forms.Padding(4);
            this.grbTransactionFeed.Size = new System.Drawing.Size(671, 548);
            this.grbTransactionFeed.TabIndex = 1;
            this.grbTransactionFeed.TabStop = false;
            this.grbTransactionFeed.Text = "Лента транзакций";
            // 
            // dgvListTransactions
            // 
            this.dgvListTransactions.AllowUserToAddRows = false;
            this.dgvListTransactions.AllowUserToDeleteRows = false;
            this.dgvListTransactions.AllowUserToOrderColumns = true;
            this.dgvListTransactions.AllowUserToResizeRows = false;
            this.dgvListTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colSum,
            this.colCategory,
            this.colUser,
            this.clnAccount,
            this.clmComment});
            this.dgvListTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListTransactions.Location = new System.Drawing.Point(4, 20);
            this.dgvListTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListTransactions.Name = "dgvListTransactions";
            this.dgvListTransactions.ReadOnly = true;
            this.dgvListTransactions.RowHeadersVisible = false;
            this.dgvListTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTransactions.Size = new System.Drawing.Size(663, 524);
            this.dgvListTransactions.TabIndex = 0;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.colDate.FillWeight = 80F;
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 80;
            // 
            // colSum
            // 
            this.colSum.DataPropertyName = "PaymentSum";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSum.DefaultCellStyle = dataGridViewCellStyle14;
            this.colSum.HeaderText = "Сумма";
            this.colSum.Name = "colSum";
            this.colSum.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.DataPropertyName = "Category";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCategory.DefaultCellStyle = dataGridViewCellStyle15;
            this.colCategory.FillWeight = 120F;
            this.colCategory.HeaderText = "Категория";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 120;
            // 
            // colUser
            // 
            this.colUser.DataPropertyName = "User";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUser.DefaultCellStyle = dataGridViewCellStyle16;
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
            // grbAddTransaction
            // 
            this.grbAddTransaction.Controls.Add(this.dtpDate);
            this.grbAddTransaction.Controls.Add(this.lblDate);
            this.grbAddTransaction.Controls.Add(this.cmbTypeTransaction);
            this.grbAddTransaction.Controls.Add(this.lblCType);
            this.grbAddTransaction.Controls.Add(this.txtCommentForTransaction);
            this.grbAddTransaction.Controls.Add(this.lblCommentTransaction);
            this.grbAddTransaction.Controls.Add(this.lblAccount);
            this.grbAddTransaction.Controls.Add(this.cmbAccountChoise);
            this.grbAddTransaction.Controls.Add(this.label3);
            this.grbAddTransaction.Controls.Add(this.btnAddTransaction);
            this.grbAddTransaction.Controls.Add(this.lblUserTransaction);
            this.grbAddTransaction.Controls.Add(this.cmbChoiceUserForTransaction);
            this.grbAddTransaction.Controls.Add(this.lblCategoryTransaction);
            this.grbAddTransaction.Controls.Add(this.cmbChoiceCategoryTransaction);
            this.grbAddTransaction.Controls.Add(this.txtSumTransaction);
            this.grbAddTransaction.Controls.Add(this.lblSumTransaction);
            this.grbAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbAddTransaction.Location = new System.Drawing.Point(701, 33);
            this.grbAddTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.grbAddTransaction.Name = "grbAddTransaction";
            this.grbAddTransaction.Padding = new System.Windows.Forms.Padding(4);
            this.grbAddTransaction.Size = new System.Drawing.Size(309, 314);
            this.grbAddTransaction.TabIndex = 2;
            this.grbAddTransaction.TabStop = false;
            this.grbAddTransaction.Text = "Добавление транзакции";
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
            // btnAddTransaction
            // 
            this.btnAddTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTransaction.Location = new System.Drawing.Point(8, 277);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(114, 29);
            this.btnAddTransaction.TabIndex = 6;
            this.btnAddTransaction.Text = "Добавить";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
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
            this.grbFilters.Controls.Add(this.btnApplyFilters);
            this.grbFilters.Controls.Add(this.label1);
            this.grbFilters.Controls.Add(this.comboBox1);
            this.grbFilters.Controls.Add(this.lblCategoryTransFilters);
            this.grbFilters.Controls.Add(this.comboBox2);
            this.grbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbFilters.Location = new System.Drawing.Point(701, 452);
            this.grbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.grbFilters.Name = "grbFilters";
            this.grbFilters.Padding = new System.Windows.Forms.Padding(4);
            this.grbFilters.Size = new System.Drawing.Size(309, 125);
            this.grbFilters.TabIndex = 7;
            this.grbFilters.TabStop = false;
            this.grbFilters.Text = "Фильтры";
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyFilters.Location = new System.Drawing.Point(72, 88);
            this.btnApplyFilters.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(161, 29);
            this.btnApplyFilters.TabIndex = 8;
            this.btnApplyFilters.Text = "Применить";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пользователь";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 56);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // lblCategoryTransFilters
            // 
            this.lblCategoryTransFilters.AutoSize = true;
            this.lblCategoryTransFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoryTransFilters.Location = new System.Drawing.Point(8, 31);
            this.lblCategoryTransFilters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryTransFilters.Name = "lblCategoryTransFilters";
            this.lblCategoryTransFilters.Size = new System.Drawing.Size(77, 17);
            this.lblCategoryTransFilters.TabIndex = 3;
            this.lblCategoryTransFilters.Text = "Категория";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(127, 24);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(799, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(118, 23);
            this.txtUserName.TabIndex = 10;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(698, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(105, 17);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Пользователь:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1019, 586);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.grbFilters);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.grbAddTransaction);
            this.Controls.Add(this.grbTransactionFeed);
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
            this.grbTransactionFeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransactions)).EndInit();
            this.grbAddTransaction.ResumeLayout(false);
            this.grbAddTransaction.PerformLayout();
            this.grbFilters.ResumeLayout(false);
            this.grbFilters.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem PieChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbTransactionFeed;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCategoryTransFilters;
        private System.Windows.Forms.ComboBox comboBox2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComment;
    }
}