
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
            this.txtColorCategory = new System.Windows.Forms.TextBox();
            this.btnColorCategory = new System.Windows.Forms.Button();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.colorDialogCategory = new System.Windows.Forms.ColorDialog();
            this.lblColorSelection = new System.Windows.Forms.Label();
            this.btnOkCatecory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grbCreatingCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoSize = true;
            this.lblNameCategory.Location = new System.Drawing.Point(5, 73);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(165, 20);
            this.lblNameCategory.TabIndex = 0;
            this.lblNameCategory.Text = "Название категории";
            // 
            // grbCreatingCategories
            // 
            this.grbCreatingCategories.Controls.Add(this.comboBox1);
            this.grbCreatingCategories.Controls.Add(this.label1);
            this.grbCreatingCategories.Controls.Add(this.btnOkCatecory);
            this.grbCreatingCategories.Controls.Add(this.lblColorSelection);
            this.grbCreatingCategories.Controls.Add(this.txtColorCategory);
            this.grbCreatingCategories.Controls.Add(this.btnColorCategory);
            this.grbCreatingCategories.Controls.Add(this.txtNameCategory);
            this.grbCreatingCategories.Controls.Add(this.lblNameCategory);
            this.grbCreatingCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbCreatingCategories.Location = new System.Drawing.Point(293, 12);
            this.grbCreatingCategories.Name = "grbCreatingCategories";
            this.grbCreatingCategories.Size = new System.Drawing.Size(417, 228);
            this.grbCreatingCategories.TabIndex = 1;
            this.grbCreatingCategories.TabStop = false;
            this.grbCreatingCategories.Text = "Создание категории";
            // 
            // txtColorCategory
            // 
            this.txtColorCategory.Location = new System.Drawing.Point(296, 110);
            this.txtColorCategory.Multiline = true;
            this.txtColorCategory.Name = "txtColorCategory";
            this.txtColorCategory.Size = new System.Drawing.Size(108, 49);
            this.txtColorCategory.TabIndex = 3;
            // 
            // btnColorCategory
            // 
            this.btnColorCategory.Location = new System.Drawing.Point(180, 110);
            this.btnColorCategory.Name = "btnColorCategory";
            this.btnColorCategory.Size = new System.Drawing.Size(108, 49);
            this.btnColorCategory.TabIndex = 2;
            this.btnColorCategory.Text = "Выбор цвета";
            this.btnColorCategory.UseVisualStyleBackColor = true;
            this.btnColorCategory.Click += new System.EventHandler(this.btnColorCategory_Click);
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(180, 67);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(218, 26);
            this.txtNameCategory.TabIndex = 1;
            // 
            // lblColorSelection
            // 
            this.lblColorSelection.AutoSize = true;
            this.lblColorSelection.Location = new System.Drawing.Point(6, 110);
            this.lblColorSelection.Name = "lblColorSelection";
            this.lblColorSelection.Size = new System.Drawing.Size(130, 20);
            this.lblColorSelection.TabIndex = 4;
            this.lblColorSelection.Text = "Цвет категории";
            // 
            // btnOkCatecory
            // 
            this.btnOkCatecory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOkCatecory.Location = new System.Drawing.Point(157, 182);
            this.btnOkCatecory.Name = "btnOkCatecory";
            this.btnOkCatecory.Size = new System.Drawing.Size(85, 36);
            this.btnOkCatecory.TabIndex = 5;
            this.btnOkCatecory.Text = "ОК";
            this.btnOkCatecory.UseVisualStyleBackColor = true;
            this.btnOkCatecory.Click += new System.EventHandler(this.btnOkCatecory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип транзакции";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 225);
            this.listBox1.TabIndex = 2;
            // 
            // frmCreatingCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 245);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.grbCreatingCategories);
            this.Name = "frmCreatingCategories";
            this.Text = "frmCreatingCategories";
            this.grbCreatingCategories.ResumeLayout(false);
            this.grbCreatingCategories.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}