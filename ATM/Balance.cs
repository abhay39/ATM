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
    public partial class Balance : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhay\Documents\Atm_db.mdf;Integrated Security=True;Connect Timeout=30");
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account_Tbl where AccNum = '" + acc.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            blc.Text = "Rs."+dt.Rows[0][0].ToString();
            Con.Close();
        }
        public Balance()
        {
            InitializeComponent();
            acc.Text = login.User;
            getBalance();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
