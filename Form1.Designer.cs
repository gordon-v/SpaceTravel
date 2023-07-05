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
            this.PB_Distance = new System.Windows.Forms.ProgressBar();
            this.L_Destination = new System.Windows.Forms.Label();
            this.IL_Planets = new System.Windows.Forms.ImageList(this.components);
            this.PB_Planet = new System.Windows.Forms.PictureBox();
            this.L_RightArrow = new System.Windows.Forms.Label();
            this.L_LeftArrow = new System.Windows.Forms.Label();
            this.L_PlanetName = new System.Windows.Forms.Label();
            this.L_Distance = new System.Windows.Forms.Label();
            this.L_DistanceNum = new System.Windows.Forms.Label();
            this.L_START = new System.Windows.Forms.Label();
            this.T_BlinkingStart = new System.Windows.Forms.Timer(this.components);
            this.EP_DestinationSwitch = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Planet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_DestinationSwitch)).BeginInit();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // L_speed
            // 
            this.L_speed.AutoSize = true;
            this.L_speed.BackColor = System.Drawing.Color.Black;
            this.L_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_speed.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_speed.Location = new System.Drawing.Point(702, 829);
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
            // PB_Distance
            // 
            this.PB_Distance.BackColor = System.Drawing.Color.IndianRed;
            this.PB_Distance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PB_Distance.Location = new System.Drawing.Point(756, 752);
            this.PB_Distance.Name = "PB_Distance";
            this.PB_Distance.Size = new System.Drawing.Size(157, 10);
            this.PB_Distance.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_Distance.TabIndex = 6;
            // 
            // L_Destination
            // 
            this.L_Destination.AutoSize = true;
            this.L_Destination.BackColor = System.Drawing.Color.Black;
            this.L_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Destination.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_Destination.Location = new System.Drawing.Point(435, 829);
            this.L_Destination.Name = "L_Destination";
            this.L_Destination.Size = new System.Drawing.Size(182, 29);
            this.L_Destination.TabIndex = 7;
            this.L_Destination.Text = "DESTINATION:";
            // 
            // IL_Planets
            // 
            this.IL_Planets.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_Planets.ImageStream")));
            this.IL_Planets.TransparentColor = System.Drawing.Color.Transparent;
            this.IL_Planets.Images.SetKeyName(0, "jupiter.png");
            this.IL_Planets.Images.SetKeyName(1, "moon.png");
            this.IL_Planets.Images.SetKeyName(2, "neptune.png");
            // 
            // PB_Planet
            // 
            this.PB_Planet.BackColor = System.Drawing.Color.Black;
            this.PB_Planet.Location = new System.Drawing.Point(1072, 866);
            this.PB_Planet.Name = "PB_Planet";
            this.PB_Planet.Size = new System.Drawing.Size(100, 100);
            this.PB_Planet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Planet.TabIndex = 11;
            this.PB_Planet.TabStop = false;
            // 
            // L_RightArrow
            // 
            this.L_RightArrow.AutoSize = true;
            this.L_RightArrow.BackColor = System.Drawing.Color.Black;
            this.L_RightArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_RightArrow.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_RightArrow.Location = new System.Drawing.Point(640, 916);
            this.L_RightArrow.Name = "L_RightArrow";
            this.L_RightArrow.Size = new System.Drawing.Size(27, 29);
            this.L_RightArrow.TabIndex = 12;
            this.L_RightArrow.Text = ">";
            this.L_RightArrow.Click += new System.EventHandler(this.L_RightArrow_Click);
            // 
            // L_LeftArrow
            // 
            this.L_LeftArrow.AutoSize = true;
            this.L_LeftArrow.BackColor = System.Drawing.Color.Black;
            this.L_LeftArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_LeftArrow.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_LeftArrow.Location = new System.Drawing.Point(392, 916);
            this.L_LeftArrow.Name = "L_LeftArrow";
            this.L_LeftArrow.Size = new System.Drawing.Size(27, 29);
            this.L_LeftArrow.TabIndex = 13;
            this.L_LeftArrow.Text = "<";
            this.L_LeftArrow.Click += new System.EventHandler(this.L_LeftArrow_Click);
            // 
            // L_PlanetName
            // 
            this.L_PlanetName.AutoSize = true;
            this.L_PlanetName.BackColor = System.Drawing.Color.Black;
            this.L_PlanetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PlanetName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_PlanetName.Location = new System.Drawing.Point(435, 881);
            this.L_PlanetName.Name = "L_PlanetName";
            this.L_PlanetName.Size = new System.Drawing.Size(84, 29);
            this.L_PlanetName.TabIndex = 14;
            this.L_PlanetName.Text = "Name:";
            this.L_PlanetName.Click += new System.EventHandler(this.L_PlanetName_Click);
            // 
            // L_Distance
            // 
            this.L_Distance.AutoSize = true;
            this.L_Distance.BackColor = System.Drawing.Color.Black;
            this.L_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Distance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_Distance.Location = new System.Drawing.Point(435, 919);
            this.L_Distance.Name = "L_Distance";
            this.L_Distance.Size = new System.Drawing.Size(112, 29);
            this.L_Distance.TabIndex = 15;
            this.L_Distance.Text = "Distance:";
            // 
            // L_DistanceNum
            // 
            this.L_DistanceNum.AutoSize = true;
            this.L_DistanceNum.BackColor = System.Drawing.Color.Black;
            this.L_DistanceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_DistanceNum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_DistanceNum.Location = new System.Drawing.Point(435, 957);
            this.L_DistanceNum.Name = "L_DistanceNum";
            this.L_DistanceNum.Size = new System.Drawing.Size(45, 29);
            this.L_DistanceNum.TabIndex = 16;
            this.L_DistanceNum.Text = "km";
            // 
            // L_START
            // 
            this.L_START.AutoSize = true;
            this.L_START.BackColor = System.Drawing.Color.Black;
            this.L_START.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_START.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.L_START.Location = new System.Drawing.Point(860, 829);
            this.L_START.Name = "L_START";
            this.L_START.Size = new System.Drawing.Size(93, 29);
            this.L_START.TabIndex = 17;
            this.L_START.Text = "START";
            this.L_START.Click += new System.EventHandler(this.L_START_Click);
            // 
            // T_BlinkingStart
            // 
            this.T_BlinkingStart.Enabled = true;
            this.T_BlinkingStart.Interval = 700;
            this.T_BlinkingStart.Tick += new System.EventHandler(this.T_BlinkingStart_Tick);
            // 
            // EP_DestinationSwitch
            // 
            this.EP_DestinationSwitch.ContainerControl = this;
            // 
            // SpaceTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 1053);
            this.Controls.Add(this.L_START);
            this.Controls.Add(this.L_DistanceNum);
            this.Controls.Add(this.L_Distance);
            this.Controls.Add(this.L_PlanetName);
            this.Controls.Add(this.L_LeftArrow);
            this.Controls.Add(this.L_RightArrow);
            this.Controls.Add(this.PB_Planet);
            this.Controls.Add(this.L_Destination);
            this.Controls.Add(this.PB_Distance);
            this.Controls.Add(this.L_Lightspeed);
            this.Controls.Add(this.L_Warp);
            this.Controls.Add(this.L_Cruise);
            this.Controls.Add(this.L_speed);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "SpaceTravel";
            this.Text = "SpaceTravel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceTravel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceTravel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Planet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_DestinationSwitch)).EndInit();
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
        private System.Windows.Forms.ProgressBar PB_Distance;
        private System.Windows.Forms.Label L_Destination;
        private System.Windows.Forms.ImageList IL_Planets;
        private System.Windows.Forms.PictureBox PB_Planet;
        private System.Windows.Forms.Label L_RightArrow;
        private System.Windows.Forms.Label L_LeftArrow;
        private System.Windows.Forms.Label L_PlanetName;
        private System.Windows.Forms.Label L_Distance;
        private System.Windows.Forms.Label L_DistanceNum;
        private System.Windows.Forms.Label L_START;
        private System.Windows.Forms.Timer T_BlinkingStart;
        private System.Windows.Forms.ErrorProvider EP_DestinationSwitch;
    }
}

