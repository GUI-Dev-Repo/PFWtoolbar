namespace PRWGISv01
{
    partial class frm_prjBoundary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textWEA = new System.Windows.Forms.TextBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.textCreator = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboCounty = new System.Windows.Forms.ComboBox();
            this.textFeature = new System.Windows.Forms.TextBox();
            this.richComments = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateExp = new System.Windows.Forms.DateTimePicker();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "WEA#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Creator";
            // 
            // textWEA
            // 
            this.textWEA.Location = new System.Drawing.Point(106, 95);
            this.textWEA.Name = "textWEA";
            this.textWEA.Size = new System.Drawing.Size(121, 20);
            this.textWEA.TabIndex = 3;
            // 
            // comboStatus
            // 
            this.comboStatus.AllowDrop = true;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Complete",
            "In progress",
            "On hold"});
            this.comboStatus.Location = new System.Drawing.Point(106, 23);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 21);
            this.comboStatus.TabIndex = 1;
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
            this.comboState.Location = new System.Drawing.Point(106, 129);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(121, 21);
            this.comboState.TabIndex = 4;
            this.comboState.SelectedIndexChanged += new System.EventHandler(this.comboState_SelectedIndexChanged);
            // 
            // textCreator
            // 
            this.textCreator.Location = new System.Drawing.Point(106, 172);
            this.textCreator.Name = "textCreator";
            this.textCreator.Size = new System.Drawing.Size(121, 20);
            this.textCreator.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLastName);
            this.groupBox1.Controls.Add(this.textFirstName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(27, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wildlife Cooperator";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(79, 69);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(121, 20);
            this.textLastName.TabIndex = 11;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(79, 36);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(121, 20);
            this.textFirstName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "First";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Exp Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Feature";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "County";
            // 
            // comboCounty
            // 
            this.comboCounty.FormattingEnabled = true;
            this.comboCounty.Location = new System.Drawing.Point(323, 129);
            this.comboCounty.Name = "comboCounty";
            this.comboCounty.Size = new System.Drawing.Size(121, 21);
            this.comboCounty.TabIndex = 9;
            // 
            // textFeature
            // 
            this.textFeature.Location = new System.Drawing.Point(323, 95);
            this.textFeature.Name = "textFeature";
            this.textFeature.Size = new System.Drawing.Size(121, 20);
            this.textFeature.TabIndex = 8;
            // 
            // richComments
            // 
            this.richComments.Location = new System.Drawing.Point(274, 214);
            this.richComments.Name = "richComments";
            this.richComments.Size = new System.Drawing.Size(170, 112);
            this.richComments.TabIndex = 12;
            this.richComments.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Comments:";
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "MM/dd/yyyy";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(106, 59);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(121, 20);
            this.dateStart.TabIndex = 2;
            // 
            // dateExp
            // 
            this.dateExp.CustomFormat = "MM/dd/yyyy";
            this.dateExp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExp.Location = new System.Drawing.Point(323, 59);
            this.dateExp.Name = "dateExp";
            this.dateExp.Size = new System.Drawing.Size(121, 20);
            this.dateExp.TabIndex = 7;
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
            this.comboYear.Location = new System.Drawing.Point(323, 22);
            this.comboYear.MaxDropDownItems = 4;
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(121, 21);
            this.comboYear.TabIndex = 6;
            // 
            // frm_prjBoundary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 378);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.dateExp);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.richComments);
            this.Controls.Add(this.textFeature);
            this.Controls.Add(this.comboCounty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textCreator);
            this.Controls.Add(this.comboState);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.textWEA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_prjBoundary";
            this.Text = "PFW Project Boundary";
            this.Load += new System.EventHandler(this.Fm_attEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox comboStatus;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox textWEA;
        public System.Windows.Forms.ComboBox comboState;
        public System.Windows.Forms.TextBox textCreator;
        public System.Windows.Forms.TextBox textLastName;
        public System.Windows.Forms.TextBox textFirstName;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboCounty;
        public System.Windows.Forms.TextBox textFeature;
        public System.Windows.Forms.RichTextBox richComments;
        public System.Windows.Forms.DateTimePicker dateStart;
        public System.Windows.Forms.DateTimePicker dateExp;
        public System.Windows.Forms.ComboBox comboYear;
    }
}