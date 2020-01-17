using System;
using System.Globalization;
using System.Collections.Generic;
using ShapeAreas.Entities.Enums;
using ShapeAreas.Entities;

/// <summary>
/// a program to read the Figures data (Not supplied by the user), 
/// and then show the areas of these figures in the same order as they were typed.
/// </summary>

namespace ShapeAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapesList = new List<Shape>();

            Console.WriteLine("Enter the number of shapes !");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Shape # {i} data: ");
                Console.Write("Rectangle or Circle (R/C): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r' || ch == 'R')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapesList.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapesList.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in shapesList)
            {
                Console.WriteLine(shape.Area().ToString("F2"), CultureInfo.InvariantCulture);
            }

            Console.ReadLine();
        }
    }
}
