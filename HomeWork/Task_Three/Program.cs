using System;
/* Усов Александр
 * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
    б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;*/

namespace Task_Three
{
    class Program
    {
        public static void Pause()
        {
            Console.ReadKey();
        }
        static double findDistanceBetwTwoPoints(double x1, double y1, double x2, double y2)
        {
            double r;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void Main()
        {

            double x1, y1, x2, y2, r;

            /*Третье задание*/

            /*Пункт "а"*/
            Console.WriteLine("Введите координаты первой точки:");
            Console.Write(" x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки:");
            Console.Write(" x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние равно: {0:F2} ", r);


            /*Пункт "б"*/

            Console.WriteLine("Расстояние равно: {0:F2} ", findDistanceBetwTwoPoints(x1, y1, x2, y2));
            Pause();
        }
    }
}
