using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    class Reset : Shape
    {
        public Reset():base() { }

        public override void draw()
        {
            canvas.posx = 0; canvas.posy = 0;
        }

        public override string infoParams()
        {
            return "reset takes no parameters";
        }

        public override int parameters()
        {
            return 0;
        }
    }
}
