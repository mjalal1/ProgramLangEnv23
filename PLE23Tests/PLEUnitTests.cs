using Microsoft.VisualStudio.TestTools.UnitTesting;
using PLE23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Unit Testing for the main program
/// </summary>
namespace PLE23UnitTests
{
    /// <summary>
    /// Test class containing the unit test methods
    /// </summary>
    [TestClass()]
    public class PLEUnitTests
    {

        /// <summary>
        /// Tests 'moveTo' with valid input.
        /// </summary>
        [TestMethod()]
        public void MoveToTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("moveto 100,150");
            Assert.AreEqual(100, forma.Canvas.posx, 0.01);
            Assert.AreEqual(150, forma.Canvas.posy, 0.01);

        }

        /// <summary>
        /// Tests 'reset' with valid input
        /// </summary>
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


        /// <summary>
        /// Tests 'drawTo' with valid input
        /// </summary>
        [TestMethod()]
        public void DrawToTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("drawto 100,150");
            Assert.AreEqual(100, forma.Canvas.posx, 0.01);
            Assert.AreEqual(150, forma.Canvas.posy, 0.01);
        }

        /// <summary>
        /// Tests 'fill' with valid input
        /// </summary>
        [TestMethod()]
        public void fillTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("fill on");
            Assert.AreEqual(true, forma.Canvas.fillo);

        }

        /// <summary>
        /// Tests 'clear' with valid input
        /// </summary>
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


        /// <summary>
        /// Tests 'rect' with valid input
        /// </summary>
        [TestMethod()]
        public void DrawRectTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("rect 100,150");
            Assert.AreEqual("1", forma.labelDrawCountVal.Text);
        }


        /// <summary>
        /// Tests 'circle' with valid input
        /// </summary>
        [TestMethod()]
        public void DrawCircleTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("circle 100");
            Assert.AreEqual("1", forma.labelDrawCountVal.Text);
        }

        /// <summary>
        /// Tests 'triangle' with valid input
        /// </summary>
        [TestMethod()]
        public void DrawTriangleTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("triangle 100,100,200,200,300,100");
            Assert.AreEqual("1", forma.labelDrawCountVal.Text); 
        }

        /// <summary>
        /// Tests 'pen' with valid input
        /// </summary>
        [TestMethod()]
        public void penTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("pen red");
            Assert.AreEqual(System.Drawing.Color.Red, forma.Canvas.Pen.Color);
            
        }

        /// <summary>
        /// Tests 'save' with valid input
        /// </summary>
        [TestMethod()]
        public void saveTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("circle 45\nsave test");
            forma.LoadFile("test");
          

        }

        /// <summary>
        /// Tests 'load' with valid input
        /// </summary>
        [TestMethod()]
        public void loadTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);

            p.ParseCommand("circle 45\nsave loadtest");
            forma.LoadFile("loadtest"); // u need to commit save test above first then this


        }

        /// <summary>
        /// Tests parsing the command line with valid input
        /// </summary>
        [TestMethod()]
        public void commandLineTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            forma.commandLine.Text = "fill on";
            p.ParseCommand(forma.commandLine.Text);
            Assert.AreEqual(true, forma.Canvas.fillo);

        }

        /// <summary>
        /// Tests parsing the programWindow and 'run' with valid input
        /// </summary>
        [TestMethod()]
        public void programWindowTest() 
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            forma.programWindow.Text = "circle 50\nrect 100,150\ncircle 100\ndrawto 200,200\nfill on\npen blue\ncircle 50";
            p.ParseCommand("run");
            Assert.AreEqual("5", forma.labelDrawCountVal.Text);

        }
    }
}