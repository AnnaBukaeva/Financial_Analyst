
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пересозданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТранзакциямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.круговаяДиаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.прочееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTransactionFeed = new System.Windows.Forms.GroupBox();
            this.dgvListTransactions = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFastAddExpenses = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAccountChoise = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddFastAddExpenses = new System.Windows.Forms.Button();
            this.lblUserFastAddExpenses = new System.Windows.Forms.Label();
            this.cmbChoiceUserFastAddExpenses = new System.Windows.Forms.ComboBox();
            this.lblCategoryFastAddExpenses = new System.Windows.Forms.Label();
            this.cmbChoiceCategoryFastAddExpenses = new System.Windows.Forms.ComboBox();
            this.txtSumFastAddExpenses = new System.Windows.Forms.TextBox();
            this.lblSumFastAddExpenses = new System.Windows.Forms.Label();
            this.grbFilters = new System.Windows.Forms.GroupBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.saveFileDialogUnloadingInExcel = new System.Windows.Forms.SaveFileDialog();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbTransactionFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransactions)).BeginInit();
            this.grbFastAddExpenses.SuspendLayout();
            this.grbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.работаСТранзакциямиToolStripMenuItem,
            this.аналитикаToolStripMenuItem,
            this.прочееToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(968, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выгрузкаВExcelToolStripMenuItem,
            this.пересозданиеToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка списка транзакций в Excel";
            // 
            // пересозданиеToolStripMenuItem
            // 
            this.пересозданиеToolStripMenuItem.Name = "пересозданиеToolStripMenuItem";
            this.пересозданиеToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.пересозданиеToolStripMenuItem.Text = "Пересоздать БД";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(333, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.счетаToolStripMenuItem,
            this.категорииToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // счетаToolStripMenuItem
            // 
            this.счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            this.счетаToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.счетаToolStripMenuItem.Text = "Счета";
            this.счетаToolStripMenuItem.Click += new System.EventHandler(this.счетаToolStripMenuItem_Click);
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.категорииToolStripMenuItem.Text = "Категории";
            this.категорииToolStripMenuItem.Click += new System.EventHandler(this.AddCategoriesToolStripMenuItem_Click);
            // 
            // работаСТранзакциямиToolStripMenuItem
            // 
            this.работаСТранзакциямиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.работаСТранзакциямиToolStripMenuItem.Name = "работаСТранзакциямиToolStripMenuItem";
            this.работаСТранзакциямиToolStripMenuItem.Size = new System.Drawing.Size(190, 25);
            this.работаСТранзакциямиToolStripMenuItem.Text = "Работа с транзакциями";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить ";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddTransactionToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.EditTransactionToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // аналитикаToolStripMenuItem
            // 
            this.аналитикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.круговаяДиаграммаToolStripMenuItem,
            this.toolStripMenuItem3});
            this.аналитикаToolStripMenuItem.Name = "аналитикаToolStripMenuItem";
            this.аналитикаToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.аналитикаToolStripMenuItem.Text = "Аналитика";
            // 
            // круговаяДиаграммаToolStripMenuItem
            // 
            this.круговаяДиаграммаToolStripMenuItem.Name = "круговаяДиаграммаToolStripMenuItem";
            this.круговаяДиаграммаToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.круговаяДиаграммаToolStripMenuItem.Text = "Круговая диаграмма";
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
            this.grbTransactionFeed.Location = new System.Drawing.Point(16, 33);
            this.grbTransactionFeed.Margin = new System.Windows.Forms.Padding(4);
            this.grbTransactionFeed.Name = "grbTransactionFeed";
            this.grbTransactionFeed.Padding = new System.Windows.Forms.Padding(4);
            this.grbTransactionFeed.Size = new System.Drawing.Size(613, 485);
            this.grbTransactionFeed.TabIndex = 1;
            this.grbTransactionFeed.TabStop = false;
            this.grbTransactionFeed.Text = "Лента транзакций";
            // 
            // dgvListTransactions
            // 
            this.dgvListTransactions.AllowUserToOrderColumns = true;
            this.dgvListTransactions.AllowUserToResizeRows = false;
            this.dgvListTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colSum,
            this.colCategory,
            this.colUser,
            this.clmComment});
            this.dgvListTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListTransactions.Location = new System.Drawing.Point(4, 20);
            this.dgvListTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListTransactions.Name = "dgvListTransactions";
            this.dgvListTransactions.ReadOnly = true;
            this.dgvListTransactions.RowHeadersVisible = false;
            this.dgvListTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTransactions.Size = new System.Drawing.Size(605, 461);
            this.dgvListTransactions.TabIndex = 0;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
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
            this.colCategory.HeaderText = "Категория";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 150;
            // 
            // colUser
            // 
            this.colUser.DataPropertyName = "User";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUser.DefaultCellStyle = dataGridViewCellStyle4;
            this.colUser.FillWeight = 150F;
            this.colUser.HeaderText = "Пользователь";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            this.colUser.Width = 150;
            // 
            // clmComment
            // 
            this.clmComment.DataPropertyName = "Comment";
            this.clmComment.HeaderText = "Комментарий";
            this.clmComment.Name = "clmComment";
            this.clmComment.ReadOnly = true;
            // 
            // grbFastAddExpenses
            // 
            this.grbFastAddExpenses.Controls.Add(this.label5);
            this.grbFastAddExpenses.Controls.Add(this.cmbAccountChoise);
            this.grbFastAddExpenses.Controls.Add(this.label3);
            this.grbFastAddExpenses.Controls.Add(this.btnAddFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.lblUserFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.cmbChoiceUserFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.lblCategoryFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.cmbChoiceCategoryFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.txtSumFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.lblSumFastAddExpenses);
            this.grbFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbFastAddExpenses.Location = new System.Drawing.Point(655, 40);
            this.grbFastAddExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.grbFastAddExpenses.Name = "grbFastAddExpenses";
            this.grbFastAddExpenses.Padding = new System.Windows.Forms.Padding(4);
            this.grbFastAddExpenses.Size = new System.Drawing.Size(298, 229);
            this.grbFastAddExpenses.TabIndex = 2;
            this.grbFastAddExpenses.TabStop = false;
            this.grbFastAddExpenses.Text = "Быстрое добавление транзакции";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Счёт";
            // 
            // cmbAccountChoise
            // 
            this.cmbAccountChoise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccountChoise.FormattingEnabled = true;
            this.cmbAccountChoise.Location = new System.Drawing.Point(118, 131);
            this.cmbAccountChoise.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccountChoise.Name = "cmbAccountChoise";
            this.cmbAccountChoise.Size = new System.Drawing.Size(164, 24);
            this.cmbAccountChoise.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(247, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "руб.";
            // 
            // btnAddFastAddExpenses
            // 
            this.btnAddFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddFastAddExpenses.Location = new System.Drawing.Point(78, 192);
            this.btnAddFastAddExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFastAddExpenses.Name = "btnAddFastAddExpenses";
            this.btnAddFastAddExpenses.Size = new System.Drawing.Size(161, 29);
            this.btnAddFastAddExpenses.TabIndex = 6;
            this.btnAddFastAddExpenses.Text = "Добавить";
            this.btnAddFastAddExpenses.UseVisualStyleBackColor = true;
            this.btnAddFastAddExpenses.Click += new System.EventHandler(this.btnAddFastAddExpenses_Click);
            // 
            // lblUserFastAddExpenses
            // 
            this.lblUserFastAddExpenses.AutoSize = true;
            this.lblUserFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserFastAddExpenses.Location = new System.Drawing.Point(12, 74);
            this.lblUserFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserFastAddExpenses.Name = "lblUserFastAddExpenses";
            this.lblUserFastAddExpenses.Size = new System.Drawing.Size(101, 17);
            this.lblUserFastAddExpenses.TabIndex = 5;
            this.lblUserFastAddExpenses.Text = "Пользователь";
            // 
            // cmbChoiceUserFastAddExpenses
            // 
            this.cmbChoiceUserFastAddExpenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoiceUserFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChoiceUserFastAddExpenses.FormattingEnabled = true;
            this.cmbChoiceUserFastAddExpenses.Location = new System.Drawing.Point(117, 67);
            this.cmbChoiceUserFastAddExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChoiceUserFastAddExpenses.Name = "cmbChoiceUserFastAddExpenses";
            this.cmbChoiceUserFastAddExpenses.Size = new System.Drawing.Size(164, 24);
            this.cmbChoiceUserFastAddExpenses.TabIndex = 4;
            // 
            // lblCategoryFastAddExpenses
            // 
            this.lblCategoryFastAddExpenses.AutoSize = true;
            this.lblCategoryFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoryFastAddExpenses.Location = new System.Drawing.Point(11, 106);
            this.lblCategoryFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryFastAddExpenses.Name = "lblCategoryFastAddExpenses";
            this.lblCategoryFastAddExpenses.Size = new System.Drawing.Size(77, 17);
            this.lblCategoryFastAddExpenses.TabIndex = 3;
            this.lblCategoryFastAddExpenses.Text = "Категория";
            // 
            // cmbChoiceCategoryFastAddExpenses
            // 
            this.cmbChoiceCategoryFastAddExpenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoiceCategoryFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChoiceCategoryFastAddExpenses.FormattingEnabled = true;
            this.cmbChoiceCategoryFastAddExpenses.Location = new System.Drawing.Point(117, 99);
            this.cmbChoiceCategoryFastAddExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChoiceCategoryFastAddExpenses.Name = "cmbChoiceCategoryFastAddExpenses";
            this.cmbChoiceCategoryFastAddExpenses.Size = new System.Drawing.Size(164, 24);
            this.cmbChoiceCategoryFastAddExpenses.TabIndex = 2;
            // 
            // txtSumFastAddExpenses
            // 
            this.txtSumFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumFastAddExpenses.Location = new System.Drawing.Point(118, 29);
            this.txtSumFastAddExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumFastAddExpenses.Name = "txtSumFastAddExpenses";
            this.txtSumFastAddExpenses.Size = new System.Drawing.Size(121, 23);
            this.txtSumFastAddExpenses.TabIndex = 1;
            // 
            // lblSumFastAddExpenses
            // 
            this.lblSumFastAddExpenses.AutoSize = true;
            this.lblSumFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumFastAddExpenses.Location = new System.Drawing.Point(12, 32);
            this.lblSumFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumFastAddExpenses.Name = "lblSumFastAddExpenses";
            this.lblSumFastAddExpenses.Size = new System.Drawing.Size(50, 17);
            this.lblSumFastAddExpenses.TabIndex = 0;
            this.lblSumFastAddExpenses.Text = "Сумма";
            // 
            // grbFilters
            // 
            this.grbFilters.Controls.Add(this.btnApplyFilters);
            this.grbFilters.Controls.Add(this.label1);
            this.grbFilters.Controls.Add(this.comboBox1);
            this.grbFilters.Controls.Add(this.label2);
            this.grbFilters.Controls.Add(this.comboBox2);
            this.grbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbFilters.Location = new System.Drawing.Point(655, 353);
            this.grbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.grbFilters.Name = "grbFilters";
            this.grbFilters.Padding = new System.Windows.Forms.Padding(4);
            this.grbFilters.Size = new System.Drawing.Size(298, 165);
            this.grbFilters.TabIndex = 7;
            this.grbFilters.TabStop = false;
            this.grbFilters.Text = "Фильтры";
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyFilters.Location = new System.Drawing.Point(59, 128);
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
            this.label1.Location = new System.Drawing.Point(8, 82);
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
            this.comboBox1.Location = new System.Drawing.Point(118, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(118, 32);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(776, 1);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(118, 23);
            this.txtUserName.TabIndex = 10;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(665, 4);
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
            this.ClientSize = new System.Drawing.Size(968, 533);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.grbFilters);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.grbFastAddExpenses);
            this.Controls.Add(this.grbTransactionFeed);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Финансовый аналитик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbTransactionFeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransactions)).EndInit();
            this.grbFastAddExpenses.ResumeLayout(false);
            this.grbFastAddExpenses.PerformLayout();
            this.grbFilters.ResumeLayout(false);
            this.grbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСТранзакциямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пересозданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналитикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem круговаяДиаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbTransactionFeed;
        private System.Windows.Forms.DataGridView dgvListTransactions;
        private System.Windows.Forms.GroupBox grbFastAddExpenses;
        private System.Windows.Forms.Button btnAddFastAddExpenses;
        private System.Windows.Forms.Label lblUserFastAddExpenses;
        private System.Windows.Forms.ComboBox cmbChoiceUserFastAddExpenses;
        private System.Windows.Forms.Label lblCategoryFastAddExpenses;
        private System.Windows.Forms.ComboBox cmbChoiceCategoryFastAddExpenses;
        private System.Windows.Forms.TextBox txtSumFastAddExpenses;
        private System.Windows.Forms.Label lblSumFastAddExpenses;
        private System.Windows.Forms.GroupBox grbFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.SaveFileDialog saveFileDialogUnloadingInExcel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAccountChoise;
    }
}