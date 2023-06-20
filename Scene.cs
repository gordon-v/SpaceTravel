using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravel
{
    public class Scene
    {
        int Width;
        int Height;
        public static Point center { set; get; }

        List<Star> stars;
        public Scene(int Width, int Height) { 
            this.Width = Width;
            this.Height = Height;
            center = new Point(Width/2,Height/2);

            stars = new List<Star>();
        }

        public void GenerateStars(int num)
        {
            Random r = new Random();
            for(int i = 0; i < num; i++)
            {
                Star s = new Star(Width, Height,r);
                stars.Add(s);
            }
        }

        public void DrawScene(Graphics g)
        {
            g.Clear(Color.Black);
            foreach (Star s in stars)
            {
                s.Draw(g);
            }
        }

        //https://stackoverflow.com/questions/42477367/what-is-the-equivalent-of-map-from-processing-in-other-languages
        public static double relativeMap(double value, double start1, double stop1, double start2, double stop2)    
        {
            return (value - start1) / (stop1 - start1) * (stop2 - start2) + start2;
        }
    }
}
