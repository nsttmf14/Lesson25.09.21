using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs4
{
    enum Mounth
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        Ocober,
        November,
        December
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("all_tasks_from_lab4");
            var dayMonths = new byte[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("Введите год: ");
            ushort dayAdd = Convert.ToUInt16(Console.ReadLine());
            dayAdd = (ushort)(dayAdd % 400 == 0 || dayAdd % 4 == 0 && !(dayAdd % 100 == 0) ? 1 : 0);//4.1(hw)
            if (dayAdd == 1)
            {
                Console.WriteLine("Введенный год високосный");
                dayMonths[2]++;
            }
            else
            {
                Console.WriteLine("Введенный год невисокосный");
            }
            Console.Write("Введите порядковый номер дня в текущем году: ");//4.1
            int day; bool flag = true;
            while (flag)
            {
                day=Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 365 + dayAdd)//4.2
                {
                    Console.WriteLine("n не может принимать данное значение. Введите другой номер: ");
                }
                else
                {
                    int numMounth = 0;
                    while (day > dayMonths[numMounth])
                    {
                        day -= dayMonths[numMounth];
                        numMounth++;
                    }
                    Console.WriteLine($"Текущая дата в данном году: {day}{(Mounth)numMounth}");
                    flag = false;
                }

            }

            Console.ReadKey();
        }
    }
}
