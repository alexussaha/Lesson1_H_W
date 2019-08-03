using System;

/* Усов Александр
 * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах*/
namespace Task_Two
{
    class Task_Two
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        static void Main()
        {
            double height, weight, ibm;
            /*Второе задание*/

            Console.WriteLine("Введите Ваш рост:");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Спасибо!");
            ibm = weight / Math.Pow(height / 100, 2);
            Console.WriteLine($"ИМТ равен: {ibm}");
            Pause();
           
        }
    }
}

