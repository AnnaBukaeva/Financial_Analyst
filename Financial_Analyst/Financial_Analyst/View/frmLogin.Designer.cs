namespace Financial_Analyst.View
{
    partial class frmLogin
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
            this.lblFirstNameUser = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtFirstNameUser = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblLastNameUser = new System.Windows.Forms.Label();
            this.txtLastNameUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstNameUser
            // 
            this.lblFirstNameUser.AutoSize = true;
            this.lblFirstNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNameUser.Location = new System.Drawing.Point(12, 40);
            this.lblFirstNameUser.Name = "lblFirstNameUser";
            this.lblFirstNameUser.Size = new System.Drawing.Size(39, 17);
            this.lblFirstNameUser.TabIndex = 0;
            this.lblFirstNameUser.Text = "Имя ";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 129);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(93, 17);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Номер счёта";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIn.Location = new System.Drawing.Point(160, 187);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(94, 31);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Войти";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtFirstNameUser
            // 
            this.txtFirstNameUser.Location = new System.Drawing.Point(160, 40);
            this.txtFirstNameUser.Name = "txtFirstNameUser";
            this.txtFirstNameUser.Size = new System.Drawing.Size(250, 20);
            this.txtFirstNameUser.TabIndex = 3;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(160, 129);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(250, 20);
            this.txtAccountNumber.TabIndex = 4;
            // 
            // lblLastNameUser
            // 
            this.lblLastNameUser.AutoSize = true;
            this.lblLastNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNameUser.Location = new System.Drawing.Point(12, 87);
            this.lblLastNameUser.Name = "lblLastNameUser";
            this.lblLastNameUser.Size = new System.Drawing.Size(74, 17);
            this.lblLastNameUser.TabIndex = 5;
            this.lblLastNameUser.Text = "Фамилия ";
            // 
            // txtLastNameUser
            // 
            this.txtLastNameUser.Location = new System.Drawing.Point(160, 84);
            this.txtLastNameUser.Name = "txtLastNameUser";
            this.txtLastNameUser.Size = new System.Drawing.Size(250, 20);
            this.txtLastNameUser.TabIndex = 6;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 230);
            this.Controls.Add(this.txtLastNameUser);
            this.Controls.Add(this.lblLastNameUser);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtFirstNameUser);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblFirstNameUser);
            this.MaximumSize = new System.Drawing.Size(450, 269);
            this.MinimumSize = new System.Drawing.Size(450, 269);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNameUser;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtFirstNameUser;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblLastNameUser;
        private System.Windows.Forms.TextBox txtLastNameUser;
    }
}