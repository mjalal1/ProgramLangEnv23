using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
   public interface IShapes
    {
       
        void set(CanvasO canvas, params int[] list);
        void draw();
    }
}
