namespace Kebele_Management_System
{
    partial class WaitingList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.decline_btn = new System.Windows.Forms.Button();
            this.approve_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.waitingDataGridView = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.decline_btn);
            this.panel1.Controls.Add(this.approve_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 1;
            // 
            // decline_btn
            // 
            this.decline_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.decline_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decline_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.decline_btn.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold);
            this.decline_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decline_btn.Location = new System.Drawing.Point(131, 9);
            this.decline_btn.Name = "decline_btn";
            this.decline_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.decline_btn.Size = new System.Drawing.Size(108, 43);
            this.decline_btn.TabIndex = 108;
            this.decline_btn.Text = "Decline";
            this.decline_btn.UseVisualStyleBackColor = false;
            this.decline_btn.Click += new System.EventHandler(this.decline_btn_Click);
            // 
            // approve_btn
            // 
            this.approve_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.approve_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approve_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.approve_btn.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold);
            this.approve_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.approve_btn.Location = new System.Drawing.Point(2, 9);
            this.approve_btn.Name = "approve_btn";
            this.approve_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.approve_btn.Size = new System.Drawing.Size(108, 43);
            this.approve_btn.TabIndex = 107;
            this.approve_btn.Text = "Approve";
            this.approve_btn.UseVisualStyleBackColor = false;
            this.approve_btn.Click += new System.EventHandler(this.approve_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.waitingDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 389);
            this.panel2.TabIndex = 2;
            // 
            // waitingDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.waitingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.waitingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waitingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waitingDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waitingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.waitingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.waitingDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.waitingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.waitingDataGridView.Name = "waitingDataGridView";
            this.waitingDataGridView.ReadOnly = true;
            this.waitingDataGridView.Size = new System.Drawing.Size(800, 389);
            this.waitingDataGridView.TabIndex = 3;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // WaitingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitingList";
            this.Text = "WaitingList";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waitingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button decline_btn;
        private System.Windows.Forms.Button approve_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView waitingDataGridView;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}