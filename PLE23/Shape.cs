using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    public abstract class Shape : Command, IShapes
    {
        protected int x, y;
        protected Color colour;
        protected CanvasO canvas;

        public Shape()
        {
            this.x = 0; this.y = 0;
        }

        public override string cmdType()
        { return "draw";}

      

        public abstract void draw();

        public virtual void set(CanvasO canvas, params int[] list)
        {
            this.canvas = canvas;
            this.x = canvas.posx; this.y=canvas.posy;
          
        }
        



    }
}
