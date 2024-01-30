using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
     class DrawTo : Shape
    {

        public DrawTo() : base()
        {
            
        }
        public override void execute()
        {
            draw();
        }

        public override int parameters()
        {
            return 2;
        }
        public override string infoParams()
        {
            return " drawTo takes 2 parameters : x and y";
        }
        public override void set(CanvasO canvas, params int[] list)
        {
            base.set(canvas, list);
            x = list[0];
            y = list[1];
        }

        public override void draw()
        {
            canvas.g.DrawLine(canvas.Pen, canvas.posx, canvas.posy, x, y);
            canvas.posx = x;
            canvas.posy = y;
            canvas.drawCount++;
        }
    }
}
