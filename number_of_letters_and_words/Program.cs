using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        try // перехватываем исключение
        {
            // открываем текстовый файл для чтения
            // путь ...\bin\Debug\text.txt
            string filePath = "text.txt";
            string text = File.ReadAllText(filePath);

            // словарь хранит объекты, которые представляют пару ключ-значение.
            // класс словаря Dictionary<K, V> типизируется двумя типами:
            // параметр K представляет тип ключей, а параметр V предоставляет тип значений.
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // подсчитываем количество каждого символа в тексте
            foreach (char c in text) // перебираем все символы строки (фактически строка == коллекция символов) в цикле
            {
                // проверяет наличие элемента с определенным ключом и возвращает true при его наличии в словаре
                if (charCount.ContainsKey(c))
                {
                    // если ключ уже присутствует в словаре -> инкременируем значение у соответствующего ключа
                    charCount[c]++;
                }
                else
                {
                    // если ключа нет в словаре (== первое вхождение символа)
                    // -> значение у ключа = 1
                    charCount[c] = 1;
                }
            }

            // подсчитываем количество слов в тексте
            // метод String.Split создает массив подстрок, разбивая входную строку по одному или нескольким разделителям
            // для несколькиз разделителей нужно создать массив символов
            // как правило является самым простым способом разделить строку по границам слов
            // необязательный параметр StringSplitOptions.RemoveEmptyEntries
            // позволяет исключить из возвращаемого массива все пустые строки
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            
            // общее число элементов в массиве
            int wordCount = words.Length;

            // вывод результатов на экран
            Console.WriteLine("Статистика символов:");

            // итерация в цикле по парам (ключ, значение)
            foreach (var pair in charCount)
            {
                // в случае наличия управляющих символов
                if (pair.Key == '\n') 
                {
                    // Console.Write($"({(int)pair.Key}) - "); // вывод номера символа
                    // Console.WriteLine($"Символ 'перенос строки': {pair.Value} шт");
                    Console.WriteLine($"перенос строки;{pair.Value}");
                    //continue;
                }
                if (pair.Key == '\r') 
                {
                    // Console.Write($"({(int)pair.Key}) - "); // вывод номера символа
                    // Console.WriteLine($"Символ 'возврат каретки': {pair.Value} шт");
                    Console.WriteLine($"возврат каретки;{pair.Value}");
                    continue;
                }
                if (pair.Key == '\t') 
                {
                    // Console.Write($"({(int)pair.Key}) - "); // вывод номера символа
                    // Console.WriteLine($"Символ 'табуляции': {pair.Value} шт");
                    Console.WriteLine($"табуляция;{pair.Value}");
                    continue;
                }
                if (pair.Key == ' ')
                {
                    // Console.Write($"({(int)pair.Key}) - "); // вывод номера символа
                    // Console.WriteLine($"Символ 'пробел': {pair.Value} шт");
                    Console.WriteLine($"пробел;{pair.Value}");

                    continue;
                }

                // в ином случае
                else
                {
                    //Console.Write($"({(int)pair.Key}) - "); // вывод номера символа
                    //Console.WriteLine($"Символ '{pair.Key}': {pair.Value} шт");
                    Console.WriteLine($"{pair.Key};{pair.Value}");

                }
            }

            Console.WriteLine($"\nОбщее количество слов в тексте: {wordCount}");

            WordInText("берёза", text);
        }
        catch (Exception ex) // обработка исключения
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        //--------------------------------------------------------------------
        // количество конкретных слов в тексте
        void WordInText(string word, string text)
        {
            // инициализируем новый экземпляр Regex
            // регулярным выражением выступает переданное слово word
            // обращаемся к значению Count из коллекции Matches
            int amount = new Regex(word).Matches(text).Count;
            Console.WriteLine($"\nСлово /{word}/ содержится в тексте {amount} раза");
        }
        //--------------------------------------------------------------------

        Console.ReadKey();
    }



}
