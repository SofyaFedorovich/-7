using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_7
{
    class Program
    {
        static void Main(string[] args)
        {//сравнение площадей двух треугольников
            {
                Console.Write("Ввести сторону треугольника х1:");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ввести сторону треугольника y1:");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ввести сторону треугольника z1:");
                double z1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ввести сторону треугольника х2:");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ввести сторону треугольника y2:");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ввести сторону треугольника z2:");
                double z2 = Convert.ToDouble(Console.ReadLine());
                if ((S(x1, y1, z1) > S(x2, y2, z2)))
                {
                    Console.WriteLine("Площадь тругольника со сторонами х1,y1,z1 больше");
                }
                else
                {
                    Console.WriteLine("Площадь тругольника со сторонами х2,y2,z2 больше");
                }
                Console.ReadKey();
            }
        }

        private static double S(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(Math.Abs(p * (p - x) * (p - y) * (p - z)));
            return S;
        }
    }
}
