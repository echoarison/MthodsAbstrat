using System;
using System.Collections.Generic;
using System.Globalization;
using MethodsAbstratos.Entities;
using MethodsAbstratos.Entities.Enum;

namespace MethodsAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            //fazendo a list de figuras
            List<Shape> list = new List<Shape>();

            //fazendo um loop
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data:");   //fazendo uma interploração
                Console.Write("Rectangle or Circle(r / c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                //fazendo uma verificação
                if (ch == 'r' || ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));

                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();

            Console.WriteLine("Shape Areas: ");
            foreach (Shape item in list)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
