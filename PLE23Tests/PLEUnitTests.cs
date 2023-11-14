using Microsoft.VisualStudio.TestTools.UnitTesting;
using PLE23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23UnitTests
{
    [TestClass()]
    public class PLEUnitTests
    {
  
        [TestMethod()]
        public void MoveToTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("moveto 100,150");
            Assert.AreEqual(100, forma.Canvas.posx, 0.01);
            Assert.AreEqual(150, forma.Canvas.posy, 0.01);

        }

        [TestMethod()]
        public void resetTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            forma.Canvas.posx = 100;
            forma.Canvas.posy = 200;
            p.ParseCommand("reset");
            Assert.AreEqual(0, forma.Canvas.posx, 0.01);
            Assert.AreEqual(0, forma.Canvas.posy, 0.01);
        }

        [TestMethod()]
        public void DrawToTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("drawto 100,150");
            Assert.AreEqual(100, forma.Canvas.posx, 0.01);
            Assert.AreEqual(150, forma.Canvas.posy, 0.01);
        }

        [TestMethod()]
        public void fillTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("fill on");
            Assert.AreEqual(true, forma.Canvas.fillo);

        }

        [TestMethod()]
        public void clearTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("rect 100,150\ncircle 50");
            Assert.AreEqual("2", forma.labelDrawCountVal.Text);
            p.ParseCommand("clear");
            Assert.AreEqual("0", forma.labelDrawCountVal.Text);
            
        }

        [TestMethod()]
        public void DrawRectTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("rect 100,150");
            Assert.AreEqual("1", forma.labelDrawCountVal.Text);
        }

        [TestMethod()]
        public void DrawCircleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DrawTriangleTest()
        {
            Assert.Fail(); // parse draw 
        }

        [TestMethod()]
        public void penTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("pen red");
            Assert.AreEqual(System.Drawing.Color.Red, forma.Canvas.Pen.Color);
            
        }

        [TestMethod()]
        public void saveTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("circle 45\nsave test");
            forma.LoadFile("test");
          

        }

        
        [TestMethod()]
        public void loadTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);

            p.ParseCommand("circle 45\nsave loadtest");
            forma.LoadFile("loadtest"); // u need to commit save test above first then this


        }

        [TestMethod()]
        public void commandLineTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            forma.commandLine.Text = "fill on";
            p.ParseCommand(forma.commandLine.Text);
            Assert.AreEqual(true, forma.Canvas.fillo);

        }
    }
}