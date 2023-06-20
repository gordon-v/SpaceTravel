using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceTravel
{
    public partial class SpaceTravel : Form
    {
        Scene scene;
        public SpaceTravel()
        {
            InitializeComponent();
            DoubleBuffered = true;

            scene = new Scene(Width, Height);
            scene.Speed = 1;
            L_Cruise.ForeColor = Color.DarkOrange;
            scene.GenerateStars(300);

            timer1.Start();
            
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
    }
}
