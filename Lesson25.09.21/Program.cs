using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25._09._21
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            bool logic = true;
            Console.Write("Введите трехзначное положительное число: ");
            while (logic)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i > 999 || i < 99)
                {
                    Console.Write("Число должно быть трехзначным, введите другое число: ");
                }
                else
                {
                    if (i / 100 == i % 10)
                    {
                        Console.WriteLine("Введенное число является палиндромом");
                    }
                    else
                    {
                        Console.WriteLine("Введенное число не является палидромом");
                    }
                    logic = false;
                }
            }

            Console.WriteLine("task2");
            double a, b, x;
            Console.WriteLine("Введите размер окна(высота)-");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите размер окна(ширина)-");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы Васи-");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Диаметр головы Васи диаметром {x}. Размеры окна {a} x {b}");
            if (x < a + 2 && x < b + 2)
            {
                Console.WriteLine("Вася смог высунуть голову");
            }
            else
            {
                Console.WriteLine("Кажется, парнишка застрял...");
            }

            Console.WriteLine("task3");
            Console.Write("Введите порядковый номер дня недели (1-7): ");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wendnesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Измените номер");
                    break;
            }

            Console.WriteLine("task4");
            try
            {
                Console.WriteLine("Введите порядковый номер карты k (6 <= k <= 14): ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ваша карта: ");
                switch (x)
                {
                    case 6:
                        Console.WriteLine("Шестерка");
                        break;
                    case 7:
                        Console.WriteLine("Семерка");
                        break;
                    case 8:
                        Console.WriteLine("Восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Десятка");
                        break;
                    case 11:
                        Console.WriteLine("Валет");
                        break;
                    case 12:
                        Console.WriteLine("Дама");
                        break;
                    case 13:
                        Console.WriteLine("Король");
                        break;
                    case 14:
                        Console.WriteLine("Туз");
                        break;
                    default:
                        Console.WriteLine("Такой карты не существует");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("task 5");
            Console.WriteLine("Земля — идеальная сфера с радиусом R = 6370 км." +
                " h - высота до линии горизонта. а - расстояние до линнии горизонта");
            x = 6370;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"При h = {i}, a = {Math.Sqrt(i * (2 * x + i))} км.");

            }

            Console.WriteLine("task6");
            Console.Write("Введите цифру:");
            while (logic)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x > 9 || x < 1)
                {
                    Console.Write("Число должно быть натуральным и меньше 9, введите другое: ");
                }
                else
                {
                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine($"{x} * {i} = {x * i}");
                        logic = false;
                    }
                }
            }

            Console.WriteLine("task7");
            try
            {
                Console.WriteLine("A - последовательность. А[n] - член последовательности.");
                logic = true; a = 1; b = 0;
                while (logic)
                {
                    Console.Write($"A[{a}] = ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x < 0)
                    {
                        Console.WriteLine($"Среднее арифметическое для всех A[n] > 0: {b / a}");
                        logic = false;
                    }
                    b += x; a++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("task9");
            Console.WriteLine("А - последовательность чисел");
            logic = true; a = 1; b = 0;
            while (x != 0)
            {
                Console.Write($"A[{a}] = ");
                x = Convert.ToInt32(Console.ReadLine());
                if (a % 3 == 0)
                {
                    b += x;
                }
                a++;
            }
            Console.WriteLine($"Cумма элементов с порядковым номер кратным трем равна: {b}");


            Console.WriteLine("task10");
            Console.WriteLine("А - последовательность");
            a = 1; b = 0;
        Start:
            Console.Write($"A[{a}] = ");
            x = Convert.ToInt32(Console.ReadLine());
            b += x;
            a++;
            if (x != 0)
            {
                goto Start;
            }
            Console.WriteLine($"Cумма элементов последовательности: {b}");

            Console.ReadKey();

        }
    }
}

          