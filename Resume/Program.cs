using System;
using MathLib;

namespace Resume
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(3);
            Figure figure1 = new Figure(0);
            Console.WriteLine($"Площадь фигуры равна: {figure.Square()}");
            Console.WriteLine($"Площадь фигуры равна: {figure1.Square()}");
        }
    }
}
