
namespace Financial_Analyst.View
{
    partial class frmAboutProgram
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
            this.txtAboutProgram = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAboutProgram
            // 
            this.txtAboutProgram.BackColor = System.Drawing.SystemColors.Window;
            this.txtAboutProgram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAboutProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAboutProgram.Location = new System.Drawing.Point(12, 12);
            this.txtAboutProgram.Multiline = true;
            this.txtAboutProgram.Name = "txtAboutProgram";
            this.txtAboutProgram.ReadOnly = true;
            this.txtAboutProgram.Size = new System.Drawing.Size(284, 158);
            this.txtAboutProgram.TabIndex = 0;
            this.txtAboutProgram.Text = "Международный IT колледж DevEducation\r\nФилиал г. Санкт-Петербурга\r\n\r\nРазработчки:" +
    "\r\nБукаева Виктория,\r\nБукаева Анна,\r\nКудрявцев Александр\r\n\r\n2021 год\r\n";
            this.txtAboutProgram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(308, 182);
            this.Controls.Add(this.txtAboutProgram);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 221);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(324, 221);
            this.Name = "frmAboutProgram";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAboutProgram;
    }
}