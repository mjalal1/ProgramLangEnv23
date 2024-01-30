using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    class Triangle : Shape
    { 
        
        Point[] pnt = new Point[3];
        public Triangle() : base()
        { }

        public override int parameters()
        {
            return 6;
        }
        public override string infoParams()
        {
            return "triangle takes 6 parameters : x1,y1, x2,y2, x3,y3";
        }

        public override void execute()
        {
            draw();
        }

        public override void set(CanvasO canvas, params int[] list)
        {
            base.set(canvas, list);
            this.pnt[0].X = list[0];
            this.pnt[0].Y = list[1];

            this.pnt[1].X = list[2];
            this.pnt[1].Y = list[3] ;

            this.pnt[2].X = list[4];
             this.pnt[2].Y = list[5];
        }

        public override void draw()
        {
            canvas.g.DrawPolygon(canvas.Pen, pnt);
            if (canvas.fillo) { canvas.g.FillPolygon(canvas.brush, pnt); }
            canvas.drawCount++;
        }



    }
}
