

using System;
using System.Diagnostics;

public class Result<T>
{
    public T Value { get; }
    public bool IsSuccess { get; }
    public string Error { get; }

    public Result(T value)
    {
        Value = value;
        IsSuccess = true;
    }

    public Result(string error)
    {
        Error = error;
        IsSuccess = false;
    }
}

public class Calculator
{
    public Result<double> DivideWithResult(double numerator, double denominator)
    {
        if (denominator == 0)
        {
            return new Result<double>("Деление на ноль невозможно.");
        }
        return new Result<double>(numerator / denominator);
    }

    public double DivideWithException(double numerator, double denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Деление на ноль невозможно.");
        }
        return numerator / denominator;
    }
}

class Program
{
    static void Main()
    {
        var calculator = new Calculator();
        const int iterations = 1_000_000; // Количество операций


        // Тест с использованием Result<T>
        Stopwatch stopwatchResult = Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++)
        {
            var result = calculator.DivideWithResult(10, i % 2 == 0 ? 1 : 0); // Делим на 1 или 0
            if (!result.IsSuccess)
            {
                // Игнорируем ошибки
            }
        }
        stopwatchResult.Stop();
        Console.WriteLine($"Время выполнения с использованием Result<T>: {stopwatchResult.ElapsedMilliseconds} мс");


        //Тест с использованием исключений
        Stopwatch stopwatchException = Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++)
        {
            try
            {
                var result = calculator.DivideWithException(10, i % 2 == 0 ? 1 : 0); // Делим на 1 или 0
            }
            catch (DivideByZeroException)
            {
                // Игнорируем ошибки
            }

        }
        stopwatchException.Stop();
        Console.WriteLine($"Время выполнения с использованием исключений: {stopwatchException.ElapsedMilliseconds} мс");

        Console.WriteLine($"\tДольше в {stopwatchException.ElapsedMilliseconds/ stopwatchResult.ElapsedMilliseconds} раз");
    }
}
