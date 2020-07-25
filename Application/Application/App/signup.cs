using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = string.Empty; 
            if(male_btn.Checked)
    {
                gender = "M";
            }
            else if (fmale_btn.Checked)
            {
                gender = "F";
            }
            string pass;
            if (pass_txt.Text==repass_txt.Text)
            {
                pass = pass_txt.Text;
            }
            else
            {
                MessageBox.Show("Re-enter Password");
            }
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\C# assign\C-Application\Application\Application\signupdb.mdf;Integrated Security = True; Connect Timeout = 30");
            string qry = "Insert into signup(Full_name,Username,Nic,Address,contact_no,password,Email,Job_title,gender) values('@Full_name','@Username','@Nic','@Address','@contact_no','@password','@Email','@Job_title','@gender')";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Full_name", fnam_txt.Text);
            cmd.Parameters.AddWithValue("@Username", user_txt.Text);
            cmd.Parameters.AddWithValue("@Nic", nic_txt.Text);
            cmd.Parameters.AddWithValue("@Address", add_txt.Text);
            cmd.Parameters.AddWithValue("@contact_no", con_txt.Text);
            cmd.Parameters.AddWithValue("@password", pass_txt.Text);
            cmd.Parameters.AddWithValue("@Email", email_txt.Text);
            cmd.Parameters.AddWithValue("@Job_title", jobT_txt.Text);
            cmd.Parameters.AddWithValue("@gender", gender);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
