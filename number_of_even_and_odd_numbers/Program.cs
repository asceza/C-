using System;

namespace numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число: ");
            uint limit = uint.Parse(Console.ReadLine());
            uint evenNumCount = 0, oddNumCount = 0, evenNumSum = 0, oddNumSum = 0;
            for (uint i = 1; i <= limit; i++)
            {
                //Console.Write(i + " ");
                if (i % 2 == 0)
                {
                    evenNumCount++;
                    evenNumSum += i;
                }
                else
                {
                    oddNumCount++;
                    oddNumSum += i;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Четные: {evenNumCount} шт, сумма четных чисел от 1 до {limit} = {evenNumSum}");
            Console.WriteLine($"Нечетные: {oddNumCount} шт, сумма нечетных чисел от 1 до {limit} = {oddNumSum}");
            Console.ReadLine();
        }
    }
}
