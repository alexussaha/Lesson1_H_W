using System;


/* Усов Александр
 * 4. Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной*/
namespace Task_four
{
    class Program
    {
        public static void Pause()
        {
            Console.ReadKey();
        }
        static void Main()
        {

            int a, b, c;
          

            /*Четвёртое задание*/

            /*Пункт "a"*/
            a = 1;
            b = 2;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a={a}; b = {b}");

            /* Пункт "b"*/
            a = 1;
            b = 2;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a}; b = {b}");
            Pause();
        }
    }
}
