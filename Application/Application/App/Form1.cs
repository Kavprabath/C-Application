﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pass, user;
            pass = textBox2.Text;
            user = textBox1.Text;
            if ((user =="care") && (pass =="admin"))
            {
                Form2 mainform = new Form2();
                mainform.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 ADMINPASS = new Form3();
            ADMINPASS.Visible = true;
            this.Hide();

        }
    }
}