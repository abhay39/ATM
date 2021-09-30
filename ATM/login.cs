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
using Microsoft.TeamFoundation.Dashboards.WebApi;

namespace ATM
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhay\Documents\Atm_db.mdf;Integrated Security=True;Connect Timeout=30");
        public static String User;

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (acnumber.Text == "" || pin.Text == "")
            {
                MessageBox.Show("Missing Information..");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Account_Tbl where AccNum = '" + acnumber.Text + "' and Pin='" + pin.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = acnumber.Text;
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!!");
                    acnumber.Text = "";
                    pin.Text = " ";
                }
                Con.Close();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Create_Account ca = new Create_Account();
            ca.Show();
        }
    }
}
