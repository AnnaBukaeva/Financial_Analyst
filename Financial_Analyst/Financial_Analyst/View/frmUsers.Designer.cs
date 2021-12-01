
namespace Financial_Analyst.View
{
    partial class frmUsers
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
            this.grbUsers = new System.Windows.Forms.GroupBox();
            this.lbListUsers = new System.Windows.Forms.ListBox();
            this.grbAddUsers = new System.Windows.Forms.GroupBox();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserDescription = new System.Windows.Forms.TextBox();
            this.lblDescriptionUser = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnOKSaveUsers = new System.Windows.Forms.Button();
            this.grbUsers.SuspendLayout();
            this.grbAddUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUsers
            // 
            this.grbUsers.Controls.Add(this.lbListUsers);
            this.grbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbUsers.Location = new System.Drawing.Point(12, 12);
            this.grbUsers.Name = "grbUsers";
            this.grbUsers.Size = new System.Drawing.Size(341, 206);
            this.grbUsers.TabIndex = 0;
            this.grbUsers.TabStop = false;
            this.grbUsers.Text = "Пользователи ";
            // 
            // lbListUsers
            // 
            this.lbListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbListUsers.FormattingEnabled = true;
            this.lbListUsers.ItemHeight = 20;
            this.lbListUsers.Location = new System.Drawing.Point(3, 22);
            this.lbListUsers.Name = "lbListUsers";
            this.lbListUsers.Size = new System.Drawing.Size(335, 181);
            this.lbListUsers.TabIndex = 0;
            // 
            // grbAddUsers
            // 
            this.grbAddUsers.Controls.Add(this.btnOKSaveUsers);
            this.grbAddUsers.Controls.Add(this.btnDeleteUser);
            this.grbAddUsers.Controls.Add(this.btnAddUser);
            this.grbAddUsers.Controls.Add(this.txtUserDescription);
            this.grbAddUsers.Controls.Add(this.lblDescriptionUser);
            this.grbAddUsers.Controls.Add(this.txtUserName);
            this.grbAddUsers.Controls.Add(this.lblNameUser);
            this.grbAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbAddUsers.Location = new System.Drawing.Point(359, 12);
            this.grbAddUsers.Name = "grbAddUsers";
            this.grbAddUsers.Size = new System.Drawing.Size(351, 206);
            this.grbAddUsers.TabIndex = 1;
            this.grbAddUsers.TabStop = false;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Location = new System.Drawing.Point(6, 22);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(47, 20);
            this.lblNameUser.TabIndex = 0;
            this.lblNameUser.Text = "ФИО";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(101, 16);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(244, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // txtUserDescription
            // 
            this.txtUserDescription.Location = new System.Drawing.Point(101, 62);
            this.txtUserDescription.Multiline = true;
            this.txtUserDescription.Name = "txtUserDescription";
            this.txtUserDescription.Size = new System.Drawing.Size(244, 73);
            this.txtUserDescription.TabIndex = 3;
            // 
            // lblDescriptionUser
            // 
            this.lblDescriptionUser.AutoSize = true;
            this.lblDescriptionUser.Location = new System.Drawing.Point(6, 68);
            this.lblDescriptionUser.Name = "lblDescriptionUser";
            this.lblDescriptionUser.Size = new System.Drawing.Size(83, 20);
            this.lblDescriptionUser.TabIndex = 2;
            this.lblDescriptionUser.Text = "Описание";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddUser.Location = new System.Drawing.Point(6, 163);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(97, 38);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteUser.Location = new System.Drawing.Point(119, 162);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(97, 38);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Удалить";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnOKSaveUsers
            // 
            this.btnOKSaveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOKSaveUsers.Location = new System.Drawing.Point(262, 162);
            this.btnOKSaveUsers.Name = "btnOKSaveUsers";
            this.btnOKSaveUsers.Size = new System.Drawing.Size(83, 38);
            this.btnOKSaveUsers.TabIndex = 5;
            this.btnOKSaveUsers.Text = "ОК";
            this.btnOKSaveUsers.UseVisualStyleBackColor = true;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 225);
            this.Controls.Add(this.grbAddUsers);
            this.Controls.Add(this.grbUsers);
            this.Name = "frmUsers";
            this.Text = "Пользователи";
            this.grbUsers.ResumeLayout(false);
            this.grbAddUsers.ResumeLayout(false);
            this.grbAddUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUsers;
        private System.Windows.Forms.ListBox lbListUsers;
        private System.Windows.Forms.GroupBox grbAddUsers;
        private System.Windows.Forms.TextBox txtUserDescription;
        private System.Windows.Forms.Label lblDescriptionUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Button btnOKSaveUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
    }
}