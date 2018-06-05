namespace StudentTestWinForm
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
            this.bttNew = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gridStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttExport = new System.Windows.Forms.Button();
            this.txtDob = new System.Windows.Forms.DateTimePicker();
            this.txtScore = new System.Windows.Forms.NumericUpDown();
            this.bttBrowser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScore)).BeginInit();
            this.SuspendLayout();
            // 
            // bttNew
            // 
            this.bttNew.Location = new System.Drawing.Point(15, 300);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(95, 23);
            this.bttNew.TabIndex = 0;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 20);
            this.txtId.TabIndex = 1;
            // 
            // gridStudent
            // 
            this.gridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudent.Location = new System.Drawing.Point(265, 32);
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.Size = new System.Drawing.Size(560, 244);
            this.gridStudent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date Of Birth";
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(122, 300);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(95, 23);
            this.bttSave.TabIndex = 10;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            // 
            // bttExport
            // 
            this.bttExport.Location = new System.Drawing.Point(705, 300);
            this.bttExport.Name = "bttExport";
            this.bttExport.Size = new System.Drawing.Size(120, 23);
            this.bttExport.TabIndex = 11;
            this.bttExport.Text = "Export To XML";
            this.bttExport.UseVisualStyleBackColor = true;
            // 
            // txtDob
            // 
            this.txtDob.CustomFormat = "MM/dd/yyyy";
            this.txtDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDob.Location = new System.Drawing.Point(15, 184);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(202, 20);
            this.txtDob.TabIndex = 12;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(15, 256);
            this.txtScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(202, 20);
            this.txtScore.TabIndex = 13;
            // 
            // bttBrowser
            // 
            this.bttBrowser.Location = new System.Drawing.Point(568, 300);
            this.bttBrowser.Name = "bttBrowser";
            this.bttBrowser.Size = new System.Drawing.Size(120, 23);
            this.bttBrowser.TabIndex = 14;
            this.bttBrowser.Text = "Browser...";
            this.bttBrowser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 344);
            this.Controls.Add(this.bttBrowser);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.bttExport);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridStudent);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bttNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView gridStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttExport;
        private System.Windows.Forms.DateTimePicker txtDob;
        private System.Windows.Forms.NumericUpDown txtScore;
        private System.Windows.Forms.Button bttBrowser;
    }
}

