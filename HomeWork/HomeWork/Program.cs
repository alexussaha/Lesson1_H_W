using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Усов Александр.
 * Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
а) используя склеивание;
б) используя форматированный вывод;
в) *используя вывод со знаком $.*/

namespace HomeWork
{
   public class Program
    {
       static void Pause()
        {
            Console.ReadKey();
        }
       
        static void Main(string[] args)
        {
            string name, surname;
            int age;
            double height, weight;

            /*Первое задание*/

            Console.WriteLine("Добро пожаловать в программу \"Анкета\".");
            Console.WriteLine("Введите Ваше имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию:");
            surname = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Ваш рост:");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Спасибо!");
           
            /*Пункт "а"*/
            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);

            /*Пункт "б"*/
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, surname, age, height, weight);

            /*Пункт "в"*/
            Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age} Рост: {height} Вес: {weight}");





            Pause();
          


           
        }
    }
   
}
