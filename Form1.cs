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
        bool flag = true;
        bool flickerFlag = true;

        Scene scene;
        int imageCount;
        int planetCount = 0;

        long dist;
        long passedKm;
        
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
            dist = scene.Distance[0];
            passedKm = 0;
            L_DistanceNum.Text = $"{dist}km";

            

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
            if (scene.started)
            {
                if (scene.Speed == 1)
                {           
                    passedKm += 11;
                }
                else if(scene.Speed == 10)
                {
                    passedKm += 11111;
                }
                else
                {
                    passedKm += 111111;
                }
                if (passedKm >= dist)
                {
                    passedKm = dist;
                    L_DistanceNum.Text = $"{dist-passedKm}km";
                    PB_Distance.Value = 100;
                    scene.started = false;
                    L_START.Text = "START";
                    MessageBox.Show("Arrived");
                    return;
                    
                }

                PB_Distance.Value = (int) Scene.relativeMap(passedKm, 0, dist, 0, 100);
                L_DistanceNum.Text = $"{dist-passedKm}km";
            }
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

        private bool checkStarted()
        {
            if (scene.started)
            {
                EP_DestinationSwitch.SetError(L_Destination, "Cannot switch destination while moving!");
                return false;
            }
            else
            {
                EP_DestinationSwitch.Clear();
            }
            return true;
        }
        private void L_RightArrow_Click(object sender, EventArgs e)
        {
            if (checkStarted())
            {
                passedKm = 0;
                PB_Distance.Value = 0;
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
            

        }

        private void L_LeftArrow_Click(object sender, EventArgs e)
        {
            if (checkStarted())
            {
                passedKm = 0;
                PB_Distance.Value = 0;
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
            
        }

        private void UpdateLabels()
        {
            dist = scene.Distance[planetCount];
            PB_Planet.Image = IL_Planets.Images[planetCount];
            L_DistanceNum.Text = $"{dist}km";
            L_PlanetName.Text = $"Name: {scene.Planets[planetCount]}";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void L_PlanetName_Click(object sender, EventArgs e)
        {

        }

        private void L_START_Click(object sender, EventArgs e)
        {
            if (!scene.started)
            {
                scene.started = true;
                L_START.Text = "STOP";
                L_START.ForeColor = Color.DarkRed;
            }
            else
            {
                scene.started = false;
                L_START.Text = "START";
                L_START.ForeColor = Color.MediumSeaGreen;
            }
            
        }

        private void T_BlinkingStart_Tick(object sender, EventArgs e)
        {
            if (!scene.started) {
                if (flag)
                {
                    L_START.ForeColor = Color.LawnGreen;
                    flag = false;
                }
                else
                {
                    L_START.ForeColor = Color.MediumSeaGreen;
                    flag = true;
                }
            }
        }

        private void SpaceTravel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                Scene.UP = 1;
               
            }else if (e.KeyCode == Keys.S)
            {
                Scene.DOWN = -1;
            }
            else if (e.KeyCode == Keys.D)
            {
                Scene.RIGHT = -1;
            }
            else if (e.KeyCode == Keys.A)
            {
                Scene.LEFT = 1;
            }
        }

        private void SpaceTravel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {

                Scene.UP = 0;
            }
            else if (e.KeyCode == Keys.S)
            {
                Scene.DOWN = 0;
            }
            else if (e.KeyCode == Keys.D)
            {
                Scene.RIGHT = 0;
            }
            else if (e.KeyCode == Keys.A)
            {
                Scene.LEFT = 0;
            }
        }
    }
}
