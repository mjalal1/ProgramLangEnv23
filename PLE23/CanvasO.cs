using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    
        class CanvasO
        {
            Graphics g;
            Pen Pen;
            int posx;
            int posy;
        Brush brush = Brushes.Black;
        bool fillo = false;
        public CanvasO(Graphics g)
            {
                this.g = g;
                posx = posy = 0; ;
                Pen = new Pen(Color.Black, 1);
            }

        public void MoveTo(int x, int y)
        {

            posx = x;
            posy = y;

        }
        public void reset()
        {
            posx = 0; posy=0;
        }
        public void DrawTo(int x, int y)
        {
            g.DrawLine(Pen, posx, posy, x, y);
            posx = x;
            posy = y;

        }

        public void clear()
        {

            g.Clear(Color.Transparent);

        }
        public void DrawRect(int length, int height)
        {
            g.DrawRectangle(Pen, posx, posy, posx + length, posy + height);


        }

        public void DrawCircle(int radius)
        {
            g.DrawEllipse(Pen, posx, posy, (posx + (radius * 2)), (posy + (radius * 2)));
        }

        public void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Point[] pnt = new Point[3];

            pnt[0].X = x1;
            pnt[0].Y = y1;

            pnt[1].X = x2;
            pnt[1].Y = y2;

            pnt[2].X = x3;
            pnt[2].Y = y3;

            g.DrawPolygon(Pen, pnt);
        }
    }
    
}
