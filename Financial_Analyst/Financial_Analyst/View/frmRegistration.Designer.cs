
namespace Financial_Analyst.View
{
    partial class frmRegistration
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
            this.grbRegistration = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPasswordRegistr = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtFIORegistr = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.grbRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegistration
            // 
            this.grbRegistration.Controls.Add(this.btnRegister);
            this.grbRegistration.Controls.Add(this.lblPassword);
            this.grbRegistration.Controls.Add(this.txtPasswordRegistr);
            this.grbRegistration.Controls.Add(this.lblLogin);
            this.grbRegistration.Controls.Add(this.txtFIORegistr);
            this.grbRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbRegistration.Location = new System.Drawing.Point(12, 67);
            this.grbRegistration.Name = "grbRegistration";
            this.grbRegistration.Size = new System.Drawing.Size(341, 174);
            this.grbRegistration.TabIndex = 0;
            this.grbRegistration.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(74, 126);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 42);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Пароль";
            // 
            // txtPasswordRegistr
            // 
            this.txtPasswordRegistr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswordRegistr.Location = new System.Drawing.Point(89, 76);
            this.txtPasswordRegistr.Name = "txtPasswordRegistr";
            this.txtPasswordRegistr.Size = new System.Drawing.Size(246, 26);
            this.txtPasswordRegistr.TabIndex = 6;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 20);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "ФИО";
            // 
            // txtFIORegistr
            // 
            this.txtFIORegistr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFIORegistr.Location = new System.Drawing.Point(89, 26);
            this.txtFIORegistr.Name = "txtFIORegistr";
            this.txtFIORegistr.Size = new System.Drawing.Size(246, 26);
            this.txtFIORegistr.TabIndex = 4;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuth.Location = new System.Drawing.Point(105, 27);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(141, 26);
            this.lblAuth.TabIndex = 3;
            this.lblAuth.Text = "Регистрация";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(365, 253);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.grbRegistration);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(381, 292);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(381, 292);
            this.Name = "frmRegistration";
            this.Text = "Регистрация";
            this.grbRegistration.ResumeLayout(false);
            this.grbRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegistration;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPasswordRegistr;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtFIORegistr;
        private System.Windows.Forms.Label lblAuth;
    }
}