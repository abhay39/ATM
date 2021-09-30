using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            ACCOUNT.Text = "Account Number : " + login.User;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            deposite d = new deposite();
            d.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            fastcash d = new fastcash();
            d.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            changepin d = new changepin();
            d.Show();
            this.Hide();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            withdraw d = new withdraw();
            d.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ministatement d = new ministatement();
            d.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Balance d= new Balance();
            d.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
