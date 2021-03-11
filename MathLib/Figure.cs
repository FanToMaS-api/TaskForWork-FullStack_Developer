using System;
using System.Collections.Generic;
namespace MathLib
{
    public class Figure
    {
        private uint ungles; // кол-во углов в фигуре
        private double[] side;
        //List<Figure> figures = new List<Figure>(); // лист для сохранения всех уникальных фигур

        public Figure(uint _ungles)
        {
            ungles = _ungles;

            if (ungles != 0)
            {
                side = new double[ungles];
                for (int i = 0; i < side.Length; i++)
                {
                    Console.Write($"Введите длину {i + 1} стороны: ");
                    Check(out side[i]);
                }
            }
            else
            {
                side = new double[1];
                Console.Write($"Введите радиус: ");
                Check(out side[0]);
            }
        }

        #region Методы        
        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// <param name="figure"></param>
        /// <returns> 0 - если треугольник прямоугольный и первая сторона гипотенуза
        /// 1 - если треугольник прямоугольный и вторая сторона гипотенуза
        /// 2 - если треугольник прямоугольный и третья сторона гипотенуза
        /// -1 - есил треугольник не прямоугольный</returns>
        private int SquareTriangle(Figure figure)
        {
            if (Math.Pow(side[0], 2) == Math.Pow(side[1], 2) + Math.Pow(side[2], 2))
                return 0;
            else if (Math.Pow(side[1], 2) == Math.Pow(side[2], 2) + Math.Pow(side[0], 2))
                return 1;
            else if (Math.Pow(side[2], 2) == Math.Pow(side[0], 2) + Math.Pow(side[1], 2)) 
                return 2;
            else
                return -1;
        }
        /// <summary>
        /// Функция, вычисляющая площадь фигуры
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        public double Square()
        {
            if(ungles == 0)
            {
                return Math.PI * Math.Pow(side[0], 2);
            }
            else if (ungles == 3)
            {
                switch(SquareTriangle(this))
                {
                    case 0:
                        return side[1] * side[2] / 2;
                    case 1:
                        return side[2] * side[0] / 2;
                    case 2:
                        return side[0] * side[1] / 2;
                    case -1:
                        {
                            double p = (side[0] + side[1] + side[2]) / 2; // полупериметр
                            return Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2]));
                        }
                }                
            }
            return 0;
        }        
        public static void AddFigure(uint ungles)
        {
            Console.WriteLine("Введите кол-во углов:");
            bool succcessfulInput = false;
            double a;
            while (!succcessfulInput)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a <= 0)
                        throw new Exception();
                    else
                        succcessfulInput = true;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Ошибка ввода, повторите ввод!");
                }
            } 
            Console.WriteLine("Введите кол-во переменных для вычисления площади фигуры:");
            int iterations = 0;
            succcessfulInput = false;
            
            while(iterations != 0)
            {
                /// Возникла проблема в добавления новой фигуры, а точнее в занесении формулы для вычисления ее площади
            }
        }
        /// <summary>
        /// Проверка на корректный ввод
        /// </summary>
        /// <param name="value"></param>
        private void Check(out double value)
        {
            bool succcessfulInput = false;
            value = 0;
            while (!succcessfulInput)
            {
                try
                {
                    value = Convert.ToDouble(Console.ReadLine());
                    if (value <= 0)
                        throw new Exception();
                    else                    
                        succcessfulInput = true;                    
                }
                catch (Exception)
                {
                    Console.WriteLine($"Ошибка ввода, повторите ввод!");
                }
            }            
        }
        #endregion
    }
}
