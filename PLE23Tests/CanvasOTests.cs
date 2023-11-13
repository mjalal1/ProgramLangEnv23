﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PLE23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23UnitTests
{
    [TestClass()]
    public class CanvasOTests
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
            
        }

        [TestMethod()]
        public void DrawToTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void fillTest()
        {
           
          
        }

        [TestMethod()]
        public void clearTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DrawRectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DrawCircleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DrawTriangleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void penTest()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            p.ParseCommand("pen red");
            Assert.AreEqual(System.Drawing.Color.Red, forma.Canvas.Pen.Color);
            
        }
    }
}