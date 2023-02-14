using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace File_Upload_Assignment
{
    public partial class frm_Upload_File : Form
    {
        public frm_Upload_File()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=File_Upload_Assignment_DB;Integrated Security=True");

        private void btn_Browse_File_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select File to upload.";
            openFileDialog1.Filter = "Select valid Document(*.pdf;*.xlsx; *.html) |*.pdf; *.docx; *.xlsx;*.html";

            openFileDialog1.FilterIndex = 1;

            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        String path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        lbl_Directory_Path.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Upload_Document_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please Select a valid document");
                }
                else
                {
                    Con.Open();
                    SqlCommand Cmd = new SqlCommand("Insert into Doc(document)values('\\Document\\" + filename + "')", Con);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Document\\" + filename);
                    Cmd.ExecuteNonQuery();

                    Con.Close();
                    MessageBox.Show("Document Upload");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
