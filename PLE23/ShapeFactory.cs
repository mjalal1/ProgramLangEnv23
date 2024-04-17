using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PLE23
{
    public class ShapeFactory
    {
        public Command GetCmd(string shapeType)
        {
            shapeType = shapeType.ToLower().Trim();


            if (shapeType.Equals("circle"))
            {
                return new Circle(); // create classes for other commands
            }
           else if (shapeType.Equals("rect"))
            {
                return new Rect(); // create classes for other commands
            }
            else if (shapeType.Equals("triangle"))
            {
                return new Triangle(); 
            }
            else if (shapeType.Equals("drawto"))
            {
                return new DrawTo();
            }
            else if (shapeType.Equals("moveto"))
            {
                return new MoveTo();
            }
            else if (shapeType.Equals("clear"))
            {
                return new Clear();
            }
            else if (shapeType.Equals("reset"))
            {
                return new Reset();
            }
            else if (shapeType.Equals("fill"))
            {
                return new Fill();
            }
            else if (shapeType.Equals("pen"))
            {
                return new PenCmd();
            }
            else if (shapeType.Equals("save"))
            {
                return new Save();
            }
            else if (shapeType.Equals("load"))
            {
                return new Load();
            }
            else if (shapeType.Equals("run"))
            {
                return new Run();
            }
            else if (shapeType.Equals("var"))
            {
                return new Var();
            }
            else if (shapeType.Equals("="))
            {
                return new Var();
            }


            else
            {
                throw new Exc.InvalidCommandException(shapeType);
                throw new ApplicationException("[FACTORY]: Command not recognised\nValid Commands: rect,triangle,circle,drawTo,moveTo,reset,clear,pen,fill");
            }
        }

    }
}
