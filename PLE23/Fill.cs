using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    internal class Fill : Shape, StringCmd
    {
        string state;
         public void set(Form1 forma, string state)
        {
            base.set(forma.Canvas);
            this.state = state;


        }
        public override void draw()
        {
            if (state == "on")
            {
                canvas.fillo = true;

            }
            else if (state == "off")
            { canvas.fillo = false; }
        }

        public override string cmdType()
        {
            return "string";
        }

        public override string infoParams()
        {
            return "fill takes 1 parameters: on/off";
        }

        public override int parameters()
        {
            return 1 ;
        }
    }
}
