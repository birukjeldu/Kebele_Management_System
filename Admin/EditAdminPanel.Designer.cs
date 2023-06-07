namespace Kebele_Management_System
{
    partial class EditAdminPanel
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
            this.components = new System.ComponentModel.Container();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_TB = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.fullName_label = new System.Windows.Forms.Label();
            this.fullName_TB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.email_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Crimson;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_btn.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel_btn.Location = new System.Drawing.Point(532, 373);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cancel_btn.Size = new System.Drawing.Size(186, 46);
            this.cancel_btn.TabIndex = 110;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.update_btn.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_btn.Location = new System.Drawing.Point(318, 373);
            this.update_btn.Name = "update_btn";
            this.update_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.update_btn.Size = new System.Drawing.Size(186, 46);
            this.update_btn.TabIndex = 109;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(300, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(228, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 117;
            this.label1.Text = "Password:";
            // 
            // password_TB
            // 
            this.password_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.password_TB.Location = new System.Drawing.Point(231, 259);
            this.password_TB.Name = "password_TB";
            this.password_TB.Size = new System.Drawing.Size(305, 28);
            this.password_TB.TabIndex = 118;
            this.password_TB.UseSystemPasswordChar = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(301, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 20);
            this.label21.TabIndex = 116;
            this.label21.Text = "*";
            // 
            // fullName_label
            // 
            this.fullName_label.AutoSize = true;
            this.fullName_label.BackColor = System.Drawing.Color.Transparent;
            this.fullName_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.fullName_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fullName_label.Location = new System.Drawing.Point(228, 84);
            this.fullName_label.Name = "fullName_label";
            this.fullName_label.Size = new System.Drawing.Size(80, 18);
            this.fullName_label.TabIndex = 111;
            this.fullName_label.Text = "Full Name:";
            // 
            // fullName_TB
            // 
            this.fullName_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.fullName_TB.Location = new System.Drawing.Point(231, 105);
            this.fullName_TB.Name = "fullName_TB";
            this.fullName_TB.Size = new System.Drawing.Size(305, 28);
            this.fullName_TB.TabIndex = 112;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 11F);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(228, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 113;
            this.label10.Text = "Email:";
            // 
            // email_TB
            // 
            this.email_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.email_TB.Location = new System.Drawing.Point(231, 180);
            this.email_TB.Name = "email_TB";
            this.email_TB.Size = new System.Drawing.Size(305, 28);
            this.email_TB.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(276, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 115;
            this.label7.Text = "*";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // EditAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_TB);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.fullName_label);
            this.Controls.Add(this.fullName_TB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.email_TB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.update_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Admin Data";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_TB;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label fullName_label;
        private System.Windows.Forms.TextBox fullName_TB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox email_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}