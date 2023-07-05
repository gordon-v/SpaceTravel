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

        float pX;
        float pY;
        public float pZ { set; get; }

        int MOD;
        public float XModifier { set; get; }
        public float YModifier { set; get; }
        public float radius { set; get; }

        private int speed { set; get; } = 10;

        private Random r;

        public Star(int Width, int Height, Random rand)
        {
            this.Width = Width;
            this.Height = Height;

            r = rand;

            
            Reset();
        }
        public void Reset()
        {
            X = r.Next(-Width, Width);
            Y = r.Next(-Height, Height);
            Z = r.Next(0, Width);
            pX = X;
            pY = Y;
            pZ = Z;
        }
        public void Update()
        {
            Z -= speed;
            if (Z <= 0)
            {
                this.Reset();
            }
        }
        public void SetModifiers(int Speed)
        {
            
            if(Speed == 1)
            {
                MOD = 2000;
            }
            else if (Speed == 10)
            {
                MOD = 5000;
            }
            else
            {
                MOD = 12000;
            }
            YModifier = (Scene.UP / Z * MOD) + (Scene.DOWN / Z * MOD);
            XModifier = (Scene.LEFT / Z * MOD) + (Scene.RIGHT / Z * MOD);
        }
        public void Draw(Graphics g, int Speed, bool started)
        {
            SetModifiers(Speed);

            this.speed = Speed;

            Brush b = new SolidBrush(Scene.starColor);
            Pen p = new Pen(Color.White);   
           
            if (started)
            {
                this.Update();
            }
            

            float offsetX = (float) Scene.relativeMap((float) X / Z ,0, 1, Scene.center.X, Width) + XModifier;
            float offsetY = (float) Scene.relativeMap((float) Y / Z ,0, 1, Scene.center.Y, Height)+ YModifier;
            

            radius = (float)Scene.relativeMap(Z, 0, Width, 4, 0); //make the radius get bigger as the stars get closer

            g.FillEllipse(b, offsetX - radius, offsetY - radius, radius * 2, radius * 2);
            
            pX = (float)Scene.relativeMap((float)X / pZ, 0, 1, Scene.center.X, Width);
            pY = (float)Scene.relativeMap((float) Y / pZ, 0, 1, Scene.center.Y, Height);
            
            if(pZ!=Z)
                g.DrawLine(p, pX, pY, offsetX, offsetY);
            pZ = Z;
            g.Flush();


        }
    }
}
