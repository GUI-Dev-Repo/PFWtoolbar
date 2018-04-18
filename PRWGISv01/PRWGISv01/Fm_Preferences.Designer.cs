namespace PRWGISv01
{
    partial class Fm_Preferences
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocationDb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseTable = new System.Windows.Forms.Button();
            this.textLocationTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseDb = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocationDb);
            this.groupBox1.Location = new System.Drawing.Point(76, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PFWGIS Database Location";
            // 
            // textLocationDb
            // 
            this.textLocationDb.Location = new System.Drawing.Point(6, 29);
            this.textLocationDb.Name = "textLocationDb";
            this.textLocationDb.Size = new System.Drawing.Size(390, 20);
            this.textLocationDb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowseTable);
            this.groupBox2.Controls.Add(this.textLocationTable);
            this.groupBox2.Location = new System.Drawing.Point(76, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PFWGIS Lookup Table Location";
            // 
            // btnBrowseTable
            // 
            this.btnBrowseTable.Location = new System.Drawing.Point(402, 29);
            this.btnBrowseTable.Name = "btnBrowseTable";
            this.btnBrowseTable.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseTable.TabIndex = 3;
            this.btnBrowseTable.Text = "Browse";
            this.btnBrowseTable.UseVisualStyleBackColor = true;
            this.btnBrowseTable.Click += new System.EventHandler(this.btnBrowseTable_Click);
            // 
            // textLocationTable
            // 
            this.textLocationTable.Location = new System.Drawing.Point(6, 29);
            this.textLocationTable.Name = "textLocationTable";
            this.textLocationTable.Size = new System.Drawing.Size(389, 20);
            this.textLocationTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify the following PFW GIS Database Locations";
            // 
            // btnBrowseDb
            // 
            this.btnBrowseDb.Location = new System.Drawing.Point(478, 100);
            this.btnBrowseDb.Name = "btnBrowseDb";
            this.btnBrowseDb.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseDb.TabIndex = 1;
            this.btnBrowseDb.Text = "Browse";
            this.btnBrowseDb.UseVisualStyleBackColor = true;
            this.btnBrowseDb.Click += new System.EventHandler(this.btnBrowseDb_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(199, 244);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Fm_Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 284);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBrowseDb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Fm_Preferences";
            this.Text = "PFWGIS Preferences";
            this.Load += new System.EventHandler(this.Fm_Preferences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox textLocationDb;
        public System.Windows.Forms.TextBox textLocationTable;
        public System.Windows.Forms.Button btnBrowseDb;
        public System.Windows.Forms.Button btnBrowseTable;
    }
}