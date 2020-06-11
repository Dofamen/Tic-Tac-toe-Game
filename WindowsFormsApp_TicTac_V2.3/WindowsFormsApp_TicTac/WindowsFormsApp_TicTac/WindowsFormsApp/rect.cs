using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class Rect
    {
        private Rectangle geom;
        private int state;
        private static readonly int s = 100;

        public void reset()
        {
            this.state = 0;
        }

        public bool isEmpty()
        {
            return state == 0;
        }

        public bool PlayerA(){
            return state == 1; 
        }
        public bool PlayerB()
        { return state == -1; }

        public bool PointInRect(Point p)
        {

            bool r = this.geom.Contains(p);
            return  r;
        }
        public Rect(int tx, int ty, int w)
        {
            geom = new Rectangle(tx, ty, w, w);
            state = 0;
        }

        public void At(int x, int y) // Not used
        {
            geom.X = x;
            geom.Y = y;
            geom.Width = s;
            geom.Height = s;
        }
        public void desiner(ref Graphics g)
        {
            //Brush b = new SolidBrush(Color.Black);
            Pen s = new Pen(Color.DarkBlue,2);
            //s.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            g.DrawRectangle(s, geom);
            
        }

        public void rond(ref Graphics g) // Insert a pic of Oggy ... for player B
        {
            // Graphics g = p.Graphics;
            if (state == 0)
            {
                //Brush s = new SolidBrush(Color.Gold);
                //g.FillEllipse(s, geom);
                string img = @"..\..\img\Caf2.png"; 
                extension1.req1(ref g, ref geom, img);
                state = -1;
            }
        }
        public void Croix( ref Graphics g) // Insert a pic Cafards ... for player A
        {
            // Graphics g = p.Graphics;

            if (state == 0)
            {
                //Pen s = new Pen(Color.Red, 20);
                //g.DrawLine(s, geom.Left, geom.Top, geom.Right, geom.Bottom);
                //g.DrawLine(s, geom.Left, geom.Bottom, geom.Right, geom.Top);
                string img = @"..\..\img\Oggy.PNG";
                extension1.req1(ref g, ref geom, img);

                state = 1;
            }
        }
 
       
    }
}
