using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YC_Student_Management_System
{
    public partial class MDI_YC_App : Form
    {
        private int childFormNumber = 0;

        public MDI_YC_App()
        {
            InitializeComponent();
        }

        private void MDI_YC_App_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome" + Shared_Class.Username;
            if (Shared_Class.Username != "Admin")
            {
                courseToolStripMenuItem.Visible = false;
                userManagementToolStripMenuItem.Visible = false;
                addCourseToolStripMenuItem.Visible = false;
            }

        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddNewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details Obj = new frm_Add_Student_Details();

            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Obj.Text = String.Empty;
        }

        private void UpdateStudentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details Obj = new frm_Update_Student_Details();

            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Obj.Text = String.Empty;
        }

        private void SearchStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details Obj = new frm_Search_Student_Details();

            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Obj.Text = String.Empty;
        }

        private void viewAllStudentListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details Obj = new frm_View_Student_Details();
            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Obj.Text = String.Empty;
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YC_Student_Management_System.frm_Add_New_Course Obj = new YC_Student_Management_System.frm_Add_New_Course();

            Obj.MdiParent = this;
            Obj.Show();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_YC_App_Login Obj = new frm_YC_App_Login();
                Obj.Show();
                this.Hide();
            }
        }
       
    }
}
