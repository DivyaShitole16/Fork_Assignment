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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGM_Record_System_DB;Integrated Security=True");

        void Con_Open()
        {

            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {

            if (Con.State != ConnectionState.Open)
            {
                Con.Close();
            }
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }

        }
        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = " Select Count(*)  From Student";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Roll_No) From Student";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }
            Con_Close();
            return Cnt;
        }
        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());

            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text = " 01/06/2007";
            cmb_Course.SelectedIndex = -1;

        }
        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Shared_Class.Username;
            Clear_Controls();
            tb_Roll_No.Focus();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            {
                if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
                {
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "Insert Into Student(Roll_No,Name,DOB,Mobile_No,Course) Values(@RollNo,@Nm,@DOB,@MNo,@Course)";

                    Cmd.Parameters.Add("RollNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                    Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                    Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                    Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                    Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Controls();

                }
                else
                {
                    MessageBox.Show("Fill All Field Compulsory  ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                Con.Close();

            }
        }
        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
            obj.Show();
            this.Hide();

        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_Student_List obj = new frm_View_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Shour Want To Log Out???", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Res == DialogResult.Yes)
            {
                frm_Student_App_Login obj = new frm_Student_App_Login();
                obj.Show();
                this.Hide();
            }
        }
        
    }
}
