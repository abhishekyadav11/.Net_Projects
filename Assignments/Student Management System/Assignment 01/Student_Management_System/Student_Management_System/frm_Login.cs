﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((tb_Username.Text == "Admin" && tb_Password.Text == "a123")||(tb_Username.Text == "A" && tb_Password.Text == "a"))
            {
                MessageBox.Show("Login Successfull...!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Student Obj = new frm_Add_New_Student();

                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username Or Password.","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }


        
    }
}
