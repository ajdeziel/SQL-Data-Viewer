namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnImport = new System.Windows.Forms.Button();
            this.tbCsvInput = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.RetrieveData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(26, 90);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(136, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tbCsvInput
            // 
            this.tbCsvInput.Location = new System.Drawing.Point(26, 39);
            this.tbCsvInput.Name = "tbCsvInput";
            this.tbCsvInput.ReadOnly = true;
            this.tbCsvInput.Size = new System.Drawing.Size(291, 20);
            this.tbCsvInput.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(323, 39);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // RetrieveData
            // 
            this.RetrieveData.Location = new System.Drawing.Point(262, 90);
            this.RetrieveData.Name = "RetrieveData";
            this.RetrieveData.Size = new System.Drawing.Size(136, 23);
            this.RetrieveData.TabIndex = 3;
            this.RetrieveData.Text = "Retrieve";
            this.RetrieveData.UseVisualStyleBackColor = true;
            this.RetrieveData.Click += new System.EventHandler(this.RetrieveData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 357);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RetrieveData);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbCsvInput);
            this.Controls.Add(this.btnImport);
            this.Name = "Form1";
            this.Text = "Some kind of CSV to SQL Importer & Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox tbCsvInput;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button RetrieveData;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

