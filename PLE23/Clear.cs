using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    internal class Clear : Shape
    {
        public Clear() : base()
        { }
        
        public override void draw()
        {
            canvas.g.Clear(Color.Transparent);
            canvas.drawCount = 0;
        }

        public override string infoParams()
        {
            return "clear takes no parameters";
        }

        public override int parameters()
        {
            return 0;
        }
    }
}
