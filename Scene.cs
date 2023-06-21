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

        public long[] Distance { set; get; }
        public string[] Planets { set; get; } 
        public int Speed { set; get; }
        public static Point center { set; get; }

        List<Star> stars;
        public Scene(int Width, int Height) { 
            this.Width = Width;
            this.Height = Height;
            center = new Point(Width/2,Height/2);

            Distance = new long[3];
            Distance[0] = 588000000;
            Distance[1] = 384000;
            Distance[2] = 4300000000;

            Planets = new string[3];
            Planets[0] = "Jupiter";
            Planets[1] = "Moon";
            Planets[2] = "Neptune";

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
                s.Draw(g, Speed);
            }
        }

        //https://stackoverflow.com/questions/42477367/what-is-the-equivalent-of-map-from-processing-in-other-languages
        public static double relativeMap(double value, double start1, double stop1, double start2, double stop2)    
        {
            return (value - start1) / (stop1 - start1) * (stop2 - start2) + start2;
        }
    }
}
