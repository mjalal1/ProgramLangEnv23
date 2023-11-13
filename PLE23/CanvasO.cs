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

            public CanvasO(Graphics g)
            {
                this.g = g;
                posx = posy = 0; ;
                Pen = new Pen(Color.Black, 1);
            }

        public void DrawLine(int x, int y)
        {
            g.DrawLine(Pen, posx, posy, x, y);
            posx = x;
            posy = y;

        }
        public void DrawSquare(int length)
        {
            g.DrawRectangle(Pen, posx, posy, posx + length, posy + length);


        }
    }
    
}
