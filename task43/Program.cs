// Ищем точку пересечения двух прямых
using System;

namespace Seminar6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты уравнений y = k1*x + b1 и y = k2*x + b2");

            double k1 = GetNumber("k1");
            double k2 = GetNumber("k2");
            double b1 = GetNumber("b1");
            double b2 = GetNumber("b2");

            double[] junction = LinesJunction(k1, b1, k2, b2); // Результат возвращается в виде double[] со значениями x, y

            Console.WriteLine($"точка пересечения двух прямых (x,y): {junction[0]}, {junction[1]}");
        }

        static double GetNumber(string varName) // метод для ввода переменной varName с клавитатуры
        {
            Console.WriteLine($"Введите переменную {varName}");

            double var = Double.Parse(Console.ReadLine());

            return var;
        }

        static double[] LinesJunction (double k1, double b1, double k2, double b2)
        {
            
            double[] noJunction = {Double.MaxValue, Double.MaxValue};
            if (k1 == k2) return noJunction; // параллельные прямые не пересекаются

            double x;
            double y;

            // находим x из уравнения k1*x + b1 = k2*x + b2
            x = (b2 - b1) / (k1 - k2);
            // находим y 
            y = k1 * x + b1;

            double[] linesJunction = {x, y};

            return linesJunction;

        }
    }
}