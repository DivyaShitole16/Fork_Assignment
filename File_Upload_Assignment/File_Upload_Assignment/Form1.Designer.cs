namespace File_Upload_Assignment
{
    partial class frm_Upload_File
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
            this.lbl_File_Path = new System.Windows.Forms.Label();
            this.lbl_Directory_Path = new System.Windows.Forms.Label();
            this.btn_Browse_File = new System.Windows.Forms.Button();
            this.btn_Upload_Document = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_File_Path
            // 
            this.lbl_File_Path.AutoSize = true;
            this.lbl_File_Path.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_File_Path.Location = new System.Drawing.Point(96, 61);
            this.lbl_File_Path.Name = "lbl_File_Path";
            this.lbl_File_Path.Size = new System.Drawing.Size(140, 35);
            this.lbl_File_Path.TabIndex = 0;
            this.lbl_File_Path.Text = "File Path:";
            // 
            // lbl_Directory_Path
            // 
            this.lbl_Directory_Path.AutoSize = true;
            this.lbl_Directory_Path.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Directory_Path.ForeColor = System.Drawing.Color.Red;
            this.lbl_Directory_Path.Location = new System.Drawing.Point(344, 64);
            this.lbl_Directory_Path.Name = "lbl_Directory_Path";
            this.lbl_Directory_Path.Size = new System.Drawing.Size(215, 32);
            this.lbl_Directory_Path.TabIndex = 1;
            this.lbl_Directory_Path.Text = "directory Path....";
            // 
            // btn_Browse_File
            // 
            this.btn_Browse_File.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Browse_File.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse_File.Location = new System.Drawing.Point(102, 154);
            this.btn_Browse_File.Name = "btn_Browse_File";
            this.btn_Browse_File.Size = new System.Drawing.Size(229, 71);
            this.btn_Browse_File.TabIndex = 2;
            this.btn_Browse_File.Text = "Browse File";
            this.btn_Browse_File.UseVisualStyleBackColor = false;
            this.btn_Browse_File.Click += new System.EventHandler(this.btn_Browse_File_Click);
            // 
            // btn_Upload_Document
            // 
            this.btn_Upload_Document.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Upload_Document.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload_Document.Location = new System.Drawing.Point(364, 350);
            this.btn_Upload_Document.Name = "btn_Upload_Document";
            this.btn_Upload_Document.Size = new System.Drawing.Size(330, 100);
            this.btn_Upload_Document.TabIndex = 3;
            this.btn_Upload_Document.Text = "Upload Document";
            this.btn_Upload_Document.UseVisualStyleBackColor = false;
            this.btn_Upload_Document.Click += new System.EventHandler(this.btn_Upload_Document_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_Upload_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1163, 550);
            this.Controls.Add(this.btn_Upload_Document);
            this.Controls.Add(this.btn_Browse_File);
            this.Controls.Add(this.lbl_Directory_Path);
            this.Controls.Add(this.lbl_File_Path);
            this.Name = "frm_Upload_File";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_File_Path;
        private System.Windows.Forms.Label lbl_Directory_Path;
        private System.Windows.Forms.Button btn_Browse_File;
        private System.Windows.Forms.Button btn_Upload_Document;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

