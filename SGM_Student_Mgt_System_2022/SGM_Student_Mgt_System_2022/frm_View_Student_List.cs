using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Student_Mgt_System_2022
{
    public partial class frm_View_Student_List : Form
    {
        public frm_View_Student_List()
        {
            InitializeComponent();
        }

        private void frm_View_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet.SGM_App_Details' table. You can move, or remove it, as needed.
            this.sGM_App_DetailsTableAdapter.Fill(this.student_Management_System_DBDataSet.SGM_App_Details);

        }

      


        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_student obj = new frm_Add_New_student();
            obj .Show();
            this.Hide();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Shoure Want To Log Out???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Res == DialogResult.Yes)
            {
                frm_SGM_Login obj = new frm_SGM_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            Frm_Search_Student_Details obj = new Frm_Search_Student_Details();
            obj.Show();
            this.Hide();
        }
    }
}
