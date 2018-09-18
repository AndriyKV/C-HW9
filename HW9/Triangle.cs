using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    // Create class Triangle
    public class Triangle
    {
        //Create: fields vertex1, vertex2, vertex3 of type Point/constructors/methods Perimeter(), Square(), Print()
        //Point vertex1, vertex2, vertex3;
        public Point Vertex1
        {
            get;
        }
        public Point Vertex2
        {
            get;
        }
        public Point Vertex3
        {
            get;
        }

        public Triangle()
        {

        }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
        }

        public double Perimeter()
        {
            return Vertex1.Distance(Vertex2) + Vertex2.Distance(Vertex3) + Vertex3.Distance(Vertex1);
        }

        public double Square()
        {
            return Math.Sqrt(Perimeter() * 
                (Perimeter() - Vertex1.Distance(Vertex2)) *
                (Perimeter() - Vertex2.Distance(Vertex3)) *
                (Perimeter() - Vertex3.Distance(Vertex1)));
        }

        public void Print()
        {
            Console.WriteLine($"First point: {Vertex1.ToString()}\n" +
                $"Second point: {Vertex2.ToString()}\n" +
                $"Third point: {Vertex3.ToString()}\n" +
                $"Perimeter: {Perimeter()}\n" +
                $"Square: {Square()}\n");
        }
    }
}
