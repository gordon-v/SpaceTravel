using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravel
{
    public class Star
    {
        private int Width;
        private int Height;
        public float X { set; get; }
        public float Y { set; get; }
        public float Z { set; get; }
        public float radius { set; get; }

        private Random r;

        public Star(int Width, int Height, Random rand)
        {
            this.Width = Width;
            this.Height = Height;


            r = rand;

            radius = 4;
            Reset();
        }
        public void Reset()
        {
            X = r.Next(0, Width);
            Y = r.Next(0, Height);
            Z = r.Next(0, Width);
        }
        public void Update()
        {
            Z -= 10;
            if (Z <= 0)
            {
                this.Reset();
            }
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.White);

            this.Update();

            float offsetX = 100.0f * (X / Z);
            float offsetY = 100.0f * (Y / Z);
            float scaleZ = 0.0001f * (2000.0f - Z);


            g.FillEllipse(b, X - radius, Y - radius, radius * 2, radius * 2);
            g.Flush();
        }
    }
}
