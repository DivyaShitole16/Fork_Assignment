﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YC_Student_Management_System
{
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }
      private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'yC_Student_Management_System_DBDataSet2.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.yC_Student_Management_System_DBDataSet2.Student_Details);

        }
    }
}
