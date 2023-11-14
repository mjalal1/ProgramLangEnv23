using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    /// <summary>
    /// Canvas class for drawing methods
    /// </summary>
    public class CanvasO
        {
         public   Graphics g;
           public Pen Pen;
          public  int posx;
       public     int posy;
       public Brush brush = Brushes.Black;
      public  bool fillo = false;
        public int drawCount = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="CanvasO"/> class.
        /// </summary>
        /// <param name="g">The graphics interface used to draw.</param>
        public CanvasO(Graphics g)
            {
                this.g = g;
                posx = posy = 0; ;
                Pen = new Pen(Color.Black, 1);
            }

        /// <summary>
        /// Moves the pen location without drawing
        /// </summary>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        public void MoveTo(int x, int y)
        {

            posx = x;
            posy = y;

        }

        /// <summary>
        /// Resets the pen position to 0,0.
        /// </summary>
        public void reset()
        {
            posx = 0; posy=0;
        }

        /// <summary>
        /// Draws a line to given position from current position.
        /// </summary>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        public void DrawTo(int x, int y)
        {
            g.DrawLine(Pen, posx, posy, x, y);
            posx = x;
            posy = y;
            drawCount++;

        }

        /// <summary>
        /// Toggles whether brush fills the shape.
        /// </summary>
        /// <param name="o">on or off.</param>
        public void fill(string o)
        {

            if (o == "on")
            {
                fillo = true;

            }
            else if (o == "off")
            { fillo = false; }


        }

        /// <summary>
        /// Clears the canvas.
        /// </summary>
        public void clear()
        {

            g.Clear(Color.Transparent);
            drawCount = 0;

        }

        /// <summary>
        /// Draws the rectangle.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="height">The height.</param>
        public void DrawRect(int length, int height)
        {
            Rectangle rect = new Rectangle(posx, posy, length, height);
            g.DrawRectangle(Pen, rect);
            if (fillo) { g.FillRectangle(brush, rect); }
            drawCount++;
            


        }

        /// <summary>
        /// Draws the circle.
        /// </summary>
        /// <param name="radius">The radius.</param>
        public void DrawCircle(int radius)
        {
            Rectangle recta = new Rectangle(posx - radius, posy - radius, radius * 2, radius * 2);
            g.DrawEllipse(Pen, recta);
            if (fillo) { g.FillEllipse(brush, recta); }
            drawCount++;
        }

        /// <summary>
        /// Draws the triangle using x and y of each point.
        /// </summary>
        /// <param name="x1">The x of point 1.</param>
        /// <param name="y1">The y of point 1.</param>
        /// <param name="x2">The x of point 2.</param>
        /// <param name="y2">The y of point 2.</param>
        /// <param name="x3">The x of point 3.</param>
        /// <param name="y3">The y of point 3.</param>
        public void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Point[] pnt = new Point[3];

            pnt[0].X = x1;
            pnt[0].Y = y1;

            pnt[1].X = x2;
            pnt[1].Y = y2;

            pnt[2].X = x3;
            pnt[2].Y = y3;

            g.DrawPolygon(Pen, pnt);
            if (fillo) { g.FillPolygon(brush, pnt); }
            drawCount++;
        }


        /// <summary>
        /// Sets colour of the pens.
        /// </summary>
        /// <param name="colour">The colour.</param>
        public void pen(string colour)
        {

            switch (colour)
            {
                case "red":
                    Pen.Color = Color.Red;
                    brush = Brushes.Red;

                    break;
                case "blue":
                    Pen.Color = Color.Blue;
                    brush = Brushes.Blue;
                    break;
                case "green":
                    Pen.Color = Color.Green;
                    brush = Brushes.Green;
                    break;
                case "Pink":
                    Pen.Color = Color.Pink;
                    brush = Brushes.Pink;
                    break;
                case "purple":
                    Pen.Color = Color.Purple;
                    brush = Brushes.Purple;
                    break;
                case "black":
                    Pen.Color = Color.Black;
                    brush = Brushes.Black;
                    break;
            }


        }
    }
    
}
