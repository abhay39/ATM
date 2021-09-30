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
    public partial class fastcash : Form
    {
        public fastcash()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhay\Documents\Atm_db.mdf;Integrated Security=True;Connect Timeout=30");
        int oldbalance, newbalance;
        string accc = login.User;
        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void fastcash_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void rs100brn_Click(object sender, EventArgs e)
        {
            if (oldbalance < 100)
            {
                MessageBox.Show("Amount Cannot be negetive...");
            }
            else
            {
                try
                {
                    newbalance = oldbalance - 100;
                    Con.Open();
                    string Query = "update Account_Tbl set Balance = '" + newbalance + "' where AccNum = '" + accc + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully WithDraw Rs.100 From your account.");
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rs1000btn_Click(object sender, EventArgs e)
        {
            if (oldbalance < 100)
            {
                MessageBox.Show("Amount Cannot be negetive...");
            }
            else
            {
                try
                {
                    newbalance = oldbalance - 1000;
                    Con.Open();
                    string Query = "update Account_Tbl set Balance = '" + newbalance + "' where AccNum = '" + accc + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully WithDraw Rs.1000 From your account.");
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rs500btn_Click(object sender, EventArgs e)
        {
            if (oldbalance < 100)
            {
                MessageBox.Show("Amount Cannot be negetive...");
            }
            else
            {
                try
                {
                    newbalance = oldbalance - 500;
                    Con.Open();
                    string Query = "update Account_Tbl set Balance = '" + newbalance + "' where AccNum = '" + accc + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully WithDraw Rs.500 From your account.");
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rs2000btn_Click(object sender, EventArgs e)
        {
            if (oldbalance < 100)
            {
                MessageBox.Show("Amount Cannot be negetive...");
            }
            else
            {
                try
                {
                    newbalance = oldbalance - 2000;
                    Con.Open();
                    string Query = "update Account_Tbl set Balance = '" + newbalance + "' where AccNum = '" + accc + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully WithDraw Rs.2000 From your account.");
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rs5000btn_Click(object sender, EventArgs e)
        {
            if (oldbalance < 100)
            {
                MessageBox.Show("Amount Cannot be negetive...");
            }
            else
            {
                try
                {
                    newbalance = oldbalance - 5000;
                    Con.Open();
                    string Query = "update Account_Tbl set Balance = '" + newbalance + "' where AccNum = '" + accc + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully WithDraw Rs.5000 From your account.");
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rs10000btn_Click(object sender, EventArgs e)
        {
            if (oldbalance < 100)
            {
                MessageBox.Show("Amount Cannot be negetive...");
            }
            else
            {
                try
                {
                    newbalance = oldbalance - 10000;
                    Con.Open();
                    string Query = "update Account_Tbl set Balance = '" + newbalance + "' where AccNum = '" + accc + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully WithDraw Rs.10000 From your account.");
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account_Tbl where AccNum = '" + accc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            amtlbl.Text = "Amount in Accoount is \n         Rs." + dt.Rows[0][0].ToString();
            Con.Close();
        }
    }
}
