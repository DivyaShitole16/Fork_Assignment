namespace YC_Student_Management_System
{
    partial class frm_Add_New_Course
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
            this.lbl_Add_New_Course = new System.Windows.Forms.Label();
            this.lbl_Course_ID = new System.Windows.Forms.Label();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.tb_Course_ID = new System.Windows.Forms.TextBox();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Course
            // 
            this.lbl_Add_New_Course.AutoSize = true;
            this.lbl_Add_New_Course.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Add_New_Course.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Course.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_New_Course.Location = new System.Drawing.Point(281, 26);
            this.lbl_Add_New_Course.Name = "lbl_Add_New_Course";
            this.lbl_Add_New_Course.Size = new System.Drawing.Size(528, 77);
            this.lbl_Add_New_Course.TabIndex = 0;
            this.lbl_Add_New_Course.Text = "Add New Course";
            // 
            // lbl_Course_ID
            // 
            this.lbl_Course_ID.AutoSize = true;
            this.lbl_Course_ID.BackColor = System.Drawing.Color.Linen;
            this.lbl_Course_ID.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_ID.Location = new System.Drawing.Point(186, 197);
            this.lbl_Course_ID.Name = "lbl_Course_ID";
            this.lbl_Course_ID.Size = new System.Drawing.Size(186, 43);
            this.lbl_Course_ID.TabIndex = 1;
            this.lbl_Course_ID.Text = "Course ID";
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.BackColor = System.Drawing.Color.Linen;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.Location = new System.Drawing.Point(186, 357);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(238, 43);
            this.lbl_Course_Name.TabIndex = 2;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // tb_Course_ID
            // 
            this.tb_Course_ID.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_ID.Location = new System.Drawing.Point(562, 194);
            this.tb_Course_ID.MaxLength = 10;
            this.tb_Course_ID.Name = "tb_Course_ID";
            this.tb_Course_ID.Size = new System.Drawing.Size(411, 50);
            this.tb_Course_ID.TabIndex = 3;
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(562, 350);
            this.tb_Course_Name.MaxLength = 50;
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(411, 50);
            this.tb_Course_Name.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_Save.Location = new System.Drawing.Point(394, 513);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(192, 65);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_New_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_ID);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_ID);
            this.Controls.Add(this.lbl_Add_New_Course);
            this.Name = "frm_Add_New_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Course";
            this.Load += new System.EventHandler(this.frm_Add_New_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Course;
        private System.Windows.Forms.Label lbl_Course_ID;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_ID;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.Button btn_Save;
    }
}