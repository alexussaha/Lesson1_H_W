using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Усов Александр
 * 5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)*/

namespace Task_5
{
    class Program
    {
        public static void Pause()
        {
            Console.ReadKey();
        }
        static void print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 20);
            Console.SetBufferSize(50, 20);
            /* Пятое задание*/

/*Пункт "a"*/
string fullName = "Усов Александр, Москва";
            Console.WriteLine(fullName);

            ///*Пункт "б"*/
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine(fullName);

            /*Пункт "c"*/

            print(fullName, Console.WindowWidth / 2, Console.WindowHeight / 2);
            Pause();
        }
    }
}
