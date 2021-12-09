
namespace Financial_Analyst.View
{
    partial class frmCreatingCategories
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
            this.lblNameCategory = new System.Windows.Forms.Label();
            this.grbCreatingCategories = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtDiscriptionCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmpTypeTransaction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkCatecory = new System.Windows.Forms.Button();
            this.lblColorSelection = new System.Windows.Forms.Label();
            this.txtColorCategory = new System.Windows.Forms.TextBox();
            this.btnColorCategory = new System.Windows.Forms.Button();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.colorDialogCategory = new System.Windows.Forms.ColorDialog();
            this.dgvListCategories = new System.Windows.Forms.DataGridView();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDiscriptionCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCreatingCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoSize = true;
            this.lblNameCategory.Location = new System.Drawing.Point(6, 63);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(143, 17);
            this.lblNameCategory.TabIndex = 0;
            this.lblNameCategory.Text = "Название категории";
            // 
            // grbCreatingCategories
            // 
            this.grbCreatingCategories.Controls.Add(this.btnAddCategory);
            this.grbCreatingCategories.Controls.Add(this.txtDiscriptionCategory);
            this.grbCreatingCategories.Controls.Add(this.label2);
            this.grbCreatingCategories.Controls.Add(this.cmpTypeTransaction);
            this.grbCreatingCategories.Controls.Add(this.label1);
            this.grbCreatingCategories.Controls.Add(this.btnOkCatecory);
            this.grbCreatingCategories.Controls.Add(this.lblColorSelection);
            this.grbCreatingCategories.Controls.Add(this.txtColorCategory);
            this.grbCreatingCategories.Controls.Add(this.btnColorCategory);
            this.grbCreatingCategories.Controls.Add(this.txtNameCategory);
            this.grbCreatingCategories.Controls.Add(this.lblNameCategory);
            this.grbCreatingCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbCreatingCategories.Location = new System.Drawing.Point(446, 12);
            this.grbCreatingCategories.Name = "grbCreatingCategories";
            this.grbCreatingCategories.Size = new System.Drawing.Size(384, 264);
            this.grbCreatingCategories.TabIndex = 1;
            this.grbCreatingCategories.TabStop = false;
            this.grbCreatingCategories.Text = "Создание категории";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Thistle;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCategory.Location = new System.Drawing.Point(9, 222);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(100, 36);
            this.btnAddCategory.TabIndex = 10;
            this.btnAddCategory.Text = "Добавить";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtDiscriptionCategory
            // 
            this.txtDiscriptionCategory.Location = new System.Drawing.Point(153, 98);
            this.txtDiscriptionCategory.Multiline = true;
            this.txtDiscriptionCategory.Name = "txtDiscriptionCategory";
            this.txtDiscriptionCategory.Size = new System.Drawing.Size(224, 52);
            this.txtDiscriptionCategory.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Описание категории";
            // 
            // cmpTypeTransaction
            // 
            this.cmpTypeTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpTypeTransaction.FormattingEnabled = true;
            this.cmpTypeTransaction.Items.AddRange(new object[] {
            "Доход",
            "Расход"});
            this.cmpTypeTransaction.Location = new System.Drawing.Point(155, 25);
            this.cmpTypeTransaction.Name = "cmpTypeTransaction";
            this.cmpTypeTransaction.Size = new System.Drawing.Size(222, 24);
            this.cmpTypeTransaction.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип категории";
            // 
            // btnOkCatecory
            // 
            this.btnOkCatecory.BackColor = System.Drawing.Color.Thistle;
            this.btnOkCatecory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOkCatecory.Location = new System.Drawing.Point(292, 220);
            this.btnOkCatecory.Name = "btnOkCatecory";
            this.btnOkCatecory.Size = new System.Drawing.Size(85, 36);
            this.btnOkCatecory.TabIndex = 5;
            this.btnOkCatecory.Text = "OK";
            this.btnOkCatecory.UseVisualStyleBackColor = false;
            this.btnOkCatecory.Click += new System.EventHandler(this.btnOkCatecory_Click);
            // 
            // lblColorSelection
            // 
            this.lblColorSelection.AutoSize = true;
            this.lblColorSelection.Location = new System.Drawing.Point(8, 159);
            this.lblColorSelection.Name = "lblColorSelection";
            this.lblColorSelection.Size = new System.Drawing.Size(112, 17);
            this.lblColorSelection.TabIndex = 4;
            this.lblColorSelection.Text = "Цвет категории";
            // 
            // txtColorCategory
            // 
            this.txtColorCategory.Location = new System.Drawing.Point(269, 156);
            this.txtColorCategory.Multiline = true;
            this.txtColorCategory.Name = "txtColorCategory";
            this.txtColorCategory.Size = new System.Drawing.Size(108, 49);
            this.txtColorCategory.TabIndex = 3;
            // 
            // btnColorCategory
            // 
            this.btnColorCategory.Location = new System.Drawing.Point(153, 156);
            this.btnColorCategory.Name = "btnColorCategory";
            this.btnColorCategory.Size = new System.Drawing.Size(108, 49);
            this.btnColorCategory.TabIndex = 2;
            this.btnColorCategory.Text = "Выбор цвета";
            this.btnColorCategory.UseVisualStyleBackColor = true;
            this.btnColorCategory.Click += new System.EventHandler(this.btnColorCategory_Click);
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(155, 57);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(222, 23);
            this.txtNameCategory.TabIndex = 1;
            // 
            // dgvListCategories
            // 
            this.dgvListCategories.AllowUserToAddRows = false;
            this.dgvListCategories.AllowUserToDeleteRows = false;
            this.dgvListCategories.AllowUserToOrderColumns = true;
            this.dgvListCategories.AllowUserToResizeRows = false;
            this.dgvListCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListCategories.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnName,
            this.clnCType,
            this.clnDiscriptionCategory,
            this.clnColor});
            this.dgvListCategories.Location = new System.Drawing.Point(12, 15);
            this.dgvListCategories.Name = "dgvListCategories";
            this.dgvListCategories.ReadOnly = true;
            this.dgvListCategories.RowHeadersVisible = false;
            this.dgvListCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCategories.Size = new System.Drawing.Size(418, 253);
            this.dgvListCategories.TabIndex = 2;
            // 
            // clnName
            // 
            this.clnName.DataPropertyName = "Name";
            this.clnName.FillWeight = 120F;
            this.clnName.HeaderText = "Название";
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            this.clnName.Width = 120;
            // 
            // clnCType
            // 
            this.clnCType.DataPropertyName = "CType";
            this.clnCType.HeaderText = "Тип";
            this.clnCType.Name = "clnCType";
            this.clnCType.ReadOnly = true;
            // 
            // clnDiscriptionCategory
            // 
            this.clnDiscriptionCategory.DataPropertyName = "Discription";
            this.clnDiscriptionCategory.FillWeight = 120F;
            this.clnDiscriptionCategory.HeaderText = "Описание";
            this.clnDiscriptionCategory.Name = "clnDiscriptionCategory";
            this.clnDiscriptionCategory.ReadOnly = true;
            this.clnDiscriptionCategory.Width = 120;
            // 
            // clnColor
            // 
            this.clnColor.DataPropertyName = "CategoryColor";
            this.clnColor.HeaderText = "Цвет";
            this.clnColor.Name = "clnColor";
            this.clnColor.ReadOnly = true;
            this.clnColor.Width = 80;
            // 
            // frmCreatingCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(832, 280);
            this.Controls.Add(this.dgvListCategories);
            this.Controls.Add(this.grbCreatingCategories);
            this.MinimumSize = new System.Drawing.Size(848, 319);
            this.Name = "frmCreatingCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Категории";
            this.grbCreatingCategories.ResumeLayout(false);
            this.grbCreatingCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameCategory;
        private System.Windows.Forms.GroupBox grbCreatingCategories;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.TextBox txtColorCategory;
        private System.Windows.Forms.Button btnColorCategory;
        private System.Windows.Forms.ColorDialog colorDialogCategory;
        private System.Windows.Forms.Label lblColorSelection;
        private System.Windows.Forms.Button btnOkCatecory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmpTypeTransaction;
        private System.Windows.Forms.TextBox txtDiscriptionCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dgvListCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDiscriptionCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnColor;
    }
}