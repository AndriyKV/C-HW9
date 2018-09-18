using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            //create list of 3 triangles
            Random randomNumber = new Random();
            List<Triangle> trianglesList = new List<Triangle>(3);

            for (int i = 0; i < trianglesList.Capacity; i++)
            {
                Point a = new Point((i + randomNumber.NextDouble()), i + randomNumber.NextDouble());
                Point b = new Point(i + randomNumber.Next(0, 10), i + randomNumber.Next(0, 10));
                Point c = new Point(i + randomNumber.Next(10, 20), i + randomNumber.Next(10, 20));

                trianglesList.Add(new Triangle(a, b, c));
            }

            foreach (var triangle in trianglesList)
            {
                triangle.Print();
            }

            //write into console the information about triangles
            Console.WriteLine("\nThe triangle with vertex which is the closest to origin Point(0,0):\n");

            Triangle triangleCloseToOrigin = trianglesList[0];
            Point originPoint = new Point(0, 0);

            trianglesList.OrderBy(x => x.Vertex1.Distance(originPoint))
                .ThenBy(y => y.Vertex2.Distance(originPoint))
                .ThenBy(z => z.Vertex3.Distance(originPoint))
                .FirstOrDefault().Print();

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
