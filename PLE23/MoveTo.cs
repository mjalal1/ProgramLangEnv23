﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    class MoveTo : Shape
    {
        public MoveTo() : base()
        {

        }

        public override int parameters()
        {
            return 2;
        }
        public override string infoParams()
        {
            return " moveTo takes 2 parameters : x and y";
        }
        public override void set(CanvasO canvas, params int[] list)
        {
            base.set(canvas, list);
            x = list[0];
            y = list[1];
        }

        public override void draw()
        {
            canvas.posx = x;
            canvas.posy = y;
        }

        public override void execute()
        {
            draw();
        }
    }
}
