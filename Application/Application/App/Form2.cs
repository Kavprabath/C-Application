using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 ADMINPASS = new Form3();
            ADMINPASS.Visible = true;
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loginform = new Form1();
            loginform.Visible = true;
        }
    }
}
