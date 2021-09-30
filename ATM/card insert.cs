using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ATM
{
    public partial class card_insert : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer("sound.wav");
        public card_insert()
        {
            InitializeComponent();
        }

        int startpoint;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressbar.Value = startpoint;
            if (progressbar.Value == 100)
            {
                progressbar.Value = 0;

                timer1.Stop();
                this.Hide();
                login mylogin = new login();
                mylogin.Show();
            }
        }

        private void card_insert_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            soundPlayer.Play();
        }
    }
}
