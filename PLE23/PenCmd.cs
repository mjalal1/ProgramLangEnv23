using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    public class PenCmd : Shape, StringCmd
    {
        string colour;
        public void set(Form1 forma, string colour)
        {
            base.set(forma.Canvas);
            this.colour = colour;


        }

        public override void execute()
        {
            draw();
        }
        public override void draw()
        {
            switch (colour)
            {
                case "red":
                    canvas.Pen.Color = Color.Red;
                    canvas.brush = Brushes.Red;

                    break;
                case "blue":
                    canvas.Pen.Color = Color.Blue;
                    canvas.brush = Brushes.Blue;
                    break;
                case "green":
                    canvas.Pen.Color = Color.Green;
                    canvas.brush = Brushes.Green;
                    break;
                case "Pink":
                    canvas.Pen.Color = Color.Pink;
                    canvas.brush = Brushes.Pink;
                    break;
                case "purple":
                    canvas.Pen.Color = Color.Purple;
                    canvas.brush = Brushes.Purple;
                    break;
                case "black":
                    canvas.Pen.Color = Color.Black;
                    canvas.brush = Brushes.Black;
                    break;
            }
        }

        public override string cmdType()
        {
            return "string";
        }

        public override string infoParams()
        {
            return "pen takes 1 parameter: red/blue/green/purple/black ";
        }

        public override int parameters()
        {
            return 1;
        }
    }
}
