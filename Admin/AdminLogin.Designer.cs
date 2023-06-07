namespace Kebele_Management_System
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.pass_error = new System.Windows.Forms.Label();
            this.email_error = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminPassword_TB = new System.Windows.Forms.TextBox();
            this.adminEmail_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminLogin_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pass_error
            // 
            this.pass_error.Location = new System.Drawing.Point(531, 197);
            this.pass_error.Name = "pass_error";
            this.pass_error.Size = new System.Drawing.Size(179, 13);
            this.pass_error.TabIndex = 14;
            this.pass_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // email_error
            // 
            this.email_error.Location = new System.Drawing.Point(528, 119);
            this.email_error.Name = "email_error";
            this.email_error.Size = new System.Drawing.Size(182, 23);
            this.email_error.TabIndex = 12;
            this.email_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(350, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(350, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-mail:";
            // 
            // adminPassword_TB
            // 
            this.adminPassword_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminPassword_TB.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassword_TB.Location = new System.Drawing.Point(352, 213);
            this.adminPassword_TB.MaxLength = 100;
            this.adminPassword_TB.Name = "adminPassword_TB";
            this.adminPassword_TB.PasswordChar = '*';
            this.adminPassword_TB.Size = new System.Drawing.Size(357, 33);
            this.adminPassword_TB.TabIndex = 11;
            // 
            // adminEmail_TB
            // 
            this.adminEmail_TB.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com",
            "@yahoo.com"});
            this.adminEmail_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.adminEmail_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.adminEmail_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminEmail_TB.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEmail_TB.Location = new System.Drawing.Point(352, 145);
            this.adminEmail_TB.MaxLength = 100;
            this.adminEmail_TB.Name = "adminEmail_TB";
            this.adminEmail_TB.Size = new System.Drawing.Size(357, 33);
            this.adminEmail_TB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(346, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sign In";
            // 
            // adminLogin_btn
            // 
            this.adminLogin_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.adminLogin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLogin_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.adminLogin_btn.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminLogin_btn.Location = new System.Drawing.Point(352, 267);
            this.adminLogin_btn.Name = "adminLogin_btn";
            this.adminLogin_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.adminLogin_btn.Size = new System.Drawing.Size(357, 46);
            this.adminLogin_btn.TabIndex = 13;
            this.adminLogin_btn.Text = "Log In";
            this.adminLogin_btn.UseVisualStyleBackColor = false;
            this.adminLogin_btn.Click += new System.EventHandler(this.adminLogin_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass_error);
            this.Controls.Add(this.email_error);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adminPassword_TB);
            this.Controls.Add(this.adminEmail_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminLogin_btn);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pass_error;
        private System.Windows.Forms.Label email_error;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adminPassword_TB;
        private System.Windows.Forms.TextBox adminEmail_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminLogin_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}