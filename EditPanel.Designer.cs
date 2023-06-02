namespace Kebele_Management_System
{
    partial class EditPanel
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
            this.uploadImage_btn = new System.Windows.Forms.Button();
            this.idPicture = new System.Windows.Forms.PictureBox();
            this.personalInfo = new System.Windows.Forms.GroupBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.occupation_CB = new System.Windows.Forms.ComboBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.kebele_CB = new System.Windows.Forms.ComboBox();
            this.maritalBox = new System.Windows.Forms.GroupBox();
            this.martial_married = new System.Windows.Forms.RadioButton();
            this.martial_single = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bloodType_CB = new System.Windows.Forms.ComboBox();
            this.password_TB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.email_TB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.house_number = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.wereda_CB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.zone_CB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.region_CB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nationality_CB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sex_CB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.birth_month = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.birth_year = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.birth_day = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.grandFatherName_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fatherName_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstName_TB = new System.Windows.Forms.TextBox();
            this.fullName_label = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.idPicture)).BeginInit();
            this.personalInfo.SuspendLayout();
            this.maritalBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.house_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadImage_btn
            // 
            this.uploadImage_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uploadImage_btn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImage_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uploadImage_btn.Location = new System.Drawing.Point(95, 326);
            this.uploadImage_btn.Name = "uploadImage_btn";
            this.uploadImage_btn.Size = new System.Drawing.Size(271, 37);
            this.uploadImage_btn.TabIndex = 59;
            this.uploadImage_btn.Text = "Upload Image";
            this.uploadImage_btn.UseVisualStyleBackColor = false;
            this.uploadImage_btn.Click += new System.EventHandler(this.uploadImage_btn_Click);
            // 
            // idPicture
            // 
            this.idPicture.Location = new System.Drawing.Point(95, 43);
            this.idPicture.Name = "idPicture";
            this.idPicture.Size = new System.Drawing.Size(271, 245);
            this.idPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.idPicture.TabIndex = 58;
            this.idPicture.TabStop = false;
            // 
            // personalInfo
            // 
            this.personalInfo.Controls.Add(this.cancel_btn);
            this.personalInfo.Controls.Add(this.occupation_CB);
            this.personalInfo.Controls.Add(this.update_btn);
            this.personalInfo.Controls.Add(this.label39);
            this.personalInfo.Controls.Add(this.kebele_CB);
            this.personalInfo.Controls.Add(this.maritalBox);
            this.personalInfo.Controls.Add(this.label21);
            this.personalInfo.Controls.Add(this.label19);
            this.personalInfo.Controls.Add(this.label18);
            this.personalInfo.Controls.Add(this.bloodType_CB);
            this.personalInfo.Controls.Add(this.password_TB);
            this.personalInfo.Controls.Add(this.label17);
            this.personalInfo.Controls.Add(this.email_TB);
            this.personalInfo.Controls.Add(this.label16);
            this.personalInfo.Controls.Add(this.phoneNumber);
            this.personalInfo.Controls.Add(this.label15);
            this.personalInfo.Controls.Add(this.house_number);
            this.personalInfo.Controls.Add(this.label14);
            this.personalInfo.Controls.Add(this.label13);
            this.personalInfo.Controls.Add(this.wereda_CB);
            this.personalInfo.Controls.Add(this.label12);
            this.personalInfo.Controls.Add(this.zone_CB);
            this.personalInfo.Controls.Add(this.label11);
            this.personalInfo.Controls.Add(this.region_CB);
            this.personalInfo.Controls.Add(this.label10);
            this.personalInfo.Controls.Add(this.nationality_CB);
            this.personalInfo.Controls.Add(this.label9);
            this.personalInfo.Controls.Add(this.sex_CB);
            this.personalInfo.Controls.Add(this.label8);
            this.personalInfo.Controls.Add(this.birth_month);
            this.personalInfo.Controls.Add(this.label7);
            this.personalInfo.Controls.Add(this.birth_year);
            this.personalInfo.Controls.Add(this.label6);
            this.personalInfo.Controls.Add(this.birth_day);
            this.personalInfo.Controls.Add(this.label3);
            this.personalInfo.Controls.Add(this.grandFatherName_TB);
            this.personalInfo.Controls.Add(this.label5);
            this.personalInfo.Controls.Add(this.fatherName_TB);
            this.personalInfo.Controls.Add(this.label4);
            this.personalInfo.Controls.Add(this.firstName_TB);
            this.personalInfo.Controls.Add(this.fullName_label);
            this.personalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.personalInfo.Location = new System.Drawing.Point(421, 33);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(664, 546);
            this.personalInfo.TabIndex = 57;
            this.personalInfo.TabStop = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Crimson;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_btn.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel_btn.Location = new System.Drawing.Point(451, 494);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cancel_btn.Size = new System.Drawing.Size(186, 46);
            this.cancel_btn.TabIndex = 108;
            this.cancel_btn.Text = "Exit";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // occupation_CB
            // 
            this.occupation_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occupation_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.occupation_CB.FormattingEnabled = true;
            this.occupation_CB.Items.AddRange(new object[] {
            "Accountant",
            "Architect",
            "Business Owner",
            "Consultant",
            "Dentist",
            "Doctor",
            "Engineer",
            "Farmer",
            "Government Employee",
            "Homemaker",
            "Journalist",
            "Lawyer",
            "Nurse",
            "Pharmacist",
            "Police Officer",
            "Professor",
            "Salesperson",
            "Self-Employed",
            "Student",
            "Teacher",
            "Unemployed"});
            this.occupation_CB.Location = new System.Drawing.Point(237, 365);
            this.occupation_CB.Name = "occupation_CB";
            this.occupation_CB.Size = new System.Drawing.Size(186, 28);
            this.occupation_CB.TabIndex = 107;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.update_btn.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_btn.Location = new System.Drawing.Point(237, 494);
            this.update_btn.Name = "update_btn";
            this.update_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.update_btn.Size = new System.Drawing.Size(186, 46);
            this.update_btn.TabIndex = 106;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Roboto", 12F);
            this.label39.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label39.Location = new System.Drawing.Point(447, 195);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 19);
            this.label39.TabIndex = 104;
            this.label39.Text = "Kebele:";
            // 
            // kebele_CB
            // 
            this.kebele_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kebele_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.kebele_CB.FormattingEnabled = true;
            this.kebele_CB.Location = new System.Drawing.Point(451, 217);
            this.kebele_CB.Name = "kebele_CB";
            this.kebele_CB.Size = new System.Drawing.Size(186, 28);
            this.kebele_CB.TabIndex = 103;
            // 
            // maritalBox
            // 
            this.maritalBox.Controls.Add(this.martial_married);
            this.maritalBox.Controls.Add(this.martial_single);
            this.maritalBox.Location = new System.Drawing.Point(451, 105);
            this.maritalBox.Name = "maritalBox";
            this.maritalBox.Size = new System.Drawing.Size(186, 80);
            this.maritalBox.TabIndex = 100;
            this.maritalBox.TabStop = false;
            this.maritalBox.Text = "Martial Status";
            // 
            // martial_married
            // 
            this.martial_married.AutoSize = true;
            this.martial_married.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.martial_married.Location = new System.Drawing.Point(86, 42);
            this.martial_married.Name = "martial_married";
            this.martial_married.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.martial_married.Size = new System.Drawing.Size(80, 24);
            this.martial_married.TabIndex = 1;
            this.martial_married.TabStop = true;
            this.martial_married.Text = "Married";
            this.martial_married.UseVisualStyleBackColor = true;
            // 
            // martial_single
            // 
            this.martial_single.AutoSize = true;
            this.martial_single.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.martial_single.Location = new System.Drawing.Point(7, 42);
            this.martial_single.Name = "martial_single";
            this.martial_single.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.martial_single.Size = new System.Drawing.Size(71, 24);
            this.martial_single.TabIndex = 0;
            this.martial_single.TabStop = true;
            this.martial_single.Text = "Single";
            this.martial_single.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(98, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 20);
            this.label21.TabIndex = 87;
            this.label21.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Roboto", 12F);
            this.label19.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label19.Location = new System.Drawing.Point(233, 341);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 19);
            this.label19.TabIndex = 85;
            this.label19.Text = "Occupation:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Roboto", 12F);
            this.label18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label18.Location = new System.Drawing.Point(447, 341);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 19);
            this.label18.TabIndex = 84;
            this.label18.Text = "Blood Type:";
            // 
            // bloodType_CB
            // 
            this.bloodType_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodType_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bloodType_CB.FormattingEnabled = true;
            this.bloodType_CB.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodType_CB.Location = new System.Drawing.Point(451, 363);
            this.bloodType_CB.Name = "bloodType_CB";
            this.bloodType_CB.Size = new System.Drawing.Size(186, 28);
            this.bloodType_CB.TabIndex = 83;
            // 
            // password_TB
            // 
            this.password_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.password_TB.Location = new System.Drawing.Point(451, 428);
            this.password_TB.Name = "password_TB";
            this.password_TB.Size = new System.Drawing.Size(186, 28);
            this.password_TB.TabIndex = 82;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Roboto", 12F);
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(447, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 19);
            this.label17.TabIndex = 81;
            this.label17.Text = "Password:";
            // 
            // email_TB
            // 
            this.email_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.email_TB.Location = new System.Drawing.Point(237, 428);
            this.email_TB.Name = "email_TB";
            this.email_TB.Size = new System.Drawing.Size(186, 28);
            this.email_TB.TabIndex = 80;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Roboto", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(233, 406);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 19);
            this.label16.TabIndex = 79;
            this.label16.Text = "E-mail:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Roboto", 13F);
            this.phoneNumber.Location = new System.Drawing.Point(21, 428);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(186, 28);
            this.phoneNumber.TabIndex = 78;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(17, 406);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 19);
            this.label15.TabIndex = 77;
            this.label15.Text = "Phone Number:";
            // 
            // house_number
            // 
            this.house_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.house_number.Location = new System.Drawing.Point(21, 365);
            this.house_number.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.house_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.house_number.Name = "house_number";
            this.house_number.Size = new System.Drawing.Size(186, 26);
            this.house_number.TabIndex = 76;
            this.house_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Roboto", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(17, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 19);
            this.label14.TabIndex = 75;
            this.label14.Text = "House Number:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(447, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 19);
            this.label13.TabIndex = 74;
            this.label13.Text = "Wereda:";
            // 
            // wereda_CB
            // 
            this.wereda_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wereda_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.wereda_CB.FormattingEnabled = true;
            this.wereda_CB.Location = new System.Drawing.Point(451, 292);
            this.wereda_CB.Name = "wereda_CB";
            this.wereda_CB.Size = new System.Drawing.Size(186, 28);
            this.wereda_CB.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(233, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 72;
            this.label12.Text = "Zone:";
            // 
            // zone_CB
            // 
            this.zone_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zone_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.zone_CB.FormattingEnabled = true;
            this.zone_CB.Location = new System.Drawing.Point(237, 292);
            this.zone_CB.Name = "zone_CB";
            this.zone_CB.Size = new System.Drawing.Size(186, 28);
            this.zone_CB.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(17, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 70;
            this.label11.Text = "Region:";
            // 
            // region_CB
            // 
            this.region_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.region_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.region_CB.FormattingEnabled = true;
            this.region_CB.Location = new System.Drawing.Point(21, 292);
            this.region_CB.Name = "region_CB";
            this.region_CB.Size = new System.Drawing.Size(186, 28);
            this.region_CB.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(233, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 68;
            this.label10.Text = "Nationality:";
            // 
            // nationality_CB
            // 
            this.nationality_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationality_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nationality_CB.FormattingEnabled = true;
            this.nationality_CB.Items.AddRange(new object[] {
            "Ethiopian",
            "Kenyan",
            "Algerian",
            "American",
            "Somalian",
            "Ertirean"});
            this.nationality_CB.Location = new System.Drawing.Point(237, 217);
            this.nationality_CB.Name = "nationality_CB";
            this.nationality_CB.Size = new System.Drawing.Size(186, 28);
            this.nationality_CB.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(17, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 66;
            this.label9.Text = "Sex:";
            // 
            // sex_CB
            // 
            this.sex_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.sex_CB.FormattingEnabled = true;
            this.sex_CB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex_CB.Location = new System.Drawing.Point(21, 217);
            this.sex_CB.Name = "sex_CB";
            this.sex_CB.Size = new System.Drawing.Size(186, 28);
            this.sex_CB.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(146, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 64;
            this.label8.Text = "Month:";
            // 
            // birth_month
            // 
            this.birth_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.birth_month.Location = new System.Drawing.Point(149, 152);
            this.birth_month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.birth_month.Name = "birth_month";
            this.birth_month.Size = new System.Drawing.Size(58, 26);
            this.birth_month.TabIndex = 63;
            this.birth_month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(255, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "Year:";
            // 
            // birth_year
            // 
            this.birth_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.birth_year.Location = new System.Drawing.Point(258, 152);
            this.birth_year.Maximum = new decimal(new int[] {
            1997,
            0,
            0,
            0});
            this.birth_year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.birth_year.Name = "birth_year";
            this.birth_year.Size = new System.Drawing.Size(84, 26);
            this.birth_year.TabIndex = 61;
            this.birth_year.Value = new decimal(new int[] {
            1997,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(46, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Day:";
            // 
            // birth_day
            // 
            this.birth_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.birth_day.Location = new System.Drawing.Point(49, 152);
            this.birth_day.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.birth_day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.birth_day.Name = "birth_day";
            this.birth_day.Size = new System.Drawing.Size(58, 26);
            this.birth_day.TabIndex = 59;
            this.birth_day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 58;
            this.label3.Text = "Date Of Birth";
            // 
            // grandFatherName_TB
            // 
            this.grandFatherName_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.grandFatherName_TB.Location = new System.Drawing.Point(451, 60);
            this.grandFatherName_TB.Name = "grandFatherName_TB";
            this.grandFatherName_TB.Size = new System.Drawing.Size(186, 28);
            this.grandFatherName_TB.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(448, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Grand Father\'s Name:";
            // 
            // fatherName_TB
            // 
            this.fatherName_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.fatherName_TB.Location = new System.Drawing.Point(237, 60);
            this.fatherName_TB.Name = "fatherName_TB";
            this.fatherName_TB.Size = new System.Drawing.Size(186, 28);
            this.fatherName_TB.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(234, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Father\'s Name:";
            // 
            // firstName_TB
            // 
            this.firstName_TB.Font = new System.Drawing.Font("Roboto", 13F);
            this.firstName_TB.Location = new System.Drawing.Point(21, 60);
            this.firstName_TB.Name = "firstName_TB";
            this.firstName_TB.Size = new System.Drawing.Size(186, 28);
            this.firstName_TB.TabIndex = 53;
            // 
            // fullName_label
            // 
            this.fullName_label.AutoSize = true;
            this.fullName_label.BackColor = System.Drawing.Color.Transparent;
            this.fullName_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.fullName_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fullName_label.Location = new System.Drawing.Point(18, 39);
            this.fullName_label.Name = "fullName_label";
            this.fullName_label.Size = new System.Drawing.Size(86, 18);
            this.fullName_label.TabIndex = 52;
            this.fullName_label.Text = "First Name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 633);
            this.Controls.Add(this.uploadImage_btn);
            this.Controls.Add(this.idPicture);
            this.Controls.Add(this.personalInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPanel";
            this.Text = "Edit Panel";
            this.Load += new System.EventHandler(this.EditPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idPicture)).EndInit();
            this.personalInfo.ResumeLayout(false);
            this.personalInfo.PerformLayout();
            this.maritalBox.ResumeLayout(false);
            this.maritalBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.house_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadImage_btn;
        private System.Windows.Forms.PictureBox idPicture;
        private System.Windows.Forms.GroupBox personalInfo;
        private System.Windows.Forms.ComboBox occupation_CB;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox kebele_CB;
        private System.Windows.Forms.GroupBox maritalBox;
        private System.Windows.Forms.RadioButton martial_married;
        private System.Windows.Forms.RadioButton martial_single;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox bloodType_CB;
        private System.Windows.Forms.TextBox password_TB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox email_TB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown house_number;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox wereda_CB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox zone_CB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox region_CB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox nationality_CB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sex_CB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown birth_month;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown birth_year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown birth_day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grandFatherName_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fatherName_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstName_TB;
        private System.Windows.Forms.Label fullName_label;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}