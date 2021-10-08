using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1.1");
            Console.Write("Введите действительное число x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Его абсолютная величина равна {Abs(x)}");

            Console.WriteLine("task1.2");
            Console.Write("Введите действительное число x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите действительное число x = ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (Abs(x) > Abs(y))
            {
                x = x / 2;
            }
            else
            {
                Console.WriteLine("Второе число больше первого, программа не выполняется...");
            }
            Console.WriteLine($"После преобразования x = {x}");

            Console.WriteLine("task1.3");
            Console.Write("Введите животное(alligator): ");
            string size = Console.ReadLine();
            if (size.ToLower() == "alligator")//показывает независимость от регистра
            {
                size = "small";
            }
            else
            {
                size = "wide";
            }
            Console.WriteLine($"mouthSize = {size}");

            Console.WriteLine("task1.4");
            try
            {
                Console.WriteLine("Input string: ");
               string name = Console.ReadLine();
                switch (name.ToLower())//независимость от регистра
                {
                    case "jabroni":
                        Console.WriteLine("Patron Tequilla");
                        break;
                    case  "school counselor":
                        Console.WriteLine("Anything with Alcohol");
                        break;
                    case "programmer":
                        Console.WriteLine("Hipster Craft Beer");
                        break;
                    case "bike gang member":
                        Console.WriteLine("Moonshine");
                        break;
                    case "politcian":
                        Console.WriteLine("Your tax dollars");
                        break;
                    case "rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("task1.5");
            Console.Write("Input string: ");
            string english = Console.ReadLine();
            Console.WriteLine($"String contains \"english\": {english.ToLower().Contains("english")}");

            Console.WriteLine("task2.1");//последовательность дана
            x = 1; double sum = 1;
            for (int i = 0; i < 8; i++)
            {
                x /= 3;
                sum += x;
            }
            Console.WriteLine($"Искомая сумма равна {sum}");

            Console.WriteLine("task2.2");
            int stage = 100;
            double distance = 0;
            int summ = 0;
            double temp = 1;
            double way = 1;
            bool flag = true;
            for (int i = 0; i < stage; i++)
            {
                if (flag)
                {
                    distance += way;
                    temp++;
                    way = (double)1 / temp;
                    flag = false;
                }
                else
                {
                    distance -= way;
                    temp++;
                    way = (double)1 / temp;
                    flag = true;
                }

            }
            Console.WriteLine("В данный момент муж находится на расстоянии: " + distance + " \nА общий путь составляет: " + summ);

            Console.WriteLine("task2.3");
            int[] tempJanuary = new int[31];
            int[] tempMarch = new int[30];
            Random r = new Random();
            summ = 0;
            for (int i = 0; i < tempJanuary.Length; i++)
            {
                tempJanuary[i] = r.Next(0, 100);
            }
            for (int i = 0; i < tempJanuary.Length; i++)
            {
                summ += tempJanuary[i];
            }
            Console.WriteLine("Среднее количество осадков в Январе = " + summ / (tempJanuary.Length));

            summ = 0;
            for (int i = 0; i < tempMarch.Length; i++)
            {
                tempMarch[i] = r.Next(0, 100);
            }
            for (int i = 0; i < tempMarch.Length; i++)
            {
                summ += tempMarch[i];
            }
            Console.WriteLine("Средняя количество осадков в Марте = " + summ / (tempMarch.Length));

            Console.WriteLine("task3.1");//последовательность дана
            x = 1; y = 1;
            while (Math.Abs(x / y - (x + y) / x) > 0.001)
            {
                temp = x;
                x += y;
                y = temp;
            }
            Console.WriteLine($"Первый член последовательности, который отличается от предыдущего члена не более чем на 0, 001.: { x + y}/{x}");

            Console.WriteLine("task3.2");
            Console.Write("Введите число n: ");
            double n = Convert.ToDouble(Console.ReadLine()); y = 1;
            while (y * y <= x)
            { 
                y++;
            }
            Console.WriteLine($"Первое натуральное  число, квадрат которого больше x: {y}");

            Console.WriteLine("task3.3");
            x = 100;
            while (x > 79)
            {
                Console.WriteLine(x);
                x--;
            }
            x = 100;
            do
            {
                Console.WriteLine(x);
                x--;
            } while (x > 79);

            Console.WriteLine("task3.4");
            x = 5000;
            while (x % 39 != 0)
            {
                x--;
            }
            Console.WriteLine("максимальное из натуральных чисел, не превышающих 5000," +
                $" которое нацело делится на 39 - {x}");

            Console.WriteLine("task3.5");
            string order = "";
            for (int i = 0; i < 5; i++)
            {
                order += "5";
                Console.WriteLine(order);
            }
            order = "1 1 1 1 1 ";
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(order);
            }
            Console.ReadKey();
        }
        static double Abs(double x)//для раcкрытия модуля
        {
            x = x > 0 ? x : -x;
            return x;
        }
    }
}
