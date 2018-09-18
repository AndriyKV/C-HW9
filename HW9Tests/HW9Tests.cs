using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW9;
using System.IO;

namespace HW9Tests
{
    [TestClass]
    public class PointUnitTest
    {
        [TestMethod]
        public void DistanceTest()
        {
            //Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            double expected = 1;

            //Act
            double result = p1.Distance(p2);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestToSting()
        {
            //Arrange
            Point p1 = new Point(1, 1);
            string expected = "(1,1)";

            //Act
            string actual = p1.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class TrianguleUnitTest
    {
        [TestMethod]
        public void InitializationTest()
        {
            //Arrange
            Point p1 = new Point(97, 33);
            Point p2 = new Point(8.3, 93.25);
            Point p3 = new Point(18, 77);

            //Act
            Triangle triangle = new Triangle(p1, p2, p3);

            //Assert
            Assert.AreEqual(p1, triangle.Vertex1);
            Assert.AreEqual(p2, triangle.Vertex2);
            Assert.AreEqual(p3, triangle.Vertex3);
        }

        [TestMethod]
        public void PerimiterTest()
        {
            //Arrange
            Point p1 = new Point(97, 33);
            Point p2 = new Point(8, 93);
            Point p3 = new Point(18, 77);
            double expected = 216.631;

            //Act
            double actual = Math.Round(new Triangle(p1, p2, p3).Perimeter(), 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareTest()
        {
            //Arrange
            Point p1 = new Point(97, 33);
            Point p2 = new Point(8, 93);
            Point p3 = new Point(18, 77);
            double expected = 24309.056;

            //Act
            double actual = Math.Round(new Triangle(p1, p2, p3).Square(), 3);

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrintTest()
        {
            //Arrange
            Point p1 = new Point(97, 33);
            Point p2 = new Point(8, 93);
            Point p3 = new Point(18, 77);
            string expected = "First point: (97,33)\nSecond point: (8,93)\nThird point: (18,77)\nPerimeter: 216,630649506992\nSquare: 24309,0560579587\n\n";

            //Act
            string actual;

            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                new Triangle(p1, p2, p3).Print();

                actual = stringWriter.ToString();
            }
            
            Assert.AreEqual(expected, actual);
        }
    }
}
