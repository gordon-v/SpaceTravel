namespace SpaceTravel
{
    partial class SpaceTravel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceTravel));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_speed = new System.Windows.Forms.Label();
            this.L_Cruise = new System.Windows.Forms.Label();
            this.L_Warp = new System.Windows.Forms.Label();
            this.L_Lightspeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-180, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2030, 1388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // L_speed
            // 
            this.L_speed.AutoSize = true;
            this.L_speed.BackColor = System.Drawing.Color.Black;
            this.L_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_speed.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_speed.Location = new System.Drawing.Point(709, 829);
            this.L_speed.Name = "L_speed";
            this.L_speed.Size = new System.Drawing.Size(100, 29);
            this.L_speed.TabIndex = 2;
            this.L_speed.Text = "SPEED:";
            // 
            // L_Cruise
            // 
            this.L_Cruise.AutoSize = true;
            this.L_Cruise.BackColor = System.Drawing.Color.Black;
            this.L_Cruise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cruise.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_Cruise.Location = new System.Drawing.Point(714, 884);
            this.L_Cruise.Name = "L_Cruise";
            this.L_Cruise.Size = new System.Drawing.Size(99, 26);
            this.L_Cruise.TabIndex = 3;
            this.L_Cruise.Text = "1. Cruise";
            this.L_Cruise.Click += new System.EventHandler(this.L_Cruise_Click);
            // 
            // L_Warp
            // 
            this.L_Warp.AutoSize = true;
            this.L_Warp.BackColor = System.Drawing.Color.Black;
            this.L_Warp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Warp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_Warp.Location = new System.Drawing.Point(714, 919);
            this.L_Warp.Name = "L_Warp";
            this.L_Warp.Size = new System.Drawing.Size(88, 26);
            this.L_Warp.TabIndex = 4;
            this.L_Warp.Text = "2. Warp";
            this.L_Warp.Click += new System.EventHandler(this.L_Warp_Click);
            // 
            // L_Lightspeed
            // 
            this.L_Lightspeed.AutoSize = true;
            this.L_Lightspeed.BackColor = System.Drawing.Color.Black;
            this.L_Lightspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Lightspeed.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_Lightspeed.Location = new System.Drawing.Point(714, 957);
            this.L_Lightspeed.Name = "L_Lightspeed";
            this.L_Lightspeed.Size = new System.Drawing.Size(142, 26);
            this.L_Lightspeed.TabIndex = 5;
            this.L_Lightspeed.Text = "3. Lightspeed";
            this.L_Lightspeed.Click += new System.EventHandler(this.L_Lightspeed_Click);
            // 
            // SpaceTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 1053);
            this.Controls.Add(this.L_Lightspeed);
            this.Controls.Add(this.L_Warp);
            this.Controls.Add(this.L_Cruise);
            this.Controls.Add(this.L_speed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SpaceTravel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_speed;
        private System.Windows.Forms.Label L_Cruise;
        private System.Windows.Forms.Label L_Warp;
        private System.Windows.Forms.Label L_Lightspeed;
    }
}

