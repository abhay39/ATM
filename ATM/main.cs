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
    public partial class main : Form
    {
        int startpoint = 0;
        public main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressbar.Value = startpoint;
            sp.Text ="Loading "+startpoint+"%";
            if (progressbar.Value == 100)
            {
                progressbar.Value = 0;
                timer1.Stop();
                this.Hide();
                card_insert ci = new card_insert();
                ci.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
