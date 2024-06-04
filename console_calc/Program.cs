using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float first_number, second_number, result;
            char sign; //знак действия

            while (true)
            {
                Console.WriteLine("Введите первое число, затем знак действия(+,-,*,/) и второе число.");
                Console.Write("Введите первое число: ");
                first_number = Convert.ToSingle(Console.ReadLine()); //Возвращает число с плавающей запятой одиночной точности
                Console.Write("Введите знак действия : ");
                sign = Convert.ToChar(Console.ReadLine()); //Возвращает символ
                Console.Write("Введите Второе число: ");
                second_number = Convert.ToSingle(Console.ReadLine());
                if (sign == '+')
                {
                    result = first_number + second_number;
                    Console.WriteLine("Сумма ваших чисел равна " + result + "\n");
                    //Console.ReadKey(); //чтобы консоль не закрывалась сразу после завершения вычислений
                }
                else if (sign == '-')
                {
                    result = first_number - second_number;
                    Console.WriteLine("Разность ваших чисел равна " + result + "\n");
                }
                else if (sign == '*')
                {
                    result = first_number * second_number;
                    Console.WriteLine("Произведение ваших чисел равно " + result + "\n");
                }
                else if (sign == '/')
                {
                    if (second_number == 0)
                    {
                        Console.WriteLine("Ошибка. Делитель не может быть равным нулю.");
                    }
                    else
                    {
                        result = first_number / second_number;
                        Console.WriteLine("Частное ваших чисел равна " + result + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка. Вы ввели неверный знак.");
                }
            }
        }
    }
}
