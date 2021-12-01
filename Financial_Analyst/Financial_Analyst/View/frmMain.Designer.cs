﻿
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТранзакциямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пересозданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.круговаяДиаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTransactionFeed = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbFastAddExpenses = new System.Windows.Forms.GroupBox();
            this.lblSumFastAddExpenses = new System.Windows.Forms.Label();
            this.txtSumFastAddExpenses = new System.Windows.Forms.TextBox();
            this.cmbChoiceCategoryFastAddExpenses = new System.Windows.Forms.ComboBox();
            this.lblCategoryFastAddExpenses = new System.Windows.Forms.Label();
            this.lblUserFastAddExpenses = new System.Windows.Forms.Label();
            this.cmbChoiceUserFastAddExpenses = new System.Windows.Forms.ComboBox();
            this.btnAddFastAddExpenses = new System.Windows.Forms.Button();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFilters = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.grbFastAddIncome = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddFastAddIncome = new System.Windows.Forms.Button();
            this.lblUserFastAddIncome = new System.Windows.Forms.Label();
            this.cmbChoiceUserFastAddIncome = new System.Windows.Forms.ComboBox();
            this.lblCategoryFastAddIncome = new System.Windows.Forms.Label();
            this.cmbCategoryFastAddIncome = new System.Windows.Forms.ComboBox();
            this.txtSumFastAddIncome = new System.Windows.Forms.TextBox();
            this.lblSumFastAddIncome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbTransactionFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbFastAddExpenses.SuspendLayout();
            this.grbFilters.SuspendLayout();
            this.grbFastAddIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.работаСТранзакциямиToolStripMenuItem,
            this.аналитикаToolStripMenuItem,
            this.прочееToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.счетаToolStripMenuItem,
            this.категорииToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // работаСТранзакциямиToolStripMenuItem
            // 
            this.работаСТранзакциямиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.переToolStripMenuItem});
            this.работаСТранзакциямиToolStripMenuItem.Name = "работаСТранзакциямиToolStripMenuItem";
            this.работаСТранзакциямиToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.работаСТранзакциямиToolStripMenuItem.Text = "Работа с транзакциями";
            // 
            // прочееToolStripMenuItem
            // 
            this.прочееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.прочееToolStripMenuItem.Name = "прочееToolStripMenuItem";
            this.прочееToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.прочееToolStripMenuItem.Text = "Прочее";
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка в Excel";
            // 
            // пересозданиеToolStripMenuItem
            // 
            this.пересозданиеToolStripMenuItem.Name = "пересозданиеToolStripMenuItem";
            this.пересозданиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пересозданиеToolStripMenuItem.Text = "Пересоздать БД";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // счетаToolStripMenuItem
            // 
            this.счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            this.счетаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.счетаToolStripMenuItem.Text = "Счета";
            this.счетаToolStripMenuItem.Click += new System.EventHandler(this.счетаToolStripMenuItem_Click);
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.категорииToolStripMenuItem.Text = "Категории";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить ";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // переToolStripMenuItem
            // 
            this.переToolStripMenuItem.Name = "переToolStripMenuItem";
            this.переToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.переToolStripMenuItem.Text = "Перевод между счетами";
            // 
            // аналитикаToolStripMenuItem
            // 
            this.аналитикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.круговаяДиаграммаToolStripMenuItem,
            this.toolStripMenuItem3});
            this.аналитикаToolStripMenuItem.Name = "аналитикаToolStripMenuItem";
            this.аналитикаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.аналитикаToolStripMenuItem.Text = "Аналитика";
            // 
            // круговаяДиаграммаToolStripMenuItem
            // 
            this.круговаяДиаграммаToolStripMenuItem.Name = "круговаяДиаграммаToolStripMenuItem";
            this.круговаяДиаграммаToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.круговаяДиаграммаToolStripMenuItem.Text = "Круговая диаграмма";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem3.Text = "???";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // grbTransactionFeed
            // 
            this.grbTransactionFeed.Controls.Add(this.dataGridView1);
            this.grbTransactionFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbTransactionFeed.Location = new System.Drawing.Point(16, 33);
            this.grbTransactionFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbTransactionFeed.Name = "grbTransactionFeed";
            this.grbTransactionFeed.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbTransactionFeed.Size = new System.Drawing.Size(679, 665);
            this.grbTransactionFeed.TabIndex = 1;
            this.grbTransactionFeed.TabStop = false;
            this.grbTransactionFeed.Text = "Лента транзакций";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colSum,
            this.colCategory,
            this.colUser});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 638);
            this.dataGridView1.TabIndex = 0;
            // 
            // grbFastAddExpenses
            // 
            this.grbFastAddExpenses.Controls.Add(this.label3);
            this.grbFastAddExpenses.Controls.Add(this.btnAddFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.lblUserFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.cmbChoiceUserFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.lblCategoryFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.cmbChoiceCategoryFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.txtSumFastAddExpenses);
            this.grbFastAddExpenses.Controls.Add(this.lblSumFastAddExpenses);
            this.grbFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbFastAddExpenses.Location = new System.Drawing.Point(709, 33);
            this.grbFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFastAddExpenses.Name = "grbFastAddExpenses";
            this.grbFastAddExpenses.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFastAddExpenses.Size = new System.Drawing.Size(373, 196);
            this.grbFastAddExpenses.TabIndex = 2;
            this.grbFastAddExpenses.TabStop = false;
            this.grbFastAddExpenses.Text = "Быстрое добавление расхода";
            // 
            // lblSumFastAddExpenses
            // 
            this.lblSumFastAddExpenses.AutoSize = true;
            this.lblSumFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumFastAddExpenses.Location = new System.Drawing.Point(9, 32);
            this.lblSumFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumFastAddExpenses.Name = "lblSumFastAddExpenses";
            this.lblSumFastAddExpenses.Size = new System.Drawing.Size(50, 17);
            this.lblSumFastAddExpenses.TabIndex = 0;
            this.lblSumFastAddExpenses.Text = "Сумма";
            // 
            // txtSumFastAddExpenses
            // 
            this.txtSumFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumFastAddExpenses.Location = new System.Drawing.Point(118, 29);
            this.txtSumFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSumFastAddExpenses.Name = "txtSumFastAddExpenses";
            this.txtSumFastAddExpenses.Size = new System.Drawing.Size(164, 23);
            this.txtSumFastAddExpenses.TabIndex = 1;
            // 
            // cmbChoiceCategoryFastAddExpenses
            // 
            this.cmbChoiceCategoryFastAddExpenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoiceCategoryFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChoiceCategoryFastAddExpenses.FormattingEnabled = true;
            this.cmbChoiceCategoryFastAddExpenses.Location = new System.Drawing.Point(118, 66);
            this.cmbChoiceCategoryFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbChoiceCategoryFastAddExpenses.Name = "cmbChoiceCategoryFastAddExpenses";
            this.cmbChoiceCategoryFastAddExpenses.Size = new System.Drawing.Size(229, 24);
            this.cmbChoiceCategoryFastAddExpenses.TabIndex = 2;
            // 
            // lblCategoryFastAddExpenses
            // 
            this.lblCategoryFastAddExpenses.AutoSize = true;
            this.lblCategoryFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoryFastAddExpenses.Location = new System.Drawing.Point(9, 69);
            this.lblCategoryFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryFastAddExpenses.Name = "lblCategoryFastAddExpenses";
            this.lblCategoryFastAddExpenses.Size = new System.Drawing.Size(77, 17);
            this.lblCategoryFastAddExpenses.TabIndex = 3;
            this.lblCategoryFastAddExpenses.Text = "Категория";
            // 
            // lblUserFastAddExpenses
            // 
            this.lblUserFastAddExpenses.AutoSize = true;
            this.lblUserFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserFastAddExpenses.Location = new System.Drawing.Point(9, 110);
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
            this.cmbChoiceUserFastAddExpenses.Location = new System.Drawing.Point(118, 107);
            this.cmbChoiceUserFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbChoiceUserFastAddExpenses.Name = "cmbChoiceUserFastAddExpenses";
            this.cmbChoiceUserFastAddExpenses.Size = new System.Drawing.Size(229, 24);
            this.cmbChoiceUserFastAddExpenses.TabIndex = 4;
            // 
            // btnAddFastAddExpenses
            // 
            this.btnAddFastAddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddFastAddExpenses.Location = new System.Drawing.Point(107, 150);
            this.btnAddFastAddExpenses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFastAddExpenses.Name = "btnAddFastAddExpenses";
            this.btnAddFastAddExpenses.Size = new System.Drawing.Size(161, 29);
            this.btnAddFastAddExpenses.TabIndex = 6;
            this.btnAddFastAddExpenses.Text = "Добавить";
            this.btnAddFastAddExpenses.UseVisualStyleBackColor = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            // 
            // colSum
            // 
            this.colSum.HeaderText = "Сумма";
            this.colSum.Name = "colSum";
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Категория";
            this.colCategory.Name = "colCategory";
            // 
            // colUser
            // 
            this.colUser.FillWeight = 150F;
            this.colUser.HeaderText = "Пользователь";
            this.colUser.Name = "colUser";
            this.colUser.Width = 150;
            // 
            // grbFilters
            // 
            this.grbFilters.Controls.Add(this.btnApplyFilters);
            this.grbFilters.Controls.Add(this.label1);
            this.grbFilters.Controls.Add(this.comboBox1);
            this.grbFilters.Controls.Add(this.label2);
            this.grbFilters.Controls.Add(this.comboBox2);
            this.grbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbFilters.Location = new System.Drawing.Point(703, 529);
            this.grbFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFilters.Name = "grbFilters";
            this.grbFilters.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFilters.Size = new System.Drawing.Size(373, 165);
            this.grbFilters.TabIndex = 7;
            this.grbFilters.TabStop = false;
            this.grbFilters.Text = "Фильтры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пользователь";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(118, 32);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(229, 26);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(290, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "руб.";
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyFilters.Location = new System.Drawing.Point(107, 122);
            this.btnApplyFilters.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(161, 29);
            this.btnApplyFilters.TabIndex = 8;
            this.btnApplyFilters.Text = "Применить";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // grbFastAddIncome
            // 
            this.grbFastAddIncome.Controls.Add(this.label4);
            this.grbFastAddIncome.Controls.Add(this.btnAddFastAddIncome);
            this.grbFastAddIncome.Controls.Add(this.lblUserFastAddIncome);
            this.grbFastAddIncome.Controls.Add(this.cmbChoiceUserFastAddIncome);
            this.grbFastAddIncome.Controls.Add(this.lblCategoryFastAddIncome);
            this.grbFastAddIncome.Controls.Add(this.cmbCategoryFastAddIncome);
            this.grbFastAddIncome.Controls.Add(this.txtSumFastAddIncome);
            this.grbFastAddIncome.Controls.Add(this.lblSumFastAddIncome);
            this.grbFastAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbFastAddIncome.Location = new System.Drawing.Point(709, 281);
            this.grbFastAddIncome.Margin = new System.Windows.Forms.Padding(4);
            this.grbFastAddIncome.Name = "grbFastAddIncome";
            this.grbFastAddIncome.Padding = new System.Windows.Forms.Padding(4);
            this.grbFastAddIncome.Size = new System.Drawing.Size(373, 196);
            this.grbFastAddIncome.TabIndex = 8;
            this.grbFastAddIncome.TabStop = false;
            this.grbFastAddIncome.Text = "Быстрое добавление дохода";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(290, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "руб.";
            // 
            // btnAddFastAddIncome
            // 
            this.btnAddFastAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddFastAddIncome.Location = new System.Drawing.Point(107, 150);
            this.btnAddFastAddIncome.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFastAddIncome.Name = "btnAddFastAddIncome";
            this.btnAddFastAddIncome.Size = new System.Drawing.Size(161, 29);
            this.btnAddFastAddIncome.TabIndex = 6;
            this.btnAddFastAddIncome.Text = "Добавить";
            this.btnAddFastAddIncome.UseVisualStyleBackColor = true;
            // 
            // lblUserFastAddIncome
            // 
            this.lblUserFastAddIncome.AutoSize = true;
            this.lblUserFastAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserFastAddIncome.Location = new System.Drawing.Point(9, 110);
            this.lblUserFastAddIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserFastAddIncome.Name = "lblUserFastAddIncome";
            this.lblUserFastAddIncome.Size = new System.Drawing.Size(101, 17);
            this.lblUserFastAddIncome.TabIndex = 5;
            this.lblUserFastAddIncome.Text = "Пользователь";
            // 
            // cmbChoiceUserFastAddIncome
            // 
            this.cmbChoiceUserFastAddIncome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoiceUserFastAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChoiceUserFastAddIncome.FormattingEnabled = true;
            this.cmbChoiceUserFastAddIncome.Location = new System.Drawing.Point(118, 107);
            this.cmbChoiceUserFastAddIncome.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChoiceUserFastAddIncome.Name = "cmbChoiceUserFastAddIncome";
            this.cmbChoiceUserFastAddIncome.Size = new System.Drawing.Size(229, 24);
            this.cmbChoiceUserFastAddIncome.TabIndex = 4;
            // 
            // lblCategoryFastAddIncome
            // 
            this.lblCategoryFastAddIncome.AutoSize = true;
            this.lblCategoryFastAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoryFastAddIncome.Location = new System.Drawing.Point(9, 69);
            this.lblCategoryFastAddIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryFastAddIncome.Name = "lblCategoryFastAddIncome";
            this.lblCategoryFastAddIncome.Size = new System.Drawing.Size(77, 17);
            this.lblCategoryFastAddIncome.TabIndex = 3;
            this.lblCategoryFastAddIncome.Text = "Категория";
            // 
            // cmbCategoryFastAddIncome
            // 
            this.cmbCategoryFastAddIncome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFastAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCategoryFastAddIncome.FormattingEnabled = true;
            this.cmbCategoryFastAddIncome.Location = new System.Drawing.Point(118, 66);
            this.cmbCategoryFastAddIncome.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoryFastAddIncome.Name = "cmbCategoryFastAddIncome";
            this.cmbCategoryFastAddIncome.Size = new System.Drawing.Size(229, 24);
            this.cmbCategoryFastAddIncome.TabIndex = 2;
            // 
            // txtSumFastAddIncome
            // 
            this.txtSumFastAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumFastAddIncome.Location = new System.Drawing.Point(118, 29);
            this.txtSumFastAddIncome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumFastAddIncome.Name = "txtSumFastAddIncome";
            this.txtSumFastAddIncome.Size = new System.Drawing.Size(164, 23);
            this.txtSumFastAddIncome.TabIndex = 1;
            // 
            // lblSumFastAddIncome
            // 
            this.lblSumFastAddIncome.AutoSize = true;
            this.lblSumFastAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumFastAddIncome.Location = new System.Drawing.Point(9, 32);
            this.lblSumFastAddIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumFastAddIncome.Name = "lblSumFastAddIncome";
            this.lblSumFastAddIncome.Size = new System.Drawing.Size(50, 17);
            this.lblSumFastAddIncome.TabIndex = 0;
            this.lblSumFastAddIncome.Text = "Сумма";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 715);
            this.Controls.Add(this.grbFastAddIncome);
            this.Controls.Add(this.grbFilters);
            this.Controls.Add(this.grbFastAddExpenses);
            this.Controls.Add(this.grbTransactionFeed);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Финансовый аналитик";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbTransactionFeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbFastAddExpenses.ResumeLayout(false);
            this.grbFastAddExpenses.PerformLayout();
            this.grbFilters.ResumeLayout(false);
            this.grbFilters.PerformLayout();
            this.grbFastAddIncome.ResumeLayout(false);
            this.grbFastAddIncome.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналитикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem круговаяДиаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbTransactionFeed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbFastAddExpenses;
        private System.Windows.Forms.Button btnAddFastAddExpenses;
        private System.Windows.Forms.Label lblUserFastAddExpenses;
        private System.Windows.Forms.ComboBox cmbChoiceUserFastAddExpenses;
        private System.Windows.Forms.Label lblCategoryFastAddExpenses;
        private System.Windows.Forms.ComboBox cmbChoiceCategoryFastAddExpenses;
        private System.Windows.Forms.TextBox txtSumFastAddExpenses;
        private System.Windows.Forms.Label lblSumFastAddExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.GroupBox grbFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.GroupBox grbFastAddIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddFastAddIncome;
        private System.Windows.Forms.Label lblUserFastAddIncome;
        private System.Windows.Forms.ComboBox cmbChoiceUserFastAddIncome;
        private System.Windows.Forms.Label lblCategoryFastAddIncome;
        private System.Windows.Forms.ComboBox cmbCategoryFastAddIncome;
        private System.Windows.Forms.TextBox txtSumFastAddIncome;
        private System.Windows.Forms.Label lblSumFastAddIncome;
    }
}