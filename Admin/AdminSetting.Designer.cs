namespace Kebele_Management_System
{
    partial class AdminSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Admin_dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email_TB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fullName_TB = new System.Windows.Forms.TextBox();
            this.fullName_label = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.addAdmin_btn = new System.Windows.Forms.Button();
            this.password_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Admin_dataGrid);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List Of Admin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.edit_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 62);
            this.panel1.TabIndex = 3;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(170, 12);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(144, 43);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click_1);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Orange;
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(5, 12);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(142, 43);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Admin_dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Light", 10F);
            this.Admin_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Admin_dataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Admin_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Admin_dataGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Light", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Admin_dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Admin_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admin_dataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.Admin_dataGrid.Location = new System.Drawing.Point(3, 65);
            this.Admin_dataGrid.Name = "Admin_dataGrid";
            this.Admin_dataGrid.ReadOnly = true;
            this.Admin_dataGrid.Size = new System.Drawing.Size(786, 356);
            this.Admin_dataGrid.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.password_TB);
            this.groupBox1.Controls.Add(this.addAdmin_btn);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.fullName_label);
            this.groupBox1.Controls.Add(this.fullName_TB);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.email_TB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.Location = new System.Drawing.Point(62, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 383);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(228, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "*";
            // 
            // email_TB
            // 
            this.email_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.email_TB.Location = new System.Drawing.Point(183, 148);
            this.email_TB.Name = "email_TB";
            this.email_TB.Size = new System.Drawing.Size(305, 28);
            this.email_TB.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 11F);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(180, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 51;
            this.label10.Text = "Email:";
            // 
            // fullName_TB
            // 
            this.fullName_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.fullName_TB.Location = new System.Drawing.Point(183, 73);
            this.fullName_TB.Name = "fullName_TB";
            this.fullName_TB.Size = new System.Drawing.Size(305, 28);
            this.fullName_TB.TabIndex = 43;
            // 
            // fullName_label
            // 
            this.fullName_label.AutoSize = true;
            this.fullName_label.BackColor = System.Drawing.Color.Transparent;
            this.fullName_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.fullName_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fullName_label.Location = new System.Drawing.Point(180, 52);
            this.fullName_label.Name = "fullName_label";
            this.fullName_label.Size = new System.Drawing.Size(80, 18);
            this.fullName_label.TabIndex = 42;
            this.fullName_label.Text = "Full Name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(253, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 20);
            this.label21.TabIndex = 64;
            this.label21.Text = "*";
            // 
            // addAdmin_btn
            // 
            this.addAdmin_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.addAdmin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAdmin_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.addAdmin_btn.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdmin_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAdmin_btn.Location = new System.Drawing.Point(235, 289);
            this.addAdmin_btn.Name = "addAdmin_btn";
            this.addAdmin_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.addAdmin_btn.Size = new System.Drawing.Size(186, 46);
            this.addAdmin_btn.TabIndex = 66;
            this.addAdmin_btn.Text = "Create Admin";
            this.addAdmin_btn.UseVisualStyleBackColor = false;
            this.addAdmin_btn.Click += new System.EventHandler(this.addAdmin_btn_Click);
            // 
            // password_TB
            // 
            this.password_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.password_TB.Location = new System.Drawing.Point(183, 227);
            this.password_TB.Name = "password_TB";
            this.password_TB.Size = new System.Drawing.Size(305, 28);
            this.password_TB.TabIndex = 57;
            this.password_TB.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(180, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(252, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "*";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AdminSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSetting";
            this.Text = "AdminSetting";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.DataGridView Admin_dataGrid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_TB;
        private System.Windows.Forms.Button addAdmin_btn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label fullName_label;
        private System.Windows.Forms.TextBox fullName_TB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox email_TB;
        private System.Windows.Forms.Label label7;
    }
}