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
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void clear()
        {
            acctb.Text = "";
            nametb.Text = "";
            fathertb.Text = "";
            blctb.Text = "";
            pintb.Text = "";
            educb.Text = "";
            addresstb.Text = "";
            phonetb.Text = "";
            occtb.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhay\Documents\Atm_db.mdf;Integrated Security=True;Connect Timeout=30");

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (nametb.Text==""||fathertb.Text==""||addresstb.Text==""||phonetb.Text==""||acctb.Text==""||pintb.Text==""||blctb.Text==""||occtb.Text==""||educb.SelectedIndex==-1)
            {
                MessageBox.Show("Missing Informations....");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Account_Tbl(AccNum, Name,FName,DOB,Phone,Address,Education,Occupation,Pin,Balance)values(@AN,@N,@FN,@D,@PH,@A,@E,@O,@P,@B)", Con);
                    cmd.Parameters.AddWithValue("@AN", acctb.Text);
                    cmd.Parameters.AddWithValue("@N", nametb.Text);
                    cmd.Parameters.AddWithValue("@FN", fathertb.Text);
                    cmd.Parameters.AddWithValue("@D", dobdate.Value.Date);
                    cmd.Parameters.AddWithValue("@PH", pintb.Text);
                    cmd.Parameters.AddWithValue("@A", addresstb.Text);
                    cmd.Parameters.AddWithValue("@E", educb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@O", occtb.Text);
                    cmd.Parameters.AddWithValue("@P", pintb.Text);
                    cmd.Parameters.AddWithValue("@B", blctb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added Successfully..");
                    login d = new login();
                    d.Show();
                    this.Hide();
                    Con.Close();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void Create_Account_Load(object sender, EventArgs e)
        {
            clear();
        }
    }
}
