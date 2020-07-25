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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            adminlog ADMINPASS = new adminlog();
            ADMINPASS.Visible = true;
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            login loginform = new login();
            loginform.Visible = true;
        }
    }
}
