namespace PRWGISv01
{
    partial class Frm_Grazing
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.textWEA = new System.Windows.Forms.TextBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboCounty = new System.Windows.Forms.ComboBox();
            this.dateExp = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textCreator = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richComments = new System.Windows.Forms.RichTextBox();
            this.textAcres = new System.Windows.Forms.TextBox();
            this.textFeature = new System.Windows.Forms.TextBox();
            this.comboLandCover = new System.Windows.Forms.ComboBox();
            this.comboLandUse = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboStatus);
            this.groupBox2.Controls.Add(this.dateStart);
            this.groupBox2.Controls.Add(this.comboState);
            this.groupBox2.Controls.Add(this.textWEA);
            this.groupBox2.Controls.Add(this.comboYear);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboCounty);
            this.groupBox2.Controls.Add(this.dateExp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textCreator);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 165);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Standard Fields";
            // 
            // comboStatus
            // 
            this.comboStatus.AllowDrop = true;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Complete",
            "In progress",
            "On hold"});
            this.comboStatus.Location = new System.Drawing.Point(106, 19);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 21);
            this.comboStatus.TabIndex = 63;
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "MM/dd/yyyy";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(104, 65);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(121, 20);
            this.dateStart.TabIndex = 66;
            // 
            // comboState
            // 
            this.comboState.FormattingEnabled = true;
            this.comboState.Items.AddRange(new object[] {
            "ND",
            "SD",
            "MT",
            "WY",
            "UT",
            "CO",
            "NE",
            "KS"});
            this.comboState.Location = new System.Drawing.Point(104, 135);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(121, 21);
            this.comboState.TabIndex = 65;
            // 
            // textWEA
            // 
            this.textWEA.Location = new System.Drawing.Point(104, 101);
            this.textWEA.Name = "textWEA";
            this.textWEA.Size = new System.Drawing.Size(121, 20);
            this.textWEA.TabIndex = 64;
            // 
            // comboYear
            // 
            this.comboYear.DropDownHeight = 50;
            this.comboYear.FormattingEnabled = true;
            this.comboYear.IntegralHeight = false;
            this.comboYear.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.comboYear.Location = new System.Drawing.Point(329, 19);
            this.comboYear.MaxDropDownItems = 4;
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(121, 21);
            this.comboYear.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "County";
            // 
            // comboCounty
            // 
            this.comboCounty.FormattingEnabled = true;
            this.comboCounty.Location = new System.Drawing.Point(329, 95);
            this.comboCounty.Name = "comboCounty";
            this.comboCounty.Size = new System.Drawing.Size(121, 21);
            this.comboCounty.TabIndex = 59;
            // 
            // dateExp
            // 
            this.dateExp.CustomFormat = "MM/dd/yyyy";
            this.dateExp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExp.Location = new System.Drawing.Point(329, 60);
            this.dateExp.Name = "dateExp";
            this.dateExp.Size = new System.Drawing.Size(121, 20);
            this.dateExp.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Exp Date";
            // 
            // textCreator
            // 
            this.textCreator.Location = new System.Drawing.Point(330, 131);
            this.textCreator.Name = "textCreator";
            this.textCreator.Size = new System.Drawing.Size(121, 20);
            this.textCreator.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Data Creator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "WEA#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Project Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textLastName);
            this.groupBox1.Controls.Add(this.textFirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 58);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wildlife Cooperator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "First";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(329, 21);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(121, 20);
            this.textLastName.TabIndex = 57;
            this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(106, 22);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(121, 20);
            this.textFirstName.TabIndex = 62;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richComments);
            this.groupBox3.Controls.Add(this.textAcres);
            this.groupBox3.Controls.Add(this.textFeature);
            this.groupBox3.Controls.Add(this.comboLandCover);
            this.groupBox3.Controls.Add(this.comboLandUse);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 150);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PFW Grazing";
            // 
            // richComments
            // 
            this.richComments.Location = new System.Drawing.Point(330, 69);
            this.richComments.Name = "richComments";
            this.richComments.Size = new System.Drawing.Size(120, 45);
            this.richComments.TabIndex = 9;
            this.richComments.Text = "";
            // 
            // textAcres
            // 
            this.textAcres.Location = new System.Drawing.Point(330, 37);
            this.textAcres.Name = "textAcres";
            this.textAcres.Size = new System.Drawing.Size(120, 20);
            this.textAcres.TabIndex = 8;
            // 
            // textFeature
            // 
            this.textFeature.Location = new System.Drawing.Point(106, 30);
            this.textFeature.Name = "textFeature";
            this.textFeature.ReadOnly = true;
            this.textFeature.Size = new System.Drawing.Size(121, 20);
            this.textFeature.TabIndex = 7;
            // 
            // comboLandCover
            // 
            this.comboLandCover.FormattingEnabled = true;
            this.comboLandCover.Items.AddRange(new object[] {
            "Cropped",
            "CRP",
            "Grazed",
            "Hayed",
            "Idle"});
            this.comboLandCover.Location = new System.Drawing.Point(106, 93);
            this.comboLandCover.Name = "comboLandCover";
            this.comboLandCover.Size = new System.Drawing.Size(121, 21);
            this.comboLandCover.TabIndex = 6;
            // 
            // comboLandUse
            // 
            this.comboLandUse.FormattingEnabled = true;
            this.comboLandUse.Items.AddRange(new object[] {
            "Cropland",
            "CRP",
            "Native Grass",
            "Tame Grass",
            "Wetland",
            "Forest/Woodland"});
            this.comboLandUse.Location = new System.Drawing.Point(106, 61);
            this.comboLandUse.Name = "comboLandUse";
            this.comboLandUse.Size = new System.Drawing.Size(121, 21);
            this.comboLandUse.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Comments";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(277, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Acres";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Landcover";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Landuse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Feature";
            // 
            // Frm_Grazing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 446);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Grazing";
            this.Text = "PFW Grazing";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboYear;
        public System.Windows.Forms.ComboBox comboCounty;
        public System.Windows.Forms.DateTimePicker dateExp;
        public System.Windows.Forms.TextBox textCreator;
        public System.Windows.Forms.TextBox textLastName;
        public System.Windows.Forms.ComboBox comboStatus;
        public System.Windows.Forms.DateTimePicker dateStart;
        public System.Windows.Forms.ComboBox comboState;
        public System.Windows.Forms.TextBox textWEA;
        public System.Windows.Forms.TextBox textFirstName;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.RichTextBox richComments;
        public System.Windows.Forms.TextBox textAcres;
        public System.Windows.Forms.TextBox textFeature;
        public System.Windows.Forms.ComboBox comboLandCover;
        public System.Windows.Forms.ComboBox comboLandUse;
    }
}