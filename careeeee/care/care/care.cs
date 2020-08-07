using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace care
{
    public partial class care : Form
    {
        public care()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            login loginform = new login();
            loginform.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            adminlog ADMINPASS = new adminlog();
            ADMINPASS.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME.SelectedTab = tabPage3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            HOME.SelectedTab = tabPage6;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            HOME.SelectedTab = tabPage7;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            daily dailydetails = new daily();
            dailydetails.Visible = true;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Cheq cheqdetails = new Cheq();
            cheqdetails.Visible = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buyer BUYdetails = new buyer();
            BUYdetails.Visible = true;
        }

        private void care_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cheq cheqdetails = new Cheq();
            cheqdetails.Visible = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
