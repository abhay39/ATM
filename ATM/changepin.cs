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

namespace ATM
{
    public partial class changepin : Form
    {
        public changepin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhay\Documents\Atm_db.mdf;Integrated Security=True;Connect Timeout=30");
        string accnt = login.User;
        public void clear()
        {
            newpin.Text = "";
            cnfpin.Text = "";
        }
        private void changebtn_Click(object sender, EventArgs e)
        {
            if (newpin.Text == "" || cnfpin.Text=="")
            {
                MessageBox.Show("Please Enter the Pin and Confirm Pin...");
            }
            if (newpin.Text !=cnfpin.Text)
            {
                MessageBox.Show("Pin and Confirm Pin is not Correct.");
            }


            else
            {
                try
                {
                    Con.Open();
                    string Query = "update Account_Tbl set Pin = '" + cnfpin.Text + "' where AccNum = '" + accnt + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Change the Pin Which is " + cnfpin.Text + ".");
                    clear();
                    login l = new login();
                    l.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
