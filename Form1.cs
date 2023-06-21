using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SpaceTravel
{
    public partial class SpaceTravel : Form
    {
        Scene scene;
        int imageCount;
        int planetCount = 0;
        long dist;
        
        public SpaceTravel()
        {
            InitializeComponent();
            DoubleBuffered = true;

            scene = new Scene(Width, Height);
            scene.Speed = 1;
            L_Cruise.ForeColor = Color.DarkOrange;
            imageCount = IL_Planets.Images.Count;
            PB_Planet.Image = IL_Planets.Images[planetCount];
            L_PlanetName.Text = $"Name: {scene.Planets[0]}";
            L_DistanceNum.Text = $"{scene.Distance[0]}km";

            dist = scene.Distance[0];

            scene.GenerateStars(300);

            timer1.Start();

            PB_Distance.ForeColor = Color.DarkOrange;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawScene(e.Graphics);
            
            
        }

        private void L_Cruise_Click(object sender, EventArgs e)
        {
            L_Cruise.ForeColor= Color.DarkOrange;
            L_Warp.ForeColor = Color.DodgerBlue;
            L_Lightspeed.ForeColor = Color.DodgerBlue;

            scene.Speed= 1;
        }

        private void L_Warp_Click(object sender, EventArgs e)
        {
            L_Cruise.ForeColor = Color.DodgerBlue;
            L_Warp.ForeColor = Color.DarkOrange;
            L_Lightspeed.ForeColor = Color.DodgerBlue;

            scene.Speed= 10;
        }

        private void L_Lightspeed_Click(object sender, EventArgs e)
        {
            L_Cruise.ForeColor = Color.DodgerBlue;
            L_Warp.ForeColor = Color.DodgerBlue;
            L_Lightspeed.ForeColor = Color.DarkOrange;

            scene.Speed= 100;
        }


        private void L_RightArrow_Click(object sender, EventArgs e)
        {
            if (planetCount < imageCount - 1)
            {
                planetCount++;
            }
            else
            {
                planetCount = 0;
            }
            UpdateLabels();

        }

        private void L_LeftArrow_Click(object sender, EventArgs e)
        {
            if (planetCount > 0)
            {
                planetCount--;
            }
            else
            {
                planetCount = imageCount - 1;
            }
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            PB_Planet.Image = IL_Planets.Images[planetCount];
            L_DistanceNum.Text = $"{scene.Distance[planetCount]}km";
            L_PlanetName.Text = $"Name: {scene.Planets[planetCount]}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void L_PlanetName_Click(object sender, EventArgs e)
        {

        }
    }
}
