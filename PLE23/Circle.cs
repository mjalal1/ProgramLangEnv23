using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    public class Circle : Shape
    {
        int radius;
      
       
        public Circle():base()
        {

        }


            
        public override void set(CanvasO canvas, params int[] list)
        {  base.set(canvas, list);
            this.radius = list[0];
        }

        public override void draw()
        {
            Rectangle recta = new Rectangle(canvas.posx - radius, canvas.posy - radius, radius * 2, radius * 2);
            canvas.g.DrawEllipse(canvas.Pen, recta);
            if (canvas.fillo) { canvas.g.FillEllipse(canvas.brush, recta); }
            canvas.drawCount++;
        }

        public override int parameters()
        {
            return 1;
        }

        public override string infoParams()
        {
            return "circle takes 1 parameter: radius";
        }
    }
}
    