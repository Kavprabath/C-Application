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
    public partial class adminlog : Form
    {
        public adminlog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String adpass;
            adpass = textBox1.Text;
            
            if (adpass == "Admin@123")
            { 
                admin ADMINform = new admin();
                 ADMINform.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Admin Password");
            }
        }
    }
}
