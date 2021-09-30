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
    public partial class deposite : Form
    {
        public deposite()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
        string accc = login.User;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhay\Documents\Atm_db.mdf;Integrated Security=True;Connect Timeout=30");
        int oldbalance, newbalance;
        
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (amounttb.Text == "" || Convert.ToInt32(amounttb.Text) <= 0)
            {
                MessageBox.Show("Please Enter the amount...");
            }
            
            else
            {
                try
                {
                    newbalance = oldbalance + Convert.ToInt32(amounttb.Text);
                    Con.Open();
                    string Query = "update Account_Tbl set Balance = '" + newbalance + "' where AccNum = '" + accc + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deposited Rs." + amounttb.Text + " in your account.");
                    clear();
                    Con.Close();
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        string accnt = login.User;

        private void deposite_Load(object sender, EventArgs e)
        {
            getBalance();
        }
        public void clear()
        {
            amounttb.Text = "";
        }

        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account_Tbl where AccNum = '" + accnt + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
    }
}
