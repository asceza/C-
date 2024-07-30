/* Напишите функцию в ООП стиле, принимающую в качестве параметра целое число, и возвращающую строковое значение по следующему алгоритму:  
- если параметр кратен 3, функция возвращает слово «Three»;  
- если параметр кратен 5, функция возвращает слово «Five»;  
- если параметр одновременно кратен и 3, и 5, то функция возвращает строку «Fifteen»;  
- если параметр не удовлетворяет ни одному из вышеописанных условий, то функция  
возвращает сам параметр.
using System;
*/
public class Number
{
    private string divider;
    public Number(int num)
    {
        if (num % 3 != 0 && num % 5 != 0)
        {
            Console.WriteLine($"{num}");
            return;
        }
        else if (num % 3 == 0 && num % 5 == 0)
        {
            this.divider = "Fifteen";
        }
        else if (num % 3 == 0)
        {
            this.divider = "Three";
        }
        else if (num % 5 == 0)
        {
            this.divider = "Five";
        }
        PrintDivider();
    }

    private void PrintDivider()
    {
        Console.WriteLine(this.divider);
    }
}

public class Program
{
    static void Main()
    {
        Number number1 = new Number(4);  // 4
        Number number2 = new Number(10); // Five
        Number number3 = new Number(12); // Three
        Number number4 = new Number(15); // Fifteen
        Number number5 = new Number(25); // Five
        Number number6 = new Number(30); // Fifteen
        Number number7 = new Number(31); // 31
    }
}
