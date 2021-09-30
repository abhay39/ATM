
namespace ATM
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.acclbl = new System.Windows.Forms.Label();
            this.pinlbl = new System.Windows.Forms.Label();
            this.acnumber = new ns1.BunifuMaterialTextbox();
            this.pin = new ns1.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // acclbl
            // 
            this.acclbl.AutoSize = true;
            this.acclbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acclbl.ForeColor = System.Drawing.Color.Blue;
            this.acclbl.Location = new System.Drawing.Point(17, 280);
            this.acclbl.Name = "acclbl";
            this.acclbl.Size = new System.Drawing.Size(98, 27);
            this.acclbl.TabIndex = 1;
            this.acclbl.Text = "Acc No:-";
            // 
            // pinlbl
            // 
            this.pinlbl.AutoSize = true;
            this.pinlbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinlbl.ForeColor = System.Drawing.Color.Blue;
            this.pinlbl.Location = new System.Drawing.Point(17, 391);
            this.pinlbl.Name = "pinlbl";
            this.pinlbl.Size = new System.Drawing.Size(59, 27);
            this.pinlbl.TabIndex = 2;
            this.pinlbl.Text = "Pin:-";
            this.pinlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // acnumber
            // 
            this.acnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.acnumber.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.acnumber.HintForeColor = System.Drawing.Color.Empty;
            this.acnumber.HintText = "";
            this.acnumber.isPassword = false;
            this.acnumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.acnumber.LineIdleColor = System.Drawing.Color.Gray;
            this.acnumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.acnumber.LineThickness = 4;
            this.acnumber.Location = new System.Drawing.Point(124, 250);
            this.acnumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.acnumber.Name = "acnumber";
            this.acnumber.Size = new System.Drawing.Size(274, 57);
            this.acnumber.TabIndex = 3;
            this.acnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pin
            // 
            this.pin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pin.HintForeColor = System.Drawing.Color.Empty;
            this.pin.HintText = "";
            this.pin.isPassword = true;
            this.pin.LineFocusedColor = System.Drawing.Color.Blue;
            this.pin.LineIdleColor = System.Drawing.Color.Gray;
            this.pin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pin.LineThickness = 4;
            this.pin.Location = new System.Drawing.Point(124, 361);
            this.pin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(274, 57);
            this.pin.TabIndex = 4;
            this.pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(405, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 5;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Navy;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "SignUp";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.IdleBorderThickness = 10;
            this.bunifuThinButton22.IdleCornerRadius = 10;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Navy;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Navy;
            this.bunifuThinButton22.Location = new System.Drawing.Point(247, 441);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(180, 57);
            this.bunifuThinButton22.TabIndex = 7;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 5;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.IdleBorderThickness = 10;
            this.bunifuThinButton21.IdleCornerRadius = 10;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Navy;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Navy;
            this.bunifuThinButton21.Location = new System.Drawing.Point(35, 441);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(180, 57);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(256, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Made By Abhay";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.acnumber);
            this.Controls.Add(this.pinlbl);
            this.Controls.Add(this.acclbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label acclbl;
        private System.Windows.Forms.Label pinlbl;
        private ns1.BunifuMaterialTextbox acnumber;
        private ns1.BunifuMaterialTextbox pin;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label2;
    }
}