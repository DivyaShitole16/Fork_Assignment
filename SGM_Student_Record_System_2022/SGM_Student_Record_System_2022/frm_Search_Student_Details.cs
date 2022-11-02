using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_Student_Record_System_2022
{
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGM_Record_System_DB;Integrated Security=True");

        void Con_Open()
        {

            if (Con.State !=ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {

            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Clear_Controls()
        {
            tb_Roll_No.Clear();

            tb_Name.Clear();
            dtp_DOB.Text = " 01/06/2007";
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;

        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();

        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_Student_List obj = new frm_View_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select *from Student where Roll_No=@RNo", Con);

            Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                dtp_DOB.Text = (Dr["DOB"].ToString());
                cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
            }
            else
            {
                MessageBox.Show("No Record Found", "Invalid Roll No");
                tb_Roll_No.Clear();
            }
            Con_Close();
        }
        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Shared_Class.Username;
            tb_Roll_No.Focus();
            tb_Name.Enabled = false;
            tb_Mobile_No.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Course.Enabled = false;

        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
             DialogResult Res = MessageBox.Show("Are You Shoure Want To Log Out???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (Res == DialogResult.Yes)
             {
                 frm_Student_App_Login obj = new frm_Student_App_Login();
                 obj.Show();
                 this.Hide();
             }
        }
    }
}
