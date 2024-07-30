/* Напишите функцию в ООП стиле, принимающую в качестве параметра целое число и
возвращающую название дня недели по этому номеру. А в случае если параметр
некорректен (не попадает в диапазон [1-7]), возвращающую строку «Нет такого дня недели!».
*/
using System;
using System.Collections.Generic;

public class Day
{
    private Dictionary<int, string> days = new Dictionary<int, string>()
    {
        {1, "Понедельник" },
        {2, "Вторник" },
        {3, "Среда" },
        {4, "Четверг" },
        {5, "Пятница" },
        {6, "Суббота" },
        {7, "Воскресение" },
    };

    private string dayName;

    public Day(int dayNumber)
    {
        if (dayNumber > 0 && dayNumber <= 7)
        {
            this.dayName = days[dayNumber];
            PrintDayName(dayNumber);
        }
        else
        {
            Console.WriteLine("Нет такого дня недели!");
        }
    }

    private void PrintDayName(int dayNumber)
    {
        Console.WriteLine($"День с номером {dayNumber}: {this.dayName}");
    }
}

public class Program
{
    static void Main()
    {
        Day userDay1 = new Day(0); // Нет такого дня недели!
        Day userDay2 = new Day(4); // День с номером 4: Четверг
        Day userDay3 = new Day(1); // День с номером 1: Понедельник
        Day userDay4 = new Day(9); // Нет такого дня недели!
    }
}
