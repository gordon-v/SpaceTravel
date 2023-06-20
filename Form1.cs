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
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            scene = new Scene(Width, Height);
            scene.GenerateStars(100);

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
    }
}
