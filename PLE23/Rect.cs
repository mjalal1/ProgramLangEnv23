using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    public class Rect : Shape
    {
        int length,height;

        public Rect() : base()
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
            return "rect takes 2 parameters : length and height";
        }


        public override void set(CanvasO canvas, params int[] list)
        {
            base.set(canvas, list);
            this.length = list[0];
            this.height = list[1];
        }

        public override void draw()
        {
            Rectangle rect = new Rectangle(canvas.posx, canvas.posy, length, height);
            canvas.g.DrawRectangle(canvas.Pen, rect);
            if (canvas.fillo) { canvas.g.FillRectangle(canvas.brush, rect); }
            canvas.drawCount++;
        }
    }
}
