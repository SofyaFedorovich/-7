using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {//метод для вычисления объёма и площади поверхности куба по длине его ребра
                {
                    Console.Write("Ввести длину ребра куба a:  ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double v = 0;
                    double s = 0;
                    getParam(a, out v, out s);
                    Console.WriteLine("Объём куба с ребром a равен:   {0}", v);
                    Console.WriteLine("Площадь поверхности куба с ребром a равна:   {0}", s);
                    Console.ReadKey();
                }
            }
        }

        private static void getParam(double a, out double v, out double s)
        {
            v = a * a * a;
            s = 6 * a * a;
        }
    }
}