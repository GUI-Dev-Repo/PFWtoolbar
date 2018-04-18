namespace PRWGISv01
{
    partial class Fm_addData
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
            this.fcList = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFcList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fcList
            // 
            this.fcList.FormattingEnabled = true;
            this.fcList.Location = new System.Drawing.Point(30, 42);
            this.fcList.Name = "fcList";
            this.fcList.Size = new System.Drawing.Size(120, 160);
            this.fcList.TabIndex = 10;
            this.fcList.SelectedIndexChanged += new System.EventHandler(this.fcList_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(166, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFcList
            // 
            this.lblFcList.AutoSize = true;
            this.lblFcList.Location = new System.Drawing.Point(27, 26);
            this.lblFcList.Name = "lblFcList";
            this.lblFcList.Size = new System.Drawing.Size(64, 13);
            this.lblFcList.TabIndex = 7;
            this.lblFcList.Text = "Data Layers";
            this.lblFcList.Click += new System.EventHandler(this.label2_Click);
            // 
            // Fm_addData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fcList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFcList);
            this.Name = "Fm_addData";
            this.Text = "PFW Add Data";
            this.Load += new System.EventHandler(this.Fm_addData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        void setFcList()
        {
            foreach (var item in nameFeatureClass)            {                this.fcList.Items.Add(item);            }

        }
        #endregion

        private System.Windows.Forms.ListBox fcList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFcList;
    }
}