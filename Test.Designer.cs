namespace Kebele_Management_System
{
    partial class Test
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
            this.weredaComboBox = new System.Windows.Forms.ComboBox();
            this.kebeleComboBox = new System.Windows.Forms.ComboBox();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // weredaComboBox
            // 
            this.weredaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weredaComboBox.FormattingEnabled = true;
            this.weredaComboBox.Location = new System.Drawing.Point(426, 161);
            this.weredaComboBox.Name = "weredaComboBox";
            this.weredaComboBox.Size = new System.Drawing.Size(121, 21);
            this.weredaComboBox.TabIndex = 2;
            this.weredaComboBox.SelectedIndexChanged += new System.EventHandler(this.weredaComboBox_SelectedIndexChanged_1);
            // 
            // kebeleComboBox
            // 
            this.kebeleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kebeleComboBox.FormattingEnabled = true;
            this.kebeleComboBox.Location = new System.Drawing.Point(565, 161);
            this.kebeleComboBox.Name = "kebeleComboBox";
            this.kebeleComboBox.Size = new System.Drawing.Size(121, 21);
            this.kebeleComboBox.TabIndex = 3;
            this.kebeleComboBox.SelectedIndexChanged += new System.EventHandler(this.kebeleComboBox_SelectedIndexChanged);
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(258, 161);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(121, 21);
            this.zoneComboBox.TabIndex = 1;
            this.zoneComboBox.SelectedIndexChanged += new System.EventHandler(this.zoneComboBox_SelectedIndexChanged_1);
            // 
            // regionComboBox
            // 
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(96, 161);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(121, 21);
            this.regionComboBox.TabIndex = 0;
            this.regionComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kebeleComboBox);
            this.Controls.Add(this.weredaComboBox);
            this.Controls.Add(this.zoneComboBox);
            this.Controls.Add(this.regionComboBox);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox weredaComboBox;
        private System.Windows.Forms.ComboBox kebeleComboBox;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}