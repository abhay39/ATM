﻿using System;
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
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
            getBalance();
            clear();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhay\Documents\Atm_db.mdf;Integrated Security=True;Connect Timeout=30");
        int oldbalance, newbalance;
        string accc = login.User;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (withdrawtb.Text == "" || Convert.ToInt32(withdrawtb.Text) <= 0)
            {
                MessageBox.Show("Please Enter the amount...");
            }
            else
                {
                    try
                    {
                        newbalance = oldbalance - Convert.ToInt32(withdrawtb.Text);
                    
                        Con.Open();
                        string Query = "update Account_Tbl set Balance = '" + newbalance + "' where AccNum = '" + accc + "';";
                        SqlCommand cmd = new SqlCommand(Query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully WithDraw Rs." + withdrawtb.Text + " From your account.");
                        clear();
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
            amtlbl.Text = "Amount in Accoount is Rs." + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void withdraw_Load(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            withdrawtb.Text = "";
        }
    }
    
}
