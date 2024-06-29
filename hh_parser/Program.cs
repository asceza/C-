using HtmlAgilityPack;
using System;
using System.IO;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace SimpleHHParsing
{
    public class Program
    {

        async public static void SaveResponseToFile(string request, string title, string amount)
        {
            string filename = "output.txt";

            // флаг true указывает на добавление в файл, а не перезапись
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                await writer.WriteLineAsync($"{request};{title};{amount}");
            }
        }

        public static void Main(string[] args)
        {
            string textRequest = args[0].Replace(" ", "%20").Replace("#", "%23").Replace("+", "%2B").Replace(".", "%2E");
            // целевая страница со статическим контентом
            string url = "https://spb.hh.ru/search/vacancy?&text=" + textRequest + "&area=2";

            // экземпляр класса HtmlWeb позволяет загрузить веб-страницу благодаря своему методу Load().
            // под капотом этот метод выполняет запрос HTTP GET для получения HTML-документа по URL адресу,
            // затем Load() возвращает экземпляр HtmlAgilityPack HtmlDocument,
            // который можно использовать для выбора элементов HTML на странице
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);

            // метод SelectSingleNode() можно вызвать только для экземпляра HtmlNode.
            // поэтому требуется получить корневой узел HTML-документа с помощью свойства DocumentNode
            // статическая функции HtmlEntity.DeEntitize() используется для замены специальных символов HTML
            // на их естественные представления.  
            HtmlNode amountNode = document.DocumentNode.SelectSingleNode("//*[@id=\"HH-React-Root\"]/div/div/div[1]/div[3]/div[1]/div[1]/div[1]/div/div/div[2]/h1/text()[1]");
            HtmlNode titleNode = document.DocumentNode.SelectSingleNode("//*[@id=\"HH-React-Root\"]/div/div/div[1]/div[3]/div[1]/div[1]/div[1]/div/div/div[2]/h1/text()[2]");

            Console.Write(textRequest);
            Console.Write($"\t{HtmlEntity.DeEntitize(titleNode.InnerText)}");
            Console.Write($"\t{HtmlEntity.DeEntitize(amountNode.InnerText)}");

            SaveResponseToFile(textRequest, HtmlEntity.DeEntitize(titleNode.InnerText), HtmlEntity.DeEntitize(amountNode.InnerText));


        }
    }
}
